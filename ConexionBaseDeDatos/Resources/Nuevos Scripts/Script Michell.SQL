#En este archivo de texto sólo Michell deberá meter sus procedimientos almacenados

#
# Trigger "TriggActualizarPedido"
#

DROP TRIGGER IF EXISTS TriggActualizarPedido;
CREATE TRIGGER TriggActualizarPedido
  AFTER INSERT ON Ventas
  FOR EACH ROW
BEGIN
  IF (SELECT Pedido.RestantePagar FROM Pedido WHERE Pedido.IDPedido = NEW.IDPedido LIMIT 1) = NEW.Importe THEN
    UPDATE Pedido SET Pagado = 'SI';
  END IF;
  UPDATE Pedido SET RestantePagar = RestantePagar - NEW.Importe WHERE IDPedido = NEW.IDPedido;
END;

#
# Trigger "TriggVentaDevuelta"
#

DROP TRIGGER IF EXISTS TriggVentaDevuelta;
CREATE TRIGGER TriggVentaDevuelta
  AFTER DELETE ON Ventas
  FOR EACH ROW
BEGIN
  UPDATE Pedido SET RestantePagar = RestantePagar + OLD.Importe, Pedido.Pagado = IF(RestantePagar + OLD.Importe > 0, 'NO', 'SI') WHERE Pedido.IDPedido = OLD.IDPedido;
END;

#
# View "DetalleCorteCaja"
#

DROP VIEW IF EXISTS DetalleCorteCaja;
CREATE
  ALGORITHM = UNDEFINED
  VIEW DetalleCorteCaja
  AS
SELECT
  FolioCorte,
  Fecha,
  Empleado,
  Supervisor,
  FondoCaja,
  EntradaEfectivo AS 'Efectivo',
  EntradaCheque AS 'Cheque',
  EntradaTarjeta AS 'Tarjeta',
  NumVentas AS 'NumeroVentas',
  DineroCaja,
  ((DineroCaja - EntradaEfectivo) - FondoCaja) AS 'Diferencia',
  Comentario
FROM
  CorteCaja;

#
# View "DetalleVentas"
#

CREATE
  ALGORITHM = UNDEFINED
  VIEW DetalleVentas
  AS
(SELECT
  ventas.IDVenta,
  ventas.FechaPago,
  ventas.IDPedido,
  CONCAT(usuario.Nombre, ' ', usuario.Apellidos) AS 'RegistraVenta',
  ventas.Importe,
  ventas.PersonaPaga AS 'Referencia',
  ventas.FormaPago,
  ventas.Login,
  ventas.Recibido
FROM
  (ventas
    JOIN usuario)
WHERE
  (ventas.Login = usuario.Login));

#
# Procedure "AgregarCorteCaja"
#

DROP PROCEDURE IF EXISTS AgregarCorteCaja;
CREATE PROCEDURE AgregarCorteCaja(
  Emp char(30),
  Sup char(30),
  Fechita datetime,
  Fondo decimal(10,2),
  Efec decimal(10,2),
  Cheq decimal(10,2),
  Tar decimal(10,2),
  Ven int(11),
  Din decimal(10,2),
  Com char(100)
)
BEGIN
  INSERT IGNORE
    INTO CorteCaja
    (Fecha, Empleado, Supervisor, FondoCaja, EntradaEfectivo, EntradaCheque, EntradaTarjeta, NumVentas, DineroCaja, Comentario)
  VALUES
    (Fechita, Emp, Sup, Fondo, Efec, Cheq, Tar, Ven, Din, Com);
END;

#
# Procedure "BuscarPedidosParametros"
#

DROP PROCEDURE IF EXISTS BuscarPedidosParametros;
CREATE PROCEDURE BuscarPedidosParametros(
  IDPedid char(10),
  Empleado char(100),
  Dentista char(100),
  FechaMin datetime,
  FechaMax datetime,
  Urgente bool,
  NoPagado bool,
  Entregado int(11)
)
BEGIN
  SET Entregado = IFNULL(Entregado, 2);
  SELECT
    *
  FROM
    Pedido,
    Usuario,
    Dentista
  WHERE
    Pedido.IDEmpleado = Usuario.Login
      AND Pedido.Cedula = Dentista.Cedula
      AND IDPedido = IFNULL(IDPedid, IDPedido)
      AND CONCAT(Usuario.Nombre, ' ', Usuario.Apellidos) LIKE IFNULL(CONCAT(Empleado, '%'), CONCAT(Usuario.Nombre, ' ', Usuario.Apellidos))
      AND CONCAT(Dentista.Nombre, ' ', Dentista.Apellidos) LIKE IFNULL(CONCAT(Dentista, '%'), CONCAT(Dentista.Nombre, ' ', Dentista.Apellidos))
      AND Pedido.FechaIngreso >= IFNULL(FechaMin, Pedido.FechaIngreso)
      AND Pedido.FechaIngreso <= IFNULL(FechaMax, Pedido.FechaIngreso)
      AND Pedido.Urgencia = IF(Urgente = 1, '1', Pedido.Urgencia)
      AND Pedido.Pagado = IF(NoPagado = 1, 'NO', Pedido.Pagado)
      AND Pedido.Entregado = IF(Entregado = 2, Pedido.Entregado, IF(Entregado = 1, '1', IF(Entregado = 0, '0', 'N')));
END;
  
#
# Procedure "DevolucionPago"
#

DROP PROCEDURE IF EXISTS DevolucionPago;
CREATE PROCEDURE DevolucionPago(IDVent int)
BEGIN
  DELETE FROM Ventas WHERE Ventas.IDVenta = IDVent;
END;

#
# Procedure "EntregarPedido"
#

DROP PROCEDURE IF EXISTS EntregarPedido;
CREATE PROCEDURE EntregarPedido(IDPedid char(10), Fecha datetime)
BEGIN
  UPDATE Pedido SET Pedido.FechaEntrega = Fecha, Pedido.Entregado = '1' WHERE Pedido.IDPedido = IDPedid;
END;

#
# Procedure "InsertarVenta"
#

DROP PROCEDURE IF EXISTS InsertarVenta;
CREATE PROCEDURE InsertarVenta(
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
    INTO Ventas
    (IDPedido, Importe, Recibido, FechaPago, Login, PersonaPaga, FormaPago)
  VALUES
    (IDPedid, Importee, Recibid, FechaPag, Logi, PersonaPag, FormaPag);
END;

#
# Procedure "ObtenerDentista"
#

DROP PROCEDURE IF EXISTS ObtenerDentista;
CREATE PROCEDURE ObtenerDentista(Cedul char(10))
BEGIN
  SELECT * FROM dentista WHERE Cedula = Cedul;
END;

#
# Procedure "ObtenerMateriales"
#

DROP PROCEDURE IF EXISTS ObtenerMateriales;
CREATE PROCEDURE ObtenerMateriales()
BEGIN
  SELECT * FROM material;
END;

#
# Procedure "ObtenerPedidos"
#

DROP PROCEDURE IF EXISTS ObtenerPedidos;
CREATE PROCEDURE ObtenerPedidos()
BEGIN
  SELECT * FROM pedido;
END;

#
# Procedure "ObtenerPermisoAdministrador"
#

DROP PROCEDURE IF EXISTS ObtenerPermisoAdministrador;
CREATE PROCEDURE ObtenerPermisoAdministrador(pass varchar(30))
BEGIN
  SELECT
    Password AS 'result'
  FROM
    Usuario
  WHERE
    Password = pass
      AND Puesto = 'ADMINISTRADOR'
      AND Departamento = 'ADMINISTRACION'
      AND Activo = '1';
END;

#
# Procedure "ObtenerProductos"
#

DROP PROCEDURE IF EXISTS ObtenerProductos;
CREATE PROCEDURE ObtenerProductos()
BEGIN
  SELECT * FROM producto;
END;

#
# Procedure "RecuperarMaterial"
#

DROP PROCEDURE IF EXISTS RecuperarMaterial;
CREATE PROCEDURE RecuperarMaterial(IDMateria int)
BEGIN
  SELECT * FROM material WHERE IDMaterial = IDMateria;
END;

#
# Procedure "RecuperarPedido"
#

DROP PROCEDURE IF EXISTS RecuperarPedido;
CREATE PROCEDURE RecuperarPedido(IDPedid char(10))
BEGIN
  SELECT * FROM pedido WHERE IDPedido = IDPedid;
END;

#
# Procedure "RecuperarProducto"
#

DROP PROCEDURE IF EXISTS RecuperarProducto;
CREATE PROCEDURE RecuperarProducto(IDProduct int)
BEGIN
  SELECT * FROM producto WHERE IDProducto = IDProduct;
END;

#
# Procedure "RecuperarProveedor"
#

DROP PROCEDURE IF EXISTS RecuperarProveedor;
CREATE PROCEDURE RecuperarProveedor(Proveedo int)
BEGIN
  SELECT * FROM proveedores WHERE IDProveedor = Proveedo;
END;

#
# Procedure "RecuperarTicket"
#

DROP PROCEDURE IF EXISTS RecuperarTicket;
CREATE PROCEDURE RecuperarTicket(IDVent int)
BEGIN
  DECLARE _Pedido char(10) DEFAULT NULL;
  DECLARE _Fecha datetime DEFAULT NULL;
  DECLARE _Importe decimal(10,2) DEFAULT NULL;
  SET _Pedido = (SELECT Ventas.IDPedido FROM Ventas WHERE IDVenta = IDVent);
  SET _Fecha = (SELECT FechaPago FROM Ventas WHERE IDVenta = IDVent);
  SET _Importe = (SELECT SUM(Ventas.Importe) FROM Ventas WHERE IDPedido = _Pedido AND Ventas.FechaPago <= _Fecha);
  SELECT
    Ventas.IDVenta,
    Ventas.FechaPago,
    Ventas.IDPedido,
    Usuario.Nombre,
    Ventas.Importe,
    Ventas.Recibido,
    Ventas.Recibido - Ventas.Importe AS 'Cambio',
    Ventas.PersonaPaga AS 'Referencia',
    CONVERT(Pedido.CostoTotal - _Importe, decimal(10,2)) AS 'Restante'
  FROM
    Ventas,
    Usuario,
    Pedido
  WHERE
    Ventas.Login = Usuario.Login AND Pedido.IDPedido = Ventas.IDPedido AND Ventas.IDVenta = IDVent;
END;

#
# Procedure "RecuperarTrabajos"
#

DROP PROCEDURE IF EXISTS RecuperarTrabajos;
CREATE PROCEDURE RecuperarTrabajos(IDPedid char(10))
BEGIN
  SELECT * FROM producto_pedido WHERE IDPedido = IDPedid;
END;

#
# Procedure "UltimoCorteCaja"
#

DROP PROCEDURE IF EXISTS UltimoCorteCaja;
CREATE PROCEDURE UltimoCorteCaja()
BEGIN
  SELECT * FROM CorteCaja ORDER BY FolioCorte DESC LIMIT 1;
END;

#
# Procedure "VerVentas"
#

DROP PROCEDURE IF EXISTS VerVentas;
CREATE PROCEDURE VerVentas(
  IDVent int,
  FechaPagoMin datetime,
  FechaPagoMax datetime,
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
    Detalleventas
  WHERE
    IDVenta = IF(IDVent != 0, IDVent, IDVenta)
      AND (FECHAPAGO >= IFNULL(FECHAPAGOMIN, FECHAPAGO) AND FECHAPAGO <= IFNULL(FECHAPAGOMAX, FECHAPAGO))
      AND IDPEDIDO = IFNULL(IDPEDID, IDPEDIDO)
      AND REGISTRAVENTA LIKE IFNULL(CONCAT(NOMBRE, '%'), REGISTRAVENTA)
      AND REFERENCIA LIKE IFNULL(CONCAT(REFERENCI, '%'), REFERENCIA)
      AND (FORMAPAGO = IF(EFECTIVO = 1, 'EFECTIVO', '') OR FORMAPAGO = IF(TARJETA = 1, 'TARJETA', '') OR FORMAPAGO = IF(CHEQUE = 1, 'CHEQUE', ''));
END;