USE [darede-db]
GO

INSERT INTO tipoUsuario(nomeTipoUsuario)
VALUES 
	('Cliente'),
	('Funcionário')
GO

INSERT INTO usuario(idTipoUsuario, nomeUsuario, email, senha)
VALUES
	('1', 'Jorge', 'jorge@email.com','jorge123'),
	('1', 'Rebeca', 'rebeca@email.com', 'rebeca123'),
	('2', 'Romário', 'romario@email.com', 'romario123')
GO

INSERT INTO software(nomeSoftware)
VALUES
	('Linux'),
	('Windows')
GO

INSERT INTO zona(nomeZona)
VALUES
	('us-east-2'),
	('us-west-1')
GO

INSERT INTO armInstancia(tipoArmInstancia)
VALUES
	('HDD'),
	('SSD')
GO

INSERT INTO tipoInstancia(nomeTipoInstancia)
VALUES
	('t2.micro'),
	('c4.xlarge')
GO

INSERT INTO instancia(idArmInstancia, idTipoInstancia, vCPU, memoriaGIB)
VALUES
	('1', '1', '1', 'xxGB'),
	('1', '2', '2', 'xxGB'),
	('2', '2', '3', 'xxGB')
GO

INSERT INTO infraestrutura
(idUsuario, idInstancia, idSoftware, idZona, topologiaImagem, ipPrivado, mascaraPrivado, ipPublico, mascaraPublico, gateway, mascaraGateway, ativo)
VALUES
	('1', '1', '1',  '1', 'abc.png', '1xx.xxx.xxx.xxx', '/xx', '1xx.xxx.xxx.xxx', '/xx', '1xx.xxx.xxx.xxx', '/xx', '1'),
	('2', '2', '2', '2', 'def.png', '2xx.xxx.xxx.xxx', '/xx', '2xx.xxx.xxx.xxx', '/xx', '2xx.xxx.xxx.xxx', '/xx', '1'),
	('2', '3', '2',  '2', 'ghi.png', '3xx.xxx.xxx.xxx', '/xx', '3xx.xxx.xxx.xxx', '/xx', '3xx.xxx.xxx.xxx', '/xx', '0')
GO