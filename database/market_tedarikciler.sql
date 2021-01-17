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
-- Table structure for table `tedarikciler`
--

DROP TABLE IF EXISTS `tedarikciler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tedarikciler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tedarikciAdi` varchar(45) NOT NULL,
  `tedarikciAdres` text NOT NULL,
  `urunAdi` varchar(45) NOT NULL,
  `fiyat` double NOT NULL,
  `stok` int NOT NULL,
  `kategori` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tedarikciler`
--

LOCK TABLES `tedarikciler` WRITE;
/*!40000 ALTER TABLE `tedarikciler` DISABLE KEYS */;
INSERT INTO `tedarikciler` VALUES (1,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','ÜLKER İkram Biskivü',2,155,'Gıda Ürünleri'),(2,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','ETİ Benim o Biskivü',2.5,200,'Gıda Ürünlei'),(3,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','ARIEL Toz Çamaşır Deterjanı 5 kg',56.9,56,'Temizlik Ürünleri'),(4,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','FİLİZ Makarna Kelebek',3,100,'Gıda Ürünleri'),(5,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','ICE-TEA Soğuk Çay',6.8,150,'Gıda Ürünleri'),(6,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','ABC Yumuşatıcı 2 kg',33,60,'Temizlik Ürünleri'),(7,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','SEK Süt 1 L',5.25,50,'Gıda Ürünleri'),(8,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','Çif Yağ Sökücü 750 ml',8.5,2,'Temizlik Ürünleri'),(9,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','YUDUM Ay Çiçek Yağı 2 Litre',33.9,48,'Gıda Ürünleri'),(10,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','KNORR Ezo gelin Çorbası',3.75,39,'Gıda Ürünleri'),(11,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','Mr Muscle Lavabo Açıcı',15,26,'Gıda Ürünleri'),(12,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','DURU Doğal Sabun 1 kg',19.94,45,'Temizlik Ürünleri'),(13,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','SÜTAŞ Süzme Peynir 500gr',15.9,95,'Gıda Ürünleri'),(14,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','Dixi Sıvı Yüzey Temizleyici 2.5 L',10.9,40,'Temizlik Ürünleri'),(15,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','Yayla Kırmızı Mercimek 1 kg',13.5,100,'Gıda Ürünleri'),(16,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','Torku Tereyağı 1 kg',69.95,150,'Gıda Ürünleri'),(17,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','Mimsan Şeffaf Eldiven 500 Adet',16.31,128,'Temizlik Ürünleri'),(18,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Nivea Nemlendirici Krem 300 ml',12.88,65,'Haftalık Kampanya Ürünleri'),(19,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','Garnier Nem Bombası',8.34,36,'Temizlik Ürünleri'),(20,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Çaykur Tiryaki Çayı 1 kg',32.75,80,'Haftalık Kampanya Ürünleri'),(21,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Selin Limon Kolonyası 900 ml',29.9,32,'Haftalık Kampanya Ürünleri'),(22,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','Dr.Oetker Pudra Şekeri 250 gr',5.65,89,'Gıda Ürünleri'),(23,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Nutella 750 gr',29.6,99,'Haftalık Kampanya Ürünleri'),(24,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Koroplast Çöp torbası 30 adet',10,78,'Haftalık Kampanya Ürünleri'),(25,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','İçim  Krema 200 ml',6.95,62,'Gıda Ürünleri'),(26,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','Familia Deterjanlı Havlu',6.95,48,'Temizlik Ürünleri'),(27,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Evony 3 Katlı Cerrahi Maske 50 adet',39.8,73,'Haftalık Kampanya Ürünleri'),(28,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Billur Sofra Tuzu 750 gr',4.3,205,'Haftalık Kampyan Ürünleri'),(29,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','Pınar Organik Yoğurt 1 kg',13.75,128,'Gıda Ürünleri'),(30,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Ellidor Şampuan 650 ml',21.9,105,'Haftalık Kampanya Ürünleri'),(31,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','Listerine Ağız Suyu 1 kg',29.9,95,'Haftalık Kampanya Ürünleri'),(32,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','Nescafe 3 ü 1 arada 15 adet',12.45,84,'Gıda Ürünleri'),(33,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','ORKİD Hijyenik Ped 22 li',18.4,186,'Haftalık Kampanya Ürünleri'),(34,'Metro','Maltepe, Anadolu Cd. No:8108, 35640 Çiğli/İzmir','HACI Şakir Beyaz SABUN 4 adet',16.25,164,'Haftalık Kampanya Ürünleri'),(35,'Dolaz Gıda','Turgut Özal, 40. Sk. No:12/A, 45020 Şehzadeler/Manisa','Doritos Baharatlı Cips 218 gr',6.95,86,'Gıda Ürünleri'),(36,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','Finish Bulaşık Makinesi Deterjanı',41.95,137,'Temizlik Ürünleri'),(37,'Mepa Temizlik','Yenişehir, 1145/2. Sk. No:8-AA, 35050 Konak/İzmir','OMO Sıvı deterjan 2 L',28.4,77,'Temizlik Ürünleri');
/*!40000 ALTER TABLE `tedarikciler` ENABLE KEYS */;
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
