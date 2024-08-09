
-- ----------------------
-- Candidata
-- ----------------------

-- Registrar Candidata
CREATE OR ALTER PROCEDURE sp_registrar_candidata
    @Nombre NVARCHAR(100),
    @FotoPrincipal VARBINARY(MAX),
    @Edad INT,
    @Telefono NVARCHAR(MAX),
    @Fecha_Nacimiento DATE,
    @Pasatiempos NVARCHAR(MAX),
    @Habilidades NVARCHAR(MAX),
    @Intereses NVARCHAR(MAX),
    @Aspiraciones NVARCHAR(MAX),
    @Carrera NVARCHAR(100),
    @Nivel INT
AS
BEGIN
    INSERT INTO Candidata (
        Nombre,
        FotoPrincipal,
        Edad,
        Telefono,
        Pasatiempos,
        Habilidades,
        Intereses,
        Aspiraciones,
        Carrera,
        Nivel
    )
    VALUES (
        @Nombre,
        @FotoPrincipal,
        @Edad,
        @Telefono,
        @Pasatiempos,
        @Habilidades,
        @Intereses,
        @Aspiraciones,
        @Carrera,
        @Nivel
    )
END;
GO

-- Actualizar Candidata
CREATE OR ALTER PROCEDURE sp_actualizar_candidata
    @CandidataID INT,
    @Nombre NVARCHAR(100),
    @FotoPrincipal VARBINARY(MAX),
    @Edad INT,
    @Telefono NVARCHAR(MAX),
    @Fecha_Nacimiento DATE,
    @Pasatiempos NVARCHAR(MAX),
    @Habilidades NVARCHAR(MAX),
    @Intereses NVARCHAR(MAX),
    @Aspiraciones NVARCHAR(MAX),
    @Carrera NVARCHAR(100),
    @Nivel INT
AS
BEGIN
    UPDATE Candidata
    SET
        Nombre = @Nombre,
        FotoPrincipal = @FotoPrincipal,
        Edad = @Edad,
        Telefono = @Telefono,
        Fecha_Nacimiento = @Fecha_Nacimiento,
        Pasatiempos = @Pasatiempos,
        Habilidades = @Habilidades,
        Intereses = @Intereses,
        Aspiraciones = @Aspiraciones,
        Carrera = @Carrera,
        Nivel = @Nivel
    WHERE CandidataID = @CandidataID
END;
GO

-- Eliminar Candidata
CREATE OR ALTER PROCEDURE sp_eliminar_candidata
    @CandidataID INT
AS
BEGIN
    DELETE FROM Candidata
    WHERE CandidataID = @CandidataID
END;
GO

-- Obtener Candidatas
CREATE OR ALTER PROCEDURE sp_obtener_candidatas
AS
BEGIN
	SELECT *
	FROM Candidata
END;
GO


-- Obtener Candidata
CREATE OR ALTER PROCEDURE sp_buscar_candidata
	@Nombre NVARCHAR(100) 
AS
BEGIN
	SELECT *
	FROM Candidata
	WHERE Nombre = @Nombre
END;
GO

-- Obtener Candidata
CREATE OR ALTER PROCEDURE sp_filtrar_candidatas
	@Condicion NVARCHAR(100) 
AS
BEGIN
	SELECT *
	FROM Candidata
	WHERE CandidataID LIKE @Condicion+'%' OR Nombre LIKE @Condicion+'%' OR Carrera LIKE @Condicion+'%'
END;
GO


-- Obtener Total de Galerias de Candidata
CREATE OR ALTER PROCEDURE sp_obtener_total_galerias_candidata
    @CandidataID INT
AS
BEGIN
    SELECT COUNT(*) AS Total
    FROM Galeria_Albun
    WHERE CandidataID = @CandidataID
END;
GO

-- Obtener Total de Fotos de Candidata
CREATE OR ALTER PROCEDURE sp_obtener_total_fotos_candidata
    @CandidataID INT
AS
BEGIN
    SELECT COUNT(*) AS Total
    FROM Foto
    JOIN Galeria_Albun ON Foto.GaleriaID = Galeria_Albun.GaleriaID
    WHERE Galeria_Albun.CandidataID = @CandidataID
END;