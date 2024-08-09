USE UgQueenDatabase
GO


-- ----------------------
-- Galeria_Albun
-- ----------------------

-- Registrar Galeria
CREATE OR ALTER PROCEDURE sp_registrar_galeria
    @CandidataID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX),
    @Portada VARBINARY(MAX)
AS
BEGIN
    INSERT INTO Galeria_Albun(
        CandidataID,
        Titulo,
        Descripcion,
        Portada
    )
    VALUES (
        @CandidataID,
        @Titulo,
        @Descripcion,
        @Portada
    )
END;
GO

-- Actualizar Galeria
CREATE OR ALTER PROCEDURE sp_actualizar_galeria
    @GaleriaID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX),
    @Portada VARBINARY(MAX)
AS
BEGIN
    UPDATE Galeria_Albun
    SET
        Titulo = @Titulo,
        Descripcion = @Descripcion
        Portada = @Portada
    WHERE GaleriaID = @GaleriaID
END;
GO

-- Obtener Galeria
CREATE OR ALTER PROCEDURE sp_obtener_galeria
    @GaleriaID INT
AS
BEGIN
    SELECT
        *
    FROM Galeria_Albun
    WHERE GaleriaID = @GaleriaID
END;
GO

-- Eliminar Galeria
CREATE OR ALTER PROCEDURE sp_eliminar_galeria
    @GaleriaID INT
AS
BEGIN
    DELETE FROM Galeria_Albun
    WHERE GaleriaID = @GaleriaID
END;
GO

-- Obtener Fotos por Galeria
CREATE OR ALTER PROCEDURE sp_obtener_fotos_por_galeria
    @GaleriaID INT
AS
BEGIN
    SELECT
        *
    FROM Foto
    WHERE GaleriaID = @GaleriaID
END;
GO

-- Obtener Galeria
CREATE OR ALTER PROCEDURE sp_filtrar_galeria
	@Condicion NVARCHAR(100),
    @CandidataID INT
AS
BEGIN
	SELECT *
	FROM Galeria_Albun
    WHERE CandidataID LIKE @Condicion+'%' OR Titulo LIKE @Condicion+'%' OR Descripcion LIKE @Condicion+'%' AND CandidataID = @CandidataID
END;
GO

-- obtener galerias de candidata
CREATE OR ALTER PROCEDURE sp_obtener_galerias_candidata
    @CandidataID INT
AS
BEGIN
    SELECT
        *
    FROM Galeria_Albun
    WHERE CandidataID = @CandidataID
END;
GO