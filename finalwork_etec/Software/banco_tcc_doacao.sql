-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.27 - MySQL Community Server (GPL)
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para banco_tcc_doacao_novo
CREATE DATABASE IF NOT EXISTS `banco_tcc_doacao_novo` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `banco_tcc_doacao_novo`;

-- Copiando estrutura para evento banco_tcc_doacao_novo.EVENT0_UPDATE_FIM
DELIMITER //
CREATE DEFINER=`root`@`localhost` EVENT `EVENT0_UPDATE_FIM` ON SCHEDULE EVERY 1 DAY STARTS '2018-11-30 23:59:59' ON COMPLETION NOT PRESERVE ENABLE DO update tb09_campanhas set tb09_status = 2 where month(tb09_datafim) = month(now()) and day(tb09_datafim) = day(now())//
DELIMITER ;

-- Copiando estrutura para evento banco_tcc_doacao_novo.EVENT0_UPDATE_INICIO
DELIMITER //
CREATE DEFINER=`root`@`localhost` EVENT `EVENT0_UPDATE_INICIO` ON SCHEDULE EVERY 1 DAY STARTS '2018-11-30 00:02:59' ON COMPLETION NOT PRESERVE ENABLE DO update tb09_campanhas set tb09_status = 1 where month(tb09_datainicio) = month(now()) and day(tb09_datainicio) = day(now())//
DELIMITER ;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb01_ongs
CREATE TABLE IF NOT EXISTS `tb01_ongs` (
  `tb01_cnpj` bigint(14) NOT NULL,
  `tb01_nome` text,
  `tb01_endereco` text,
  `tb01_senha` varchar(20) DEFAULT NULL,
  `tb01_descricao` text,
  `tb01_bairro` text,
  `tb01_telefone` bigint(20) DEFAULT NULL,
  `tb01_email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`tb01_cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb01_ongs: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `tb01_ongs` DISABLE KEYS */;
INSERT INTO `tb01_ongs` (`tb01_cnpj`, `tb01_nome`, `tb01_endereco`, `tb01_senha`, `tb01_descricao`, `tb01_bairro`, `tb01_telefone`, `tb01_email`) VALUES
	(11111111111111, 'Ong 1', 'Al. das Oliveiras', 'admin123', 'A Descrição da ONG é super importante para que as pessoas doem para a ong. DESCRIÇÃO AQUI', 'Brotas', 1144589876, 'admin@outlook.com'),
	(22222222222222, 'ONG 2', 'Rua João da Silva', '123', 'A Descrição da ONG é super importante para que as pessoas doem para a ong. DESCRIÇÃO AQUI', 'Cidade Satélite', 11997645878, 'ong@gmail.com');
/*!40000 ALTER TABLE `tb01_ongs` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb02_doacoes
CREATE TABLE IF NOT EXISTS `tb02_doacoes` (
  `tb02_cod` int(11) NOT NULL AUTO_INCREMENT,
  `tb02_data` datetime DEFAULT NULL,
  `tb02_status` int(11) DEFAULT NULL,
  `tb02_ong` bigint(14) DEFAULT NULL,
  `tb02_tipo` int(11) DEFAULT NULL,
  `tb02_user` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`tb02_cod`),
  KEY `tb02_tipo` (`tb02_tipo`),
  KEY `tb02_ong` (`tb02_ong`),
  KEY `tb02_status` (`tb02_status`),
  KEY `FK_tb02_user` (`tb02_user`),
  CONSTRAINT `FK_tb02_user` FOREIGN KEY (`tb02_user`) REFERENCES `tb08_user` (`tb08_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb02_ong` FOREIGN KEY (`tb02_ong`) REFERENCES `tb01_ongs` (`tb01_cnpj`),
  CONSTRAINT `tb02_status` FOREIGN KEY (`tb02_status`) REFERENCES `tb04_status` (`tb04_cod`),
  CONSTRAINT `tb02_tipo` FOREIGN KEY (`tb02_tipo`) REFERENCES `tb03_tipo_doacao` (`tb03_cod`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb02_doacoes: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tb02_doacoes` DISABLE KEYS */;
INSERT INTO `tb02_doacoes` (`tb02_cod`, `tb02_data`, `tb02_status`, `tb02_ong`, `tb02_tipo`, `tb02_user`) VALUES
	(1, '2018-12-04 11:38:31', 1, 11111111111111, 2, 11997645981);
/*!40000 ALTER TABLE `tb02_doacoes` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb03_tipo_doacao
CREATE TABLE IF NOT EXISTS `tb03_tipo_doacao` (
  `tb03_cod` int(11) NOT NULL AUTO_INCREMENT,
  `tb03_tipo` text,
  PRIMARY KEY (`tb03_cod`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb03_tipo_doacao: ~9 rows (aproximadamente)
/*!40000 ALTER TABLE `tb03_tipo_doacao` DISABLE KEYS */;
INSERT INTO `tb03_tipo_doacao` (`tb03_cod`, `tb03_tipo`) VALUES
	(1, 'Roupas'),
	(2, 'Alimentos'),
	(3, 'Dinheiro'),
	(4, 'Ração'),
	(5, 'Remédios'),
	(6, 'Produtos de Higiêne'),
	(7, 'Cobertores e Travesseiros'),
	(8, 'Agasalhos em geral'),
	(9, 'N/A');
/*!40000 ALTER TABLE `tb03_tipo_doacao` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb04_status
CREATE TABLE IF NOT EXISTS `tb04_status` (
  `tb04_cod` int(11) NOT NULL,
  `tb04_status` text,
  PRIMARY KEY (`tb04_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb04_status: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `tb04_status` DISABLE KEYS */;
INSERT INTO `tb04_status` (`tb04_cod`, `tb04_status`) VALUES
	(1, 'Entregue'),
	(2, 'Não visto'),
	(3, 'Visto');
/*!40000 ALTER TABLE `tb04_status` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb05_conversas
CREATE TABLE IF NOT EXISTS `tb05_conversas` (
  `tb05_sequencia` int(11) NOT NULL AUTO_INCREMENT,
  `tb05_status` int(11) DEFAULT NULL,
  `tb05_de` bigint(20) DEFAULT NULL,
  `tb05_para` bigint(14) DEFAULT NULL,
  `tb05_data` datetime DEFAULT NULL,
  `tb05_mensagem` text,
  PRIMARY KEY (`tb05_sequencia`),
  KEY `tb05_status` (`tb05_status`),
  KEY `tb05_de` (`tb05_de`),
  KEY `tb05_para` (`tb05_para`),
  CONSTRAINT `tb05_de` FOREIGN KEY (`tb05_de`) REFERENCES `tb08_user` (`tb08_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb05_para` FOREIGN KEY (`tb05_para`) REFERENCES `tb08_user` (`tb08_id`),
  CONSTRAINT `tb05_status` FOREIGN KEY (`tb05_status`) REFERENCES `tb04_status` (`tb04_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb05_conversas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tb05_conversas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb05_conversas` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb06_tipos
CREATE TABLE IF NOT EXISTS `tb06_tipos` (
  `tb06_sequencia` int(11) NOT NULL AUTO_INCREMENT,
  `tb06_ong` bigint(14) DEFAULT NULL,
  `tb06_tipo` int(11) DEFAULT NULL,
  PRIMARY KEY (`tb06_sequencia`),
  KEY `tb06_ong` (`tb06_ong`),
  KEY `tb06_tipo` (`tb06_tipo`),
  CONSTRAINT `tb06_ong` FOREIGN KEY (`tb06_ong`) REFERENCES `tb01_ongs` (`tb01_cnpj`),
  CONSTRAINT `tb06_tipo` FOREIGN KEY (`tb06_tipo`) REFERENCES `tb03_tipo_doacao` (`tb03_cod`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb06_tipos: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `tb06_tipos` DISABLE KEYS */;
INSERT INTO `tb06_tipos` (`tb06_sequencia`, `tb06_ong`, `tb06_tipo`) VALUES
	(22, 22222222222222, 1),
	(23, 22222222222222, 2),
	(24, 22222222222222, 3),
	(25, 22222222222222, 5),
	(26, 22222222222222, 6),
	(27, 22222222222222, 7),
	(45, 11111111111111, 1);
/*!40000 ALTER TABLE `tb06_tipos` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb07_urgencias
CREATE TABLE IF NOT EXISTS `tb07_urgencias` (
  `tb07_sequencia` int(11) NOT NULL AUTO_INCREMENT,
  `tb07_ong` bigint(14) DEFAULT NULL,
  `tb07_tipo` int(11) DEFAULT NULL,
  PRIMARY KEY (`tb07_sequencia`),
  KEY `tb07_ong` (`tb07_ong`),
  KEY `tb07_tipo` (`tb07_tipo`),
  CONSTRAINT `tb07_ong` FOREIGN KEY (`tb07_ong`) REFERENCES `tb01_ongs` (`tb01_cnpj`),
  CONSTRAINT `tb07_tipo` FOREIGN KEY (`tb07_tipo`) REFERENCES `tb03_tipo_doacao` (`tb03_cod`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb07_urgencias: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tb07_urgencias` DISABLE KEYS */;
INSERT INTO `tb07_urgencias` (`tb07_sequencia`, `tb07_ong`, `tb07_tipo`) VALUES
	(25, 11111111111111, 5);
/*!40000 ALTER TABLE `tb07_urgencias` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb08_user
CREATE TABLE IF NOT EXISTS `tb08_user` (
  `tb08_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `tb08_nome` text,
  `tb08_email` varchar(50) DEFAULT NULL,
  `tb08_senha` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`tb08_id`)
) ENGINE=InnoDB AUTO_INCREMENT=22222222222223 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb08_user: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `tb08_user` DISABLE KEYS */;
INSERT INTO `tb08_user` (`tb08_id`, `tb08_nome`, `tb08_email`, `tb08_senha`) VALUES
	(11111111111, 'Nilo', 'saccilucas@gmail.com', '123'),
	(11997645981, 'Sacci', 'sacci@gmail.com', 'lucass'),
	(22222222222, 'SÃ©rgio', 'sergio.sergio', '123'),
	(11111111111111, 'Ong 1', 'admin@outlook.com', 'admin123'),
	(22222222222222, 'ONG 2', 'ong@gmail.com', '123');
/*!40000 ALTER TABLE `tb08_user` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb09_campanhas
CREATE TABLE IF NOT EXISTS `tb09_campanhas` (
  `tb09_id` bigint(14) NOT NULL AUTO_INCREMENT,
  `tb09_nome` text,
  `tb09_ong` bigint(20) DEFAULT NULL,
  `tb09_status` int(11) DEFAULT NULL,
  `tb09_datafim` date DEFAULT NULL,
  `tb09_datainicio` date DEFAULT NULL,
  `tb09_descricao` text,
  `tb09_objetivo` text,
  PRIMARY KEY (`tb09_id`),
  KEY `FK_tb09_ong` (`tb09_ong`),
  CONSTRAINT `FK_tb09_ong` FOREIGN KEY (`tb09_ong`) REFERENCES `tb01_ongs` (`tb01_cnpj`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb09_campanhas: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `tb09_campanhas` DISABLE KEYS */;
INSERT INTO `tb09_campanhas` (`tb09_id`, `tb09_nome`, `tb09_ong`, `tb09_status`, `tb09_datafim`, `tb09_datainicio`, `tb09_descricao`, `tb09_objetivo`) VALUES
	(7, 'Campanha 1', 22222222222222, 2, '2019-02-28', '2019-01-01', 'Essa campanha é só para teste', 'Campanha 1 teste '),
	(8, 'Campanha 2', 22222222222222, 1, '2018-12-25', '2018-12-03', 'odemos acreditar que tudo que a vida nos oferecerá no futuro é repetir o que fizemos ontem e hoje. Mas, se prestarmos atenção, vamos nos dar conta de que nenhum dia é igual a outro. Cada manhã traz uma benção escondida; uma benção que só serve para esse dia e que não se pode guardar nem desaproveitar.', 'Campanha 2 teste'),
	(10, 'Campanha 3', 11111111111111, 2, '2019-02-01', '2018-12-18', 'Com o crescente número de cães, gatos e outros animais domésticos nesse período, nós vimos a necessidade de criar uma campanha para arrecadar ração para os fofíneos', 'Campanha 3 teste');
/*!40000 ALTER TABLE `tb09_campanhas` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb10_ongs_campanhas
CREATE TABLE IF NOT EXISTS `tb10_ongs_campanhas` (
  `tb10_id` int(11) NOT NULL AUTO_INCREMENT,
  `tb10_campanha` bigint(14) DEFAULT NULL,
  `tb10_ong` bigint(14) DEFAULT NULL,
  `tb10_status` int(11) DEFAULT NULL,
  PRIMARY KEY (`tb10_id`),
  KEY `FK_tb10_ong` (`tb10_ong`),
  KEY `FK_tb10_campanha` (`tb10_campanha`),
  CONSTRAINT `FK_tb10_campanha` FOREIGN KEY (`tb10_campanha`) REFERENCES `tb09_campanhas` (`tb09_id`),
  CONSTRAINT `FK_tb10_ong` FOREIGN KEY (`tb10_ong`) REFERENCES `tb01_ongs` (`tb01_cnpj`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb10_ongs_campanhas: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `tb10_ongs_campanhas` DISABLE KEYS */;
INSERT INTO `tb10_ongs_campanhas` (`tb10_id`, `tb10_campanha`, `tb10_ong`, `tb10_status`) VALUES
	(4, 7, 11111111111111, 2),
	(5, 8, 11111111111111, 3),
	(6, 7, 22222222222222, 2),
	(7, 8, 22222222222222, 2),
	(10, 10, 11111111111111, 2),
	(11, 10, 22222222222222, 2);
/*!40000 ALTER TABLE `tb10_ongs_campanhas` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb11_campanha_doacoes
CREATE TABLE IF NOT EXISTS `tb11_campanha_doacoes` (
  `tb11_id` bigint(14) NOT NULL AUTO_INCREMENT,
  `tb11_tipo` int(11) DEFAULT NULL,
  `tb11_campanha` bigint(14) DEFAULT NULL,
  PRIMARY KEY (`tb11_id`),
  KEY `FK_tb11_tipo` (`tb11_tipo`),
  KEY `FK_tb11_campanha` (`tb11_campanha`),
  CONSTRAINT `FK_tb11_campanha` FOREIGN KEY (`tb11_campanha`) REFERENCES `tb09_campanhas` (`tb09_id`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tb11_tipo` FOREIGN KEY (`tb11_tipo`) REFERENCES `tb03_tipo_doacao` (`tb03_cod`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb11_campanha_doacoes: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `tb11_campanha_doacoes` DISABLE KEYS */;
INSERT INTO `tb11_campanha_doacoes` (`tb11_id`, `tb11_tipo`, `tb11_campanha`) VALUES
	(4, 3, 7),
	(5, 2, 8),
	(6, 4, 10);
/*!40000 ALTER TABLE `tb11_campanha_doacoes` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb12_imagens
CREATE TABLE IF NOT EXISTS `tb12_imagens` (
  `tb12_seq` int(11) NOT NULL AUTO_INCREMENT,
  `tb12_ong` bigint(14) DEFAULT NULL,
  `tb12_extencao` varchar(50) NOT NULL,
  `tb12_data_upload` date DEFAULT NULL,
  `tb12_descricao` text,
  PRIMARY KEY (`tb12_seq`),
  KEY `FK_tb12_ong` (`tb12_ong`),
  CONSTRAINT `FK_tb12_ong` FOREIGN KEY (`tb12_ong`) REFERENCES `tb01_ongs` (`tb01_cnpj`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb12_imagens: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `tb12_imagens` DISABLE KEYS */;
INSERT INTO `tb12_imagens` (`tb12_seq`, `tb12_ong`, `tb12_extencao`, `tb12_data_upload`, `tb12_descricao`) VALUES
	(1, 11111111111111, '.png', '2018-12-05', 'Imagem'),
	(2, 11111111111111, '.png', '2018-12-05', 'Logo2'),
	(3, 11111111111111, '.png', '2018-12-05', 'Escola');
/*!40000 ALTER TABLE `tb12_imagens` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb13_campanha_doacoes
CREATE TABLE IF NOT EXISTS `tb13_campanha_doacoes` (
  `tb13_sequencia` int(11) NOT NULL AUTO_INCREMENT,
  `tb13_user` bigint(20) DEFAULT NULL,
  `tb13_campanha` bigint(20) DEFAULT NULL,
  `tb13_material` int(11) DEFAULT NULL,
  `tb13_status` int(11) DEFAULT NULL,
  `tb13_data` date DEFAULT NULL,
  PRIMARY KEY (`tb13_sequencia`),
  KEY `FK_tb13_material` (`tb13_material`),
  KEY `FK_tb13_campanha` (`tb13_campanha`),
  KEY `FK_tb13_user` (`tb13_user`),
  CONSTRAINT `FK_tb13_campanha` FOREIGN KEY (`tb13_campanha`) REFERENCES `tb09_campanhas` (`tb09_id`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tb13_material` FOREIGN KEY (`tb13_material`) REFERENCES `tb03_tipo_doacao` (`tb03_cod`) ON UPDATE CASCADE,
  CONSTRAINT `FK_tb13_user` FOREIGN KEY (`tb13_user`) REFERENCES `tb08_user` (`tb08_id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb13_campanha_doacoes: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tb13_campanha_doacoes` DISABLE KEYS */;
INSERT INTO `tb13_campanha_doacoes` (`tb13_sequencia`, `tb13_user`, `tb13_campanha`, `tb13_material`, `tb13_status`, `tb13_data`) VALUES
	(1, 11111111111, 10, 4, 1, '2018-12-04');
/*!40000 ALTER TABLE `tb13_campanha_doacoes` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_tcc_doacao_novo.tb14_fale_conosco
CREATE TABLE IF NOT EXISTS `tb14_fale_conosco` (
  `tb14_seq` int(11) NOT NULL AUTO_INCREMENT,
  `tb14_texto` text,
  `tb14_user` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`tb14_seq`),
  KEY `FK_tb14_user` (`tb14_user`),
  CONSTRAINT `FK_tb14_user` FOREIGN KEY (`tb14_user`) REFERENCES `tb08_user` (`tb08_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_tcc_doacao_novo.tb14_fale_conosco: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tb14_fale_conosco` DISABLE KEYS */;
INSERT INTO `tb14_fale_conosco` (`tb14_seq`, `tb14_texto`, `tb14_user`) VALUES
	(1, 'IMG', NULL);
/*!40000 ALTER TABLE `tb14_fale_conosco` ENABLE KEYS */;

-- Copiando estrutura para trigger banco_tcc_doacao_novo.tg_atualiza_user
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='';
DELIMITER //
CREATE TRIGGER `tg_atualiza_user` AFTER UPDATE ON `tb01_ongs` FOR EACH ROW BEGIN
	
	update tb08_user set tb08_nome = new.tb01_nome, tb08_senha = new.tb01_senha, tb08_email = new.tb01_email where tb08_id = old.tb01_cnpj;

END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Copiando estrutura para trigger banco_tcc_doacao_novo.tg_delete
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='';
DELIMITER //
CREATE TRIGGER `tg_delete` BEFORE DELETE ON `tb09_campanhas` FOR EACH ROW BEGIN

Delete from tb10_ongs_campanhas where tb10_campanha = old.tb09_id;
Delete from tb11_campanha_doacoes where tb11_campanha = old.tb09_id;

END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
