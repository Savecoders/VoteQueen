CREATE DATABASE UgQueenDatabase
GO

-- FILE

ALTER DATABASE [TESTPOE]
ADD FILE (
	NAME=UgQueenDatabasefile,
	FILENAME='E:\Datos\UgQueenDatabase.ndf',
	SIZE=10MB,
	MAXSIZE = 500MB,
	FILEGROWTH = 1MB
)