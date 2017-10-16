#En este archivo de texto sólo Rolland deberá meter sus procedimientos almacenados

#Procedimiento que permite agregar un proveedor
DROP PROCEDURE IF EXISTS `AgregarProveedor`;
CREATE DEFINER=`root`@`%` PROCEDURE `AgregarProveedor`(
id int(11), 
nom char(50),
tel char(10),
email char(70),
dir char(100),
descripcion char(50)
)
BEGIN 
  INSERT IGNORE INTO `Proveedores`(`IDProveedor`, `Nombre`, `Telefono`, `Correo`, `Direccion`, `Descripcion`) 
    VALUES(id, nom, tel, email, dir, descripcion);
END;

#Procedimiento que permite actualizar los proveedores
DROP PROCEDURE IF EXISTS `ActualizarProveedor`;
CREATE DEFINER=`root`@`%` PROCEDURE `ActualizarProveedor`(
id int(11), 
nom char(50),
tel char(10),
email char(70),
dir char(100),
descripcion char(50)
)
BEGIN 
  UPDATE `Proveedores` SET
    `IDProveedor` = id,
    `Nombre` = nom,
    `Telefono` = tel,
    `Correo` = email,
    `Dirección` = dir,
    `Descripcion` = descripcion
    WHERE `IDProveedor` = id;
END;

#Procedimiento que permite ver la información de todos los proveedores
DROP PROCEDURE IF EXISTS `VerProveedores`;
CREATE DEFINER=`root`@`%` PROCEDURE `VerProveedores`()
BEGIN
  SELECT * FROM `Proveedores`;
END;

#Procedimiento que permite ver la inforrmación de solo un proveedor 
DROP PROCEDURE IF EXISTS `UnProveedor`;
CREATE DEFINER=`root`@`%` PROCEDURE `UnProveedor`(
id int(11)
)
BEGIN
  SELECT * FROM `Proveedores` WHERE `IDProveedor` = id;
END;

#Procedimiento que permite ver todo el inventario disponible
DROP PROCEDURE IF EXISTS `MostrarInventario`;
CREATE DEFINER=`root`@`%` PROCEDURE `MostrarInventario`()
BEGIN
  SELECT `IDMaterial`, `Nombre`, `PrecioCompra`,`Proveedor`,`UnidadMedida`,`Cantidad` FROM `Material`;
END;

#Procedimiento para ver el inventario particular de un material
DROP PROCEDURE IF EXISTS `InventarioUno`;
CREATE DEFINER=`root`@`%` PROCEDURE `InventarioUno`(
id int(11)
)
BEGIN
  SELECT `IDMaterial`, `Nombre`, `PrecioCompra`, `Proveedor`, `UnidadMedida`, `Cantidad` 
    FROM `Material` WHERE `IDMaterial` = id;
END;

#Procedimiento que detalla la compra de insumos
DROP PROCEDURE IF EXISTS `ComprarInsumos`;
CREATE DEFINER=`root`@`%` PROCEDURE `ComprarInsumos`
(
  id int(11),
  Nombre char(50),
  Descripcion char(70),
  Cantidad int(11), 
  PrecioUnitario numeric(10,2)
)
BEGIN 
  INSERT IGNORE INTO `Detalle_Compra_Insumo`(`IDCompra`, `Nombre`, `Descripcion`, `Cantidad`, `PrecioUnitario`, `Subtotal`) 
    VALUES(id, Nombre, Descripcion, Cantidad, PrecioUnitario, Cantidad * PrecioUnitario);
END;

#Procedimiento que detalla la compra de materiales
DROP PROCEDURE IF EXISTS `ComprarMateriales`;
CREATE DEFINER=`root`@`%` PROCEDURE `ComprarMateriales`
(
  idC int(11),
  idM int(11),
  Cantidad int(11)
)
BEGIN 
  INSERT IGNORE INTO `Detalle_Compra_Material`(`IDCompra`, `IDMaterial`, `Cantidad`) 
    VALUES(idC, idM, Cantidad);
  UPDATE `Detalle_Compra_Material`,`Material` SET `Subtotal` = Cantidad * `PrecioCompra`, `Detalle_Compra_Material`.`IDMaterial` = idM
    WHERE `Detalle_Compra_Material`.`IDMaterial` = idM AND  `Detalle_Compra_Material`.`IDMaterial` = `Material`.`IDMaterial`;
END;
