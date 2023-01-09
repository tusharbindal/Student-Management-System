-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: schooldb
-- ------------------------------------------------------
-- Server version	5.7.9-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `mst_student`
--

DROP TABLE IF EXISTS `mst_student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mst_student` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `father_name` varchar(45) DEFAULT NULL,
  `fees` int(11) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `mobile_no` varchar(12) DEFAULT NULL,
  `mother_name` varchar(45) DEFAULT NULL,
  `class_id` int(11) DEFAULT NULL,
  `religion` varchar(20) DEFAULT NULL,
  `reg_date` date DEFAULT NULL,
  `images` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mst_student`
--

LOCK TABLES `mst_student` WRITE;
/*!40000 ALTER TABLE `mst_student` DISABLE KEYS */;
INSERT INTO `mst_student` VALUES (11,'Deeksha Tiwari','2022-11-19','Male ','Mr. Gajendra Tiwari',2000,'Agra','9067894534','Mrs. Neetu Tiwari',2,'1','2022-09-01',NULL),(12,'Rohit Agrawal','2022-11-19','Male ','Mr, Akhilesh ',2000,'Delhi','9720961425','Mrs. Anjali ',17,'2','2022-10-10',NULL),(13,'Mayank Agrawal','2009-01-15','Male ','Mr. Rohit Agrawal',7678,'Agra','867675785','Mrs. Ankita',2,'Hindu','2022-11-19','D:\\tushar Bindal\\Student_Project\\img\\02_Student_img.png'),(14,'Samarth Sharma','2020-02-05','Male ','Ankur',600,'Agra','9877654322','Kesar',2,'9','2022-11-19',NULL),(15,'Tushar Bindal','2020-01-29','Male ','Mr. Ravindra Kumar',2000,'Agra','7579551145','Mrs. sonam Bindal',20,'3','2022-11-19',NULL),(16,'Ritik Agrawal','2016-02-04','Male ','Mr. Tarun Agrawal',2000,'Noida, Uttar Pradesh','8090567869','Mrs.  Lakshmi Agrawal',13,'10','2022-11-21',NULL),(17,'Raju Sharma','2009-02-04','Male ','Mr. Ramesh Sharma',1000,'Dholpur','9823001289','Mrs. Suneeta Shrama',4,'11','2022-11-21',NULL),(18,'Hemant Sharma','2010-06-16','Male ','Mr. Rajkumar ',1200,'Agra','9789270013','Mrs. Seeta',14,'12','2022-11-21',''),(19,'Jatin Rajput','2011-10-27','Male ','Mr. Ankur Verma',2000,'Agra','9720983567','Mrs. Kajal Verma',18,'13','2022-11-21',''),(20,'Rahul','2014-07-17','Male ','Mr. Mahesh',2000,'Agra','9720961326','Mrs. Gunjan',20,'Hindu','2022-11-21','D:\\Align Project\\School_Projeact\\Student_Project\\img\\cover.jpg'),(21,'Sumit Mittal','2013-06-20','Male ','Mr. Ramavtar Mittal',2000,'Jagner, Agra','9411404072','Mrs. Suman Mittal',19,'Hindu','2022-11-21',''),(22,'Gunjan Agrawal','2011-06-15','Female','Mr. Ravindra Kumar',2000,'Agra','9720673425','Mrs. Anjali Agrawal',25,'Hindu','2022-11-21','D:\\Align Project\\School_Projeact\\Student_Project\\img\\cover3.jpg'),(23,'Akhilesh Tiwari','2013-06-12','Male ','Mr. Gajendra Tiwari',2000,'Agra','6390456700','Mrs. Lakshmi Tiwari',21,'Hindu','2022-11-21','D:\\Align Project\\School_Projeact\\Student_Project\\img\\02_Student_img.png'),(24,'Reetika ','2016-06-22','Female','Mr. Ram Kumar',2000,'Agra','906789078','Mrs. Pooja ',19,'Hindu','2022-11-21','C:\\Users\\hp\\Downloads\\7f34fc392de7d7cdc7d10079ee509dcb.jpg'),(25,'Sachin Sharma','1994-06-09','Male ','Mr. Akash',2999,'Agra','2389737869','Mrs. Anjali',3,'Hindu','2022-11-22','');
/*!40000 ALTER TABLE `mst_student` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-02 13:39:55
