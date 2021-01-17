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
-- Table structure for table `urunler`
--

DROP TABLE IF EXISTS `urunler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `urunler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `urunAdi` varchar(60) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `fiyat` double NOT NULL,
  `indirimYuzdesi` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `indirimTarihi` datetime DEFAULT NULL,
  `stokDurumu` int NOT NULL,
  `subeID` int NOT NULL,
  `kategori` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=183 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `urunler`
--

LOCK TABLES `urunler` WRITE;
/*!40000 ALTER TABLE `urunler` DISABLE KEYS */;
INSERT INTO `urunler` VALUES (1,'ÜLKER İkram Biskivü',2,NULL,NULL,26,7,'Gıda Ürünleri'),(2,'ETİ Benim\'o Biskivü',2.5,NULL,NULL,18,9,'Gıda Ürünlei'),(3,'ARIEL Toz Çamaşır Deterjanı 5 kg',56.9,'%5','2020-12-20 16:32:37',24,2,'Temizlik Ürünleri'),(4,'FİLİZ Makarna Kelebek',3,NULL,NULL,64,4,'Gıda Ürünleri'),(5,'ICE-TEA Soğuk Çay',6.8,'%3','2020-12-19 01:51:03',31,6,'Gıda Ürünleri'),(6,'ABC Yumuşatıcı 2 kg',33,NULL,NULL,7,10,'Temizlik Ürünleri'),(7,'SEK Süt 1 L',5.25,NULL,NULL,49,6,'Gıda Ürünleri'),(8,'Çif Yağ Sökücü 750 ml',8.07,'%5','2020-12-27 18:55:12',66,10,'Temizlik Ürünleri'),(9,'YUDUM Ay Çiçek Yağı 2 Litre',29.62,'%8','2020-12-27 19:41:46',101,4,'Gıda Ürünleri'),(10,'KNORR Ezo gelin Çorbası',3.75,NULL,NULL,55,1,'Gıda Ürünleri'),(12,'Mr Muscle Lavabo Açıcı',15,NULL,NULL,41,2,'Gıda Ürünleri'),(13,'DURU Doğal Sabun 1 kg',17.59,'%10','2020-12-27 19:31:01',36,8,'Temizlik Ürünleri'),(14,'SÜTAŞ Süzme Peynir 500gr',13.99,NULL,NULL,11,7,'Gıda Ürünleri'),(15,'Dixi Sıvı Yüzey Temizleyici 2.5 L',10.9,NULL,NULL,17,6,'Temizlik Ürünleri'),(16,'Yayla Kırmızı Mercimek 1 kg',13.5,NULL,NULL,38,9,'Gıda Ürünleri'),(17,'Torku Tereyağı 1 kg',66.45,'%5','2020-12-27 19:36:14',46,3,'Gıda Ürünleri'),(18,'Mimsan Şeffaf Eldiven 500 Adet',15.49,'%5','2020-12-27 19:17:26',69,5,'Temizlik Ürünleri'),(19,'Nivea Nemlendirici Krem 300 ml',12.88,'%6','2020-12-19 01:51:03',93,4,'Haftalık Kampanya Ürünleri'),(20,'Garnier Nem Bombası',8.34,NULL,NULL,71,10,'Temizlik Ürünleri'),(21,'Çaykur Tiryaki Çayı 1 kg',31.11,'%5','2020-12-27 18:44:21',35,9,'Haftalık Kampanya Ürünleri'),(22,'Selin Limon Kolonyası 900 ml',27.51,'%8','2020-12-27 19:39:24',4,8,'Haftalık Kampanya Ürünleri'),(23,'Dr.Oetker Pudra Şekeri 250 gr',5.65,NULL,NULL,3,6,'Gıda Ürünleri'),(24,'Nutella 750 gr',29.6,'%10','2020-12-19 01:51:03',19,4,'Haftalık Kampanya Ürünleri'),(25,'Koroplast Çöp torbası 30 adet',10,NULL,NULL,25,3,'Haftalık Kampanya Ürünleri'),(26,'İçim  Krema 200 ml',6.95,NULL,NULL,21,2,'Gıda Ürünleri'),(27,'Familia Deterjanlı Havlu',6.95,NULL,NULL,49,1,'Temizlik Ürünleri'),(28,'Evony 3 Katlı Cerrahi Maske 50 adet',35.82,NULL,NULL,68,7,'Haftalık Kampanya Ürünleri'),(29,'Billur Sofra Tuzu 750 gr',4.3,NULL,NULL,13,3,'Haftalık Kampyan Ürünleri'),(30,'Pınar Organik Yoğurt 1 kg',13.75,'%9','2020-12-19 01:51:03',36,8,'Gıda Ürünleri'),(31,'Ellidor Şampuan 650 ml',21.9,NULL,NULL,79,9,'Haftalık Kampanya Ürünleri'),(32,'Listerine Ağız Suyu 1 kg',28.4,NULL,NULL,85,5,'Haftalık Kampanya Ürünleri'),(33,'Nescafe 3\'ü 1 arada 15 adet',12.45,NULL,NULL,101,7,'Gıda Ürünleri'),(34,'ORKİD Hijyenik Ped 22\'li',18.4,'%4','2020-12-19 01:51:03',48,4,'Haftalık Kampanya Ürünleri'),(35,'HACI Şakir Beyaz SABUN 4 adet',16.25,NULL,NULL,26,1,'Haftalık Kampanya Ürünleri'),(36,'Doritos Baharatlı Cips 218 gr',6.95,NULL,NULL,17,1,'Gıda Ürünleri'),(37,'Finish Bulaşık Makinesi Deterjanı',37.76,'%10','2020-12-27 19:15:11',25,8,'Temizlik Ürünleri'),(38,'OMO Sıvı deterjan 2 L',28.4,'%5','2020-12-21 02:15:42',12,10,'Temizlik Ürünleri'),(180,'YUDUM Ay Çiçek Yağı 2 Litre',50.85,NULL,NULL,30,6,'Gıda Ürünleri'),(181,'Çif Yağ Sökücü 750 ml',11.9,NULL,NULL,19,8,'Temizlik Ürünleri'),(182,'YUDUM Ay Çiçek Yağı 2 Litre',50.85,NULL,NULL,10,3,'Gıda Ürünleri');
/*!40000 ALTER TABLE `urunler` ENABLE KEYS */;
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
