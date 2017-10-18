DROP PROCEDURE IF EXISTS R_DatosProveedores;
CREATE PROCEDURE R_DatosProveedores(
  dummy BOOL
)
  BEGIN
    SELECT *
    FROM proveedores;
  END;

DROP PROCEDURE IF EXISTS R_Materiales;
CREATE PROCEDURE R_Materiales(
  dummy BOOL
)
  BEGIN
    SELECT
      material.*,
      proveedores.Nombre AS NombreProveedor
    FROM material, proveedores
    WHERE proveedores.IDProveedor = material.Proveedor;
  END;

DROP PROCEDURE IF EXISTS R_ProductoMateriales;
CREATE PROCEDURE R_ProductoMateriales(
  dummy BOOL
)
  BEGIN
    SELECT
      producto.IDProducto,
      producto.Nombre                 AS ProNombre,
      producto.Descripcion            AS ProDescripcion,
      producto.TiempoBase,
      producto.PrecioBase,
      producto.PrecioCompra           AS ProPreCo,
      producto.UnidadMedida           AS ProUnMed,
      producto.Cantidad               AS ProCant,
      materiales_producto.IDMaterial,
      PrecioFinal,
      TiempoFinal,
      materiales_producto.Descripcion AS MatDescripcion,
      Medidas,
      material.Nombre                 AS MatNombre,
      material.Cantidad               AS MatCant,
      material.PrecioCompra           AS MatPreCo,
      material.UnidadMedida           AS MatUnMed
    FROM material, materiales_producto, producto
    WHERE materiales_producto.IDMaterial = material.IDMaterial AND producto.IDProducto = materiales_producto.IDProducto;
  END;

DROP PROCEDURE IF EXISTS R_CompraMateriales;
CREATE PROCEDURE R_CompraMateriales(
  dummy BOOL
)
  BEGIN
    SELECT
      compras.IDCompra,
      compras.Empleado,
      proveedores.Nombre AS ProvNom,
      detalle_compra_material.Subtotal,
      detalle_compra_material.Cantidad,
      material.PrecioCompra,
      compras.Total,
      compras.Fecha,
      compras.FechaSurtido,
      material.Nombre    AS MatNom
    FROM compras, proveedores, detalle_compra_material, material
    WHERE proveedores.IDProveedor = compras.IDProveedor AND compras.Tipo = 'MATERIAL' AND
          material.IDMaterial = detalle_compra_material.IDMaterial AND
          detalle_compra_material.IDCompra = compras.IDCompra;
  END;

DROP PROCEDURE IF EXISTS R_ComprasInsumos;
CREATE PROCEDURE R_ComprasInsumos(
  dummy BOOL
)
  BEGIN
    SELECT
      compras.IDCompra,
      Empleado,
      Total,
      Fecha,
      Tipo,
      FechaSurtido,
      Estado,
      detalle_compra_insumo.Nombre,
      detalle_compra_insumo.Descripcion,
      Cantidad,
      PrecioUnitario,
      Subtotal,
      proveedores.Nombre
    FROM compras, detalle_compra_insumo, proveedores
    WHERE compras.IDProveedor = proveedores.IDProveedor AND compras.Tipo = 'INSUMOS' AND
          compras.IDCompra = detalle_compra_insumo.IDCompra;
  END;

DROP PROCEDURE IF EXISTS R_VentasGeneradas;
CREATE PROCEDURE R_VentasGeneradas(
  dummy BOOL
)
  BEGIN
    SELECT
      IDVenta,
      ventas.IDPedido,
      Importe,
      Recibido,
      FechaPago,
      Login,
      PersonaPaga,
      FormaPago,
      producto_pedido.IDProducto,
      PrecioProducto,
      Subtotal,
      producto.Nombre,
      producto.Cantidad,
      producto.UnidadMedida
    FROM
      ventas, producto, producto_pedido
    WHERE ventas.IDPedido = producto_pedido.IDPedido AND producto_pedido.IDProducto = producto.IDProducto
    ORDER BY FechaPago DESC;
  END;

DROP PROCEDURE IF EXISTS R_GastosGeneradosMat;
CREATE PROCEDURE R_GastosGeneradosMat(
  NomMat VARCHAR(30),
  idComp INT(11)
)
  BEGIN
    SELECT
      compras.IDCompra,
      compras.Empleado,
      compras.IDProveedor,
      compras.Total,
      compras.Fecha,
      compras.Tipo,
      compras.FechaSurtido,
      compras.Estado,
      detalle_compra_material.IDMaterial,
      detalle_compra_material.Subtotal,
      detalle_compra_material.Cantidad,
      material.Nombre    AS MatNombre,
      material.UnidadMedida,
      proveedores.Nombre AS ProvNombre,
      proveedores.Correo,
      proveedores.Telefono
    FROM compras, detalle_compra_material, material, proveedores
    WHERE compras.IDCompra = detalle_compra_material.IDCompra AND compras.IDProveedor = proveedores.IDProveedor AND
          detalle_compra_material.IDMaterial = material.IDMaterial AND
          (material.Nombre LIKE concat('%', NomMat, '%') OR compras.IDCompra = idComp);
  END;

CALL R_GastosGeneradosIns('nombre1', 0);

DROP PROCEDURE IF EXISTS R_GastosGeneradosIns;
CREATE PROCEDURE R_GastosGeneradosIns(
  NomIs  VARCHAR(30),
  idComp INT(11)
)
  BEGIN
    SELECT
      compras.IDCompra,
      compras.Empleado,
      compras.IDProveedor,
      compras.Total,
      compras.Fecha,
      compras.Tipo,
      compras.FechaSurtido,
      compras.Estado,
      detalle_compra_insumo.Nombre AS InsuNom,
      detalle_compra_insumo.Descripcion,
      detalle_compra_insumo.Cantidad,
      detalle_compra_insumo.PrecioUnitario,
      detalle_compra_insumo.Subtotal,
      proveedores.Nombre           AS ProvNombre,
      proveedores.Correo,
      proveedores.Telefono
    FROM compras, detalle_compra_insumo, proveedores
    WHERE compras.IDCompra = detalle_compra_insumo.IDCompra AND
          compras.IDProveedor = proveedores.IDProveedor AND
          (detalle_compra_insumo.Nombre LIKE concat('%', NomIs, '%') OR compras.IDCompra = idComp);
  END;

DROP PROCEDURE IF EXISTS R_GastosGeneradosGeneral;
CREATE PROCEDURE R_GastosGeneradosGeneral(
  dummy BOOL
)
  BEGIN
    SELECT
      compras.IDCompra,
      compras.Empleado,
      compras.IDProveedor,
      compras.Total,
      compras.Fecha,
      compras.Tipo,
      compras.FechaSurtido,
      compras.Estado,
      material.Nombre                  AS MatNom,
      detalle_compra_material.Cantidad AS MatCant,
      detalle_compra_material.Subtotal AS MatSub,
      detalle_compra_insumo.Nombre     AS InNom,
      detalle_compra_insumo.Cantidad   AS InCat,
      detalle_compra_insumo.Subtotal   AS InSub
    FROM compras
      LEFT JOIN detalle_compra_material ON compras.IDCompra = detalle_compra_material.IDCompra
      LEFT JOIN material ON detalle_compra_material.IDMaterial = material.IDMaterial
      LEFT JOIN detalle_compra_insumo ON detalle_compra_insumo.IDCompra = compras.IDCompra;
  END;

DROP PROCEDURE IF EXISTS R_NominaGeneral;
CREATE PROCEDURE R_NominaGeneral(
  dummy BOOL
)
  BEGIN
    SELECT
      IDPago,
      FechaPago,
      Empleado,
      Cantidad,
      SemanaPago,
      AñoPago,
      usuario.Nombre,
      usuario.Apellidos
    FROM pagoempleados, usuario
    WHERE pagoempleados.Empleado = usuario.N_Empleado;
  END;

DROP PROCEDURE IF EXISTS R_NominaEmpleado;
CREATE PROCEDURE R_NominaEmpleado(
  idPag INT(11)
)
  BEGIN
    SELECT
      IDPago,
      FechaPago,
      Empleado,
      Cantidad,
      SemanaPago,
      AñoPago,
      usuario.Nombre,
      usuario.Apellidos,
      usuario.FechaIngreso,
      usuario.TelCasa,
      usuario.Email,
      usuario.Departamento
    FROM pagoempleados, usuario
    WHERE usuario.N_Empleado = pagoempleados.Empleado AND pagoempleados.IDPago = idPag;
  END;

