USE [darede-db]
GO

CREATE TABLE tipoUsuario(
	idTipoUsuario TINYINT PRIMARY KEY IDENTITY(1,1),
	nomeTipoUsuario VARCHAR(15) UNIQUE NOT NULL,
)
GO

CREATE TABLE usuario(
	idUsuario INT PRIMARY KEY IDENTITY (1,1),
	idTipoUsuario TINYINT FOREIGN KEY REFERENCES tipoUsuario(idTipoUsuario),
	nomeUsuario VARCHAR(256) NOT NULL,
	email VARCHAR(256) UNIQUE NOT NULL,
	senha VARCHAR(50) NOT NULL
)
GO

CREATE TABLE software(
	idSoftware TINYINT PRIMARY KEY IDENTITY(1,1),
	nomeSoftware VARCHAR(100) UNIQUE NOT NULL,
)
GO

CREATE TABLE zona(
	idZona TINYINT PRIMARY KEY IDENTITY(1,1),
	nomeZona VARCHAR(30) UNIQUE NOT NULL,
)
GO

CREATE TABLE armInstancia(
	idArmInstancia TINYINT PRIMARY KEY IDENTITY(1,1),
	tipoArmInstancia VARCHAR(30) UNIQUE NOT NULL,
)
GO

CREATE TABLE tipoInstancia(
	idTipoInstancia SMALLINT PRIMARY KEY IDENTITY(1,1),
	nomeTipoInstancia VARCHAR(256) UNIQUE NOT NULL,
)
GO

CREATE TABLE instancia(
	idInstancia SMALLINT PRIMARY KEY IDENTITY(1,1),
	idArmInstancia TINYINT FOREIGN KEY REFERENCES armInstancia(idArmInstancia),
	idTipoInstancia SMALLINT FOREIGN KEY REFERENCES tipoInstancia(idTipoInstancia),
	vCPU VARCHAR(50) NOT NULL,
	memoriaGIB VARCHAR(50) NOT NULL
)
GO

CREATE TABLE infraestrutura(
	idInfraestrutura INT PRIMARY KEY IDENTITY(1,1),
	idUsuario INT FOREIGN KEY REFERENCES usuario(idUsuario),
	idInstancia SMALLINT FOREIGN KEY REFERENCES instancia(idInstancia),
	idSoftware TINYINT FOREIGN KEY REFERENCES software(idSoftware),
	idZona TINYINT FOREIGN KEY REFERENCES zona(idZona),

	topologiaImagem VARCHAR(256) NOT NULL,

	ipPrivado VARCHAR(20) UNIQUE NOT NULL,
	mascaraPrivado VARCHAR(15) NOT NULL,
	
	ipPublico VARCHAR(20) UNIQUE NOT NULL,
	mascaraPublico VARCHAR(15) NOT NULL,
	
	gateway VARCHAR(20) NOT NULL,
	mascaraGateway VARCHAR(15) NOT NULL,
	
	ativo BIT DEFAULT(1) NOT NULL,
)
GO
