CREATE DATABASE  IF NOT EXISTS `hireme` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `hireme`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: hireme
-- ------------------------------------------------------
-- Server version	5.7.21-log

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
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(100) NOT NULL,
  `ContextKey` varchar(200) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`,`ContextKey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201810161349264_InitialCreate','HireMe.Models.ApplicationDbContext','�\0\0\0\0\0\0\�\\\�n\�6}/\��X�V.\�\�6�[�N\�\�\\�\�}[\�\�+��D�	�~Y�I���u\�M7+�S,��\�\�\�pH�\����?\��\��z�q\�c4��&����=�gvJV_����\�/�^�d�ZН0:\�%3���\�\�q�� ���\��\�\�š<\�~\�9�B\�˲�RD�f�s��#��\�\Z{0Hx9�Yd�\�\ra\�\��^\�INh[g���l �	 T\�ӏ	\\���\"� �� �[� �\\�ӊ�k/�Y/��a\�	�aO���Gn>H�v�6���`�\�z�)of_y0+���\0�\�\�<��̾.Y�%\�\r$��\�$���)\�8�<�#X�\��ft<9d��y\Z�4�3S�\���K��\���\��g�f\'G\�\�ɻ7o�w��x�\�S\�WJ\'Т�G0���U\�\�r\�v�ܰlVk�k�\���u\r�\�C�&t����K�	zE	7��ȧ�6\"qJ?o\� \0\�\0��N#O�\�\�7oG\�z�u6�:qb:�>� �M�(�^\�x\�d�1ٷh_y\�Nc�uI\�A��D�n\�T\�\�ɤ\��f]�\�i3IU�֒�\r�	�mφBޗ\�\�\�\�΢�^fZL#M\'\�S�ၕWWs\�\�`\�\��y�����\0v\�Bݎ���\�变�@�e�IB\��3H\ZD�?G}\�4�f�  �^�\�\�F�&\r�\�ڷ\�k����_�\���V\�\�\�g��\�?�\0d��~\�`q\�\\&\�%5f\�\�1���+DN�{ñ�i\�\�<\0~��@�U�SAZy!z\n\�1�鼑&Q\�㵏��Z��E\�)ZE\�d}Ee`\�$\�fA3�V9s�\���l�\�w�2\����6ۼMkAM��B �1]Ƽ;@�Q5]֍]8\��1�/�7e�~A:6�A�![Ɵ\r\��φLLZ�\�{\�+\�p\�)�)|\'z���}\�I�m{:\�\�6�\��\�r�$\���Y�	x�p�(?�\��\�E\�9�A;F\r\�g[-�}�e��E\�0�Zgn��\���F\�!��`Ŏ�����\�}��c\��CPBg���:-|\��Z�$�츅���<\�sA\��j�s}؃	P��MCS�fq͆h�ZMc\�\�\�V\�D#�b�-���.���\"�٬�-g�J�`\�\�\�@�Y��\��}3P\�\�d0P\�Rm\�@E�\��@E��:͏�]\�_:�\�y�\�\�o\�\�ځm\n�\�3\�\�}Oچ\�0V\��|\�*\�\�Ψ��|�pWW6��D\�T��\�u�Ad#j���_�)@ʄ\�!\\\�k��{=`��[#,_�%ؚ\r�\��K\�\Z���T6\�N���g�5(F\�\�P\�\���x�\�S\\VUL_��7\\\���x�%�]K�i�kI\��q\�6Ғ\�>�Ttft-qmW�\�)\�\�l�\"qi���r�)\�N�\���!jz\r�\�G\�Z>/�y2\��\�E�T�0\�p\�D�qTJ[r\"8k(\�R\�T\�K?N\�9 `	X�g\�\n�vo5,�\����b�\�\�w\�B���Y\�\�\�/i\�B\�\�dt\�\�\�[,�\r \�\�\�8HCd��̭�z��DE�:���\�(J�pE�w\Zu>l>>�\�2|�\�&M>g]\�&?ԌR��\�(�P\�\�\�\�\�t\'\�)\�?L�/3�x&J��Ĩ%3(`��\�b�IS�\�(%�\�!��R\�SG!\���\Z\�St\�&�\�\�\�\�\�Ț��:��z\0�Ff��;�&����\�]��\�\�\�\�Wƣʐ\r+?\�n�c0^f1gë\�\�ׁj\�=����\�\��Ґ���!���.63$�y�.�\�\��fތ)\�\\Kz\�ͽ�����Q(\�8��\�^�\�s۔��\�\�(���Ķ\n5\�\�\�\�\�\���\�O�����l�.(��W0!y���f��\�f�8I\��3�\�Ջ8f[H�B� v@��Al�(�U\"\�WȃO3�Ϭ\�i�`��\�\�*���\�SZq�\��KM\�\'I��T��O\Z�k�\�Oy\�\�6�\�\�:�t9d�Ň��ɛn \�\�\��wB	���҄��`�q0ʋ�\0Sɲ��~biӼj��r���=�I�D���~� ��o\��\�\0Ij|\�#���\�+Q\�r���\�D��U)\�sk�F锻ޞ�D롓^ͣA��\0{xeƣm��\�Ѱwi\�/�5�/�\�U\n\�n󃷙\�p��\�ރ\�5M.\�\��}�mk�\�\�\'M�\�\�\�3c\�Z�\�\�ݶ��\�{nl�2t�\�\�v�\�\�\�:o�;ϷUS�w0� p[>m1�\��%�F�{��3H}WS�iÊ\�\�Ԝ9&3V&�\�W�hfۯ�|\�o\�,�ifkȷl\�\�\��Fޜ���!�q��\�<B]vv\�:֔\���2���$�����\�)\�w��\�p9�z�zGQɘS�G�z\�K�\�ڟJ��w\�+��t�]���B+\\lޒD����xtK=���.�\�,���\�\�Bv\�c	�+t��(%�\�0\\B��9M��deQ\�\�m��I�1�@\��Y������W\�}��	 �w�\�l,	�箟K��:q��N\�=���%�h\�٨���k\�>W@H�@�j���`�0\�U{�Im\�������1T\0\0','6.1.3-40302');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(128) NOT NULL,
  `Name` varchar(256) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
INSERT INTO `aspnetroles` VALUES ('14e15ce3-0e4b-4811-b19b-0c221a5f1b4d','Employee'),('d357f022-8054-490d-90bc-38598281a07e','Employer'),('e1ebd389-2611-4a58-8a45-5311e736b038','Admin');
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(128) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`),
  KEY `UserId` (`UserId`),
  CONSTRAINT `ApplicationUser_Claims` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `UserId` varchar(128) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`,`UserId`),
  KEY `ApplicationUser_Logins` (`UserId`),
  CONSTRAINT `ApplicationUser_Logins` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(128) NOT NULL,
  `RoleId` varchar(128) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IdentityRole_Users` (`RoleId`),
  CONSTRAINT `ApplicationUser_Roles` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `IdentityRole_Users` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
INSERT INTO `aspnetuserroles` VALUES ('4f803a93-feea-4ac1-b12e-12a4d87906f9','d357f022-8054-490d-90bc-38598281a07e'),('65b79f76-87a1-4079-bddf-571d52ec5826','d357f022-8054-490d-90bc-38598281a07e'),('d7cee69f-c1d5-4571-a008-12e8a09ca5a4','e1ebd389-2611-4a58-8a45-5311e736b038');
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(128) NOT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEndDateUtc` datetime DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `UserName` varchar(256) NOT NULL,
  `FirstName` varchar(265) NOT NULL,
  `LastName` varchar(265) DEFAULT NULL,
  `Address` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('0cd10275-3fd4-4b07-aa35-1a1b8139bf5e','akshaya.dash@kare4u.in',0,'AInAB9kAOVUx+zNHI/mY7xB5LyWwPBDgr6HX6tdA3BOVXbq3tAEpQCqQtZpKA1NOSQ==','ca9c77fe-e86a-4365-9852-8e6b576dcac4',NULL,0,0,NULL,1,0,'akshaya.dash@kare4u.in','',NULL,NULL),('4f803a93-feea-4ac1-b12e-12a4d87906f9','siddharth.ray@gmail.com',0,'AL9X3npH5BHwVBmhIqS0lApSF5Iwa13jK3pYK7FOiIe2w088Hu/vKbWekBUw4+55ug==','841922f7-66cf-4e79-be9b-d960eacfa1c9',NULL,0,0,NULL,1,0,'siddharth','',NULL,NULL),('65b79f76-87a1-4079-bddf-571d52ec5826','bhairab.meher@gmail.com',0,'AAXT6ppzwfzqvBqIKXrhtA5F/XYYUXrD3q/gbIvX0oHJS+Ya0zDZZyVH8HSdLwFcWA==','1bbdc065-c911-4c10-9910-1f58c12dbc22','9999999999',0,0,NULL,1,0,'bhairab.meher@gmail.com','Bhairab Charan','Meher','Patia, BBSR'),('913bcd54-d444-4b7a-b1ba-47093179bb0f','akshayakdash.dash@gmail.com',0,'AKPheMTzOaJrhcpNPd17G+7gyPYSArK19ZmOCp1fPDklBAyJNZt/wyqlPo32OEOhjg==','fe2fc146-a9ad-4c8f-9ad9-d657bf47622a',NULL,0,0,NULL,1,0,'akshayakdash.dash@gmail.com','',NULL,NULL),('d7cee69f-c1d5-4571-a008-12e8a09ca5a4','akshayakdash@gmail.com',0,'APysTynXT3tgqZuIaDAc0qKb9auG+IZ2zjjGPeeAJbLKLUVUeIseIf0zyqQW4Tv7wg==','1ddae73f-5487-4151-9d9b-568c7c1a52b8',NULL,0,0,NULL,0,0,'akshayakdash@gmail.com','',NULL,NULL);
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusersecurityquestionanswers`
--

DROP TABLE IF EXISTS `aspnetusersecurityquestionanswers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusersecurityquestionanswers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `aspnetuserId` int(11) NOT NULL,
  `securityquestion` longtext NOT NULL,
  `securityanswer` longtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusersecurityquestionanswers`
--

LOCK TABLES `aspnetusersecurityquestionanswers` WRITE;
/*!40000 ALTER TABLE `aspnetusersecurityquestionanswers` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusersecurityquestionanswers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-10-20 17:21:01
