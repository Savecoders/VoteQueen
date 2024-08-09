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
    SELECT *
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
    @FotoPerfil VARBINARY(MAX),
    @Matricula NVARCHAR(100)
AS
BEGIN
    UPDATE Estudiante
    SET
        Nombre = @Nombre,
        Correo = @Correo,
        Contrasena = @Contrasena,
        FotoPerfil = @FotoPerfil,
        Matricula = @Matricula
    WHERE EstudianteID = @EstudianteID
END;
GO

-- Eliminar Estudiante
CREATE OR ALTER PROCEDURE sp_eliminar_estudiante
    @EstudianteID INT
AS
BEGIN
    UPDATE Estudiante
    SET Estado = 0
    WHERE EstudianteID = @EstudianteID
END;
GO

-- Obtener Estudiante
CREATE OR ALTER PROCEDURE sp_obtener_estudiante
    @Correo NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Estudiante
    WHERE Correo = @Correo and Estado = 1
END;
GO

-- filtrar Estudiante
CREATE OR ALTER PROCEDURE sp_filtrar_estudiante
	@Condicion NVARCHAR(100)
AS
BEGIN
	SELECT *
	FROM Estudiante
	WHERE ( Correo LIKE @Condicion+'%' OR Nombre LIKE @Condicion+'%') AND Estado = 1
END;
GO

-- Obtener Estudiantes
CREATE OR ALTER PROCEDURE sp_obtener_estudiantes_activos
AS
BEGIN
    SELECT *
    FROM Estudiante
    WHERE Estado = 1
END;
GO
-- Verificar Estudiante ya votado por una Candidata 'Reina FCMF'

CREATE OR ALTER PROCEDURE sp_virificar_voto_fmcf
    @EstudianteID INT
AS
BEGIN
    SELECT COUNT(*) AS Voto
    FROM Votacion
    WHERE EstudianteID = @EstudianteID AND TipoVotacion = 'Reina FCMF'
END;
GO
-- Verificar Estudiante ya votado por una Candidata 'Miss Fotogenia'

CREATE OR ALTER PROCEDURE sp_virificar_voto_fotogenia
    @EstudianteID INT
AS
BEGIN
    SELECT COUNT(*) AS Voto
    FROM Votacion
    WHERE EstudianteID = @EstudianteID AND TipoVotacion = 'Miss Fotogenia'
END;
GO