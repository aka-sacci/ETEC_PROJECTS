-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para banco_sus
CREATE DATABASE IF NOT EXISTS `banco_sus` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `banco_sus`;

-- Copiando estrutura para tabela banco_sus.tb01_normal
CREATE TABLE IF NOT EXISTS `tb01_normal` (
  `tb01_nro` int(3) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `tb01_status` int(11) DEFAULT NULL,
  `tb01_data` datetime DEFAULT NULL,
  PRIMARY KEY (`tb01_nro`),
  KEY `tb01_status` (`tb01_status`),
  CONSTRAINT `tb01_status` FOREIGN KEY (`tb01_status`) REFERENCES `tb04_status` (`tb04_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela banco_sus.tb02_prioritario
CREATE TABLE IF NOT EXISTS `tb02_prioritario` (
  `tb02_nro` int(3) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `tb02_status` int(11) DEFAULT NULL,
  `tb02_data` datetime DEFAULT NULL,
  PRIMARY KEY (`tb02_nro`),
  KEY `tb02_status` (`tb02_status`),
  CONSTRAINT `tb02_status` FOREIGN KEY (`tb02_status`) REFERENCES `tb04_status` (`tb04_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela banco_sus.tb03_urgente
CREATE TABLE IF NOT EXISTS `tb03_urgente` (
  `tb03_nro` int(3) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `tb03_status` int(11) DEFAULT NULL,
  `tb03_data` datetime DEFAULT NULL,
  PRIMARY KEY (`tb03_nro`),
  KEY `tb03_status` (`tb03_status`),
  CONSTRAINT `tb03_status` FOREIGN KEY (`tb03_status`) REFERENCES `tb04_status` (`tb04_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela banco_sus.tb04_status
CREATE TABLE IF NOT EXISTS `tb04_status` (
  `tb04_cod` int(11) NOT NULL,
  `tb04_status` text DEFAULT NULL,
  PRIMARY KEY (`tb04_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela banco_sus.tb05_request
CREATE TABLE IF NOT EXISTS `tb05_request` (
  `tb05_cod` int(11) NOT NULL AUTO_INCREMENT,
  `tb05_status` int(11) DEFAULT NULL,
  `tb05_guiche` int(11) DEFAULT NULL,
  `tb05_data` datetime DEFAULT NULL,
  PRIMARY KEY (`tb05_cod`),
  KEY `tb05_status` (`tb05_status`),
  CONSTRAINT `tb05_status` FOREIGN KEY (`tb05_status`) REFERENCES `tb04_status` (`tb04_cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
