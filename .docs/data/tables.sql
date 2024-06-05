
USE UgQueenDatabase
GO

-- Rol
CREATE TABLE Rol (
    RolID INT PRIMARY KEY IDENTITY,
    NombreRol NVARCHAR(50) NOT NULL UNIQUE
);

-- Usuario
CREATE TABLE Usuario (
    UsuarioID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    Contrasena NVARCHAR(100) NOT NULL
);

-- UsuarioRol
CREATE TABLE UsuarioRol (
    UsuarioID INT NOT NULL,
    RolID INT NOT NULL,
    PRIMARY KEY (UsuarioID, RolID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    FOREIGN KEY (RolID) REFERENCES Rol(RolID)
);

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
);

-- Foto
CREATE TABLE Foto (
    FotoID INT PRIMARY KEY IDENTITY,
    Imagen VARBINARY(MAX) NOT NULL,
);

-- Galeria_Fotos
CREATE TABLE Galeria_Fotos (
    GaleriaID INT PRIMARY KEY IDENTITY,
    CandidataID INT NOT NULL,
    FotoID INT NOT NULL,
    FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID),
    FOREIGN KEY (FotoID) REFERENCES Foto(FotoID)
);

-- Comentario

-- Comentario
CREATE TABLE Comentario(
	ComentarioID INT PRIMARY KEY IDENTITY,
	Comentario NVARCHAR(MAX) NOT NULL,
	FechaComentario DATETIME NOT NULL DEFAULT GETDATE()
)

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

-- Votacion
CREATE TABLE Votacion (
    VotacionID INT PRIMARY KEY IDENTITY,
    UsuarioID INT NOT NULL,
    CandidataID INT NOT NULL,
    TipoVotacion NVARCHAR(50) CHECK (TipoVotacion IN ('Miss Fotogenia', 'Reina FCMF')),
    FechaVotacion DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (UsuarioID) REFERENCES Usuario(UsuarioID),
    FOREIGN KEY (CandidataID) REFERENCES Candidata(CandidataID)
);


-- Index
CREATE INDEX IDX_Votacion_TipoVotacion ON Votacion(TipoVotacion);

-- roles Administrador - Estudiante
INSERT INTO Rol (NombreRol) VALUES ('Administrador');
INSERT INTO Rol (NombreRol) VALUES ('Estudiante');
