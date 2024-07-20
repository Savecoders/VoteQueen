CREATE DATABASE UgQueenDatabase
GO

-- FILE

ALTER DATABASE [UgQueenDatabase]
ADD FILE (
	NAME=votequeenfile,
	FILENAME='E:\Datos\votequeenfile.ndf',
	SIZE=10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 1MB
)

USE UgQueenDatabase
GO


-- Usuario
CREATE TABLE Estudiante (
    EstudianteID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Contrasena NVARCHAR(100) NOT NULL,
    FotoPerfil VARBINARY(MAX),
    Matricula NVARCHAR(100) NOT NULL UNIQUE
)
GO
-- Administrador
CREATE TABLE Administrador (
    AdministradorID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Contrasena NVARCHAR(100) NOT NULL,
    FotoPerfil VARBINARY(MAX),
    Cargo NVARCHAR(100) NOT NULL
)
GO

-- Creación de la tabla Candidata
CREATE TABLE Candidata (
    CandidataID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    FotoPrincipal VARBINARY(MAX),
    Edad INT NOT NULL,
    DatosAcademicos NVARCHAR(MAX),
    Pasatiempos NVARCHAR(MAX),
    Habilidades NVARCHAR(MAX),
    Intereses NVARCHAR(MAX),
    Aspiraciones NVARCHAR(MAX),
    FechaInscripcion DATETIME NOT NULL DEFAULT GETDATE(),
    AdministradorID INT NOT NULL
)
GO

-- Foto
CREATE TABLE Foto (
    FotoID INT PRIMARY KEY IDENTITY,
    GaleriaID INT NOT NULL,
    Imagen VARBINARY(MAX) NOT NULL
)
GO

-- Galeria_Fotos
CREATE TABLE Galeria_Fotos (
    GaleriaID INT PRIMARY KEY IDENTITY,
    CandidataID INT NOT NULL,
    Titulo NVARCHAR(100),
    Descripcion NVARCHAR(MAX)
)
GO

-- Comentario
CREATE TABLE Comentario(
    ComentarioID INT PRIMARY KEY IDENTITY,
    texto NVARCHAR(MAX) NOT NULL,
    FechaComentario DATETIME NOT NULL DEFAULT GETDATE(),
    EstudianteID INT NOT NULL,
    CandidataID INT NOT NULL
)
GO


-- Votacion
CREATE TABLE Votacion (
    VotacionID INT PRIMARY KEY IDENTITY,
    EstudianteID INT NOT NULL,
    CandidataID INT NOT NULL,
    TipoVotacion NVARCHAR(50) CHECK (TipoVotacion IN ('Miss Fotogenia', 'Reina FCMF')),
    FechaVotacion DATETIME NOT NULL DEFAULT GETDATE()
)
GO

-- Index
CREATE INDEX IDX_Votacion_TipoVotacion ON Votacion(TipoVotacion)
GO

-- Agregar restricciones de clave foránea
-- Relacion entre Galeria_Fotos 1 y * Foto
ALTER TABLE Foto ADD CONSTRAINT FK_Foto_Galeria FOREIGN KEY (GaleriaID) REFERENCES Galeria_Fotos(GaleriaID)
GO
-- Relacion entre Candidata 1 y * Galeria_Fotos
ALTER TABLE Galeria_Fotos ADD CONSTRAINT FK_Galeria_Fotos_Candidata FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID)

-- Relacion entre Estudiante 1 y * Comentario
ALTER TABLE Comentario ADD CONSTRAINT FK_Comentario_Estudiante FOREIGN KEY (EstudianteID) REFERENCES Estudiante(EstudianteID)
GO

ALTER TABLE Comentario ADD CONSTRAINT FK_Comentario_Candidata FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID)
GO

ALTER TABLE Votacion ADD CONSTRAINT FK_Votacion_Estudiante FOREIGN KEY (EstudianteID) REFERENCES Estudiante(EstudianteID)
GO

ALTER TABLE Votacion ADD CONSTRAINT FK_Votacion_Candidata FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID)
GO

ALTER TABLE Candidata ADD CONSTRAINT FK_Candidata_Administrador FOREIGN KEY (AdministradorID) REFERENCES Administrador(AdministradorID)