USE UgQueenDatabase
GO

-- ----------------------
-- Votacion
-- ----------------------

-- Registrar Votacion
CREATE OR ALTER PROCEDURE sp_registrar_votacion
    @EstudianteID INT,
    @CandidataID INT,
    @TipoVotacion NVARCHAR(50)
AS 
    BEGIN
        INSERT INTO Votacion (
            EstudianteID,
            CandidataID,
            TipoVotacion
        )
        VALUES (
            @EstudianteID,
            @CandidataID,
            @TipoVotacion
        )
END;
GO


CREATE OR ALTER PROCEDURE sp_eliminar_votacion
    @VotacionID INT
AS
BEGIN
    DELETE FROM Votacion
    WHERE VotacionID = @VotacionID
END;
GO


CREATE OR ALTER PROCEDURE sp_obtener_votaciones_por_candidata_tipo
    @CandidataID INT,
    @TipoVotacion NVARCHAR(50)
AS
BEGIN
    SELECT
        COUNT(*) AS Votos
    FROM Votacion
    WHERE CandidataID = @CandidataID AND TipoVotacion = @TipoVotacion
END;
GO