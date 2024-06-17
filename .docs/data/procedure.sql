USE UgQueenDatabase
GO


-- ----------------------
-- Usuario Estudiante
-- ----------------------
-- Registrar Estudiantes

-- Login Estudiante
CREATE PROCEDURE sp_login_estudiante
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100)
AS
BEGIN
    SELECT UsuarioID, Nombre, Correo, FotoPerfil
    FROM Usuario
    WHERE Correo = @Correo AND Contrasena = @Contrasena
END;
GO

CREATE PROCEDURE sp_registrar_estudiante
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @FotoPerfil VARBINARY(MAX)
AS
BEGIN TRY 
        BEGIN TRANSACTION T1
            INSERT INTO Usuario (
                Nombre,
                Correo,
                Contrasena,
                FotoPerfil
            )
            VALUES (
                @Nombre,
                @Correo,
                @Contrasena,
                @FotoPerfil
            )

            INSERT INTO UsuarioRol (
                UsuarioID,
                RolID
            )
            VALUES (
                SCOPE_IDENTITY(),
                2
            )

            SAVE TRANSACTION T1;
            COMMIT TRANSACTION T1;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION T1;
    END CATCH;
GO


CREATE PROCEDURE sp_existe_estudiante
    @Correo NVARCHAR(100)
AS
BEGIN
    SELECT COUNT(*) AS Existe
    FROM Usuario
    WHERE Correo = @Correo
END;
GO

-- Actualizar Estudiante
CREATE PROCEDURE sp_actualizar_estudiante
    @UsuarioID INT,
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @FotoPerfil VARBINARY(MAX)
AS
BEGIN
    UPDATE Usuario
    SET
        Nombre = @Nombre,
        Correo = @Correo,
        Contrasena = @Contrasena,
        FotoPerfil = @FotoPerfil
    WHERE UsuarioID = @UsuarioID
END;
GO

-- Eliminar Estudiante
CREATE PROCEDURE sp_eliminar_estudiante
    @UsuarioID INT
AS
BEGIN
    DELETE FROM Usuario
    WHERE UsuarioID = @UsuarioID
END;
GO

-- ----------------------
-- Candidata
-- ----------------------

-- Registrar Candidata
CREATE PROCEDURE sp_registrar_candidata
    @Nombre NVARCHAR(100),
    @FotoPrincipal VARBINARY(MAX),
    @Edad INT,
    @DatosAcademicos NVARCHAR(MAX),
    @Pasatiempos NVARCHAR(MAX),
    @Habilidades NVARCHAR(MAX),
    @Intereses NVARCHAR(MAX),
    @Aspiraciones NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Candidata (
        Nombre,
        FotoPrincipal,
        Edad,
        DatosAcademicos,
        Pasatiempos,
        Habilidades,
        Intereses,
        Aspiraciones
    )
    VALUES (
        @Nombre,
        @FotoPrincipal,
        @Edad,
        @DatosAcademicos,
        @Pasatiempos,
        @Habilidades,
        @Intereses,
        @Aspiraciones
)
END;
GO

-- Actualizar Candidata
CREATE PROCEDURE sp_actualizar_candidata
    @CandidataID INT,
    @Nombre NVARCHAR(100),
    @FotoPrincipal VARBINARY(MAX),
    @Edad INT,
    @DatosAcademicos NVARCHAR(MAX),
    @Pasatiempos NVARCHAR(MAX),
    @Habilidades NVARCHAR(MAX),
    @Intereses NVARCHAR(MAX),
    @Aspiraciones NVARCHAR(MAX)
AS
BEGIN
    UPDATE Candidata
    SET
        Nombre = @Nombre,
        FotoPrincipal = @FotoPrincipal,
        Edad = @Edad,
        DatosAcademicos = @DatosAcademicos,
        Pasatiempos = @Pasatiempos,
        Habilidades = @Habilidades,
        Intereses = @Intereses,
        Aspiraciones = @Aspiraciones
    WHERE CandidataID = @CandidataID
END;
GO

-- Eliminar Candidata
CREATE PROCEDURE sp_eliminar_candidata
    @CandidataID INT
AS
BEGIN
    DELETE FROM Candidata
    WHERE CandidataID = @CandidataID
END;
GO

-- ----------------------
-- Foto
-- ----------------------

-- Registrar Foto
CREATE PROCEDURE sp_registrar_foto
    @Imagen VARBINARY(MAX)
AS
BEGIN
    INSERT INTO Foto (
        Imagen
    )
    VALUES (
        @Imagen
    )
END;
GO


-- Registrar Foto-Galeria
CREATE PROCEDURE sp_registrar_foto_galeria
    @Imagen VARBINARY(MAX),
    @CandidataID INT
AS
BEGIN
    INSERT INTO Foto (
        Imagen
    )
    VALUES (
        @Imagen
    )

    SELECT SCOPE_IDENTITY() AS FotoID

    INSERT INTO Galeria_Fotos (
        CandidataID,
        FotoID
    )
    VALUES (
        @CandidataID,
        SCOPE_IDENTITY()
    )

END;
GO

-- Actualizar Foto
CREATE PROCEDURE sp_actualizar_foto
    @FotoID INT,
    @Imagen VARBINARY(MAX)
AS
BEGIN
    UPDATE Foto
    SET
        IMAGEN = @Imagen
    WHERE FotoID = @FotoID
END;
GO

-- Eliminar Foto
CREATE PROCEDURE sp_eliminar_foto
    @FotoID INT
AS
BEGIN
    DELETE FROM Foto
    WHERE FotoID = @FotoID
END;
GO

-- ----------------------
-- Galeria_Fotos
-- ----------------------

-- Registrar Galeria
CREATE PROCEDURE sp_registrar_galeria
    @CandidataID INT,
    @FotoID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Galeria_Fotos (
        CandidataID,
        FotoID,
        Titulo,
        Descripcion
    )
    VALUES (
        @CandidataID,
        @FotoID,
        @Titulo,
        @Descripcion
    )
END;
GO

-- Actualizar Galeria
CREATE PROCEDURE sp_actualizar_galeria
    @CandidataID INT,
    @FotoID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX)
AS
BEGIN
    UPDATE Galeria_Fotos
    SET
        Titulo = @Titulo,
        Descripcion = @Descripcion
    WHERE CandidataID = @CandidataID AND FotoID = @FotoID
END;
GO


-- Eliminar Foto de Galeria
CREATE PROCEDURE sp_eliminar_foto_galeria
    @CandidataID INT,
    @FotoID INT
AS
BEGIN
    DELETE FROM Galeria_Fotos
    WHERE CandidataID = @CandidataID AND FotoID = @FotoID
END;
GO

-- ----------------------
-- Comentario
-- ----------------------

-- Registrar Comentario
CREATE PROCEDURE sp_registrar_comentario
    @texto NVARCHAR(MAX)
AS
BEGIN
    BEGIN TRANSACTION T1
        INSERT INTO Comentario (
            texto
        )
        VALUES (
            @texto
        )

        SAVE TRANSACTION T1
        COMMIT TRANSACTION T1
END;
GO

-- Actualizar Comentario
CREATE PROCEDURE sp_agregar_candidata_comentario
    @UsuarioID INT,
    @CandidataID INT,
    @ComentarioID INT
AS
BEGIN 
    INSERT INTO CandidataComentario (
        UsuarioID,
        CandidataID,
        ComentarioID
    )
    VALUES (
        @UsuarioID,
        @CandidataID,
        @ComentarioID
    )
END;
GO

-- Eliminar Comentario
CREATE PROCEDURE sp_eliminar_candidata_comentario
    @CandidataComentarioID INT
AS
BEGIN
    DELETE FROM CandidataComentario
    WHERE CandidataComentarioID = @CandidataComentarioID
END;
GO

-- ----------------------
-- Votacion
-- ----------------------

-- Registrar Votacion
CREATE PROCEDURE sp_registrar_votacion
    @UsuarioID INT,
    @CandidataID INT,
    @TipoVotacion NVARCHAR(50)
AS 
    BEGIN
        INSERT INTO Votacion (
            UsuarioID,
            CandidataID,
            TipoVotacion
        )
        VALUES (
            @UsuarioID,
            @CandidataID,
            @TipoVotacion
        )
END;
GO


CREATE PROCEDURE sp_eliminar_votacion
    @VotacionID INT
AS
BEGIN
    DELETE FROM Votacion
    WHERE VotacionID = @VotacionID
END;
GO

-- ----------------------
-- Consultas
-- ----------------------

-- Consultar Votos de una Candidata
CREATE PROCEDURE sp_consultar_votos_candidata
    @CandidataID INT
AS
BEGIN
    SELECT COUNT(*) AS Votos
    FROM Votacion
    WHERE CandidataID = @CandidataID
END;
GO

-- Consultar Cantidad de Comentarios de una Candidata
CREATE PROCEDURE sp_cantidad_comentarios_candidata
    @CandidataID INT
AS
BEGIN 
    SELECT COUNT(*) AS CantidadComentarios
    FROM CandidataComentario
    WHERE CandidataID = @CandidataID
END;
GO