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


-- Copiando estrutura do banco de dados para banco_urna
CREATE DATABASE IF NOT EXISTS `banco_urna` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `banco_urna`;

-- Copiando estrutura para tabela banco_urna.tb01_candidatos
CREATE TABLE IF NOT EXISTS `tb01_candidatos` (
  `tb01_numero` int(4) NOT NULL,
  `tb01_cargo` int(4) NOT NULL,
  `tb01_votos` int(4) NOT NULL,
  `tb01_nome` text,
  `tb01_partido` char(6) DEFAULT NULL,
  `tb01_vice` text,
  PRIMARY KEY (`tb01_numero`),
  KEY `tb01_cargo` (`tb01_cargo`),
  KEY `tb01_partido` (`tb01_partido`),
  CONSTRAINT `tb01_cargo` FOREIGN KEY (`tb01_cargo`) REFERENCES `tb03_apuracao` (`tb03_cargo`),
  CONSTRAINT `tb01_partido` FOREIGN KEY (`tb01_partido`) REFERENCES `tb02_partido` (`tb02_partido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_urna.tb01_candidatos: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tb01_candidatos` DISABLE KEYS */;
INSERT INTO `tb01_candidatos` (`tb01_numero`, `tb01_cargo`, `tb01_votos`, `tb01_nome`, `tb01_partido`, `tb01_vice`) VALUES
	(21, 3, 0, 'Sergiao Grande Hokage', 'PV', 'Anderson'),
	(223, 1, 0, 'Katia Katiau', 'PF', 'Japa'),
	(666, 2, 0, 'Satanás', 'PF', '');
/*!40000 ALTER TABLE `tb01_candidatos` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_urna.tb02_partido
CREATE TABLE IF NOT EXISTS `tb02_partido` (
  `tb02_partido` char(6) NOT NULL,
  `tb02_descricao` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`tb02_partido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_urna.tb02_partido: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tb02_partido` DISABLE KEYS */;
INSERT INTO `tb02_partido` (`tb02_partido`, `tb02_descricao`) VALUES
	('PF', 'Partido da Favela'),
	('PI', 'Partido do Inferno'),
	('PV', 'Partido Veio');
/*!40000 ALTER TABLE `tb02_partido` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_urna.tb03_apuracao
CREATE TABLE IF NOT EXISTS `tb03_apuracao` (
  `tb03_validos` int(11) DEFAULT NULL,
  `tb03_brancos` int(11) DEFAULT NULL,
  `tb03_nulos` int(11) DEFAULT NULL,
  `tb03_cargo` int(11) NOT NULL,
  `tb03_descricao` text,
  PRIMARY KEY (`tb03_cargo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_urna.tb03_apuracao: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `tb03_apuracao` DISABLE KEYS */;
INSERT INTO `tb03_apuracao` (`tb03_validos`, `tb03_brancos`, `tb03_nulos`, `tb03_cargo`, `tb03_descricao`) VALUES
	(0, 0, 0, 1, 'Governador'),
	(0, 0, 0, 2, 'Senador'),
	(0, 0, 0, 3, 'Presidente e Vice');
/*!40000 ALTER TABLE `tb03_apuracao` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
