CREATE DATABASE  IF NOT EXISTS `access` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `access`;
-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: access
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `benutzergruppen`
--

DROP TABLE IF EXISTS `benutzergruppen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `benutzergruppen` (
  `idbenutzergruppen` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`idbenutzergruppen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Temporary view structure for view `faecherzuteilung`
--

DROP TABLE IF EXISTS `faecherzuteilung`;
/*!50001 DROP VIEW IF EXISTS `faecherzuteilung`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `faecherzuteilung` AS SELECT 
 1 AS `Semester`,
 1 AS `Fach`,
 1 AS `Klasse`,
 1 AS `Se_Nr`,
 1 AS `Fae_Nr`,
 1 AS `Kl_Nr`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `switchboard items`
--

DROP TABLE IF EXISTS `switchboard items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `switchboard items` (
  `SwitchboardID` int(11) NOT NULL,
  `ItemNumber` int(11) NOT NULL DEFAULT '0',
  `ItemText` varchar(255) DEFAULT NULL,
  `Command` int(11) DEFAULT NULL,
  `Argument` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`SwitchboardID`,`ItemNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_anrede`
--

DROP TABLE IF EXISTS `tbl_anrede`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_anrede` (
  `An_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Anrede` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`An_Nr`),
  UNIQUE KEY `Anrede` (`Anrede`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_beruf`
--

DROP TABLE IF EXISTS `tbl_beruf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_beruf` (
  `Be_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Beruf` varchar(40) DEFAULT NULL,
  `Kürzel` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`Be_Nr`),
  UNIQUE KEY `Beruf` (`Beruf`),
  UNIQUE KEY `Kürzel` (`Kürzel`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_fae_kla_sem`
--

DROP TABLE IF EXISTS `tbl_fae_kla_sem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_fae_kla_sem` (
  `Fae_Kla_Sem` int(11) NOT NULL AUTO_INCREMENT,
  `Fae_Nr` int(11) DEFAULT '0',
  `Se_Nr` int(11) DEFAULT '0',
  `Kl_Nr` int(11) DEFAULT '0',
  PRIMARY KEY (`Fae_Kla_Sem`),
  UNIQUE KEY `Fae_Nr` (`Fae_Nr`,`Se_Nr`,`Kl_Nr`),
  KEY `Fae_Nr_2` (`Fae_Nr`),
  KEY `Kl_Nr` (`Kl_Nr`),
  KEY `Se_Nr` (`Se_Nr`)
) ENGINE=InnoDB AUTO_INCREMENT=229 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_faecher`
--

DROP TABLE IF EXISTS `tbl_faecher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_faecher` (
  `Fae_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Fach` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Fae_Nr`),
  UNIQUE KEY `Fach` (`Fach`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_firma`
--

DROP TABLE IF EXISTS `tbl_firma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_firma` (
  `Fi_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `F_Name` varchar(50) DEFAULT NULL,
  `F_Vorname` varchar(20) DEFAULT NULL,
  `F_Nachname` varchar(30) DEFAULT NULL,
  `F_Strasse` varchar(30) DEFAULT NULL,
  `An_Nr` int(11) DEFAULT '0',
  `Or_Nr` int(11) DEFAULT '0',
  `F_Ansprechperson` varchar(50) DEFAULT NULL,
  `F_Zusatz` varchar(255) DEFAULT NULL,
  `F_Telefon` varchar(30) DEFAULT NULL,
  `F_Fax` varchar(30) DEFAULT NULL,
  `F_Aktiv` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Fi_Nr`),
  KEY `An_Nr` (`An_Nr`),
  KEY `F_Aktiv` (`F_Aktiv`),
  KEY `F_Ansprechperson` (`F_Ansprechperson`),
  KEY `F_Zusatz` (`F_Zusatz`),
  KEY `F_Name` (`F_Name`),
  KEY `Or_Nr` (`Or_Nr`)
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_klasse`
--

DROP TABLE IF EXISTS `tbl_klasse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_klasse` (
  `Kl_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Klasse` varchar(30) DEFAULT NULL,
  `Be_Nr` int(11) DEFAULT '0',
  PRIMARY KEY (`Kl_Nr`),
  UNIQUE KEY `Klasse` (`Klasse`),
  KEY `Be_Nr` (`Be_Nr`)
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_lehrling`
--

DROP TABLE IF EXISTS `tbl_lehrling`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_lehrling` (
  `Ll_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Fi_Nr` int(11) DEFAULT '0',
  `An_Nr` int(11) DEFAULT '0',
  `Name` varchar(30) DEFAULT NULL,
  `Vorname` varchar(20) DEFAULT NULL,
  `Strasse` varchar(30) DEFAULT NULL,
  `Or_Nr` int(11) DEFAULT '0',
  `Telefon` varchar(30) DEFAULT NULL,
  `Zusatz` varchar(255) DEFAULT NULL,
  `weibl` tinyint(1) DEFAULT '0',
  `GebDat` datetime DEFAULT NULL,
  `Lj_Nr` int(11) DEFAULT '0',
  `Aktiv` tinyint(1) DEFAULT '1',
  `Kl_Nr` int(11) DEFAULT '0',
  PRIMARY KEY (`Ll_Nr`),
  KEY `An_Nr` (`An_Nr`),
  KEY `Aktiv` (`Aktiv`),
  KEY `Fi_Nr` (`Fi_Nr`),
  KEY `Kl_Nr` (`Kl_Nr`),
  KEY `Lj_Nr` (`Lj_Nr`),
  KEY `Name` (`Name`),
  KEY `Or_Nr` (`Or_Nr`),
  KEY `Vorname` (`Vorname`),
  KEY `weibl` (`weibl`),
  KEY `Zusatz` (`Zusatz`)
) ENGINE=InnoDB AUTO_INCREMENT=1044 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_lehrzeiten`
--

DROP TABLE IF EXISTS `tbl_lehrzeiten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_lehrzeiten` (
  `Lj_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Lj_Von` int(11) DEFAULT '0',
  `Lj_Bis` int(11) DEFAULT '0',
  PRIMARY KEY (`Lj_Nr`),
  UNIQUE KEY `Lj_Von` (`Lj_Von`,`Lj_Bis`),
  KEY `Lj_Bis` (`Lj_Bis`),
  KEY `Lj_Von_2` (`Lj_Von`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_noten`
--

DROP TABLE IF EXISTS `tbl_noten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_noten` (
  `No_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Note_1` float DEFAULT NULL,
  `GewN1` float DEFAULT '0',
  `Note_2` float DEFAULT NULL,
  `GewN2` float DEFAULT '0',
  `Note_3` float DEFAULT NULL,
  `GewN3` float DEFAULT '0',
  `Note_4` float DEFAULT NULL,
  `GewN4` float DEFAULT '0',
  `Note_5` float DEFAULT NULL,
  `GewN5` float DEFAULT '0',
  `Fae_Nr` int(11) DEFAULT '0',
  `Ll_Nr` int(11) DEFAULT '0',
  `Se_Nr` int(11) DEFAULT '0',
  PRIMARY KEY (`No_Nr`),
  UNIQUE KEY `Ll_Nr` (`Ll_Nr`,`Fae_Nr`,`Se_Nr`),
  KEY `Fae_Nr` (`Fae_Nr`),
  KEY `Ll_Nr_2` (`Ll_Nr`),
  KEY `Se_Nr` (`Se_Nr`)
) ENGINE=InnoDB AUTO_INCREMENT=3089 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_ort`
--

DROP TABLE IF EXISTS `tbl_ort`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_ort` (
  `Or_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `PLZ` varchar(10) DEFAULT NULL,
  `Ort` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Or_Nr`),
  UNIQUE KEY `PLZ` (`PLZ`,`Ort`),
  UNIQUE KEY `PLZ_2` (`PLZ`),
  KEY `Ort` (`Ort`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tbl_semester`
--

DROP TABLE IF EXISTS `tbl_semester`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tbl_semester` (
  `Se_Nr` int(11) NOT NULL AUTO_INCREMENT,
  `Semester` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Se_Nr`),
  UNIQUE KEY `Semester` (`Semester`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `user` (
  `iduser` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Vorname` varchar(45) NOT NULL,
  `Benutzername` varchar(45) NOT NULL,
  `Passwort` varchar(255) NOT NULL,
  `Admin` tinyint(1) NOT NULL,
  `idBenutzergruppen` int(11) DEFAULT NULL,
  PRIMARY KEY (`iduser`),
  UNIQUE KEY `Benutzername_UNIQUE` (`Benutzername`),
  KEY `idBenutzergruppen_idx` (`idBenutzergruppen`),
  CONSTRAINT `idBenutzergruppen` FOREIGN KEY (`idBenutzergruppen`) REFERENCES `benutzergruppen` (`idbenutzergruppen`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Final view structure for view `faecherzuteilung`
--

/*!50001 DROP VIEW IF EXISTS `faecherzuteilung`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `faecherzuteilung` AS select `tbl_semester`.`Semester` AS `Semester`,`tbl_faecher`.`Fach` AS `Fach`,`tbl_klasse`.`Klasse` AS `Klasse`,`tbl_semester`.`Se_Nr` AS `Se_Nr`,`tbl_faecher`.`Fae_Nr` AS `Fae_Nr`,`tbl_klasse`.`Kl_Nr` AS `Kl_Nr` from (((`tbl_fae_kla_sem` join `tbl_klasse` on((`tbl_fae_kla_sem`.`Kl_Nr` = `tbl_klasse`.`Kl_Nr`))) join `tbl_faecher` on((`tbl_fae_kla_sem`.`Fae_Nr` = `tbl_faecher`.`Fae_Nr`))) join `tbl_semester` on((`tbl_fae_kla_sem`.`Se_Nr` = `tbl_semester`.`Se_Nr`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
INSERT INTO `user` VALUES (1,'vmadmin','vmadmin','vmadmin','x7eyRa9wS0b7Izwn9HagLsYjV+77ADz3Q/20wv5tH6XQcvvR',1,3);
INSERT INTO `benutzergruppen` VALUES (1,'Schüler'),(2,'Dozent'),(3,'Verwaltung');
