-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: market
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `subeler`
--

DROP TABLE IF EXISTS `subeler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subeler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `il` varchar(45) NOT NULL,
  `ilce` varchar(45) NOT NULL,
  `adres` text NOT NULL,
  `marketIsmi` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subeler`
--

LOCK TABLES `subeler` WRITE;
/*!40000 ALTER TABLE `subeler` DISABLE KEYS */;
INSERT INTO `subeler` VALUES (1,'AYDIN','SÖKE','YENİKENT MAHALLESİ','Elit Market'),(2,'İZMİR','BORNOVA','ATATÜRK MAHALLESİ','Palmiye Market'),(3,'ANKARA','KIZILAY','NAMIK KEMAL MAHALLESİ','Zengin Market'),(4,'MANİSA','TURGUTLU','SELVİLİTEPE MAHALLESİ','Yörem Market'),(5,'AYDIN','KUŞADASI','DAVUTLAR MAHALLESİ','Seçmar Market'),(6,'BURSA','NİLÜFER','BEŞEVLER MAHALLESİ','Sandal Market'),(7,'SAMSUN','ATAKUM','AKSU MAHALLESİ','Ada Market'),(8,'NEVŞEHİR','AVANOS','YENİ MAHALLESİ','Yerli Market'),(9,'BALIKESİR','AYVALIK','ÇAKMAK MAHALLESİ','Bahar Market'),(10,'ANTALYA','ALANYA','BIÇAKCI  MAHALLESİ','Ucuz Market');
/*!40000 ALTER TABLE `subeler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-27 20:52:46
