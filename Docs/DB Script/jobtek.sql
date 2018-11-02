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
INSERT INTO `__migrationhistory` VALUES ('201810312003598_initial','HireMe.Migrations.Configuration','�\0\0\0\0\0\0\�][o\�~/\�� \�\�ڹ\�L������t�\�I:N}h�v�\�\�+Q�E\�>\�O\�_(�+�%K�<\���\"?�\���\�\�L~~�\\\����S�dtl\Zз\��\�S3F�>�?��\�?M�l\�\��5�wF\�\�~45_ڜ�Ǒ�=�<\�\n�(X��xc`\�\�\�㿍ON\��01-Ø|�}\�x0��\�߂w\�Ѝ�r�e�P5\��\r�\�\��\�	\��Ҋ�q\�:\03��\�\�4�\� \�\��S(��b�������\�\n�\�X?/�\�\����b\\6\�IYq��!���L,c�y+ᚅذர�\�;u\"��ycä\�K\�b��\�ܐT��󢋋hs\�(o8JI^��ܷ �:�)\�\�\n���\�G\�,vQ©c�\�x���c��?_�?=;Y�\�>}�쳏?³�H�Xq=�\0=����7�*\�o\Zc�ݘoX4�ڤR�X\�+\�4\�\�\��k�\�\�\�\'Ӹvޠ��d\�z���p#\��\�]\�`\�\�\����O���^O?|\�\�;�ꬓ�\��\�\'\�\�\�t��ы�I�3\�\�Y�\�0�\�o_\�\�\�E�L���\�5D,w�q	^-HR\�\�:�:|hNExK���Y	y�^\r9�������\��3�Q�O�\�T#�呑~/!s��\rLx\�\�@F#\�N%r�D�@A�}\���r\�a��\r�O-4Twt\�G\�`2�EWd�{\0x���ݠ\�b���Ȇ�/}0q\r���C9M��0B5Gj7��;\�\�¶CE����>8\�S\��?*9��	/���K�K<:^m\�+8U\�L\Z�`Ce\�,��9��\��D\�\�_@�һl�M{���\�7/�\�boIv�\��\�\�\�<~�����+��ښ\�m`}\rbt\�\�\�O\�j�\�@\'\�\\X\�=�1��=�^w�W�#\�ϾM��On�p\'\�s^��[\�5\�EQMf�T�z�_�ռ��մF-�Y���bz�f5Ռ&j�Lkuf&3ԽI���M���ֿ2�/�2�>F�\�\�lJz��q\�]�Z\r\�&\��jH\�5$l\�\�W\�&Z���$��\�k՗�`\�\�\�ٮ�3\�]w��=��9λ:R�@k#]N\�\�L��O�t\�z���?K\�u\��٢\�\�R��&G\�@I�\�\��\��4�4U[Emk������/n)�L3%9��]��b\�D\�.X����;[Ab\�\���=\�;^$��cgz�y�\��\r;Ѫ�汀\n�\�\�Z_?oE��\��\�p���Y�\�\���#�}V]#Z�f\�Gqӹ�/�(��dB$W�\�E\�\�o��r�g���\�s,q	\Z�\���x$\Z\�gG��g ��-nZx8v\�rPK+o�X\��\"�\�9�F�8\�\"�=\�G\�\����n�����*{\��\�n�O:���N\��=\�@\�7)u��)\�UQ\�]Q\�y����w\�,\�	&k|<\n\\f~�^�Y-���Z$:(/��\�̧�\0\��64�r�=@3\�\'\0e%���\"98���T\��\���C�\'\�\�\���^)�=`��ǡAS\�j\�\�FSR	m���P\�r&Au͢;�D�\\7\�x��o6\�:��.�����\�����bM���x,���TcՁn�#���\n7\�1\���K}Y�\r\�-\n\n5\�\�%�����E溊2*nB|{\�]�Ϥ~a��Dx���`��\�\�/#*.�\Z�\�\�m��p�5q���rș�܀l���lf\�h�Z�>4d�\�F�>)0�\�\�\�Sկ\��U�\�\�+�]�ZX�Z^8��\���\�\\C(��9�`t�LM\�L\���ɨP�KH!�|0�K)_�R�y:��:��\�PH)L\�R\�0Z/$��\��\�\�JD�m�\�Ŧ{X+�66a�V!7\�\�]Z\Z\Zu\�m�\�#�\�\\U[(]\�(;�-�)Bq ѫ��.�h-�\�\�\�d�ƫf��\"�u2��㯩@׬\�X�Q��\�c@��\�\�b�4^�.zBA֐���Ɯ&a�\0�% \�3\��IUq��wIk\�\�,\�\ZX^����`���\\4a�\�\�xp1��\�(�\rV\�\� 1\���\�\�,pc\�W�Hԭ\�\�t��D�0s��� (�f��5\'⩳��FN�9R�PI:w\nѲV9�\�T�[U��\�uos&\�a\�\�\�И�z*i\�\\�\�u\\j\�\�I\�T\�U�\�@�]>t�LH]D\�(q\Z���\�\�^K��\�D�b}ZePM�,m��<j�N^�O��ʣ�q�\Z�F\�\�1�\��\�ey4���!\r*�K F}k =&\��E�\"[\'۶�O\r��#\�&\��\�)$*��߃3GS�6X�b��\�\�-hKx\�5YMB����\���\�>*\�Ge\�`N�7��2u!o�Q*h�su��RaK4!��!�,0I ��HJ�f ��\�IAC�\�0�>\�vS���\��pڀ:�IM�\\��۪�G�i��+���`]��lG\�\�	\�`�|T��د��_���\�\��(���*E\�����M2�[}�;�	�V1�|YO\���\�7wD���?g��6�ט\�Ya���\�\�_�ly\�\�\\7�\"ە�,U\�\�\�9\�Aԛ�\nB\��b\�\�\�J�\��߆oS�\�I��\��M�J����\�\�w~��\�0�\�\�l\�DV{\���L_�7�zN��!^0\�\�1\'\�63\�f,k\�M\�tn\�\�1k1���s\�VVI\�pn�bn�%�<!*	�K��\�OV�\�\�\�\�[m\�\�\�\�j=olꬶd���Z�$&��1\�Q�\�!����\�=nJ�I�%�S\�h�kn\')�\�\nQ�\���	�: Ս\�TɩZSf�\���U�8U&��\�w\��B;=,o�G=L\�\�ř\�\�q<,\�M\�\�vы��(m�ק,%NgJ�$\�Mg��	\�\�\�|;�,�L�i�	\�N\�vyg9hp&R`�\�*q\�vVg+����\�\�on�]���x��]e�@ܴ$Df��&v�5\�\��f�ز���\�\�5\�T��[�\�\�ھ\�\�=#M�к\���u��� }�\�\n�ھa�ȱ M\�+7��Z#J`/��u\�CF$����.5�\�\�#S\�^K�9��oy�����VvXVQw�m\�;W�бXE\�q}�ߵpP	=5�G\�L̙�W)\�Nu��X���3ſ�\�Nuߊ\�\ZQ����	P���\�T\�|��\�\�\�!5��\�\r�4\rɐ�90#�IYR\�f�| ~H\�:\n�\���\'[C\'\"\�\�\�lv�\�m��7x2�]g[P�>�X\�a��A\��4V��-\���.I�;܇�dun�U�\��Gy\�\Zl��~\"g,�?��\'ɿ\�%m��о�\�c��2��.s!Nl�����,ϓ�M��v1̦C�\���cǵ��%w\�\n\�\�na\�\\\"r�~/(\��&�L|�\r�����E���\�6�a@\�\�5�\�\�*\"���}r\�u�(�Q�\�?1�m\�\�����4\0\0','6.1.3-40302'),('201811011814230_job_category_added','HireMe.Migrations.Configuration','�\0\0\0\0\0\0\�]\�rܸ}OU��\�ǔvF�֎\�\�-�d\�ʱl\�#m\�M�Јe^fI�,U*_��|R~!\0���\0x�K/\Zh4\Z�n����\�\�\���a�xQ�����C\'r�p���\��o\���V\�\�\�\���\�w��a��\�t�n�L��dxN%\�}�p�`	\�h�\���oˣ�%D$lD˲V_�a\�0��~�F�w\��������R6U\�`�\\ۿy1���<�m��@Ll�o[ ���\�w7	ܤqn7;��\�\�;��\�?�\�\�\�쪭8|�[�����}�F�&��\�B,K���p\�JlHp\�g\�\�Lxk�Ctw\nR��\�g\�b\�{w\�\�8/#\�Q\��ʓ* �\�\�t\���C�Oc\�XW�;\�s�����0\\�{\�\'�C\�4\��tG;�\�_\�=\��k[K�Ē�QQ\�\�w�ǯl\�b	\���B!�M\Z\��W\��v�@�\�u\�3�r�0Ֆu\�_e��h@\�\�%x�\�m���ѿ�u\�=A��Rprzh��Bi��m���ĉ�]���\�B��5���a\Z�	<z۬�j\�8��,1y�v�p\'�y�g:��\�K\�\�}��\�n�}\�`�#I�koaJ��Z\�èmpi\r�i�\� \Zs�\�F7ZsC+)<\ng�\0lG{\� �*�uj\�U\�E\�N\�:\�0�q�L3�p͆\�,:\�\�aL`�\�\Zʸ�1WB\\\�:��Q��\�p\�\�vb\�z�\���\'�j���;���G\�YɓG\�e�>g��.\"T+\ZK���9��F\�4?_�JδE�\"���ꙷ)_5ٖ3qc\�r\�Vm\�f߼P\�D�\�łJ-t�N���\�\�+���ˉ\�:2���f��rik�io\�\r1�J\�\�\�eW\�z��{Y)N�\�\'�.ʂ��\�9�=\�(�� )X\�\�jؿR���\�\���\�\�o�{�\�Gx�z�! X�^�UZ41ܲ`�z���Z���IP\�O��m���9�ʁ[��HcR�ú�:hcNyx�\�������GC\�\��*#m\��1��=L�s�\�F�-9�&�e�\"\Zcmj��W?	�o06>r(�\�d�C��\��/u01_܆r��\�܋�t�3�G0RE\'�\�d�k\�{>��\��UN\�=\�4D��\�\�,q\��E\��kbPuˤP\�i\�{q\0+$��\n�J�$A;�7�<.\�r\�ޤ \�\r���(�����\�ƫ������-U\�C\\�3����5ڧ\�C�&ut�]腝\�A�\�93t�\�f�#7^�>����\�gf��-�\�\�q\�\�\"\�&:�4��1\�z�\Z�eV9�y�VV�l��bbj�9\�fZ�\�s\�\�\�H�͛\�⢷ܶL\�05�Ռ�H�jtTΠ\��Y9#;�\��\�U�S���\�\�<C-\�YM�U�窌FC6;�?\Z2��\r�\��\�\�NA�TfF\��S\�c�\�l\�\�@5s\�\�ǙL�\��\�X{!&�\�t\Zï�\�6\�Ό\�>�ڈ��]\�|��-a\�]�\�F��DxR�\"a?ʄ#�gO\�\�,G�w/�sl\�\�ߪ3[E�\�\�@�\��\rr\�\�=}	�ޣ\�Z�\'\�\�lW��9TPyO����\�\�Ԝ+*�<\�+\�~Q���B�(\�?E\�\�\�\�y\�II�~\�{0\�+�\�I�D��uH\�]�\�$O3�>t-�|m_�D\�\�a\�\"��\�p\rV��:*\��UW\n\�*�lvE��!A�\�:q�� q�\�ϙH�.�-�\�O�\0Vq&�^��+�:\��\Z\rah\�\�uĬV��)gpC�rjtcgn�J��\�o�$�ڌa\�\�G�{P�\�9\\,�!\�@Y�<���%k\�xp�\�@�\�\�T@�/[7t�\�\�5\�̓N<N�\0\'E�u\Z\�\�N5�-�MC�J\�P[?3j\�<\��\�jB�(v��}�.\�2腋 (��&\�iu�\��#G�a\�}8c�-�A`)��\n$:�Q.	�\�ŗ\�F�\�\�(\��6sc\�\�\�aL�\�9%�,LJ�\0�Yb#��Y$*H/hN\�®�\n\0\�\�<7�2\�m	@+\�(\0�%6@i��8�\�\�	T���[07xҗ\Z\�_\�\�56)y�4h*\Z��k-�B[f�S\�Iv�ע<脊�>p�\����\�\�k�hk\��Gg,\�B�\�h��!�F�񦳹����U�\�Qj2\��\�p\�#.7[�2)*QYˈ\�\�\�\�\��Ǚ(�(\n+eR�\�Ypc\��rJ_\�M�\"57P8Z*E�ߢ\����\�$�\'6\�/\�r\�h�Qv\�\�D�\��eA*\"\�\�>-D�g�!n�\�hqy��ɅFA�ly_��lqTh��^q�,d�\rS\'1曡[�)\'���Ag\'(M�w%\�\�@M#7QC=\�\�E����y\��ܚ����@lfUྙ\�\�b |-	E 1\�\�r⦷6��\�\r\�dƽ��\�\r�+5\�\�=�j6\�Altj��D�yI�YPTm(�\�Z\� ��AG�>v�\�%/���N�hX\�\rjѿK�T6�w)��j��Dje\�r\')1J`��\�\��.��\�B�65���DD+\"\�l�k[h��\�Q\�t�t��\�-���6\�U������\�A}*�F\�-�އ\�@p:S\��s�	�\�V\�\�\�u�a���\�^\��n	?\�\�k�;\�>�a�\�B:\�i,jNc�UMi�-dR�Y�����3��;�/\\���M����\�\�*E�\r��\��\\Y\n���������\�稍VNe�=�[EAi;.>���ΞF�>�n\�\�i\�\�I�t�:Eʓ&I�JP����\�4�H\�)��L7pZ:��9%*�!U�u����$\0�p>���*�p\�J�\����:\�g2I��<\'\�\�N\�\Z���\��\'.\�\�A\�uh��d��i�\�\�ᰀ#PsN�d\rgD\�0I�Kԣ+�j�$=�\�c*�&�d@��,$L��S��&+�dѪ�~�Po~10\�$#V��\�8B�����FF:\�3\�7�9z�\���\�F��<$\�t�=OY\��{���0=\�O�3\�w�\��S\��HNB&\��)k\�\�9��\"8IEv9|�>\�5\�}֦LQ\�v2i�nE��W�5!�^k�H�2\�u%ҝ\'I��>t\�1��hQ�*\0��\�0s-ᩓ$B|V�U�\�$I\�_5�S:ۤ�S~\�\��\�\�4�����\�2�\�LP�W�\�$)�4i�9bD�\�ޙ��Io�\�u��KLѴU$ipI:���$�\�I$*Ρq�\�\\]Rg*.Uc�N/��\�\'\��̦\�&\�/&=��du\�x\�\��\�lV�M��\re~��ێRBc�娟\r)\�T�:\�՟5in�8b\��YIz3�H��n@�А\�7�\':z�it�\'�I��cvr�zrzzp�po+�\���\�\\�\�V�;\�tD����\�w r�Þ\�\�K��ykt<r\�s6KU{i,/W\��\�r\�j�3e\�Yl�\�k��y��\�\�\�S߃x7Q\��w�D�{�_/�ʄ��O�\�e����\�\�\�t�M\�\�\�\�nuŨ\�=W\�ُ\�m�8�&f�ٔ\�A\0f5ZZ��\�z�sp\�Az�O��\�%\�\�^\�\\�.|Z\��\�J��.�yK>�>\�h^xgZ�\�\Zjش5\\$\��A$�\�7z�ܡ\0e��\�=\�\�\�eI�\\S��p�]\�\�sbb\\0۬\�z�`kB�1l�i[%QiUQ\��\�\�\�\�n\�÷�P�\�[\�m+��f�FG\��\�\��y�\�Bq\�D\�z7\Z��}>�.��\��c��\�0�ņ\�\�W\�b\�\�LI�K\�>/J��c\�\�%��ɋv\�\�<\�A\��q���\r�h�\��\�{�\�\Z��/j�\�\"%�ʛ\r�h\�ot�C\�-�(��1O|�B�=͢�]\�\��2g\�\��a*���O��\�<d\�]��\�+4�0�q��\�{ Տ\�d���I\��@q�A#N�M�=��Tw�.KN�X,_\�qe^7.Z�\�烑��\�j1<~�a�z۔\\�Q�z�=%�{��}\�0��VZ\�BP\�n��TU6<�N�:�V�	��(:��\"\�1�$d\�@�W\�\�v\��t�_2q��\�2\�M�mrsz;��	��*����5\�ũQ�a�/�D_T��\�cΌ_f��2\�{��������\n�إ|\�CN����&�ڧF��9���D1xb�\�l\�\�/ccM�fA\�n:��.3[\�W����\r6ٻ���M+V\�̰6\��91Ҕ�\�9�\�\�+�C�hz\"8\�K��\����\�/\�	\�U��ɨ�B^*�`�\\��᳊3»\�d!S<�<�i	���Z\�\�]���[,\Z=��*��W��k�Dt�	m�{��\���U&\�&�Y),�4fF�\�ᪧ�E\�\��\�U���zK%��\�\"�T���=���,��\���Us\n�f.Gs��\�\\�\�\�\\\�i�V\�T��\�\�\�Xw���n���Q˖�����R�\�|\�p/\�\�F�\�\�ח6�*AD)�\�\\\"�h7�2���4FˠJÆk\�@QX$�WD���3�+\�\0\r�(`-\�\r�:��$j\�B�P-\�\�EB-�\�2�e�*��Z�%�R�\�PSz\�Cg�R���3\��2�\�\'	x\";��u\�[�\ZAKx�*�\������\�\�&޶&�B4\���xM�\�s\�G�f�\�\�\�ܦ��)pA\nN\�ԻN���/\�\�Vv3����\�E�y�\��)j2\�|jہ�2M�g�Yh�W\�\�>��\���;�\�\�/{\�w+�\�W�%$����̋�2ŗz�\��OQ�H�_�����\�GĒ\�\�<B\� ?\�-p�\�\�2\"\�A�}u\�m���Q�G?�\�\�\��WI-�\�\0\0','6.1.3-40302'),('201811011846067_job_group_name_added','HireMe.Migrations.Configuration','�\0\0\0\0\0\0\�]\�rܸ}OU��\�ǔvF�֎\�\�-�d\�ʱl\�#m\�M�Јe^fI�,U*_��|R~!\0���\0x�K/\Zh\0\��n����\�\�\���a�xQ�����C\'r�p���\��o\���V\�\�\�\���\�w��a��\�t�n�L��dxN%\�}�p�`	\�h�\���oˣ�%D$lD˲V_�a\�0��~�F�w\��������R6U\�`�\\ۿy1���<�m��@�\�@�޶@F)HQ\�\�$p�\�Q�\�\�\�\�_?\� \�w�MWgW\�\�\�+܋e]�$\�\�4\n4	lY�ō�kWlC�{��>\�^g\�[\���S�\�m?\�[߻S?\�y�.�BV�tP�\0��X�{?\�\�p\�}\Z���\�\����w�|}�\�:\��>\�8\�<�F}@��\�h\����\�|\�\�֒&�diT\�\���]�\��+\����\�|X!�\�\�&�b�+a�J�W Ma�z\��\\C�j\�:�VE4�l\�<}�\�6}X\�\�_\�:���[~)Zrzh��Bi��m���ĉ�]���\���m\���h\�}�~��<x�|�x�\�3�\�Q�%�iqdi��h;�E�$\�5��0���Z\�\�nûΧ��!�\�\�3�n(k\r\�VR�\�\�~7F����\'\n/�@\nM��\Z$_���\�@\r�\�h�׉]7��5�q�i9�\�p��EG\�=>\�\�\�\\נ� S%�o\\\�(]\��e�\�h�]����6<≯���h��=\�pV�\�xY�ϙ���Y�jEcI665g\�\���\�\�K�C��\�Q\�\�3\�V�_=�6\�&\�r&n\�\\N۪]\�\���\�^�XPi��\�\�i\�uZ}��`91YGF^@\�֬�CT\�mm2m\�m�!\�bWi<\Z\���	����\�$\�}�\�,�\�I��\�~�\��⁥\\���+U\�\�\��}��\�o~�ǯ\��u\�\�\�[�uA\�-��\�oz�U\n��IGxR޷E�\Z\�|*nA�^ �I�\�\����[\�\�[�w\�d$�U�=\Z\��[�2\�\�~�O�\�\�$?7�nؒl\�&�\�@Dc�MB\���\�\'a�\r\�\�Ge4�\�vH�o��RS�\�m(Ǜ?ν8IG9#Ut\�1LF8�\�ѽ\�\�+Ϲ��\�{\�\�#�AC��\�\�\�^\�Z�}\0���n�j9�\�{/`�\�_\"�@�\�@	�$h\�\�����y[Nڛ\�k���~\�wxF��\�Ds�-:Z�އ�Tgz#\�k�O߇.�M\�\�\�\"\�KsN\�\�\�\�\�N�ݎ\�x���\�r\�/�Y���\�Z�[\�9���$�\��\�\�ԏ\�\�՚Zf�75\�\�\�\�\"�nS11��9\�\r\�2��3ϥ\�LvG�oޔ\Z..z\�mˤS#�\�Qͨ��FG\�����3��?,\�]:\�I;u\�j\�\�jʬ:=We4\Z�ٱ�ѐ���hȚ�>?z.�\�4HefD^)�X9\�>昖�=�n�]�8s���B�^k/\�\�^�Nc��!�AzÆڙQ]ѧ�S�\"���\�~�e#���4\�(w\�OJ�%\�gC�pd�\�I���\��\�Er\�m}�[uf�Ht��\�\�\�\�?�AB:Zҗ\�=J�|B\�\�vUk��C���:_����G\����\�\�s�b\�%�;+T�R�S\�>n΍���lЏ�sY�O�$r�L \rw5*�<݀��k\�\�\�k3��B\�%��!�����\�uX��\�X\�W])��8�\�\�sx��B\�\�\���\�.?g\"n���B|?\�Xř `zaʯ�^\�x;\�kt���w\�7���M9�;\�SC��[SU\�0���%\�fsW�d8�߃j\�\�\�b��\�\�\�o-Y\�ƃ��*-\�\��M���u��7�)1:�HZ2\�8>(��;и~w�yh\�v\Z�*y�C	�~b6\�\�O���\�Ԅ<Q��m�.\�<\�#@PpM&i��\����\�\�>��a�-�A`)\�\n$:�Q\�	�\�ŗ\�F�\�\�(�y����;�v�-vN	.�\� �l\�\�\�lf�J�4�\0haWV\0kd�@\����g�\��\0�4K^@�\���g\�\�\r������FvM�M�/\r��El\�Z�Ж\�\�u�\�(:�\�\\\�x|\�\�\�Z�}�5pƣ�3u�\�r4���Z���񦳹����U�\�Qj2\��\�\�\�G\\n�DeRT���\�=�É�\�3Q\"VVʤ0��\�\�\�70\�:�\�Y�LEj:n�p�$$T�/�E\�s\rp	�%HDOl\�k!^\�u\�\�\�\"\�ޯ�`�?l!ʂTD��}Z�\�<9B\�:�\�\��vc���\��t#\�\��\�k\�\�6^\�V�Nb\�7C�~SNQy�\�NP�&\�)\�\�M��Fn��zس�\Z\�\'�#x�5YYc�\�̪\��fB����$d�\�<(7ˉ�\�\�mޮ7X�?r\�n7��ԌWt\�\�U��b�S3\r� z�\�s�͂�jC!\�_�e\r\\h0yt\�cg�\�^�Q\�\�\�\��\�h`P��]¤�3�s�\\T۹$R+\�(�;q�QK�Tv�w.mg�@���\�\�\�\"Z9\�`S�X\�\�@\\�*8F\0\�-��X45mmLT���TV\�\�>B�IK��!Z 8�)����\\i��\�2wu]|X-%>�Wx\�[\�Gv�\�\�\��O\�軏r\ZK��\�X�EUS\Z\�`�T|Vpa\�\��\�\�קn�e\�=$縲J�j��vy�+K\���R�\��QQ��1�ʩ쵇p�((ma�\��q�{\�\�\�\��\�-9M\�\�4I�NQ�Hy\�$	R	<�Ւa\Z�S\�é<i��\�#\�į%v���\�����\�P\�\��P�Zf\�_�(徔B�Gu:��d��yN�\�5 ,R��X\\�A@\�5hFD�\�э����aA��\�LX@�e&�Q\�����D=��`�*��G�xD\�\�$�h^����tu\�W�d�,ZuЏ\�\�/&�d\�*_�Ghlџ~\�\�H\'y��F3G/3ᩖڀ՟g��\�BU�eL_\�\�Ň�4?)\�\�d\�\�l�˧24�\�HNB\�\���\n\�kٝ9��8IEv)|2��\Z\0s��)Qd\�NB\�m\�m��*�%\�\�k\rISf�n�D��$i�\�g��F-*P@�Rf�%<t�D�\�\�j�$���vJ\'�pʏ\Z�?ډ&����4\�F�ʤ\�G&�\�+�g���O�4�1\"Mg\�Lzɤ7\�d�:E\��h\�*�4ZI:��\ZI&ѓpT�C\�TŹ��\�T\\�\�\�]RC�O6�-h3��3�8���\�\�i\�y���꯳Y}�\�~6��5�n;J	�a��~6��3=\�xW֤U�\�\�\�g	$\�\0 \���IBC>\�P\�\�\�\�m��&\�V�\�\r\�\�\�\�\�\��u½�\��\�ێWr\��>X�\�0\��ʃZ�\Z\�\�){z+/��\�\��\�Y\�\�,U���]Y\��u{xi΄�g��rX�\�\�\�\���/�O}\�\�D�\��\�=by\�\�~��+�z>!��I\�R�\�F\�\"�,����\�\�Q\�k� l��\��QFM\�0*�\Z)�\�\�f\�\�qx\����2^\�U\�E\�§����\�;\�⟷T\�\�s�\��;\�\��w\��\��C�6%\�E\���|�G\�\n�FH\� 6�nIb\�R���\�B��pۅ�6�[oQkM�5��5\�$�*J�\�2�v�\�m�c�sj^0\�z+�\�⣶�\�,�\�\�\�\nA\�<����\�!�fM�MB�\���\��u�܄\�{�p���_��\�3\r�\�U���(\r���CJj�&/ڡ5\�&\r$;l�\�A\�G6ģ\�\Z\�Gp\�q�k4���Ɏ��h\�o6���\�\�؆\�[Q\�B\�6�	]��4�\�vC\�\��c�\�z����B�2K�y�»(�{�Qh\�DaBc��{ \�\�d\���IC�@q`A��J�\n�{j�\�\Z]��p&�V�\�\�ʼ6n\\�2\�A\� \�Y�\�bt�.Cs��)�\�#o�F{J@�n\���aD1��\�BPN��W�*�B\'\�\r@�ۄ\�S\�\�1\�I�a o�b^Dŝ�t�Y2qț\�2\�M1mrSz;��	��*���X5\�ŦQ�a�/��D_T̙\�\�̌Sf�82\�{̘����=�\n\�3���G�*g\r-X)<JT�O�.�qr\�B3�\\ �*�و\�^\�ƚ콂�\�t�1]f�\�\'�l#Fnl�7\r3�V|��am��sb�)/�sZ�\�V:�)\��\n8D@��=ӧ9|C��(\'�\'M\'�Fy��Vp~arj\"�\�*��L�\�J�̧%dH�\"jm�wBRn�h��.�LTDB\\�f�\�\�\�S$�\�N\�Y�b�W�8��f�P\�8����NU�\�\�b�в\�\�-��\�:��R�_j�b~�\�*泈*nw\�\�V\�m(���\�=\�csq\"o\�s���Z�#����Zc\�E�\�%\�\�[X-[z\� +\'l�JQ�\�S�xa&6\�w\'���YT	\"JQ�\��E������\�qY\��tl�N\ryEmEt�I�9��\"\� ��բ\�P�;3A�\� �\n\�.M�%\�\�(�,\�?S���\�S�[\�%��$��L0tfŘ�Z;3\r_+c�~� \'�C�\�I\�ٯ��w��Z~A;K/\�o*�\�`\�mk+D3\�_�\�D\�<\�}TjV��Y�۔�0.H�I�z��IQ2~�\��[\�\�n�\�4wн?\�\�\�>E]���Om;�V���,\Z\�\�U񆻏.�fz�\�\��\�U�\�W�%$����̋e�\�K�\�\�ҧ(T$T��\�R]\�`\�#b\�\�p�I\� ?\�-p�\�\�2\"킠پ:��6ARШˣ�\�n��\���\�>L\�\�\0\0','6.1.3-40302');
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
