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
INSERT INTO `__migrationhistory` VALUES ('201810161349264_InitialCreate','HireMe.Models.ApplicationDbContext','ã\0\0\0\0\0\0\›\\\€n\„6}/\–ÙX§V.\›\Ì6∞[§N\“\›\\∞\Œ}[\–\Ì+ë™D•	ä~Y˙I˝Öíu\·M7+∂S,∞∞\»\·ô\·pHá\√¸˚˜?\”û\¬¿zÑq\‚c4≥è&á∂ëã=≠gvJV_ø≥¯˛\À/¶^¯d˝Z–ù0:\⁄%3˚Åê\Ë\‘q˜Ü ôÑæ\„Ø\»\ƒ≈°<\Ï~\Á9êB\ÿÀ≤¶RD¸fÙséë#íÇ\‡\Z{0Hx9≠Yd®\÷\ra\Œ\Ïü˝^\√INh[gÅ®¨l Ñ	 T\ƒ”è	\\ê£ı\"¢ ∏é •[Å Å\\Ù”äºk/èY/ú™a\Â¶	¡aO¿£ÆGn>Hπv©6™∏™`Ú\Ãzù)of_y0+˙Ä™\0ô\·\È<àÒÃæ.Yú%\—\r$ì¢\·$áºå)\‹8˛<©#Xù\€îft<9dˇ¨y\Zê4Ü3SÉ\‡¿∫KóÅ\Ô˛ü\ÔÒgàf\'G\À\’…ª7oÅwÚˆxÚ¶\ﬁS\⁄WJ\'–¢ªG0¶≤¡U\Ÿ\€r\ƒvé‹∞lVkìkÖ\⁄ù∂u\rû\ﬁC¥&tÆø≥≠Kˇ	zE	7Æè»ßà6\"qJ?o\“ \0\À\0ñıN#Oˆ\◊\„7oG\·z˝u6Ù:qb:Ø>¿ ´M¸(ü^\¬x\‚dó1Ÿ∑h_y\ÌßNcóuI\ÓAºÜDîn\ÍT\∆\€…§\‘¯f]†\Óøi3IUÛ÷í≤\rô	ãmœÜBﬁó\Â\€\Ÿ\‚Œ¢à^fZL#M\'\ÏS©·ÅïWWs\‘\’`\Ì\»ˇy˝ªÅå∞\0v\‡B›éïá∞\ÏÂèòö@ΩeæIB\Áø˜3H\ZDß?G}\›4¶fπ  å^ú\€\›F&\ró\Ã⁄∑\«k¥°πˇ_ó\‡¯±V\„Ω\«\Ógúí\‰ù?∑\0dü˜~\ÿ`q\Œ\\&\…%5f\Ë\Õ1ı™¿+DNé{√±µi\◊\»<\0~®˜@§UÙSAZy!z\n\≈1êÈºë&Q\ﬂ„µè∫âZêöE\Õ)ZE\Âd}Ee`\›$\ÂîfA3ÇV9s™\—¸ªlÑ\∆w2\ÿ˝˜6€ºMkAMç∫B¬ü Ç1]∆º;@åQ5]÷ç]8\Ÿ1¶/æ7eú~A:6´A≥![∆ü\r\Ï˛œÜLLZ¸\Ë{\Ã+\Èp\Ï)à)|\'z˝â™}\ŒIím{:\›\‹6Û\Ì¨¶\Èrñ$\ÿı≥Y†	xÒpÖ(?ı\·¨ˆ\ÿE\ﬁ9˛A;F\r\›g[-°}≥e£∫E\Á0ÄZgnúÉ\ƒû™F\⁄!Øá`≈é™¨äÉà\¬}•§ñc\÷∞CPBg™èà:-|\‰˙Zµ$µÏ∏Ö±æó<\‰ösA\ƒ∂j¢s}ÿÉ	PÚë•MCSßfqÕÜhZMc\ﬁ\Ê\¬V\„ÆD#∂bì-æ≥¡.πˇˆ\"ÜŸ¨±-g≥J∫`\·\Ì\¬@˘Y•´\»ó}3P\È\ƒd0P\ÓRm\≈@Eç\Ì¿@Eïº:Õè®]\«_:Ø\Óõyä\Â\Ìo\Îç\Í⁄Åm\n˙\ÿ3\”\Ã}O⁄Ü\–0V\ÕÛ|\…*\·\—Œ®ú¸|ñpWW6æÄD\ŸT˛Æ\÷uöAd#j¨≠î_˛)@ Ñ\Í!\\\Àkîé{=`ã∏[#,_˚%ÿö\r®\ÿıK\–\Z°˘™T6\ŒNßè≤g•5(F\ﬁ\È∞P\√\—Ñºxâ\Ô†S\\VUL_∏è7\\\ÎåµxÆ%ù]KÖi∂kI\Áêıq\…6“í\‰>¥Ttft-qmWí\∆)\Ë\·l§\"qi≤ëér∑)\Î¶Nû\≈¶é!jz\r¢\»G\ÎZ>/±y2\’¸\ÎEˇT£0\«p\‹DìqTJ[r\"8k(\’R\÷T\“K?N\»9 `	Xúg\ÓÖ\nôvo5,ˇ\À˙ˆ©b±\‘\Ïw\ﬁBº≤∂Y\’\·\Õ/i\ÁB\Ê\Ãdt\Õ\–\Îõ[,µ\r \÷\Ì\Á8HCdˆ≠Ã≠Û´ªz˚ºDEò:í¸ä\Ô§(JÒpE≠w\Zu>l>>•\◊2|å\Ã&M>g]\◊&?‘åRÑ•\Í(¶P\’\Œ\∆\Ã\‰æt\'\Ÿ)\Ï?L≠/3õx&JÄıƒ®%3(`µ∫\Ó®bæIS¨\Èé(%ï\‘!•™R\÷SG!\ÎÉ\Z\’St\Á†&ã\‘\—\’\⁄\Ó»ö¥ë:¥¶z\0∂FfπÆ;™&≥§¨©\Óé]•ô\»\Î\Á\ÔW∆£ ê\r+?\»n∂c0^f1g√´\›\◊◊Åj\≈=±¯çº\∆\À˜“êåßπ!Üîá.63$ÜyΩ.π\≈\Â¶Òfﬁå)\‹\\Kz\”ÕΩØüπæ®Q(\Á8ô§\‰^û\Á§s€îü°\⁄\«(á™úƒ∂\n5\Œ\Ï\Î\Á\≈\Ô¡Ñ\’O≤üÛ¿álı.(ÆÚW0!y∫Ü˝fÚ≠Ù\»fº8I\‚ö3®\È’ã8f[HºBè v@¨¶Al(§U\"\ÃW»ÉO3˚œ¨\’i¨`ø≤\‚\Î*˘à¸\ﬂSZqß\–˙KM\Î\'Iæ˘TµßO\Z∫kı\Í∑Oy\”\Î6¶\Ê\‘:ît9dÑ≈áΩ§…õn \Õ\‡\ÁØwB	Ø¥®“Ñ˛®`âq0 ãÇ\0S…≤´•~bi”ºj•ôr˝Å˝=˙I≤Dˇª∫~˛ ˆ∞o\Áı\œ\0Ij|\‡#≤ÒÄ\Ó+Q\—ráªç\ÊD¥çU)\”skıFÈîªﬁûîDÎ°ì^Õ£ÓÜ¥AöÙ\0{xe∆£mãö\‚—∞wi\–/û5º/â\¬U\n\«nÛÉ∑ô\‹pÙø\ ﬁÉ\‹5M.\Œ\ÓÛ}∑mk¶\ÿ\Ìû\'Mˆ\À\Í\›3c\„Zª\œ\››∂±ô\‚ª{nlΩ2t˜\Ã\÷vµ\Ó\ÿ\“:o°;œ∑USáw0∫ p[>m1ß\«¸%¶Fê{î˘3H}WSÚi√ä\ƒ\Ã‘ú9&3V&é\¬W°hf€ØØ|\√o\Ï,ßifk»∑l\‚\Õ\◊ˇFﬁú¶ô∑!ãqô¿\⁄<B]vv\À:÷î\ÓÙö2Öû¥$ö∑˘¨ç\ÍØ)\—w•≥\«p9¸zÚzGQ…òSßGØz\œK˜\Œ⁄üJ§˚w\‚Ø+ˆátÖ]≥§πB+\\lﬁíDâ°πÜxtK=ãâø.°\’,≤úΩ\„\ŒBv\Ïäc	Ω+tõí(%¥\À0\\B¿ã9M¸≥deQ\Ê\Èmî˝Ií1∫@\≈ÙYÄ˛˝ò˙ÅW\ }©â	 òw¡\„∏l,	ãÁÆüK§å:qıïN\—=£ÄÇ%∑h\·Ÿ®˘Ωák\‡>W@H˚@àjüû˚`É0\·U{˙Im\ÿüæˇ˚¸¸1T\0\0','6.1.3-40302');
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
