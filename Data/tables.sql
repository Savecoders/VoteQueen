CREATE DATABASE UgQueenDatabase
GO

-- FILE
ALTER DATABASE [UgQueenDatabase]
ADD FILE (
	NAME=votequeenfile,
	FILENAME='E:\Datos\votequeenfile.ndf',
	SIZE=10MB,
	MAXSIZE = 500MB,
	FILEGROWTH = 1MB
)
GO

USE UgQueenDatabase
GO

-- Usuario
CREATE TABLE Estudiante (
    EstudianteID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Contrasena NVARCHAR(100) NOT NULL,
    FotoPerfil VARBINARY(MAX),
    Matricula NVARCHAR(100) NOT NULL,
    Estado bit NOT NULL DEFAULT 1
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
    Telefono NVARCHAR(100) NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    Pasatiempos NVARCHAR(MAX),
    Habilidades NVARCHAR(MAX),
    Intereses NVARCHAR(MAX),
    Aspiraciones NVARCHAR(MAX),
    Carrera NVARCHAR(100) NOT NULL,
    Nivel INT NOT NULL,
    FechaInscripcion DATETIME NOT NULL DEFAULT GETDATE(),
)
GO

-- Foto
CREATE TABLE Foto (
    FotoID INT PRIMARY KEY IDENTITY,
    GaleriaID INT NOT NULL,
    Titulo NVARCHAR(100),
    Descripcion NVARCHAR(MAX),
    Imagen VARBINARY(MAX) NOT NULL,
    FechaCreacion DATETIME DEFAULT GETDATE()
)
GO

-- Galeria_Albun
CREATE TABLE Galeria_Albun (
    GaleriaID INT PRIMARY KEY IDENTITY,
    CandidataID INT NOT NULL,
    Titulo NVARCHAR(100),
    Descripcion NVARCHAR(MAX),
    Portada VARBINARY(MAX),
    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE()
)
GO

-- Comentario
CREATE TABLE Comentario (
    ComentarioID INT PRIMARY KEY IDENTITY,
    Texto NVARCHAR(MAX) NOT NULL,
    FechaComentario DATETIME NOT NULL DEFAULT GETDATE(),
    EstudianteID INT NOT NULL,
    FotoID INT NOT NULL
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
-- Relacion entre Foto y Galeria_Albun
ALTER TABLE Foto ADD CONSTRAINT FK_Foto_Galeria FOREIGN KEY (GaleriaID) REFERENCES Galeria_Albun(GaleriaID)
GO

-- Relacion entre Galeria_Albun y Candidata
ALTER TABLE Galeria_Albun ADD CONSTRAINT FK_Galeria_Albun_Candidata FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID)
GO

-- Relacion entre Comentario y Estudiante
ALTER TABLE Comentario ADD CONSTRAINT FK_Comentario_Estudiante FOREIGN KEY (EstudianteID) REFERENCES Estudiante(EstudianteID)
GO

-- Relacion entre Comentario y Foto
ALTER TABLE Comentario ADD CONSTRAINT FK_Comentario_Foto FOREIGN KEY (FotoID) REFERENCES Foto(FotoID)
GO

-- Relacion entre Votacion y Estudiante
ALTER TABLE Votacion ADD CONSTRAINT FK_Votacion_Estudiante FOREIGN KEY (EstudianteID) REFERENCES Estudiante(EstudianteID)
GO

-- Relacion entre Votacion y Candidata
ALTER TABLE Votacion ADD CONSTRAINT FK_Votacion_Candidata FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID)
GO
