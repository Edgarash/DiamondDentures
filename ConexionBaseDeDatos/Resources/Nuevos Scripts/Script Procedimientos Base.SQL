
DROP PROCEDURE IF EXISTS `ConteoAdministradores`;
CREATE DEFINER=`root`@`%` PROCEDURE `ConteoAdministradores`()
BEGIN
  SELECT COUNT(`Activo`) AS 'resultado' FROM `usuario` WHERE `Departamento` = 'Administracion' AND `Puesto` = 'Administrador' AND `Activo` = 1;
END;


DROP PROCEDURE IF EXISTS `RegistrarEmpleado`;
CREATE DEFINER=`root`@`%` PROCEDURE `RegistrarEmpleado`(emp int)
BEGIN
  INSERT INTO `empleados` VALUES (emp);
END;


DROP PROCEDURE IF EXISTS `RecuperarTarjeta`;
CREATE PROCEDURE `RecuperarTarjeta`(log varchar(30))
BEGIN
  SELECT * FROM `tarjetas` WHERE `login` = log AND `activo` = 1;
END;


DROP PROCEDURE IF EXISTS `RecuperarUsuario`;
CREATE PROCEDURE `RecuperarUsuario`(log varchar(30))
BEGIN
  SELECT * FROM `usuario` WHERE `login` = log;
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
