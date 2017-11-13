DROP PROCEDURE IF EXISTS `ActualizarTarjeta`;
CREATE DEFINER=`root`@`%` PROCEDURE `ActualizarTarjeta`(
  numer varchar(16),
  titula varchar(50),
  apellido varchar(50),
  banc varchar(50),
  fve varchar(5),
  logi varchar(30)
)
BEGIN
  UPDATE
    `tarjetas`
  SET
    `numero` = numer,
    `titular` = titula,
    `apellidos` = apellido,
    `banco` = banc,
    `fven` = fve
  WHERE
    `login` = logi;
END;


DROP PROCEDURE IF EXISTS `ActualizarUsuario`;
CREATE DEFINER=`root`@`%` PROCEDURE `ActualizarUsuario`(
  emplead int(11),
  logi char(30),
  passwor char(30),
  nombr char(50),
  apellido char(50),
  FechaNacimient date,
  NumCas char(10),
  Direccio char(80),
  Coloni char(30),
  Ciuda char(30),
  Municipi char(50),
  Estad char(30),
  Pai char(30),
  CodPo char(11),
  TelCas char(45),
  TelOficin char(45),
  TelCe char(45),
  Emai char(70),
  Pregunt char(100),
  Respuest char(100),
  Activ char(1),
  Departament char(50),
  FechaIngres date,
  Puest char(20),
  Sueld decimal(10,2)
)
BEGIN
  UPDATE
    `usuario`
  SET
    `N_Empleado` = emplead,
    `Password` = passwor,
    `Nombre` = nombr,
    `Apellidos` = apellido,
    `FechaNacimiento` = FechaNacimient,
    `NumCasa` = NumCas,
    `Direccion` = Direccio,
    `Colonia` = Coloni,
    `Ciudad` = Ciuda,
    `Municipio` = Municipi,
    `Estado` = Estad,
    `Pais` = Pai,
    `CodPos` = CodPo,
    `TelCasa` = TelCas,
    `TelOficina` = TelOficin,
    `TelCel` = TelCe,
    `Email` = Emai,
    `Pregunta` = Pregunt,
    `Respuesta` = Respuest,
    `Activo` = Activ,
    `Departamento` = Departament,
    `FechaIngreso` = FechaIngres,
    `Puesto` = Puest,
    `Sueldo` = Sueld
  WHERE
    `Login` = logi;
END;


DROP PROCEDURE IF EXISTS `AdministrarUsuarios`;
CREATE DEFINER=`root`@`%` PROCEDURE `AdministrarUsuarios`()
BEGIN
  SELECT
    `usuario`.`N_empleado`,
    `Login`,
    `Nombre`,
    `Apellidos`,
    `FechaNacimiento`,
    `Direccion`,
    `NumCasa` AS 'N° Casa',
    `CodPos` AS 'Codigo Postal',
    `Colonia`,
    `Ciudad` 'Municipio',
    `Estado`,
    `Pais`,
    `TelCasa` AS 'Tel. Casa',
    `TelCel` AS 'Tel. Movil',
    `TelOficina` AS 'Tel. Oficina',
    `Email`,
    `Activo`,
    `Departamento`,
    `Puesto`,
    `FechaIngreso` AS 'Fecha de Ingreso',
    `Sueldo`
  FROM
    `usuario`,
    `empleados`
  WHERE
    `usuario`.`N_Empleado` = `empleados`.`N_Empleado`
  UNION ALL
  SELECT
    `N_Empleado`,
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    '',
    ''
  FROM
    `empleados`
  WHERE
    `N_Empleado` NOT IN (SELECT `N_Empleado` FROM `usuario`)
  ORDER BY `N_Empleado`;
END;


DROP PROCEDURE IF EXISTS `ConteoAdministradores`;
CREATE DEFINER=`root`@`%` PROCEDURE `ConteoAdministradores`()
BEGIN
  SELECT COUNT(`Activo`) AS 'resultado' FROM `usuario` WHERE `Departamento` = 'ADMINISTRACION' AND `Puesto` = 'ADMINISTRADOR' AND `Activo` = '1';
END;

DROP PROCEDURE IF EXISTS `EliminarTarjeta`;
CREATE DEFINER=`root`@`%` PROCEDURE `EliminarTarjeta`(logi varchar(30))
BEGIN
  DELETE FROM `Tarjetas` WHERE `login` = logi;
END;


DROP PROCEDURE IF EXISTS `RecuperarPregunta`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarPregunta`(emp int)
BEGIN
  SELECT * FROM `usuario` WHERE `N_Empleado` = emp;
END;


DROP PROCEDURE IF EXISTS `RecuperarTarjeta`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarTarjeta`(log varchar(30))
BEGIN
  SELECT * FROM `tarjetas` WHERE `login` = log AND `activo` = 1;
END;


DROP PROCEDURE IF EXISTS `RecuperarUsuario`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarUsuario`(log varchar(30))
BEGIN
  SELECT * FROM `usuario` WHERE `login` = log;
END;


DROP PROCEDURE IF EXISTS `RecuperarUsuarioN`;
CREATE DEFINER=`root`@`%` PROCEDURE `RecuperarUsuarioN`(N int)
BEGIN
  SELECT * FROM `usuario` WHERE `N_Empleado` = N;
END;


DROP PROCEDURE IF EXISTS `RegistrarEmpleado`;
CREATE DEFINER=`root`@`%` PROCEDURE `RegistrarEmpleado`(emp int)
BEGIN
  INSERT IGNORE INTO `empleados` VALUES (emp);
END;


DROP PROCEDURE IF EXISTS `RegistrarTarjeta`;
CREATE DEFINER=`root`@`%` PROCEDURE `RegistrarTarjeta`(
  numer varchar(16),
  titula varchar(50),
  apellido varchar(50),
  banc varchar(50),
  fve varchar(5),
  logi varchar(30)
)
BEGIN
  INSERT IGNORE
    INTO `tarjetas`
    (`numero`, `titular`, `apellidos`, `banco`, `fven`, `login`)
  VALUES
    (numer, titula, apellido, banc, fve, logi);
END;


DROP PROCEDURE IF EXISTS `RegistrarUsuario`;
CREATE DEFINER=`root`@`%` PROCEDURE `RegistrarUsuario`(
  emplead int(11),
  logi char(30),
  passwor char(30),
  nombr char(50),
  apellido char(50),
  FechaNacimient date,
  NumCas char(10),
  Direccio char(80),
  Coloni char(30),
  Ciuda char(30),
  Municipi char(50),
  Estad char(30),
  Pai char(30),
  CodPo char(11),
  TelCas char(45),
  TelOficin char(45),
  TelCe char(45),
  Emai char(70),
  Pregunt char(100),
  Respuest char(100),
  Activ char(1),
  Departament char(50),
  FechaIngres date,
  Puest char(20),
  Sueld decimal(10,2)
)
BEGIN
  INSERT IGNORE
    INTO `usuario`
    (`N_Empleado`, `Login`, `Password`, `Nombre`, `Apellidos`, `FechaNacimiento`, `NumCasa`, `Direccion`, `Colonia`, `Ciudad`, `Municipio`, `Estado`, `Pais`, `CodPos`, `TelCasa`, `TelOficina`, `TelCel`, `Email`, `Pregunta`, `Respuesta`, `Activo`, `Departamento`, `FechaIngreso`, `Puesto`, `Sueldo`)
  VALUES
    (emplead, logi, passwor, nombr, apellido, FechaNacimient, NumCas, Direccio, Coloni, Ciuda, Municipi, Estad, Pai, CodPo, TelCas, TelOficin, TelCe, Emai, Pregunt, Respuest, Activ, Departament, FechaIngres, Puest, Sueld);
END;


DROP PROCEDURE IF EXISTS `ValidarEmpleado`;
CREATE DEFINER=`root`@`%` PROCEDURE `ValidarEmpleado`(emp int)
BEGIN
  SELECT `N_Empleado` FROM `empleados` WHERE `N_Empleado` = emp;
END;


DROP PROCEDURE IF EXISTS `ValidarEmpleadoRegistrado`;
CREATE DEFINER=`root`@`%` PROCEDURE `ValidarEmpleadoRegistrado`(emp int)
BEGIN
  SELECT `N_Empleado` AS 'result' FROM `usuario` WHERE `N_Empleado` = emp AND `Activo` = '1';
END;