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

CREATE PROCEDURE sp_registrar_estudiante
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @FotoPerfil VARBINARY(MAX)
AS
BEGIN
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

-- Eliminar Estudiante
CREATE PROCEDURE sp_eliminar_estudiante
    @UsuarioID INT
AS
BEGIN
    DELETE FROM Usuario
    WHERE UsuarioID = @UsuarioID
END;

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

-- Eliminar Candidata
CREATE PROCEDURE sp_eliminar_candidata
    @CandidataID INT
AS
BEGIN
    DELETE FROM Candidata
    WHERE CandidataID = @CandidataID
END;

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

-- Eliminar Foto
CREATE PROCEDURE sp_eliminar_foto
    @FotoID INT
AS
BEGIN
    DELETE FROM Foto
    WHERE FotoID = @FotoID
END;

-- ----------------------
-- Galeria_Fotos
-- ----------------------

-- Agregar Foto a Galeria
CREATE PROCEDURE sp_agregar_foto_galeria
    @CandidataID INT,
    @FotoID INT
AS
BEGIN
    INSERT INTO Galeria_Fotos (
        CandidataID,
        FotoID
    )
    VALUES (
        @CandidataID,
        @FotoID
    )
END;

-- Eliminar Foto de Galeria
CREATE PROCEDURE sp_eliminar_foto_galeria
    @CandidataID INT,
    @FotoID INT
AS
BEGIN
    DELETE FROM Galeria_Fotos
    WHERE CandidataID = @CandidataID AND FotoID = @FotoID
END;

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

-- Eliminar Comentario
CREATE PROCEDURE sp_eliminar_candidata_comentario
    @CandidataComentarioID INT
AS
BEGIN
    DELETE FROM CandidataComentario
    WHERE CandidataComentarioID = @CandidataComentarioID
END;

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


CREATE PROCEDURE sp_eliminar_votacion
    @VotacionID INT
AS
BEGIN
    DELETE FROM Votacion
    WHERE VotacionID = @VotacionID
END;

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

-- Consultar Cantidad de Comentarios de una Candidata
CREATE PROCEDURE sp_cantidad_comentarios_candidata
    @CandidataID INT
AS
BEGIN 
    SELECT COUNT(*) AS CantidadComentarios
    FROM CandidataComentario
    WHERE CandidataID = @CandidataID
END;