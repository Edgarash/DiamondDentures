#En este archivo de texto sólo Michell deberá meter sus procedimientos almacenados


DROP TRIGGER IF EXISTS TriggActualizarPedido;
CREATE DEFINER=`root`@`%` trigger TriggActualizarPedido after insert on Ventas for each row
begin
update pedido set RestantePagar = RestantePagar - NEW.Importe Where IDPedido = New.IDPedido;
end;


DROP PROCEDURE IF EXISTS `InsertarVenta`;
CREATE DEFINER=`root`@`%` PROCEDURE `InsertarVenta`(
  IDPedid char(30),
  Importee decimal(10,2),
  FechaPag date,
  Logi char(30),
  PersonaPag char(20),
  FormaPag char(10)
)
BEGIN
  INSERT
    INTO `Ventas`
    (`IDPedido`, `Importe`, `FechaPago`, `Login`, `PersonaPaga`, `FormaPago`)
  VALUES
    (IDPedid, Importee, FechaPag, Logi, PersonaPag, FormaPag);
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


DROP PROCEDURE IF EXISTS `RecuperarTrabajos`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarTrabajos`(IDPedid char(10))
BEGIN
  SELECT * FROM `producto_pedido` WHERE `IDPedido` = IDPedid;
END;

