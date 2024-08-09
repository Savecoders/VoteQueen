USE UgQueenDatabase
GO

-- ----------------------
-- Usuario Administrador
-- ----------------------

-- Login Administrador
CREATE OR ALTER PROCEDURE sp_login_administrador
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Administrador
    WHERE Correo = @Correo AND Contrasena = @Contrasena AND Nombre = @Nombre
END;
GO

-- Registrar Administrador
CREATE OR ALTER PROCEDURE sp_registrar_administrador
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @FotoPerfil VARBINARY(MAX),
    @Cargo NVARCHAR(100)
AS
BEGIN
    INSERT INTO Administrador (
        Nombre,
        Correo,
        Contrasena,
        FotoPerfil,
        Cargo
    )
    VALUES (
        @Nombre,
        @Correo,
        @Contrasena,
        @FotoPerfil,
        @Cargo
    )
END;

GO

-- Actualizar Administrador
CREATE OR ALTER PROCEDURE sp_actualizar_administrador
    @AdministradorID INT,
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @FotoPerfil VARBINARY(MAX),
    @Cargo NVARCHAR(100)

AS
BEGIN
    UPDATE Administrador
    SET
        Nombre = @Nombre,
        Correo = @Correo,
        Contrasena = @Contrasena,
        FotoPerfil = @FotoPerfil,
        Cargo = @Cargo
    WHERE AdministradorID = @AdministradorID
END;
GO

-- Existe Administrador
CREATE OR ALTER PROCEDURE sp_existe_administrador
    @Correo NVARCHAR(100)
AS
BEGIN
    SELECT COUNT(*) AS Existe
    FROM Administrador
    WHERE Correo = @Correo
END;
GO

-- Obtener Administrador
CREATE OR ALTER PROCEDURE sp_obtener_administrador
	@Correo NVARCHAR(100)
AS
BEGIN
	SELECT AdministradorID, Nombre, Correo, FotoPerfil, Cargo
	FROM Administrador
	WHERE Correo = @Correo
END;
GO