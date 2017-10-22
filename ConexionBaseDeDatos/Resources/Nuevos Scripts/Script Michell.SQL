#En este archivo de texto sólo Michell deberá meter sus procedimientos almacenados

DROP TRIGGER IF EXISTS `TriggVentaDevuelta`;
CREATE DEFINER = 'root'@'%' TRIGGER `TriggVentaDevuelta`
  AFTER DELETE ON `Ventas`
  FOR EACH ROW
BEGIN
  UPDATE `Pedido` SET `RestantePagar` = `RestantePagar` + OLD.`Importe`, `Pedido`.`Pagado` = IF(`RestantePagar` + OLD.`Importe` > 0, 'NO', 'SI') WHERE `Pedido`.`IDPedido` = OLD.`IDPedido`;
END;


DROP TRIGGER IF EXISTS `TriggActualizarPedido`;
CREATE DEFINER = 'root'@'%' TRIGGER `TriggActualizarPedido`
  AFTER INSERT ON `Ventas`
  FOR EACH ROW
BEGIN
  IF (SELECT `Pedido`.`RestantePagar` FROM `Pedido` WHERE `Pedido`.`IDPedido` = NEW.`IDPedido` LIMIT 1) = NEW.`Importe` THEN
    UPDATE `Pedido` SET `Pagado` = 'SI';
  END IF;
  UPDATE `Pedido` SET `RestantePagar` = `RestantePagar` - NEW.`Importe` WHERE `IDPedido` = NEW.`IDPedido`;
END;


DROP VIEW IF EXISTS `DetalleVentas`;
CREATE
  VIEW `DetalleVentas`
  AS
(SELECT
  `Ventas`.`IDVenta`,
  `Ventas`.`FechaPago`,
  `Ventas`.`IDPedido`,
  CONCAT(`Usuario`.`Nombre`, ' ', `Usuario`.`Apellidos`) AS 'RegistraVenta',
  `Ventas`.`Importe`,
  `Ventas`.`PersonaPaga` AS 'Referencia',
  `Ventas`.`FormaPago`
FROM
  `Ventas`,
  `Usuario`
WHERE
  `Ventas`.`Login` = `Usuario`.`Login`);

  
DROP PROCEDURE IF EXISTS `BuscarPedidosNoPagados`;
CREATE DEFINER=`root`@`%` PROCEDURE `BuscarPedidosNoPagados`(
  IDPedid char(10),
  Empleado char(100),
  Dentista char(100),
  FechaMin datetime,
  FechaMax datetime,
  Urgente bool,
  NoPagado bool
)
BEGIN
  SELECT
    *
  FROM
    `Pedido`,
    `Usuario`,
    `Dentista`
  WHERE
    `Pedido`.`IDEmpleado` = `Usuario`.`Login`
      AND `Pedido`.`Cedula` = `Dentista`.`Cedula`
      AND `IDPedido` = IFNULL(IDPedid, `IDPedido`)
      AND CONCAT(`Usuario`.`Nombre`, ' ', `Usuario`.`Apellidos`) LIKE IFNULL(CONCAT(Empleado, '%'), CONCAT(`Usuario`.`Nombre`, ' ', `Usuario`.`Apellidos`))
      AND CONCAT(`Dentista`.`Nombre`, ' ', `Dentista`.`Apellidos`) LIKE IFNULL(CONCAT(Dentista, '%'), CONCAT(`Dentista`.`Nombre`, ' ', `Dentista`.`Apellidos`))
      AND `Pedido`.`FechaIngreso` >= IFNULL(FechaMin, `Pedido`.`FechaIngreso`)
      AND `Pedido`.`FechaIngreso` <= IFNULL(FechaMax, `Pedido`.`FechaIngreso`)
      AND `Pedido`.`Urgencia` = IF(Urgente = 1, '1', `Pedido`.`Urgencia`)
      AND `Pedido`.`Pagado` = IF(NoPagado = 1, 'NO', `Pedido`.`Pagado`);
END;
  
  
DROP PROCEDURE IF EXISTS `DevolucionPago`;
CREATE DEFINER=`root`@`%` PROCEDURE `DevolucionPago`(IDVent int)
BEGIN
  DELETE FROM `Ventas` WHERE `Ventas`.`IDVenta` = IDVent;
END;


DROP PROCEDURE IF EXISTS `InsertarVenta`;
CREATE DEFINER = 'root'@'%' PROCEDURE `InsertarVenta`(
  IDPedid char(30),
  Importee decimal(10,2),
  Recibid decimal(10,2),
  FechaPag datetime,
  Logi char(30),
  PersonaPag char(20),
  FormaPag char(10)
)
BEGIN
  INSERT
    INTO `Ventas`
    (`IDPedido`, `Importe`, `Recibido`, `FechaPago`, `Login`, `PersonaPaga`, `FormaPago`)
  VALUES
    (IDPedid, Importee, Recibid, FechaPag, Logi, PersonaPag, FormaPag);
END;


DROP PROCEDURE IF EXISTS `ObtenerMateriales`;
CREATE DEFINER=`root`@`%` PROCEDURE `ObtenerMateriales`()
BEGIN
  SELECT * FROM `material`;
END;


DROP PROCEDURE IF EXISTS `ObtenerPedidos`;
CREATE DEFINER=`root`@`%` PROCEDURE `ObtenerPedidos`()
BEGIN
  SELECT * FROM `pedido`;
END;


DROP PROCEDURE IF EXISTS `ObtenerPermisoAdministrador`;
CREATE DEFINER=`root`@`%` PROCEDURE `ObtenerPermisoAdministrador`(pass varchar(30))
BEGIN
  SELECT
    `Password` AS 'result'
  FROM
    `Usuario`
  WHERE
    `Password` = pass
      AND `Puesto` = 'ADMINISTRADOR'
      AND `Departamento` = 'ADMINISTRACION'
      AND `Activo` = '1';
END;


DROP PROCEDURE IF EXISTS `ObtenerProductos`;
CREATE DEFINER=`root`@`%` PROCEDURE `ObtenerProductos`()
BEGIN
  SELECT * FROM `producto`;
END;


DROP PROCEDURE IF EXISTS `RecuperarDentista`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarDentista`(Cedul char(10))
BEGIN
  SELECT * FROM `dentista` WHERE `Cedula` = Cedul;
END;


DROP PROCEDURE IF EXISTS `RecuperarMaterial`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarMaterial`(IDMateria int)
BEGIN
  SELECT * FROM `material` WHERE `IDMaterial` = IDMateria;
END;


DROP PROCEDURE IF EXISTS `RecuperarPedido`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarPedido`(IDPedid char(10))
BEGIN
  SELECT * FROM `pedido` WHERE `IDPedido` = IDPedid;
END;


DROP PROCEDURE IF EXISTS `RecuperarProducto`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarProducto`(IDProduct int)
BEGIN
  SELECT * FROM `producto` WHERE `IDProducto` = `IDProduct`;
END;


DROP PROCEDURE IF EXISTS `RecuperarProveedor`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarProveedor`(Proveedo int)
BEGIN
  SELECT * FROM `proveedores` WHERE `IDProveedor` = Proveedo;
END;


DROP PROCEDURE IF EXISTS `RecuperarTicket`;
CREATE DEFINER = 'root'@'%' PROCEDURE `RecuperarTicket`(IDVent int)
BEGIN
  DECLARE _Pedido char(10) DEFAULT NULL;
  DECLARE _Fecha datetime DEFAULT NULL;
  DECLARE _Importe decimal(10,2) DEFAULT NULL;
  SET _Pedido = (SELECT `Ventas`.`IDPedido` FROM `Ventas` WHERE `IDVenta` = IDVent);
  SET _Fecha = (SELECT `FechaPago` FROM `Ventas` WHERE `IDVenta` = IDVent);
  SET _Importe = (SELECT SUM(`Ventas`.`Importe`) FROM `Ventas` WHERE `IDPedido` = _Pedido AND `Ventas`.`FechaPago` <= _Fecha);
  SELECT
    `Ventas`.`IDVenta`,
    `Ventas`.`FechaPago`,
    `Ventas`.`IDPedido`,
    `Usuario`.`Nombre`,
    `Ventas`.`Importe`,
    `Ventas`.`Recibido`,
    `Ventas`.`Recibido` - `Ventas`.`Importe` AS 'Cambio',
    `Ventas`.`PersonaPaga` AS 'Referencia',
    CONVERT(`Pedido`.`CostoTotal` - _Importe, decimal(10,2)) AS 'Restante'
  FROM
    `Ventas`,
    `Usuario`,
    `Pedido`
  WHERE
    `Ventas`.`Login` = `Usuario`.`Login` AND `Pedido`.`IDPedido` = `Ventas`.`IDPedido` AND `Ventas`.`IDVenta` = IDVent;
END;


DROP PROCEDURE IF EXISTS `RecuperarTrabajos`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarTrabajos`(IDPedid char(10))
BEGIN
  SELECT * FROM `producto_pedido` WHERE `IDPedido` = IDPedid;
END;


DROP PROCEDURE IF EXISTS `UltimoCorteCaja`;
CREATE DEFINER=`root`@`%` PROCEDURE `UltimoCorteCaja`()
BEGIN
  SELECT * FROM `CorteCaja` ORDER BY `FolioCorte` DESC LIMIT 1;
END;


DROP PROCEDURE IF EXISTS `VerVentas`;
CREATE DEFINER=`root`@`%` PROCEDURE `VerVentas`(
  IDVent int,
  FechaPagoMin date,
  FechaPagoMax date,
  IDPedid char(10),
  Nombre char(100),
  Referenci char(10),
  Efectivo bool,
  Tarjeta bool,
  Cheque bool
)
BEGIN
  SELECT
    *
  FROM
    `Detalleventas`
  WHERE
    `IDVenta` = IF(IDVent != 0, IDVent, `IDVenta`)
      AND `FECHAPAGO` >= IFNULL(FECHAPAGOMIN, `FECHAPAGO`)
      AND `FECHAPAGO` <= IFNULL(FECHAPAGOMAX, `FECHAPAGO`)
      AND `IDPEDIDO` = IFNULL(IDPEDID, `IDPEDIDO`)
      AND `REGISTRAVENTA` LIKE IFNULL(CONCAT(NOMBRE, '%'), `REGISTRAVENTA`)
      AND `REFERENCIA` LIKE IFNULL(CONCAT(REFERENCI, '%'), `REFERENCIA`)
      AND (`FORMAPAGO` = IF(EFECTIVO = 1, 'EFECTIVO', '') OR `FORMAPAGO` = IF(TARJETA = 1, 'TARJETA', '') OR `FORMAPAGO` = IF(CHEQUE = 1, 'CHEQUE', ''));
END;