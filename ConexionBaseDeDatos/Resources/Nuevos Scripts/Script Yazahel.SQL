#En este archivo de texto sólo Yazahel deberá meter sus procedimientos almacenados
CREATE TABLE IF NOT EXISTS `nomina` (
  `Fecha` date,
  `N_empleado` int NOT NULL,
  `Nombre` varchar(100),
  `Apellidos` varchar(100),
  `RCF` varchar(20),
  `Email` varchar(100),
  `Departamento` varchar(50),
  `Puesto` varchar(100),
  `DiasLaborados` varchar(20),
  `Sueldo` decimal(10,2),
  `ISR` decimal(10,2),
  `DescuentoISR` decimal(10,2),
  `SueldoFinal` decimal(10,2),
  `pagado` int(1)
);

CREATE TABLE IF NOT EXISTS `BalanceCuentasIngresos` (
  `Descripcion` varchar(100),
  `Valor` decimal(10,2)
);

CREATE TABLE IF NOT EXISTS `BalanceCuentasEgresos` (
  `Descripcion` varchar(100),
  `Valor` decimal(10,2)
);

CREATE TABLE IF NOT EXISTS `insumos` (
  `IDInsumos` int(11) NOT NULL AUTO_INCREMENT,
  `IDProveedor` int(11) DEFAULT NULL,
  `Nombre` char(30) DEFAULT NULL,
  `Descripcion` char(50) DEFAULT NULL,
  `PrecioBase` decimal(10,2) DEFAULT NULL,
  `PrecioCompra` decimal(10,2) DEFAULT NULL,
  `UnidadMedida` char(50) DEFAULT NULL,
  `CantidadDisponible` int(11) DEFAULT NULL,
  `CantidadSolicitada` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDInsumos`)
);

DROP PROCEDURE IF EXISTS `FinanzasVentasGeneradas`;
CREATE PROCEDURE `FinanzasVentasGeneradas`(fec char(10))
BEGIN
  SELECT
    `IDPedido`,
    `Importe`,
    `FechaPago` AS 'Fecha de Pago',
    `Login` AS 'Usuario',
    `PersonaPaga` AS 'Cliente',
    `FormaPago` AS 'Forma de Pago'
  FROM
    `ventas`
  WHERE
    `FechaPago` LIKE `fec`
  ORDER BY `FechaPago` DESC;
END;

DROP PROCEDURE IF EXISTS `FinanzasBusquedaVentasGeneradas`;
CREATE PROCEDURE `FinanzasBusquedaVentasGeneradas`(logi char(50), idp int(5))
BEGIN
  SELECT
    `IDPedido`,
    `Importe`,
    `FechaPago` AS 'Fecha de Pago',
    `Login` AS 'Usuario',
    `PersonaPaga` AS 'Cliente',
    `FormaPago` AS 'Forma de Pago'
  FROM
    `ventas`
  WHERE
    `login` LIKE logi OR `IDpedido` LIKE idp
  ORDER BY `FechaPago` DESC;
END;

DROP PROCEDURE IF EXISTS `FinanzasBuscarAdminPagos`;
CREATE PROCEDURE `FinanzasBuscarAdminPagos`(idp char(5), nomb int(50))
BEGIN
  SELECT
    `IDPago`,
    `Nombre`,
    `Descripcion`,
    `Cantidad`,
    `PrecioUnitario`,
    `Subtotal`,
    `Total`,
    CASE `Estado` WHEN 1 THEN 'PENDIENTE' WHEN 2 THEN 'EN PROCESO' WHEN 3 THEN 'PAGADO' END AS 'Estado',
    IF(`Registro` = 0, 'NO', 'SÍ') AS 'Registrado'
  FROM
    `pagos`
  WHERE
    `IDPago` LIKE idp OR `Nombre` LIKE nomb;
END;

DROP PROCEDURE IF EXISTS `FinanzasAgregarCompra`;
CREATE PROCEDURE `FinanzasAgregarCompra`(Nomb char(50), tot numeric(10,2))
BEGIN
  INSERT IGNORE
    INTO `Compras`
    (`Empleado`, `Total`, `Fecha`, `Tipo`, `FechaSurtido`, `Estado`, `Registro`)
  VALUES
    ('YAZAH', `tot`, CURDATE(), 'INSUMOS', CURDATE(), 'PENDIENTE', 1);
END;

DROP PROCEDURE IF EXISTS `FinanzasGastosGenerados`;
CREATE PROCEDURE `FinanzasGastosGenerados`(fec char(10))
BEGIN
  SELECT
  `IDCompra`,
  `Empleado`,
  `Total`,
  `Fecha`,
  `Tipo`,
  `estado`
FROM
  `compras`
  WHERE
    `Fecha` LIKE `fec`
  ORDER BY `Fecha` DESC;
END;

DROP PROCEDURE IF EXISTS `FinanzasPagoEmpleados`;
CREATE PROCEDURE `FinanzasPagoEmpleados`()
BEGIN
  SELECT
    `IDPago`,
    `FechaPago`,
    `Empleado`,
    `Cantidad`,
    `SemanaPago`,
    `AñoPago`
  FROM
    `pagoempleados`
  ORDER BY `FechaPago` DESC;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerUsuarios`;
CREATE PROCEDURE `FinanzasObtenerUsuarios`()
BEGIN
  SELECT DISTINCT `Login` FROM `usuario`;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerProveedor`;
CREATE PROCEDURE `FinanzasObtenerProveedor`(id char(10))
BEGIN
  SELECT DISTINCT
    `proveedores`.`Nombre`
  FROM
    `proveedores`,
    `detalle_compra_insumo`
  WHERE
    `detalle_compra_insumo`.`IDCompra` = `id` AND `detalle_compra_insumo`.`IDProveedor` = `proveedores`.`IDProveedor`;
END;


DROP PROCEDURE IF EXISTS `FinanzasListaProveedor`;
CREATE PROCEDURE `FinanzasListaProveedor`()
BEGIN
  SELECT DISTINCT `Nombre` FROM `proveedores` ORDER BY `IDProveedor`;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerUltimoIDCompras`;
CREATE PROCEDURE `FinanzasObtenerUltimoIDCompras`()
BEGIN
  SELECT MAX(`IDCompra`) FROM `compras`;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerDatosNombreUsuarios`;
CREATE PROCEDURE `FinanzasObtenerDatosNombreUsuarios`(id char(10))
BEGIN
  SELECT DISTINCT CONCAT(`Nombre`, ' ', `Apellidos`) AS 'Empleado' FROM `usuario` WHERE `N_Empleado` = id;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerIDProveedores`;
CREATE PROCEDURE `FinanzasObtenerIDProveedores`(nomb char(100))
BEGIN
  SELECT DISTINCT `IDProveedor` FROM `proveedores` WHERE `Nombre` = nomb;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerBanco`;
CREATE PROCEDURE `FinanzasObtenerBanco`(nomb char(100))
BEGIN
  SELECT DISTINCT `Banco` FROM `proveedores` WHERE `Nombre` = nomb;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerNumeroCuenta`;
CREATE PROCEDURE `FinanzasObtenerNumeroCuenta`(nomb char(100))
BEGIN
  SELECT DISTINCT `NumeroCuenta` FROM `proveedores` WHERE `Nombre` = nomb;
END;

DROP PROCEDURE IF EXISTS `FinanzasVerProductosDeProveedor`;
CREATE PROCEDURE `FinanzasVerProductosDeProveedor`(id char(10))
BEGIN
SELECT DISTINCT
  `IDInsumos`,
  `Nombre`,
  `Descripcion`,
  `PrecioCompra` AS 'Precio',
  `UnidadMedida`,
  `CantidadDisponible`
FROM
  `insumos`
WHERE
  `IDProveedor` = id
ORDER BY `IDInsumos` ASC;
END;

DROP PROCEDURE IF EXISTS `FinanzasVerRequisicionInsumos`;
CREATE PROCEDURE `FinanzasVerRequisicionInsumos`(id char(10))
BEGIN
  SELECT * FROM `detalle_compra_insumo` WHERE `IDCompra` = id;
END;

DROP PROCEDURE IF EXISTS `FinanzasObtenerIDUsuarios`;
CREATE PROCEDURE `FinanzasObtenerIDUsuarios`()
BEGIN
 SELECT DISTINCT `N_Empleado` FROM `usuario` ORDER BY `N_Empleado` ASC;
END;

DROP PROCEDURE IF EXISTS `FinanzasComprarInsumos`;
CREATE PROCEDURE `FinanzasComprarInsumos`(
  id int(11),
  Nombre char(50),
  Descripcion char(70),
  Cantidad int(11),
  PrecioUnitario numeric(10,2),
  IdProveedor int(11)
)
BEGIN
  INSERT IGNORE
    INTO `Detalle_Compra_Insumo`
    (`IDCompra`, `Nombre`, `Descripcion`, `Cantidad`, `PrecioUnitario`, `Subtotal`, `IDProveedor`)
  VALUES
    (`id`, `Nombre`, `Descripcion`, `Cantidad`, `PrecioUnitario`, `Cantidad` * `PrecioUnitario`, `IdProveedor`);
END;
DROP PROCEDURE IF EXISTS `FinanzasVerComprarInsumos`;
CREATE PROCEDURE `FinanzasVerComprarInsumos`()
BEGIN
  SELECT
  `compras`.`IDCompra`,
  `proveedores`.`IDProveedor`,
  `proveedores`.`nombre` AS 'Proveedores',
  `Empleado`,  
  `Tipo`,
  `detalle_compra_insumo`.`Nombre` AS 'Nombre Insumo',
  `detalle_compra_insumo`.`Descripcion`,
  `Fecha`,
  `FechaSurtido`,
  `PrecioUnitario`,
  `Cantidad`,
  `Subtotal`,
  `Total`
FROM
  `compras`,
  `detalle_compra_insumo`,
  `proveedores`
WHERE
  `compras`.`Tipo` = 'INSUMOS' AND `compras`.`IDCompra` = `detalle_compra_insumo`.`IDCompra` AND `detalle_compra_insumo`.`IDProveedor` = `Proveedores`.`IDProveedor` 
ORDER BY `IDCompra`;
END;

DROP PROCEDURE IF EXISTS `FinanzasTotalVentas`;
CREATE PROCEDURE `FinanzasTotalVentas`()
BEGIN
  SELECT SUM(`importe`) FROM `ventas`;
END;

DROP PROCEDURE IF EXISTS `FinanzasTotalGastos`;
CREATE PROCEDURE `FinanzasTotalGastos`()
BEGIN
  SELECT SUM(`Total`) FROM `compras` WHERE `Estado` = 'PENDIENTE';
END;

DROP PROCEDURE IF EXISTS `FinanzasTotalInsumos`;
CREATE PROCEDURE `FinanzasTotalInsumos`()
BEGIN
  SELECT
    SUM(`Total`)
  FROM
    `compras`,
    `detalle_compra_insumo`
  WHERE
    `compras`.`Tipo` = 'INSUMOS' AND `compras`.`IDCompra` = `detalle_compra_insumo`.`IDCompra`;
END;

DROP PROCEDURE IF EXISTS `FinanzasPagos`;
CREATE PROCEDURE `FinanzasPagos`()
BEGIN
  SELECT
    `IDPago`,
    `Nombre`,
    `Descripcion`,
    `Cantidad`,
    `PrecioUnitario`,
    `Subtotal`,
    `Total`,
    CASE `Estado` WHEN 1 THEN 'PENDIENTE' WHEN 2 THEN 'EN PROCESO' WHEN 3 THEN 'PAGADO' END AS 'Estado',
    IF(`Registro` = 0, 'NO', 'SÍ') AS 'Registrado',
	IDCompra
  FROM
    `pagos`;
END;

DROP PROCEDURE IF EXISTS `RHumanosTotalPagoEmp`;
CREATE PROCEDURE `RHumanosTotalPagoEmp`()
BEGIN
  SELECT SUM(`Cantidad`) FROM `pagoempleados`;
END;

DROP PROCEDURE IF EXISTS `FinanzasPagosPendientes`;
CREATE PROCEDURE `FinanzasPagosPendientes`()
BEGIN
  SELECT
    `IDPago`,
    `Nombre`,
    `Descripcion`,
    `Cantidad`,
    `PrecioUnitario`,
    `Subtotal`,
    `Total`,
	IF(`Registro` = 0, 'NO', 'SÍ') AS 'Registrado'
  FROM
    `pagos`
  WHERE
    `Estado` = 1;
END;

DROP PROCEDURE IF EXISTS `FinanzasPagosEnProceso`;
CREATE PROCEDURE `FinanzasPagosEnProceso`()
BEGIN
  SELECT
  `IDPago`,
  `Nombre`,
  `Descripcion`,
  `Cantidad`,
  `PrecioUnitario`,
  `Subtotal`,
  `Total`,
  IF(`Registro` = 0, 'NO', 'SÍ') AS 'Registrado'
FROM
  `pagos`
WHERE
  `Estado` = 2;
END;

DROP PROCEDURE IF EXISTS `FinanzasPagosPagados`;
CREATE PROCEDURE `FinanzasPagosPagados`()
BEGIN
  SELECT
    `IDPago`,
    `Nombre`,
    `Descripcion`,
    `Cantidad`,
    `PrecioUnitario`,
    `Subtotal`,
    `Total`,
	IF(`Registro` = 0, 'NO', 'SÍ') AS 'Registrado'
  FROM
    `pagos`
  WHERE
    `Estado` = 3;
END;

DROP PROCEDURE IF EXISTS `FinanzasRegistrarPago`;
CREATE PROCEDURE `FinanzasRegistrarPago`(
  Nom char(50),
  Des char(70),
  Preuni numeric(10,2),
  Cant int(11),
  Est int(1),
  Reg int(1),
  id int(11)
)
BEGIN
  INSERT IGNORE
  INTO `pagos`
  (`Nombre`, `Descripcion`, `PrecioUnitario`, `Cantidad`, `Subtotal`, `Total`, `Estado`, `Registro`, `Fecha`,IDCompra)
VALUES
  (`Nom`, `Des`, `Preuni`, `Cant`, `Cant` * `Preuni`, `Subtotal` + (`Subtotal` * 0.16), `Est`, `Reg`, CURDATE(),id);
END;

DROP PROCEDURE IF EXISTS `RHumanosRegistrarAsistencia`;
CREATE PROCEDURE `RHumanosRegistrarAsistencia`(
  id int(11),
  emp char(200),
  fec char(12),
  hEnt varchar(5),
  hSal varchar(5)
)
BEGIN
  INSERT IGNORE
    INTO `asistencia`
    (`IDEmpleado`, `Empleado`, `Fecha`, `HoraEntrada`, `HoraSalida`)
  VALUES
    (`id`, `emp`, `fec`, `hEnt`, `hSal`);
END;


DROP PROCEDURE IF EXISTS `FinanzasObtenerProveedores`;
CREATE PROCEDURE `FinanzasObtenerProveedores`()
BEGIN
  SELECT DISTINCT `nombre` FROM `proveedores`;
END;

DROP PROCEDURE IF EXISTS `FinanzasBalanceCuentasIngresos`;
CREATE PROCEDURE `FinanzasBalanceCuentasIngresos`(fec char(10))
BEGIN
  SELECT DISTINCT
    `FechaPago`, 'Venta' AS 'DESCRIPCIÓN', `importe` AS 'INGRESOS'
  FROM
    `ventas`
  WHERE
    `ventas`.`FechaPago` LIKE `fec`
  UNION
  SELECT DISTINCT
    `Fecha`, `descripcion`, `valor`
  FROM
    `balancecuentasingresos`
  WHERE
    `balancecuentasingresos`.`Fecha` LIKE `fec`
  UNION
  SELECT DISTINCT
  `Fecha`, CONCAT('Corte de caja de ', `Empleado`) AS 'Descripción', `EntradaEfectivo`
FROM
  `cortecaja`
  WHERE
    `cortecaja`.`fecha` LIKE `fec`
  UNION
  SELECT DISTINCT
    `Fecha`, 'TOTAL', (SELECT DISTINCT SUM(`ventas`.`Importe`) FROM `ventas`) + (SELECT DISTINCT SUM(`cortecaja`.`EntradaEfectivo`) FROM `cortecaja`)
  FROM
    `ventas`,
    `cortecaja`
  WHERE
    `cortecaja`.`fecha` LIKE `fec` AND `ventas`.`FechaPago` LIKE `fec`;
END;

DROP PROCEDURE IF EXISTS `FinanzasBalanceCuentasEgresos`;
CREATE PROCEDURE `FinanzasBalanceCuentasEgresos`(fec char(10))
BEGIN
  SELECT
    `Fecha`, `descripcion` AS 'DESCRIPCIÓN', `TOTAL` AS 'EGRESOS'
  FROM
    `pagos`
  WHERE
    `estado` = 3 AND `Fecha` LIKE `fec`
  UNION
  SELECT
    `Fecha`, `descripcion`, `valor`
  FROM
    `balancecuentasegresos`
  WHERE
    `Fecha` LIKE `fec`
  UNION
  SELECT
    `Fecha`, 'TOTAL', SUM(`TOTAL`)
  FROM
    `pagos`
  WHERE
    `estado` = 3 AND `Fecha` LIKE `fec`;
END;

DROP PROCEDURE IF EXISTS `FinanzasTotalIngresos`;
CREATE PROCEDURE `FinanzasTotalIngresos`()
BEGIN
  SELECT DISTINCT
  (SELECT SUM(`ventas`.`Importe`) FROM `ventas`) + (SELECT SUM(`cortecaja`.`ganancia`) FROM `cortecaja`) - (SELECT SUM(`pagos`.`Total`) FROM `pagos` WHERE `pagos`.`Estado` = 3) AS 'TOTAL'
FROM
  `ventas`,
  `cortecaja`,
  `pagos`;
END;

DROP PROCEDURE IF EXISTS `FinanzasActualizarEstado`;
CREATE PROCEDURE `FinanzasActualizarEstado`(
    `id` int(1)
)
BEGIN
  UPDATE
    `pagos`
  SET
    `Estado` = 3
  WHERE
    `IDPago` = id;
END;

DROP PROCEDURE IF EXISTS `FinanzasActualizarRegistroGastos`;
CREATE PROCEDURE `FinanzasActualizarRegistroGastos`(
    `id` int(11)
)
BEGIN
  UPDATE
    `compras`
  SET
    `registro` = 1
  WHERE
    `IDCompra` = id;
END;

DROP PROCEDURE IF EXISTS `RHumanosEmpleados`;
CREATE PROCEDURE `RHumanosEmpleados`()
BEGIN
  SELECT
  `N_empleado` AS 'Numero Empleado',
  `Nombre` AS 'Nombres',
  `Apellidos`,
  `RFC`,
  `Email`,
  `Departamento`,
  `Puesto`
FROM
  `usuario`
ORDER BY `DEPARTAMENTO` ASC;
END;

DROP PROCEDURE IF EXISTS `RHumanosTotalNomina`;
CREATE PROCEDURE `RHumanosTotalNomina`()
BEGIN
  SELECT SUM(`SueldoFinal`) FROM `nomina`;
END;

DROP PROCEDURE IF EXISTS `RHumanosNomina`;
CREATE PROCEDURE `RHumanosNomina`()
BEGIN
  SELECT
    `Fecha`,
    `N_empleado` AS 'Numero Empleado',
    `Nombre` AS 'Nombres',
    `Apellidos`,
    `RCF`,
    `Email`,
    `Departamento`,
    `Puesto`,
    `DiasLaborados` AS 'Dias Laborados',
    `Sueldo` AS 'Pago por día',
    `ISR`,
    `DescuentoISR` AS 'Descuento ISR',
    `SueldoFinal` AS 'Suedo',
    IF(`pagado` = 1, 'SI', 'NO') AS 'Registrado'
  FROM
    `nomina`
  ORDER BY `Fecha`;
END;

DROP PROCEDURE IF EXISTS `RHumanosAsistencia`;
CREATE PROCEDURE `RHumanosAsistencia`()
BEGIN
  SELECT * FROM `asistencia` ORDER BY `Fecha`;
END;

DROP PROCEDURE IF EXISTS `RHumanosAgregarNomina`;
CREATE PROCEDURE `RHumanosAgregarNomina`(
  fec date,
  nemp int,
  nomb varchar(100),
  ape varchar(100),
  rfc varchar(20),
  mail varchar(100),
  dep varchar(50),
  pues varchar(100),
  dlab varchar(20),
  suel decimal(10,2),
  isr decimal(10,2),
  descisr decimal(10,2),
  sfinal decimal(10,2),
  pag int(1)
)
BEGIN
  INSERT IGNORE
    INTO `nomina`
    (`Fecha`, `N_empleado`, `Nombre`, `Apellidos`, `RCF`, `Email`, `Departamento`, `Puesto`, `DiasLaborados`, `Sueldo`, `ISR`, `DescuentoISR`, `SueldoFinal`, `pagado`)
  VALUES
    (`fec`, `nemp`, `nomb`, `ape`, `rfc`, `mail`, `dep`, `pues`, `dlab`, `suel`, `isr`, `descisr`, `sfinal`, `pag`);
END;

DROP PROCEDURE IF EXISTS `FinanzasRegistrarPago`;
CREATE PROCEDURE `FinanzasRegistrarPago`(
  nom char(50),
  des char(70),
  punit decimal(10,2),
  cant int(11),
  subt decimal(10,2),
  tot decimal(15,2),
  est int(1),
  reg int(1),
  fec date
)
BEGIN
  INSERT IGNORE
    INTO `pagos`
    (`Nombre`, `Descripcion`, `PrecioUnitario`, `Cantidad`, `Subtotal`, `Total`, `Estado`, `Registro`, `Fecha`)
  VALUES
    (`nom`, `des`, `punit`, `cant`, `subt`, `tot`, `est`, `reg`,`fec`);
END;


DROP PROCEDURE IF EXISTS `FinanzasAgregaBalanceIngresos`;
CREATE PROCEDURE `FinanzasAgregaBalanceIngresos`(
  `des` varchar(100),
  `val` decimal(10,2)
)
BEGIN
  INSERT IGNORE
    INTO `FinanzasAgregaBalanceIngresos`
    (`Descripcion`, `Valor`)
  VALUES
    (`des`, `val`);
END;


DROP PROCEDURE IF EXISTS `FinanzasAgregaBalanceEgresos`;
CREATE PROCEDURE `FinanzasAgregaBalanceEgresos`(
  `des` varchar(100),
  `val` decimal(10,2)
)
BEGIN
  INSERT IGNORE
    INTO `FinanzasAgregaBalanceEgresos`
    (`Descripcion`, `Valor`)
  VALUES
    (`des`, `val`);
END;


#ModuloControlPedidos

DROP PROCEDURE IF EXISTS `ControlPedidosObtenerPedidos`;
CREATE PROCEDURE `ControlPedidosObtenerPedidos`()
BEGIN
  SELECT DISTINCT
    `IdPedido`,
    `pedido`.`Cedula`,
    CONCAT(`dentista`.`Nombre`, ' ', `dentista`.`Apellidos`) AS 'NombreDentista',
    `FechaIngreso` AS 'Llegada',
    `FechaCalculada` AS 'Calculada',
    IF(`Urgencia` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido',
    CASE `EstadoPedido`
      WHEN '0' THEN 'Cancelado'
      WHEN '1' THEN 'Registrado'
      WHEN '2' THEN 'Confirmado'
      WHEN '3' THEN 'En Proceso'
      WHEN '4' THEN 'Terminado'
      WHEN '5' THEN 'Facturado'
      WHEN '6' THEN 'Pagado'
    END AS 'Estado de Pedido',
    IF(`Laboratorista` = '', 'No asignado', `Laboratorista`) AS 'Laboratorista'
  FROM
    `pedido`,
    `dentista`
  WHERE
    `pedido`.`Cedula` = `dentista`.`Cedula`
  ORDER BY `Urgencia` DESC, `FechaCalculada`, `EstadoPedido` = '0', `EstadoPedido` = '5', `EstadoPedido` = '7', `EstadoPedido` = '6', `EstadoPedido` = '1', `EstadoPedido` = '2', `EstadoPedido` = '4' DESC;
END;

DROP PROCEDURE IF EXISTS `ControlPedidosObtenerLaboratoristas`;
CREATE PROCEDURE `ControlPedidosObtenerLaboratoristas`()
BEGIN
  SELECT DISTINCT `N_EMPLEADO` FROM `usuario` WHERE `PUESTO` = 'LABORATORISTA';
END;