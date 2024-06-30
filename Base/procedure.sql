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
    SELECT EstudianteID, Nombre, Correo, FotoPerfil, Matricula
    FROM Estudiante
    WHERE Correo = @Correo AND Contrasena = @Contrasena
END;
GO

CREATE PROCEDURE sp_registrar_estudiante
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @FotoPerfil VARBINARY(MAX),
    @Matricula NVARCHAR(100)
AS
BEGIN TRY 
        BEGIN TRANSACTION T1
            INSERT INTO Estudiante (
                Nombre,
                Correo,
                Contrasena,
                FotoPerfil,
                Matricula
            )
            VALUES (
                @Nombre,
                @Correo,
                @Contrasena,
                @FotoPerfil,
                @Matricula
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
    FROM Estudiante
    WHERE Correo = @Correo
END;
GO

-- Actualizar Estudiante
CREATE PROCEDURE sp_actualizar_estudiante
    @EstudianteID INT,
    @Nombre NVARCHAR(100),
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100),
    @FotoPerfil VARBINARY(MAX)
AS
BEGIN
    UPDATE Estudiante
    SET
        Nombre = @Nombre,
        Correo = @Correo,
        Contrasena = @Contrasena,
        FotoPerfil = @FotoPerfil
    WHERE EstudianteID = @EstudianteID
END;
GO

-- Eliminar Estudiante
CREATE PROCEDURE sp_eliminar_estudiante
    @EstudianteID INT
AS
BEGIN
    DELETE FROM Estudiante
    WHERE EstudianteID = @EstudianteID
END;
GO

-- ----------------------
-- Usuario Administrador
-- ----------------------

-- Login Administrador
CREATE PROCEDURE sp_login_administrador
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100)
AS
BEGIN
    SELECT AdministradorID, Nombre, Correo, FotoPerfil, Cargo
    FROM Administrador
    WHERE Correo = @Correo AND Contrasena = @Contrasena
END;

GO

-- Registrar Administrador
CREATE PROCEDURE sp_registrar_administrador
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
CREATE PROCEDURE sp_actualizar_administrador
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
CREATE PROCEDURE sp_existe_administrador
    @Correo NVARCHAR(100)
AS
BEGIN
    SELECT COUNT(*) AS Existe
    FROM Administrador
    WHERE Correo = @Correo
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
    @Aspiraciones NVARCHAR(MAX),
    @AdministradorID INT
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
        Aspiraciones,
        AdministradorID
    )
    VALUES (
        @Nombre,
        @FotoPrincipal,
        @Edad,
        @DatosAcademicos,
        @Pasatiempos,
        @Habilidades,
        @Intereses,
        @Aspiraciones,
        @AdministradorID
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
    GaleriaID INT
AS
BEGIN
    INSERT INTO Foto (
        Imagen
        GaleriaID
    )
    VALUES (
        @Imagen
        GaleriaID
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
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Galeria_Fotos (
        CandidataID,
        Titulo,
        Descripcion
    )
    VALUES (
        @CandidataID,
        @Titulo,
        @Descripcion
    )
END;
GO

-- Actualizar Galeria
CREATE PROCEDURE sp_actualizar_galeria
    @CandidataID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX)
AS
BEGIN
    UPDATE Galeria_Fotos
    SET
        Titulo = @Titulo,
        Descripcion = @Descripcion
    WHERE CandidataID = @CandidataID
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
    @texto NVARCHAR(MAX),
    @EstudianteID INT,
    @CandidataID INT
AS
BEGIN
    BEGIN TRANSACTION T1
        INSERT INTO Comentario (
            texto,
            EstudianteID,
            CandidataID
        )
        VALUES (
            @texto,
            @EstudianteID,
            @CandidataID
        )

        SAVE TRANSACTION T1
        COMMIT TRANSACTION T1
END;
GO

-- Actualizar Comentario
CREATE PROCEDURE sp_actualizar_comentario
    @ComentarioID INT,
    @texto NVARCHAR(MAX)
AS
BEGIN
    UPDATE Comentario
    SET
        texto = @texto
        FechaComentario = GETDATE()
    WHERE ComentarioID = @ComentarioID
END;

GO

-- Eliminar Comentario
CREATE PROCEDURE sp_eliminar_comentario
    @ComentarioID INT
AS
BEGIN
    DELETE FROM Comentario
    WHERE ComentarioID = @ComentarioID
END;

-- ----------------------
-- Votacion
-- ----------------------

-- Registrar Votacion
CREATE PROCEDURE sp_registrar_votacion
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