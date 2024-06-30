-- delete FK

USE UgQueenDatabase
GO

-- Eliminar tablas con claves foráneas
DROP TABLE IF EXISTS Votacion;
DROP TABLE IF EXISTS Galeria_Fotos;

-- Eliminar tablas con claves primarias
DROP TABLE IF EXISTS Comentario;
DROP TABLE IF EXISTS Foto;
DROP TABLE IF EXISTS Candidata;
DROP TABLE IF EXISTS Administrador;
DROP TABLE IF EXISTS Estudiante;