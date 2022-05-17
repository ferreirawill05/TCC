USE [darede-db]
GO

SELECT * FROM tipoUsuario
SELECT * FROM usuario
SELECT * FROM software
SELECT * FROM zona
SELECT * FROM armInstancia
SELECT * FROM tipoInstancia
SELECT * FROM instancia
SELECT * FROM infraestrutura

--Lista todas as informações de uma infraestrutura
SELECT 
idInfraestrutura, nomeUsuario[Cliente], ti.nomeTipoInstancia[Tipo de Instância], ai.tipoArmInstancia[Armazenamento da Instância], vCPU, memoriaGIB[Memória GIB], s.nomeSoftware[Software], z.nomeZona [Zona], topologiaImagem[Topologia], ipPrivado+mascaraPrivado[Ip Privado], ipPublico+mascaraPublico[Ip Público], gateway+mascaraGateway[Gateway], ativo[Ativo]
FROM infraestrutura i

LEFT JOIN usuario u
ON i.idUsuario = u.idUsuario
LEFT JOIN instancia ins
ON i.idInstancia = ins.idInstancia
LEFT JOIN tipoInstancia ti
ON ins.idTipoInstancia = ti.idTipoInstancia
LEFT JOIN armInstancia ai
ON ins.idArmInstancia = ai.idArmInstancia
LEFT JOIN software s
ON i.idSoftware = s.idSoftware
LEFT JOIN zona z
ON i.idZona = z.idZona
GO

--Lista as informações do Usuário
SELECT idUsuario, nomeUsuario[Nome do Usuário], nomeTipoUsuario[Cargo], email[Email], senha[Senha] FROM usuario u
LEFT JOIN tipoUsuario tu
ON u.idTipoUsuario = tu.idTipoUsuario
GO

--Lista as informações da Instância
SELECT idInstancia, ai.tipoArmInstancia[Armazenamento da Instância], ti.nomeTipoInstancia[Tipo de Instância], vCPU, memoriaGIB FROM instancia i
LEFT JOIN armInstancia ai
ON i.idArmInstancia = ai.idArmInstancia
LEFT JOIN tipoInstancia ti
ON i.idTipoInstancia = ti.idTipoInstancia
GO