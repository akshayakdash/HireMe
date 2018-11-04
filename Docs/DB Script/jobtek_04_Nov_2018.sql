CREATE DATABASE  IF NOT EXISTS `jobtek` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `jobtek`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: jobtek
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
INSERT INTO `__migrationhistory` VALUES ('201810312003598_initial','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\å][o\ã¸~/\Ðÿ \è±\ÈÚ¹\ìL§½‹Œ“tƒ\ÆI:N}h‰v„\Ñ\Å+Q™E\Ù>\ìO\ê_(©+¯%K¶<\Å‹˜\"?’\çòœù\ï\ïL~~ó\\\ã†‘øSódtl\ZÐ·\Ûñ\×S3F«>™?ÿô\ç?M®l\ï\Íø5¯wF\ê\á–~45_ÚœÇ‘õ=<\Ç\nƒ(X¡‘xc`\ã\Ó\ãã¿ON\Æ“01-Ã˜|‰}\äx0ù\Îß‚w\ØÐ²rüe‘P5\î€£\r°\à\Ôü\Å	\áŽÒŠ¦q\á:\03±€\î\Ê4€\ï \Ì\âùS(üõbƒ€ûø¾¸\Þ\n¸\ÌX?/«\ëŽ\âø”Œb\\6\ÌIYq„¯!Á“³L,c¾y+áš…Ø°à®°€\Ñ;u\"¼©ycÃ¤\èK\àbðž\ÏÜTžšó¢‹‹hs\Ñ(o8JI^‡˜Ü· ü:¢)\Ú\íŽ\nŽŽ\ÉG\Æ,vQÂ©c÷\Èxˆ—®cý¾?_¡?=;Y®\Î>}øì³?Â³ôHñXq=¦\0=„Á†˜7¸*\Æo\Zc¶Ý˜oX4£Ú¤RÁX\Â+\Â4\æ\à\íúkô‚\×\Ê\é\'Ó¸vÞ —d\àzò¼€p#\Æø\ç]\ìº`\é\Â\âû¸²OòÿŠ^O?|\ì¤\×;ðê¬“©\çú\Ç\'\Ä\ë\êt“¯Ñ‹³I—3\ß\ÏYµ\ë0ð\Èo_\é\×\çE‡L ¬ò\Â5D,w“q	^-HR\Ý\Ã:§:|hNExK«’µY	y»^\r9¿ýö«¸´\âý3†QºO«\ÇT#¾å‘‘~/!s¢¥\rLx\Ú\à@F#î\ÎN%r¦D³@Aÿ}\í€ýr\×a¡º\røO-4Twt\áG\ß`2‹EWdÿ{\0x§¥Ý \éb³ÁóšÈ†¬/}0q\r÷€¥C9M¯0B5Gj7 ¹;\ê\èÂ¶CE½÷ƒ®>8\ÖS\èö?*9¯ð	/‘¢¯K¼K<:^m\Ó+8U\êªL\Z½`Ce\å„,ü9Àð\ãòD\Ö\ì_@ôÒ»lóM{€·\é7/\ïboIv´\Ýõ\Õ\Ù\Ô<~®…ª+Ÿ´Úš\Þm`}\rbt\å\Û\ÐO\ÈjŠ\ï‚@\'\ì\\X\Þ=®1˜¡=°^w€W“#\çÏ¾M–™On³p\'\ås^µ´[\ä5\ÛEQMf¿T±z¬_Õ¼ªšÕ´F-«Yµ¦¬bzœf5ÕŒ&jùLkuf&3Ô½I˜¾M¸‚Ö¿2¿/ƒ2™>Fµ\ï\ëlJzú¸q\×]µZ\r\É&\ÐýjH\È5$l\â\âW\Ç&Z‰†£$¯Œ\ÉkÕ—û`\ê\×\ÇÙ®—3\Ì]w¾›= ­9Î»:R¯@k#]N\î\àL÷þO†t\éz¦‘¾?K\Çu\ÔýÙ¢\Ô\ÒR½¾&G\â³@I©\Ï\é¨\Ó÷4©4U[Emk‰ˆ¤šŠ„/n)L3%9ö¨]Žòb\ÞD\×.X—·¢º;[Ab\Û\ÝƒŸ=\î;^$ô¢cgz‰yŸ\çð\r;Ñª¦æ±€\n¦\î\ìZ_?oEý“\êú\Äp¬¯ûY‹\Ó\ê¹—#«}V]#Zˆf\èGqÓ¹¢/¢(°œdB$W¹\ÙE\Û\í•oõ·r¥g›½ž\ã©s,q	\Z¤\Üû—x$\Z\ÄgG®ºg ²€-nZx8v\ÆrPK+oøX\æþ\"ô‰\Ï9’F€8\ë\"Œ=\ÇG\â¡\èø–³n­”¸–š*{\Ñÿ\ån O:¬•„N\çò=\Â@\Ñ7)ušŒ)\ÄUQ\á]Q\Íy«¥œw\á,\Ú	&k|<\n\\f~†^€Y-±€³Z$:(/§÷\ÐÌ§¦\0\ÞÁ64€rž=@3\Ó\'\0e%¶€²\"98€¦®T\Ýù\çüªCƒ\'\ë\Ð\Ýý±^)®=`“‘Ç¡AS\Ój\Ô\ÄFSR	m•—¦P\Ûr&AuÍ¢;D¤\\7\ãx÷¸o6\×:ü±.¢¯Áƒ°\Õî„½¯¥‹‚bMô§ôx,õ¸²TcÕný#¼–š\n7\Ý1\ÜùŠK}Y¸\r\Â-\n\n5\Ü\Ë%ù˜¸ƒ¿EæºŠ2*nB|{\Õ]úÏ¤~a…°Dx¥¦Š`©ø\Ô\å¥/#*.«\Z¢\Ù\Ûmp€5qþ°¢rÈ™©Ü€lþ¢’lf\àhŒZ¾>4d¡\ÚF¹>)0‹\ã¡\ß\ÍSÕ¯\ëùU¦\å\Ö+†]ÀZX­Z^8ŠŽ\Ùüö\Ë\\C(ª‡9¢`tœLM\ÜL\ÔÀ²É¨PKH!¤|0K)_õR’y:šø:¶’\ç—PH)L\çR\Ê0Z/$‰µ\ÝÀ\Þ\ÞJD¬m¼\ÛÅ¦{X+À66a‡V!7\Ê\Í]Z\Z\Zu\èmª\Ä#¿\í\\U[(]\Ú(;›-¥)Bq Ñ«´§.¿h-”\Ó\â\ÛdœÆ«f“±\"°u2›ã¯©@×¬\ÄX¤Q®³\Íc@½”\Æ\Øbö4^•.zBAÖûŠ»Æœ&a—\0% \Ã3\ÛªIUq…–wIk\Û\â,\ç\ZX^›ü¶`¯Ÿ­\\4a²\æ\×xp1”’\ç(’\rV\Þ\Ü 1\ÇÀ¡\ä\Ì,pc\ÏW»HÔ­\Ó\Òtû´D¤0sü¦– (Áf¥®5\'â©³ýüFNû9R“PI:w\nÑ²V9Š\ÔTò[UšŠ\ê¦uos&\îa\í\ç¬\îÐ˜³z*i\Ë\\´\äu\\j\ê\åI\ÓT\ËU”\è¸@š]>t¨LH]D\Ô(q\Z€¨¥\Ð\Ï^K…ü\ÑD¨b}ZePMª,m€<jN^¨O‡‹Ê£©qŸ\ZðF\Ç\Þ1ü\Ñô\éey4¥¬¨!\r*¦K F}k =&\ìŽóEŸ\"[\'Û¶²O\r¸¤#\è&\é­\è)$*¯¡ßƒ3GS¿6Xbô³\Å\Ï-hKx\æ¿5YMB€»¦„\Ïú´\É>*\îGe\é`N‰7¬…2u!o§Q*hôsu£RaK4!ª¸!­,0I –•HJŸf ¥—\ÛIAC½\ß0±>\ìvS ¤¦\ÉðpÚ€:€IM¯\\÷¨ÛªüGi¼Š+Ÿ­õ`]ºýlG\ì\Ó	\æ`ª|T¡¦Ø¯õ–_´‰ö\Ö\Îñ(øýø*E\ï…ÿóóM2Ÿ[}–;Á	—V1|YO\Íùû\â7wD¾’?g®‰6‘×˜\ßYa‘§ñ\æ‡\Ñ_¹ly\Ã\É\\7Ž\"Û•ø,U\é\ë\Ø9\ÛAÔ›ÿ\nB\ë„b\Ú\Ù\ÝJ¢\Â†ß†oSó\ßI«ó\ÄûMþJŠŒ›\è\Éw~‹ñ‡\Ç0†\Æ\Äl\ÝDV{\áš›L_ª7ÿzN›÷!^0\ç\Æ1\'\Ë63\Ìf,k\ÄM\Útn\Ú\ç1k1³ý¦s\ÈVVI\Úpnøbn€%›<!*	µK–°\ÛOV°\Ã\Ý\ì„\ä[m\å\Í\ç\Öj=olê¬¶d¤™±Zó$&¾²1\ÚQ’\è!„–“¦\Ü=nJ˜I‹%S\î¨hŸkn\')°\Ú\nQš\áªõôŠ	¬: Õ\ÐTÉ©ZSf¦\ê€ò¼U­8U&­ª\ßw\åúB;=,o¹G=L\â»\ÚÅ™\Ð\Ëq<,\ÅM\È\ÔvÑ‹‰ô(m‘×§,%NgJ‰$\ãMg´÷	\èŽ\Ó\Ü|;Œ,—L£i¡	\èN\Îvyg9hp&R`ù\Û*q\ÍvVg+†’¤¢\×\ØonŠ]¦£¨x½õ]e¡@Ü´$Dfÿ¹&v5\Õ\Åî°£¢f”Ø²À©ý\ç\Ø5\ØT—¿[£\ì\ÃÚ¾\Î\Ï=#MûÐº\Íõ°u’„† }„\Ã\nôÚ¾aøÈ± M\í+7Á¡Z#J`/³u\ÅCF$Ÿžœ¥.5–\Ó\Ç#S\Ó^K©9Ÿ®oy„©ª³ò¨VvXVQwªm\å;W¥Ð±XE\Öq}¼ßµpP	=5ªG\ÜLÌ™¥W)\ç¬Nu·ŠXôª¾3Å¿²\ï¬NußŠ\ï\ZQ«¶´º	Pµ“ò¨\ÓT\ä|ù¤\Ñ\á²\ä!5ª·\â\r«4\rÉó90#©IYR\çf©| ~H\é:\n³\î\'[C\'\"\Ù\Ã\Òlv†\Öm´¿7x2ý]g[P©>òX\Ûa‹¿A\Æñ…4Vµ©-\Û‘³.I;Ü‡£dunüU\ëýGy\î\Zl°±~\"g,„?“—\'É¿\â%m¿ò–Ð¾ñ\ïc´‰2ô–.s!Nl†ªþ“´,Ï“ûM¢•v1Ì¦Cð\ÜûŸcÇµ¾¯%w\Æ\n\Ä\Éna\É\\\"r»~/(\Ý¾&¡L|…\rõ½‹‰E÷þ¼\Â6¼a@\Þ\Â5°\Þ\Ë*\"õÁŠ}r\é€u¼(£Q¶\Ç?1†m\ï\í§ÿ””·4\0\0','6.1.3-40302'),('201811011814230_job_category_added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\Ý]\ÛrÜ¸}OUþ\ÅÇ”vF²ÖŽ\ãš\Ù-­d\íÊ±l\Å#m\åM‘Ðˆe^fIŽ,U*_–‡|R~!\0¯¸’\0x•K/\Zh4\Z·n ûÿù\ï\ê\ç§À·aœxQ¸¶‡¶C\'r½p»¶÷\éýo\íŸúóŸV\ï\Ý\à\Éú½\ÌwŒó¡’a²¶\Òt÷n¹Lœ€dxN%\Ñ}ºp¢`	\Ühù\êððoË££%D$lDË²V_öa\ê0û~žF¡w\éø—‘ý¤øŽR6U\ë`²\\Û¿y1¼„‹<£mø@Ll o[ £¤ˆ\Åw7	Ü¤qn7;ôø\×\Ï;ˆò\Ý?\ë\ï\êìª­8|…[±¬–¤œ}’F&Á£\ãB,K¶¸‘p\íJlHpï‘€\Óg\Ü\êLxkûCtw\nR¸\âg\Ûb\ë{w\ê\Ç8/#\ÞQ\èÀÊ“* °\à¿\ët\ï§û®C¸Oc\àXWû;\ßsþŸ¯£¯0\\‡{\ß\'™C\ì¡4\êútG;§\Ï_\à=\Ïò…k[KšÄ’¥QQ\Ï\Ûw¦Ç¯l\ëb	\Üù°B!‹M\Z\ÅðW\Â•v¯@š\Âu\è…3™rŒ0Õ–u\â_e­Šh@\Ù\Ö%xú\Ãmú°¶Ñ¿¶u\î=A·üRprzhü¡Bi¼‡m•ÁÄ‰½]Ž™\ëBòü5Žö»a\Zö	<zÛ¬øj\Ñ8ÿý,1yðvùp\'Áy›g:£\àK\ä\Ó}Ÿ¥\Ýn¢}\ì`¶#I†koaJ³µZ\ÖÃ¨mpi\rªi“\á \Zsð \êF7ZsC+)<\ngùÂ‰Â‹\0lG{\× ù*·uj\ìU\ßE\ã®N\ì:\æ0­q‡L3öpÍ†\ã¯,:\â\ìaL`®\Ç\ZÊ¸®1WB\\\ß:¸®Qšˆ\ëp\é\Ôvb\àzª\Úðˆ\'¾j¢¢ù;ð÷°G\ÂYÉ“G\àe…>gýŸ.\"T+\ZK²±©9»žF\è4?_‚JÎ´EŽ\"žñ¶šÿê™·)_5Ù–3qc\ær\ÚVm\Êfß¼P\äD÷\ÂÅ‚J-t†N‹†¨\Ñ\ê+ˆ¨ôË‰\É:2ò¢¶fµ¤rik“io\Ã\r1»J\ã\Ñ\ÇeW\àzšð{Y)N’\Ý\'˜.Ê‚‹œ\ä9š=\á·(þº )X\Ê\åjØ¿R…ýñ\Ñ\Ýýñ\Û\×o€{ü\æGxüzü! XŽ^½UZ41Ü²`¿zý¦—Z¥¿IP\ïOö÷m‘­†9ŸÊ[¥HcRýÃº¤:hcNyx³\â™Œ„²Š±GC\É\ï°õ*#m\á÷1úô=Lòsƒ\êF€-9Á&€eÁ\"\Zcmj¡¼W?	“o06>r(£\éd·Cýš\É/u01_Ü†r¼ù\ãÜ‹“t”3ðG0RE\'®\Ãd„k\Ý{>¼òœ›\Ø¾UN\ê=\Â4Dªº\Î\Ð,q\í­E\ßÀkbPuË¤P\Ëi\Þ{q\0+$ÿ¡\n„Jˆ$A;÷7<.\Ûr\ÒÞ¤ \Ø\r›‡(„ŸöÁž\ÑÆ««·®¹þ-U\ïC\\ª3½‘ó5Ú§\ïCú&utñ]è…\ÇA³\Ç93t³\Óf·#7^¦>²œúÀ\Ägf¥¼-³\Ö\çq\î\ì\"\É&:¿4±ú1\Úz¡\Z«eV9«yŽVV‹lº¬bbjœ9\åŒfZù\Ìs\é²\É\îHóÍ›\ãâ¢·Ü¶L\Ú05œÕŒŠHÁjtTÎ \ÛÿY9#;ÿ\Ãò\ÜU¡S´³\î£\Î<C-\ÚYM™U§çªŒFC6;ö?\Z2²ó\r›\èó£\ç\â™NAƒTfF\ä•ò‹•S\ícŽ\ál\ì\á@5s\ì\ÊÇ™Lõ\âõ\ÊX{!&÷\ât\ZÃ¯ù\Ò6\ÔÎŒ\êŠ>Úˆ‘¸]\Ü|öƒ-a\Í]¥\éF¹ƒDxRº\"a?Ê„#£gO\Ú\Ä,G¨w/’sl\ë\Ëßª3[E¢\ë\ì…@\Öÿ\rr\Ð\Ñ=}	±Þ£\ÔZÀ\'\Ô\ìlWµ¶9TPyO óõ—\è©\ÊÔœ+*®<\ç+\Æ~Q‚¿³B•(\Õ?E\î\ã\æ\Üy\ÐII†~\ä{0\ï+ò\ãI’DŽ—uH\Ã]\Ê$O3ð>t-û|m_¹D\Ý\êa\È\" ­\í¿p\rV¬¯:*\ÖõUW\n\è*ŽlvEûž!A¦\Ð:qò§ q€\ËÏ™Hš.ý-‚\ßOò\0Vq&˜^˜ò+¦:\Þø\Z\rah\è\ÝuÄ¬V•²)gpC¼rjtcgnªJ¶\Éoµ$ÀÚŒa\î\ê“Gò{P­\Ø9\\,ø!\ß@Y•<ð %k\Ûxp’\É@…\î®\ßT@ª/[7tµ\à\æ5\ÕÍƒN<N¦\0\'E°u\Z\×\îN5-úMC§J\ÕP[?3j\â—<\ÍÀ\ïjB™(vºü}›.\ì„2è…‹ (¸Œ&\ëî¦›iu‡\Ó÷#GÁa\Ã}8cõ-·A`)—’\n$:¢Q.	•\ÊÅ—\ÚF¢\Ä\Â(\ëó6sc\Ý\ïœ\ÚaL¶\Ø9%¸,LJƒ\0³Yb#€³Y$*H/hN\ÐÂ®¬\n\0\Ö\È<7€2\Öm	@+\Ï(\0¥%6@i‘¼8€\æ\×	TûŸ¹[07xÒ—\Z\Æ_\Ö\Å56)y¼4h*\Z±¡k-B[fS\×Iv¼×¢<è„Š§>p­\Çñø¸\×\ëkþhk\àŒGg,\êB¹\åhòñ!µF¬ñ¦³¹©õ»µUº\íQj2\Üô\Çp\ï#.7[¢2)*QYËˆ\æž\Ý\á\Ä\ÌòÇ™(‘(\n+eR˜\ÎYpc\â˜rJ_\æ¬M¦\"57P8Z*E‹ß¢\â¹¸…„\È$¢\'6\äµ/\îºr\ÄhõQv\ï\×D°\Þ¶eA*\"\Ê\Ï>-D‹gž!n\×hqy»±É…FAƒly_º‘lqThµô^q›,d«\rS\'1æ›¡[¿)\'Š¨¼Ag\'(M“w%\éˆ\â¦@M#7QC=\ì\ÙE–“‚y\ß¼Üš¬¬±@lfUà¾™\Ð\àb |-	E 1\Ê\Írâ¦·6›·\ë\r\ÖdÆ½›°\Ù\r¦+5\ã\Í=¹j6\ËAltj¦DõyI´YPTm(ÿ\ÅZ\Ö …“AG°>vŠ\ì%/¾ŽNŸhX\Ñ\rjÑ¿K„T6¦w)•‹j»”Dje\År\')1J`‰”\Ê\Æô.¥£\íB¨65”›DD+\"\Çlªk[h¢€\ëQ\Çt€t‹¨\Þ-šš¶6\ÖUüÁÁ´¯š\ÕA}*„F\ë-©Þ‡\à@p:S\îºòs¥	¨\ÒV\Ë\Ü\Ýuñaµ”ø\Å^\á¸n	?\Ù\Åk“;\É>ýa£\ïB:\Èi,jNcõUMiƒ-dRñYÁ…™Ÿ†3‚;€/\\Ÿº—M¨÷œ\ã\Ê*Eª\r¾·\Ëó\\Y\nÿŸ—”ú¶¨Š\Òç¨VNe¯=„[EAi;.>ˆ›½ÎžFþ>•n\á\Èi\Ò\î¦I’tŠ:EÊ“&IJP§÷ò\Í4šH\á)®–L7pZ:®»9%*!U„u– ´€$\0p>”®–*ºp\ÔJŸ\Êµü£:\Âg2I‰ø<\'\Ð\ÉN\ï\ZÀ©Š\ÔÀ\'.\Ù\ÐA\åuh¦‹d·¤iõ\æ\Úá°€#PsN…d\rgD\Î0IšKÔ£+™j™$=š\Äc*–&‘d@“ð,$L¤«S—¸&+dÑªƒ~ÀPo~10\Ù$#Výš\Ï8B£‹þô£FF:\É3\â7š9z™\Éµ\ÔF¬þ<$\Ètª=OY\Èô{¼¹ø0=\ÍOŠ3\Ûwòº›\îýS\ÍûHNB&\éò)k\Ù\Ý9•ò\"8IEv9|²>\ã5\æ}Ö¦LQ\è³v2i‹nE’W¹5!§^kšHš2\Ãu%Ò\'I‹ü>t\È1ªˆhQ…*\0¢•\Â0s-á©“$B|V§Uû\â$I\Õ_5°S:Û¤€S~\Ô\Øý\Ñ\Î4©½¤Á\é2“\âLP§Wø\Ñ$)Ÿ4i®9bDš\ÎÞ™ô–Ioœ\ÉuŠŒKLÑ´U$ipI:¾¤˜$Œ\èI$*Î¡qª\â\\]Rg*.UcòN/©¡\È\'\ÐðÌ¦\éŒ&\Î/&=¦¸du\Úx\å\ç£ú\ëlVM¹Ÿ\re~«ÛŽRBc˜å¨Ÿ\r)\áT:\ÞÕŸ5inó8b\Å÷YIz3ÀHù¾n@’Ð\Ï7”\':zºitŸ\'§I¹—cvr÷zrzzppo+³\Âö¶\ã•\\¿\ì¼V¥;\ÌtD¿ö ¦\Æw rŠÃž\Þ\ÊK¯üykt<r\Ös6KU{i,/W\Öó\Âr\Ýjš3e\çYl«\Ökûòyó‡¿À\é‹\ì\ßSßƒx7Q\æ¸¡wDž{³_/þÊ„¬žOø\èe’¸”§\Å\æ\Òt—M\Ï\Ù\Ã\ÒnuÅ¨\ë=W\ÂÙ\Âmþ8£&f¡Ù”\ÔA\0f5ZZŒ\Íz¶sp\áAzòO¸ƒ\ä%\Ð\ã^\ê\\„.|Z\Ûÿ\ÊJ¾³.þyK>°>\Çh^xgZÿ\î\ZjØ´5\\$\áþA$ð\Ñ7z¤Ü¡\0e„€\î=\Ï\Ô\í€eI¼\\SŠ’p¸]\È\Îsbb\\0Û¬\ßz‹`kB­1l­i[%QiUQ\Ê—\áµ\Ã\Ä\Ðn\çÃ·óPó‚™\Ô[\åm+µ”f±FG\ï­ð\Ä\Îˆy¯\ØBq\ÖD\Ûz7\Zÿ—}>°.’›\Ðûc®\Ñ0ÀÅ†\Æ\éW\æb\Û\ëLIªK\á>/Jƒ¾c\Ó\á%µ¸É‹v\à\Æ<\è¤A\Ïûqù‘\r÷hº\Æñ\Ñ{œ\é\Z¥/j²\ã\"%šÊ›\r„h\ÜotœC\ã-Ž(Œ¡1O|”B¡=Í¢¸]\Å\Ðñ2g\ï\Ø»a*†¡°O™¥\Â<d\á]ù½\Ä+4¢0¡q÷ò\Ñ{ Õ\Ðd‘ˆI\Ãö@qA#N¥MŽ=µ‘Tw.KN¸X,_\ìqe^7.Z™\é çƒ‘õ¬\Új1<~—aºzÛ”\\ñQ¸z£=% {½õ}\Ì0¢øVZ\ÝBP\íœn±°TU6<…Nº:˜V·	«§(:•“\"\Â1’$d\Ã@žW\Å\î¼v\Ì÷t‰_2qø›\ï2\ÞMñmrsz;µ‹	²*µ¾¬¸5\ÓÅ©Q…aÀ/D_Tü™\écÎŒ_fü˜2\ß{ü˜¹„Œ©½‚\nøØ¥|\ËCN•³†¬&ªÚ§F—Š9¹—¡D1xb•\àl\Ä\È/ccMöfA\Ãn:ÿø.3[\áŸW¶£¸Œ\r6Ù»†™ƒM+V\ËÌ°6\Õú91Ò”—\Ð9­\ß\È+C–hz\"8\ÅKž\éóž‘\ï/\â	\ïU“ÀÉ¨‘B^* `˜\\†šá³Š3Â»\åd!S<¹<õi	’¿ŠZ\Û\î]„”[,\Z=©‹*“‘W¢™kñDtó	m±{–¾\ØþÀU&\Î&ªY),ƒ4fF¾\Ãáª§“E\Õ\æó°\ØU´¬²zK%­°\Î\"¯Tî£š­˜Ÿ=¹Šù,¢Š\Û÷²Us\n®f.Gs‹õ\Ä\\œ\È\å\\\äi®V\âT¾©\î\â€\ÖXw‘§¹n‰«öQË–ž¶•ò¨R”\ç|\Êp/\Ì\ÄFù\ï\ä×—6‹*AD)‚\Ò\\\"¸h7Ÿ2¶—4FË JÃ†k\Ô@QX$‘WDœ´„3¿+\Â\0\r¢(`-\Ê\r•:±³$j\îBªP-\á\ÒEB-Œ\ï2ýe¸*½…Z±%žRú\ÊPSz\ÉCg¶RŒªµ3\Óð·2–\è\'	x\";´ˆu\Î[ü\ZAKx÷*«\å´³ô‚ü¦\â\ê&Þ¶&±B4\ÃüõxM´\Ìs\ÞG¥f…\á¨\Ì\ÂÜ¦¼„)pA\nN\âÔ»NŠ’ñ/\Ü\ÚVv3¿¤¹ƒ\îEøyŸ\îö)j2\î|jÛµ2Mõg‘YhžW\Å\î>š€\Øôð;\Ï\á/{\Ïw+¾\ÏW%$°º§¸Ì‹û2Å—z·\Ï¥OQ¨H¨_¥¥º†Á\ÎGÄ’\Ï\á<B\Þ ?\Â-pž\ë‹\æ2\"\íA‹}u\æm‚¤ Q—G?†\Ý\à\é§ÿWI-ö\Â\0\0','6.1.3-40302'),('201811011846067_job_group_name_added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\Ý]\ÛrÜ¸}OUþ\ÅÇ”vF²ÖŽ\ãš\Ù-­d\íÊ±l\Å#m\åM‘Ðˆe^fIŽ,U*_–‡|R~!\0¯¸’\0x•K/\Zh\0\Ý·n ûÿù\ï\ê\ç§À·aœxQ¸¶‡¶C\'r½p»¶÷\éýo\íŸúóŸV\ï\Ý\à\Éú½\ÌwŒó¡’a²¶\Òt÷n¹Lœ€dxN%\Ñ}ºp¢`	\Ühù\êððoË££%D$lDË²V_öa\ê0û~žF¡w\éø—‘ý¤øŽR6U\ë`²\\Û¿y1¼„‹<£mø@\Ø@ÿÞ¶@F)HQ\ß\Ý$p“\ÆQ¸\Ý\ì\Ð\à_?\ï \ÊwüMWgW\í\Å\á+Ü‹e]°$\å\ì“4\n4	lY²Å˜kWlCŒ{œ>\ã^g\Ì[\Û¢»S\Âm?\Û[ß»S?\Æyö.ˆBVžtP¡\0ÿX§{?\Ý\Çp\Â}\ZÿÀº\Ú\ßùžówø|}…\á:\Üû>\Ù8\Ô<”F}@Ÿ®\âh\ãôù¼\ç›|\á\ÚÖ’&±diT\Ä\Åóþ]„\éñ+\Ûú„š\î|X!‚\à\Å&bø+aŒJ»W MaŒz\áÂŒ§\\C˜j\Ë:ñ¯²VE4 l\ë<}„\á6}X\Û\è_\Û:÷ž [~)Zrzhü¡Bi¼‡m•ÁÄ‰½]Ž™¾\ëú½m\Æž³h\è}~–˜<x»|’x¹\Í3\ÇQð%òiqdi·›h;˜E‘$\Ã5ˆ·0¥›µZ\Ö\ÈnÃ»Î§Á·!®\Ç\Ä3ªn(k\r\×VR¿\Æ\Ñ~7F›ñ¼ž\'\n/°@\nMƒü\Z$_¥ý¶\Î@\rò\ê»h€×‰]7¦¢5Àqi9®\Ùp —EG\ì=>\Ü\ê±\æ\\× « S%®o\\\×(]\Äõe“\Ùhµ]¸žª6<â‰¯š€¨hþü=\ì‘pVò\äxY¡Ï™ü“ÁY„jEcI665g\×\Ó„\â\çK°C‰Â™¶\ÈQ\ä\Ï3\ÞVó_=ó6\å«&\Ûr&n\Ì\\NÛª]\Ù\ì›Šœ\è^¸XPi¢ƒ\Î\Ði\ÑuZ}•ž`91YGF^@\ÔÖ¬–CT\Îmm2m\ãm¸!\ÆbWi<\Z\á¸®§	¿—•²\à$\Ù}‚\é¢,¸\ÈIž£\Ù~‹\â¯’â¥\\®†ý+U\Ø\Ý\Ý¿}ý¸\Ço~„Ç¯\Ç‚u\á\è\Õ[¥uA\Ã-ö«\×oz©U\nù›IGxRÞ·E¶\Z\æ|*nA–^ Iõ\ë’\êü¡[\Ê\Ã[˜w\Èd$”UŒ=\Z\Êö[¯2\â\Ð~£Oÿ\Ø\Ã$?7¨nØ’l\Ø&˜\à@Dc¬MB\Íô÷\ê\'aò\r\Æ\ÆGe4\ìvH®oðøRSð\Åm(Ç›?Î½8IG9#Ut\âº1LF8±\ÆÑ½\ç\Ã+Ï¹‰ý\á{\å¤\Þ#¼AC¤ª\ë\Í\×^\ÐZô}\0¼¦ªn™j9\Â{/`…\ä_\"´@\Ð@	‘$h\Ç\àþ’‡Áy[NÚ›\Ãk·¯¢~\ÚwxF¯®\ÞDsý-:ZªÞ‡¸Tgz#\çk´Oß‡.ôM\ê\è\â»\"\ÐKsN\Í\ç\Ì\Ð\ÍN›ÝŽ\Üxý™ú\Èr\ê/ŸY˜•ò¶\ÌZŸ[\Ä9¸³‹$›\èü\Ò\ÔÔ\Ñ\ÖÕšZf•75\Ï\Ñ\Ú\Ô\"›nS11µ–9\å\r\Í2´¶3Ï¥\ÛLvGšoÞ”\Z..z\ËmË¤S#À\éQÍ¨ˆ¬FG\åºýŸ•3²ó?,\Ï]:\ÕI;u\æj\Ñ\ÎjÊ¬:=We4\Z²Ù±ÿÑ‘ÿhÈš‰>?z.ž\é4HefD^)¿X9\Õ>æ˜–=¨nŽ]ù8s€©žB¼^k/\Ä\ä^œNcø•!ŸAzÃ†Ú™Q]Ñ§¢Sñ\"·‹›\Ï~°e#¬¹«4\Ý(w\àOJ—%\ìgCžpdô\ìIû€˜\åõ\îEr\îƒm}ñ[uf«Ht½\è\Ñ\Ú\ã?£AB:ZÒ—\ë=J­|B\Ý\ÎvUkûC•÷ô:_‰žªüG\Íù±¢\â\Ês¾b\ì%ø;+T‰RýS\ä>nÎ”lÐ¼sY‘O’$r¼L \rw5*“<Ý€÷¡k\é\Ø\çk3€øB\È%«‡!‹€¶¶ÿ\ÂuX±¾\ê¨X\×W]) «8²\Ù\ísx†™B\ë\Ä\Éœ‚\Ä.?g\"nºô´B|?\ÉXÅ™ `zaÊ¯˜^\èx;\àkt„¡¡w\×7µª”M9ƒ;\â•SCŒ[SU\Ê0´«%\ÖfsWŸd8’ßƒj\Å\Î\ábÁù\Ê\ê¨\äo-Y\ßÆƒ“Œ*-\à\îúM¤ú²uƒ¨7¯)1:ñHZ2\à8>(‚­;Ð¸~wªyh\Ñv\Z„*y½C	¶~b6\Ô\ÄO†š\ßÔ„<Qºüm›.\ì„<\è¥#@PpM&î¦›iµÀ\éû‘£\à°\á>œ aõ-·A`)\ç’\n$:¢Q\Î	•\ÊÅ—\ÚF¢\Ä\Â(“y›¹±–;§v“-vN	.“\Ò Àl\æ\Ø\àlf‰J¤4§\0haWV\0kdž@\ë¶ …•g€\Ò›\0 4K^@ó\ëªòg\î\Ì\ržô¥†ñ—õFvM€MŠ/\ršŠEl\èZ¤Ð–\ä\Ôu’\ïµ(:¡\â©\\\ëµx|\Ü\ë\ÉZ¥}´5pÆ£ƒ3u¡\Ür4ùøZ£ˆ¦ñ¦³¹©õ»õUº\íQj2\Üô\×\à\ÞG\\n¶DeRT¢²–\Ý=»Ã‰™\å3Q\"VVÊ¤0³\à\Æ\Ä70\å”:¾\ÌY›LEj:n p´$$TŠ/¾E\Ås\rp	‘%HDOl\Èk!^\Üu\åˆ\Ñ\ê£\"\ìÞ¯‰`½?l!Ê‚TD”Ÿ}Zˆ\Ï<9B\Ü:¯\Ñ\ãòvc—‚\Ùò¾t#\Ù\â¨\Ðk\é½\â6^\ÈV¦Nb\Ì7C·~SNQyƒ\ÎNPš&\ïŠ)\Ò\ÅMšFn¢†zØ³‹\Z\Í\'ò¾#x¾5YYc\ØÌª\ÐúfBƒ³ðµ$d\Ä<(7Ë‰»\Þ\ÚmÞ®7X—?r\Ân7˜®ÔŒWt\ë\ÉU³™b£S3\rø z¨\Ïs¢Í‚¢jC!\Ú_¬e\r\\h0yt\ëcg¦\È^ñŒQ\Ñ\è\ë\èô‰Ž\Âh`P‹þ]Â¤²3½s©\\TÛ¹$R+\ë(–;q‰QK¸Tv¦w.mg’@µ©¡\Ü\ì\Ä\"Z9\î`S½X\Û\Ê@\\*8F\0\Ò-¢ºX45mmLTüÁÁTV\Í\ê >B£IKª÷!Z 8)‹®¼À\\iª´\Õ2wu]|X-%>±Wx\î…[\ÂGvñ\Å\Ú\ä²O\Øè»r\ZK‡š\ÓX½EUS\Z\Å`™T|Vpa\æ§\á¤\à\à×§nÀe\ê=$ç¸²J‘jƒ—vyž+K\áÿó’R¿\ÖµQQúõ1ÀÊ©ìµ‡p«((ma§\åÀq³{\Û\Ó\È\ß¡\Ò-9M\Ú\Õ4I’NQ§Hy\Ò$	R	<½Õ’a\Z§S\ã„Ã©<i‰«\â¡#\ÌÄ¯%v¸õ\Äü¡ôÀ\ÌP\Ñ\îüP¹Zf\È_µ(å¾”BùGu:„¯d’ñyNð•\Ú5 ,R©ÁX\\²A@\å5hFD²\ÛÑ´úµ£aA‹†\çLX@¶e&”Q\çü“¤¹D=º„`–*‘¤G“xD\Å\Ò$’h^€…„‰tu\êWÀd’,ZuÐ\ê\Í/&›d\Ä*_óGhlÑŸ~\Ô\ÈH\'y†ýF3G/3á©–Ú€ÕŸgƒ™\ÎBUò”eL_\â\ÍÅ‡‘4?)\Ê\æÂ‰d\Â\ëlºË§24š\ËHNB\Æ\éòþ\n\ÉkÙ9•ò8IEv)|2™ñ\Z\0s™µ)Qd\ÖNB\Æm\Ñm’ó*·%\ä\Ôk\rISf°n¢Dºñ$i‘\ßgƒ™F-*P@´Rf®%<t’Dˆ\Ï\ê´jœ$©ú«vJ\'›pÊ\Z»?Ú‰&µ÷£“4\ÚFºÊ¤\ÚG&¨\Ó+üg’”ŠOš4Œ1\"Mg\ïLzÉ¤7\ÎdŠ:E\Æ¦h\Ú*’4ZI:¼¤\ZI&Ñ“pTœC\ãTÅ¹¸¤\ÎT\\ª\Æ\ä]RC‘O6 -h3›¦3š8˜ô˜\â’\Õi\ãy”Ÿê¯³Y}¶\ä~6”ù5®n;J	a–£~6¤„3=\êxWÖ¤U¸\Ë\ãˆ\ßg	$\é\0 \å÷ºIBC>\ßP\è\è\é¦\Ñmžœ&\åVŽ\Ù\r\È\Ý\ê\É\é\éÁuÂ½­\Ìú\ÚÛŽWr\í²ó>X•\î0\ÓýÊƒZ˜\Z\ß\È){z+/»ò\ç­\Ññ\ÈY\Í\Ù,Uí¥‘¼ü]Y\Í‹u{xiÎ„g±­rX¯\í\Ë\ç\Íþ§/²O}\â\ÝD™\ã„\Þ=by\î\Ì~½ø+¦z>!£—I\âR›\ãF\Ó\"›,†³‡¹\Ý\ê‚Q\×k® l³…\ÛüQFM\Ì0*³\Z)­\è\Æf\Ò\èqx\î ƒ›2^\îU\ÍE\èÂ§µý¯¬\ä;\ëâŸ·T\á\ësŒ\Æò;\ë\Ðúw\çø\ÃºC†6%\ÃE\îŒ¿|£G\Ç\n˜FH\êŽ 6ˆnIb\äšR”„À\íBŽ‹pÛ…À6“[oQkM¨5†ª5\í«$­*J™\â2¼v˜\Úm¼cøsj^0\ãz+¿\Íâ£¶ƒ\Ò,¾\è\è\Ò\nA\ì<€˜÷„\Ý!üfM´MB¸\Óø¿\ìóu‘Ü„\Þ{”p†§_ž‹\í®3\r©\ÎU„û¼(\rúŽ¦CJjµ&/Ú¡5\æ&\r$;l¼\ÇA\æG6Ä£\é\Z\ÇGp\ìq¦k4”¾¨ÉŽ‹Žh\Êo6ø¡±\Ü\èØ†\Æ[Q\èB\ã6ñ‘	]„ö4‹\ÜvC\Ç\Ë¼c§\ëz„©¸…B™2K…y˜Â»(ò{‰Qh\ÊDaBcñò{ \Õ\Ód\ÑˆICö@q`A£–J£\nš{j©\î\Z]–œp&°V¾\Ø\ãÊ¼6n\\„2\ÓA\Ï \ëYµ\Õbtü.Csõ¶)¹\â#oõF{J@÷n\ëû˜aD1­´\ÄBPN·øWª*žB\'\Ý\r@«Û„\ÕS\äœ\Ê1\áI¦a o«b^DsÌ‚õt‰Y2qÈ›\ï2\ÆM1mrSz;µ‹	²Ÿ*µ¾¬X5\ÓÅ¦Q…aÀ/þŒD_TÌ™\é\ãÌŒSfü82\ß{Ì˜¹„‰©=\n\Ú3°ù–Gœ*g\r-X)<JTµO.¯qr\ÏB3ˆ\\ ð¾*ÁÙˆ\Ñ^\ÆÆšì½‚†\Ýtþ1]f¶\Â\'¯l#Fnl²7\r3›V|–™amªõsb¤)/¡sZ¿\ÑV:‡)\Ñô\n8D@Š—=Ó§9|C¾¿(\'¼\'M\'£Fy©€Vp~arj\"„\Ï*¶ïŠ“…Lñ\ÜJðÌ§%dHþ\"jm»wBRn±hôž.ªLTDB\\‰f®\Å\Ñ\ÍS$´\ÅN\ëYúbûW™8›¨f¥P\Ò8ù‡«žNU›\Ï\Ãb÷Ð²\Ê\ê-•´\Â:‹¼R¹_j¶b~ö\ä*æ³ˆ*nw\Ö\ËV\Ím(¸š¹\Í=\Öcsq\"o\äs‘§¹Z‰#ù¦º‹Zc\ÝEž\æº%\î\Ù[X-[z\Ú +\'l£JQ¾\åS†xa&6\Êw\'¿¾´YT	\"JQ“\æµE»û”™°½\ì¤qY\Øªtl¸N\ryEmEtÁI‹9ó«\"\Ê ŠüÕ¢\ÜP©;3A¢\æ Œ\n\Õ.M‘%\Ô\Â(ñ,\Ó?S†‹š\ÒS¨[\â%¥¦$¥–L0tfÅ˜¡Z;3\r_+c±~’ \'²C‹\ØI\ç¼Ù¯¨„w­²Z~A;K/\Èo*®\Î`\âmk+D3\Ì_\×D\Ë<\á}TjV˜•Y˜Û”—0.HÁIœz÷ÀIQ2~À\à…[\Û\Ên†\ã—4wÐ½?\ï\Ó\Ý>E]†ÁOm;°V¦©þ,\Z\Ý\æUñ†». fzø\È\çð—½\ç»U»\ÏW%$°º§¸Ì‹e™\âK½\Û\çŠÒ§(T$T°¯\ÒR]\Ã`\ç#b\É\çp¡I\Û ?\Â-pž\ë‹\æ2\"í‚ Ù¾:óÀ6ARÐ¨Ë£Ÿ\Ãnðô\Óÿ±\ä>L\æ\Â\0\0','6.1.3-40302'),('201811030753410_Job_Category_Image_Added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\Ý]YsÜ¸~OUþkS\Ú\ÉZ;Žkf·´’µ+Ç²´•7DB#–yÌ’YªT~Yò“òð\ÄI<†r\éEC\0F÷‡«tÿ\ï?ÿ]þü\Î#LR?ŽV³£ù\áÌ‘{~´Y\Ív\Ùýog?ÿô\ç?-\ß{\á“ó{•\ï\çC%£t5{È²\í»\Å\"u`\Òy\è»Iœ\Æ÷\ÙÜ\Ãð\âÅ«\ÃÃ¿-ŽŽ‘˜!ZŽ³ü²‹2?„ùôó4Ž\\¸\Ív ¸Œ=¤\åw”²Î©:Ÿ@\Ó-p\ájö›ŸÀK8/2Îœ“Àˆ‰5\îgˆ¢8bñ\ÝM\n\×YG›õ}\0Áõó¢|÷ Ha\Éú»&»n+_\áV,š‚)w—fqhHð\è¸Ë‚-n%\ÜY-6$¸÷HÀ\Ù3nu.¼\Õ\ìC|w\n2¸‰“\ç™\Ã\Ö÷\î4Hp^F¼s¢ÐS$\Ô(@`Á\Î\é.\Èv	\\Ep—% 8p®vw\ïþ>_\Ç_a´ŠvA@2‡\ØCi\Ôô\é*‰·0Éž¿À{ž\åo\æ,h–FMA\\¼h\ßE”¿š9ŸK\à.€5\"Y¬³8¿\Â&¨´w²&H¡\Ìe\Ê1\ÂT[Õ‰Uµ\"(¢5s.Á\ÓGm²‡\Õý;s\Îý\'\èU_JNn\"õ?T(KvPU\ÙL\Ý\Ä\ß˜¸®7Ž.B° UŸÀ£¿É¥\Ï\ëuò/0\È\Ó[ôu™·E¦ó$¿\Ä­ø<\ív\ï³K2\\ƒd3š­\å¢\éCªžeÔ£öÓ“,{Ð˜=U7J§1\Z”¤~M\â\Ývžq_ÿ^;ù5H¿J;úm“\ê\äõwQo»vnLÅ¨ƒ\ãû\é\ä¸fËŽ^±³÷\Ðù0\×c¸®1\ç[\\\ß\Zº¸®Qšˆ\ë\Ë³\Ñj»	q=um¸\Ç_\rQ\Óü;\Ø#\á¼\ä\É#ðóBŸsý§ƒ‹ÕŠú’¬o\ZŽ®G²\Ñ\'\Þ6™¨–J²t\ÑH«Á\ÚiŒ¶ƒ\Éó%Ø¢D!›eŽ2‘ñ¶š–\Ûò\Õ\ÜU\ì·f®ÚªÛ”õ®}Ó—2Ë¦T\rVó™¨\Ñú“›¨ôf:›)n\ä¹Mo:U\ì$i“Qõ·\áº;BhõG+WªÀõ´\á÷²¶˜œ¤\ÛO0›W\ç\És4°\ÃoqòuNR<p´\Ë5°¥ûã£»ûã·¯\ß\0\ïøÍðøõø]@0e½z«5ebX±–xõúM/µJ!“\"\íO\êû¶\Ì\ÖÀœO\åÀ-\È\Ò¤1©þa]Q>´1§<¼…YqƒlzBU\ÅØ½¡\âw\Øzµ‡v»}ú\Ç¦Å–Fw!À–\Ü\Ã\"€eÁ\"\Zc-\Z¡¼8‰\Òo0±\Þ\ri£\éd»Ez\Íeƒû—>˜˜‚/nA9\Þøq\î\'i6\Êöü#©¢\ÏK`:\Âf:‰\ïý\0^ù\îM\ß*7ó\á\r\ê\"u]gh”¸öCe\Ñ÷!ð\Û\Ô]2i\Ôr\ZG÷~\Â\ZÉ¿\Äh‚‘…}$MÑŠÁû\r¤ƒË¶\Z´\×‡7¼_=\Äü´\ïðˆ6^]½©\æú[|\\4U½p©\Îô>\Æ\î\×x—½<\è›\Ì5\ÅwM vN\\\ç\Ì\Ð\Ëw›Ý¶\Üxþ\Ù÷–\å4\0~(Þ³03\åm•µÙ·ˆsp{I6S\Þ\Çx\ãGz¬VY\å¬9”¬–\ÙLY\Å\Äô8-s\Ê\Í3(ù,r™²É®H‹Å›\ãâ¢·Ü²L\Ú0=œÒŽJ\'+&¹©Í¡\Ûÿ^9\';ý\Íò\ÔM¡û\Úi\ç\ê£ö<CM\ÚyMùS\ÏUYõ†|t\ì¿7\äd§\ßr6\Ñ\çG\ß\Ã#†©ÊŒ\Èk\å§\Ô}Ž\ál\ì\î@5s\ì\Ê\Çl\í\âù\Ê\Úz!&÷\âl\Z\Ã\Ï\Å\Ò6ôöŒú†>›Úˆw¤¸U\ÜtÖƒŠ…°\áª\Òv¡\ÜA\"<)S‘°Ÿ-eÂ‘1;OÚ…\Ä(G˜w/\Òó\0lš\Û\ïº#[M¢\ë\è…@\æž\àu²\ÓÑš¾„\Ø\îQY-\àjv¾ªZ\Í9TPyO ûõ—ø©\ÎÔž*®|÷+\Æ~Y‚¿NC•¨\Ì?e\î\ãö\Üy\Ð\ÍH†~\ä5X\èŠüx’¦±\ë\ç\n¡\ë›k#t¥\ï#\ÏQ\Ý\Ôi\ÌýõQþ%Ò˜Ñˆ0´šý…kK\Ùz\ç§${8ŸóZ@s\Ä7š|€-)Â‹eüD\æG®¿‚	¦œÙH¬ƒº\"6\åna„\'1…tu8\à®pñ|\Ô\Õ1sµJZ\Ë˜v µ\Þ\íi_\ï¢Gƒñ\Í\"}´\é\Ý\ÝR\"\ïˆ\Õ\Ëòst†zd·xšs\nRxüä‹º¥\×bu\Z2zu\ÔØ™›0L\Ýo±—\Â)\ÌŠ	\'ú\è\å;ˆ\í \É\ÉAS\É\ÝK®ÝjZô[¢¥JQŠm\ÞÙ5ñk¦v\à÷5¡L4•.\àg\n;¡z\áb\n.£\É\Ô\Ýv3­Q8}?r¶Ü‡0\Ö\Ür–r)\é@¢#\Z\å’Ð©\\|©m$ JNe:W76z\ç\Ì£`Rq\Î)Áey¤40\Û%68\ÛE¢Ã€ô‚\æ>\0Zž+\ë€=dž\Z@™\Óm	@\ËSžQ\0JKl\0¥Eò\â\0Z\\\'\Ð\Õ?s·`jð¤/5Œ?­·ŠkØ¤\äñÒ ©y@ ‰\r\Ó\Ó)´erú¦¤Ž÷Z´;]V\ÎN{3]\ëðGŸN¸wp‡E\Ý@(?9\Ú{ÿžF¬ñGgS³\Ævk«t\ÕQ\èj2\Üô\Çp\ï=®8¶De2T¢>-#š{v‡ó“?\îˆ‰¢<¥LË£sÜ˜ø\ZfœQ\ÇÇ—9›#S‘™Ž\ë(-		¢\å³pQñ\Â¬ !2\à‹\è‰\Ï_\ÄË»®1\Ú|¤ Â®ý\Ú6\ëCQ¤\"¢ü\è£ Z>ó\äqó¼A‹«;Ø­M.-\nd«ûÒ­d\Ë} F«¥÷ŠU²\Í6LDŸ\ç\ÐOø= ²\É|#°‘\Æ1w\Ý`²\Ãq#š\ÆÁ¶!jxC95\Ä\Ðþ´ž‰þq­c|`K´P2°´\ÈM\ëˆv\Òn „0’Ê\å\ÄðQB‡?\×¬ÉŒ‹;a³[Ž®ô¯h\î\ÉY³]\âC\'…0-\ä z¨\ÏKBu‚¢{†Bð_\Îe-Rh9ò \è\æ\Ç\ÎB‘½\â£c\Ñ7±\é\r+•\Ñ\" …ý]\"¤ª1½K©šT\ÕR™•MË¤\Ä%Rª\ZÓ»”JŒª…$0m\Z7;‰ˆ6DŽ\Û\Ùt/\Ö*hc€\ë\Ñ\Ç(@ºD\ÔW‹¡¥M…€ÁT\Åolu\Õn\ê\Ó 4š¶¤v‚Á\îL[u\Õ\æ\ÚP§-…¿\ïò\Ãr!q¾\ÄKO?\ÚŽ\Â\Ë/Îºð~ú\Ã\ÚÜ‡vX\ÐX¸Ô˜\Æ\Ú-êš²8È¤\âE²s?\rg w\0_¸>õB.›\Ð\î!\Ù\ÇUUŠL¼¶«ý\\U\nÿ_””:÷˜\Ê\Òç¨!6N\å¯=„KEAi{nH\Ú=\ïž\ÆÁ.Œ´n\á\Èi\Òþ¶I’tŠ>E\Ê\É\'IJÐ§Gø\Ô%©ŸyZ\Ë£\0\Î>\Ç)š3Ÿ\Ò\è\Ñ\ÅVGH\ÙA\ÉB\è˜A\æC\åhš¡b\n”!\àü¡ö(Í+¿\ZQ*\\F3„Š\ß+|e\0‹\ì,z0—lQPu¥šQ‘\ì¦u+­>ºE\ãOYÀ‘E÷\à|&\ÈZŽªœ{d’4—hF—pƒ\ÌR%’\Ìh²XšD’M\ÂÙ±0‘®O]\âñ˜¬@’Å¨H=Ža¨\ÃÖ—3{d\ÄvSûGxpc>üè‘‘òŒø­FŽ^F2\Â\ë-µ˜k>O	2û‡®\æ©S6s·F\Óü (÷¤\Þþ\Ó]?õ¡¥½Ž\ä$d’®\îÂ²–Ý‘S©.““Td\Ì÷¦3Þš`¯3•AFCgj2i‹nV’×¹y!§\ÞX«Hš²\Ã\ï6J¤KP’ù}2\è\æ\è\"BaN\Õ\0„’\Â0c-\á\í“$B|Ö§\Õøó$I5_\r°S9ì¤€S}4Xý\Ñ9©µdÀ\év“\âLÐ§Wú\â$)•Ÿi\î9bDš\ÉÚ™ô¸I/œ\É}ŠŒ[MÑ°U&pI:Ï¤˜$¬\èI$*\Îa°«\â\ÜeR{*.Õ òŽ3©®\È\'[\ÐðÌ¦™ô&Î·&Ý§¸d}\Úx\åÇ£\æ\ëdfÁ¹t?\Ê\âJX·¥„\Æ0\ÓQ?R\Â1µ½k>\Ò*]\ïq\Ä\Ê\ï“’ôv\rŠK€Ý€$¡!o(ovôp\Ó\ê‚ON“rQÇ¬\ä.ú\äô\Ì\àºÇµ­\ì$··¯\ä\ng\çu°.\Ýa†#ú\Å51µ¾%‘Sv÷V]œ\å÷[£\ã‘;g³Ôµ—_\ê\ßõ	|yú­Ž\×\Í‡YfNÕ­W³\Ë\çõÁ§\ÏóO\â\ÕD•\ãDþ=y\áQlözþW&\î÷tbp/\ÒÔ£¼5¶\â¦U¶· \Ø>–¶Ò£©^A\ì Ž6\Å†˜e˜k[R\\€[=BFÑ \í\Ô\Ú9Bó jü@e¶»w\ÜSŸ‹ÈƒO«Ù¿ò’ïœ‹\ÞR…œ\Ï	\Z\Þ9‡Î¿;\Çk\î\Ð2ó„Á(ðñ6z4á¡€i…¤\îbƒw\0‘$¦°-EI\È\à.ä¸ˆÀ]ˆqs½õ\å×†Zkh_Û¶J\"÷ê¢”).\Ãk‡A}X<†“\é¡\Æ;©+\åm´U\rJ» §£k+z‰û\0\Þ=w‡˜ \rQ•†p£ñù\ç\ç\"½‰ü?v(\á\Zu¬(6FO¿2\àN4¢¥¾Tî‹¢4\è;j˜Žsi\ÄMQ´7ö\Ñ/-4;l\ÊA\ÆG6\î¤\íÇ‡•\ìq¤k=q}Qƒ²\ÑV\ÞlDFk½\Ñ­—8¢xŠ\Ö<ñ\á=„ö,\'w•@\×Ï½\ÎcOðf„©`ŠB2S…}\ìÄ»8z	œh+Da\\Dkõòa{ Õ\Ðd!\r­ˆI\ãö@q´C+N¥¡m¶=\ÍI«\é]•\Ü\ã:Lp\ìùb·+\ÓZ¸qa\Ól;=­gÓ–\âôò»Œ\ÖÛ¢\äŠ\Ö\í}º\ç`\ß\Ç#\n´e¤’€®rº\å\Ò5\Ùð:\Ùn\è¨^\Ý¬\î\á|¬\ã\ìp”ŠSR5µþBHž\Ð38!zòv\ê\Ôú‚\Ãò€c ŸÀbGs;v‘€^\Ô4_kV?¡\0:û˜£‹\ëþ°3^P”¾¨@8û~3~ ›ñƒ\Û|\ïl¦»¦qO*\àg`\ßöŠ× :{\r#Xi¼n\Ô=Ÿ\Z	\\:®\ì\ä\îŽ&NA\àV‚³CÐŒ5\Ù\Ãƒs\Ó\éš™\ØJGÁ°Nfl°\ÉGLlFAc&†µ}ÍŸ{Fšö:% õ¦s\ìCW…CD\Éx)Ð³}\ã\Ã3òý…^\á\Ý{85d\ÉK´†\r›\ËP{Bø¤žðþAYÈ”\ï¶\ï…qLŠ§U«™w#$\'­.\ÝE•\É\"Hˆk\Ñ,¬x\"ºEŠ„¶Ø“>K_ln\æ*gÕ¬A\Z¼£X\áp\Õ\ÓÉ¢j‹qX\ì³ZVY³¤’V\Ød‘W*w–\ÍVÌž\\\Å|Q\Åj\Âl\ÕÜ‚‚«™\Ë\Ñ\Þb31—;òV9—yÚ«•x·o«»Ü µ\Ö]\æi¯[\â3^!j\ÙÔ£R€¬œG¢<\ç#Æ\Åù\Ì#’\ÓWu\Ù\éF–±@\Û\È,÷Y\Ø],z\Ã6YG\ß\éš;œ\é-Œ$Œè‚“‘p¦\ëE)BŽLa\ÜPi;Ab\æ ¶\Õ.MS$\Ô\Ä(qQÓ¿P†\åÒ‹P¨[\ân¥¡¹¥‘\ì¡\ëL6R‹µ@VfN[\Æý^\"¯\È6-boŸ\Ó¿Aô\ÞG\Ërñ-¸ü°¸©¸<ƒ©¿iH,Í¨x=\Þ­ò\\D÷qeYa8ª²0·)/a<“$óï›¡dü€Á63\'¿Ž_\Ò\ÜA\ï\"ú¼Ë¶»5†wµ\ìÀV™¶úó14\Ï\Ëò\rwM@lúø\È\çè—x5\ßç‚«\Ç\Ø\ÜS^\æÅº\Ìð¥\Þ\ÍsM\éSi*\ÅW[©®a¸\r±ôs´Ð†7Èp\Ü\çæ¢¹ŒˆZ´Ø—g>\Ø$ LK\ZMyôa\ØŸ~ú?[©¤Ã€\Ä\0\0','6.1.3-40302'),('201811031958527_JobRequest_Added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\í]\Ûr\Ü8’}ßˆý‡Šzœð¨,{º·\Ç!Í„Z—iy,K+\Ù=;O\nŠ„$®Yd\r\ÉrK±±_¶ûIûðŠK\âJU¥Q\èEE\0	 qH\0™‰ÿûŸÿ=øó\Ó2™}Gyg\é\á|\ï\í|†\Ò0‹\âô\áp¾.\ïÿ\Óü\Ïú\×98–O³_\Û|\ïI>\\2-\çe¹ú°X\á#Z\Å\Þ2ó¬\È\îË½0[.‚([¼{ûö‹ýý\Â$\æ˜\Ölvp½N\Ëx‰ªø\çq–†hU®ƒ\ä\"‹PR4\ßq\ÊMEuö9X¢b„\èpþKœ£´WgœÏŽ’8À¸A\Éý|¤iV%nâ‡¯º)ó,}¸Y\áAò\åy…p¾û )P\Óô}v\Ó^¼}Gz±\è¶¤\ÂuQfKK‚û\ï¶,ø\âNÌwlÃŒ;\Å.ŸI¯+\æ\Î?fw\ÇA‰²üy>\ã\ëûpœ\ä$/\Ç\Þ=ªÐ›Yô¦Cù{3;^\'\å:G‡)Z—y¼™]­\ï’8ü+zþ’}C\éaºNºq¸y8ù€?]\å\Ù\n\å\åó5º›|\Íg–Ä‚§\ÑQ€‹\×ý;O\Ë÷\ï\æ³Ï¸IÁ]‚:DP¼¸)³ý¥(Ç¥£« ,QŽô<BO…†pÕ¶u’_m­ŠxB\ÍgÁ\Ó\'”>”‡sü\ï|v?¡¨ýÒ´\äk\Z\ãù‡•ù\Z\é*;AE˜Ç«\Z3#\×uf\éù2x¡WŸƒ\ïñC\Å}qñ$¿FI•X<Æ«z®\ÓÈ¼­3\å\Ùò:KØ¯\Òno²u’fg’_‚ü•l³ý\Ò\Í,«µ™™\ä8ƒ¦œ9¸ºI&•`Ð’úKž­WS´™\Ìõ—:É¿\Å7\éD¿\í30“¼ûMð>q\è\ä&T¬&8)°™INjvœ\èm\Ñ	\'»‡\ÉGZ=•\Ì uM¹Þ’únPHêš¤‹¤¾J˜MV\ÛUKROW™ñ\ÔWK@t4\r’5òH¸*yô=ˆ«B—\Õø£³×Š\ç’lnZJ\×\ã\ï¹ò\ç‹`…AI\Û\ähò\×o;ù\×K^U¾NØ¶’X™¹Û¦]¹Y«Šš\è\Z\\,˜4hÁ`3Z4 N›¯ P\é\r,\'.\ë\È\ÄˆÙš¥Ù®\ÕÜ¶&£›o\ãM1»Fó\Ñ	\Ç\íPzTø½\èŽ%ŽŠ\ÕgT\îµ÷j’gXz¢ß²ü\ÛMñ\ÍÌ¸\\ûw¦°¿wÿþ§~¢÷?þ½ÿaú)\0¬û\ï~2Z,1¬Y°\ßýð£—Z¥ÿZ\à\ÑO÷m“­‡¹˜*€\È\âÒ„”X·T·Ú¤¥\"¼Á¬¤C.3¡­b\ê\ÙÐ¶w\Üz‡UøuŽ?ýû\Zõ¾ÁT\àKn@	\à›\à‚ˆ\ÆTJB\Ïô‘uõ£´ø\r\å\Î[c4­Vx\\+Þùe&®\à\Î)”\ÓÉ³8/\ÊIöÀŸ‚‰*:Š¢\ìXó\ì>N\ÐU~Í“ñ{–ñwôO‘®®,%¾\ÄKm\Ñ\Óe«\Zhª2\Ôrœ¥÷q¾D’\Îð¤‡E5†è— x·­Ð¾)ƒ\åø§\ÛWYŠ>¯—wD¢MW—·¡ùò[v„x©:MI©Áô>e\á·l]ž¦ô\×2´\ÅwGÀKsŽ\ÂK3fU»\Ía[n²þlz\Ër¤Qan\Âûnµ¼¥³÷ûy.a£\È\n\íg”MO‚xi\Ø\ì&«¢\ÉU}s\ël¶Mý”=Ä©YSÛ¬ò¦\Ö9´Mm²\Ù6•3ki“S\Þ\Ð*ƒ¶u.\Ûfò\Êt­w\Z5.z+h”ÒŽ™Ž€Ý¨@g\Ã\æ°\í\ì²8um‹l@3\î\êvQ‘™\ÂS\í«\êC\ro;|Me(\r\ÅZu!Ü·ˆ\Ò&\È|h?Ù®~ýe¸QÍ§OøWŒ›Œ\ÎÓ¿£ /œK_diùhWü<\Â²û“lS®ªI,š½ž”ñ}<\\§ÁŠ\íý½°_§¾Z\Ò;‰‹U–\ÆwqRM^]ót+¡)…«¶,‚›,,-‹\ÝI?‹\ì£>ÛŽGWô²|Dù$Â¢ó\Zƒ¡„\Éü\r¯hh(2õC,/\â´\æF#\Æ\Ë\0\ïW¯rü_cª‹%\ëM\âö\ZxWSð4rM7	B«\Ëô\Æ/{®³li/V›\Û\Æ5V†W([%v‹®Ïµ\èqŽ\È\Ú|ô¬o&\Ôuýü<zM_W\Ñd½jêš WGQ½*HFµ’nÎ‚\ïÑª\Ñ\Ç\ì\îòþ^¶#\èt\Å[¨\0uÿ¬\È\'\Þ?«2\Û\îop\Ékô²5\Ðõ€\É	5Ê h3k¨¥`\Õg+SÁª\Äfl«ª»²;d-xº\\%Ù³I³7·±pXU;\äÀ­‡%½×½È‹Þ‹Ø’6\'öƒw+Î›\×\í\Ë\ëöe+¶/\î,ð@M¹Á±¥¥\Úñ\Ø^ym§xd·Î‚\ì\× ‰£/q\Ü±ö¬”!K•\éV\Ì\Í\Ø(Ã™ ceIN/\n¬‹\Ë]p\çLK&Q_\rU\æitXO¶Ó„\Æ5\"ºF1þfž®l\Ó\Ûm•77 ónI\éD\çó\r\æÍ†\×j†7e6³Wm*wÜ­R¥§šð—r£o|Ï‹nl‚´-\ë±t7&šúuz@“\í*ÁyFHL(r{.Z[ôU/$œ^Wô\r®\è,’%k:œI1]½®\ë´Je®\åßµ¥\"ûf\ë}[¶}\Öo\Ê1¦\Z>\æ\Ðk´“)RS\å„\í¹*§\ÙPYúŸ\r\Ù\íŸ\rU3ñ\ç\ïquGa\àð\Õf\Æ\äòÃ¾dú9Çµl\ê\éÀts\êÊ§‘®nE°¦³³L\îUÜ¬Y¥½_ž‰Ü„:›`¹¼=6\Ð\Z\ãoKKjW\ãðIÙ²„ÿ\ì\È\Ì %¹=@5em‰\rH+ú´\×Vj™ŸO.½ü¨˜þ\Ì0^\àý¶gû„\é¬§´yœ\Î:pT›G#›@¥M]++n\á½\àWf\ä»:·ƒa Â°±«4gS\åU›.\Êšõ’Zf(·ÿó\â,	ú\ÐÃ¦\ëNGb\èÂƒáƒ¥bòŒ\áF‹–\íˆøÃ¶\çr\è	w»Ú¾\Î\ß\nC\Ä\ä=~Dá·Ÿ³§.ÿ¾:?™Wqø\Èé¦„hÍ”hÝ‚›\Ü\ïÕ¹1\ZPX\Ò\rúƒ8‚õX)Æ¯]I\\¯.?ý\È]\Ä\â\Âl\ä\ÎÐ’Î½\ïÀ&\ÊBÍ•S‰\é™uŽ¬\È@¥\Æh¯=Ñ†ñŒ²1sfZGc#†¡É³)\Ç~Ár6‘rŒ\Ï]\Ù\Î2\É\0ó÷¨(²0®ø\Å*tp”5¶ö\Ó4šÙ„\\\ë•M8\Æ\ßfzL¶5x8œÿN\è­a}m__w\åÀV±\ÏvWq™ž`X¢\ÙQ:”\ÜEa‰Š\æf\Ä~Á[DBN\Æ‰ZU\Ñ NKqŸ§a¼\n‹Žp4d\×üpøZ\ÒÔ®R>å¤\Â\Ã8¸5]¥Cuü;XP`UcXˆf)Ã‘<´¥;o÷ö\Äù¨ lŽJøNÐ’õm:8\Éx`\Ò!|ë¦€\Ô\Ç\ÏV5L›\æQ¤%›\0œÀC°\rš\Ð\ïA5O-ö\rÅ Jd`¶Ÿd*¨Á¯@¨\ïj O]þ0Š-\ì@xi\Å\â‹Ê†[l´p6\ä\í$8T„8\Z\Ö.–r.™@b \Z\åœ0©ŽS:,­~\ÂGm\Ì\È \Ö.\ß|“¡3 Þ…ý…¦“ê‚ª!Û‘]…\ÄE‡ …WŠˆ\Ô\épÌY4¬Rv¢D\âœ\í„W){†·e\È*CHWŒ\âP‡9}¼0‹“¸³\ãwü)—\Ít–¦*¦Œ\ÎJ•i0oümµôh¬\\wdñQ÷b\Ò\åG=t;²\0)< ôXRºC@Èn)2pÁ6·XÁ:C\äH½°q¬`•Mº8}¤n\Ìõ\ÆG\è\Ú\Ü`9\Z	½\êh8Fó\Ê\\•,2…\"”¦\Ý=‚Š%\Z281Œe@0	hÜ£A°š´º^0ˆˆì¦¡9O\ßó	\Î?ô,1ik†·Ð«\ãPCJm¹‘\ä£&\Z¶ä”®qÂš®\Ç6U†%&\r\Ø*€6\Ñ\ÇMÀ‡\"\ß6€r1\Ð%\0mü¢&(Ë±\r\0”e\É\Î´:o:þ\\úmƒ\'ú~úK%»6€M†»MC—\ZCl\Øú\×H¡-sa3?Á\ZøúÁ0=\Ù®\íZ<=\î\í\Æz7U_S÷ªa ”ûZm|~Hý·¨¦‰\Îf\Ûv<¬¯&\ÐÕ¿´8\ÂT“\á\Æ_ƒ\'˜qj÷z\r}Yzö®ƒ\æS\Ä\Ì\Æ\å€Í…?ú{3•£Œž#i\n\×û\Û5W \çŒ\É\\‘{rZMj9\'†7\ÂûD­¥p™—\è=(z¹trG+_#ÁñË¬\Æ÷¡h\Ü\Þxt\â7¨l\Ñbò6W\ï¤Y\n\ÓU %!aR´‰\å¯¯y4$ vˆ\ì !\Þ<]&c­\Þ4DøMšŠ`¿‘\Ó\åWˆ¨¨&hˆ6Ž„…\\7&\Ô\ë\â@ô\'\Ózt´¾‰<\ZñeHD\r5\Ö\ÔEO²÷ö„¨uK’1!u\ëø›OÀµ/\Z*×œ¼Zm_T’m\Î\Ë@\'}¥OE™V®©³\íP\rýj\Í¡\ä¶Züô\áÎ¨\"\n1[¡°7Ž&\ÞV]/¥RQX\Æ,ý«¨\Zz\Äòª	\Ë\'výh}w\0¾	y\ä=\á³Bü‘µ^Mht6ôž\'0$ž)|«E\ß¶\Å\Ún‹.%£u™õˆ€»­ðš\à[ûM°­§55`\r3ø\0˜\åœ\Ð\ï3­W˜\ïS\íoô\Öö@\Çñ804ˆ½59?¸J{rvŒ9\rB\r\Z¥ùhóH0_\Î,Q3\Ø-¹Y3À03NÉ­‘-\ÆÀgê·½€•\ÛØ°–]WMLké•›ÒUËµ‰1­É˜¸¡M\ßD›‰\Í-\r\Õ-\Û3A‰V\ÃNcg;\ÚUÅ²V1Nkú)\é \Êød )\çT6›V#3h\Ú2\íV\Í×²\ãMÉŒúl™¡3L3þ;ðGa\Å0\É\Ô\æMy=\rX½Q\Ýk\Ô§,ÛŒ\Ø\ïƒ[\ÍvÙ€S€‰–ºW¬‘\Ö0±UE¬\íŒw.µ»=— ;!e\Ï8K¡A\\\â¬z$\\j;\ãK¬g`«¢\ìk­2ˆE¬e\É\È\n½clQ-],*<\ÚTp =\Ë2K\Ó	F*ñ€\Ùu¬\Ô÷û>oø\'-\éE>\Õ\àð\Ði¢Š#dq\ìp#Lõ–:uUp\×\ìx4ý	ŠŒ¨\à™\ÉPqK\ì\Îï»½6TcwÙ¥,n\ÂG´šœ%D«r$u€µ6œ\Z\Ç\éCÑ—l¾\ÌnVAHt\â\ß\ß\ÌgO\Ë$-\çe¹ú°X\ébo\Ù=f\ËEe‹wo\ßþq±¿¿X\Ö4!\Ãcþ¾´«©\Ìò\àq©\ä|;Bgq^”\'A\Ü$|\Üq´²÷­’Ë„¶J\èJUÁöš¡-Eþob¾ñ\ï\0uW¯\â5uSú÷qI.º«\Ä\àñ&P\Z—\'/{¹+”ŽLrœ%\ëej´DN³-E~±$\ÙsŠ\ÌC74A&Áœ\Þy˜¥\ç\Ë\àkõY¤u°\à@°Z0\Ü`\ÑcŠ­rƒ’„\0\è\ØA\Ñ\Ò}´¢\ãÎ¸`õJ«@®ùjE©~\í˜#T|©ð•ZY@:44ƒ1\\R1@­\Ï77D2Wp%-Ó‚TN>ÁšžTœB\é\æ\ÔIQ¬Ö’bb‹…D;º\Õ\\ƒ©RIv4©\Ð\Ó<M*Éf“UA˜J7§^•<ú\ÄU8ú\ËU³i +d±ª1q9\êH¤qcB6yp—8 Á˜½ø1##òû$‡IF½úÀ(sý\ç­A‚\ì<\Ít\ä\ë>ûWg¤E¡(“…\Zñ<qøøtÆ’\îc$\'!\ãt\ë,CóZ\æ@#§\Ò\ÆÞ£©\È\âñml\Ì\Ä\Ó)÷1\ÓðŒ™ž„ŒÛ\ë\Íy\×9õþô“¦)3ºUQªOEþ¾5\è ™\"Bs<o\0-…qdmuŠ$\n\\\ê³9­ODªÿj(\ÊQÁ\é‚\ÝG\í¯~\n\é*¿\æ	§û±Im\Ã\ZÿwôG‘I0§wºxJ\Í\'K\Z\ÇYz\çKÄ¨4Ý¹(~\Ëòè— x\äg:Åœb+›n\Ê`¹‚\ÅV“d\Ñ\Ê\Ç,E\í;1L#\é\'zŽ\Â9,vU¿egAˆ\çÿiJv5u1\Õbf\á·l]ž¦\ÕsS_K\î`Hv \r´™O³™M!ž\Óg¢(ª\Ôo~N	\Éæ´‰\åQÿukV¥¡Šñ¯sEq\Ø\×\É\ËÊÄ©Wì‰¸\"ö•Œ÷6ƒ¥_·‚bõ^@­ûjN©}Š¦\Ó~³j\Ð+!ÿ„Å¸õ\è<ý;\nrny’\ÝhWü(ˆ·\é§»þÝŸd!¯ªô\ß]¨‰G\Ï|šµªÐ¿š(}¢Å’\×?“\Å,wýg‹K£¸Xei|\'1y“¹6b“\Æ=\n‘ÒŠK‘PóÍª—\Ý;˜\\»\ïü§ž\Üb€ú\îB­z­J ˜Á\æ¢1½F(Q\ëVtþF¬\rB\ÍW;\É–(ºˆÓºo¢`\à’hOJ\Ú}²\ÅH%­.\Ó	L‚®³l	\ÈG6Õ‰*\Ê]ª9eÜš\ê*\á\ne«„cŸfA5x’S\å\Ò,K?þÊ€–N°¦÷ó3H\íg+,1O¸2º$`Moõ\Ùj«“Cƒ ‘ÞI²lú«2;²¸R­]¨\îT%EW]\\|\î.B\Z/_Imðµ*Þ\Ýü\Ë\Ã>È©½ê»¯úî«¾k@\ëU\ß}\Õw_õ\ÝW}×jõ sñi•\\’9\Í_ƒ$Ž¾\Ä	w@}\Þ:Ï5ñ\Æ]´¶®l\Ñ\âQô«ú´¶!%®Y¯À~¬Oq£h°2È¾MC\á®b1\'Ú¸MN\ÓAZX\ê=2Š—Z\ä}_0ø\Øfl\æ&>°{‹€~TU¶P–-œO~–\Z.|Ù\Ù5ýr\ãyŠ¾.[`€(õ\Ýw±@¬ƒ\çÙƒÚ€\Æ8 öcÁX5Y\Ü3SŸ-iUöð\0±\æûVI\Z\ÞÀHu¸\Äa@’Ð¨\à\ìø\Û÷X8¼ä’¬NÉª2E\Ü^I®4†”¹’»£\Ã\È\Ñ|¸\á¤)\ÝqÄ‘+–q\Í}\Û£¢\î\á±w&wG_\Õ`ò¢\Ól\Åýc\Ê\Ïý\ÎK?I\ë†\Ä\çÍ´\ï[sŸ7Ó®·\æcK6h„\ÄŒ£¨5½KI-e\Ï$B†\ì0DxQd¤\Çs•ê‘†–\ÒÀöJŸ-ðvJ*o-3\Ä\Z!šˆ4ºõGRL¶\æÈ\â\0¦Å°1\äºl	ó	£\à8\æ(q:\Ü‚!\ÈŸ¥“dÍ—\îwd¦	ð\ÂDž©ºH\â\ÈT]+š`3|Ä—:\Ë|\ÖnD\ç\Ï7ÿHöHú^õ\ïq#b0\ß\æ¸\Òø³\áKö\r¥‡óöþm>;Jâ ¨\Ã\05±l>ð\Ïq·\ÙO‚Û h¹\à‹Û‡\È!TŠ\"J€\09dvõÇ†9À[2~\Ûf\Þ—\Ç\Î8Xð4D¸\Ñ\Å\ëˆû1\áv5“±2…r²\Æ]e‰ò´\ß\×\ÎgŸ\×I\å\Ì~8¿ñD‹¯‰\r0SW”d\éCývJO¬z\'EC‹9\Ì\ZFŠŠ\ÌaCˆ^»u\Ã\ë8¬Ž\Ã9ò0v‘_†±]Ž;\ás¬\Ï?\Îÿ«*ùavþ·L\á7³\Ë…³·³ÿv\éM*fpwj‹‘­£xPoHø,\Ü”m\Ñqé„¤\á\êÃ½‘\âeE!²\ËprTH—\áÄ¨X.Ô¸YŽ\0»Åš$PË°¾\nñY\ìP\Ê—\áu€`\Ð\ÇC1“.\âa|¹\à\Æu-¿\ÍÔžþ\É”Æ£&i2\Åh¥ßƒ<|\È[…Á\Ó\'„g\Æ\ã\á|ÿ\ÝO\Ö,¢¥IOT7B¤\Ó\ä¿\êó›\Ùyñ5ñ\î\è\Ã\ìžd ¨V½û\áG\ß<‡c”˜ñ]ú´¯˜?¢¦¶\n[®b\Ü\×EY\Ð\á¶­©‹hñ\Èj^36\ZYý%†~\è \Z#\Ê\Ç>$Ê°5Ž‡\â]\Ò)ƒŠì”°£’\ãwŽdà¸µ\ÑHª8l’m¢#Ô¤\ÈQ]“\î^\å(Œ‹\ê@\ç­-\á& ‰bL¹¥Â˜(@£¦~—e‰ƒöI\Ç#\ÆD.\ÉÀ\á¥cx#\å‡ib ‘Ä€\Ð\">\È\ÐR ¤ˆû¶§&b»F·%\'\Ö\Ã$‘>\Ì\Ö\Å\á¿~Q`\n¸0³—\âªMÀT2’\Î]\äo&$\ÚKzwÀ=\Èô#‘-ú\\z¡ÕºX:£=+ž%r•^–÷\ÞL`€\à¢\\(\ÝÇŸó›4•\Ñ^ö\ì&k>œ	Ð¶\ÎDhgIw^ƒ¾‘\ÃðÔ¹FÀQ\ï9€\à\Ù`	h$”ö±¬$·¶8ù{M½W\äH51ž’~xÓ¸0’¬7¤3)\ÞÒ\çó\è>\×i¥ó¢7ž\ZFˆ±MòBjx›$\Þc]u6I\Æw]‹£Ë®®ì¤·]¶s›²‹±;\ïK:S4–n&: 51¥hD\íU\Ü-ÐŒˆJ\r4\í¢Z´T\á^Aù~Uµ¼Qio¶½L\ËH4£d¢š\á²þ\Î^E\åû<€®µ5Àlh;\r \r\Í\Ì\" )9Hó‘¨^»e\×À:37\Òx,µG\0Òw	R{l£}UzD¸ËŽ«\rBj#7\ëLTŠ!\×k[/›U@™rB¼8‘O63qÙ•õa)ú*°\Ýñ©‰Î°³ø\Ü.k-*Z\ÄÀ½)bt<\0A\Ìð ‰©\0”¸R\ÅL0¶÷Ó£Žk™gK$¦žioÐ®Fe&vV\Âl­1\Æ\ÚÑ e\"…A\ëd5b‡`0C•<\è‚]’-\ç(s]<†\ß¼¨\\ŸG\ï\Þ.=^|z»dt¾ø´7=rÇ¨ö?÷{\'¹G\0SºY\äaGAƒ9\à\èh;†s\ê\rµlH©\à¬\Ügœ\Ùn\á\Ó4ª‰z\×Ø¦3$À^÷\íb”1QqýX\ËBX\\¦\'(A%š…u¤\ã ƒHd#	\Ò k\èƒG7\ÎÀ¶\íwB•uˆ¸\Æ±Q\ÇKQ‹‘h®ò8\r\ãUp\Ü\àò\ÉÀ,‹’y°\èó)\'hEø´Tõ~põ]-\Ü0\è˜\Â\Ä\ÌP£­©ÿöf\rEeuC\ØÛ½½}a Ju°=µ\Å\ÝO“Z7\ÛM¢•6J0ðC7‘˜±€¡?\à˜‚\Æ`†\Õ6\rD\Ú\0*J˜tÁa¸\ë¿O`ýÁˆ#Hy[øø©qÑ¾ß·À«\ï\Ô\Ð1n\âô²	“ÀHpŸ†\Ú\Ó\'Ž0¹Û¼d¼\ÂJ\í2.©vüžN>Ñ†; <ó¦*\\KØ´—£iÞ‹\ÙJm¹jó\íG\å»9ÀÈ‚CúÏ„.Ù³6gES\àKQõ\0³0J\ïÀ;ŸRf\Û\Ý\æ@8^[#›ž\0\'ñ¯•»&š¦ù)€.¤¬K\í›F\0t\Ë\Üv`nB\Î\rqs‚¥\Ön\èhœu\×>õ\å\èi\ÚÇ–¶RSkZ}+t@©­µ÷(ð\àþ³aMþzÝµ\Ð4ˆSV?\é:ú‘Š*¾\Ýúš5\äwZC³„ô\æU3\ÎÊ«¿•ãŠ6F«fusc‰XOHQFO“œ/µÊ¨2õû/›	ð\ZˆLp²Z\ÛFËŽV›Ô—5“gÿLmr76\èÅº[mx-[“úÁ&{\Zp\ËÁF:²«X\ÛÔ•Ñ†‘f|k´M@ƒ\í\éoÕ¡\\§P\Â\Ì\ìþõ\ÉJ¼è¹¾p¹Š•š\à\Ï=x„Œ4N\Ä\ÄI$\änZ\Íj	L^\Ý\Â\Í\Z6\Î\íM£\Ôù¥\Ð \é?N‚bÀj\Í\è\ç*ŠVmœr¬ð¨&oKOWìŸ¾\Û\Â\Ã\âmAÞ¦Ž‹Ñ·\ç\Åüº\ÛÖ­qVW½;,Î¬\îR\Õuz\Ñ)û\Ôe\ç3\Â=K)\à¨y\ÒT4\Ïz\Ç\È<·~\àòp\Ýex\Ükÿ–>CŒ÷\â\âVE¨®DJÜˆf}ñÑ­S$´\ë@}\ØYE¨\Î\Õ\å\Ô7ƒ5qªg“¡j\ëL}fbZY!­°\Ï\"¯´Í£¯X\Üw‹Y Šù\\úª…­¸P³C\Ýchõ\×%\"žú4Dý\åÁi\Ä24Cš$\Éi_\Ì6¬B9\Ùª\n\ç&­\È@Uv‰’\Úúçž+Rv‘Ï£®Ö¸›À‡r>6y\Ôðl\î…l\ênŽÀ•u7y\Ôu7\×–SR¶¹\×MTY9°&Eõ-\ï\Õ1¡q}T›j!<ó\È\ÓVúŸ\Ù]‰¾‰òD0û3\î«r2B™$Mi³1¡-\ìƒ\à&n³3ªˆbé†­\Ðx˜–\Õ+ñ\Ý7AÿÓ¹\ÇRD\à¼v\ÎvÝ€-­}]\ç\ß	°B\È\ã¿ûiŸO}Y·Žö~‹p\'%~|Cùštl¼N±žvp\Ç\Þx|cyµ¿mpÿ]\ÝYs:	ø‚\Ý\ÔyŒ—n´\Z[µ˜MPtU¦3TúD#\rú,Á®woò5k!\r¯-Ï¦yc\è\\£`‚\ÆGr~ôc‹a\â­h¶¾#\ì\ÅoK\êU©ÿªZ\ÜdZ	KCª\\xfQsnk\Ë\"\è¸\×~¦g°\á\ÐHs|_2\ÞTµøT¬€LÁ•\ì\ÐÚŽK/À>mc`seå´¡3Ž#K¬™\è\Ðq…Q-\Ð{S\\Õ¥6\Ó!\ÍDr˜±\Ò3š#F\0F¦£0Az\"hcMªw¦´gz¦@Æ£3…9£˜Ò¤zgJsº«\ç	`³7:K¦P\Ú\ÝL\Æôs±=…¡VgquY‰‰X/^¸ò^gö£´±¢ø#&\î$û\Ìu\0fÛ›ùHnÁ©>÷¬”ŸW24¼ªF\Ö%\ÖL2Ù¦PC7\Ê(\êòIÁ–>\×H±\Ú\å):\ÛF|\ì\îê»´ƒE}\Þ|À?\Ë,\ÐE¡¤¨¾,®\×)y~£þu‚Šø¡\'q€i¦(dlº<\ç\é}Öš)p-j³ð¯G¡2À\Êdp”—ñ}–8™¼\Í§óYÿžp\îE\ç\é\åº\\­K\Üe´¼K˜³Bbê ªÿ`!´ù\à²zl¡ðÑ…\êù¬_¦?¯\ã$\ê\Ú}Dâ” 6M0i2–%	*ýð\ÜQúœ¥†„\Zöu¦_†\Ù.\\¦7Áw\ä\Ò6,\Ë?¡‡ |\î\Ã\éËˆ\è‚eûÁI<\äÁ²hhô\åñOŒ\áhùô§ÿŒ¯âž¥†\0','6.1.3-40302'),('201811032208193_Candidate_UserName_ProfilePicUrl_Added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\í]\Ír\Ü8’¾oÄ¾CE;<*Ëž\î\éqH3!KV·4–¥U\É=;\'Å‚$®Yd\r\ÉrK±±O¶‡}¤}…ÿñ\ÄYUZ…V@H|H$€\Ì\Äÿþ÷ÿüõiO¾£,\Ò\äpº¿÷v:AI˜.¢\ä\ápº.\îÿðóô¯ù\×9ø´X>M~kó½/ó\á’I~8},ŠÕ‡\Ù,\Ñ2\È÷–Q˜¥yz_\ì…\ér,\ÒÙ»·oÿ<\ÛßŸ!LbŠiM&\×ë¤ˆ–¨ú§IˆV\Å:ˆ/\ÒŠó\æ;N™WT\'_‚%\ÊWAˆ§¿Fº@{u\Æ\é\ä(ŽÜˆ9Šï§“ I\Ò\"(p?|\ÍÑ¼\È\Ò\äa¾\Â‚ø\æy…p¾û \ÎQ\Óô}vh/Þ¾+{1\ë¶¤\Âu^¤KC‚û\ï¶\Ì\Ø\âVÌvlÃŒû„\\<—½®˜w8=’E´\n\Ü{¶¶\ÇqV\æd˜»\×y3©\ÞtÀ@)ÿ½™¯\ãb¡\Ã­‹,ˆ\ßL®\Öwqþ\r=ß¤\ßPr˜¬\ã˜ln\ZN£>\àOWYºBYñ|\î\Ù\æž-¦“M`\ÆR\èÊ‹\n\×=;KŠ÷ï¦“/¸9Á]Œ:$\\˜i†~A	\Êp\É\ÅUP(\Ãy¶@/¹f0•\å«/¨À¸\ËúZ1ñDšN.‚§\Ï(y(ñ{÷ótr\Z=¡Eû¥i\É\×$\Âó*²5\ÒVö€g\é3\×=u¡²m\å_Š\Ö\á?=´ÿ¼bt…_³xð\Úð-P\ÖUƒ%Á^û‰n-Wú\é	ÿŠðH ³\ä(\Èr\ë\ÒiR<š?[\à\éýI\Z\Îá¾ª”_],k¢ûuÿ˜¦1\n\ãQÁý}I‚‚ñÕ\ÞI”¯\Ò$º‹\âJ*\Ô4O°Ì¸‰–\æÔŽS¼f¦SùWmX7XX›q=ó\ì#>›ŽGWô²xD\Ù(\Â+\Â5\nœ¡„\Éü=‹\n\äJ§œú!^d.¢¤\æF#F\Ë\0\ËÌ«ÿ\Õ(exÁ˜‡AI\\´‚k\nž®i#´ºL\æ~\Ùs¦Ks±\ÚôØ¼0®ñ—,]¯®PºŠ\Í\\Ÿm\Ñ\ã•*\ÇIP¿67u}|¼¦¯«\Åh½j\ê\Z¡WG‹ETª‹A\\\n®,Z\Õúº\ïZ¿ß£‡J/e\ê?\r¾§\ëR§w—÷÷¨T:®Q\\e\Í£U#Ÿ;øVT\à4K—\×iLªÊ‚|·sü!,/d¾	²TÀ;‚K^£®Q^ˆ{Ð§\ß{—¾\å¢ô®m‹…™\Ún‘-=˜õ;&\å>ª\í0|Õ–\ØÀ.ª­\ÚfE–k…\ë\ÔW§ÿ\ËUœ>Cš½¹]…\År¨\Úf8\î;\é½nD^ôFÄ”Œhgb\Þ1ñV\Åz§ñºwyÝ»l\Å\ÞÅž¨)w7¦´T\ÛCZ•¶“?\Ò{kAö[G‹›(Ž\Í)©”\ÕJ\Âÿ\ßù7©\ÆZeº\åsSj«8§m\ËsŠTmc¶¡f®\Ç67 \ÎÚ¨±#«¯@•y¶)W2%kT\ê\Zùð;y²²Mïµ»)¢˜\ìMž\Û./?Õ™,Ò‰\Î\æs\æ\Æ\Ó{CÓš€©\Å&†ð­Ú£6­\å.®©k\Ð	$˜\Âs¬¶\àºF\ébY_¥‹ŒV\ÛUKn_A|µ°Ui¬»¬‘G\ÂUÉ£\ïATº¬\Æ?œE¸V<—ds\ÓPú6ûÒ‹`µ*_DguŽ&Q$Uù¸“Cef\Ñ	¢ª+óµZm¬‰v™¨%„J­t§EC\Ôi{A\éW-q(­\Ìö¼\ÆJ\Ûñ2Å¸\ë\È|´U~šc#ý§)³¨©\ÜR\"J…c+«Á5ª³¼;Cp=ÀÙš\Ã\é of3D\\\Âùº­,fò+=1¦ka•E\Ø6ü§ªUe²ý=§\îðˆ¨…+!k-“Q\Óx6·«5’®›«–òtd…`¬­\à1n\àC\ê~ËƒIU;®1\Ú<\Ê%\ËY˜&g\Ë\àa€Q\Ð)\\Ryp+™þ·ª\Ù~\ëmr\Ó\Â\ÂF‘z=)VÀ\Z¬±½žñnðŒ—F²\ä”WœI±û>\émÅº\Ñ$mmf]&W\"‹õ¾ù\Üð\ÔuŽ²Xy`»¡\ÅOºðµŒ¾­3QsJM1:ƒ\Ó\ÌjQ\ÒVM­‹\Î-«v\Úk\î\Õ$O3L\î÷4û¶GR|3—\ë§\æ;\è\Ô|¿wÿþ\ç\n\ïú#zÿ\ãø«¨ƒó“\áâ¥™\ï~ü\ÉK­R,—ŽUb0“\ã}\Ûd\ë\áÌ§r€dñé’”X·T·Ú­Ÿ\ÞLŸµ\ì\ÍLð\æ\nh8\Úö[/qs––\â\ÏÿV*>\Õj\ÕQØ’PT\Ø&\Ø\à@Dc,•¥gú\ÐnIþ;Ê¬o.Áh:Z­ð¸V¼)\çLLÁÛ“Ž\'?N£,/F\Ñq?#U„7™\ÊG¸ø\Õñù(,¢\ï\è+ž\"‚\Û…Y©\ZU™\0µ§\É}”-=\\\ÌyŽ5†Å¯Aþ88o[¡=/‚\åð§œWi‚¾¬—w„\Ç\Éuyš›\ß\Ó\Ó \ÄKÕ§¤,\åL\ïs\Z~K\×Å§¤º„ûZ„¦ø\îxi\ÎQb\éqŠÁŒÕ¥µ\ÛY \Ã\à[–\î~M¼oaV\Ë[2{¿‘\ç\âö1Š¬¦j\Çq-\Ín²*š\\\å\Ð7·\Îf\Ú\Ô\Ï\éC”Àš\Úf•7µÎ¡mj“Í´©%1XK›œò†V´\í¬s™6“U¦k½\Ôpq\Ñ[N£”vF€³$³£\â\ä¤J\î\Ç+\èú\ß\æWd·Ÿ¿\íA›:$¨†Ú®\r\æ¾V\ÖTÙµz®\Êj6T\Ò\Ñÿl¨\Ènÿl¨š‰?*GfÀ\áW›“\åŸ«\é\çÓ²±§\ÕÍ±+G\Ø±ˆ\×+\ëƒ1¹;Žyañ\ä\Ì\Ï(!Ç#^\'rZ\Üö\èƒ\ZE\ØP«´U”8Â“2e	ûÙ’\'§«°\Ö\Ë.\Ê\ÚV¤K¨©Ô‚»“Ž.½¶-\ä‚q\å7ˆ\Éxñ\ÃÆŒŠ6^ü°A£¢¢†)£nµ²\âV\\¢üÊŒœ|W\ç¶0©W„>\ë\ê:<\ãS\å=W7“/4\ë%±Ì´’\è,?ƒ‡>5tÑ©Ë».98˜JüŒF\nš\á¨¼h\Ú}”\Ö!\Õ\Æýpú–*\ï)Z’¹÷yF\Õ,Q°‰ƒdË©Ž\Äø\Ì:\ÃV\å@•w0ž\Õ!œ\ÝxF2²fZGc+£\Å\ÏPŽýŠ\çi,\å›»\nÐ”w¹\ßYð—°^°eoGb|\îÞ \'0Qø\ícúen¹|]E\á·R°‰Ì–ho7›\Ü\ïÕ¹± GaA6èñ;\Êó4Œª¡:±\ã*Ý€O\Ébb\â\Å\Ú+›b·\é<¬Q¹­Ák\Ä\áô®\ÃÀúºë„¾¾\Î\n®bŸ\î®\â29ÁŒ,\Ðä¨Š\ÆP^û\åa°\à\Ì\Íýo=P\é\Å\å\r>VEƒ()ø}J”„\Ñ*ˆ\r:\Â\Ð\îv¤AÊ¦v•²)\'­6F\ç\Öt•2\Õñ\ï`F€Ua.@€GòhZ\ì¼\Ý\Ûã§¼‚2•<ð­ %\ë\Ûxp’ñ\0\Ò.\"Æ¦€$ŒY¤uu\0#jð\é¨bp\é\'«e—Ÿ¦£‚T5d;\"\î$aôtR\Ä\Ô\ã‘:(ˆ m\ã\Ûl9U\Ê. J$¡¥­ð*e{[F€¬2ÚºT\ë…^\'´\Ì>®‚j		\Ù˜?°\ê·\Ét\æ#C(f‹\"L\Õ\Ì.À‹\ÑJ£\àôV,4\Ò.@¦Š\â]-\Óy+(\íg™¹…¬,o{\n‡\ã­#¼kÿ˜\Ú7\Ç dv\Z\×o§šÇj Ž\ÎÉ¸3\Å\Ü9°fDØºŠ6¢Ù£¡L0»ƒ3ƒ.X}v»:M°ƒ\Ù×©{1\ê\ÎN=t;²·SD¹‚	4i\È+ˆ\Ünu„\Ùr›[„ª„u@\äH#:ˆZ	«|´h8Ó±*ø®  \Ñ\Çqµ\âhjUÁ4…<Ž½<€Œ)…<ðÒŠ (ˆ0!nU¸‰~À\é \'£\àP\äBÐ°>t\Å °”s		G4\Ê9©\\©b$ *\\e\ãñ\ìÇŸ3\Ì5ºÁ8 ÚµYL\ßóÀ¦g	¤´¥\çv@¯vûCñCn q¨q>•ˆ\Ä\Æ\Ïo¸R\ÛT)–@\Z°U\0mœ}¡\0`=·\r ŒË± \ë\Ý(\0¥9¶€\Ò,\Ù9€\Ö>\Þ\Ðñg¾·\rž´§ùø\Z¥’]À&Å]ƒ&\Ðkˆ\rS.)´e^’ðS\Ç`nz²\\›µx|Ü›õnª¾P>7\Ê\Ýù6>?¤.‚D\Óx\Æm»vp\ë+ºúÀ†L5nü5x„§ö’¡\è.Õƒ´÷N…O˜—•\Íý²\rôP*_,=\'\Ò\Þ_\ævR¶@\Î\È\\‘;Mj9\'\Ü\á}¢Ö¾x¸LKôNV½\\:¹++Ÿ\ÎyË¬\Æ\'o<+Yt”\Ä\ç¨DO\ë\0ù³Cn¦\Òdú\ÂS\é$\ÒÝ¢\ÊiuWz’\nR \"\ß!³„®3úöõ.©¢&vBMOHBÁ \rjn±·¼z²Í•R$uI¨¡\Õj\ãh\Ð7<\Z\"\ìYE°\ßGkˆ²‹¹ˆ(¯¥iˆ6\á\Õ9B\Ü~È \Çm\0Ae—›“W²m°?%\Ù\æ¼\ÐkiP</dZ¹¦\ÎV´‹j\èWk†!·\Õb¢d…(y‡’]dúº^J¥·Œºð5ôBƒUMh>x\Øõ£{?–\ç—G\Þ6«ˆ?²Ö«	\r\Îñƒ\ìBn\èý Ø¾(=¡\è.1ë±šGJß§aY\Å{\Ø(˜¥q\ÇvK\î#`ŒSr?\Zƒ1°\à™\Ò\ÅC$©À.!´8…’Š\ÐDU\â	\â;´	žM\ã(\ÂB\î*Bw¥W\Õ\0“;‡€8nÇ›[\Í\ä“8)°m\ç\Ýhh;\Ï{&|¨wX•@8g\Í\çeCvNÐ»\rþ9a2¯a¡S\ïa\ëÄ¾[\Ò\ØZ\Åmb@\\\Z}½R½«C\Ò\ÌX™¡±3¾döÁF#c\ÇG\æi5!\ë&­l§\ÄF­t?\Èý¬šEbcTÿ“Pô*\Ï	e%\Õz…m%\Ñþf­\à‚\Â’ #Ø”;3EòŸg\Ô\ÚOy1/°÷#:\ÙŒ‚Y\0›¾¡n\ÙK\0N	Œ\ÓÔ½¢\Í\Ó\Ü8D›’I \Õv\Æ;—\Ús=—DRÊž16RN\\b\ì™$\\j;\ãKÍŒ\Ö3I`¥£\ìm§\ã\Ä\"Ú¦f\\\Ñ\rÜ«e -‰Gkf\0¤§xða14\Z\Ñ!`°¡\â\Ïvm\ÇJm\Ù\àÓ¶a´Ñ’š0- ;&ô\'?B7\áw\áDo‰ófwa·\ß0\åÝ…}\Êc!\Ý\í8ô~Üž;\Þ\Ï}\Ú8¨\Ý\Ýk—v0›‡h4f8KˆV\Å:ˆ\ëðˆmBy^%y_²ù2™¯‚°<¿ú\Ã|:yZ\ÆI~8},ŠÕ‡\Ù,¯H\ç{\Ë\îÍ0]Î‚E:{÷ö\íŸgûû³eMcR<foŠ»šŠ4“Zž\ì/Põ$\âIPwAüñx±\ä²	oš%\×(m•\Üe2?|\í\íJ[¤ü»‰†IÅ™”ž˜õ¼<\Å\Ý[–·ûUho‘bÌ—Å¥\ça!Tö|Xy»œ\Æ\ëeˆ\ë!§G[Ò‘\Õ6v\nŠUxUŽZ÷N©¬»ü‹¦\Ô…Sbž‡$\É1Ipšmxa’XûÍˆ[£L\ÊzÂ¿\"\Ì[t–ü¥ü ©	’\íhWc\Ä\Ût8õ³þÞŸ¤!M•ünC\í\åRŠuš1nú\î\äô‰pºD\Ìe’\"ñN\ë$\ÊWi\ÝEqT¾@\Òc’\à4‰hü”Œ\é?ÐŠ\nžPóÍ¨—]P~¦‹\Ýwþñ›© ¾\ÛP«Bó\0f0\à`\\£€—÷õG#:/µ3ŽPó\ÕL2„Z\\DI\Ý7^00\É´ƒ\'%\í>\Ù`¤b„V—Éœc•`Å‡\ë4]\n\ä#j\Å\å.N·\æ—,]¯®PºŠ6°iTƒ\'9U&\Í\0±\äKh\ÉczŸ…\Ô>\Za‰zO‚RP\ÈczlÛˆ\ÏZ\Åb•\nq—²&‹Võ^Ÿ\Ò3\ÄYø:fŒ\Z\Ë\ê\Ê3NYf60¬ú\rR\ÎU\Û4¨n\ÞÒ°P\Í\åEe<oK°+ù>‚\çut+†\r\Ò˜’\na9µW}÷U\ß}\Õw´^õ\ÝW}÷U\ß}\Õw-¨V\ï\Ï\ä\"­’I‚\Óü-ˆ£\ÅM3\ç^\Ä\ç­\ÓùC¦ªŸ\Än\Ë@”R/\Í\ìrl¨øyT#ýª€\ç}K¦i²Ø–rZe‰kT®\×9ƒt:ÅŽ\"`È¾M\ÃÃ„°ŸfÀ\'L|ìƒšŠ\Ë\Â\Õ	\Æô¤\È¥›ÁxŽ*?Z¾\Å\\¢\ÝjYS%’\Ìhoµ±4‰$š\Õûc\n\ÂDºÁ\n[–<úD\ÕÓ«—«\æŸZi\ÅYŒ\ê@Ô›Cu¤|hcBF\ì{\åp3*ò0µ¸$‘l1ö&\Élö˜›[n\Ö$+N\ëlµ\èH+F‹ˆK\Ì˜\"b±b\Ì<ß¶ûX\Í\Îòn+À@›LØ½=‡~TU®(\Ë6\Í\'Ç‰d7ƒŒ¦Ž5K¨bY¨Wdpg†š*î³’f¥\àpäš¯F”ø¯\î£Á4\Ó\äl°\Ç\á\Ä\çm‚¯Þ“\Ç|UpÚ‘\èh¦x^a^·Ô›5\á\å„\ç..ˆ’\å¥\Çm)^‚\Ó)72”X\î‹wH`\Ê\ÜC ˜¢\âÄ˜ƒJ]|\É\È\ãF†—\r	\ï\ã>>]\Øû1’“qZd«kn¥Û¾X@R‘½b°±1\ã-\ì\ÇL\ç¯3=	\é=œ †\"uˆ±(§\Þ;ó4e\á›T”jGþÌü¾5\èyC¡ñ6\0BKaY[9Eð—ø§õ9‘\ê¿\ZÙœe(g\ÎR»›µ\Õ/\ÃR~G_ñ\È1©“kµ€¥\Ô|2¤qœ&÷Q¶dr\Ø4“³\ç<ÿ=\Í¿ù#{ðL¦\Ø4²i^Ë•Xl5I­|Lôe½¼c\rÊ¨+zŽŠs\ì„~OOƒ\ÏÿOIy+ÀP\çS\rf`\Z~K\×Å§¤:eûZ0G‚dÚ‚6³i&³)\ÄsúC-ª\ãkvNq\ÉCúül>),`£P\ÖA\r\Ý4J	a–#?\ni\Õd^ó >Òª®Äš\ï[	$ið \Õa,Ý€$¡!—78;þö=\âL…™$#} *ó7ô\Ìi}\ÂPpÝ n+st÷¦ñJ‚:\ëÁPºÃˆ£#\ï­\Ã\î\Þ\ÚÐ¯ü~k‹ðØ»ºÛ£¯Pk0yQ¹v\í\Óð\Í?¦üxS¼t»õ¡ü|úùöQó\éf\ë£6´”¡CZH¢2\ã½j\Ã0KI/\ÈÜ¼\Êø2[E€Xž‘\ÍJª\Ç3ZJŽ\í•>\'\á\Í&Y\ÞZ6¢‰1B4ñrtë¤˜lÍ‘[\"	˜Š°\äºl	ó	P\è8J¬.\Ç]Â…Àa³t’¬ù\Òý\îB\à4\ág¨¸8U\Ë(7U\×ò&¦\Î2´‘\Ã\é\ÅóüŸñ^™¾WýyG¨<ÿhs\\It\Ùp“~C\É\áôÇ½?M\'Gq\äu¢&\Ò\Îö™P\èý÷e\è´X\Î\Ø\â\æ|J*y¾ˆ\á{\Ê\Ù\ÅJ&\ÜÞ±C\ÜoÿJ\Å3–ÂJ€\Öo D%Ÿ«9Œ\Õ(”•«\ÛUP(Kú\ítòeWV½‡\Óû \æm!\Øzhí®®(ùd\ác	^³9\Ãú\Û\Ó\áô?«\Ò&gÿ~Kx3¹\Ì0>L\ÞNþk:¹ž>£\ä¡x<œ\î¿û™lYõŽ®a]8¢÷f$ú3µšDœ\â\ÖT¯ô˜\Ña\åÝˆµ*°°W°!{@Lø{¡Õº[#½„\ÝX\Ìz{ý^	¯\ÉÝ¥il<t„;°ýø3>À5¡RTQ‰õ«…Q^\ÉÔ·Æ´‰}•õ@¶[*k\äNÊš\éøk\Ïk¡Ÿ¯ž:7_õ¾D>½\r–0€–ALAiðR\'\Â\É\ï\ìk\ê=|ª‰òúõÃ›\Æ\×IHÒž½Ö¤Xg^{BŒÿ®ý\\\'O\0\çE4\áFˆ\Úù{!\å\Þ&‰­¨	QòDB©´Šwü0U¾\ßÕ«¬d\Ù5\Ö\Æj\ß^¦“»N‚\n@\×\íKÒš®a†TÁ\Ò\r¢\ZS* j¯Z\àh0\"*5\ÚEµh¨Â½*‚òüªjy£\Ò\ÞL{\ïL¤\n\Â(AtA%Æ™Ò«H\"+\è\Z\ëPB\ï+˜*e£B\r¯:‰44€\æÓ—t\Ò|$ª—y7Z\×1\ã^\Ô:A»š¹­\0²¡ö¶¸–:\îv‚~ƒ\0ƒ†#,¨P+n¨…Wq\ÇUÅNÅG\Å^.ˆ\â¦8¬f\â )Ž\Û66ŠJ™\â2¼:},’]^ý6¹lXlªLÄ¹ð,Ñ¥—\× ¡N”püdW¢€$Šº\ÊøM,-T\Ü‡\Í\Ìö+\è*x¢Y\ÎË‰3¼\Äó¤Ž.÷\Æ\è\ï»N¾&–‰sw|\ßnùCQd——añzSWÖ‡²þº…tÂ§8°Xh\Ê\ãx€„§D&ùW;\È\è nc\åqG7´ø‘‡\ØCòô&hr+2\Ðè‘£·k+;]þU}~39Ë¿&;&7˜¡ŒmÛ»ò¥Æ«CfÀø.s\ÔdG\Ã\Ð“ƒµ ™ h„\Û^X´¦.\ê\Ð\ZðÈªkÀFVï„¥:eg¡\Ã\Ñ|‚ˆ\Î\á}ó¬Œq±SÂŽˆ\á\Æ\ï>:†³\ÙK\Ã\Ë\å»\\* t«\n2ôª\ãc(Æ”Y*ÀD‰x.»*<†™¸Ž\ÃK†\ÄðF\Ê\Óø¸\Ä‘.|w\á\ÐRA„û“t\Ö¾F·%7¨‡	M\ì\ì\Ö{»7\"ð…£!\rôbÐ½$^šð‚Wªð`\Õ_:¦ež•ªžioÐ¶ú%$v\Ä\ÎJ˜­u\'\Ól|\0-\ã)8¶0X\âh0T\É\ãG\è\Ñ%±\ïe›ó\Ç{QÖ²>íœ½ytxô2ñ\æ\Ña\íe7\ÅP‡ppvB–\Ë[;€l\Çý˜Ž\Æ\Ù\ÍP\Ãb0;¶c8Ç¾+”\r)§Aa*u+¾«\Å;þ\êN¡7¼l:S\ÆD\è®›\\¬\ã\"*•E\\?\Ör¸h—\É	ŠQ&Ga4\á8\È\Ã`Á³±Œ7!k\ÐÂ‹lŽ8Ý¶¸*1\êPiœ\åq^Š‚ˆªs•EI­‚˜\á“OfÙƒ³Ž0›r‚V\åŸª\Þ;W\ß\Õ\ÂƒŽ)Tø5Úšúo\çk\Ñ%v{»··\Ï\r$G©ŽÛ¡§¶³˜ û	©UûÀ\ÝX€ ]v@ò°NLKè´—ƒ-\Í+½[)jª6ßž+_+Œ¬pHÿ?¡Kj\ÍP\Ñ_ŠªG\0˜q 9R}\éB2Q:Kÿu%ŠÛ›	[#›ž\0\'	O%vMT5¸\n¥-hSû¦Q\'\n·en;0·	!g‡¸‹¹~z+$·mr8Ÿ`\Þ}~A’LørKEnð-Dco<ô@·þ¤Tø\Ù$º\Õ6®\Ð\á\ÝY¶$1£B\ÅD¬lZv\êqŒ\ã\è%h\ß\Þ\Ê\ÃB)_Yv/k†EŒzx\Ä)«t­\ÛN‰:%\Î:\'&fdû\ïc!M· ûC“\â=gCO-S<ù©q‘þO·‚‡8‰¡£\\¥\È1¤F\çB$jOŸ8À4;CÙŒ`x¬\êü4¸“Àþx@2\ÖK…W.\Í\èš\Ïð\äÁHôo\ÓzÇ‰\Ù!ƒúÝ£\ÍÀDð\n£ˆŒ jCz™8jR_\n\Ô \Ï]\Zønnl¢—\Zwlµ•¾lM\êK›\ìI\Ì-[Ù‘]\ÅÚ¦Ô¬\r#\r¬im\Ð\Ä\Î·j\à1”0˜“ˆ¢>Y‰—=Û—]wA±“ R4 —‘\Ä	Ÿ8Š„\Ü-@«Y-\äUÜ Ö°pnþX  Î‰‰Iÿq\ìöE­üòJñ²°‰—õ\ÏC\nk\ßü-¹ù“[xó°-\È\Û\ÔÝƒ%ú¶\àò¡ƒ_g]¶\Õ\"\ÎÈ´m‡Å™‘í˜ºN\ï úD?ñ\Ú91Ï±r8jžòe%\ït\Òû0ñÇ¹õ£®‡\Ó\Å]ŠÇ¼v„\" ù=\n]K\r®’>ITG? Ut·ªÒšºª\n»\Ûf@½òú”õÀ\è‹=«ø±f› \'¨›Ýš!\êi—(\élÿ¢´¾\"q\rR\Ò&WŽ›G\Ý„ô÷Â¢zûTIM†0\Ó\è\ëC®6:YT]½Ó­\ÏÖ •õ‡V\Ò\nû,òJ\Û<úŠùý)W1ŸET1›K_5wd\Ã\Õ\Ì\åP÷ØŒ\ÍÍ‡’\ÏMuµÍ½I\Ý\Í¸²\î&º\î\æšÀÕ²Í½n\0d\å„m„Õ·¼WÇ¸\ÆõI¢ú\ÛTÀºÀ\Û\î\Ëp~‘ýô®@\ßøµœss\0÷U¹Bˆ2Iš\ÒflÄ¸¶ª‘z\Å\ìL\'D\Å\Ò)6idu`r)Áõ\ß8ýO\çKMg`µsº\ë\0¶´Æš3°€\\ÿ\Ý?\'„õe\í:*tr÷W\ï\ë«\Û\"õ´-O§ycï©`‚\ÆuS²ôc‹ñ\Z‰SgCz†³{ªzZ÷_U\ÒA&\Öi\ZR\é\ì™E\ÍÁ—)‹D\çežð3>ƒkdb…óH\ãº\å\r%üZ\Û2P¶RZuûV#6$~ElS\Ù6BÖ‡\á\Ö\Ò\ÓE=Š\ÓS·Ž1f\×eOGYþ\Ä;p†C4·g\×\r¼\Ò\éÀm\\7\Ï\Ú\Î]\Ì…-<\Ûöt£mzÿ]\Í\0\Ý4²\è¤À[\ÐM½6\ÕP\Ñ\ÉJ\Õb:A\ÑU\Ùq	E¥Otf‚\ÂbXÀ¨}±\êÆž\ê—Y\Õa‹¡f4\ç\0F,ha‚ôœ‡H“\ê)\íÁŒž)\"K\ÏÁ™B@qLiR½3¥9’\ÔóD`88K6 G€öpz†\Ù\Ö\r\ÂP£ƒFuY‰‘XÏŸu\Ûò^gÓ¤4 #ø\Ã\'\î$ûA¶Hf›\Û0I®ø‰>÷¬”\ÆR4¼n:@¦3\ÆL‚!8\è\Ýe\Ôy«­`KŸk¤À(:\Û\Æ>\íº´ƒY}\Â\ß|À?‹4\ÐEº@q^}=˜]¯“ò“ú\×	Ê£‡ž\Ä¦™\Ô÷D\Û<g\É}\Ú\Ú`0-j³0a/P`e28ÊŠ\è>œ\\>X%\ÓIõDÉ¹;´8K.\×\Åj]\à.£\å]Lm_J;Uý3®\Í\Í3\à>ºP=˜‹õ\á\Ë\ä\ã:Š]»O1i%$J‘&¬z9–E^ýá¹£ô%M€„\Zöuv-7Ã®\Ü.\\&ó\à;²i–\åŸ\ÑC>÷KÈˆ\è‚fûÁI<dÁ2ohô\åñOŒ\á\Åò\é/ÿƒ«Dp\0','6.1.3-40302'),('201811032304140_Job_Offer_new_column_added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\í=]s\Û8’\ïWuÿA¥Ç©¬\';³³){·;ž±7Ž}–3{û\ä¢)\Øf…\"µ$•±\ë\ê~\Ù=\ÜOº¿p\0?ñR’×•‡X\Ðht7\Z\r »ñÿó¿}ZÆ“\ï(Ë£49œ\îï½NP¦‹(y8œ®‹û?ü<ý\ë_þý\ß>-–O“ßšz\ïI=\Ü2\É§E±ú0›\å\á#Zù\Þ2\n³4Oï‹½0]Î‚E:{÷ö\íŸgûû3„AL1¬\É\ä\àz\Ñ•?ð\Ï\ã4	ÑªXñEº@q^\Ç%ó\ê\äK°Dù*\Ñ\áô\×(Ch¯ª8\ÅQ€‘˜£ø~:	’$-‚£ø\ákŽ\æE–&óþ\Ä7\Ï+„\ë\ÝqŽj\Ô?tÕ¡£xûŽŒb\Ö5l@…\ë¼H—–\0÷\ß\×d™ñÍˆ;mÉ†	÷	¸x&£.‰w8=’E´\n<z¾·\ÇqFjr\Ä\Ýk›¼™ToZ	À‚Bþ½™¯\ãb¡\Ã­‹,ˆ\ßL®\Öwqþ\r=ß¤\ßPr˜¬\ã˜F£†Ë˜ø\ÓU–®PV<_£{Ý³\Åt2c\Ìxm{Y\ãjdgIñþ\Ýtò£\ÜÅ¨•Š\nó\"\Í\Ð/(An¹¸\nŠe˜‘gT\ÒR@ƒ\ëô(_}A–»¬\ë‹ žH\Ó\ÉEðô%\Å#žb\ï~žNN£\'´h¾Ô˜|M\"<\ïp£\"[#cgx–>\Ã\Ó7\"¸‘¿4\Ø\á?=`‡\ÞG1ºŠÂ¯Y<xo˜e”µ\Ý`M°\×|\Øm¤ªA?=\á_\æ:Kþ‚,wn}‘&Å£]ó³þÞŸ¤\á\à\îº:Aùð\Ý\Õ\âƒuMt¡V\Æ?¦iŒ‚Äš«ó\"¸¿\' ¡¾Z\Â;‰òUšDwQ\\j…\n\æ	\Ö7\Ñ\Ò\ÚqŠ\×\Â\Ìv*\ã®-›`´1\Ã\ÂÂ²\Ù<ˆƒ\ìY$õÙ–m\Ó\Ë\âe£ˆ^®Q\Ð[”0˜¿gQú\Â!S?Ä‹\ÌE”T\Ôh\Å…\Ñ2À:ó*\Ã\ÕF^0\æa@€\ËV0`OÁ\ÓÀ=\Íc„V—\É\Ü/y®\Óti¯V\ë\Û7\Æ=þ’¥\ë\ÕJW±\Ýb€ûsmzœ!brœ\Åðks\Ý\×\Ç\çÁ{úºZŒ6ªº¯Fu´XD\Ä\\b¢¸²hU\Ù\ë¾{ý|J»”\ëÿ4øž®‰:O\ï.\ï\ï1:®Q\\V\Í£U­Ÿ[øV\Ö\à4K—\×iL›Ê’z·sü!$\ÌK•o‚\ìð\à–\×\èŸk”òt\å·\ÔÞ¥\Ã\\V\Þ\"\Ñ`,­\Ô‹\Æô`\Öí˜´û¨fÀðmT\Ób»¨¦k—M\Ýv¬=\î\ÓÜAý/WqúA{s»\n‡\åP·\Í\èNºï°„÷ºy\Ñ[0²‰ýÀ\ä[\ç\Æ\ë\Þ\åu\ï²{wx€¦\Ý\Ý\Ø\Â\ÒmwlW¼´wò\Çþ:¶Do;œu\âoA-n¢8¶‡¤³{K»\nÿ\äß”\ÆoY\éV¬\ÍXÀòJ‚á®®)³Ú­m\á\Zš½I\\7Ü€e\ìbl	­\ïq\Ì\ášS}Á×ˆ˜-ùð‡tg›Þ¶·SD3\Ù\ë:·m]qªsU”¯\×wš[O\ï\rMkJLö»0	ßª\ínõ(\×zu_ƒN \Éžc÷5\ÊI¥Y3ZoWA,…-\nõ\ÕAÃ–­±\í²F—-¾Q\Ù\è²\ä>8‰p¯x.©æ¦¥ö­·¸ÁjE\ÎqdÇ¦Uº~UQ¦uõ„CHme\Ùa¤n(óµ\Þl¬€¶•˜%„)“­l…^‹†l\Ð®\'’Ö¯V\âPV™\ëÑ“µ\ãeŠ	7ù\èjü\Ô7VöO\Ýf3&PÝ¹£DµKŽ-¶·¨^\âa„’É›\ÙQ÷y¾.þ$‹™úv\ÐB™0,«Hq\Ã\ê°\"\Å\îW¦¦\Ã#ª¡…\n[®¢y¾v_%k¥]7£Võ\é\ÈÁX[ÁcŒ\àC\Úÿ\Âƒ*w\\c\à<\Ê}\ÍY˜&g\Ë\àa\0.˜.¥>¸ULÿ[\Ýl¿õ6¹Ye\ábH½žk\Ä\Zl±½žñnðŒ—•d\Å)¯¼’f-öz\Ò\Û\ÜÀgh\Ób“¾Ú° ðk‘\ÑD¶-(\âú…xö\ëÏ¥vLG\áñ\\ju9\ÒjQ]q+oÑ©omEA…\ëk;l\r5\ÞÀm_\ç2`±T\ì¹\Ö\ß\×\Æ&löV\Ö`\Óh3@z\Ë\ã°„\ï˜|ž¬U}Ž²+ófpC»,\å«!ômU‰1\ê˜2™-\ÇV\è5³\ZÁ °uS\ë¢\r%®ì’½¦\á^ò4\Ã\à~O³o{4\Ä7p»nj¾ƒN\Í÷ûw÷\ïþñ§`ñþ§?¢÷?Ž¿]\ë°ki4&\ä»òÒ«R–‰*fšß·uµNœ\ÅRA %U¼ˆ4\å_¬¨\Û/\Ú\Í\Öaf®J\ä2¼…¯[Î†\ßaûK\Ü…\Ä\"{þbŒ•«\ÔF\á[nÀP\áQp‘Œ±L–Ž\è›GIþ;Êœ]dÀ\Òt´Za¾–´!ó.L\\Ã;üOœFY^Œb\ã~F\ê\èh±\ÈP>‚‡Õ¨\É:Ž\Â\"úŽ¾\â)\"¹\Æ6¹2‘A¨\É\è\å8M\î£l\éÁ \Èsl1,~\rò\ÇÁi\Û(\íy,‡¿N»zLôe½¼£ŽG\è\Ëkn~OOƒ/UŸÒª7¼\Ïiø-]Ÿ’ò \ëk\Ú\ÊwÀ:Gaˆµ\Ç)f´(pû™r\r¾ei9\äûnµ¼¥«wûu-a£©j{<w\Ñˆv]UƒrYÃŒnU\Í\Õ\æ¨†-U[p[ÉˆsW\Ó\í\Ï\éC”Àpnªª®j±­«Ù¢J€Á0­kª-+ñ¬jÙ¢\É\ï*s„¸¼\é­`+ xZ»A\é•‚>F(gœÿÓ‰\ìöOl»£Ä¦\Î6Jö1»\ÌÁ®IOeÜ‡ç®œfC©ýÏ†\ìöÏ†Müù{T^º\Î\ìš\Ê<¨¾ü8\Ð<\ç8\ÌÆž\Ì0\Ç\î|\àz2$_¯œÏ‹\ä\àv\îik<sü¤nµ?Z…œbŽx*Xq\Ûc\ZaK«\Ò\ÕP\îA”-IøÏŽ4À\Ø\Ýà­—”–k\Ï\Îò\Ó8x\è²pC\ÕZÕ¾¯\Þ\ÂâŽ¡\Ä\Ïxz\ÐÓ\åñ\"gL5\Þ¹k,\í©\Ã\é[A˜º§hI\×\Þ	U‘DC&*”+¥Z\ã\ë7XF‘“&Íª$\ÖýhF¥rr&Zc\"Fò¯\Å\ÏPŠýŠ\çr¬¤_»LQ•·µ\ß9Ð—ºs%ob|\êÞ \'°0?¢ð\Û\Çô	J\\rª{…ßˆb“˜oÑœ•×µ\ß\ëk\ãE…\Ð!ü;\Êó4ŒJ†°þ»òx[O\Ébb|\ÛÝ™Ê£½/0[#²\Ú\à5\âpúƒ0``\í)O\×_\ë<\Ïv±?\å\Ñ\Ë\ä²@“£2‰9D\Î\Ã`!š;˜šö¶_I>\ä>(Ç‚%…h\ìFI­‚\Øb •·¡<‘	Aµ\í”/9iT°{c\Óv\Ê\ÔD¿ƒ%¬zò\Z¨\äH\äÀ(;o÷ö\Ä)¯—JQðDK5¶ñ\ÄIEB\"M	’4Õ’†\ëú¼Kó\Ùdhp\í§\êe—Ÿa£\n©Že;¢\î\ÙÿL¤I(J\ê BÁM.\ßv³¨—°*\É”Erm\'yU’§?.#ˆ¬6ß¼\Ò\ê%Ÿ§¬\Ì.„…i	IZ˜?ð\æ·\ÍtZhf‹&»ƒf›—\Æj¥\Ñ$\ÍPz+\Z\å SEó²˜\í¼U2\Ê\ã,3·•E’$€‘\Ãñ\Ö1#Á˜Ö·@ f\î/hÂ¸{õ<Žh\Ñr\0\ê\èœN—\ãQÍSyvFÛ¾ªB{4)“°bw\ä\ÌbGgÊ± “>·]!GÃŽ\ì\ëô£ug§gÝŽ\ì\í4É¹`\nM™©¢7‡[\ÙÁú\Í-JUA: \ä(+öPµ\nRùÀhq\Ö\'GP	0SB\',]b\Z¸þ…%Xp±5\\\èc\Þ\r\ë\Ò0˜)1Ð´\Ö$~°\ß3»Na5e ³D\'\ÈjÖª)\Ñ‰q\Ö6EF‘+ò0ü\î\ÒwŒµ¼È“$\èmzkˆ”&@%­\Îb»nHi\à‹DP’X@\Ån]–Ž\ál®‹Q\äP“\Û@‚X—±`±TS	\"=¥QM	H\çò#	¢&RL\ÅwH\ØX\ÇÁ±\Ñ\êªw\æv(\î$dæ‘ lf’@`ý|·Côªh?°(p¡`‘H\Zb*±Ž“\ZG\\ŠmBT’@\Ø*\í<¡2 ‰öJ3Š\á¢ö{\Æ´©I¡\ØòQ¥\Û6y¹pV\Å\ä­ÃºF™¼,\Å60yY’\ì\Ü\ä­â‡¡üç‚‰·M<\Ù(\æñ­m-¹6 ›=vM4A@Ù°\rRŠ¶*~\ê\Ø3½\ßJ\éC®\í0_\î\íx½›\ÛhtX?!T‡Šm|~(\Ã\Ï(\Ô\ÄX¹m»;\í7Vˆ\èšsý\r0\ÕTr\ãa\ï3®ŠS\Äm\nÜ¢@\ë†{rG\n\Ëx!!°	“¢Žm\Ê\ëXY^¸	ð9*$yŠº\0Iñ¸F˜#,˜\î\ÆH„\Ò]¸\0´7\ÌjX\í5¬¤„,.EJ,iX‘¿.;»\Åö’\ÏHÁ=µøpX*Û’\0­\Û\îšq«¯\"©„2—;Xu‚\"{2o\0\Â\Û\ï:€o\0\Ê+\ZPq1\0­³!€[\Íb\ÄM¾/\í\ë3°M’+-\Øz/µ2”‰*‹\ë“\Ò\Ûz5Ñ½›C5Ñ¨¹Cc’€‚[¢(µ—°ŒY†7R=tJƒ7LX:hØŽ£}X¤›PG=¾ªŒ>*\ìõ€\'ƒ4ðKN\rsŒ?m”;$n=\Ö\ÓH6,©\Ä\è#\r±¡J\Òa©ƒ•$ƒQJcdÁši\Ã_dš\n.\Ã\êHÀ­©(KT§ž !2ž¸I›\äµW© ‚hxP‡Ñ°C\éŒE½€©g@w£Í­aò)8x\Ü\Å–\ÆÁ‹‘ƒ)\æi]­ œó¡*–SÁý˜N…H\Økô°u\n\âû®	l­61 *¾^\éž;6I\Ö[#*\'\ì\Þò¥ò¶\âŒ\rïœ‰t´ðýe†óþ¥†Km{5T„ùû\Â\ØÓ‡|Ú…\ß\ä,‘v‘·¤Î˜+;÷(–t*j¼RùI\"÷KeÑ§6ôSN\îO\ê_©\Ë\ÞS)arŽd°×¸GRø\×g)\Z*h¼)8’ó™\ÞD\Ñ%k‰u\Ø\Ó\ÞK\\ö¨AÖŒ\Ñ\à–7”!¨\Ê ”Ä¿L?*\ÖÃ¬…Xo0…H5ƒñN%J1š	¥ðsÒŽOôt\êE.Ñ›	¢\å=ª9+4SI\æñ¤\çóÔ‹>œ’BœšÁx§R­ú\ÌD’x\Ý\0[¼ˆõ‘W‡C“¼\Z	\è\â\â\Ñ;„c€ò\ä\ÎK\'“\Æ*ñ>Ä•WzOŸ¾\n£qK\é’@a ¹t³®I¦\Û^R·e³yøˆ–Aý\á`†«„hU¬ƒ¸Ê±\Ù‹…(yÈ»–õ—\É|„\ä \ïó\é\äi\'ù\áô±(Vf³¼\ï-\Û|úaºœ‹tö\î\í\Û?\Ïö÷g\Ë\n\Æ,dt\Z¥\ÞöT¤Yð€¸Rr²@\å+m\'A\Ü$ƒ\èñb)T“^\É+®§š.…[w‘\Õ\ÍUÓ„ü]§Te’•*;Zž\â\á-‰\ËD™t\\fñ‰mq\ëyH\ÒÌª^4\"n\Çi¼^&€\ä0jx¬\'\rP\ïã¤X\æ\è µ_\áH\ß\ä/R÷‰{±Ž\ÇÁa69ªi`\Í7+j	„²iÿ\é	ÿŠ0m\ÑYò½EC“»Á.\Ók€7\åp\ègü!½?IC*ý\Ý\ZyR\\±*³–›\ßð0\ï#´JNW‡K%\î¦!RŸ\á°N¢|•&\Ñ]G\ä\Ý\ZW‡Y\ß>:¦ûl÷-\0ª¿Y²È¢°\à!\Ñ\ß-\èO%g@}wV\æ\ÏPZÁ‚‚ArQ\ßW­\àür\n€\ê¯vš!,\Ð\â\"Jª±‰Š+v€<iaw\ÅœŠZ]&sL®\Ót)Ñl©t\ÛR8dŒ\Í/Yº^]¡tsd\à\Ë, Oj¨\\™…\Äfˆ<\ÏrBKX\Ãûø,…ö\ÑJ–¾®rÜ˜kx<n\Ôg«b±ˆˆA\ÄD\×dÑªÚ›1v†¼Š\Ø\ÇÁŒ3cy[y&\Ë\Ü†7¿AÆ¹\î¶j›70LsuSÍ›ü\nE‡sð¼J‘\Æ²ƒAga´‡&³ˆ\ZÚ«½ûj\ï¾Ú»\0X¯öî«½ûj\ï¾Ú»P\Ïòò£ü‘×½L…>o\Z‰V*W‡ù[G‹›(\æ\ÎÑ¨\Ï[gCj<µlMI…Ãœ…E©„ ^\êù\å\ÝÒôh–ú5)Ï»Ìªjª„«jX¤\Å5\"\ë\ÎI:[\â°¡Tß¦‰\áaB¸O»	\àSL|\ì«\êŽ\É)FU5<¥d\É\Ê\í\ÄxŽ\Êðec¡\Ðn¹\ÌÉ¡REv0©y˜T‘\ÌòQ<\r`ª\Üb…%-¾Qù\0\ïåª¾\ÃeVZy«>ói_\ÉÚ˜’‘½õ¸i•…ö:\\º‚À¶{\Ód.{\Ö\Í-7\Z\'o‹§‰\ÃvZt”5Ü¢’esÓ¤\Ñ\Öð\Ìóí½\Õ\ì¥\î9\Ì\\\Õ-¸²*\Û4ŸzN$·d5u|˜YR\ËÁ¼¢s\Ðt9Žµ0KG\0Wµ‚$ µ-¦q˜&gË€?^§>o“øšC¨\ìW…^;ŒÁ\ì\Ï+\Ì\ë–zCB­‹€\Êr›\Å^„\ÕM\Ç9\Êñ\ïG\è\ç¾ñ¥\ß\ìuc\ç\ÓSÂ·‡OO	W/Ž\Í-T¸b¯U³\Í\Ø\ä´^ª[i†5­D;‘-±˜ªµ\Èñôm‡\Ì2UT¦˜^öB¥o>Œý%ÊJ^6\Ä1«?Ú„h\î<RƒP\êY‰e`o4o€\ÐPT\ï‚lŒgbH;\ÏLQQ\0ž™A¨¨-Ë¼\É8\02sª¡w!c4LUb=¤*\ÜJ<Ù§¿ot¨õ¡aˆi„\Â0º¶\å.õ\ës \Õ}µò”\ÍP\Î\ÝØ´7aDrG_1\ç8ˆL\Í\å}ÀCª?Y\Â8N“û([ò\Û\r¾\Ì\æ†+\ÏO³Å¯Aþ\È_o\Ñ%žOµnšÁr%W[u‘–i‚¾¬—wü¶”)p‚§ ¨¼†\Åy\Ë\ï\éi\âùÿ)!wt±\Ôb¦\á·t]|J\Ê\Ò×‚;À”;À–\àÌ—\ÙÌ¦\Ï\éS,¢hQnÿù9%[\ì\"­#·ÀžT&úp1(«t³ý,JŒa–#?i‰²hyPŸ-a•N`õ÷­$eŠAª÷$µ¾Á\Õñ·\ï‘p\à\ÈY\Ùe›¿¡gÁ\Z\è\n†\×\rÚ¶ªt\n\Þ,^Ez\è\Þv0\î0\ê\Èÿùù°»·&)·¸\ßÚ„<²)2Y¤‰vi¤­”‰Tac$wˆ\ÊD“™W$¤G·’òÍ’RO|•xóIVc\ËgH±–C\ZK\Óm¢™\ê†N\í‰$!:(ñ%\êª?ŸBÊ¨	—§\Ëñ%…Ï¿D¥X®^t\è®„\ÎJ¨–2!,6\\\"¡F\ÕN\\î«µ¨\âu\åR09Ë¿¬\ãøpzÄ¼§ƒ™ f¡ò4ñU\Ú\å±þ\Òþnó4\Õ9’˜\äM%¡H*¦’@y¯‰OšTU™N\Z»ópzñ<ÿg¼G\Ê÷\Ê?\ã‘\ínS\ã\"H¢{<·n\Òo(9œþ¸÷§\é\ä(Ž‚¼\Ê\çU§ƒúÀ?z\Êµÿž\ä‡B‹\åŒonŸeŠ@\ÉóE,\É1E&#¿lq9¡°ý\ÍD#(\Ý\ÛS\Z\Õx0\ã!\èV\åê¹“ˆÐ¹œö¿ ,\ä‚ù*(\n”%\Ýf:!\ÂHŽ7Zœiûa\rÄª£\ä{…A&y›\ê,Y §\Ã\é•­?L\Îþó–ðfr™aø0y;ù\ï\é\ä\"xúŒ’‡\âñpºÿ\îg\Z³òQ+bm\Î\'jôv º#”\nDœbl\Ê7·\ì\àpg°ý€5^(\ÒQÁXö€zE\ä\îV\Ó\îŒe\ïGb>„\Ý÷;?˜\n\Ü]š\ÆÖ¬£b\Ö\Ýù\ÏªW€ˆª(\"\"\ëW\n£¼Ô©o­aS®MÎŒl¼šœ\Ð\ÎL\Î@\è\ètwZKƒ\Ñû\ÉS‹\ÞCŽº0ô@$\çµ,aZ1#JûX\Ë\n¿s\ï©C¨\'&4\Ým\ê˜ñ^J’\r?w\ÅGœ»\â‚\Ì\Ý\ç:\í„\×s^tÞý\01\Îw^@õ\ÇI\á€l”>\æ\Ò\Z­òc$˜Íª>D1›¬t\Û-\Ö:\Ä]§\Ó{>\n\nÀ\Ö\íZ²–®%Cš€`\í±­i@´W+p¬@¢\Þ´4\á^\rAõ~5´\ÑYo¶£\ï\rd\n\Â AlA˜\î¦c~{Ðœ‹ôõªÚ¨¨\ßp­m1ih \Ì$s1Å†7Ád–À‚\êZö² &œý0š¸F\ëQT\r{\r‚ƒì·–\0‚‡\Úk¸Êµ2ª´Ó0nøL4zŠ“¨ŸT\Èrÿô—3&\åOpT®ŸþÀ¨$?\îzA–\Ô\Çš\"ƒO\Ï\íŸ¸\ÇNJ¹\æ*y\í¡Ì‰rvyõ\Û\ä²\á°9³Q\çR÷°FWzV€”:\Õz@þ©®V¤šö\Õñ›XZþutxb9\ÎÇ‰3¼\ÆódŽÐ‘\Ú\Ö\Ò\ß5\î;ù\êD;½‡\ã\ãˆŠ\æJuùivy–¯0aj\Ûú0\Ö_·\îò)w\\„‰¥\Ú}\Ï,žŠ3„1¬6\ç;ô¢Nö}\Þ\Éx»}öx#\î\íö\Ùã¸Ì¥µ‚h\ç5(€q÷´Y	\å™gÀ\æ™:\Ñ\ÈLSX?þ78túš~üöxv4´¡£\Î3†Ó‰¿ZvAÜ£¹ŸSd\Ð\ä¯òó›\ÉYþ5‰°óarƒ	\ÊÍ¨w?þ\ä\ëÀ@Ÿ\ÓFwUtš¤ª<]‹™M=ü›\í<›AnF\á€MÕ´6`\Î\ê3¿À8kŽ4³Nc@\ÝÙ¥\é¹NR\éc¼\Ói“°ì”²£¸ô£w—¾¥·£^•½Å‹»Ÿ&côP\äšZ%p\Ñð”[*À@©„#}\Î™ü-ýˆ\È%n\é\É^:g‹7P~ˆ&&f\éL’ŠÅ§\0ò	Yz`*IÁâ¾³\ä#‡\àkt\Órƒv˜$\Ê\Îòm—\áFef\éyH@eet/¤Hh“CþI‹+]~°\éo–:3\ÏF	3\nÏ°7)Ð®ö%$¹\É\Îj˜­\r€5l|\0˜‰z]64ZQX†$(½#®U\'z\Î\Ñ.\Û\áE0¦¦õN?oföð>\ÙvŽ}¡©b)•”‚½8bü¹n\å\Êx³PGvÞ¡õ`Hˆö\é\Ç\É\Å:.\"²\Î\àþ±‚ò–\\&\'(Fš…U†ˆ\ã ƒ…HF’¦C…\Ô\rFG^\Å\í¡K,uˆx\ÐE\Ù\é\æEDbZª«,J\Âh\Ä5¸z*aV=¹r0kó%\'hEn“B7ú\ÞÝ·½pl0…\Éu¢—¶ºÿ\ÛùZöÄ›„½\Ý\Û\Û)@ª’”˜¡\í¬L\Ð\ã„ôj|\"r, \ã(v@óð‘&l\ÙË‘-\Ã;\×[©jJœoÏµ\ï}K8+eé¿’tI“Z\Z\ÚcÈ—¦\ë\Ì:U#m¾´ù§›¥û:Ž%\ìÍ¤Ø¨¦€\'S\ä\âR°Ý—nB™’sºô¾i©“\å\Î\Û2·2·	%\ç&qWs\ÝôV•5o\Ûô\Zu>ÁIzûùi2u\ê\Ø-Ua\á[ˆ1\Æ3o<\én1üi#¨.ð³I\ì\×Û¸JGŒ¹\Ù!ÙˆŠUTl\Ô\ÊvH\ËN#p\Ñ;r9zG	Æ—¹·ò0\ÒG\Úw\Êû(‰—.k–\nE›\Î}x‰\Óv?‚\ÐÙ§ù§x\ÞF_Ñ¬\î>Ž\"w’ûB6ƒ/šš\ÔmBÏ¬¤\Îü°Ã–Z\çö5l¡\Æ\Û\ÉÛ”\Îs”¾mRz\í©\ÖV«8«#µVgVgVú>\Ç1×šX9\"GZ­\ä8\Ø}KL[Y:I-©\à\æ¹.<\ÒVˆüô8‚\ÑA‡·’\ç™)\Ö1ñ‰4Ù‚Q\ÄHˆÛ“\á\Ó\"`\êxM¿{Š\à	{h\Ä\áH\Â\ÅGI·VŸZ\Èø\Ð0š¯B™•ƒŒå™½\'!1¿X\î]N\ìŽ\çõ/,nFL$oóú‘´Q½¢RGu\éK5\È#\ÈÓ›¶\îIºñU’•e¿»Rbe\È\Ã\áÛ€ \Èz\Þ­T\ÅP©´R]úR\ä\rò¢ö–k%2]•µM\Ù\ã–4°I¾M‚&\ã\Óm`i„…ðiúSµx)¢\çú0ü.\ì\0RiH\é\Ò	P‘–±p\r¹[­\'µB\Ì\ér6$\á0Ä¼\Ëù\'ö\á\ã6{¤X\ãúMlþªl:\é‚\Ý\ÄÓ‹\ê©\ã\Ã\é\â.\ÅRTE\ÌQ\ç-¢¦e{\é\Îò…Nº\"Y\Ýý´‹öú]\ÙS[C\×a\ë–\0\èWÝŸ¶|yž\È+i5)\Û$5A\Ãl/ùd#mƒm\î>!\É{P‚¶A^\Ë-¾Ž~(`v[n¡Ó®H\Öõž½y€\ÝM‹lh]©bPu…0™\Ùy¡7¶X\Ö]eT›hgu¯ì°«¢î´©c\îX\\È…Ž\Å*²ŽùZ\æ®\ÛV\èY¨¡±™\ëSD-\ë:ún\ë“V›¾\ë³m\ßu}\ßõyŠ%©UV‰ªvR!M\ë‚\ä¡^Àõ‹l[M†\ë6\íò «¤\ÓwŸ\Ê(Ò¯•­\ë„j¢Y4\å^¯Œ±\Í-\"¸\ê›`ù™\Â\í) ò\nü6€:€,?o/.!…P\Çÿð\Ï\érs[·J\ã \å\ã5‡Lû\Z¶\Ì0mÚ³e\ÞH \ìjˆ`ˆ\î•G:Ž-\"$°T¦l\ãQU·Àô´\î¾ê´ƒJ¡³0”ª\Ù3‰jE[\É\\=\É\Ïø¢\Ö)J\ç‘!ºÏ›”ˆmC@\ÕJ\é4\ì[ƒ\ÚP„žñ¨ò8BÖ‡\á\Ö:J\ÏE‰U¿Á3EôŽv¤£,ò½7Gƒ¡8-\ì\ÖMŒ\×Æ¥ô\ã\ë†	\n…\Ð\Ç>„‚(þQŽ¯û¨!‘zwÁÀð:‘@žû\ÖD‚,‹=di£„:\ï\Îh5d\éj\r!)VV…›Na}¡\åjD\ã/Í£ËŸ\×5w\ßõ\Ã5­@ƒ”x\ëJ†iò\é•\Þ\Ü\ÓGw%\Ælf¨ª@JWØ›\Z¯R	1 >¨ú{mjDB\Ä †Ù‘>ˆQŸ\è!ñ²„Ê“KA@\êR\ïD¡Ž\é\ÍtQ8B\Z+u\êÍ™«™\n2o·Á¥ƒ9[¤£.õN”ú¶ÁL‰S\Ö\à$Ù€Bú™	\æ\â\\4A­\îd\ÐU-F\"½x\åJ{“_‡Ö‰†¢X¸\Õ\äoò·¾m\ÙÁ¬º\ç¨?\àŸEš\è\"] 8/¿Ì®\×	y+¤úu‚ò\è¡q€a&(d|?\Ú:g\É}Ú¸£p5U¸$\Ê¨°ieEt„.&\ï‚D\É\ÃtR>¸@Ö‡;´8K.\×\Åj]\à!£\å]\Ì£Ä•E\×ÿÁLÀù\à²|\"/÷1„òll\Ý\\&\×Q¼hñ>•\äoV€ >2uŽ|\ÂË‚\ä\Êxn!}I  š|­k\Ï\rÂ‹+1þ.“yð¹\à†ò3z\Â\ç\îý3#X²œDÁC,ó\ZF\×ÿ\Ä2¼X>ý\åÿô»†š\0','6.1.3-40302'),('201811032322443_Min_Age_Column_Added_To_Job_Offer','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\í=\Ër9’÷\Ø`ð8\á-{º·\Ç!Í„Z²»¥±,­i÷\ìœ%’*\\¬\âT\ÝRl\ì—\ía?iaz\âÄ£Š¤F\áƒ\ÅHd&	 3ñÿó¿Gy\\%“\ï(/\â,=ž¼žNPºÈ–qz<Ý”wÿö\Óô/þ\×9z¿\\=N~k\ë½%õpË´8ž>”\åú\ÝlV,\Ð**Vñ\"ÏŠ\ì®<Xd«Y´\Ìfo^¿þ\Ó\ìðp†0ˆ)†5™}Þ¤e¼B\Õüó4Kh]n¢\ä2[¢¤h¾\ã’yuò)Z¡b-\Ðñô\×8G—è ®8œ$q„‘˜£\än:‰\Ò4+££ø\îk\æež¥÷ó5þ%_ž\Ö×»‹’5¨¿\ë«CGñú\rÅ¬oØ‚ZlŠ2[Y<|Ûe\Æ7w\"\î´#&\Ü{L\àò‰Œº\"\Þñô4J—ñ2*ñ\èù\ÞÞ&9©\É÷ kòjR¼\ê$\0\nù÷jrºI\ÊMŽŽS´)ó(y5¹\Þ\Ü&ñ\â¯\è\éKö\r¥\Ç\é&Ih\Ä0j¸Œù€?]\ç\Ù\Z\å\å\ÓgtÇ£{¾œNf,€¡k/k\\\ì<-ß¾™N>at¢\Ûu’@Qa^f9ú¥(\Ç-—\×QY¢3ò|‰*Z\nhpž\ëO¨\Är—÷½b\Äi:¹Œ?¢ô¾|ÀS\ì\ÍO\ÓÉ‡ø-\Û/\r&_\Ó\Ï;Ü¨\Ì7\È\Ø\Ù=ž¥O\Âðôn\ä/\rvø\Ï\0\Ø\áŸwq‚®\ã\Å\×<¼7Ì²%Ê»n°&8h?	\ì6RÕŠ \ïñ¯s§GQ^8·¾\Ì\ÒòÁ®ùù\È\îÎ²\Å\à\î»:C\Åð\Ý5\âƒuM|£N\ÆÎ²E©5W\çetwG@0\"B}µ„w\ë,o\ã¤\Ò\n5\Ì3¬3¾\Ä+{h§^sÛ©|Š»¶l‚\Ñ\Æ[”–\Í\æQ\åO\"ù¨Ï¶ü\èš^•(E¤ðŠðEÞ¢„Áü-K\ä‡Lý^d.ã´¦F\'Fh¯\"¬3¯süWc”\ác¾ˆp\Ù\n\ì)z¸§y‚\Ðú*‡%\Ï\ç,[Ù«\Õf\Äöq¿\ä\Ùf}²ub·\àþ\\›žæˆ˜gQ9ü\Ú\Üôõó\Ó\à=}]/GU\Ó\×£:Y.cb.F	Q\\y¼®\íõÐ½~Š¾\Ç÷•]\Êõÿ!úžmˆº\Èn¯\î\î1:>£¤ªZ<\Ä\ëF?w&ð¬Á‡<[}\Î\ÚT–Ô»™\ãÂ¼PùK”ß£>\Üò3ú\Ç¥|}ù\rµw\é1—•wH´K+µÃ¢1=šõ;&\í>ª0|Õ¶\Ø\Â.ª\í\ÚeE·k…û4wgPÿ«u’=A\Ð\ÞÞ®\Â\0^”üaD\Þ0L\Ûp\Òý%¼—\rÑ³\ÞÙ‚‘\í\ì&\ß29\ïx^öP/{¨\ØC¹“ \04\í.\Ë~aë¼¨\ì®\âÁ_\Çv€\èí³Nü-J\â\å—8I\ì!\é\ì\ïÊ¾\Ãÿ‰ŠoJ#¼ªt#\Öf,qy%a¡®)\Û=X\Û\ä\r4{Ó¼i¸\Ý\Å2\Ù\"\î\Æ1\ËNù‚!0>#b¶\ÃNÐmûø ›\"š\É\ÞÔ¹\é\êŠS«¢œ\è|=\ßin=½·4­)1u\Øw\Ã$|§¶\Ý\rÖ£\\/6}\r:$SxŽ- \Ü\×(C$ýUf\Íh½]Gy´¶(\ÔW\r[µÆ¶\Ë\\µ<ù\ÅU£«Šÿ\Å\à$Â½â¹¤š›–Ú·\Ù\â^F\ë59O’\ß\Ö5šúuE™>\Ö\ÕCµ•e‡¢º¡\Ì7z³±\ÚUb–¦L¶v°¼\rÙ -\\`$­_¬Ä¡¬2×£\'k\'\ÈnH ó\Ñ\Õøin2¬ìŸ¦\ÍvL ¦sG+ˆj=–[8Ž\rnQ=\Ç\Ã%“·³¢\îC]@J3õ-¥…\Z3aXU‘\â†ÿ\ÔaEŠÝ¯nM‡GT/B¶\\Eò|m_%k¥]·£Võ\é\ÈÁX[ÁSŒ\à}\æa„AU;®1p\å¾\æ|‘¥\ç«\è~\0.˜.¥>¸QLÿ\Ýl¿	6¹Ye\ábH½œk\Ä\Zl±½œñnñŒ—•d\Å)¯¼’f-z\Ò\Û\ÞÀgh\Ûb“¾Ú° ðk‘\ÑUv-8\ãú…ö\ëÏµwL‡\åñ\\{uX9ôjb[]q#oÑ«omEA…\ëk;l\r5^\É]_2_d±T\ì…\Ö\ï\Ø\Æ&l÷V\Ö`\Ûh;@z\Ë\ã°„\ï˜Bž¬\Õ}Ž²+ófpK»,\å«%ôM]‰1\ê˜2™-\ÇVðšY­`Øº©uÙ…4\×v\ÉA\Ûð ù!\Ç\à~\Ïòo4\ÄWp»~j¾NÍ·‡·woú\á\Çhùö\Ç?¢·?Œ¿]ó¶4\Zò\Í?\éU)\Ë\Ä•3\Íï›¦Z/\Îb© Ð’*ADš€\n/\Ö-\Ô\Ý\ív\ë03W%r™	Á\Â\è-gC‹\ï°ý‚%nŽ\Ä\"{úbŒU«\ÔF\á[nÁP\áQp‘Œ±L–ž\è›\'iñ;Ê]dÀ\Òt²^c¾V´!ó.L\\Ã½;üO|ˆó¢\Å\Æý\Ô\Ñ\Ér™£b«Q“†œ,\Êø;úŠ§ˆ\ä\Z\Û\ä\Ê\Å:¡& —\Ó,½‹óU\0€¨(°Å°ü5*§m«´\çe´\Zþ:\íú!KÑ§\Í\ê–:f¡¯`¬ùò{ö!Z\à¥\ê}JZy\Ãû˜-¾e›ò}Zd}-¶ò\Ý‚\Î\Ébµ\Ç,\ÌhY\áú™r\r¾e\é9\äûnµ¼¡«÷ûu-a£©j{<wšDñ\nˆvSUƒrUÃŒn]\Í\Õö¨†-U[pWÉˆs_\Ó\í\Ù}œ\Âpn«ª®k±mªÙ¢J€Á0mjª­*ñ¬kÙ¢\É\ïjs„¸¼\é`+ xZ»Añ\ÊKA#T3.ü\éDv÷\'v\ÝQb[gû˜]\æ`×ƒ¤§*\î#pWN³¡ÒŽ\ágCv÷gC…&þü=®.\ÝgvmeT_~hžsfcOf˜cw>Žp=’¯W\Î\çErp{wŠ´3ž9aR\È\Ú­BN1G¼¬¸Ý±\r†°¥U\éj({PDeKþ³#M0v7x›¥\åZÇ³ó\âC\Ý÷\ÙÀ¡j­nï«·°¸c(\Éžôtcy|‰\ÈSƒ÷eD\î\Z+{\êxúZ¦\î´¢kŠ„ªI¢!•Ê•Rˆñ‰uŽ¬	£\ÈIŒfu2m?šQ©œœ‰\ÖÁØ‚ˆ‘ük\É”b¿â¹œ()\Æ×®RT]\í7ô¥\î\Â\\\ÉÛŸº_\Ð#XO\Ð\â\Û\Ï\Ù#”¸\äT÷:^|#ŠMN`¾E{V\Þ\Ô~«¯\r´(i„þ\á\ßIQd‹¸b\ë¿+·exŸ.\'6Á·ý©<\Úû³5&«\r^#Ž§\ì¯;\å\éû\ëœ\ç\Ù.§¼1z•žaB–hrR%‘ ‡\È\Å\"ZŠ\æ¦\æ’ý‚\íWD’\Ä¹*°`\Æi)\Z»qºˆ\×Qb1†\Ê\ÛPžÈ„ \ÚuÊ—œµ*Ø‚\Þ\Øtr5\Ñ\ïhF	«^†…¼*9R\'90\Ê\Î\ëƒq\Êk Ã¥R|\'\ÑRm<qR\Ñ\0‚\Èc[‚$Mµ¤\áº>\ï\Ã|6\Z\\û©z\Ù\'\ÅgÃ¨BªcÙž¨;Eö?“iRŠ’:¨Ap“Ë·\Ý,òV%¹€R¢Hò\í$¯Jòø\ã2‚\Èjó\Þ+­>P|\Ê\Ê\ì\ÓAX˜–\äù€\Ùñ\Þü¶™\ÎbB\Íl\Ñd·`\Ð\ìò\ÒX­4š\äý\0J\ï\ÄB£dªh^8³·JFÀcœe\æ²²H’0r8\Þ:\"f$\Óú\è\0\Ô\Ìþ‚&ŒÛ«\çqD‹ÎPGtºœ€j\î‚Ê³3¢\Øúª6\n\íÑ¤LÂŠý‘3‹)Ç‚Lú\Üvu†\r{²¯ÓbÔžu{²·\Ó$\ç‚)4e¦.ˆ\Þnudó›[”ª‚t@\ÉQ&VôPµ\nR…Àhq\Ö\'GP	0SB/,}b\Z¸þ…%Xp±5\\\èc\Þ\r\ë\Ò0˜)1Ð´\Ö$~°\ß3»Na5e ³D\'\ÈjÖª)\á\Ä8\ë›¢@£\Èù\n~÷\é;\ÆZ^\äIô6}¸5DJ ’V\ç\r±]7¤4‚\Å\"(I, b·.\Ë@\Ïp6\×\Å(r¨\Ém A¬\ÏX0ˆXª©	OiTSÒ¹<AÁH‚¨‰Sñ6\Öó_pl´ºjÄ¹Š;	™y\ä#›™$$X?\ß\Ý½:\Ú,\n\\\èX\äR‡†˜C…Jl\â¤\ÆW†b\ÛU†$vJ@û\0O¨H¢=‡ÒŒb¸¨ýžÑƒ6M )[>ªt\×&/Îª˜¼MX\×(“—¥\Ø&/K’½›¼uü0”ÿ\\0ñ®‰\'\Å<¾µ­%\×d“¡Ç¾‰&0\"(¶\áAJ\ÑVE\àÁO=\ÙýV\Êrm‡ñøro\Ç\ëý\Ü@£\Ãü„P*¶õù¡?£Pc\åv\í\î\Ôo¬\Ñ5\çú`ª©\ä&\ÂÁg\\§ˆÛ”¸E€\Ö÷\ì–VñBB`&E\ÛT4±²¼p\àsTJòõ’\âq0GX0ý‘¥¿p\én˜Õ°ºkX3H\r(Y\\Š”XÒ°\"3~}vvŠ\Ý%Ÿ‚zjñ7\à°T¶%Z¿\Ý5\ã\Ö\\\ÄR	e.w°šEöd\Þ\0„·\ßu\0{\ß\0”W42 \â\nb\0\ÚdC\0	¶šÅˆ\Û|_\Ú!7\'f`\Û$WZ°\Í^0je2(-T\×\'¥·õj¢7‡j¢Qr‡0\Æ$;vDQj/a³o¤z\è•o˜°tÐ°G÷$°H7¡Žz$|U}T\Ø\ë\rNi\à—œ\Z\æ1~,\Ú(1vH\Üz¬§‘6.lXR‰\ÑG\ZbB•¤\ÃR+I£”:\ÆÈ‚4Ó†¿\È48\\†\Õ#€ZSQ–¨N=ABd <q“6\Ék¯RA3\Ñð¡£a‡\Ò‹zSÎ€(\îF›\Ã\äSpð¸‹!,\rŒƒ#/S>\ÌÓºZA¸\àCT,» ‚ü˜A…H\è5z\Ø:ñ}WŒ¶V	›•F_¯t\Ï›$Hë‚­•¶·|©|§­8\ã@G\Ã;g\"-|™\áÂ¼©\áR\Û^\raþ¾0öøO»ð›ü\å#\Ò.ò–\Ôse\çÅ’NEW*?I\ä~©,úôÑ†~\Ê\ÉýI\Ã+u\Ù{J\"%LÎ‘ö\Z÷H\nÿ\æ,EC7#Gr>\ãM]²v‘8P‡=\íý±\Äe\Zd\Ã\r±\0nyC‚ªñ\0JIü\Ëô£b=\Ìü(\Äzƒ)DªLp*QŠ\ÑL(…Ÿ“v|¢§“¹Do&ˆ–@¨ö¬\ÐL%™Ç“vLœÏ“}8ÿ$…8µƒ	N¥Fõ™‰$ñº8¶!\ë#3®‡&y5\Ð\Å7$ w\Ç\0\å\É7œ-–N &	ŒU\â}ˆ+¯ôž\n!}F\ã–\Ò%\Â@r\éf]›L·»¤\îÊŽfó\ÅZEÍ‡£®²@\ër%uŽÍ¶€\\,\Ä\é}Ñ·l¾L\æ\ëhAúþm><®’´8ž>”\åú\ÝlVT ‹ƒU—O‘­f\Ñ2›½yýúO³\Ã\ÃÙª†1[0:¿R\ïz*³<ºG\\)¹Y¢ê•¶³¨Œn#’Aôt¹ªI¯\ä\×Sm—Â­»\È\êöŽªmBþnRª2\ÉJ•G‹=-?\àá­ˆ\ËD•t\\fñ‰mq\ëù‚¤™U½hD\Ü N³d³J\Éa\ÔðXO&\Z \Þ\ÇI±\Ê\Ñ+@\ë¾\Â!‘¾\É_,¤þ+÷b\rŽ+‚\ÃlsT\ÓÀ\ÚoV\Ôe\Óþý#þcÚ¢óô\ï(\"z‹†&)vƒ]¥\Ö\0o\Ë\á\ÐÏ—øCvw–-X¨ôwh\äIqÄº\ÌZn~\ÃÃ¼‹\ÑR*9}!.•¸›†H}†\Ã:‹‹u–Æ·q“whx\\fsû,\è˜þ³,Ü·\0¨ùf5\Ê2%‰þnA*	8\Ã\0\ê»´*¶(€\Ò\nŒ\Ò\Ï(õ}ý\Ñ\n\Î\ß\È!§\0¨ùj§%Z^\Æi=6Q1p\Å°£G-\ì¾Ø‚S	B\ë«t.)p¢\Ã\ç,[Iô#[\êD\ä®cóKžm\Ö\×([\'ø2¨Ñ£\Z*Wf!±9\"Ï³œE‚\Ð\Ò\Öð~~’Bû\ÙJ–¾®—rÜ˜kx<n\Ôg«b¹Œ‰A%D\×\äñºÞ›1v†¼Š\Ø\ÇÑŒ3cy[y&\Ë\Ü†7¿AÆ¹\î¶j›·0LsuS\Í\Ûü\nE‡sð¢N‘\Æ²ƒAga´‡&³ˆ\Z\ÚnØ»XC	 \ÚoV\ÚJ„\Ò|{±½_l\ï\Ûû\Åö~±½_l\ïf\Ûû¼¨žT*x\Ý\ËX\èó¶‘h1sEp˜¿EI¼ü\'Ü™õy\ç\ìY×˜­Y«pÞ³°n•\ÔK=¿¼[\ZµM\ä°\æ\íEŸ\å•CM•üU\r‹´øŒ\Èú_p’Î–¸Al\î\0\Õwib˜\îÁn„“{¼¦còCŠQ]`\rO)Y²r;1ž£*”Z\ÄX(´ƒ[-sr¨T‘L\ê1C&U\ä\0³z O˜*·XaIË“\ïQ\\=|µnî“™•V^Åª\Ä<\Ê\ÅAG\Ú»¶¦d\äx·¾²0c‡`˜Á\ã`š\ÌeÏº½\åF\ãpn±\â´1\áN‹Ž²±†[T\ânŽaš”\Þ\Zžö$±š=\×=‡™«ºWVe—\æ“\çDr›AVS\'„™%5±\Ì+:©2M—oY³2pp\ÍW+H\âZ÷\Ñb\Z/²ô|ñ\'\ì\Ô\ç]_s8—ýª\àµ#1Á\Ì¼Â¼l©·$Ôº\È¨,w\Éa\ìEX\Ýtœ£œð>a\î>Ÿû\Í\ÎP7v!½6B{”„ô\Úpõ(\Ù\Þ\ÒI…Nz­š]ö(§õR\ÝzL3¬m%Ú‰l‰\Å\ìT­EŽ§o{d–©¢ 2\Åd³*}óa\ì/QnTò²%žˆaþüé’³¹óH\rB©g%–½MÐ¾GBCQ½Q²5ž‰\áE\î<3Ehxf¡¢¶,(\ãD\0\Èª†Þ‡¯\Ñ0UIþt\ê\Ð/ñdŸþ¾3Ò¡J\Z\0•C|%@ Œ†ÑµUX™¨p©\ÏpX#¨þ«•\×nŽ\n\îÆ¦û¸\Ýh\'’ÿø;úŠ9\ÇAd\nl.\ï#Ró\É\Æi–\Þ\ÅùŠ\ßnðe67\\Eñ{–/Šþz‹.±ð|jtÓ¼ŒVk¹\ÚjŠ,°|\ÈRôi³ºå·¥L<E\å5,\Î[~\Ï>D<ÿß§\äî‘ƒ.–Z\ÌÀlñ-Û”\ï\Ój‡ôµ\ä0%\Å°%8óe6³i\çô,¢hYmÿù9%[\ì\"­£&wÀžT&q1(\ëÔ·~¥\Æ0\ËQƒ´BY´<¨Ï–°*\'	°\æûN\n’2Ýˆ‹ \ÕÉŽýIC­opuü\í{,8rEVö@\Õ\æ¯\èI°ú‚¡\Äu‹¶­*µC0‹W‘ª\Ú\Û†\ÂF…??v÷\Ö&÷[ÛG6]‡\"\ã„4\é¯1Å„´•2©„*„\ä1Qù‚h²‹„\èVR½Ÿ\ÒBò\ÄWùJ0Ÿd5¶|¶k	1¤\Ô4\Ý\Ö)š©n\èÔžH¢ƒ’p©®ºð)$ \ìžp)qºPRø\\PTº7\à\êE7\Þ\áJè¬„j)\Âb\ÃÁ\r jT\í\ÄÁ\å¾Z‹*\ÞQ\×.“ó\â\Ó&IŽ§wQ\Â{:˜	b*!g_¥[›/\Ý\ï.gT“¯‰I$UŠ¤…ªT4¹£øNu•é¤µ;§—Oó$¤ü úó4‰\Ù\î¶5.£4¾\Ãs\ëKö\r¥\Ç\Óþ}:9Iâ¨¨s‹5©©\Þñ0rU¾%¹ª\Ðr5\ã›\Ûg¼\"PŠb™Hò]‘\É\È/[\\~*ló\Ñ\nJÿ–F5\ÍxGºU¹~z%&t®¦ý/\Ë¹`¾Ž\Ê\åi¿™Nˆ0’\ãN g\Ú~X±\î(ýå‹‡(—¼“už.\Ñ\ãñô¿ª\Ö\ï&\çÿyCx5¹Ê±¼›¼žü÷tr=~D\é}ùp<=|óYõÀ–	±.ÿ5z;ýJ\r\"\É06\Õû_vp¸3X?`­ŠtT0–\Ý#¢H‚ÜƒÀjcÚÑ¡\ì~$\æCØƒp¿÷ƒ©Á\ÝfYb\Í:*fÝÿ\\ z\rˆ¨Š2&²~£E\\T:õµ5lÊµÉ™‘­W“3\0Ú™\É\îNki0ºŸ<u±\èrÔ‡¡{\0‘ž7²„h%Œ(bN,+\\üÆ½§>} ž˜\Ðô0´ibÆ½”$~\îŠ8w\Ä™»\Ïu\Ú	\Ïs^ôÞ~€\ç»  üqR8 \Û\0¥¹´F«ü	f³ªQ\Ì&+\Ýv@‹µ	q\×\éôž‚°uû–¬¥k‰À& ¨y›\ÉB“{Éƒ@;\Ô\Z˜\ÖA{±D÷À…Ñ™¢\Ð!\êmQK3ò\ÅU\Ï\àc\ÔHi;zoX sºœ‚\Ä\Ä{Ðœ‹6ªÚ¨\Èc¸\Öö 4<fº˜ƒÃ›2k`\Åõ-½¬8…i?Œ6¶\ÒzuC¯A°±˜~k	 \àr¨ýŽ«\\+#[A»	\ã†\ß\ìÀD\ÃS,˜\\D~R!\Ë?\ä/gL\Ú!pT¾!`T¢!w½ K,\äM‘E\Ès;\Â\'²“R®¹J^=ƒ9Y\Ï>¯~\Û\\66g6\ê\\\ê\â\Ö\èJ\ïR§Z\È?\Õõ.€ƒTS_¿¥\åŸ\Ç@×‰\×(V‘\ãüqœ8\Ãk¼@\æ-n-ý}c\ß\É\×$ûñNˆc *¢|(a\Ô\å\È\Ù\çeX¾^À„©k\ÂX\ÙBºË§\Üy&–jB³x*\Î\ÆpòÚžÿÒ³:\Ùy\'\ì<\à­|°ð€·ò2·\Ú\Z¢\ç¢\0\Æ\Ý\Ñf%”g¿›g\êd7 3Maý„\ß\à\Ð)tüøð\ìhhCG‡f§µì‚¸Gs\r>§È \É_\Õ\çW“ó\âk\Zc\ç\Ý\ä&(7£\Þüðc¨}^\ÝUr’ªò”1f6yøX\ÛyWƒ8ÜŽ\Â›º©6`\Î\ê³\ÏÀ8kŽT4³Nc@\ÝÙ§±ñ\\\'©6Áé´‰`öJ\ÙQIdü\èÝ§ñv¬3\Èq\n¶ÀdŠ\Üc\ë$2\ZžrK(•ô\Äçœ‘\É!\ãGD.yŒ\'{\é¼1Á@…!š˜\Æ˜$LH\ä“\Âx`*Iã¾³ä£—\àkt\Ûr‹v˜$\Ë\Þò\í–\áFe‡ñ<$ 2\ÃºR$UÉƒ!‡Š¤Åµ.G\n\Øô7K‡Y`£„E`\Ø\ÛhWû’`eo5\Ì\Î\á\Z6>\0\ÌD^—\rm–˜A–!‹wÔ·\êD\Ï9\âf7¼\ÆtÃ´¾\Ññó&q`¦‡÷\Én°s\ìMK©\Ä\ì\Å\ã\Ïu#¿PÆ›…\ê8²÷mC’Pt\ÏON.7I“u÷¤;\å*=C	*\Ñ\ädQg©8ŠE´\ÉHR…¨0º¡\Ñ\è\È+°¸ýA\èK\"tqDvºE™G±˜\Z\ë:\ÓE¼ŽŽ\Z\\=•0«ž}9šu€ù’3´&7„i©½w÷]/LDaò­è¥­\éÿf¾‘=3\ä&a¯F\n\êD)fh{+ô8!½\ZŸ©K \è8Š=\Ð<|\ä‡	[ö|d\Ëð\ÖöNªš\n\ç›\í›\ã\ÎJYú\Ï$]Ò„‰–†öò¥\éz³NI›/],\Æfé¿ŽcD	{3)6ª)H\àùÀl7\äF„›P¦¡.½o[\êdùûvLÁ\í†\ÌmCÉ¹I\Ü\Ö\Õ\\¿½Qe\î\Û5½FOp’\Þ}~FšL¾vGUFøbŒñ\ÌOz [Œp\Úª\ÂlýzW\éˆ17;\"$[Q1£ŠŠZ\Ù\riÙ«c.zG.G\Ïð(Áø:øN&PúHûVº’x\î²f©P´)å‡—8m÷#ýSÏ»\è+š\Õý\ÇQ\äNr_(\ÃfðESóŠ»Mè™•Ô™—\ØQ\ë\ÜþÁˆ\Ôx»\"y\Û\ÒyŽÒ·KJ¯;\Õ\Úigu¤¶\Ç\ê\Ì\ê\ÌJ\ß\ç8\æZ+G\äHk¡u‘ƒû\ïc	’i+N\'É£%Ü¼Ð…G\Ú\nQ˜G!:\èðFòD4\Å:&>‘\æ![0Š	q{2|ú\ÂAL¯©à·§X\éc}ª©E¸ø(\é\Î\êS\ZFóU(³r±<³$$\æWÓƒË‰\Ýñ¼þ•\Çíˆ‰\ä}\à0\"2‚6ª£WT\ê¨)}.¢yˆ\Ù\"`z\Â\Ö?‹7¾J²²\ì÷WJ¬y\ØC€[\Ùc\Ó{£•\ê*•VjJŸ‹¼A^õ\Þq­D²¯²¶-{|Ë’6\ÉwI\Ð\ä¡q|z£-,°>Mª\ÏEô\\§ß‡€B*\r)]z\á*\Òr\"Ž¢!÷K õ¤V’9]Î–$†Xp9\Ï>¾\ÜE¢q%bÜ¼\Ë\Í_•M\'}°›xzQ?·|<]\ÞfXŠ\êˆ9\ê¼EÔ´l/ýY¾\ÐI_$ë£¿¿€v\Ñ]¿+{\êj\è:\ì\Ü\0ýªû\Óöƒ/Áy%­&e›¤&h˜\Ý%Ÿl¤]¡b°\í\Ý\'¤#yJ\Ð6\Èk¹\Å\×\Ñ\ÌÁ~\Ë-t\Ú\Éú\ê\0\ìoZdC\ëKƒj*Ä€\É\Ì\È½±Å²\îj“ Þ„@;\ë­{e‡}u§ms\Ç\âB.t,V‘u\Ì\×2w-Ø¶B\ÏB\rýˆ\í\ÈÜœ\"j\é\Ü\Ô\ÑwÛœ´\ÚôÝœhûn\ê\èûn\ÎS,I­²‚LPµ“\âi\nX\Ä õ®_d»jB0X·i—Y%¾“ø\ÌˆPF‘~­\ì¼X\'TÍ¢)÷zeŒmnÁýS\ß\Ë\ÏnO‘W\à·\ì\Ðdiýy»xq	)„:\á‡AÇ›Ûº\rT\Z-¯9d:Ô°e†iÛž-F1`WCCt¯t8\Òq\ì! ¥2•`ªº¦§uÿU§T\n…¡TÍI\Ôø(Ú’H\æ\ÚH~\Æ\'\å°NñP:\Ñ}Á¤D\\h[ªVJ§a\ßÔ†\"ôŒG•\Ç²>·6\ÐÁPz.J|¬ü6\Ï\Ñ;Ú‘Ž²ü\É÷\Þ\r†â´°[71^—\â\Ç\×-\n!¡}3Pþü£\Z_ÿQC\"õî‚t\"<÷­‰Y=di«„º\è\Ïh5d\ék\r!)VV…›Na}¡\åjD\ã/Í£ËŸ×µ÷\ßõ\Ã5­@ƒ”x\ëJ†iò\é•\Þ\Ü\ÓGw\Ælf¨ª@J_\èMW©„PTý½65\"¡b\Ã\ì\È\ÄhNô\0„xYB\åÉ¥  Mip¢P\Çôfº(!•:\r@ˆö\Ì\ÕL™·\Û\à\ÒÁœ-\ÒÑ”\'Js\Û`¦‰\Ä)kp’lA¡}‚\Ìsq.\Z„ Vw2\èª#‘^¼\Ær¥½É¯C\ëDC\ÑG,\Üiò·y‚;_Œ®\ìhV\ßs4ð\Ï2Ë£{t™-QRT_fŸ7)y+¤þu†Šø¾q„a¦hÁø~tu\ÎÓ»¬uG\á0j«pI”/Qa\Ó :\É\Ëø.Z”¸˜¼§÷\ÓIõ\àYn\Ñò<½Ú”\ëM‰‡ŒV·	cŒW]ÿG3ç£«ê‰¼\"\Äª°±us•þ¼‰“e‡÷Iþf\â#\Ó\ä\È\'¼,I®üû§Ò§,j\È×¹ö|Axq%\Æ\ßU:¾#Ü°@~D÷\Ñ\â©¿A\Ä\Ì–\ìGgqtŸG«¢Ñ·\Ç?±/WþT¾œ\0','6.1.3-40302'),('201811040018195_agency_Details','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\í=\Ùn9’\ï\ì?\êqÐ£²\ì\éžCš[²»\å±l­\Ê\î\Þy¨*JJ8+³&3\Ë-a±_¶ûIûË¼y3xdVJ#4\àV%\É \ÆAFÿ\ïþ÷\èo÷›xö\rgy”&\ÇóÃƒóNV\é:Jn\ç»\â\æ?\Îÿö\×ÿ·£·\ë\Íý\ì×¶Þ«²i™\ä\Çó»¢Ø¾^,ò\ÕÞ ü`­²4OoŠƒUºY uºxù\â\Å_‡‡L@\Ì	¬\Ù\ì\èr—\ÑW?\ÈÏ“4Y\ám±Cñyº\Æq\Þ|\'%\Ë\n\ê\ì#\Ú\à|‹VøxþK”\ás|PWœ\Ï\Þ\Ä\"ƒX\âøf>CI’¨ C|ý%\Ç\Ë\"K“\Û\å–|@ñ\ç‡-&õnPœ\ãf\è¯û\ê\ÐY¼xY\Îb\Ñ7lA­vy‘n,¾jÐ²\à›;!wÞ¡ \î-ApñPÎºB\Þñü\Í-Y×‡ùŒ\ï\êõIœ•\Õ8\Ì\Ôõ¿›\Õ_¿\ëÖžHù\ßw³“]\\\ì2|œ\à]‘¡ø»\Ù\Å\î:ŽV\ÇŸÓ¯89NvqL‰Š”1È§‹,\Ý\â¬x¸\Ä7\Ì@\Ï\ÖóÙ‚m½\à›w…–õ„Î’\â\Õ\Ëù\ì#ºŽq·ú\Ô\ä—Eš\áŸq‚3T\àõ*\nœ‘\Å;[\ã\n\Âøó\íG\\Z\Ëú^	Ù‘\Í3Ÿ£û8¹-\îŽ\ç\ä\Ïù\ì]t\×\í—f$_’ˆ\ì5Ò¨\Èv\Ø\ØY5½òï‘ºúÞ¦#uõ¾Î£¹ü0x‡\ç(A·8{ey1\n2›? qû#ˆ¼«“t³E\ÉÃ›U}#\Û\å\ç«ú$\Â#·¹¡že“\Ó(\'sX–\Í\ÈÏ›(Æ„_F7\î\Úþ”¦1F‰„ž\á’5ýô0<b\ëžN\É?ƒ÷õe»iVMO\Ã\Ì\ê#ú\ÝV’„\Ç%J\ÖQ\Ù1QQ.q\\U\É\ï¢m­©4\ÂõŠ®õ.K7—i\ÜqDªðj™\î²U9üTU\ã3\ÊnqÁŽ\ïh\Ñ+ZÕ ƒ\×º&{Pº¾]t¦ñ\ÄÔ„Ã—?¨–L«\Û(Â©\áŽ\Ñ\êK\ÞY²5ÎºnÊ­\×~²dÃ”4!ô\í=ù‘•Àg\É?0\Êr\ç\Ö\çiR\Ü\Ù5?[“\é\Íi:¼4\î»\ZEø®\Ë\ÝÜ” ¡¾Z\Â#*\Ã6M¢\ë(®¸B\r³=Ÿ£=´©k:K£\ìADõ\Ùv=º¦ŸŠ;œ£O¢\ä#=\r%¿eQ¯d¸\Â)·þŠ™ó(©±Ñ‘^EDx\æEFþj\ÎkˆÀX®P	\\&Á€=¡û{Z\Æo?%Ë°\è¹LÓ=[mflß˜ôøs–\î¶8\Ý\ÆvÂ€ô\ç\ÚtL¥|<ScP¥|o¦\ÆxG\n£%œ\å­ŠÃŸ½Ý (\ãm½\Îpž\ÑOT\Ú(.¥Xm\ës\Ý\Ñ,\Ðw\è±\Z	\Ç}Ÿ^º¹Á™\Ü\í\ì¡+Yƒ\Þ(\Õ\Õ\ìSme™©ª›iy‰ÿ¹\Ãy!ŸA_~E²ý\Èe\å\Ý \ÚK+µ\Ór2ª\Û	\Ãm\ê¶\ÅL\ê¶k‹šn;–AMú4wg\â7\Û8}€{&¦%\0¢¡ø\Ã@÷\Þ0L¶¯8©1l	\ï\Ù:~\ÒÖ±-™¹l?1¹ý\ìlþ>\Ô\Ïõ$jw€¦5¹\í[0Xgy¥w\åwþ<¶D\Û\Â\Î<ñWG\ë\ÏQ\ÛC\Ò\éß•~Gþÿ\å_•JxU\éJ¬\Íh\âòJ‚¡®\éu\Ñ\ÅA³WÍ›†{\Ð\Ð]4ó‘5r 0ŽZÞ¬”/˜\Æ%.Õ–|ø\Ãº³}t[D³Ù›:W]]q«sU”¯\ç»Í­·÷ž¶5E¦v7Œ\Â\'ev7£\åð²\ék\Ð\r$\Ù\ÂK¢‘¾F™b\Ù_¥ÖŒ\Ö\Û\Ê\ÐF0Q¨¯¶jMt—¸jù\æŠªFŸªõþØ—ôJö’joZr\ß\Æ\Ä=G\Ûmyž$;¾­k4õ\ëŠ2~¬«\'†j+\ËEuSY\îôjc\r´«Äˆ¦L&;\Ø\n~NP’I[øCIZ?k‰Cie®G?N\ÚN-&Ü@ö£«ò\Ó\ÜdX\é?M›ý¨@M\çŽZ\Õz,:¶ð\"\\£zŠ‡\ÊEÞ1D\Ý+†º€”3õ-¥3°ª\"ùS7ª²\Øý\ê\ÖtxDõ\"´P–«h<_Û—\ÉZq\×ý°UG~:²B0–)xBx›ú_P•\Å5Æ˜G¹¯9[¥\É\Ù\r.dR¸”ü\àJ±ý¯t»ý*\Ø\æf™…‹\"õ|R¬!k°\Æö|Æ»\Ç3^–’§¼òJ\ZYô¤·½-€\ïÐ¶\Å6&}µa»A\á\×\"4¸9œ\Õô	\ì\×óR:a\ïuC¯\Ö!¶\åWò=û\ÖVX¸¾¶ƒi¨ñJ\îúz/óEKÕƒ}¯õ;¶\Ñ	[ûÁJl\í\Ç\0¤MCn1…<Y«û\Å*ófpOV–\Ò\Âj}UWb”:¦L¦Ë±¼vVK%l\Ý\Ö:\ïR\ß\Ôz\ÉA\Ûð ù.#\à~O³¯4\Ä\ïf\àvý\Ö|	Ýš¯¯o^ýøýhý\ê‡?\áWßo®yD‘[*\r†\rùòû‚ôª¤\åR•3½\ÞWMµžœ\ÅR %U‚t	*<Y·P§OÚ­\é°0W-\'\ä²‚\åT°\Ü\r\íx‡\íLqK¼*5²‡ÿ(•±JšAu¾\å~.t ƒ1–\Ê\Ò#}`\âM’ÿŽ3g05½\ÙnÉºV¸)÷—E\Î8¶\á£;ü<ÁP\á±k/F\Í S¥6\Ã_\È‘\\c›\\™Q¤ Teôr’&7Q¶	\à€òœh\ë_P~78n[¦½,\Ðføë´‹»4Áw›k\ê˜q„¾‚-\Í\ç\ß\ÓwhED\ÕÛ¤l\å\r\ïCºúšîŠ·Iuõ¥X\Ù\Òw \ÈpÞ¬V„{¼#ÄŒ\×\Õ®ß‘) ¡\Õ\à&K•‰+R¥€ce\åU_™\Ê§¨#&„SU´=–3\å­\ãúQ$°S\Ö2Ü\ÒN;ôEà°›ªš!W5\ÌÃ­«\Ùµ=„–ª­pW\É8æ¾¦\í°?¤·Qs[U=àº†q´M5Û¡–À`#mjªZU0Ž³®e;L\Þl©5|\ÐÀ\åM¯\Ý]91\0Á9\Ü\rŠW*\rú\ä£\Úq\áT*°\Ó?Q™ºoÇ¾Žcª\åc\ãÁn4ËžªP•À]9í†Š;†\ß\r\Ø\é\ï†j˜\äó·¨ò\03¶•	xP}ù	¦y\Ïq#{;0\Ó»óqx€\ëa–\\^9q\ÉÁ=ºƒ¯\É8…Il\Z9xñ\âV\Ðâ¦£\ZaK­\ÒUQöÀˆ\Ê%ügGœ`\ì.wŠËµ¾rgù»\Ýö\Ý@\ÙZ\ÝÞ—or\'P\â²=\è\íÆ®ñ9.ÅšqŸ£òz´Ò§Ž\ç/z`\ê¾\Ãºö¡ˆ¨\Z%\Z4Q¹«\\1ÕYg¤Á¶\\¨òp†³ö\ÕœQÙ§œ‘\ÖÁ\Ø‰•)\ã\â(\Æ~!{9VbŒ¯]e\ÕÊ»\Ú/ðK]ß¹¢·1>v?\ã{01ž\Ü\á\Õ×Ÿ\Ò{(rËƒ\è‹hõµdlró-\Ú\ãý¦ö+}m\"4ðª ô\'\Èú½\ÉótUÂº\ËC„\Ù¼M\Ö3›x\áþšW ~N–5*¥\r‘\Çó?ö×òôýuþþl‡s^ý”œDxö¦\Ê{Q\"\ç+´\Õ‚\Í5û…è¯¸Ì—¡ò\n+\'„%…¨\ìF\É*Ú¢\Øb\"•ƒ¤<÷J9Ô®S¾\ä´eÁ\Ë\è=š®S¡&ü-(b\ÕÓ°ŠAEG\ê¼F\Úyqp ny\rd8UŠ„\ïDZª¹GN*@F \ä\Ù!I³CiV]Ÿ*ŠY|6œû©zyLŒ\Ï0‡Q‰T·d„\Ý)š(H“½P¤\ÔA‰269}\Û\í\"/bU¢H%Š¼\äNôªDÿXF Ymª~¥\Ö\Ê\ÛOi™}\Õ’\ï°;þÀ«\ß6\ÛY\ÌÁ¡\Ù-š„\Ì0»T:V’Fó\Þ\0\0Ó“4\Ê)@¶Š\æ…>\Û}«\\¨\0\ãG\Ì\\A$‹$¯C‡\ã\É1‰Â˜Ú·€ gö\'4a\Þ^=CZtR\0;zOgø	\È\æ\ÞS©F$[_\ÖF\r{4*“,\Å\ã¡3‹Î”BF}nV!­\Ä#±\ëô³Õ²\Ó/\Ý#±\í4ù\Ä`M™\\\Â7‡“Î€„f~{+\0SU H9\Ê\\¬Vª#\Zœ\Å\Ç\ÂU¢y9¼\'ŠöJ\Ð\êhVýâ¸›\í\èDf\Ê\éA²Ûƒ¬”hðÁd¤O¢Zx`Žžú”Lp1K-â¢²º\à\Ç|¨¢K@b\Æ\Ä@\ÒA“ò\Äþ\è\Åu‹ª1\Ù!\êYV»T	ÿAŒ£¾°\É94ú€\"S³\Þ}âš±´yz½iN‘\â(\ë\Õsl\Õ)‚Œb”¤\ÔP-·.¿F¿\àl–—Q\èP“\ÕC2°>W\Ç d©\Æ„$<©Q	H\çò\Ôcé¾ª(I¥¢j™¤4a\Þ7\ÖN%6\Å\\\Zunw]E‡	®ÁHŠš=›\rÆ™°\Í(™Œý$vdK&.°LrI	CD¯BR4Qˆ\ã+ƒ±}*ƒ\È\0&E }ø4”$±\ÔCqF1\ÛÞ”öÀM¦\r-³=µ\Í\Ë‹+6o49\Ê\æe1¶‡\ÍË¢\ä\Ñm\Þ::ºþ\\¨þ\ÔÈ“\Í0¾¢E\×h“Á\Çc#M`¼6lƒï”¤­Šo…\Æz¦‰ð“”!\è\Ún\Ä\ãÓ½\ÝZ?N³\0\Z{\éG„\ê@Ì½\ïep\'541ujž	~s…®9ù\ç\0[ME7\á|\Ç\ÕQÀ¤MAZô\áýtO¯\Ë\Â*\ZO$¨h\"ó&\'\îøB\â²>ø˜;\É¶N&À |`ú«8J“\Òy€¨aunf\ZP ²¸1)²¤a\æñõ>È†\ØÝžš) XŒA-\ÞC\Å\0–Ê†&@\ë\rfóØš;9•3·fXM1{\åa\0\Â[\0:€½•`\0Ê³*PQ€6	\ÖE\ÆÀk{3nóñi§Üœ¹Y€m“\ÐiÁ6§€Y+“µ™p¡\Ò9¸>)Î¯gýS\\T\r»;l2J\r(¹CŠ’{	‚\Ð2ü˜\ê¡g\Z¼j\Ã\â	€\Ãn\Ý+\ã\"Þ„:\ê™ðUeøQ^hp4H3\å\Ø0\Çpòs\ÑFq²S\â\ä±GÚ¸\ÍaQ%Fje%”NKL(AS\ê@‹5pÀ™6<MÆ©À\ál,´ÑœŠ\ÒDu\ì	\ÂY7j“< -%4CO\ê07v*½²¨\'0u`\ãn¸¹2l>E€?v1ÄŠÅqòbd\Ô`Ì‡y­[K\ïù\ÐÕ’½§‚üÿ=\îc@¡\×\ìar\n›¢˜	LV	FK£\Ë+\Ý\ê&\nÒ†Hh\È@$\áM_ª\Ø«•qÀ£\èj/ÁÁŸ=,Tz\äSS\é[4R{\à\Åz\r\ïHŠˆ±ð0g¦ó1§¦Ih0ó*‡Ñªú´Z\É\ë\\>#­\Æc‰1\Õ\î\ÑA)_\Òø>óC\îý\ÌŸ>\ç\Ñó¹\×rx	\'{¯NÄ„\É—½\Æ	—\Zs°¤Á‚\Æg–‚#9¬ò\ç¼\Ê\ç0$\äª½Š\ÜB©\é5K¢\ã\Å&\×O\0s€#ƒ˜úˆjg¦\\ö˜\ZQ|©ý\0`J\âÒ¨Ÿ\ë\Ô\è‡!\ÖQ±\í\Ú\É\Ç%<ÌˆR¸\Öi\ç\':\×y¡Kt ƒH\Â\0ˆj—\ÍX’9\Ùi\çÄ¹\Ùy\á‡s‰SS;™\àXjÄƒIG/\í¼XW//±nY\ã\Ê9h\Ön#]Ü‘¸ý(@yU_K¿#¶T\âš\ëZ\écBºÇŒ¶ZJ/j’[JðÒµ\Ù\Ñ;¿ˆ®\ìh±\\\Ý\á\rj>-H•\Þ;\×I“Û‚ò&*Jnó¾eóe¶Ü¢Uy2ü\Ç\å|v¿‰“üx~W\Û×‹E^\Î6\Ý)«t³@\ëtñòÅ‹¿,›\Z\Æb\Åð4Þ‹£\ë©H3t‹¹\Òò\Îl«—BOQ®Q™úd½ªI½@÷™m—œ£‡¸\Ð\í•fÛ ü»É\Í>ˆQ;„ˆ®3M\Ãwdf›\ÒA§z@‚WŒ%\rI\Ó\åª\Ì.{M¯\n‰<I\ã\Ý&1\Õk 1\îr4­#il\åß²\Ñ\Õ\ßm¡™œÊ \Õ\ßm¡ý†¯ó¨À_.?\È`Ò¥p\È\ç(!T›Qo\ÙÒ\ÅRk\ÈýÛµÀ}¡5\\2i)\È\ê;\ÚIºÙ¢\ä¡z\"–Põ)\ÎW,XiøÕ•9O¤\ÔgX¤Pó\r\å4Ê‹,Z<$ú;Zó’\ï¯8‹n\"Ì\n-\æš\áòšŸ¸\éöŸ­aVWrh§76¼/Ûµll\ÔgkX\âØ˜\ÞÑ‚\ã\Í<÷_\ìŸÈ¼8	\íT\Ü(/>G\ÓV¹ütIfùu©%\Õð†=!\ÄbÙ·\Èmû¯\Ö»}¢[²­\Û\"8\Ìö…\ZXû\Í\n[¢lÚ¿½\'¿\"‚[|–ü£RI¦¡IŠ\Ý`W–h€·\åp\ègkò!½9M9Ew&J=¾lÿzö‡†H}¶\Û4‰®£8*)H=úÿ\ÔB\ÌP\ß] U¯\ïˆ(­`A”\\b$òûú£œ\ß\Ê[GPóÕŽ3¬ˆ@?’zn\"c\àŠ`£{-\ì¾\Øb¥bŒ·Ÿ’¥€¦À	—iº‘ðG¶\Ô	:\È]©…\É%?g\én{\ÓmÌ›\\™!s¯†Ê•\íO\Ù\r©ˆ»*»c(\â\n\Ø\Éô•Û¼.\ÆnuB´*>¦¼T\é>[\ì\rŠb^t-ô¯õ:\Ã9·½ºVp¢ò¼\Å%wÏ¢m}ô\ÊA•U™Œ9¤sø€ZC-cH\ÝT…ó¶Oôwø\n¾¯SZs€\ì`Ð©úX\ÂT§ðSC›†…Ad‚x<\Õ|³’’C®ûgk\ç\Ù\Úy¶vž­gk\ç\Ù\Úù—·v\Îò\ê	\ÜüŽ\ç½L?o‰6\nW‡ù+Š£õ\ç(\æNQ©Ï“\Óg5Q¶j­\"˜\ÃB»UBP‹z^¼[*µU\ä°\ê\íûþUnhª\Ç:Ô°\Ê—¸”ÿ9G\él‰D€q¨>¥`C¸o»\r’LB\ØxM\Ç\â‘S`\rOIY²r;2^\â*98b¡\Ðn%\æ\äP©\";˜\Ô\ãó<Lª\Èfõ º0Un!aË–o¾¡(F\×1þ´m\Ü\ÅI+¯b\ÕfQ\æ c\í\Ëû»\\—&dð¸g—¥q¸rL\ãd.6\ëþÄ&\æ\ÎB\â´9‚œ„Ž²±fµ¨‡–¸\Ó<Á¤Y³À¾!¤\ÙSµ9Ì«ª¸²*S\ÚOž\ÉmYmj–T\ÅrP¯\è\×K8hº‡M´0+G\0\×|µ‚$ u-¶ñ*M\Î6ˆ?a§>O‰|\Í\áýöRÁ\Ë\"1ÁL,ažM\ê=µ.ðJ\Ë]²@{V7\ç(\'¼i˜»Ï§~³3ÔÝ³\Ãú$\Ö\Ù\ì^R³\Ë&\ê$/Õ­\ÇT\Ã\ÚV¢žÈ–X\ìN•,r<}{Dj™*\ÞJSLvY{¢\Ò7Fÿ\éFE/{Z1\Þ\Û}ºd½\îk¤¡\ä³\ÍÀ^\'hþ£¡¨\ÜÛš‰\Ñ\Ã\îkf\nÀ¬™„\nÛ²¼òŒ \ï¼\ZzN\ÃT%}\ÖAª#»Å“}úûd¨C•7	Ü¬OŸ\0 #„ax\í4=’Cyÿ^_V\é\â/d\å8ˆL¥Ç´\Ä_\Ú\Z\ÆIš\ÜDÙ†77ø2›®<ÿ=\ÍÖ¿ üŽ¿Þ¢K,<Ÿ\ZÞ´,\Ðf+g[M‘\Å(\ï\Ò\Üm®y³”)p‚§À¨¼†\Åy\Ë\ï\é;´\"ûÿmR\Þ=r\Ð\ÅR‹˜®¾¦»\âmRYH_\n\î\0SR\ì\0[2f¾\Ìf7­Èž~GH¯+óŸ\ßSB±…i§:}R™S\ÌE¡¬ŸBð\Ó(0†Ga\ÒjÈ¢\æA}¶„U9!H€5\ß\'IH\Êlb.„T?~\áGH\nj~Cª“o\ß\"\áÀ‘+²\Òª6\Ç‚6\ÐE®{\ÔmU™›‚i¼Š§K¼õ`(\Üa\ØQøóóa­·öÁ\Ñ\Þ\Ú=²Ù¸9>¤@“zH[)\Óx¨B\Ø\Ê4e*_Í«\"\"º•T/òµ<Ç«|^/˜O²z´|26k\n1d7\Ý\Ö)š©n\èÔžH¤ƒò±®ºðI$ \çp*qºR8‘A¥„\n/ª,ùœ\Ç*–\ä \Èl\0jPŽÔŽló	iGI\ì\èÚ‘`v–\Ü\ÅññüÅ¼ƒÁI‰J¥%ª	\Ô\0°HB6\ä\éÒ“iÙ“\ê\\¦ATBvQ¾J§i5_º\ß]v\Ñ&³\'“r´BT™@´BP\Þd\åS}\ÖU\æ³Ö„9žŸ?,ÿ”\åÕŸ\'q„Ë““¶\Æ9J¢Â¦?§_qr<ÿþ\à\ÏóÙ›8By…¶Ibúš”\ÕôðU™\Õ¯7¾¹}n\ÔJž¯cIf\Ôr32|ˆKcJ\ì8ž\ZZ*¡^\ÃVðª£\ßüH\Éû\ê\Ç£½\Õnÿ“\å/].PQ\à,\éM\àù¬¤Áò€¬£Ã…¾\ÆÄ¨;Š\Ó\ä¶~»·V½\Ók‚E\å\r©\Î-\ZQ\Ôž˜G4¼þþ\"¸*³‚$i¶P_\çEÑ–0\Z§+g\0´¯•3Á»ª†t¦±õ¤üª<\ÑK»Tù¢ü©‚\0\n1&™­!&\ßP¶ºC™\ä­ñ³d\ï\çÿUÁx=;ûO!eû\Ùú»Ù§Œ¬×³³ÿž\Ï\Î\ÑýLFxw<?|ù£~ôÙ…V|(r}\Â$ˆ\ÆH3¦ñ\Èr\Än](\0\î+”¢ñ4\íØ±XRw\äGú\Ü5²°Ö‘V\Êü`k\ÝK\Þ)\É\ÓV›–\Ç\Ç\Å|ž «D\ØPiw\Ü×ŸËµS*yL•´~‘\áU”Wºü{iødt:ÁŽ;®¥ùt<õ„6Ž\Ò\Òe\Òñ\0\"É\Ó\Ð! \rŠR:$œ¿´\èIñK÷žúL:õ\Äd\×	ƒ›&\í“d3\è8ƒ\â“\æ¸\âò\ä¸\ïõpJo0E< \ÒLf°†²T©ÄŸ~€º¼Ÿž\æE\ëø\ç\rF«flU\ÈoaF…ú¾\ÍlS\Ðm4)š¨aw\ÙIŸ\é\Ú)ÿ}K•ú\ZÀª6¨y›ª\ÓB“¦\Óc€ú¾50­\Â‚ö¬ñ?D§òC§¨\×ù-\Õõg¥_½ƒŸ•~#ntšº\í\ì½a\Ô~¨8	‰IQ\ãs.1MP\ÖF%©ñ€k­J3YÀ\ÔBupx5P¦m´¸¾¥—§P#\í§Ñ¦á°žE\Ý\Ðkl\Ú?Y\È\Í1”½\ãJ\×\Ê$( kG²p\Ã;0\Òð$&m¥U\ÈRUú\Ó“¡\Ò•š\Ò•“Ò/\ÈrPºCS$œô4Gø<“vT\Ê5‡_¨Á¯Wy³ôÛ§\Øp0\ÎlØ¹\Ô\Z\ÌÑ•ŽÀ ¦NµpýT÷\ï€¤šúòø}ˆ–]G^£hEŽû\Çq\ã\Ïñ©#tb!k\ê\ïûn¾&/¤÷tBQÉ‡†\"F]:\Å\Ç,†\åòFL]\Û\Êú³	\éNŸò\àYªC\Ì\ä©8C˜²7·ÿ\åÕ“:\Ùy\'ó\ìòûô]~•‰Á\ê™:/\"HMSh?\á\r:Û¢\ßz<;\ZZ\ÑQ§,C\Ç\é\É_M» Õ£W\r¾§\ÊI—UŸ¿›\å_’ˆ(8¯gŸ	B¹õòûB\èS\Âð®J¦ ©*\Ï.h^&\'x;÷w\Ð\n·³pM\Ý\Ôc4\à•\Õ\'*„­¬9©…y\éd0\ä}\ÆCO9Ie;~L§\Íø¨˜\Ý\ä| ù^„aB\ÅÀ~š\Ú5\åD(•\Ïçœ‘I7\è‡D.Ï \çò\Ò)ƒ\nƒ41 0I\æÀ\È\çô©$c »e\ÉG‰Áet\Ûrz˜$qß£=ä›–\âF%ô<$ ’j)ò\ïÁ\èÁnO\Ò\âB—N¬ú›©ŽY`¥„™E`\Øû$hWý’‹\ï\Ñr˜\ÉFIÀ\ÈD^—\rmBÁA–!gŸwX¾\êD\Ï9\âf\Z^cºaZ\ß\èøy“8,¦‡÷\É4–s\ìMÕ’R‰¯Ø‹#ÆŸ\ëJ~¡LŒ…\ê8²÷m&S&™\ê^*Ÿ\ï\â\"*\å\éŸ0H!7Ú§\äÇ¸À³7«:\Õ	\ÊWh-¢±L¦\Z\Ô\rŽ¼;¶?]ªÃ¥]„JK7/2‰YT/²(YE[s\Ø\àê©ˆYõB\àÑ¢Ì—œ\âmyC˜º\Ù{w\ßõ\Â-ƒ	)L>5=µ5ý_-w²)\Ý(\ì\ÅÁÁ¡°¤:šÚ£¥	zž^/šEt\Å#\à<|\ä7¶\ì\éÐ–:\ÚÅ¥\ç)\ëŠ¼–\ç\Ô\ZªlIÿ•¨Kš[\ÛR\Ñƒ¾4]@`Ö™\Åiõ¥KR\Æ\è,ý\×q”(Á6“ŽFµœ\"a›b\Ù\ri´\á*”)—¼K\ïû¦:Y~Þ‰1¸i\Ð\Ü>˜œ\Å\í\Íõ\è•*µ\â\Ôø\Zu>ÁQz÷ù	q2õKeadÀWeŒ_¼ñ¨jb„\ãFP^\ÆHô\ëm\\¦#\Æ\ÜL„Hö\ÂbF%¶2\rjyT\Ç\\ôŽœŽž\àQ‚.jÉ¥\ï\Ñù;­³cO\Ö,Šöõ¡\á)N\ÛýDW§\Å\îµn5¡5OfÐ«\Ú~²:+·T\ß†üI&\éª\è^#²7Ä¼»\ìŸ&£Ö³Á£—³ÿ8\nó‘\\\Z\ËF3¸\æ¤z«Iº\èú\'ŠÀ”f~Œn¢&šýs{S¡¼}	>Gê›€\ä\ëÈ¯;Úœ4‹³:W}\Ä\ì\Ì\ê\àR\ß\ç8:{0YÒ‘VM\ï\ÂG¹ì¿EH¦óŒp<I2«X\Í÷ºY[\"\n\Ó\ã$DGžVnºj\"b‚T\é5dF!#!xS6ž¾pS\í*\ÖÛ“¬ô«Š>\åa§c™wª7k•VÈ˜{|™•\Ý¶CY|º8\Ça\è\Ã\Æ\È=©º\nœF#{:ŸR,˜0ƒiI„4‰Œ ¯\ê 7•ÀjJŸ\n©¢ûNŠ\Øú×±\ÇgIV¶\ß\ã¥+So²Â«\n\í{¬\\©µTq¥¦ô©Ð›!\ÆT\Ñé¤¸R9‘\ÇJkû²\ØöLi`£mJ„& å³ \íÃ¢EújúSµx*¤\ç\n­\Èô,\0U\Z2?õ\Ä#T¤\éD,…C>.‚Ö£ZAH\æ¬Z{¢p\ØÀ‚\Óy\ÂZ=^%8\ëV×¸\Ê.uŠ\ntrñö»lµ\Äs?Ÿõ±\Ü	\×ru‡7\èx¾¾.\ßÇ¬Cj»³8‘Ã²Ð©ó¡ªL\Öušcê¥¿K:\é‹d}ô÷g\Ð.: eO]\r]‡o _u\Ú~`ð\åqÀ\âZI«I—MR4\Í\î’Y6Ó®P1\Ùö\îÒ‘¼%h›ÁkW‹¯£Ÿ\nx{ƒ^\è´/’õ\ÕM\0&\Ø\ßôÉ¦Ö—*&\ÕT€°öBH\è-–2§J\á¨Mhg½\í ì°¯¢î´­c\îXT„Ž\Å*²ŽùZ\æ®\ÍYdý|\rýŒ\í\ÐÜœQjñ\Ü\Ô\ÑwÛœ\ã\ÚôÝœDhûn\ê\èûnNk,Q­Ò±L j\'#¤©…\à\Ö\ÈVI­ \"òÀ¼M+d•tüN\â³%„R¹ô²²s¥ŸQM4BS\îzÏ¨òœ!ýS\ß½Ò”óƒ\"¯À\ì\Ôhiƒ\nº¤Tu\ÂOÿ=\È\Â\Ü\Öm¢\Òdòùšó6„š¶L1mÛ³eÁP f\r\Ð Áb@:\é<&„Ht»Œ%\ØÅ«\î˜\ém\Ý\ÕqCga(Ys`5>²¶(’¹\Ö¢ŸñDE\ÍPk(\ÝG†\ã`T\"\n\Ú*I\é4\í+\ÛPÄ¿òC\å\Ç‘\Ã\É:\"S¿Š?¿‰±fŠB\íLGrÛ›\ÃÁP+-Xë¦…\×\Çù­\ëž#\ÆcIa\ÚbÏ´™£\Éj\Ü\í\'‡±?‡‰‚bŽ$s·Ub&\ÆôTó\ê?jP¢6£A9(D\Æ\ZIù\ï±iöŠ¨÷ýa´-}­!(\ÅJ}rcžlÐœ_jø\áò“\íˆû\ïú\éšD­\Ã$%nñ’išœ\ç¥ôe5b¶@3U\ÕI\'¥/ô—*÷m™P\0¹z\ë]h!Á—i\Ð–1P`Œ@o\æA\Ð0¼\ÐTx\áB!ñ\×	\ÊSja4¥Á‘B]É˜ñ¢p-5V%\0\"\Úóu3d~“ƒSs PGS\Z)\ÍÍ’\'÷¾ÁQ²™ô.3#\Ì\ÅMmids_$ƒ®j1\ê\Å+KWÜ›<„´\îX~\Ä\ÂI£¿ML\ßyõteG‹úN«ù@~i†nñyº\Æq^}=Z\\\î’òqªú\×)Î£\Û\Ä™\à\ÊÅ¬\Ú\Ö9Kn\ÒÖ±‰Q[…\Ë\ÚŽDTô&+¢´*HqùU”\Ü\Îg\Õ?¥|¸\Æ\ë³\äÓ®\Ø\î\n2e¼¹Ž½ªtŠ\Òõ´\Æ|ô©z“512\ÌJ»ù”ü´‹\âu7\îw’ Jo«\æQ–r-‹òq–Û‡\Ò\Ç4j\Ð\×9‰}\ÆD¸–\Êß§d‰¾a—±‚ü€o\Ñ\ê¡0HÄ¼,ÚN#t›¡M\ÞÀ\èÛ“Ÿ„†×›û¿þ?þ\Í\rE\Å\0','6.1.3-40302');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `agencies`
--

DROP TABLE IF EXISTS `agencies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `agencies` (
  `AgencyId` int(11) NOT NULL AUTO_INCREMENT,
  `AspNetUserId` varchar(128) DEFAULT NULL,
  `AgencyName` longtext,
  `AgencyLogo` longtext,
  `AgencyWebsiteURL` longtext,
  `ManagerFirstName` longtext,
  `ManagerLastName` longtext,
  `ManagerAge` longtext,
  `CompanyActivityDesc` longtext,
  `CountryId` int(11) DEFAULT NULL,
  `CityId` int(11) DEFAULT NULL,
  `DistrictId` int(11) DEFAULT NULL,
  `ProfileVerified` tinyint(1) NOT NULL,
  `CreatedBy` longtext,
  `CreatedDate` longtext,
  `UpdatedBy` longtext,
  `UpdatedDate` longtext,
  `ApplicationUser_Id` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`AgencyId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agencies`
--

LOCK TABLES `agencies` WRITE;
/*!40000 ALTER TABLE `agencies` DISABLE KEYS */;
INSERT INTO `agencies` VALUES (1,NULL,'Agency 2','E:\\Personal\\Projects\\HireMe\\JobTek\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181104-health_plan_erd.png','http://sqlfiddle.com/','Bibhab',NULL,NULL,'dasfdasf adfas adsfasf',NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,'6c4e7873-967e-42f1-8466-7385c50babac');
/*!40000 ALTER TABLE `agencies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `applicationusersecurityquestionanswers`
--

DROP TABLE IF EXISTS `applicationusersecurityquestionanswers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `applicationusersecurityquestionanswers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AspNetUserId` varchar(128) DEFAULT NULL,
  `SecurityQuestionId` int(11) NOT NULL,
  `Answer` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserId` (`AspNetUserId`) USING HASH,
  KEY `IX_SecurityQuestionId` (`SecurityQuestionId`) USING HASH,
  CONSTRAINT `FK_608d5cd3f97a476ba0f5454254865ef7` FOREIGN KEY (`SecurityQuestionId`) REFERENCES `securityquestions` (`SecurityQuestionId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_d5c9de396e5e43519bceb4f2c094eddd` FOREIGN KEY (`AspNetUserId`) REFERENCES `aspnetusers` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicationusersecurityquestionanswers`
--

LOCK TABLES `applicationusersecurityquestionanswers` WRITE;
/*!40000 ALTER TABLE `applicationusersecurityquestionanswers` DISABLE KEYS */;
INSERT INTO `applicationusersecurityquestionanswers` VALUES (2,'17e8f579-d48d-4076-be1f-5a34dc314167',1,'ddlj'),(3,'4c443678-ccf3-41e7-9580-a46f5f9be230',1,'DDLJ'),(4,'1c658a7d-7eb6-4653-9a1b-2877be90838c',1,'DDLJ'),(5,'3c61b87d-3c7f-492e-8474-148da07d052e',1,'DDLJ'),(6,'6c4e7873-967e-42f1-8466-7385c50babac',1,'DDLJ'),(7,'08c04037-dde2-471d-9ffc-eba16fa7aa01',1,'DDlJ'),(8,'c6bfa92a-13c4-4ba5-b555-9c556c389389',1,'DDLJ');
/*!40000 ALTER TABLE `applicationusersecurityquestionanswers` ENABLE KEYS */;
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
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`Name`) USING HASH
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
INSERT INTO `aspnetroles` VALUES ('dd8d9d4f-9fa2-4205-b88d-52ef13f1ff26','Admin'),('f2108fdf-f316-4932-b9a2-746730fb47cb','Agency'),('60d85a66-c870-4ce7-9031-72d5ffc14b1f','Candidate'),('b46b8bb3-bad8-4001-8a6d-33ecc76e6d1d','Employer');
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
  KEY `IX_UserId` (`UserId`) USING HASH,
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
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
  KEY `IX_UserId` (`UserId`) USING HASH,
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
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
  KEY `IX_UserId` (`UserId`) USING HASH,
  KEY `IX_RoleId` (`RoleId`) USING HASH,
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
INSERT INTO `aspnetuserroles` VALUES ('08c04037-dde2-471d-9ffc-eba16fa7aa01','b46b8bb3-bad8-4001-8a6d-33ecc76e6d1d'),('17e8f579-d48d-4076-be1f-5a34dc314167','60d85a66-c870-4ce7-9031-72d5ffc14b1f'),('1c658a7d-7eb6-4653-9a1b-2877be90838c','b46b8bb3-bad8-4001-8a6d-33ecc76e6d1d'),('3c61b87d-3c7f-492e-8474-148da07d052e','60d85a66-c870-4ce7-9031-72d5ffc14b1f'),('4c443678-ccf3-41e7-9580-a46f5f9be230','b46b8bb3-bad8-4001-8a6d-33ecc76e6d1d'),('6c4e7873-967e-42f1-8466-7385c50babac','f2108fdf-f316-4932-b9a2-746730fb47cb'),('c6bfa92a-13c4-4ba5-b555-9c556c389389','b46b8bb3-bad8-4001-8a6d-33ecc76e6d1d');
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
  `FirstName` longtext,
  `LastName` longtext,
  `Address` longtext,
  `ProfilePicUrl` longtext,
  `ActiveUntil` datetime DEFAULT NULL,
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
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`UserName`) USING HASH
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES ('08c04037-dde2-471d-9ffc-eba16fa7aa01','Employer 1 First Name','Employer 1 Last Name','lakjsdl akajdjsflj','E:\\Personal\\Projects\\HireMe\\JobTek\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181104-health_plan_class_Diagram.jpg',NULL,'employer1@gmail.com',0,'AGU1/PuUhRPJQ/mRMILhudcn20ETFkka0mCBKUwMtpbQCP/40cOBPSLSH7Hq1Q6s8g==','df5da492-8671-4787-b05f-3efdf4b744c0','9999999999',0,0,NULL,1,0,'employer1@gmail.com'),('17e8f579-d48d-4076-be1f-5a34dc314167','Akshaya Kumar','Dash','BBSR','E:\\Personal\\Projects\\HireMe\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181101-health_plan_erd.png',NULL,'akshayakdash@gmail.com',0,'AOmj0mXTGco+CzbHoso6lFh/eaxZLdyB/JILRf6k7d2VW1CXgtx6Q3n6oA63cx9eCw==','447a3012-5281-4bbf-be86-d1ec915c1fd0','9861696748',0,0,NULL,1,0,'akshayakdash@gmail.com'),('1c658a7d-7eb6-4653-9a1b-2877be90838c','Bhairab','Meher','Rasulgarh, BBSR','E:\\Personal\\Projects\\HireMe\\JobTek\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181104-health_plan_erd.png',NULL,'bhairab.meher@gmail.com',0,'AEBdgLDXaCnPAxdjNg0BAA+YTCLUATMHg2SseBTRKWqxXLe4gtifEsLp2Xx5BSlTNg==','f1cb03f2-3784-4ac4-9157-e80838b91e9b','9999999999',0,0,NULL,1,0,'bhairab.meher@gmail.com'),('3c61b87d-3c7f-492e-8474-148da07d052e','Agency First Name','Agency Last Name','Agency sample address','E:\\Personal\\Projects\\HireMe\\JobTek\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181104-health_plan_erd.png',NULL,'agency1@gmail.com',0,'ADp2efk258iWNapUKASzrnUapz5+GbdGqaFo7Ienx9YLrwmqpDAEVGo64EWjNWJcwA==','10ab4ead-e5a3-45ef-8d4e-df672ca116fa','9999999999',0,0,NULL,1,0,'agency1@gmail.com'),('4c443678-ccf3-41e7-9580-a46f5f9be230','Siddharth','Ray','Khandagiri, BBSR','E:\\Personal\\Projects\\HireMe\\JobTek\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181104-health_plan_erd.png',NULL,'siddharth.ray@gmail.com',0,'AKFwKozPKHuslXFQ3xdUmrYHXU4QMhtnHa7sJd9bnQw4BomvxPmjqdJfeHMvru1zfQ==','665cd95d-0ffc-419c-8155-58901864e27e','9999999999',0,0,NULL,1,0,'siddharth.ray@gmail.com'),('6c4e7873-967e-42f1-8466-7385c50babac','Agency 2','Agency 2 Last Name','adfa a adf','E:\\Personal\\Projects\\HireMe\\JobTek\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181104-health_plan_erd.png',NULL,'agency2@gmail.com',0,'AFVvWASXr4qpCXFH9IxDZpX8anIuhVLI0dZYTZW5RWkuwmhGV04bNQq4hL+dG2ZldQ==','53041cf0-75f4-44b8-835a-3b2e5a85d2df','9999999999',0,0,NULL,1,0,'agency2@gmail.com'),('c6bfa92a-13c4-4ba5-b555-9c556c389389','Employer 2','Last Name','lakdjjflad alkdfjlj','E:\\Personal\\Projects\\HireMe\\JobTek\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181104-health_plan_erd.png',NULL,'employer2@gmail.com',0,'AGpfS4MmszCd668CEDqeJkiU3EX7OrESxyqxR/MygQn10phDXpyCfpQ+ibSo9Ax34Q==','c788b82d-49a4-4358-b7d6-554fcba1bcf4','9999999999',0,0,NULL,1,0,'employer2@gmail.com');
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidates`
--

DROP TABLE IF EXISTS `candidates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `candidates` (
  `CandidateId` int(11) NOT NULL AUTO_INCREMENT,
  `AspNetUserId` varchar(128) DEFAULT NULL,
  `AgencyId` int(11) DEFAULT NULL,
  `Gender` int(11) NOT NULL,
  `Age` int(11) DEFAULT NULL,
  `ExperienceInYears` int(11) DEFAULT NULL,
  `ExperienceInMonths` int(11) DEFAULT NULL,
  `IdProofDoc` longtext,
  `IdProofDocDesc` longtext,
  `ProfileVerified` tinyint(1) NOT NULL,
  `StaffType` int(11) NOT NULL,
  `Disponibility` datetime NOT NULL,
  `CountryId` int(11) DEFAULT NULL,
  `CityId` int(11) DEFAULT NULL,
  `DistrictId` int(11) DEFAULT NULL,
  `SalaryType` int(11) NOT NULL,
  `SalaryTypeOtherDesc` longtext,
  `CanRead` tinyint(1) NOT NULL,
  `CanWrite` tinyint(1) NOT NULL,
  `ExpectedMinSalary` decimal(18,2) NOT NULL,
  `ExpectedMaxSalary` decimal(18,2) NOT NULL,
  `SleepOnSite` tinyint(1) NOT NULL,
  `ExpectedMinRooms` int(11) DEFAULT NULL,
  `ExpectedMaxRooms` int(11) DEFAULT NULL,
  `MinGroupPeople` int(11) DEFAULT NULL,
  `MaxGroupPeople` int(11) DEFAULT NULL,
  `CreatedDate` longtext,
  `CreatedBy` longtext,
  `UpdatedDate` longtext,
  `UpdatedBy` longtext,
  `AdditionalDescription` longtext,
  `UserName` longtext,
  `ProfilePicUrl` longtext,
  `FirstName` longtext,
  `LastName` longtext,
  `ContactNo` longtext,
  `EmailId` longtext,
  `Address` longtext,
  PRIMARY KEY (`CandidateId`),
  KEY `IX_AspNetUserId` (`AspNetUserId`) USING HASH,
  KEY `IX_AgencyId` (`AgencyId`) USING HASH,
  CONSTRAINT `FK_Candidates_Agencies_AgencyId` FOREIGN KEY (`AgencyId`) REFERENCES `agencies` (`AgencyId`),
  CONSTRAINT `FK_Candidates_AspNetUsers_AspNetUserId` FOREIGN KEY (`AspNetUserId`) REFERENCES `aspnetusers` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidates`
--

LOCK TABLES `candidates` WRITE;
/*!40000 ALTER TABLE `candidates` DISABLE KEYS */;
INSERT INTO `candidates` VALUES (1,'17e8f579-d48d-4076-be1f-5a34dc314167',NULL,0,28,3,NULL,NULL,NULL,0,0,'2017-11-10 00:00:00',NULL,NULL,NULL,0,NULL,1,1,2500.00,5000.00,0,4,5,5,7,NULL,NULL,NULL,NULL,'xczvczvzz zfgsgfd','Akshaya','E:\\Personal\\Projects\\HireMe\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181101-health_plan_erd.png',NULL,NULL,NULL,NULL,NULL),(6,NULL,1,0,23,5,NULL,NULL,NULL,0,1,'2018-11-10 00:00:00',NULL,NULL,NULL,0,NULL,1,1,2000.00,5000.00,1,2,6,2,6,NULL,NULL,NULL,NULL,'sdasfd asdffasdf',NULL,NULL,'Candidate@Agency2','lkjlkj','9999999999','candidate1.agency2@gmail.com','adsfasd asdadsf asdf');
/*!40000 ALTER TABLE `candidates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `countryjobtaskmappers`
--

DROP TABLE IF EXISTS `countryjobtaskmappers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `countryjobtaskmappers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `JobTaskId` int(11) NOT NULL,
  `CountryId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_JobTaskId` (`JobTaskId`) USING HASH,
  CONSTRAINT `FK_CountryJobTaskMappers_JobTasks_JobTaskId` FOREIGN KEY (`JobTaskId`) REFERENCES `jobtasks` (`JobTaskId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `countryjobtaskmappers`
--

LOCK TABLES `countryjobtaskmappers` WRITE;
/*!40000 ALTER TABLE `countryjobtaskmappers` DISABLE KEYS */;
/*!40000 ALTER TABLE `countryjobtaskmappers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employers`
--

DROP TABLE IF EXISTS `employers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employers` (
  `EmployerId` int(11) NOT NULL AUTO_INCREMENT,
  `AspNetUserId` varchar(128) DEFAULT NULL,
  `Gender` int(11) NOT NULL,
  `CountryId` int(11) NOT NULL,
  `CityId` int(11) NOT NULL,
  `DistrictId` int(11) NOT NULL,
  `ProfileVerified` tinyint(1) NOT NULL,
  `CreatedBy` longtext,
  `CreatedDate` longtext,
  `UpdatedBy` longtext,
  `UpdatedDate` longtext,
  `ApplicationUser_Id` varchar(128) DEFAULT NULL,
  `FirstName` longtext,
  `LastName` longtext,
  PRIMARY KEY (`EmployerId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employers`
--

LOCK TABLES `employers` WRITE;
/*!40000 ALTER TABLE `employers` DISABLE KEYS */;
INSERT INTO `employers` VALUES (1,'4c443678-ccf3-41e7-9580-a46f5f9be230',0,0,0,0,0,NULL,NULL,NULL,NULL,'4c443678-ccf3-41e7-9580-a46f5f9be230',NULL,NULL),(2,NULL,0,0,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3,'c6bfa92a-13c4-4ba5-b555-9c556c389389',0,0,0,0,0,NULL,NULL,NULL,NULL,NULL,'Employer 2','Last Name');
/*!40000 ALTER TABLE `employers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobcategories`
--

DROP TABLE IF EXISTS `jobcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobcategories` (
  `JobCategoryId` int(11) NOT NULL AUTO_INCREMENT,
  `CategoryName` longtext,
  `Description` longtext,
  `IconImage` longtext,
  PRIMARY KEY (`JobCategoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobcategories`
--

LOCK TABLES `jobcategories` WRITE;
/*!40000 ALTER TABLE `jobcategories` DISABLE KEYS */;
INSERT INTO `jobcategories` VALUES (1,'Home Job','','/assets/images/home-icon.png'),(2,'Troubleshooting',NULL,'/assets/images/settings-icon.png'),(3,'HairStyle/Care',NULL,'/assets/images/salon-icon.png'),(4,'Ceremony Organization',NULL,'/assets/images/ceremony-icon.png'),(5,'Course',NULL,'/assets/images/course-icon.png');
/*!40000 ALTER TABLE `jobcategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobofferjobtasks`
--

DROP TABLE IF EXISTS `jobofferjobtasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobofferjobtasks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `JobOfferId` int(11) NOT NULL,
  `EmployerId` int(11) NOT NULL,
  `JobTaskId` int(11) NOT NULL,
  `TaskResponse` longtext,
  `TaskResponseAdditionalDescription` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_JobOfferId` (`JobOfferId`) USING HASH,
  KEY `IX_JobTaskId` (`JobTaskId`) USING HASH,
  CONSTRAINT `FK_JobOfferJobTasks_JobOffers_JobOfferId` FOREIGN KEY (`JobOfferId`) REFERENCES `joboffers` (`JobOfferId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_JobOfferJobTasks_JobTasks_JobTaskId` FOREIGN KEY (`JobTaskId`) REFERENCES `jobtasks` (`JobTaskId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobofferjobtasks`
--

LOCK TABLES `jobofferjobtasks` WRITE;
/*!40000 ALTER TABLE `jobofferjobtasks` DISABLE KEYS */;
INSERT INTO `jobofferjobtasks` VALUES (1,1,0,1,NULL,NULL),(2,1,0,2,NULL,NULL),(3,1,0,3,NULL,NULL),(4,1,0,4,NULL,NULL),(5,1,0,5,NULL,NULL),(6,2,0,1,NULL,NULL),(7,2,0,2,NULL,NULL),(8,2,0,3,NULL,NULL),(9,2,0,4,NULL,NULL),(10,2,0,5,NULL,NULL),(11,3,0,1,NULL,NULL),(12,3,0,2,NULL,NULL),(13,3,0,3,NULL,NULL),(14,3,0,4,NULL,NULL),(15,3,0,5,NULL,NULL);
/*!40000 ALTER TABLE `jobofferjobtasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `joboffers`
--

DROP TABLE IF EXISTS `joboffers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `joboffers` (
  `JobOfferId` int(11) NOT NULL AUTO_INCREMENT,
  `JobId` int(11) NOT NULL,
  `EmployerId` int(11) NOT NULL,
  `Gender` int(11) NOT NULL,
  `Age` int(11) NOT NULL,
  `ExperienceInYears` int(11) NOT NULL,
  `ExperienceInMonths` int(11) NOT NULL,
  `IdProofDoc` longtext,
  `IdProofDocDesc` longtext,
  `ProfileVerified` tinyint(1) NOT NULL,
  `StaffType` int(11) NOT NULL,
  `Disponibility` datetime NOT NULL,
  `CountryId` int(11) NOT NULL,
  `CityId` int(11) NOT NULL,
  `DistrictId` int(11) NOT NULL,
  `SalaryType` int(11) NOT NULL,
  `SalaryTypeOtherDesc` longtext,
  `CanRead` tinyint(1) NOT NULL,
  `CanWrite` tinyint(1) NOT NULL,
  `ExpectedMinSalary` decimal(18,2) NOT NULL,
  `ExpectedMaxSalary` decimal(18,2) NOT NULL,
  `SleepOnSite` tinyint(1) NOT NULL,
  `ExpectedMinRooms` int(11) NOT NULL,
  `ExpectedMaxRooms` int(11) NOT NULL,
  `MinGroupPeople` int(11) NOT NULL,
  `MaxGroupPeople` int(11) NOT NULL,
  `PublishedDate` datetime NOT NULL,
  `ValidTill` datetime NOT NULL,
  `IsPublished` tinyint(1) NOT NULL,
  `MinAge` int(11) NOT NULL,
  `MaxAge` int(11) NOT NULL,
  `AdditionalDescription` longtext,
  PRIMARY KEY (`JobOfferId`),
  KEY `IX_EmployerId` (`EmployerId`) USING HASH,
  CONSTRAINT `FK_JobOffers_Employers_EmployerId` FOREIGN KEY (`EmployerId`) REFERENCES `employers` (`EmployerId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `joboffers`
--

LOCK TABLES `joboffers` WRITE;
/*!40000 ALTER TABLE `joboffers` DISABLE KEYS */;
INSERT INTO `joboffers` VALUES (1,1,1,0,0,5,0,NULL,NULL,0,1,'2018-11-10 00:00:00',0,0,0,0,NULL,1,1,2000.00,5000.00,1,5,7,2,7,'2018-11-04 04:57:20','0001-01-01 00:00:00',1,20,30,NULL),(2,1,2,0,0,5,0,NULL,NULL,0,0,'0001-01-01 00:00:00',0,0,0,0,NULL,1,1,2000.00,5000.00,1,2,8,2,8,'2018-11-04 15:20:41','0001-01-01 00:00:00',1,25,30,NULL),(3,1,3,0,0,5,0,NULL,NULL,0,0,'2017-10-01 00:00:00',0,0,0,0,NULL,1,1,2000.00,5000.00,1,5,7,2,9,'2018-11-04 16:04:08','0001-01-01 00:00:00',1,25,30,'I am looking for a Nanny');
/*!40000 ALTER TABLE `joboffers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobrequestjobtasks`
--

DROP TABLE IF EXISTS `jobrequestjobtasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobrequestjobtasks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `JobRequestId` int(11) NOT NULL,
  `JobTaskId` int(11) NOT NULL,
  `TaskResponse` longtext,
  `TaskResponseAdditionalDescription` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_JobRequestId` (`JobRequestId`) USING HASH,
  KEY `IX_JobTaskId` (`JobTaskId`) USING HASH,
  CONSTRAINT `FK_JobRequestJobTasks_JobRequests_JobRequestId` FOREIGN KEY (`JobRequestId`) REFERENCES `jobrequests` (`JobRequestId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_JobRequestJobTasks_JobTasks_JobTaskId` FOREIGN KEY (`JobTaskId`) REFERENCES `jobtasks` (`JobTaskId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobrequestjobtasks`
--

LOCK TABLES `jobrequestjobtasks` WRITE;
/*!40000 ALTER TABLE `jobrequestjobtasks` DISABLE KEYS */;
INSERT INTO `jobrequestjobtasks` VALUES (1,1,1,NULL,NULL),(2,1,2,NULL,NULL),(3,1,3,NULL,NULL),(4,1,4,NULL,NULL),(9,3,1,'dfssg sfdgsdfg sfdgsdg',NULL),(10,3,2,'asdfasf',NULL),(11,3,3,'adsfas',NULL),(12,3,4,'adsfsaf',NULL);
/*!40000 ALTER TABLE `jobrequestjobtasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobrequests`
--

DROP TABLE IF EXISTS `jobrequests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobrequests` (
  `JobRequestId` int(11) NOT NULL AUTO_INCREMENT,
  `CandidateId` int(11) NOT NULL,
  `JobId` int(11) NOT NULL,
  `IsPublished` tinyint(1) NOT NULL,
  `PublishedDate` datetime NOT NULL,
  `ValidTill` datetime NOT NULL,
  `JobRequestDescription` longtext,
  PRIMARY KEY (`JobRequestId`),
  KEY `IX_CandidateId` (`CandidateId`) USING HASH,
  KEY `IX_JobId` (`JobId`) USING HASH,
  CONSTRAINT `FK_JobRequests_Candidates_CandidateId` FOREIGN KEY (`CandidateId`) REFERENCES `candidates` (`CandidateId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_JobRequests_Jobs_JobId` FOREIGN KEY (`JobId`) REFERENCES `jobs` (`JobId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobrequests`
--

LOCK TABLES `jobrequests` WRITE;
/*!40000 ALTER TABLE `jobrequests` DISABLE KEYS */;
INSERT INTO `jobrequests` VALUES (1,1,1,1,'2018-11-04 01:38:04','0001-01-01 00:00:00','xczvczvzz zfgsgfd'),(3,6,1,1,'2018-11-04 14:37:54','0001-01-01 00:00:00','sdasfd asdffasdf');
/*!40000 ALTER TABLE `jobrequests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobs`
--

DROP TABLE IF EXISTS `jobs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobs` (
  `JobId` int(11) NOT NULL AUTO_INCREMENT,
  `JobName` longtext,
  `JobCategoryId` int(11) NOT NULL,
  `JobDesc` longtext,
  `IconImage` longtext,
  `JobGroup` longtext,
  PRIMARY KEY (`JobId`),
  KEY `IX_JobCategoryId` (`JobCategoryId`) USING HASH,
  CONSTRAINT `FK_Jobs_JobCategories_JobCategoryId` FOREIGN KEY (`JobCategoryId`) REFERENCES `jobcategories` (`JobCategoryId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobs`
--

LOCK TABLES `jobs` WRITE;
/*!40000 ALTER TABLE `jobs` DISABLE KEYS */;
INSERT INTO `jobs` VALUES (1,'Nanny',1,NULL,NULL,'Internal Home Job'),(2,'Cook',1,NULL,NULL,'Internal Home Job'),(3,'Guardian',1,NULL,NULL,'External Home Job'),(4,'Plumber',2,NULL,NULL,NULL),(5,'Electrician',2,NULL,NULL,NULL),(6,'Hair Dresser',3,NULL,NULL,NULL),(7,'Manicure/Pedicure/Massage',3,NULL,NULL,NULL),(8,'Server/Caterer',4,NULL,NULL,NULL),(9,'Decorator',4,NULL,NULL,NULL),(10,'School Support',5,NULL,NULL,NULL),(11,'Music Course',5,NULL,NULL,NULL);
/*!40000 ALTER TABLE `jobs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobtasks`
--

DROP TABLE IF EXISTS `jobtasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobtasks` (
  `JobTaskId` int(11) NOT NULL AUTO_INCREMENT,
  `JobId` int(11) NOT NULL,
  `JobTaskName` longtext,
  `JobTaskDescription` longtext,
  `TaskSectionName` longtext,
  `TaskGroupName` longtext,
  `TaskParamType` int(11) NOT NULL,
  `TaskParamValueType` int(11) NOT NULL,
  `ParamAvailableOptions` longtext,
  `ParentJobTaskId` int(11) DEFAULT NULL,
  PRIMARY KEY (`JobTaskId`),
  KEY `IX_JobId` (`JobId`) USING HASH,
  KEY `IX_ParentJobTaskId` (`ParentJobTaskId`) USING HASH,
  CONSTRAINT `FK_JobTasks_JobTasks_ParentJobTaskId` FOREIGN KEY (`ParentJobTaskId`) REFERENCES `jobtasks` (`JobTaskId`),
  CONSTRAINT `FK_JobTasks_Jobs_JobId` FOREIGN KEY (`JobId`) REFERENCES `jobs` (`JobId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobtasks`
--

LOCK TABLES `jobtasks` WRITE;
/*!40000 ALTER TABLE `jobtasks` DISABLE KEYS */;
INSERT INTO `jobtasks` VALUES (1,1,'Cleaning',NULL,NULL,NULL,1,0,NULL,NULL),(2,1,'Cooking',NULL,NULL,NULL,1,0,NULL,NULL),(3,1,'African Food',NULL,NULL,NULL,1,0,NULL,2),(4,1,'Sauce',NULL,NULL,NULL,1,0,NULL,3),(5,1,'Grill',NULL,NULL,NULL,1,0,NULL,3),(6,1,'European Food',NULL,NULL,NULL,1,0,NULL,2),(7,1,'Oven',NULL,NULL,NULL,1,0,NULL,6),(8,1,'Dessert',NULL,NULL,NULL,1,0,NULL,6);
/*!40000 ALTER TABLE `jobtasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobtek.candidatefavouritejoboffer`
--

DROP TABLE IF EXISTS `jobtek.candidatefavouritejoboffer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobtek.candidatefavouritejoboffer` (
  `CandidateId` int(11) NOT NULL,
  `JobOfferId` int(11) NOT NULL,
  PRIMARY KEY (`CandidateId`,`JobOfferId`),
  KEY `IX_CandidateId` (`CandidateId`) USING HASH,
  KEY `IX_JobOfferId` (`JobOfferId`) USING HASH,
  CONSTRAINT `FK_jobtek.CandidateFavouriteJobOffer_Candidates_CandidateId` FOREIGN KEY (`CandidateId`) REFERENCES `candidates` (`CandidateId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_jobtek.CandidateFavouriteJobOffer_JobOffers_JobOfferId` FOREIGN KEY (`JobOfferId`) REFERENCES `joboffers` (`JobOfferId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobtek.candidatefavouritejoboffer`
--

LOCK TABLES `jobtek.candidatefavouritejoboffer` WRITE;
/*!40000 ALTER TABLE `jobtek.candidatefavouritejoboffer` DISABLE KEYS */;
/*!40000 ALTER TABLE `jobtek.candidatefavouritejoboffer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jobtek.employerfavouritejobrequest`
--

DROP TABLE IF EXISTS `jobtek.employerfavouritejobrequest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobtek.employerfavouritejobrequest` (
  `CandidateId` int(11) NOT NULL,
  `JobRequestId` int(11) NOT NULL,
  PRIMARY KEY (`CandidateId`,`JobRequestId`),
  KEY `IX_CandidateId` (`CandidateId`) USING HASH,
  KEY `IX_JobRequestId` (`JobRequestId`) USING HASH,
  CONSTRAINT `FK_dc9ed1ce69f549e484d133adfd15cbd9` FOREIGN KEY (`JobRequestId`) REFERENCES `jobrequests` (`JobRequestId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_jobtek.EmployerFavouriteJobRequest_Employers_CandidateId` FOREIGN KEY (`CandidateId`) REFERENCES `employers` (`EmployerId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobtek.employerfavouritejobrequest`
--

LOCK TABLES `jobtek.employerfavouritejobrequest` WRITE;
/*!40000 ALTER TABLE `jobtek.employerfavouritejobrequest` DISABLE KEYS */;
/*!40000 ALTER TABLE `jobtek.employerfavouritejobrequest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `securityquestions`
--

DROP TABLE IF EXISTS `securityquestions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `securityquestions` (
  `SecurityQuestionId` int(11) NOT NULL AUTO_INCREMENT,
  `Question` longtext,
  `AnswerType` int(11) NOT NULL,
  PRIMARY KEY (`SecurityQuestionId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `securityquestions`
--

LOCK TABLES `securityquestions` WRITE;
/*!40000 ALTER TABLE `securityquestions` DISABLE KEYS */;
INSERT INTO `securityquestions` VALUES (1,'What is your favourite movie ?',0),(2,'What is your favourite food ?',0);
/*!40000 ALTER TABLE `securityquestions` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-04 16:11:44
