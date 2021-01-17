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
-- Table structure for table `calisanlar`
--

DROP TABLE IF EXISTS `calisanlar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `calisanlar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `adSoyad` varchar(45) NOT NULL,
  `adres` text NOT NULL,
  `maas` double NOT NULL,
  `subeID` int NOT NULL,
  `pozisyon` varchar(45) NOT NULL,
  `kullaniciID` int DEFAULT NULL,
  `iseBaslamaTarihi` datetime DEFAULT CURRENT_TIMESTAMP,
  `izinHakki` int DEFAULT '14',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `calisanlar`
--

LOCK TABLES `calisanlar` WRITE;
/*!40000 ALTER TABLE `calisanlar` DISABLE KEYS */;
INSERT INTO `calisanlar` VALUES (1,'Doğukan YOLCUOĞLU','Fevzipaşa Mahallesi Zümrüt Sok. No:98 Aydın/Söke',15000,1,'Müdür',2,'2020-12-26 23:20:54',14),(2,'Ender GÜLGER','Atatürk Mahallesi 1308 Sokak No:23/5  İzmir/Borova',16000,6,'Müdür',3,'2020-12-26 23:33:22',14),(3,'Mert GÜVEN','Büyükhasbahçe, Bektaş Cd., 07400 Alanya/Antalya',7000,10,'Müdür Yardımcısı',NULL,'2020-12-26 23:36:26',14),(4,'Eray HAMURLU','Selvilitepe Mahallesi No:25 Manisa/Turgutlu',9000,4,'Müdür',6,'2020-12-26 23:38:04',11),(5,'Cafer SATIK','Sazlı Kazım Karabekir Mahallesi Menekşe Sokak No:24 Aydın/Söke',10000,10,'Müdür',4,'2020-12-26 23:41:21',9),(6,'Oğuz DEMİREL','Konak Mahallesi İstasyon Caddesi Pamuk Sokak No:12 Balıkesir/Ayvalık',5000,4,'Müdür Yardımcısı',NULL,'2020-12-26 23:43:46',10),(7,'Şükrü SAYIN','Yeni Cami Mahallesi Etap Sokak No:63 Samsun/Atakum',8000,6,'Müdür',5,'2020-12-26 23:45:19',8),(8,'Kemal YILDIZ','Haspolat Mahallesi Lapta Sokak No:33',5000,4,'Müdür Yardımcısı',NULL,'2020-12-26 23:47:19',14);
/*!40000 ALTER TABLE `calisanlar` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-27 20:52:45
