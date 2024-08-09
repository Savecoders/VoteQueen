Use UgQueenDatabase
GO

-- ----------------------
-- Comentario
-- ----------------------

-- Registrar Comentario
CREATE OR ALTER PROCEDURE sp_registrar_comentario
    @Texto NVARCHAR(MAX),
    @EstudianteID INT,
AS
BEGIN
    INSERT INTO Comentario (
        Texto,
        EstudianteID,
    )
    VALUES (
        @Texto,
        @EstudianteID,
    )
END;
GO

-- Asignar Foto a Comentario
CREATE OR ALTER PROCEDURE sp_asignar_foto_a_comentario
    @ComentarioID INT,
    @FotoID INT
AS
BEGIN
    UPDATE Comentario
    SET
        FotoID = @FotoID
    WHERE ComentarioID = @ComentarioID
END;
GO

-- Actualizar Comentario
CREATE OR ALTER PROCEDURE sp_actualizar_comentario
    @ComentarioID INT,
    @Texto NVARCHAR(MAX)
AS
BEGIN
    UPDATE Comentario
    SET
        Texto = @Texto
    WHERE ComentarioID = @ComentarioID
END;
GO

-- Eliminar Comentario
CREATE OR ALTER PROCEDURE sp_eliminar_comentario
    @ComentarioID INT
AS
BEGIN
    DELETE FROM Comentario
    WHERE ComentarioID = @ComentarioID
END;
GO

-- Obtener Comentarios por Foto
CREATE OR ALTER PROCEDURE sp_obtener_comentarios_por_foto
    @FotoID INT
AS
BEGIN
    SELECT
        *
    FROM Comentario
    WHERE FotoID = @FotoID
    ORDER BY FechaComentario DESC
END;
GO

