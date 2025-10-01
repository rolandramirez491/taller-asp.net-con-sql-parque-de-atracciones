--create Database AtraccionDB
--use AtraccionDB

-- Tabla Atracciones
CREATE TABLE Atracciones (
CodA INT PRIMARY KEY,
NombreA VARCHAR(50),
Precio int,
Capacidad Int
);
GO
-- Insertar Atraccion
CREATE PROCEDURE sp_InsertarAtraccion
@CodA INT,
@NombreA VARCHAR(50),
@Precio Int,
@Capacidad Int
AS
BEGIN
INSERT INTO Atracciones(CodA, NombreA, Precio,Capacidad)
VALUES (@CodA, @NombreA, @Precio,@Capacidad);
END
GO
-- Actualizar Atraccion
CREATE PROCEDURE sp_ActualizarAtraccion
@CodA INT,
@NombreA VARCHAR(50),
@Precio Int,
@Capacidad Int
AS
BEGIN
UPDATE Atracciones
SET NombreA=@NombreA, Precio=@Precio, Capacidad=@Capacidad
WHERE CodA=@CodA;
END
GO
-- Eliminar Atraccion
CREATE PROCEDURE sp_EliminarAtraccion
@CodA INT
AS
BEGIN
DELETE FROM Atracciones WHERE CodA=@CodA;
DELETE FROM Atracciones WHERE CodA=1;DELETE FROM Juegos WHERE CodJ=1;DELETE FROM Juegos WHERE CodJ=2;DELETE FROM Juegos WHERE CodJ=3;SELECT * FROM Atracciones;SELECT * FROM Juegos;

END
GO
-- Listar Atracciones
CREATE PROCEDURE sp_ListarAtracciones
AS
BEGIN
SELECT * FROM Atracciones;
END

GO
-- Buscar Atracciones
CREATE PROCEDURE sp_BuscarAtraccion
@CodA int
AS
BEGIN
SELECT * FROM Atracciones WHERE CodA=@CodA;
END
GO

---------------------------------------------- Tabla juegos-------------------------------------------
CREATE TABLE Juegos (
CodJ INT PRIMARY KEY,
NombreJ VARCHAR(50),
Duracion int,
Categoria VARCHAR(50)
);
GO
-- Insertar Juego
CREATE PROCEDURE sp_InsertarJuego
@CodJ INT,
@NombreJ VARCHAR(50),
@Duracion Int,
@Categoria VARCHAR(50)

AS
BEGIN
INSERT INTO Juegos(CodJ, NombreJ, Duracion,Categoria)
VALUES (@CodJ, @NombreJ, @Duracion,@Categoria);
END
GO
-- Actualizar Juego
CREATE PROCEDURE sp_ActualizarJuego
@CodJ INT,
@NombreJ VARCHAR(50),
@Duracion Int,
@Categoria VARCHAR(50)
AS
BEGIN
UPDATE Juegos
SET NombreJ=@NombreJ, Duracion=@Duracion, Categoria=@Categoria
WHERE CodJ=@CodJ;
END
GO
-- Eliminar Juego
CREATE PROCEDURE sp_EliminarJuego
@CodJ INT
AS
BEGIN
DELETE FROM Juegos WHERE CodJ=@CodJ;
--DELETE FROM Juegos WHERE CodJ=1;
END
GO
-- Listar Juegos
CREATE PROCEDURE sp_ListarJuegos
AS
BEGIN
SELECT * FROM Juegos;
END

GO
-- Buscar Juegos
CREATE PROCEDURE sp_BuscarJuego
@CodJ int
AS
BEGIN
SELECT * FROM Juegos WHERE CodJ=@CodJ;
END
GO

---------------------------------------------------------------------- Tabla Sesion Juego-------------------
CREATE TABLE Sesion (
IdSesion INT primary key,
CodA Int,
CodJ Int,
NumeroZona Int,
Hora Int,
Boletos Int,
FOREIGN KEY (CodA) REFERENCES Atracciones (CodA),
FOREIGN KEY (CodJ) REFERENCES Juegos (CodJ)
);
GO
-- Insertar Sesion Juego
CREATE PROCEDURE sp_InsertarSesion
@IdSesion INT,
@CodA Int,
@CodJ Int,
@NumeroZona Int,
@Hora Int,
@Boletos Int

AS
BEGIN
INSERT INTO Sesion(IdSesion, CodA, CodJ, NumeroZona,Hora,Boletos)
VALUES (@IdSesion,@CodA,@CodJ, @NumeroZona,@Hora,@Boletos);
END
GO
-- Actualizar Sesion Juego
CREATE PROCEDURE sp_ActualizarSesion
@IdSesion INT,
@CodA Int,
@CodJ Int,
@NumeroZona Int,
@Hora Int,
@Boletos Int
AS
BEGIN
UPDATE Sesion
SET CodA=@CodA, CodJ=@CodJ, NumeroZona=@NumeroZona ,Hora=@Hora, Boletos=@Boletos
WHERE IdSesion=@IdSesion;
END
GO
-- Eliminar Sesion Juego
CREATE PROCEDURE sp_EliminarSesion
@IdSesion INT
AS
BEGIN
DELETE FROM Sesion WHERE IdSesion=@IdSesion;
END
GO
-- Listar Sesion Juegos
CREATE PROCEDURE sp_ListarSesiones
AS
BEGIN
SELECT * FROM Sesion;
END

GO
-- Buscar Sesion Juegos
CREATE PROCEDURE sp_BuscarSesion
@IdSesion int
AS
BEGIN
SELECT * FROM Sesion WHERE IdSesion=@IdSesion;
END
GO