Use UgQueenDatabase
GO

-- ----------------------
-- Foto
-- ----------------------

-- Registrar Foto

CREATE OR ALTER PROCEDURE sp_registrar_foto
    @GaleriaID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX),
    @Imagen VARBINARY(MAX)
AS
BEGIN
    INSERT INTO Foto (
        GaleriaID,
        Titulo,
        Descripcion,
        Imagen
    )
    VALUES (
        @GaleriaID,
        @Titulo,
        @Descripcion,
        @Imagen
    )
END;
GO

-- Actualizar Foto

CREATE OR ALTER PROCEDURE sp_actualizar_foto
    @FotoID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX),
    @Imagen VARBINARY(MAX)
AS
BEGIN
    UPDATE Foto
    SET
        Titulo = @Titulo,
        Descripcion = @Descripcion,
        Imagen = @Imagen
    WHERE FotoID = @FotoID
END;
GO

-- Eliminar Foto

CREATE OR ALTER PROCEDURE sp_eliminar_foto
    @FotoID INT
AS
BEGIN
    DELETE FROM Foto
    WHERE FotoID = @FotoID
END;
GO
