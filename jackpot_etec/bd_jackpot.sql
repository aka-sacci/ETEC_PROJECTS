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


-- Copiando estrutura do banco de dados para bd_jackpot
CREATE DATABASE IF NOT EXISTS `bd_jackpot` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_jackpot`;

-- Copiando estrutura para tabela bd_jackpot.tb01_apostas
CREATE TABLE IF NOT EXISTS `tb01_apostas` (
  `tb01_sequencia` int(11) NOT NULL AUTO_INCREMENT,
  `tb01_data` date DEFAULT NULL,
  `tb01_valor` double DEFAULT NULL,
  PRIMARY KEY (`tb01_sequencia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela bd_jackpot.tb01_apostas: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tb01_apostas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb01_apostas` ENABLE KEYS */;

-- Copiando estrutura para tabela bd_jackpot.tb02_ganhadores
CREATE TABLE IF NOT EXISTS `tb02_ganhadores` (
  `tb02_sequencia` int(11) NOT NULL AUTO_INCREMENT,
  `tb02_data` date DEFAULT NULL,
  `tb02_nome` varchar(50) DEFAULT NULL,
  `tb02_valor` double DEFAULT NULL,
  PRIMARY KEY (`tb02_sequencia`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela bd_jackpot.tb02_ganhadores: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tb02_ganhadores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb02_ganhadores` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
