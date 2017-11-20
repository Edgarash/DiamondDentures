CREATE DATABASE IF NOT EXISTS DiamondDentures;
USE DiamondDentures;

#
# Structure for table "Asistencia"
#

CREATE TABLE IF NOT EXISTS Asistencia
(
IDAsistencia	int(11) NOT NULL AUTO_INCREMENT,
IDEmpleado		int(11),
Empleado		char(200),
Fecha			varchar(12),
HoraEntrada		varchar(5),
HoraSalida		varchar(5)
PRIMARY KEY (IDAsistencia)
);

#
# Structure for table "BalanceCuentasEgresos"
#

CREATE TABLE IF NOT EXISTS BalanceCuentasEgresos (
  Descripcion varchar(100),
  Valor decimal(10,2),
  Fecha varchar(12)
);

#
# Structure for table "BalanceCuentasIngresos"
#

CREATE TABLE IF NOT EXISTS BalanceCuentasIngresos (
  Descripcion varchar(100),
  Valor decimal(10,2),
  Fecha varchar(12)
);

#
# Structure for table "Comentarios"
#

CREATE TABLE IF NOT EXISTS Comentarios (
  IDPedido char(10) NOT NULL,
  Comentario char(100)
);

#
# Structure for table "Compras"
#

CREATE TABLE IF NOT EXISTS Compras
(
  IDCompra int(11) NOT NULL AUTO_INCREMENT,
  Empleado char(10) DEFAULT NULL,
  Total decimal(10,2) DEFAULT NULL,
  Fecha date DEFAULT NULL,
  Tipo char(10) DEFAULT NULL,
  FechaSurtido date DEFAULT NULL,
  Estado char(15) DEFAULT NULL,
  Registro int(1) DEFAULT NULL,
  PRIMARY KEY (IDCompra)
);

#
# Structure for table "CorteCaja"
#

CREATE TABLE IF NOT EXISTS CorteCaja (
  FolioCorte int(11) NOT NULL AUTO_INCREMENT,
  Fecha datetime DEFAULT NULL,
  Empleado char(30) DEFAULT NULL,
  Supervisor char(30) DEFAULT NULL,
  FondoCaja decimal(10,2) DEFAULT NULL,
  EntradaEfectivo decimal(10,2) NOT NULL DEFAULT '0.00',
  EntradaCheque decimal(10,2) NOT NULL DEFAULT '0.00',
  EntradaTarjeta decimal(10,2) NOT NULL DEFAULT '0.00',
  NumVentas int(11) DEFAULT NULL,
  DineroCaja decimal(10,2) DEFAULT '0.00',
  Comentario char(100) DEFAULT 'SIN COMENTARIO',
  PRIMARY KEY (FolioCorte)
);

#
# Structure for table "Dentista"
#

CREATE TABLE IF NOT EXISTS Dentista
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
FechaAlta		datetime
);

#
# Structure for table "Detalle_Compra_Insumo"
#

CREATE TABLE IF NOT EXISTS Detalle_Compra_Insumo (
  IDCompra int(11) DEFAULT NULL,
  Nombre char(50) DEFAULT NULL,
  Descripcion char(70) DEFAULT NULL,
  Cantidad int(11) DEFAULT NULL,
  PrecioUnitario decimal(10,2) DEFAULT NULL,
  Subtotal decimal(10,2) DEFAULT NULL,
  IDProveedor int(11) DEFAULT NULL,
  IDInsumo int(11) DEFAULT NULL
);

#
# Structure for table "Detalle_Compra_Material"
#

CREATE TABLE IF NOT EXISTS Detalle_Compra_Material (
  IDCompra int(11) DEFAULT NULL,
  IDMaterial int(11) DEFAULT NULL,
  Nombre char(50) DEFAULT NULL,
  IDProveedor int(11) DEFAULT NULL,
  Subtotal decimal(10,2) DEFAULT NULL,
  Cantidad int(11) DEFAULT NULL,
  Fecha date DEFAULT NULL,
  Estado char(15) DEFAULT NULL
);

#
# Structure for table "Empleados"
#

CREATE TABLE IF NOT EXISTS Empleados (
  N_Empleado int(11) NOT NULL,
  PRIMARY KEY (N_Empleado)
);

#
# Structure for table "Empresa"
#

CREATE TABLE IF NOT EXISTS Empresa (
  Nombre varchar(100) DEFAULT NULL,
  Telefono varchar(100) DEFAULT NULL,
  Correo varchar(100) DEFAULT NULL,
  Direccion varchar(100) DEFAULT NULL,
  Colonia varchar(100) DEFAULT NULL,
  RFC varchar(100) DEFAULT NULL,
  Ciudad varchar(100) DEFAULT NULL,
  Pais varchar(100) DEFAULT NULL
);

#
# Structure for table "Factura"
#

CREATE TABLE IF NOT EXISTS Factura (
  NoFactura int(11) NOT NULL AUTO_INCREMENT,
  IDPedido char(10) DEFAULT NULL,
  FechaEmision date DEFAULT NULL,
  Importe double NOT NULL,
  NombreC varchar(100) NOT NULL,
  NombreE varchar(50) NOT NULL,
  CorreoE varchar(70) NOT NULL,
  CorreoC varchar(70) NOT NULL,
  CpC varchar(10) NOT NULL,
  CpE varchar(10) NOT NULL,
  CalleC varchar(80) NOT NULL,
  CalleE varchar(80) NOT NULL,
  EstadoC varchar(30) NOT NULL,
  EstadoE varchar(30) NOT NULL,
  Pedidos varchar(10) NOT NULL,
  RfcC varchar(15) NOT NULL,
  RfcE varchar(15) NOT NULL,
  TelefonoC varchar(10) NOT NULL,
  TelefonoE varchar(10) NOT NULL,
  CiudadC varchar(30) NOT NULL,
  CiudadE varchar(30) NOT NULL,
  Estatus tinyint(4) NOT NULL DEFAULT '1',
  NumCasaC varchar(6) NOT NULL,
  NumCasaE varchar(6) NOT NULL,
  ColoniaC varchar(30) NOT NULL,
  ColoniaE varchar(30) NOT NULL,
  PaisC varchar(30) NOT NULL,
  PaisE varchar(30) NOT NULL,
  PRIMARY KEY (NoFactura)
);

#
# Structure for table "FormaPedido"
#

CREATE TABLE IF NOT EXISTS FormaPedido (
  FolioForma int(11) NOT NULL AUTO_INCREMENT,
  IDPedido char(10) DEFAULT NULL,
  Emite char(20) DEFAULT NULL,
  FechaEmision date DEFAULT NULL,
  PRIMARY KEY (FolioForma)
);

#
# Structure for table "Historial"
#

CREATE TABLE IF NOT EXISTS Historial (
  Id int(11) NOT NULL,
  Cantidad int(11) DEFAULT NULL,
  CantidadReal int(11) DEFAULT NULL,
  Faltantes int(11) DEFAULT NULL,
  Fecha date DEFAULT NULL
);

#
# Structure for table "Insumos"
#

CREATE TABLE IF NOT EXISTS Insumos (
  IDInsumos int(11) NOT NULL AUTO_INCREMENT,
  IDProveedor int(11) DEFAULT NULL,
  Nombre char(30) DEFAULT NULL,
  Descripcion char(50) DEFAULT NULL,
  PrecioBase decimal(10,2) DEFAULT NULL,
  PrecioCompra decimal(10,2) DEFAULT NULL,
  UnidadMedida char(50) DEFAULT NULL,
  CantidadDisponible int(11) DEFAULT NULL,
  CantidadSolicitada int(11) DEFAULT NULL,
  PRIMARY KEY (IDInsumos)
);

#
# Structure for table "Material"
#

CREATE TABLE IF NOT EXISTS Material (
  IDMaterial int(11) NOT NULL AUTO_INCREMENT,
  Nombre char(30) DEFAULT NULL,
  Descripcion char(50) DEFAULT NULL,
  PrecioBase decimal(10,2) DEFAULT NULL,
  PrecioCompra decimal(10,2) DEFAULT NULL,
  TiempoBase char(3) DEFAULT NULL,
  Proveedor int(11) DEFAULT NULL,
  UnidadMedida char(10) DEFAULT NULL,
  Cantidad int(11) DEFAULT NULL,
  CantidadSolicitada int(11) DEFAULT NULL,
  PRIMARY KEY (IDMaterial)
);

#
# Structure for table "Materiales_Producto"
#

CREATE TABLE IF NOT EXISTS Materiales_Producto (
  IDProducto int(11) DEFAULT NULL,
  IDMaterial int(11) DEFAULT NULL,
  PrecioFinal decimal(10,2) DEFAULT NULL,
  TiempoFinal char(3) DEFAULT NULL,
  Descripcion char(50) DEFAULT NULL,
  Medidas char(50) DEFAULT NULL
);

#
# Structure for table "Nomina"
#

CREATE TABLE IF NOT EXISTS Nomina (
  Fecha date DEFAULT NULL,
  N_empleado int(11) NOT NULL,
  Nombre varchar(100) DEFAULT NULL,
  Apellidos varchar(100) DEFAULT NULL,
  RCF varchar(20) DEFAULT NULL,
  Email varchar(100) DEFAULT NULL,
  Departamento varchar(50) DEFAULT NULL,
  Puesto varchar(100) DEFAULT NULL,
  DiasLaborados varchar(20) DEFAULT NULL,
  Sueldo decimal(10,2) DEFAULT NULL,
  ISR decimal(10,2) DEFAULT NULL,
  DescuentoISR decimal(10,2) DEFAULT NULL,
  SueldoFinal decimal(10,2) DEFAULT NULL,
  pagado int(1) DEFAULT NULL
);

#
# Structure for table "NotaCompras"
#

CREATE TABLE IF NOT EXISTS NotaCompras (
  IDFolio int(11) NOT NULL AUTO_INCREMENT,
  IDCompra int(11) DEFAULT NULL,
  IDProveedor int(11) DEFAULT NULL,
  Fecha date DEFAULT NULL,
  Cantidad int(11) DEFAULT NULL,
  Subtotal decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (IDFolio)
);

#
# Structure for table "NotaTerminacion"
#

CREATE TABLE IF NOT EXISTS NotaTerminacion (
  FolioNota int(11) NOT NULL AUTO_INCREMENT,
  IDPedido char(10) DEFAULT NULL,
  Laboratorista char(20) DEFAULT NULL,
  FechaEmision date DEFAULT NULL,
  FechaEntrega date DEFAULT NULL,
  FechaTermiado date DEFAULT NULL,
  IDCompra int(11) DEFAULT NULL,
  PRIMARY KEY (FolioNota)
);

#
# Structure for table "OficioConfirmacion"
#

CREATE TABLE IF NOT EXISTS OficioConfirmacion (
  FolioOficio int(11) NOT NULL AUTO_INCREMENT,
  IDPedido char(10) DEFAULT NULL,
  Emite char(20) DEFAULT NULL,
  FechaEmision date DEFAULT NULL,
  FechaConfirmado date DEFAULT NULL,
  PRIMARY KEY (FolioOficio)
);

#
# Structure for table "PagoEmpleados"
#

CREATE TABLE IF NOT EXISTS PagoEmpleados (
  IDPago int(11) NOT NULL AUTO_INCREMENT,
  FechaPago date DEFAULT NULL,
  Empleado char(10) DEFAULT NULL,
  Cantidad decimal(10,2) DEFAULT NULL,
  SemanaPago char(3) DEFAULT NULL,
  AñoPago char(5) DEFAULT NULL,
  PRIMARY KEY (IDPago)
);

#
# Structure for table "Pagos"
#

CREATE TABLE IF NOT EXISTS Pagos (
  IDPago int(11) NOT NULL AUTO_INCREMENT,
  Nombre char(50) DEFAULT NULL,
  Descripcion char(70) DEFAULT NULL,
  PrecioUnitario decimal(10,2) DEFAULT NULL,
  Cantidad int(11) DEFAULT NULL,
  Subtotal decimal(10,2) DEFAULT NULL,
  Total decimal(15,2) DEFAULT NULL,
  Estado int(1) DEFAULT NULL,
  Registro int(1) DEFAULT NULL,
  Fecha date DEFAULT NULL,
  IDCompra int(11) DEFAULT NULL,
  PRIMARY KEY (IDPago)
);

#
# Structure for table "Pedido"
#

CREATE TABLE IF NOT EXISTS Pedido (
  IDPedido char(10) NOT NULL,
  IDEmpleado char(30) DEFAULT NULL,
  Cedula char(10) DEFAULT NULL,
  EstadoPedido int(11) DEFAULT NULL,
  FechaIngreso datetime DEFAULT NULL,
  FechaCalculada date DEFAULT NULL,
  FechaEntrega datetime DEFAULT NULL,
  Entregado char(1) NOT NULL DEFAULT '0',
  Urgencia char(1) DEFAULT NULL,
  CostoTotal decimal(10,2) DEFAULT NULL,
  Laboratorista char(20) DEFAULT NULL,
  Pagado char(5) DEFAULT 'NO',
  RestantePagar decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (IDPedido),
  KEY ValidarDentista (Cedula),
  CONSTRAINT ValidarDentista FOREIGN KEY (Cedula) REFERENCES dentista (Cedula)
);

#
# Structure for table "Producto"
#

CREATE TABLE IF NOT EXISTS Producto (
  IDProducto int(11) NOT NULL AUTO_INCREMENT,
  Nombre char(50) DEFAULT NULL,
  Descripcion char(40) DEFAULT NULL,
  TiempoBase char(3) DEFAULT NULL,
  PrecioBase decimal(10,2) DEFAULT NULL,
  PrecioCompra decimal(10,2) DEFAULT NULL,
  Activo char(1) DEFAULT NULL,
  UnidadMedida char(10) DEFAULT NULL,
  Cantidad int(11) DEFAULT NULL,
  PRIMARY KEY (IDProducto)
);

#
# Structure for table "Producto_Pedido"
#

CREATE TABLE IF NOT EXISTS Producto_Pedido (
  IDPedido char(10) DEFAULT NULL,
  IDProducto int(11) DEFAULT NULL,
  PrecioProducto decimal(10,2) DEFAULT NULL,
  IDMaterial1 int(11) DEFAULT NULL,
  PrecioMaterial1 decimal(10,2) DEFAULT NULL,
  IDMaterial2 int(11) DEFAULT NULL,
  PrecioMaterial2 decimal(10,2) DEFAULT NULL,
  Subtotal decimal(10,2) DEFAULT NULL,
  Cantidad int(11) DEFAULT NULL
);

#
# Structure for table "Proveedores"
#

CREATE TABLE IF NOT EXISTS Proveedores (
  IDProveedor int(11) NOT NULL AUTO_INCREMENT,
  Nombre char(50) DEFAULT NULL,
  Telefono char(10) DEFAULT NULL,
  Correo char(70) DEFAULT NULL,
  Direccion char(100) DEFAULT NULL,
  Descripcion char(50) DEFAULT NULL,
  Estado int(1) DEFAULT NULL,
  Banco varchar(100) DEFAULT NULL,
  NumeroCuenta varchar(50) DEFAULT NULL,
  PRIMARY KEY (IDProveedor)
);

#
# Structure for table "Usuario"
#

CREATE TABLE IF NOT EXISTS Usuario (
  N_Empleado int(11) NOT NULL,
  Login char(30) NOT NULL,
  Password char(30) DEFAULT NULL,
  Nombre char(50) DEFAULT NULL,
  Apellidos char(50) DEFAULT NULL,
  FechaNacimiento date DEFAULT NULL,
  NumCasa char(10) DEFAULT NULL,
  Direccion char(80) DEFAULT NULL,
  Colonia char(30) DEFAULT NULL,
  Ciudad char(30) DEFAULT NULL,
  Municipio char(50) DEFAULT NULL,
  Estado char(30) DEFAULT NULL,
  Pais char(30) DEFAULT NULL,
  CodPos char(11) DEFAULT NULL,
  TelCasa char(45) DEFAULT NULL,
  TelOficina char(45) DEFAULT NULL,
  TelCel char(45) DEFAULT NULL,
  Email char(70) DEFAULT NULL,
  Pregunta char(100) DEFAULT NULL,
  Respuesta char(100) DEFAULT NULL,
  Activo char(1) DEFAULT NULL,
  Departamento char(50) DEFAULT NULL,
  Puesto char(20) DEFAULT NULL,
  FechaIngreso date DEFAULT NULL,
  Sueldo decimal(10,2) DEFAULT NULL,
  RFC varchar(15) NOT NULL DEFAULT '',
  PRIMARY KEY (Login)
);

#
# Structure for table "Tarjetas"
#

CREATE TABLE IF NOT EXISTS Tarjetas (
  login varchar(30) NOT NULL,
  numero varchar(16) NOT NULL,
  titular varchar(50) NOT NULL,
  apellidos varchar(50) NOT NULL,
  banco varchar(50) NOT NULL,
  fven varchar(6) NOT NULL DEFAULT '',
  activo char(1) NOT NULL DEFAULT '1',
  KEY FK (login),
  CONSTRAINT FK FOREIGN KEY (login) REFERENCES usuario (Login)
);

#
# Structure for table "Ventas"
#

CREATE TABLE IF NOT EXISTS Ventas (
  IDVenta int(11) NOT NULL AUTO_INCREMENT,
  IDPedido char(10) DEFAULT NULL,
  Importe decimal(10,2) DEFAULT NULL,
  Recibido decimal(10,2) DEFAULT NULL,
  FechaPago datetime DEFAULT NULL,
  Login char(30) DEFAULT NULL,
  PersonaPaga char(50) DEFAULT NULL,
  FormaPago char(10) DEFAULT NULL,
  Cedula char(10) DEFAULT NULL,
  PRIMARY KEY (IDVenta)
);