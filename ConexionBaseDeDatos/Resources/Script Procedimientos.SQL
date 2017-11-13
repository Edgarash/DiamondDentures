DROP PROCEDURE IF EXISTS `ActivarMaterial`;
CREATE PROCEDURE `ActivarMaterial`(clv int)
BEGIN
  Update `materiales` set
    Activo = 1
    Where Clave = `clv`;
END;

DROP PROCEDURE IF EXISTS `ActivarProducto`;
CREATE PROCEDURE `ActivarProducto`(
  clv int
)
BEGIN
  Update `productos` set
    Activo = 1
    Where Clave = `clv`;
END;

DROP PROCEDURE IF EXISTS `ActivarUsuario`;

CREATE PROCEDURE `ActivarUsuario`(logi varchar(30))
BEGIN
declare maxi int;
select max(`ultima`) into maxi from `tarjetas` where `login` = `logi` limit 1;
  UPDATE `tarjetas` SET `activo` = 1 WHERE `login` = `logi` and `ultima` = `maxi`;
  UPDATE `usuarios` SET `estatus` = 1 WHERE `login` = `logi`;
END;

DROP PROCEDURE IF EXISTS `ActualizarDentista`;


CREATE PROCEDURE `ActualizarDentista`(
ced char(10),
rf char(15),
nmb char(50),
ape char(50),
tel char(10),
pa char(30),
es char(30),
mu char(50),
ciu char(30),
col char(30),
cal char(80),
num char(6),
codp char(10),
ema char(70)
)
BEGIN
update dentistas set `RFC` = `rf`,
	`NombreDen` = `nmb`,
    `ApellidosDen` = `ape`, 
    `Telefono`=`tel`,
    `Pais`=`pa`,
    `Estado`=`es`,
    `Municipio`=`mu`,
	`Ciudad`=`ciu`, 
    `Colonia` = `col`,
    `Calle`=`cal`,
    `NumFrente`=`num`,
    `CP`=`codp`,
    `Email`=`ema` where `Cedula` = `ced`;
END;

DROP PROCEDURE IF EXISTS `ActualizarMaterial`;


CREATE PROCEDURE `ActualizarMaterial`(
  clv int,
  nmb char(30),
  price decimal(10, 2)
)
BEGIN
  Update ignore `materiales` set
    Nombre = `nmb` ,
    Precio = `price`,
    Activo = 1
    Where Clave = `clv`;
END;

DROP PROCEDURE IF EXISTS `ActualizarPedido`;

CREATE PROCEDURE `ActualizarPedido`(
clv char(10),
user char(30),
dat datetime,
ced char(10),
rf char(15),
nmb char(50),
ape char(50),
tel char(10),
pa char(30),
es char(30),
mu char(50),
ciu char(30),
col char(30),
cal char(80),
num char(6),
codp char(10),
ema char(70),
fechaent date,
esta int,
asig char(30),
urg int
)
BEGIN
 delete from trabajospedido where `clave` = `clv`;
update pedidos set 
`Fecha` = `dat`,
`Cedula` = `ced`,
`RFC`=`rf`, 
`NombreDen`= `nmb`,
`ApellidosDen`= `ape`,
`Telefono` = `tel`,
`Pais`=  `pa`,
`Estado`= `es`,
`Municipio` = `mu`,
 `Ciudad`=`ciu`,
 `Colonia`=`col`,
 `Calle` = `cal`, 
 `NumFrente` =`num`,
 `CP` = `codp`,
 `Email` = `ema`, 
 `FechaEntrega` = `fechaent`,
 `Estatus` = `esta`,
 `Urgente` = `urg` where `Clave`= `clv`;
END ;


DROP PROCEDURE IF EXISTS `ActualizarProducto`;

CREATE PROCEDURE `ActualizarProducto`(
  clv int,
  nmb char(30),
  days int,
  price decimal(10, 2)
)
BEGIN
  Update ignore `productos` set
    Nombre = `nmb` ,
    Dias = `days`, 
    Precio = `price`,
    Activo = 1
    Where Clave = `clv`;
END;


DROP PROCEDURE IF EXISTS `ActualizarProMat`;
CREATE PROCEDURE `ActualizarProMat`(clvmat int, clvpro int, price decimal(10,2), act int)
BEGIN
	delete from `promat` where ClaveMat = `clvmat` and ClavePro = `clvpro`;
    insert into `promat` (ClavePro, ClaveMat, Precio, Valido) values (`clvpro`, `clvmat`, `price`, `act`);
END;

DROP PROCEDURE IF EXISTS `ActualizarTarjeta`;

CREATE PROCEDURE `ActualizarTarjeta`(
  nmr varchar(16),
  ttlr varchar(50),
  appe varchar(50),
  bnc varchar(50),
  fveni varchar(5),
  log varchar(30)
)
BEGIN
  UPDATE
    `tarjetas`
  SET
    `numero` = `nmr`,
    `titular` = `ttlr`,
    `apellidos` = `appe`,
    `banco` = `bnc`,
    `fven` = `fveni`
  WHERE
    `login` = `log` AND `activo` = 1;
END;



DROP PROCEDURE IF EXISTS `ActualizarUsuario`;
CREATE PROCEDURE `ActualizarUsuario`(
  nmtrb int(11),
  nomb varchar(50),
  appe varchar(50),
  str varchar(80),
  ncasa int(11),
  cl varchar(30),
  cdd varchar(30),
  ps varchar(30),
  cp varchar(11),
  eml varchar(70),
  logi varchar(30),
  pwd varchar(30),
  edo varchar(30),
  muni varchar(50),
  est tinyint(4),
  t_us varchar(20),
  tl_c varchar(45),
  tl_o varchar(45),
  tl_m varchar(45),
  preg varchar(100),
  resp varchar(100),
  newlogin varchar(30)
)
BEGIN
  UPDATE
    `usuarios`
  SET
    `nmtrabajador` = `nmtrb`,
    `nombre` = `nomb`,
    `apellidos` = `appe`,
    `calle` = `str`,
    `numcasa` = `ncasa`,
    `colonia` = `cl`,
    `ciudad` = `cdd`,
    `pais` = `ps`,
    `cp` = `cp`,
    `email` = `eml`,
    `contrasena` = `pwd`,
    `estado` = `edo`,
    `municipio` = `muni`,
    `estatus` = `est`,
    `t_usuario` = `t_us`,
    `tel_casa` = `tl_c`,
    `tel_oficina` = `tl_o`,
    `tel_movil` = `tl_m`,
    `Pregunta` = `preg`,
    `Respuesta` = `resp`,
    `login` = `newlogin`
  WHERE
    `login` = `logi`;
END;


DROP PROCEDURE IF EXISTS `BorrarUsuario`;

CREATE PROCEDURE `BorrarUsuario`(logi varchar(30))
BEGIN
  UPDATE `tarjetas` SET `activo` = 0 WHERE `login` = `logi`;
  UPDATE `usuarios` SET `estatus` = 0 WHERE `login` = `logi`;
END;


DROP PROCEDURE IF EXISTS `BuscarUnMaterial`;

CREATE PROCEDURE `BuscarUnMaterial`(clv int, nmb char(30), price char(10))
BEGIN
  SELECT * 
  FROM `materiales`
  where
	Clave = (if (`clv` = -1, Clave, `clv`))
    And Nombre like (Concat(`nmb`, '%'))
    And convert(Precio, char) like (if (`price` < 0, convert(Precio, char), Concat(`price`, '%')));
END;


DROP PROCEDURE IF EXISTS `BuscarUnProducto`;

CREATE PROCEDURE `BuscarUnProducto`(clv int, nmb char(30), days int, price char(10))
BEGIN
  SELECT * 
  FROM `productos`
  where
	Clave = (if (`clv` = -1, Clave, `clv`))
    And Nombre like (Concat(`nmb`, '%'))
    And cast(Dias as char) like (if (`days` = -1, Dias, Concat(`days`, '%')))
    And convert(Precio, char) like (if (`price` < 0, convert(Precio, char), Concat(`price`, '%')));
END;


DROP PROCEDURE IF EXISTS `ConteoAdministradores`;

CREATE PROCEDURE `ConteoAdministradores`()
BEGIN
  SELECT COUNT(`estatus`) AS 'resultado' FROM `usuarios` WHERE `t_usuario` = 'Administrador' AND `estatus` = 1;
END;


DROP PROCEDURE IF EXISTS `EliminarMaterial`;

CREATE PROCEDURE `EliminarMaterial`(
  clv int
)
BEGIN
  Update `materiales` set
    Activo = 0
    Where Clave = `clv`;
END;


DROP PROCEDURE IF EXISTS `EliminarProducto`;
CREATE PROCEDURE `EliminarProducto`(
  clv int
)
BEGIN
  Update `productos` set
    Activo = 0
    Where Clave = `clv`;
END;


DROP PROCEDURE IF EXISTS `EliminarTarjeta`;

CREATE PROCEDURE `EliminarTarjeta`(logi varchar(30))
BEGIN
  UPDATE `tarjetas` SET `activo` = 0 WHERE `login` = `logi`;
END;

DROP PROCEDURE IF EXISTS `ObtenerMateriales`;

CREATE PROCEDURE `ObtenerMateriales`()
BEGIN
  SELECT * FROM `materiales`;
END;


DROP PROCEDURE IF EXISTS `ObtenerPermiso`;

CREATE PROCEDURE `ObtenerPermiso`(pass varchar(30))
BEGIN
  SELECT `contrasena` AS 'result' FROM `usuarios` WHERE `contrasena` = `pass` AND `t_usuario` = 'Administrador' AND `estatus` = 1;
END;


DROP PROCEDURE IF EXISTS `Obtenerproductos`;

CREATE PROCEDURE `Obtenerproductos`()
BEGIN
  SELECT * FROM `productos`;
END;


DROP PROCEDURE IF EXISTS `ObtenerProMat`;

CREATE PROCEDURE `ObtenerProMat`(clvmat int, clvpro int)
BEGIN
	select * from precios where
    ClaveMat = if(`clvmat` = -1, ClaveMat,`clvmat`)
    and ClavePro = if(`clvpro` = -1, ClavePro, `clvpro`);
END;


DROP PROCEDURE IF EXISTS `ObtenerTrabajos`;

CREATE PROCEDURE `ObtenerTrabajos`(clv char(10))
BEGIN
  SELECT * FROM `trabajospedido` where `Clave` = `clv`;
END;


DROP PROCEDURE IF EXISTS `ObtenerUnDentista`;

CREATE PROCEDURE `ObtenerUnDentista`(clv char(10))
BEGIN
  SELECT * FROM `dentistas` where `Cedula` = `clv`;
END;

DROP PROCEDURE IF EXISTS `ObtenerUnMaterial`;

CREATE PROCEDURE `ObtenerUnMaterial`(clv int)
BEGIN
  SELECT * FROM `materiales` where `Clave` = `clv`;
END;


DROP PROCEDURE IF EXISTS `ObtenerUnPedido`;

CREATE PROCEDURE `ObtenerUnPedido`(clv char(10))
BEGIN
  SELECT * FROM `pedidos` where `Clave` = `clv`;
END;


DROP PROCEDURE IF EXISTS `ObtenerUnProducto`;

CREATE PROCEDURE `ObtenerUnProducto`(nmb char(30))
BEGIN
  SELECT * FROM `productos` where `Nombre` = `nmb`;
END;


DROP PROCEDURE IF EXISTS `RecuperarContrase�a`;

CREATE PROCEDURE `RecuperarContrase�a`(nmtrb int)
BEGIN
  SELECT `contrasena` FROM `usuarios` WHERE `nmtrabajador` = `nmtrb`;
END;


DROP PROCEDURE IF EXISTS `RecuperarPregunta`;

CREATE PROCEDURE `RecuperarPregunta`(emp int)
BEGIN
  SELECT `Pregunta` FROM `usuarios` WHERE `nmtrabajador` = `emp`;
END;


DROP PROCEDURE IF EXISTS `RecuperarTarjeta`;

CREATE PROCEDURE `RecuperarTarjeta`(IN log varchar(30))
BEGIN
  SELECT * FROM `tarjetas` WHERE `login` = `log` AND `activo` = 1;
END;


DROP PROCEDURE IF EXISTS `RecuperarUsuario`;

CREATE PROCEDURE `RecuperarUsuario`(log varchar(30))
BEGIN
  SELECT * FROM `usuarios` WHERE `login` = `log`;
END;


DROP PROCEDURE IF EXISTS `RegistrarDentista`;

CREATE PROCEDURE `RegistrarDentista`(
ced char(10),
rf char(15),
nmb char(50),
ape char(50),
tel char(10),
pa char(30),
es char(30),
mu char(50),
ciu char(30),
col char(30),
cal char(80),
num char(6),
codp char(10),
ema char(70)
)
BEGIN
  Insert ignore into dentistas values (`ced`, `rf`, `nmb`, `ape`, `tel`, `pa`, `es`, `mu`,
  `ciu`, `col`, `cal`, `num`, `codp`, `ema`);
END;


DROP PROCEDURE IF EXISTS `RegistrarEmpleado`;
CREATE PROCEDURE `RegistrarEmpleado`(emp int)
BEGIN
  INSERT INTO `empleados` VALUES (`emp`);
END;


DROP PROCEDURE IF EXISTS `RegistrarMaterial`;

CREATE PROCEDURE `RegistrarMaterial`(
  clv int,
  nmb char(30),
  price decimal(10, 2)
)
BEGIN
  INSERT IGNORE
    INTO `materiales`
    (`Clave`, `Nombre`, `Precio`)
  VALUES
    (`clv`, `nmb`, `price`);
END;


DROP PROCEDURE IF EXISTS `RegistrarPedido`;

CREATE PROCEDURE `RegistrarPedido`(
clv char(10),
user char(30),
dat datetime,
ced char(10),
rf char(15),
nmb char(50),
ape char(50),
tel char(10),
pa char(30),
es char(30),
mu char(50),
ciu char(30),
col char(30),
cal char(80),
num char(6),
codp char(10),
ema char(70),
fechaent date,
esta int,
asig char(30),
urg int
)
BEGIN
  Insert ignore into pedidos values (`clv`, `user`, `dat`, `ced`, `rf`, `nmb`, `ape`, `tel`, `pa`, `es`, `mu`,
  `ciu`, `col`, `cal`, `num`, `codp`, `ema`, `fechaent`, `esta`, `asig`, `urg`);
END;


DROP PROCEDURE IF EXISTS `RegistrarProducto`;

CREATE PROCEDURE `RegistrarProducto`(
  clv int,
  nmb char(30),
  days int,
  price decimal(10, 2)
)
BEGIN
  INSERT IGNORE	
    INTO `productos`
    (`Clave`, `Nombre`, `Dias`, `Precio`)
  VALUES
    (`clv`, `nmb`, `days`, `price`);
END;


DROP PROCEDURE IF EXISTS `RegistrarTarjeta`;
CREATE PROCEDURE `RegistrarTarjeta`(
  nmr varchar(16),
  ttlr varchar(50),
  appe varchar(50),
  bnc varchar(50),
  fven varchar(5),
  log varchar(30)
)
BEGIN
    INSERT IGNORE
      INTO `tarjetas`
      (`numero`, `titular`, `apellidos`, `banco`, `fven`, `login`)
    VALUES
      (`nmr`, `ttlr`, `appe`, `bnc`, `fven`, `log`);
END;


DROP PROCEDURE IF EXISTS `RegistrarTrabajo`;

CREATE PROCEDURE `RegistrarTrabajo`(
  clv char(10),
  pro char(30),
  pre decimal(10,2),
  mat1 char(30),
  pre1 decimal(10,2),
  mat2 char(30),
  pre2 decimal(10,2),
  fec date
)
BEGIN
  REPLACE INTO `trabajospedido` VALUES (`clv`, `pro`, `pre`, `mat1`, `pre1`, `mat2`, `pre2`, `fec`);
END;


DROP PROCEDURE IF EXISTS `RegistrarUsuario`;

CREATE PROCEDURE `RegistrarUsuario`(
  nmtrb int(11),
  nmb varchar(50),
  appe varchar(50),
  dr varchar(80),
  ncasa int(11),
  cl varchar(30),
  cdd varchar(30),
  ps varchar(30),
  cp varchar(11),
  eml varchar(70),
  logi varchar(30),
  pwd varchar(30),
  edo varchar(30),
  muni varchar(50),
  est tinyint(4),
  t_us varchar(20),
  tl_c varchar(45),
  tl_o varchar(45),
  tl_m varchar(45),
  preg varchar(100),
  respues varchar(100)
)
BEGIN
  INSERT IGNORE
    INTO `usuarios`
    (`nmtrabajador`, `nombre`, `apellidos`, `calle`, `numcasa`, `colonia`, `ciudad`, `pais`, `cp`, `email`, `login`, `contrasena`, `estado`, `municipio`, `estatus`, `t_usuario`, `tel_casa`, `tel_oficina`, `tel_movil`, `Pregunta`, `Respuesta`)
  VALUES
    (`nmtrb`, `nmb`, `appe`, `dr`, `ncasa`, `cl`, `cdd`, `ps`, `cp`, `eml`, `logi`, `pwd`, `edo`, `muni`, `est`, `t_us`, `tl_c`, `tl_o`, `tl_m`, `preg`, `respues`);
END;


DROP PROCEDURE IF EXISTS `ValidarEmpleado`;

CREATE PROCEDURE `ValidarEmpleado`(emp int)
BEGIN
  SELECT `N_Empleado` FROM `empleados` WHERE `N_Empleado` = `emp`;
END;


DROP PROCEDURE IF EXISTS `ValidarEmpleadoRegistrado`;

CREATE PROCEDURE `ValidarEmpleadoRegistrado`(emp int)
BEGIN
  SELECT `nmtrabajador` as result FROM `usuarios` WHERE `nmtrabajador` = `emp` AND `estatus` = 1;
END;


DROP PROCEDURE IF EXISTS `ValidarRespuesta`;

CREATE PROCEDURE `ValidarRespuesta`(num int, resp varchar(100))
BEGIN
SELECT 
    COUNT(`Respuesta`) AS result
FROM
    `usuarios`
WHERE
    `nmtrabajador` = `num`
        AND `Respuesta` = `resp`;
END;


DROP PROCEDURE IF EXISTS `ObtenerPedidos`;

CREATE PROCEDURE `ObtenerPedidos`()
BEGIN
  SELECT
  `Clave`,
  `Cedula`,
  `NombreDen` AS 'Nombre Dentista',
  `Telefono`,
  `Fecha` AS 'Llegada',
  `FechaEntrega` AS 'Entrega',
  IF(`Urgente` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido',
  `Estatus`,
  IF(`Asignado` = '', 'No asignado', `Asignado`) AS 'Laboratorista'
FROM
  `pedidos`
ORDER BY `Urgente` DESC, `FechaEntrega`, `Estatus` = '0', `Estatus` = '5', `Estatus` = '7', `Estatus` = '6', `Estatus` = '1', `Estatus` = '2', `Estatus` = '4' DESC;
  
END;

DROP PROCEDURE IF EXISTS `ObtenerPedidosID`;
DROP PROCEDURE IF EXISTS `ObtenerPedidoID`;
CREATE PROCEDURE `ObtenerPedidoID`(clv char(10))
BEGIN
SELECT Clave, Cedula, NombreDen as 'Nombre Dentista', Telefono, Fecha as 'Llegada', FechaEntrega as 'Entrega', IF(`Urgente` = 1, 'Urgente', 'Normal') AS 'Tipo de Pedido', Estatus from pedidos where Clave = `clv`;
END;


DROP PROCEDURE IF EXISTS `BuscarFactura`;
CREATE PROCEDURE `BuscarFactura`(
  idf  INT,
  nmcl VARCHAR(45),
  f1   DATE,
  f2   DATE,
  opt  TINYINT
)
  BEGIN

    CASE opt

      WHEN 1
      THEN SELECT *
           FROM facturas
           WHERE Id = idf;
      WHEN 2
      THEN SELECT *
           FROM facturas
           WHERE NombreC = nmcl;
      WHEN 3
      THEN SELECT *
           FROM facturas
           WHERE Id = idf AND NombreC = nmcl;

      WHEN 8
      THEN SELECT *
           FROM facturas
           WHERE Fecha BETWEEN subdate(curdate(), INTERVAL 1 YEAR) AND curdate()
           LIMIT 1000;


      WHEN 5
      THEN
        SELECT *
        FROM facturas
        WHERE Id = idf AND Fecha BETWEEN f1 AND f2;
      WHEN 6
      THEN
        SELECT *
        FROM facturas
        WHERE NombreC = nmcl AND Fecha BETWEEN f1 AND f2;
      WHEN 7
      THEN SELECT *
           FROM facturas
           WHERE Id = idf AND NombreC = nmcl AND Fecha BETWEEN f1 AND f2;

      WHEN 4
      THEN SELECT *
           FROM facturas
           WHERE Fecha BETWEEN f1 AND f2;

    END CASE;

  END;



DROP PROCEDURE IF EXISTS `BuscarPedido`;
CREATE PROCEDURE `BuscarPedido`(
  nmp  INT,
  nmcl VARCHAR(45),
  f1   DATE,
  f2   DATE,
  opt  TINYINT
)
BEGIN

    CASE opt


      WHEN 1
      THEN 
      SELECT 
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`
           FROM pedidos
           WHERE pedidos.Clave = nmp 
           GROUP BY pedidos.Clave;
      WHEN 2
      THEN SELECT       
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`
           FROM pedidos
           WHERE NombreDen = nmcl
           GROUP BY pedidos.Clave;
      WHEN 3
      THEN SELECT       
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`
           FROM pedidos
           WHERE pedidos.Clave = nmp AND NombreDen = nmcl 
           GROUP BY pedidos.Clave;

      WHEN 8
      THEN SELECT       
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`
           FROM pedidos
           WHERE
             pedidos.Fecha BETWEEN SUBDATE(CURDATE(), INTERVAL 2 YEAR) AND CURDATE() 
           GROUP BY pedidos.Clave
           LIMIT 1000;

      WHEN 5
      THEN SELECT       
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`
           FROM pedidos
           WHERE pedidos.Clave = nmp AND pedidos.Fecha BETWEEN f1 AND f2 
           GROUP BY pedidos.Clave;
      WHEN 6
      THEN SELECT       
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`
           FROM pedidos
           WHERE NombreDen = nmcl AND pedidos.Fecha BETWEEN f1 AND f2 
           GROUP BY pedidos.Clave;
      WHEN 7
      THEN SELECT       
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`     
           FROM pedidos
           WHERE pedidos.Clave = nmp AND NombreDen = nmcl AND pedidos.Fecha BETWEEN f1 AND f2 
           GROUP BY pedidos.Clave;

      WHEN 4
      THEN SELECT       
      `pedidos`.`Clave`,
	  `pedidos`.`NombreDen`,
	  `pedidos`.`ApellidosDen`,
	  `pedidos`.`Fecha`,
	  `pedidos`.`Cedula`    
           FROM pedidos
           WHERE pedidos.Fecha BETWEEN f1 AND f2 
           GROUP BY pedidos.Clave;

    END CASE;

  END;


DROP PROCEDURE IF EXISTS `CancelarFactura`;
CREATE PROCEDURE `CancelarFactura`(
  idf INT
)
  BEGIN

    UPDATE facturas
    SET Estatus = 0
    WHERE id = idf;

  END;

DROP PROCEDURE IF EXISTS `GuardarFactura`;
CREATE PROCEDURE `GuardarFactura`(
  idf INT,
  imp VARCHAR(45),
  fch VARCHAR(45),
  nmc VARCHAR(45),
  nme VARCHAR(45),
  cee VARCHAR(45),
  cec VARCHAR(45),
  cpc VARCHAR(45),
  cpe VARCHAR(45),
  drc VARCHAR(45),
  dre VARCHAR(45),
  esc VARCHAR(45),
  ese VARCHAR(45),
  pds INT,
  rfc VARCHAR(45),
  rfe VARCHAR(45),
  tlc VARCHAR(45),
  tle VARCHAR(45),
  cdc VARCHAR(45),
  cde VARCHAR(45),
  ncc VARCHAR(45),
  nce VARCHAR(45),
  clc VARCHAR(45),
  cle VARCHAR(45),
  psc VARCHAR(45),
  pse VARCHAR(45)
)
  BEGIN


    INSERT INTO facturas (Id, Importe, Fecha, NombreC, NombreE, CorreoE, CorreoC, CpC, CpE, CalleC, CalleE, EstadoC, EstadoE, Pedidos, RfcC, RfcE, TelefonoC, TelefonoE, CiudadC, CiudadE, Estatus, NumCasaC, NumCasaE, ColoniaC, ColoniaE, PaisC, PaisE)
    VALUES
      (idf, imp, fch, nmc, nme, cee, cec, cpc, cpe, drc, dre, esc, ese, pds, rfc, rfe, tlc, tle, cdc, cde, 1, ncc, nce,
       clc, cle, psc, pse);

  END;



DROP PROCEDURE IF EXISTS `ListarPedidos`;
CREATE PROCEDURE `ListarPedidos`(
  f1  DATE,
  f2  DATE
)
  BEGIN
        SELECT *
        FROM trabajospedido
        WHERE Fecha BETWEEN f1 AND f2;
  END;


DROP PROCEDURE IF EXISTS `ObtenerFacturaUnica`;
CREATE PROCEDURE `ObtenerFacturaUnica`(
  idf INT
)
  BEGIN

    SELECT *
    FROM facturas
    WHERE Id = idf;

  END;

DROP PROCEDURE IF EXISTS `ObtenerPedidoUnico`;
CREATE PROCEDURE `ObtenerPedidoUnico`(
  np CHAR(10)
)
  BEGIN
    SELECT *
    FROM pedidos
    WHERE pedidos.Clave = np;
  END;

DROP PROCEDURE IF EXISTS `ObtenerIdFacturas`;
CREATE PROCEDURE `ObtenerIdFacturas`()
BEGIN

  SELECT Id FROM facturas;

  END;

DROP PROCEDURE IF EXISTS `ObtenerListaPedidos`;
CREATE PROCEDURE `ObtenerListaPedidos`(
  clv CHAR(10)
)
BEGIN

  SELECT * FROM trabajospedido WHERE Clave = clv;

END;

DROP PROCEDURE IF EXISTS `ObtenerNotaTerminacion`;
CREATE PROCEDURE ObtenerNotaTerminacion(np CHAR)
  BEGIN
    SELECT
      pedidos.Clave,
      pedidos.Asignado,
      pedidos.Fecha,
      pedidos.FechaEntrega,
      trabajospedido.Producto,
      trabajospedido.Material1,
      trabajospedido.Material2
    FROM pedidos, trabajospedido
    WHERE pedidos.Clave = np AND pedidos.Clave = trabajospedido.Clave;
  END;