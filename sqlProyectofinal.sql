--create Database ProdAgricolaDB
--use ProdAgricolaDB



-- Tabla Produtos
CREATE TABLE Productos (
CodProducto INT PRIMARY KEY,
NombreP VARCHAR(50),
TipoP VARCHAR(50),
Variedad VARCHAR(50),
PrecioP Int,
UnidadDeMed Varchar(50),
StockP Int,
Descripcion VARCHAR(50),
Caracteristicas VARCHAR(50)
);
GO
-- Insertar Produtos
CREATE PROCEDURE sp_InsertarProductos
@CodProducto INT,
@NombreP VARCHAR(50),
@TipoP VARCHAR(50),
@Variedad VARCHAR(50),
@PrecioP Int,
@UnidadDeMed Varchar(50),
@StockP Int,
@Descripcion VARCHAR(50),
@Caracteristicas VARCHAR(50)
AS
BEGIN
INSERT INTO Productos(CodProducto, NombreP, TipoP,Variedad,PrecioP,UnidadDeMed,Stockp,Descripcion,Caracteristicas)
VALUES (@CodProducto, @NombreP, @TipoP,@Variedad,@PrecioP,@UnidadDeMed,@Stockp,@Descripcion,@Caracteristicas);
END
GO
-- Actualizar Produtos
CREATE PROCEDURE sp_ActualizarProductos
@CodProducto INT,
@NombreP VARCHAR(50),
@TipoP VARCHAR(50),
@Variedad VARCHAR(50),
@PrecioP Int,
@UnidadDeMed Varchar(50),
@StockP Int,
@Descripcion VARCHAR(50),
@Caracteristicas VARCHAR(50)
AS
BEGIN
UPDATE Productos
SET CodProducto=@CodProducto, NombreP=@NombreP, TipoP=@TipoP, Variedad=@Variedad, PrecioP=@PrecioP, UnidadDeMed=@UnidadDeMed, StockP=@StockP, Descripcion=@Descripcion, Caracteristicas=@Caracteristicas
WHERE CodProducto=@CodProducto;
END
GO
-- Eliminar Produtos
CREATE PROCEDURE sp_EliminarProductos
@CodProducto INT
AS
BEGIN
DELETE FROM Productos WHERE CodProducto=@CodProducto;

END
GO

-- Buscar Produtos Por Nombre
CREATE PROCEDURE sp_BuscarProductoNombre
@NombreP int
AS
BEGIN
SELECT * FROM Productos WHERE NombreP=@NombreP;
END
GO

-- Buscar Produtos Por Tipo
CREATE PROCEDURE sp_BuscarProductoTipo
@TipoP int
AS
BEGIN
SELECT * FROM Productos WHERE TipoP=@TipoP;
END
GO

-- Buscar Produtos Por Precio
CREATE PROCEDURE sp_BuscarProductoPrecio
@PrecioP int
AS
BEGIN
SELECT * FROM Productos WHERE PrecioP=@PrecioP;
END
GO

-- Buscar Produtos Por Stock
CREATE PROCEDURE sp_BuscarProductoStock
@StockP int
AS
BEGIN
SELECT * FROM Productos WHERE StockP=@StockP;
END
GO

-- Listado de productos para venta
CREATE PROCEDURE sp_ListarProductos
AS
BEGIN
SELECT * FROM Productos;
END

GO

---------------------------------------------- Tabla Clientes-------------------------------------------
CREATE TABLE Clientes (
CodCliente INT PRIMARY KEY,
Nombre VARCHAR(50),
Contacto VARCHAR(50),
Ubicacion VARCHAR(50),
TipoDeCliente VARCHAR(50)
);
GO
-- Insertar Clientes
CREATE PROCEDURE sp_InsertarCliente
@CodCliente INT,
@Nombre VARCHAR(50),
@Contacto VARCHAR(50),
@Ubicacion VARCHAR(50),
@TipoDeCliente VARCHAR(50)

AS
BEGIN
INSERT INTO Clientes(CodCliente, Nombre, Contacto,Ubicacion,TipoDeCliente)
VALUES (@CodCliente, @Nombre, @Contacto,@Ubicacion,@TipoDeCliente);
END
GO
-- Actualizar Clientes
CREATE PROCEDURE sp_ActualizarCliente
@CodCliente INT,
@Nombre VARCHAR(50),
@Contacto VARCHAR(50),
@Ubicacion VARCHAR(50),
@TipoDeCliente VARCHAR(50)
AS
BEGIN
UPDATE Clientes
SET Nombre=@Nombre, Contacto=@Contacto, Ubicacion=@Ubicacion, TipoDeCliente=@TipoDeCliente
WHERE CodCliente=@CodCliente;
END
GO
-- Eliminar Cliente
CREATE PROCEDURE sp_EliminarCliente
@CodCLiente INT
AS
BEGIN
DELETE FROM Clientes WHERE CodCliente=@CodCLiente;
--DELETE FROM Clientes WHERE CodCliente=1;
END
GO


-- Buscar para luego habilitar actualizar
CREATE PROCEDURE sp_BuscarCliente
@CodCliente int
AS
BEGIN
SELECT * FROM Clientes WHERE CodCliente=@CodCliente;
END
GO

-- Listado general de clientes
CREATE PROCEDURE sp_ListarClientes
AS
BEGIN
SELECT * FROM Clientes;
END
GO

-- Historial de pedidos por cliente sirve tambien para informe de ventas por cliente
CREATE OR ALTER PROCEDURE sp_BuscarClienteOinforme
  @CodCliente INT
AS
BEGIN
  SELECT * FROM dbo.Pedidos
  WHERE CodCliente = @CodCliente;
END
GO

---------------------------------------------------------------------- Tabla Pedidos-------------------
CREATE TABLE Pedidos (
CodPedido INT PRIMARY KEY,
Estado VARCHAR(50) NOT NULL,
CodCliente INT NOT NULL,

FOREIGN KEY (CodCliente) REFERENCES dbo.Clientes(CodCliente)
--FOREIGN KEY (CodCliente) REFERENCES dbo.Clientes(CodCliente)
);
Go



-- Insertar Pedidos
CREATE PROCEDURE sp_InsertarPedido
@CodPedido int,
@Estado Varchar(50)

AS
BEGIN
INSERT INTO Pedidos(CodPedido, Estado)
VALUES (@CodPedido, @Estado);
END
GO
-- Edicion de pedidos
CREATE PROCEDURE sp_ActualizarPedido
@CodPedido int,
@Estado Varchar(50)
AS
BEGIN
UPDATE Pedidos
SET Estado=@Estado
WHERE CodPedido=@CodPedido;
END
GO
-- Eliminar Pedidos este no se necesita
CREATE PROCEDURE sp_EliminarPedidos
@CodPedido INT
AS
BEGIN
DELETE FROM Pedidos WHERE CodPedido=@CodPedido;
END
GO
-- Listar Pedidos este no se necesita
CREATE PROCEDURE sp_ListarPedidos
AS
BEGIN
SELECT * FROM Pedidos;
END

GO
-- Buscar Pedidos
CREATE PROCEDURE sp_BuscarPedido
@CodPedido int
AS
BEGIN
SELECT * FROM Pedidos WHERE CodPedido=@CodPedido;
END
GO

------------------------------------tabla pagos--------------------------------------
CREATE TABLE Pagos(
CodPago Int Primary Key,
Tipo Varchar(50),
Monto Int,
Fecha Date,
Estado Varchar(50)
);
GO
--insertar pagos
CREATE PROCEDURE sp_InsertarPago
@CodPago int,
@Tipo Varchar(50),
@Monto Int,
@Fecha Date,
@Estado Varchar(50)
AS
Begin
Insert Into Pagos(CodPago,Tipo,Monto,Fecha,Estado)
Values (@CodPago,@Tipo,@Monto,@Fecha,@Estado);
End
Go

--filtro por fecha
CREATE PROCEDURE sp_FiltroFecha
@Fecha Date
As
Begin
SELECT * FROM Pagos Where Fecha=@Fecha
End
Go
--filtro por cliente
CREATE PROCEDURE sp_FiltroCliente
@CodCliente int
As
Begin
SELECT * FROM Clientes Where CodCliente=@CodCliente
End
Go
--filtro por estado
CREATE PROCEDURE sp_FiltroEstado
@Estado Varchar(50)
As
Begin
SELECT * FROM Pagos Where Estado=@Estado
End
Go

--------------------------------------------informes
----ventas por producto
--CodProducto INT PRIMARY KEY,
--NombreP VARCHAR(50),
--PrecioP Int,
--StockP Int,

--CREATE OR ALTER PROCEDURE sp_BuscarCliente
--  @CodCliente INT
--AS
--BEGIN
--  SELECT * FROM dbo.Pedidos
--  WHERE CodCliente = @CodCliente;
--END
--GO
--informe x producto
CREATE OR ALTER PROCEDURE sp_InformeXProductos
  @CodProducto INT
AS
BEGIN
  SELECT * FROM dbo.Pedidos
  WHERE CodProducto = @CodProducto;
END
GO

--informe x fecha
CREATE OR ALTER PROCEDURE sp_InformeXFecha
  @Fecha date --mismo codigo de codPedido para informe de ventas
AS
BEGIN
  SELECT * FROM Pagos
  WHERE Fecha = @Fecha;
END
GO