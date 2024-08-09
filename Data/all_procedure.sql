USE UgQueenDatabase
GO


-- ----------------------
-- Usuario Estudiante
-- ----------------------

-- Registrar Estudiantes

CREATE OR ALTER PROCEDURE sp_login_estudiante
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100)
AS
BEGIN
    SELECT EstudianteID, Nombre, Correo, FotoPerfil, Matricula
    FROM Estudiante
    WHERE Correo = @Correo AND Contrasena = @Contrasena
END;
GO

CREATE OR ALTER PROCEDURE sp_registrar_estudiante
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


CREATE OR ALTER PROCEDURE sp_existe_estudiante
    @Correo NVARCHAR(100)
AS
BEGIN
    SELECT COUNT(*) AS Existe
    FROM Estudiante
    WHERE Correo = @Correo
END;
GO

-- Actualizar Estudiante
CREATE OR ALTER PROCEDURE sp_actualizar_estudiante
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
CREATE OR ALTER PROCEDURE sp_eliminar_estudiante
    @EstudianteID INT
AS
BEGIN
    DELETE FROM Estudiante
    WHERE EstudianteID = @EstudianteID
END;
GO

-- Obtener Estudiante
CREATE OR ALTER PROCEDURE sp_buscar_estudiante
	@Correo NVARCHAR(100)
AS
BEGIN
	SELECT EstudianteID, Nombre, Correo, FotoPerfil, Matricula
	FROM Estudiante
	WHERE Correo = @Correo
END;
GO


-- ----------------------
-- Usuario Administrador
-- ----------------------

-- Login Administrador
CREATE OR ALTER PROCEDURE sp_login_administrador
    @Correo NVARCHAR(100),
    @Contrasena NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Administrador
    WHERE Correo = @Correo AND Contrasena = @Contrasena
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

-- ----------------------
-- Foto
-- ----------------------

-- Registrar Foto
CREATE OR ALTER PROCEDURE sp_registrar_foto
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
CREATE OR ALTER PROCEDURE sp_registrar_foto_galeria
    @Imagen VARBINARY(MAX),
    @GaleriaID INT
AS
BEGIN
    INSERT INTO Foto (
        Imagen,
        GaleriaID
    )
    VALUES (
        @Imagen,
        @GaleriaID
    )
END;
GO

-- Actualizar Foto
CREATE OR ALTER PROCEDURE sp_actualizar_foto
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
CREATE OR ALTER PROCEDURE sp_eliminar_foto
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
CREATE OR ALTER PROCEDURE sp_registrar_galeria
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
CREATE OR ALTER PROCEDURE sp_actualizar_galeria
    @GaleriaID INT,
    @CandidataID INT,
    @Titulo NVARCHAR(100),
    @Descripcion NVARCHAR(MAX)
AS
BEGIN
    UPDATE Galeria_Fotos
    SET
        Titulo = @Titulo,
        Descripcion = @Descripcion
    WHERE GaleriaID = @GaleriaID
END;
GO


-- Eliminar Foto de Galeria
CREATE OR ALTER PROCEDURE sp_eliminar_foto_galeria
    @CandidataID INT,
    @GaleriaID INT
AS
BEGIN
    DELETE FROM Galeria_Fotos
    WHERE CandidataID = @CandidataID AND GaleriaID = @GaleriaID
END;
GO

-- Obtener Galeria
CREATE OR ALTER PROCEDURE sp_obtener_galeria
    @GaleraID INT
AS
BEGIN
    SELECT GaleriaID, CandidataID, Titulo, Descripcion
    FROM Galeria_Fotos
    WHERE GaleriaID = @GaleraID
END;
GO

-- Mostrar Galeria de Candiata
CREATE OR ALTER PROCEDURE sp_mostrar_imagenes_galeria
	@CandidataID INT
AS
BEGIN
	SELECT FotoID, Imagen, Galeria_Fotos.Titulo, Galeria_Fotos.Descripcion
    FROM Foto
    JOIN Galeria_Fotos ON Foto.GaleriaID = Galeria_Fotos.GaleriaID
	WHERE Galeria_Fotos.CandidataID = @CandidataID
END;
GO

-- Obtener Galeria de Candidata
CREATE OR ALTER PROCEDURE sp_obtener_galeria_candidata
    @CandidataID INT
AS
BEGIN
    SELECT GaleriaID, Titulo, Descripcion
    FROM Galeria_Fotos
    WHERE CandidataID = @CandidataID
END;
GO
-- Obtener Imagenes de Galeria
CREATE OR ALTER PROCEDURE sp_obtener_imagenes_galeria
    @GaleriaID INT
AS
BEGIN
    SELECT FotoID, Imagen
    FROM Foto
    WHERE GaleriaID = @GaleriaID
END;
GO
-- ----------------------
-- Comentario
-- ----------------------

-- Registrar Comentario
CREATE OR ALTER PROCEDURE sp_registrar_comentario
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
CREATE OR ALTER PROCEDURE sp_actualizar_comentario
    @ComentarioID INT,
    @texto NVARCHAR(MAX)
AS
BEGIN
    UPDATE Comentario
    SET
        texto = @texto,
        FechaComentario = GETDATE()
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

CREATE OR ALTER PROCEDURE sp_obtener_comentarios_candidata
	@CandidataID INT
AS
BEGIN
	SELECT ComentarioID, texto, FechaComentario, EstudianteID, CandidataID
	FROM Comentario
	WHERE CandidataID = @CandidataID
END;
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

-- ----------------------
-- Consultas
-- ----------------------

-- Consultar Votos de una Candidata
CREATE OR ALTER PROCEDURE sp_consultar_votos_candidata
    @CandidataID INT
AS
BEGIN
    SELECT COUNT(*) AS Votos
    FROM Votacion
    WHERE CandidataID = @CandidataID
END;
GO

