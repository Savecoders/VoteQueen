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

-- Rol
CREATE TABLE Rol (
    RolID INT PRIMARY KEY IDENTITY,
    NombreRol NVARCHAR(50) NOT NULL UNIQUE
)
GO

-- Usuario
CREATE TABLE Usuario (
    UsuarioID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Contrasena NVARCHAR(100) NOT NULL,
    FotoPerfil VARBINARY(MAX)
)
GO

-- UsuarioRol
CREATE TABLE UsuarioRol (
    UsuarioID INT NOT NULL,
    RolID INT NOT NULL,
    PRIMARY KEY (UsuarioID, RolID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    FOREIGN KEY (RolID) REFERENCES Rol(RolID)
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
    Aspiraciones NVARCHAR(MAX)
)

GO

-- Foto
CREATE TABLE Foto (
    FotoID INT PRIMARY KEY IDENTITY,
    GaleriaID INT NOT NULL,
    Imagen VARBINARY(MAX) NOT NULL
    FOREIGN KEY (GaleriaID) REFERENCES Galeria(GaleriaID)
)

GO

-- Galeria_Fotos
CREATE TABLE Galeria_Fotos (
    GaleriaID INT PRIMARY KEY IDENTITY,
    CandidataID INT NOT NULL,
    Titulo NVARCHAR(100),
    Descripcion NVARCHAR(MAX),
    FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID),
)

GO

-- Comentario

-- Comentario
CREATE TABLE Comentario(
	ComentarioID INT PRIMARY KEY IDENTITY,
	texto NVARCHAR(MAX) NOT NULL,
	FechaComentario DATETIME NOT NULL DEFAULT GETDATE()
)

GO

-- CandidataComentario
CREATE TABLE CandidataComentario(
	CandidataComentarioID INT PRIMARY KEY IDENTITY,
	UsuarioID INT NOT NULL,
    CandidataID INT NOT NULL,
	ComentarioID INT NOT NULL,
	FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID),
    FOREIGN KEY (ComentarioID) REFERENCES Comentario(ComentarioID)
)

GO

-- Votacion
CREATE TABLE Votacion (
    VotacionID INT PRIMARY KEY IDENTITY,
    UsuarioID INT NOT NULL,
    CandidataID INT NOT NULL,
    TipoVotacion NVARCHAR(50) CHECK (TipoVotacion IN ('Miss Fotogenia', 'Reina FCMF')),
    FechaVotacion DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID)
)

GO


-- Index
CREATE INDEX IDX_Votacion_TipoVotacion ON Votacion(TipoVotacion)
GO

-- roles Administrador - Estudiante
INSERT INTO Rol (NombreRol) VALUES ('Administrador');
INSERT INTO Rol (NombreRol) VALUES ('Estudiante');
