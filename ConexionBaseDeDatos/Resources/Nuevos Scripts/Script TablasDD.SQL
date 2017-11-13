CREATE DATABASE IF NOT EXISTS DiamondDentures;
USE DiamondDentures;

CREATE TABLE IF NOT EXISTS Empleados
(
N_Empleado	int(11) primary key
);

CREATE TABLE IF NOT EXISTS Usuario
(
N_Empleado		int(11) not null,
Login			char(30) primary key,
Password		char(30),
Nombre 			char(50),
Apellidos 		char(50),
FechaNacimiento	date,
NumCasa			char(10),
Direccion		char(80),
Colonia			char(30),
Ciudad			char(30),
Municipio		char(50),
Estado			char(30),
Pais			char(30),
CodPos			char(11),
TelCasa			char(45),
TelOficina		char(45),
TelCel			char(45),
Email			char(70),
Pregunta		char(100),
Respuesta		char(100),
Activo			char(1),
Departamento	char(50),
Puesto			char(20),
FechaIngreso	date,
Sueldo			decimal(10,2)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS DENTISTA
(
Cedula			char(10) primary key,
RFC				char(15),
Nombre 			char(50),
Apellidos 		char(50),
Direccion		char(80),
Colonia			char(30),
Ciudad			char(50),
Municipio		char(50),
Estado			char(30),
Pais			char(30),
CodPos			char(10),
TelOficina		char(10),
Email			char(70),
Activo			char(1),
Consultorio		char(50),
FechaAlta		date
);

CREATE TABLE IF NOT EXISTS PEDIDO
(
IDPedido		char(10) primary key,
IDEmpleado		char(30),
Cedula			char(10),
EstadoPedido	int(11),
FechaIngreso	date,
FechaCalculada	date,
FechaEntrega	date,
Urgencia		char(1),
CostoTotal		decimal(10,2),
Laboratorista	char(20),
Pagado			char(50),
RestantePagar	decimal(10,2),
IVA				decimal(10,2)
);

CREATE TABLE IF NOT EXISTS Ventas
(
IDPedido		char(10),
Importe			decimal(10,2),
FechaPago		date,
Login			char(10),
PersonaPaga		char(20),
FormaPago		char(10)
);

CREATE TABLE IF NOT EXISTS NotaTerminacion
(
FolioNota		int primary key AUTO_INCREMENT,
IDPedido		char(10),
Laboratorista	char(20),
FechaEmision	date,
FechaEntrega	date,
FechaTermiado	date

#DatosDentista
#DatosProducto
);

CREATE TABLE IF NOT EXISTS OficioConfirmacion
(
FolioOficio		int primary key AUTO_INCREMENT,
IDPedido		char(10),
Emite			char(20),
FechaEmision	date,
FechaConfirmado	date

#DatosDentista
#DatosProducto
);

CREATE TABLE IF NOT EXISTS FormaPedido
(
FolioForma		int primary key AUTO_INCREMENT,
IDPedido		char(10),
Emite			char(20),
FechaEmision	date

#FechaEntrega
#DatosDentista
#DatosProducto
);

CREATE TABLE IF NOT EXISTS Factura
(
NoFactura		int primary key AUTO_INCREMENT,
IDPedido		char(10),
FechaEmision	date,
  `Importe`   DOUBLE       NOT NULL,
  `NombreC`   VARCHAR(100) NOT NULL,
  `NombreE`   VARCHAR(50)  NOT NULL,
  `CorreoE`   VARCHAR(70)  NOT NULL,
  `CorreoC`   VARCHAR(70)  NOT NULL,
  `CpC`       VARCHAR(10)  NOT NULL,
  `CpE`       VARCHAR(10)  NOT NULL,
  `CalleC`    VARCHAR(80)  NOT NULL,
  `CalleE`    VARCHAR(80)  NOT NULL,
  `EstadoC`   VARCHAR(30)  NOT NULL,
  `EstadoE`   VARCHAR(30)  NOT NULL,
  `Pedidos`   VARCHAR(10)  NOT NULL,
  `RfcC`      VARCHAR(15)  NOT NULL,
  `RfcE`      VARCHAR(15)  NOT NULL,
  `TelefonoC` VARCHAR(10)  NOT NULL,
  `TelefonoE` VARCHAR(10)  NOT NULL,
  `CiudadC`   VARCHAR(30)  NOT NULL,
  `CiudadE`   VARCHAR(30)  NOT NULL,
  `Estatus`   TINYINT(4)   NOT NULL DEFAULT '1',
  `NumCasaC`  VARCHAR(6)   NOT NULL,
  `NumCasaE`  VARCHAR(6)   NOT NULL,
  `ColoniaC`  VARCHAR(30)  NOT NULL,
  `ColoniaE`  VARCHAR(30)  NOT NULL,
  `PaisC`     VARCHAR(30)  NOT NULL,
  `PaisE`     VARCHAR(30)  NOT NULL
);

CREATE TABLE IF NOT EXISTS COMENTARIOS
(
IDPedido		char(10),
Comentario		char(100)
);

CREATE TABLE IF NOT EXISTS PRODUCTO
(
IDProducto		int primary key AUTO_INCREMENT,
Nombre			char(50),
Descripcion		char(40),
TiempoBase		char(3),
PrecioBase		decimal(10,2),
PrecioCompra	decimal(10,2),
Activo			char(1),
UnidadMedida	char(10),
Cantidad		int(11)
);

CREATE TABLE IF NOT EXISTS MATERIAL
(
IDMaterial		int primary key AUTO_INCREMENT,
Nombre			char(30),
Descripcion		char(50),
PrecioBase		decimal(10,2),
PrecioCompra	decimal(10,2),
TiempoBase		char(3),
Proveedor		int(11),
UnidadMedida	char(10),
Cantidad		int(11)
);

CREATE TABLE IF NOT EXISTS PRODUCTO_PEDIDO
(
IDPedido		char(10),
IDProducto		int,
PrecioProducto	decimal(10,2),
IDMaterial1		int,
PrecioMaterial1	decimal(10,2),
IDMaterial2		int,
PrecioMaterial2	decimal(10,2),
Subtotal		decimal(10,2)
);

CREATE TABLE IF NOT EXISTS PROVEEDORES
(
IDProveedor		int primary key AUTO_INCREMENT,
Nombre			char(50),
Telefono		char(10),
Correo			char(70),
Direccion		char(100),
Descripcion		char(50)
);

CREATE TABLE IF NOT EXISTS `ASISTENCIA` (
  `IDAsistencia` int(11) NOT NULL AUTO_INCREMENT,
  `Login` char(10),
  `Fecha` date,
  `HoraEntrada` varchar(5),
  `HoraSalida` varchar(5),
  PRIMARY KEY (`IDAsistencia`)
);
CREATE TABLE IF NOT EXISTS PAGOEMPLEADOS
(
IDPago			int primary key AUTO_INCREMENT,
FechaPago		date,
Empleado		char(10),
Cantidad		decimal(10,2),
SemanaPago		char(3),
AñoPago			char(5)
);

CREATE TABLE IF NOT EXISTS CORTECAJA
(
FolioCorte		int primary key AUTO_INCREMENT,
Fecha			date,
Empleado		char(10),
FondoCaja		decimal(10,2),
EntradaEfectivo	decimal(10,2),
SalidasEfectivo decimal(10,2),
Ganancia		decimal(10,2),
NumVentas		int
);

CREATE TABLE IF NOT EXISTS MATERIALES_PRODUCTO
(
IDProducto		int,
IDMaterial		int,
PrecioFinal		decimal(10,2),
TiempoFinal		char(3),
Descripcion		char(50),
Medidas			char(50)
);

CREATE TABLE IF NOT EXISTS COMPRAS
(
IDCompra		int primary key AUTO_INCREMENT,
Empleado		char(10),
IDProveedor		int,
Total			decimal(10,2),
Fecha			date,
Tipo			char(10),
FechaSurtido	date,
Estado			char(1)
);

CREATE TABLE IF NOT EXISTS DETALLE_COMPRA_MATERIAL
(
IDCompra		int,
IDMaterial		int,
Subtotal		decimal(10,2),
Cantidad		int
);

CREATE TABLE IF NOT EXISTS DETALLE_COMPRA_INSUMO
(
IDCompra		int,
Nombre			char(50),
Descripcion		char(70),
Cantidad		int,
PrecioUnitario	decimal(10,2),
Subtotal		decimal(10,2)
);

CREATE TABLE IF NOT EXISTS `tarjetas` (
  `login` varchar(30) NOT NULL,
  `numero` varchar(16) NOT NULL,
  `titular` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `banco` varchar(50) NOT NULL,
  `fven` varchar(6) NOT NULL DEFAULT '',
  `activo` char(1) NOT NULL DEFAULT '1',
  KEY `FK` (`login`),
  CONSTRAINT `FK` FOREIGN KEY (`login`) REFERENCES `usuario` (`Login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Pagos` (
  `IDPago` int PRIMARY KEY AUTO_INCREMENT,
  `Nombre` char(50),
  `Descripcion` char(70),
  `PrecioUnitario` decimal(10,2),
  `Cantidad` int(11),
  `Subtotal` decimal(10,2),
  `Total` decimal(15,2),
  `Estado` int(1),
  `Registro` int(1)
);
