-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: bd
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbarticulos`
--

DROP TABLE IF EXISTS `tbarticulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbarticulos` (
  `id` int NOT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `estado` int DEFAULT NULL,
  `fk_idProveedor` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_idProveedor` (`fk_idProveedor`),
  CONSTRAINT `tbarticulos_ibfk_1` FOREIGN KEY (`fk_idProveedor`) REFERENCES `tbproveedores` (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbarticulos`
--

LOCK TABLES `tbarticulos` WRITE;
/*!40000 ALTER TABLE `tbarticulos` DISABLE KEYS */;
INSERT INTO `tbarticulos` VALUES (10,'Botella 2Lts',1,1),(11,'Botella 2.5Lts',1,2),(28,'Botell 5lts',1,3),(38,'Botella 4Lts',1,4);
/*!40000 ALTER TABLE `tbarticulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbproveedores`
--

DROP TABLE IF EXISTS `tbproveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbproveedores` (
  `idProveedor` int NOT NULL,
  `razonSocial` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbproveedores`
--

LOCK TABLES `tbproveedores` WRITE;
/*!40000 ALTER TABLE `tbproveedores` DISABLE KEYS */;
INSERT INTO `tbproveedores` VALUES (1,'COCA-COLA'),(2,'PEPSI'),(3,'FANTA'),(4,'BAVARIA');
/*!40000 ALTER TABLE `tbproveedores` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-09 20:00:30
