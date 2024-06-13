-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: shalom-db
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `asistencia`
--

DROP TABLE IF EXISTS `asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asistencia` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `numcomprometidos` int DEFAULT NULL,
  `idgrupo` int DEFAULT NULL,
  `usucre` varchar(45) DEFAULT NULL,
  `usumod` varchar(45) DEFAULT NULL,
  `fechacre` datetime DEFAULT NULL,
  `fechamod` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `grupo` FOREIGN KEY (`id`) REFERENCES `grupo` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia`
--

LOCK TABLES `asistencia` WRITE;
/*!40000 ALTER TABLE `asistencia` DISABLE KEYS */;
INSERT INTO `asistencia` VALUES (3,'2024-06-15',0,1,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `evento` (
  `id` int NOT NULL,
  `nombre` varchar(105) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `numpersonas` int DEFAULT NULL,
  `idobra` int DEFAULT NULL,
  `idtipo` int DEFAULT NULL,
  `usucre` varchar(45) DEFAULT NULL,
  `usumod` varchar(45) DEFAULT NULL,
  `fechacre` datetime DEFAULT NULL,
  `fechamod` datetime DEFAULT NULL,
  KEY `idtipo` (`idtipo`),
  KEY `obra_idx` (`idobra`),
  CONSTRAINT `idtipo` FOREIGN KEY (`idtipo`) REFERENCES `tipoevento` (`id`),
  CONSTRAINT `odobraevento` FOREIGN KEY (`idobra`) REFERENCES `obra` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (1,'Seminario 1','2024-12-10 12:00:00',10,1,1,NULL,NULL,NULL,NULL),(2,'Evangelizacion','2024-12-20 12:00:00',1,2,2,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo`
--

DROP TABLE IF EXISTS `grupo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `numpersonas` int DEFAULT NULL,
  `idobra` int NOT NULL,
  `idtipogrupo` int NOT NULL,
  `activo` bit(1) DEFAULT NULL,
  `usucre` varchar(45) DEFAULT NULL,
  `usumod` varchar(45) DEFAULT NULL,
  `fechacre` datetime DEFAULT NULL,
  `fechamod` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idtipogrupo_idx` (`idtipogrupo`),
  KEY `idobragrupo_idx` (`idobra`),
  CONSTRAINT `idobragrupo` FOREIGN KEY (`idobra`) REFERENCES `obra` (`id`),
  CONSTRAINT `idtipogrupo` FOREIGN KEY (`idtipogrupo`) REFERENCES `tipogrupo` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo`
--

LOCK TABLES `grupo` WRITE;
/*!40000 ALTER TABLE `grupo` DISABLE KEYS */;
INSERT INTO `grupo` VALUES (1,'Test',10,1,1,_binary '',NULL,NULL,NULL,NULL),(2,'Test 2',11,1,1,_binary '',NULL,NULL,NULL,NULL),(3,'Testtest',6,2,2,_binary '',NULL,NULL,NULL,NULL),(4,'TEST5',30,1,1,_binary '',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `grupo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `obra`
--

DROP TABLE IF EXISTS `obra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `obra` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `activo` bit(1) DEFAULT NULL,
  `usucre` varchar(45) DEFAULT NULL,
  `usumod` varchar(45) DEFAULT NULL,
  `fechacre` datetime DEFAULT NULL,
  `fechamod` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `obra`
--

LOCK TABLES `obra` WRITE;
/*!40000 ALTER TABLE `obra` DISABLE KEYS */;
INSERT INTO `obra` VALUES (1,'Bogota',_binary '\0',NULL,NULL,NULL,NULL),(2,'Bogota',_binary '',NULL,NULL,NULL,NULL),(3,'Obra nueva',_binary '',NULL,NULL,NULL,NULL),(4,'Obra nueva',_binary '',NULL,NULL,NULL,NULL),(5,'Obra nueva',_binary '',NULL,NULL,NULL,NULL),(6,'Obra nueva',_binary '',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `obra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Administrador'),(2,'Usuario');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoevento`
--

DROP TABLE IF EXISTS `tipoevento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipoevento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `usucre` varchar(45) DEFAULT NULL,
  `usumod` varchar(45) DEFAULT NULL,
  `fechacre` datetime DEFAULT NULL,
  `fechamod` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoevento`
--

LOCK TABLES `tipoevento` WRITE;
/*!40000 ALTER TABLE `tipoevento` DISABLE KEYS */;
INSERT INTO `tipoevento` VALUES (1,'Seminario',NULL,NULL,NULL,NULL),(2,'Evangelizacion',NULL,NULL,NULL,NULL),(3,'Semirario',NULL,NULL,NULL,NULL),(4,'Test',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tipoevento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipogrupo`
--

DROP TABLE IF EXISTS `tipogrupo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipogrupo` (
  `id` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `usucre` varchar(45) DEFAULT NULL,
  `usumod` varchar(45) DEFAULT NULL,
  `fechacre` datetime DEFAULT NULL,
  `fechamod` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipogrupo`
--

LOCK TABLES `tipogrupo` WRITE;
/*!40000 ALTER TABLE `tipogrupo` DISABLE KEYS */;
INSERT INTO `tipogrupo` VALUES (1,'Jovenes',NULL,NULL,NULL,NULL),(2,'Adultos',NULL,NULL,NULL,NULL),(3,'Abierto',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tipogrupo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Username` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IdRol` int NOT NULL,
  `idobra` int DEFAULT NULL,
  `usucre` varchar(45) DEFAULT NULL,
  `usumod` varchar(45) DEFAULT NULL,
  `fechacre` datetime DEFAULT NULL,
  `fechamod` datetime DEFAULT NULL,
  `activo` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE,
  KEY `rol_idx` (`IdRol`),
  KEY `obra_idx` (`idobra`),
  CONSTRAINT `obra` FOREIGN KEY (`idobra`) REFERENCES `obra` (`id`),
  CONSTRAINT `rol` FOREIGN KEY (`IdRol`) REFERENCES `rol` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Tomas1','tcampo','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',1,1,NULL,NULL,NULL,NULL,_binary ''),(2,'Sandra','san','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3',2,2,NULL,NULL,NULL,NULL,_binary ''),(3,'test','test3','test',1,1,NULL,NULL,NULL,NULL,_binary ''),(4,'Sandra1','test','test',1,1,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-13 22:09:40
