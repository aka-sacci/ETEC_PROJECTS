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


-- Copiando estrutura do banco de dados para banco_mercado
CREATE DATABASE IF NOT EXISTS `banco_mercado` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `banco_mercado`;

-- Copiando estrutura para tabela banco_mercado.tb01_produtos
CREATE TABLE IF NOT EXISTS `tb01_produtos` (
  `tb01_codigo` varchar(20) NOT NULL,
  `tb01_nome` varchar(200) NOT NULL,
  `tb01_preco` double(10,2) NOT NULL,
  PRIMARY KEY (`tb01_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_mercado.tb01_produtos: ~15 rows (aproximadamente)
/*!40000 ALTER TABLE `tb01_produtos` DISABLE KEYS */;
INSERT INTO `tb01_produtos` (`tb01_codigo`, `tb01_nome`, `tb01_preco`) VALUES
	('1010101010101', 'ANTENA (S/ VITOR)', 10.00),
	('1010101010102', 'CALIXTRAUM XAVETA', 2.00),
	('1010101010103', 'LANÇA DO NALDO', 10.00),
	('1010101010104', 'NORMA DECEPÇAO', 4.00),
	('1010101010105', 'SERGIO CUEIO', 20.50),
	('1111111111111', 'GORDO FEDIDO', 5.00),
	('2222222222222', 'SERGIAO NORMAL', 200.00),
	('3333333333333', 'ANTENA (C/ VITOR)', 5.00),
	('4444444444444', 'BIA PIRATA', 0.50),
	('5555555555555', 'SERGIÃO HOKAGE', 500.00),
	('6666666666666', 'CACHAÇA DO RODRIGO', 2.50),
	('7777777777777', 'IGINHU HAPPY', 5.00),
	('7892840808068', 'GATORADE SABORES', 2.99),
	('8888888888888', 'AÇALTANTE PERIGOZO', 0.50),
	('9999999999999', 'BIA BUGADA', 10.00);
/*!40000 ALTER TABLE `tb01_produtos` ENABLE KEYS */;

-- Copiando estrutura para tabela banco_mercado.tb02_cupom
CREATE TABLE IF NOT EXISTS `tb02_cupom` (
  `tb02_num_cupom` int(6) NOT NULL AUTO_INCREMENT,
  `tb02_valor` double(10,2) NOT NULL,
  `tb02_data` datetime DEFAULT NULL,
  PRIMARY KEY (`tb02_num_cupom`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela banco_mercado.tb02_cupom: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tb02_cupom` DISABLE KEYS */;
INSERT INTO `tb02_cupom` (`tb02_num_cupom`, `tb02_valor`, `tb02_data`) VALUES
	(2, 5.00, NULL);
/*!40000 ALTER TABLE `tb02_cupom` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
