-- ----------------------
-- Usuario Estudiante
-- ----------------------
-- Registrar Estudiantes
CREATE PROCEDURE RegistrarEstudiante
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contraseña NVARCHAR(100)
AS
BEGIN
    BEGIN TRANSACTION T1
        INSERT INTO Usuario (
            Nombre,
            Correo,
            Contraseña
        )
        VALUES (
            @Nombre,
            @Correo,
            @Contraseña
        )
        SAVE TRANSACTION T1
        COMMIT TRANSACTION T1
    
    BEGIN TRANSACTION T2
        INSERT INTO UsuarioRol (
            UsuarioID,
            RolID
        )
        VALUES (
            SCOPE_IDENTITY(),
            2
        )
        SAVE TRANSACTION T2
        COMMIT TRANSACTION T2
END;
GO

-- Actualizar Estudiante
CREATE PROCEDURE ActualizarEstudiante
    @UsuarioID INT,
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contraseña NVARCHAR(100)
AS
BEGIN
    UPDATE Usuario
    SET
        Nombre = @Nombre,
        Correo = @Correo,
        Contraseña = @Contraseña
    WHERE UsuarioID = @UsuarioID
END;

-- Eliminar Estudiante
CREATE PROCEDURE EliminarEstudiante
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
CREATE PROCEDURE RegistrarCandidata
    @Nombre NVARCHAR(100),
    @FotoPrincipal VARBINARY(MAX),
    @Edad INT,
    @DatosPersonales NVARCHAR(MAX),
    @Pasatiempos NVARCHAR(MAX),
    @Habilidades NVARCHAR(MAX),
    @Intereses NVARCHAR(MAX),
    @Aspiraciones NVARCHAR(MAX)
AS
BEGIN
    BEGIN TRANSACTION T1
        INSERT INTO Candidata (
            Nombre,
            FotoPrincipal,
            Edad,
            DatosPersonales,
            Pasatiempos,
            Habilidades,
            Intereses,
            Aspiraciones
        )
        VALUES (
            @Nombre,
            @FotoPrincipal,
            @Edad,
            @DatosPersonales,
            @Pasatiempos,
            @Habilidades,
            @Intereses,
            @Aspiraciones
        )
        SAVE TRANSACTION T1
        COMMIT TRANSACTION T1
END;

-- Actualizar Candidata
CREATE PROCEDURE ActualizarCandidata
    @CandidataID INT,
    @Nombre NVARCHAR(100),
    @FotoPrincipal VARBINARY(MAX),
    @Edad INT,
    @DatosPersonales NVARCHAR(MAX),
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
        DatosPersonales = @DatosPersonales,
        Pasatiempos = @Pasatiempos,
        Habilidades = @Habilidades,
        Intereses = @Intereses,
        Aspiraciones = @Aspiraciones
    WHERE CandidataID = @CandidataID
END;

-- Eliminar Candidata
CREATE PROCEDURE EliminarCandidata
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
CREATE PROCEDURE RegistrarFoto
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
CREATE PROCEDURE ActualizarFoto
    @FotoID INT
    @Imagen VARBINARY(MAX)
AS
BEGIN
    UPDATE Foto
    SET
        IMAGEN = @Imagen
    WHERE FotoID = @FotoID
END;

-- Eliminar Foto
CREATE PROCEDURE EliminarFoto
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
CREATE PROCEDURE AgregarFotoGaleria
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
CREATE PROCEDURE EliminarFotoGaleria
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
CREATE PROCEDURE RegistrarComentario
    @Comentario NVARCHAR(MAX)
AS
BEGIN
    BEGIN TRANSACTION T1
        INSERT INTO Comentario (
            Comentario
        )
        VALUES (
            @Comentario
        )

        SAVE TRANSACTION T1
        COMMIT TRANSACTION T1
END;

-- Actualizar Comentario
CREATE PROCEDURE AgregarCandidataComentario
    @UsuarioID INT,
    @CandidataID INT,
    @ComentarioID INT
AS
BEGIN 
    BEGIN TRANSACTION T1
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

        SAVE TRANSACTION T1
        COMMIT TRANSACTION T1

END;

-- Eliminar Comentario
CREATE PROCEDURE EliminarCandidataComentario
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
CREATE PROCEDURE RegistrarVotacion
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


CREATE PROCEDURE EliminarVotacion
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
CREATE PROCEDURE ConsultarVotosCandidata
    @CandidataID INT
AS
BEGIN
    SELECT COUNT(*) AS Votos
    FROM Votacion
    WHERE CandidataID = @CandidataID
END;

-- Consultar Cantidad de Comentarios de una Candidata
CREATE PROCEDURE CantidadComentariosXCandidata
    @CandidataID INT
AS
BEGIN 
    SELECT COUNT(*) AS CantidadComentarios
    FROM CandidataComentario
    WHERE CandidataID = @CandidataID
END;