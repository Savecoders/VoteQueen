-- ----------------------
-- Usuario Estudiante
-- ----------------------

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

