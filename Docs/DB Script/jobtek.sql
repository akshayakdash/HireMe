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
INSERT INTO `__migrationhistory` VALUES ('201810312003598_initial','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\å][o\ã¸~/\Ğÿ \è±\ÈÚ¹\ìL§½‹Œ“tƒ\ÆI:N}h‰v„\Ñ\Å+Q™E\Ù>\ìO\ê_(©+¯%K¶<\Å‹˜\"?’\çòœù\ï\ïL~~ó\\\ã†‘øSódtl\ZĞ·\Ûñ\×S3F«>™?ÿô\ç?M®l\ï\Íø5¯wF\ê\á–~45_ÚœÇ‘õ=<\Ç\nƒ(X¡‘xc`\ã\Ó\ãã¿ON\Æ“01-Ã˜|‰}\äx0ù\Îß‚w\ØĞ²rüe‘P5\î€£\r°\à\Ôü\Å	\áÒŠ¦q\á:\03±€\î\Ê4€\ï \Ì\âùS(üõbƒ€ûø¾¸\Ş\n¸\ÌX?/«\ë\âø”Œb\\6\ÌIYq„¯!Á“³L,c¾y+áš…Ø°à®°€\Ñ;u\"¼©ycÃ¤\èK\àbğ\ÏÜTšó¢‹‹hs\Ñ(o8JI^‡˜Ü· ü:¢)\Ú\í\n\ÉG\Æ,vQÂ©c÷\Èxˆ—®cı¾?_¡?=;Y®\Î>}øì³?Â³ôHñXq=¦\0=„Á†˜7¸*\Æo\Zc¶İ˜oX4£Ú¤RÁX\Â+\Â4\æ\à\íúkô‚\×\Ê\é\'Ó¸vŞ —d\àzò¼€p#\Æø\ç]\ìº`\é\Â\âû¸²OòÿŠ^O?|\ì¤\×;ğê¬“©\çú\Ç\'\Ä\ë\êt“¯Ñ‹³I—3\ß\ÏYµ\ë0ğ\Èo_\é\×\çE‡L ¬ò\Â5D,w“q	^-HR\İ\Ã:§:|hNExK«’µY	y»^\r9¿ıö«¸´\âı3†QºO«\ÇT#¾å‘‘~/!s¢¥\rLx\Ú\à@F#î\ÎN%r¦D³@Aÿ}\í€ır\×a¡º\røO-4Twt\áG\ß`2‹EWdÿ{\0x§¥İ \éb³ÁóšÈ†¬/}0q\r÷€¥C9M¯0B5Gj7 ¹;\ê\èÂ¶CE½÷ƒ®>8\ÖS\èö?*9¯ğ	/‘¢¯K¼K<:^m\Ó+8U\êªL\Z½`Ce\å„,ü9Àğ\ãòD\Ö\ì_@ôÒ»lóM{€·\é7/\ïboIv´\İõ\Õ\Ù\Ô<~®…ª+Ÿ´Úš\Şm`}\rbt\å\Û\ĞO\ÈjŠ\ï‚@\'\ì\\X\Ş=®1˜¡=°^w€W“#\çÏ¾M–™On³p\'\ås^µ´[\ä5\ÛEQMf¿T±z¬_Õ¼ªšÕ´F-«Yµ¦¬bzœf5ÕŒ&jùLkuf&3Ô½I˜¾M¸‚Ö¿2¿/ƒ2™>Fµ\ï\ëlJzú¸q\×]µZ\r\É&\ĞıjH\È5$l\â\âW\Ç&Z‰†£$¯Œ\ÉkÕ—û`\ê\×\ÇÙ®—3\Ì]w¾›= ­9Î»:R¯@k#]N\î\àL÷şO†t\éz¦‘¾?K\Çu\ÔıÙ¢\Ô\ÒR½¾&G\â³@I©\Ï\é¨\Ó÷4©4U[Emk‰ˆ¤šŠ„/n)L3%9ö¨]òb\ŞD\×.X—·¢º;[Ab\Û\İƒŸ=\î;^$ô¢cgz‰yŸ\çğ\r;Ñª¦æ±€\n¦\î\ìZ_?oEı“\êú\Äp¬¯ûY‹\Ó\ê¹—#«}V]#Zˆf\èGqÓ¹¢/¢(°œdB$W¹\ÙE\Û\í•oõ·r¥g›½\ã©s,q	\Z¤\Üû—x$\Z\ÄgG®ºg ²€-nZx8v\ÆrPK+oøX\æş\"ô‰\Ï9’F€8\ë\"Œ=\ÇG\â¡\èø–³n­”¸–š*{\Ñÿ\ån O:¬•„N\çò=\Â@\Ñ7)ušŒ)\ÄUQ\á]Q\Íy«¥œw\á,\Ú	&k|<\n\\f~†^€Y-±€³Z$:(/§÷\ĞÌ§¦\0\ŞÁ64€r=@3\Ó\'\0e%¶€²\"98€¦®T\İù\çüªCƒ\'\ë\Ğ\İı±^)®=`“‘Ç¡AS\Ój\Ô\ÄFSR	m•—¦P\Ûr&AuÍ¢;D¤\\7\ãx÷¸o6\×:ü±.¢¯Áƒ°\Õî„½¯¥‹‚bMô§ôx,õ¸²TcÕnı#¼–š\n7\İ1\ÜùŠK}Y¸\r\Â-\n\n5\Ü\Ë%ù˜¸ƒ¿EæºŠ2*nB|{\Õ]úÏ¤~a…°Dx¥¦Š`©ø\Ô\å¥/#*.«\Z¢\Ù\Ûmp€5qş°¢rÈ™©Ü€lş¢’lf\àhŒZ¾>4d¡\ÚF¹>)0‹\ã¡\ß\ÍSÕ¯\ëùU¦\å\Ö+†]ÀZX­Z^8Š\Ùüö\Ë\\C(ª‡9¢`tœLM\ÜL\ÔÀ²É¨PKH!¤|0K)_õR’y:šø:¶’\ç—PH)L\çR\Ê0Z/$‰µ\İÀ\Ş\ŞJD¬m¼\ÛÅ¦{X+À66a‡V!7\Ê\Í]Z\Z\Zu\èmª\Ä#¿\í\\U[(]\Ú(;›-¥)Bq Ñ«´§.¿h-”\Ó\â\ÛdœÆ«f“±\"°u2›ã¯©@×¬\ÄX¤Q®³\Íc@½”\Æ\Øbö4^•.zBAÖûŠ»Æœ&a—\0% \Ã3\ÛªIUq…–wIk\Û\â,\ç\ZX^›ü¶`¯Ÿ­\\4a²\æ\×xp1”’\ç(’\rV\Ş\Ü 1\ÇÀ¡\ä\Ì,pc\ÏW»HÔ­\Ó\Òtû´D¤0sü¦– (Áf¥®5\'â©³ıüFNû9R“PI:w\nÑ²V9Š\ÔTò[UšŠ\ê¦uos&\îa\í\ç¬\îĞ˜³z*i\Ë\\´\äu\\j\ê\åI\ÓT\ËU”\è¸@š]>t¨LH]D\Ô(q\Z€¨¥\Ğ\Ï^K…ü\ÑD¨b}ZePMª,m€<jN^¨O‡‹Ê£©qŸ\ZğF\Ç\Ş1ü\Ñô\éey4¥¬¨!\r*¦K F}k =&\ìóEŸ\"[\'Û¶²O\r¸¤#\è&\é­\è)$*¯¡ßƒ3GS¿6Xbô³\Å\Ï-hKx\æ¿5YMB€»¦„\Ïú´\É>*\îGe\é`N‰7¬…2u!o§Q*hôsu£RaK4!ª¸!­,0I –•HJŸf ¥—\ÛIAC½\ß0±>\ìvS ¤¦\ÉğpÚ€:€IM¯\\÷¨ÛªüGi¼Š+Ÿ­õ`]ºılG\ì\Ó	\æ`ª|T¡¦Ø¯õ–_´‰ö\Ö\Îñ(øıø*E\ï…ÿóóM2Ÿ[}–;Á	—V1|YO\Íùû\â7wD¾’?g®‰6‘×˜\ßYa‘§ñ\æ‡\Ñ_¹ly\Ã\É\\7\"Û•ø,U\é\ë\Ø9\ÛAÔ›ÿ\nB\ë„b\Ú\Ù\İJ¢\Â†ß†oSó\ßI«ó\ÄûMşJŠŒ›\è\Éw~‹ñ‡\Ç0†\Æ\Äl\İDV{\áš›L_ª7ÿzN›÷!^0\ç\Æ1\'\Ë63\Ìf,k\ÄM\Útn\Ú\ç1k1³ı¦s\ÈVVI\Úpnøbn€%›<!*	µK–°\ÛOV°\Ã\İ\ì„\ä[m\å\Í\ç\Öj=olê¬¶d¤™±Zó$&¾²1\ÚQ’\è!„–“¦\Ü=nJ˜I‹%S\î¨hŸkn\')°\Ú\nQš\áªõôŠ	¬: Õ\ĞTÉ©ZSf¦\ê€ò¼U­8U&­ª\ßw\åúB;=,o¹G=L\â»\ÚÅ™\Ğ\Ëq<,\ÅM\È\ÔvÑ‹‰ô(m‘×§,%NgJ‰$\ãMg´÷	\è\Ó\Ü|;Œ,—L£i¡	\èN\Îvyg9hp&R`ù\Û*q\ÍvVg+†’¤¢\×\ØonŠ]¦£¨x½õ]e¡@Ü´$Dfÿ¹&v5\Õ\Åî°£¢f”Ø²À©ı\ç\Ø5\ØT—¿[£\ì\ÃÚ¾\Î\Ï=#MûĞº\Íõ°u’„† }„\Ã\nôÚ¾aøÈ± M\í+7Á¡Z#J`/³u\ÅCF$Ÿœ¥.5–\Ó\Ç#S\Ó^K©9Ÿ®oy„©ª³ò¨VvXVQwªm\å;W¥Ğ±XE\Öq}¼ßµpP	=5ªG\ÜLÌ™¥W)\ç¬Nu·ŠXôª¾3Å¿²\ï¬NußŠ\ï\ZQ«¶´º	Pµ“ò¨\ÓT\ä|ù¤\Ñ\á²\ä!5ª·\â\r«4\rÉó90#©IYR\çf©| ~H\é:\n³\î\'[C\'\"\Ù\Ã\Òlv†\Öm´¿7x2ı]g[P©>òX\Ûa‹¿A\Æñ…4Vµ©-\Û‘³.I;Ü‡£dunüU\ëıGy\î\Zl°±~\"g,„?“—\'É¿\â%m¿ò–Ğ¾ñ\ïc´‰2ô–.s!Nl†ªş“´,Ï“ûM¢•v1Ì¦Cğ\ÜûŸcÇµ¾¯%w\Æ\n\Ä\Éna\É\\\"r»~/(\İ¾&¡L|…\rõ½‹‰E÷ş¼\Â6¼a@\Ş\Â5°\Ş\Ë*\"õÁŠ}r\é€u¼(£Q¶\Ç?1†m\ï\í§ÿ””·4\0\0','6.1.3-40302'),('201811011814230_job_category_added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\İ]\ÛrÜ¸}OUş\ÅÇ”vF²Ö\ãš\Ù-­d\íÊ±l\Å#m\åM‘Ğˆe^fI,U*_–‡|R~!\0¯¸’\0x•K/\Zh4\Z·n ûÿù\ï\ê\ç§À·aœxQ¸¶‡¶C\'r½p»¶÷\éıo\íŸúóŸV\ï\İ\à\Éú½\ÌwŒó¡’a²¶\Òt÷n¹Lœ€dxN%\Ñ}ºp¢`	\Ühù\êğğoË££%D$lDË²V_öa\ê0û~F¡w\éø—‘ı¤øR6U\ë`²\\Û¿y1¼„‹<£mø@Ll o[ £¤ˆ\Åw7	Ü¤qn7;ôø\×\Ï;ˆò\İ?\ë\ï\êìª­8|…[±¬–¤œ}’F&Á£\ãB,K¶¸‘p\íJlHpï‘€\Óg\Ü\êLxkûCtw\nR¸\âg\Ûb\ë{w\ê\Ç8/#\ŞQ\èÀÊ“* °\à¿\ët\ï§û®C¸Oc\àXWû;\ßsşŸ¯£¯0\\‡{\ß\'™C\ì¡4\êútG;§\Ï_\à=\Ïò…k[KšÄ’¥QQ\Ï\Ûw¦Ç¯l\ëb	\Üù°B!‹M\Z\ÅğW\Â•v¯@š\Âu\è…3™rŒ0Õ–u\â_e­Šh@\Ù\Ö%xú\Ãmú°¶Ñ¿¶u\î=A·üRprzhü¡Bi¼‡m•ÁÄ‰½]™\ëBòü5ö»a\Zö	<zÛ¬øj\Ñ8ÿı,1yğvùp\'Áy›g:£\àK\ä\Ó}Ÿ¥\İn¢}\ì`¶#I†koaJ³µZ\ÖÃ¨mpi\rªi“\á \Zsğ \êF7ZsC+)<\ngùÂ‰Â‹\0lG{\× ù*·uj\ìU\ßE\ã®N\ì:\æ0­q‡L3öpÍ†\ã¯,:\â\ìaL`®\Ç\ZÊ¸®1WB\\\ß:¸®Qšˆ\ëp\é\Ôvb\àzª\Úğˆ\'¾j¢¢ù;ğ÷°G\ÂYÉ“G\àe…>gıŸ.\"T+\ZK²±©9»F\è4?_‚JÎ´E\"ñ¶šÿê™·)_5Ù–3qc\ær\ÚVm\Êfß¼P\äD÷\ÂÅ‚J-t†N‹†¨\Ñ\ê+ˆ¨ôË‰\É:2ò¢¶fµ¤rik“io\Ã\r1»J\ã\Ñ\ÇeW\àzšğ{Y)N’\İ\'˜.Ê‚‹œ\ä9š=\á·(şº )X\Ê\åjØ¿R…ıñ\Ñ\İıñ\Û\×o€{ü\æGxüzü! X^½UZ41Ü²`¿zı¦—Z¥¿IP\ïOö÷m‘­†9ŸÊ[¥HcRıÃº¤:hcNyx³\â™Œ„²Š±GC\É\ï°õ*#m\á÷1úô=Lòsƒ\êF€-9Á&€eÁ\"\Zcmj¡¼W?	“o06>r(£\éd·Cıš\É/u01_Ü†r¼ù\ãÜ‹“t”3ğG0RE\'®\Ãd„k\İ{>¼òœ›\Ø¾UN\ê=\Â4Dªº\Î\Ğ,q\í­E\ßÀkbPuË¤P\Ëi\Ş{q\0+$ÿ¡\n„Jˆ$A;÷7<.\Ûr\ÒŞ¤ \Ø\r›‡(„ŸöÁ\ÑÆ««·®¹ş-U\ïC\\ª3½‘ó5Ú§\ïCú&utñ]è…\ÇA³\Ç93t³\Óf·#7^¦>²œúÀ\Ägf¥¼-³\Ö\çq\î\ì\"\É&:¿4±ú1\Úz¡\Z«eV9«yVV‹lº¬bbjœ9\åŒfZù\Ìs\é²\É\îHóÍ›\ãâ¢·Ü¶L\Ú05œÕŒŠHÁjtTÎ \ÛÿY9#;ÿ\Ãò\ÜU¡S´³\î£\Î<C-\ÚYM™U§çªŒFC6;ö?\Z2²ó\r›\èó£\ç\â™NAƒTfF\ä•ò‹•S\íc\ál\ì\á@5s\ì\ÊÇ™Lõ\âõ\ÊX{!&÷\ât\ZÃ¯ù\Ò6\ÔÎŒ\êŠ>Úˆ‘¸]\Ü|öƒ-a\Í]¥\éF¹ƒDxRº\"a?Ê„#£gO\Ú\Ä,G¨w/’sl\ë\Ëßª3[E¢\ë\ì…@\Öÿ\rr\Ğ\Ñ=}	±Ş£\ÔZÀ\'\Ô\ìlWµ¶9TPyO óõ—\è©\ÊÔœ+*®<\ç+\Æ~Q‚¿³B•(\Õ?E\î\ã\æ\Üy\ĞII†~\ä{0\ï+ò\ãI’D—uH\Ã]\Ê$O3ğ>t-û|m_¹D\İ\êa\È\" ­\í¿p\rV¬¯:*\ÖõUW\n\è*lvEû!A¦\Ğ:qò§ q€\ËÏ™Hš.ı-‚\ßOò\0Vq&˜^˜ò+¦:\Şø\Z\rah\è\İuÄ¬V•²)gpC¼rjtcgnªJ¶\Éoµ$ÀÚŒa\î\ê“Gò{P­\Ø9\\,ø!\ß@Y•<ğ %k\Ûxp’\É@…\î®\ßT@ª/[7tµ\à\æ5\ÕÍƒN<N¦\0\'E°u\Z\×\îN5-úMC§J\ÕP[?3j\â—<\ÍÀ\ïjB™(vºü}›.\ì„2è…‹ (¸Œ&\ëî¦›iu‡\Ó÷#GÁa\Ã}8cõ-·A`)—’\n$:¢Q.	•\ÊÅ—\ÚF¢\Ä\Â(\ëó6sc\İ\ïœ\ÚaL¶\Ø9%¸,LJƒ\0³Yb#€³Y$*H/hN\ĞÂ®¬\n\0\Ö\È<7€2\Öm	@+\Ï(\0¥%6@i‘¼8€\æ\×	TûŸ¹[07xÒ—\Z\Æ_\Ö\Å56)y¼4h*\Z±¡k-B[fS\×Iv¼×¢<è„Š§>p­\Çñø¸\×\ëkşhk\àŒGg,\êB¹\åhòñ!µF¬ñ¦³¹©õ»µUº\íQj2\Üô\Çp\ï#.7[¢2)*QYËˆ\æ\İ\á\Ä\ÌòÇ™(‘(\n+eR˜\ÎYpc\â˜rJ_\æ¬M¦\"57P8Z*E‹ß¢\â¹¸…„\È$¢\'6\äµ/\îºr\ÄhõQv\ï\×D°\Ş¶eA*\"\Ê\Ï>-D‹g!n\×hqy»±É…FAƒly_º‘lqThµô^q›,d«\rS\'1æ›¡[¿)\'Š¨¼Ag\'(M“w%\éˆ\â¦@M#7QC=\ì\ÙE–“‚y\ß¼Üš¬¬±@lfUà¾™\Ğ\àb |-	E 1\Ê\Írâ¦·6›·\ë\r\ÖdÆ½›°\Ù\r¦+5\ã\Í=¹j6\ËAltj¦DõyI´YPTm(ÿ\ÅZ\Ö …“AG°>vŠ\ì%/¾NŸhX\Ñ\rjÑ¿K„T6¦w)•‹j»”Dje\År\')1J`‰”\Ê\Æô.¥£\íB¨65”›DD+\"\Çlªk[h¢€\ëQ\Çt€t‹¨\Ş-šš¶6\ÖUüÁÁ´¯š\ÕA}*„F\ë-©Ş‡\à@p:S\îºòs¥	¨\ÒV\Ë\Ü\İuñaµ”ø\Å^\á¸n	?\Ù\Åk“;\É>ıa£\ïB:\Èi,jNcõUMiƒ-dRñYÁ…™Ÿ†3‚;€/\\Ÿº—M¨÷œ\ã\Ê*Eª\r¾·\Ëó\\Y\nÿŸ—”ú¶¨Š\Òç¨VNe¯=„[EAi;.>ˆ›½ÎFş>•n\á\Èi\Ò\î¦I’tŠ:EÊ“&IJP§÷ò\Í4šH\á)®–L7pZ:®»9%*!U„u– ´€$\0p>”®–*ºp\ÔJŸ\Êµü£:\Âg2I‰ø<\'\Ğ\ÉN\ï\ZÀ©Š\ÔÀ\'.\Ù\ĞA\åuh¦‹d·¤iõ\æ\Úá°€#PsN…d\rgD\Î0IšKÔ£+™j™$=š\Äc*–&‘d@“ğ,$L¤«S—¸&+dÑªƒ~ÀPo~10\Ù$#Vıš\Ï8B£‹şô£FF:\É3\â7š9z™\Éµ\ÔF¬ş<$\Ètª=OY\Èô{¼¹ø0=\ÍOŠ3\Ûwòº›\îıS\ÍûHNB&\éò)k\Ù\İ9•ò\"8IEv9|²>\ã5\æ}Ö¦LQ\è³v2i‹nE’W¹5!§^kšHš2\Ãu%Ò\'I‹ü>t\È1ªˆhQ…*\0¢•\Â0s-á©“$B|V§Uû\â$I\Õ_5°S:Û¤€S~\Ô\Øı\Ñ\Î4©½¤Á\é2“\âLP§Wø\Ñ$)Ÿ4i®9bDš\ÎŞ™ô–Ioœ\ÉuŠŒKLÑ´U$ipI:¾¤˜$Œ\èI$*Î¡qª\â\\]Rg*.UcòN/©¡\È\'\ĞğÌ¦\éŒ&\Î/&=¦¸du\Úx\å\ç£ú\ëlVM¹Ÿ\re~«ÛRBc˜å¨Ÿ\r)\áT:\ŞÕŸ5inó8b\Å÷YIz3ÀHù¾n@’Ğ\Ï7”\':zºitŸ\'§I¹—cvr÷zrzzppo+³\Âö¶\ã•\\¿\ì¼V¥;\ÌtD¿ö ¦\Æw rŠÃ\Ş\ÊK¯üykt<r\Ös6KU{i,/W\Öó\Âr\İjš3e\çYl«\Ökûòyó‡¿À\é‹\ì\ßSßƒx7Q\æ¸¡wD{³_/şÊ„¬Oø\èe’¸”§\Å\æ\Òt—M\Ï\Ù\Ã\ÒnuÅ¨\ë=W\ÂÙ\Âmş8£&f¡Ù”\ÔA\0f5ZZŒ\Íz¶sp\áAzòO¸ƒ\ä%\Ğ\ã^\ê\\„.|Z\Ûÿ\ÊJ¾³.şyK>°>\Çh^xgZÿ\î\ZjØ´5\\$\áşA$ğ\Ñ7z¤Ü¡\0e„€\î=\Ï\Ô\í€eI¼\\SŠ’p¸]\È\Îsbb\\0Û¬\ßz‹`kB­1l­i[%QiUQ\Ê—\áµ\Ã\Ä\Ğn\çÃ·óPó‚™\Ô[\åm+µ”f±FG\ï­ğ\Ä\Îˆy¯\ØBq\ÖD\Ûz7\Zÿ—}>°.’›\Ğûc®\Ñ0ÀÅ†\Æ\éW\æb\Û\ëLIªK\á>/Jƒ¾c\Ó\á%µ¸É‹v\à\Æ<\è¤A\Ïûqù‘\r÷hº\Æñ\Ñ{œ\é\Z¥/j²\ã\"%šÊ›\r„h\ÜotœC\ã-(Œ¡1O|”B¡=Í¢¸]\Å\Ğñ2g\ï\Ø»a*†¡°O™¥\Â<d\á]ù½\Ä+4¢0¡q÷ò\Ñ{ Õ\Ğd‘ˆI\Ãö@qA#N¥M=µ‘Tw.KN¸X,_\ìqe^7.Z™\é çƒ‘õ¬\Új1<~—aºzÛ”\\ñQ¸z£=% {½õ}\Ì0¢øVZ\İBP\íœn±°TU6<…Nº:˜V·	«§(:•“\"\Â1’$d\Ã@W\Å\î¼v\Ì÷t‰_2qø›\ï2\ŞMñmrsz;µ‹	²*µ¾¬¸5\ÓÅ©Q…aÀ/D_Tü™\écÎŒ_fü˜2\ß{ü˜¹„Œ©½‚\nøØ¥|\ËCN•³†¬&ªÚ§F—Š9¹—¡D1xb•\àl\Ä\È/ccMöfA\Ãn:ÿø.3[\áŸW¶£¸Œ\r6Ù»†™ƒM+V\ËÌ°6\Õú91Ò”—\Ğ9­\ß\È+C–hz\"8\ÅK\éó‘\ï/\â	\ïU“ÀÉ¨‘B^* `˜\\†šá³Š3Â»\åd!S<¹<õi	’¿ŠZ\Û\î]„”[,\Z=©‹*“‘W¢™kñDtó	m±{–¾\ØşÀU&\Î&ªY),ƒ4fF¾\Ãáª§“E\Õ\æó°\ØU´¬²zK%­°\Î\"¯Tî£š­˜Ÿ=¹Šù,¢Š\Û÷²Us\n®f.Gs‹õ\Ä\\œ\È\å\\\äi®V\âT¾©\î\â€\ÖXw‘§¹n‰«öQË–¶•ò¨R”\ç|\Êp/\Ì\ÄFù\ï\ä×—6‹*AD)‚\Ò\\\"¸h7Ÿ2¶—4FË JÃ†k\Ô@QX$‘WDœ´„3¿+\Â\0\r¢(`-\Ê\r•:±³$j\îBªP-\á\ÒEB-Œ\ï2ıe¸*½…Z±%Rú\ÊPSz\ÉCg¶RŒªµ3\Óğ·2–\è\'	x\";´ˆu\Î[ü\ZAKx÷*«\å´³ô‚ü¦\â\ê&Ş¶&±B4\ÃüõxM´\Ìs\ŞG¥f…\á¨\Ì\ÂÜ¦¼„)pA\nN\âÔ»NŠ’ñ/\Ü\ÚVv3¿¤¹ƒ\îEøyŸ\îö)j2\î|jÛµ2Mõg‘YhW\Å\î>š€\Øôğ;\Ï\á/{\Ïw+¾\ÏW%$°º§¸Ì‹û2Å—z·\Ï¥OQ¨H¨_¥¥º†Á\ÎGÄ’\Ï\á<B\Ş ?\Â-p\ë‹\æ2\"\íA‹}u\æm‚¤ Q—G?†\İ\à\é§ÿWI-ö\Â\0\0','6.1.3-40302'),('201811011846067_job_group_name_added','HireMe.Migrations.Configuration','‹\0\0\0\0\0\0\İ]\ÛrÜ¸}OUş\ÅÇ”vF²Ö\ãš\Ù-­d\íÊ±l\Å#m\åM‘Ğˆe^fI,U*_–‡|R~!\0¯¸’\0x•K/\Zh\0\İ·n ûÿù\ï\ê\ç§À·aœxQ¸¶‡¶C\'r½p»¶÷\éıo\íŸúóŸV\ï\İ\à\Éú½\ÌwŒó¡’a²¶\Òt÷n¹Lœ€dxN%\Ñ}ºp¢`	\Ühù\êğğoË££%D$lDË²V_öa\ê0û~F¡w\éø—‘ı¤øR6U\ë`²\\Û¿y1¼„‹<£mø@\Ø@ÿŞ¶@F)HQ\ß\İ$p“\ÆQ¸\İ\ì\Ğ\à_?\ï \ÊwüMWgW\í\Å\á+Ü‹e]°$\å\ì“4\n4	lY²Å˜kWlCŒ{œ>\ã^g\Ì[\Û¢»S\Âm?\Û[ß»S?\Æyö.ˆBVtP¡\0ÿX§{?\İ\Çp\Â}\ZÿÀº\Ú\ßùówø|}…\á:\Üû>\Ù8\Ô<”F}@Ÿ®\âh\ãôù¼\ç›|\á\ÚÖ’&±diT\Ä\Åóş]„\éñ+\Ûú„š\î|X!‚\à\Å&bø+aŒJ»W MaŒz\áÂŒ§\\C˜j\Ë:ñ¯²VE4 l\ë<}„\á6}X\Û\è_\Û:÷ [~)Zrzhü¡Bi¼‡m•ÁÄ‰½]™¾\ëú½m\Æ³h\è}~–˜<x»|’x¹\Í3\ÇQğ%òiqdi·›h;˜E‘$\Ã5ˆ·0¥›µZ\Ö\ÈnÃ»Î§Á·!®\Ç\Ä3ªn(k\r\×VR¿\Æ\Ñ~7F›ñ¼\'\n/°@\nMƒü\Z$_¥ı¶\Î@\rò\ê»h€×‰]7¦¢5Àqi9®\Ùp —EG\ì=>\Ü\ê±\æ\\× « S%®o\\\×(]\Äõe“\Ùhµ]¸ª6<â‰¯š€¨hşü=\ì‘pVò\äxY¡Ï™ü“ÁY„jEcI665g\×\Ó„\â\çK°C‰Â™¶\ÈQ\ä\Ï3\ŞVó_=ó6\å«&\Ûr&n\Ì\\NÛª]\Ù\ì›Šœ\è^¸XPi¢ƒ\Î\Ği\ÑuZ}•`91YGF^@\ÔÖ¬–CT\Îmm2m\ãm¸!\ÆbWi<\Z\á¸®§	¿—•²\à$\Ù}‚\é¢,¸\ÈI£\Ù~‹\â¯’â¥\\®†ı+U\Ø\İ\İ¿}ı¸\Ço~„Ç¯\Ç‚u\á\è\Õ[¥uA\Ã-ö«\×oz©U\nù›IGxRŞ·E¶\Z\æ|*nA–^ Iõ\ë’\êü¡[\Ê\Ã[˜w\Èd$”UŒ=\Z\Êö[¯2\â\Ğ~£Oÿ\Ø\Ã$?7¨nØ’l\Ø&˜\à@Dc¬MB\Íô÷\ê\'aò\r\Æ\ÆGe4\ìvH®oğøRSğ\Åm(Ç›?Î½8IG9#Ut\âº1LF8±\ÆÑ½\ç\Ã+Ï¹‰ı\á{\å¤\Ş#¼AC¤ª\ë\Í\×^\ĞZô}\0¼¦ªn™j9\Â{/`…\ä_\"´@\Ğ@	‘$h\Ç\àş’‡Áy[NÚ›\Ãk·¯¢~\ÚwxF¯®\ŞDsı-:ZªŞ‡¸Tgz#\çk´Oß‡.ôM\ê\è\â»\"\ĞKsN\Í\ç\Ì\Ğ\ÍN›İ\Üxı™ú\Èr\ê/ŸY˜•ò¶\ÌZŸ[\Ä9¸³‹$›\èü\Ò\ÔÔ\Ñ\ÖÕšZf•75\Ï\Ñ\Ú\Ô\"›nS11µ–9\å\r\Í2´¶3Ï¥\ÛLvGšoŞ”\Z..z\ËmË¤S#À\éQÍ¨ˆ¬FG\åºıŸ•3²ó?,\Ï]:\ÕI;u\æj\Ñ\ÎjÊ¬:=We4\Z²Ù±ÿÑ‘ÿhÈš‰>?z.\é4HefD^)¿X9\Õ>æ˜–=¨n]ù8s€©B¼^k/\Ä\ä^œNcø•!ŸAzÃ†Ú™Q]Ñ§¢Sñ\"·‹›\Ï~°e#¬¹«4\İ(w\àOJ—%\ìgCpdô\ìIû€˜\åõ\îEr\îƒm}ñ[uf«Ht½\è\Ñ\Ú\ã?£AB:ZÒ—\ë=J­|B\İ\ÎvUkûC•÷ô:_‰ªüG\Íù±¢\â\Ês¾b\ì%ø;+T‰RıS\ä>nÎ”lĞ¼sY‘O’$r¼L \rw5*“<İ€÷¡k\é\Ø\çk3€øB\È%«‡!‹€¶¶ÿ\ÂuX±¾\ê¨X\×W]) «8²\Ù\ísx†™B\ë\Ä\Éœ‚\Ä.?g\"nºô´B|?\ÉXÅ™ `zaÊ¯˜^\èx;\àkt„¡¡w\×7µª”M9ƒ;\â•SCŒ[SU\Ê0´«%\ÖfsWŸd8’ßƒj\Å\Î\ábÁù\Ê\ê¨\äo-Y\ßÆƒ“Œ*-\à\îúM¤ú²uƒ¨7¯)1:ñHZ2\à8>(‚­;Ğ¸~wªyh\Ñv\Z„*y½C	¶~b6\Ô\ÄO†š\ßÔ„<Qºüm›.\ì„<\è¥#@PpM&î¦›iµÀ\éû‘£\à°\á>œ aõ-·A`)\ç’\n$:¢Q\Î	•\ÊÅ—\ÚF¢\Ä\Â(“y›¹±–;§v“-vN	.“\Ò Àl\æ\Ø\àlf‰J¤4§\0haWV\0kd@\ë¶ …•g€\Ò›\0 4K^@ó\ëªòg\î\Ì\rô¥†ñ—õFvM€MŠ/\ršŠEl\èZ¤Ğ–\ä\Ôu’\ïµ(:¡\â©\\\ëµx|\Ü\ë\ÉZ¥}´5pÆ£ƒ3u¡\Ür4ùøZ£ˆ¦ñ¦³¹©õ»õUº\íQj2\Üô\×\à\ŞG\\n¶DeRT¢²–\İ=»Ã‰™\å3Q\"VVÊ¤0³\à\Æ\Ä70\å”:¾\ÌY›LEj:n p´$$TŠ/¾E\Ås\rp	‘%HDOl\Èk!^\Üu\åˆ\Ñ\ê£\"\ìŞ¯‰`½?l!Ê‚TD”Ÿ}Zˆ\Ï<9B\Ü:¯\Ñ\ãòvc—‚\Ùò¾t#\Ù\â¨\Ğk\é½\â6^\ÈV¦Nb\Ì7C·~SNQyƒ\ÎNPš&\ïŠ)\Ò\ÅMšFn¢†zØ³‹\Z\Í\'ò¾#x¾5YYc\ØÌª\ĞúfBƒ³ğµ$d\Ä<(7Ë‰»\Ş\ÚmŞ®7X—?r\Ân7˜®ÔŒWt\ë\ÉU³™b£S3\rø z¨\Ïs¢Í‚¢jC!\Ú_¬e\r\\h0yt\ëcg¦\È^ñŒQ\Ñ\è\ë\èô‰\Âh`P‹ş]Â¤²3½s©\\TÛ¹$R+\ë(–;q‰QK¸Tv¦w.mg’@µ©¡\Ü\ì\Ä\"Z9\î`S½X\Û\Ê@\\*8F\0\Ò-¢ºX45mmLTüÁÁTV\Í\ê >B£IKª÷!Z 8)‹®¼À\\iª´\Õ2wu]|X-%>±Wx\î…[\ÂGvñ\Å\Ú\ä²O\Øè»r\ZK‡š\ÓX½EUS\Z\Å`™T|Vpa\æ§\á¤\à\à×§nÀe\ê=$ç¸²J‘jƒ—vy+K\áÿó’R¿\ÖµQQúõ1ÀÊ©ìµ‡p«((ma§\åÀq³{\Û\Ó\È\ß¡\Ò-9M\Ú\Õ4I’NQ§Hy\Ò$	R	<½Õ’a\Z§S\ã„Ã©<i‰«\â¡#\ÌÄ¯%v¸õ\Äü¡ôÀ\ÌP\Ñ\îüP¹Zf\È_µ(å¾”BùGu:„¯d’ñyNğ•\Ú5 ,R©ÁX\\²A@\å5hFD²\ÛÑ´úµ£aA‹†\çLX@¶e&”Q\çü“¤¹D=º„`–*‘¤G“xD\Å\Ò$’h^€…„‰tu\êWÀd’,ZuĞ\ê\Í/&›d\Ä*_óGhlÑŸ~\Ô\ÈH\'y†ıF3G/3á©–Ú€ÕŸgƒ™\ÎBUò”eL_\â\ÍÅ‡‘4?)\Ê\æÂ‰d\Â\ëlºË§24š\ËHNB\Æ\éòş\n\ÉkÙ9•ò8IEv)|2™ñ\Z\0s™µ)Qd\ÖNB\Æm\Ñm’ó*·%\ä\Ôk\rISf°n¢Dºñ$i‘\ßgƒ™F-*P@´Rf®%<t’Dˆ\Ï\ê´jœ$©ú«vJ\'›pÊ\Z»?Ú‰&µ÷£“4\ÚFºÊ¤\ÚG&¨\Ó+üg’”ŠOš4Œ1\"Mg\ïLzÉ¤7\ÎdŠ:E\Æ¦h\Ú*’4ZI:¼¤\ZI&Ñ“pTœC\ãTÅ¹¸¤\ÎT\\ª\Æ\ä]RC‘O6 -h3›¦3š8˜ô˜\â’\Õi\ãy”Ÿê¯³Y}¶\ä~6”ù5®n;J	a–£~6¤„3=\êxWÖ¤U¸\Ë\ãˆ\ßg	$\é\0 \å÷ºIBC>\ßP\è\è\é¦\Ñmœ&\åV\Ù\r\È\İ\ê\É\é\éÁuÂ½­\Ìú\ÚÛWr\í²ó>X•\î0\ÓıÊƒZ˜\Z\ß\È){z+/»ò\ç­\Ññ\ÈY\Í\Ù,Uí¥‘¼ü]Y\Í‹u{xiÎ„g±­rX¯\í\Ë\ç\Íş§/²O}\â\İD™\ã„\Ş=by\î\Ì~½ø+¦z>!£—I\âR›\ãF\Ó\"›,†³‡¹\İ\ê‚Q\×k® l³…\ÛüQFM\Ì0*³\Z)­\è\Æf\Ò\èqx\î ƒ›2^\îU\ÍE\èÂ§µı¯¬\ä;\ëâŸ·T\á\ësŒ\Æò;\ë\Ğúw\çø\ÃºC†6%\ÃE\îŒ¿|£G\Ç\n˜FH\ê 6ˆnIb\äšR”„À\íB‹pÛ…À6“[oQkM¨5†ª5\í«$­*J™\â2¼v˜\Úm¼cøsj^0\ãz+¿\Íâ£¶ƒ\Ò,¾\è\è\Ò\nA\ì<€˜÷„\İ!üfM´MB¸\Óø¿\ìóu‘Ü„\Ş{”p†§_‹\í®3\r©\ÎU„û¼(\rú¦CJjµ&/Ú¡5\æ&\r$;l¼\ÇA\æG6Ä£\é\Z\ÇGp\ìq¦k4”¾¨É‹h\Êo6ø¡±\Ü\èØ†\Æ[Q\èB\ã6ñ‘	]„ö4‹\ÜvC\Ç\Ë¼c§\ëz„©¸…B™2K…y˜Â»(ò{‰Qh\ÊDaBcñò{ \Õ\Ód\ÑˆICö@q`A£–J£\nš{j©\î\Z]–œp&°V¾\Ø\ãÊ¼6n\\„2\ÓA\Ï \ëYµ\Õbtü.Csõ¶)¹\â#oõF{J@÷n\ëû˜aD1­´\ÄBPN·øWª*B\'\İ\r@«Û„\ÕS\äœ\Ê1\áI¦a o«b^DsÌ‚õt‰Y2qÈ›\ï2\ÆM1mrSz;µ‹	²Ÿ*µ¾¬X5\ÓÅ¦Q…aÀ/şŒD_TÌ™\é\ãÌŒSfü82\ß{Ì˜¹„‰©=\n\Ú3°ù–Gœ*g\r-X)<JTµO.¯qr\ÏB3ˆ\\ ğ¾*ÁÙˆ\Ñ^\ÆÆšì½‚†\İtş1]f¶\Â\'¯l#Fnl²7\r3›V|–™amªõsb¤)/¡sZ¿\ÑV:‡)\Ñô\n8D@Š—=Ó§9|C¾¿(\'¼\'M\'£Fy©€Vp~arj\"„\Ï*¶ïŠ“…Lñ\ÜJğÌ§%dHş\"jm»wBRn±hô.ªLTDB\\‰f®\Å\Ñ\ÍS$´\ÅN\ëYúbûW™8›¨f¥P\Ò8ù‡«NU›\Ï\Ãb÷Ğ²\Ê\ê-•´\Â:‹¼R¹_j¶b~ö\ä*æ³ˆ*nw\Ö\ËV\Ím(¸š¹\Í=\Öcsq\"o\äs‘§¹Z‰#ù¦º‹Zc\İE\æº%\î\Ù[X-[z\Ú +\'l£JQ¾\åS†xa&6\Êw\'¿¾´YT	\"JQ“\æµE»û”™°½\ì¤qY\Øªtl¸N\ryEmEtÁI‹9ó«\"\Ê ŠüÕ¢\ÜP©;3A¢\æ Œ\n\Õ.M‘%\Ô\Â(ñ,\Ó?S†‹š\ÒS¨[\â%¥¦$¥–L0tfÅ˜¡Z;3\r_+c±~’ \'²C‹\ØI\ç¼Ù¯¨„w­²Z~A;K/\Èo*®\Î`\âmk+D3\Ì_\×D\Ë<\á}TjV˜•Y˜Û”—0.HÁIœz÷ÀIQ2~À\à…[\Û\Ên†\ã—4wĞ½?\ï\Ó\İ>E]†ÁOm;°V¦©ş,\Z\İ\æUñ†». fzø\È\çğ—½\ç»U»\ÏW%$°º§¸Ì‹e™\âK½\Û\çŠÒ§(T$T°¯\ÒR]\Ã`\ç#b\É\çp¡I\Û ?\Â-p\ë‹\æ2\"í‚ Ù¾:óÀ6ARĞ¨Ë£Ÿ\Ãnğô\Óÿ±\ä>L\æ\Â\0\0','6.1.3-40302');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `applicationusersecurityquestionanswers`
--

LOCK TABLES `applicationusersecurityquestionanswers` WRITE;
/*!40000 ALTER TABLE `applicationusersecurityquestionanswers` DISABLE KEYS */;
INSERT INTO `applicationusersecurityquestionanswers` VALUES (2,'17e8f579-d48d-4076-be1f-5a34dc314167',1,'ddlj');
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
INSERT INTO `aspnetuserroles` VALUES ('17e8f579-d48d-4076-be1f-5a34dc314167','60d85a66-c870-4ce7-9031-72d5ffc14b1f');
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
INSERT INTO `aspnetusers` VALUES ('17e8f579-d48d-4076-be1f-5a34dc314167','Akshaya Kumar','Dash','BBSR','E:\\Personal\\Projects\\HireMe\\HireMe\\CodeBase\\Server\\HireMe\\HireMe\\App_Data\\uploads\\20181101-health_plan_erd.png',NULL,'akshayakdash@gmail.com',0,'AOmj0mXTGco+CzbHoso6lFh/eaxZLdyB/JILRf6k7d2VW1CXgtx6Q3n6oA63cx9eCw==','447a3012-5281-4bbf-be86-d1ec915c1fd0','9861696748',0,0,NULL,1,0,'akshayakdash@gmail.com');
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
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
-- Table structure for table `jobcategories`
--

DROP TABLE IF EXISTS `jobcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jobcategories` (
  `JobCategoryId` int(11) NOT NULL AUTO_INCREMENT,
  `CategoryName` longtext,
  `Description` longtext,
  PRIMARY KEY (`JobCategoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobcategories`
--

LOCK TABLES `jobcategories` WRITE;
/*!40000 ALTER TABLE `jobcategories` DISABLE KEYS */;
INSERT INTO `jobcategories` VALUES (1,'Home Job',''),(2,'Troubleshooting',NULL);
/*!40000 ALTER TABLE `jobcategories` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobs`
--

LOCK TABLES `jobs` WRITE;
/*!40000 ALTER TABLE `jobs` DISABLE KEYS */;
INSERT INTO `jobs` VALUES (1,'Nanny',1,NULL,NULL,'Internal Home Job'),(2,'Cook',1,NULL,NULL,'Internal Home Job'),(3,'Guardian',1,NULL,NULL,'External Home Job'),(4,'Plumber',2,NULL,NULL,NULL),(5,'Electrician',2,NULL,NULL,NULL);
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jobtasks`
--

LOCK TABLES `jobtasks` WRITE;
/*!40000 ALTER TABLE `jobtasks` DISABLE KEYS */;
INSERT INTO `jobtasks` VALUES (1,1,'Cleaning',NULL,NULL,NULL,1,0,NULL,NULL),(2,1,'Cooking',NULL,NULL,NULL,1,0,NULL,NULL),(3,1,'African Food',NULL,NULL,NULL,1,0,NULL,2),(4,1,'Sauce',NULL,NULL,NULL,1,0,NULL,3),(5,1,'Grill',NULL,NULL,NULL,1,0,NULL,3);
/*!40000 ALTER TABLE `jobtasks` ENABLE KEYS */;
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

-- Dump completed on 2018-11-02 19:49:11
