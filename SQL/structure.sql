# --------------------------------------------------------
# Host:                         62.75.177.100
# Database:                     db_u10097_01
# Server version:               5.1.41-1.dotdeb.0-log
# Server OS:                    debian-linux-gnu
# HeidiSQL version:             Version 4.0, Revision 2968
# Date/time:                    2010-01-12 15:56:21
# --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
# Dumping database structure for db_u10097_01
CREATE DATABASE IF NOT EXISTS `JBM_34dfk` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `JBM_34dfk`;


# Dumping structure for table db_u10097_01.yabe_auction_feedback
CREATE TABLE IF NOT EXISTS `yabe_auction_feedback` (
  `eBay_ID` varchar(50) COLLATE latin1_german1_ci NOT NULL DEFAULT '0',
  `ebay_account` varchar(150) COLLATE latin1_german1_ci NOT NULL,
  `points` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `type` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `comment` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `rolle` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `feedback_time` datetime DEFAULT NULL,
  `lastupdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `bIsFeedback` enum('Y','N') COLLATE latin1_german1_ci DEFAULT 'N',
  PRIMARY KEY (`eBay_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='eBay Feedback zwischenspeicher';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_auction_list_history
CREATE TABLE IF NOT EXISTS `yabe_auction_list_history` (
  `eBay_ID` varchar(20) COLLATE latin1_german1_ci NOT NULL,
  `eBay_account` varchar(50) COLLATE latin1_german1_ci NOT NULL,
  `points` int(11) unsigned DEFAULT NULL,
  `email` varchar(150) COLLATE latin1_german1_ci NOT NULL,
  `picture_ID` int(10) unsigned DEFAULT NULL,
  `lastupdate` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' ON UPDATE CURRENT_TIMESTAMP,
  `startprice` decimal(9,2) unsigned DEFAULT NULL,
  `bids` smallint(5) unsigned DEFAULT NULL,
  `current_price` decimal(9,2) unsigned DEFAULT NULL,
  `auction_end` datetime DEFAULT NULL,
  `auction_title` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `shippment` varchar(10) COLLATE latin1_german1_ci DEFAULT '0',
  `payment_method` varchar(100) COLLATE latin1_german1_ci DEFAULT NULL,
  `percent_up` double unsigned DEFAULT NULL,
  `auction_begin` datetime DEFAULT NULL,
  `isSend` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `isBewertung` enum('Y','N') COLLATE latin1_german1_ci DEFAULT 'N',
  `isArticleCopy` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `iseBayEnded` varchar(15) COLLATE latin1_german1_ci DEFAULT 'false',
  `isGallery` enum('Y','N') COLLATE latin1_german1_ci DEFAULT 'N',
  `questions` tinyint(4) DEFAULT NULL,
  `ListType` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `isDeleted` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `watchcount` tinyint(3) unsigned DEFAULT '0',
  `eBayBild` varchar(350) COLLATE latin1_german1_ci DEFAULT NULL,
  `personal_id` int(10) unsigned NOT NULL DEFAULT '0',
  `feedbackpoints` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `hitcounter` int(10) unsigned DEFAULT NULL,
  `status` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `auction_type` varchar(50) COLLATE latin1_german1_ci DEFAULT 'eBay',
  `finalfee` double(9,2) DEFAULT NULL,
  `YABE_ID` tinytext COLLATE latin1_german1_ci,
  `paypal_sum` decimal(9,2) DEFAULT '0.00',
  PRIMARY KEY (`eBay_ID`,`eBay_account`,`email`,`personal_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_auction_list_history_copy2
CREATE TABLE IF NOT EXISTS `yabe_auction_list_history_copy2` (
  `eBay_ID` varchar(20) COLLATE latin1_german1_ci NOT NULL,
  `eBay_account` varchar(50) COLLATE latin1_german1_ci NOT NULL,
  `points` int(11) unsigned DEFAULT NULL,
  `email` varchar(150) COLLATE latin1_german1_ci NOT NULL,
  `picture_ID` int(10) unsigned DEFAULT NULL,
  `lastupdate` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00',
  `startprice` decimal(9,2) unsigned DEFAULT NULL,
  `bids` smallint(5) unsigned DEFAULT NULL,
  `current_price` decimal(9,2) unsigned DEFAULT NULL,
  `auction_end` datetime DEFAULT NULL,
  `auction_title` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `shippment` varchar(10) COLLATE latin1_german1_ci DEFAULT '0',
  `payment_method` varchar(100) COLLATE latin1_german1_ci DEFAULT NULL,
  `percent_up` double unsigned DEFAULT NULL,
  `auction_begin` datetime DEFAULT NULL,
  `isSend` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `isBewertung` enum('Y','N') COLLATE latin1_german1_ci DEFAULT 'N',
  `isArticleCopy` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `iseBayEnded` varchar(15) COLLATE latin1_german1_ci DEFAULT 'false',
  `isGallery` enum('Y','N') COLLATE latin1_german1_ci DEFAULT 'N',
  `questions` tinyint(4) DEFAULT NULL,
  `ListType` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `isDeleted` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `watchcount` tinyint(3) unsigned DEFAULT '0',
  `eBayBild` varchar(350) COLLATE latin1_german1_ci DEFAULT NULL,
  `personal_id` int(10) unsigned NOT NULL DEFAULT '0',
  `feedbackpoints` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `hitcounter` int(10) unsigned DEFAULT NULL,
  `status` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `auction_type` varchar(50) COLLATE latin1_german1_ci DEFAULT 'eBay',
  `finalfee` double(9,2) DEFAULT NULL,
  `YABE_ID` tinytext COLLATE latin1_german1_ci,
  `paypal_sum` decimal(9,2) DEFAULT '0.00',
  PRIMARY KEY (`eBay_ID`,`eBay_account`,`email`,`personal_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_auction_list_live
CREATE TABLE IF NOT EXISTS `yabe_auction_list_live` (
  `eBay_ID` varchar(20) COLLATE latin1_german1_ci NOT NULL,
  `eBay_account` varchar(50) COLLATE latin1_german1_ci NOT NULL,
  `points` int(10) unsigned DEFAULT NULL,
  `email` varchar(150) COLLATE latin1_german1_ci NOT NULL,
  `picture_ID` int(10) unsigned DEFAULT NULL,
  `lastupdate` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' ON UPDATE CURRENT_TIMESTAMP,
  `startprice` decimal(9,2) unsigned DEFAULT NULL,
  `bids` smallint(5) unsigned DEFAULT NULL,
  `current_price` decimal(9,2) unsigned DEFAULT NULL,
  `auction_end` datetime DEFAULT NULL,
  `auction_title` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `shippment` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `payment_method` varchar(100) COLLATE latin1_german1_ci DEFAULT NULL,
  `percent_up` double unsigned DEFAULT NULL,
  `auction_begin` datetime DEFAULT NULL,
  `isSend` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `isArticleCopy` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `iseBayEnded` varchar(15) COLLATE latin1_german1_ci DEFAULT 'false',
  `isGallery` enum('Y','N') COLLATE latin1_german1_ci DEFAULT 'N',
  `ListType` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `isDeleted` varchar(5) COLLATE latin1_german1_ci DEFAULT 'false',
  `watchcount` tinyint(3) unsigned DEFAULT '0',
  `eBayBild` varchar(350) COLLATE latin1_german1_ci DEFAULT NULL,
  `personal_id` int(10) unsigned NOT NULL DEFAULT '0',
  `feedbackpoints` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `hitcounter` int(10) unsigned DEFAULT '0',
  `questions` smallint(6) DEFAULT NULL,
  `YABE_ID` tinytext COLLATE latin1_german1_ci,
  `auction_type` varchar(50) COLLATE latin1_german1_ci DEFAULT 'eBay',
  `paypal_sum` decimal(9,2) DEFAULT '0.00',
  PRIMARY KEY (`eBay_ID`,`eBay_account`,`email`,`personal_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='eBay Auktionsliste Liveansicht';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_auction_pics
CREATE TABLE IF NOT EXISTS `yabe_auction_pics` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `eBay_ID` int(10) unsigned NOT NULL DEFAULT '0',
  `path` varchar(350) COLLATE latin1_german1_ci DEFAULT NULL,
  `lastupdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `path_small` varchar(350) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`ID`,`eBay_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_login
CREATE TABLE IF NOT EXISTS `yabe_login` (
  `id` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `account` varchar(50) DEFAULT NULL,
  `pwd` varchar(50) DEFAULT NULL,
  `lastlogin` timestamp NULL DEFAULT NULL,
  `logincount` int(10) unsigned DEFAULT '0',
  `loginfailed` tinyint(3) unsigned DEFAULT '0',
  `access_level` tinyint(3) unsigned DEFAULT '222',
  `iErrorReports` int(10) unsigned DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_order_history
CREATE TABLE IF NOT EXISTS `yabe_order_history` (
  `order_id` int(10) unsigned NOT NULL DEFAULT '0',
  `order_state` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `comment` text COLLATE latin1_german1_ci,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`order_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='Bestellverlauf';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_order_item
CREATE TABLE IF NOT EXISTS `yabe_order_item` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `orderID` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `item_title` varchar(500) COLLATE latin1_german1_ci DEFAULT NULL,
  `item_price` decimal(9,2) unsigned DEFAULT NULL,
  `payment_method` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `order_shippment` decimal(9,2) unsigned DEFAULT NULL,
  `auction_end` datetime DEFAULT NULL,
  `order_timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='Bestelldaten - Artikel';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_order_profile
CREATE TABLE IF NOT EXISTS `yabe_order_profile` (
  `orderID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `yabe_personals_id` tinyint(3) unsigned DEFAULT NULL,
  `order_history_id` int(10) unsigned NOT NULL DEFAULT '0',
  `eMail` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `webside_language` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `isWebside` enum('Y','N') COLLATE latin1_german1_ci DEFAULT NULL,
  `order_total` decimal(9,2) unsigned DEFAULT NULL,
  `lastupdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`orderID`,`order_history_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='Bestellgrunddaten';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_personals_adress
CREATE TABLE IF NOT EXISTS `yabe_personals_adress` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `eBay_account` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL COMMENT 'eBay Account',
  `email` varchar(100) COLLATE latin1_german1_ci NOT NULL,
  `Type` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `name` varchar(300) COLLATE latin1_german1_ci DEFAULT NULL,
  `street` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `zipcode` varchar(10) COLLATE latin1_german1_ci DEFAULT NULL,
  `bundesland` varchar(150) COLLATE latin1_german1_ci DEFAULT NULL,
  `city` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `country` varchar(300) COLLATE latin1_german1_ci DEFAULT NULL,
  `telefon` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `handy` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `email_second` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `firmenname` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  `adress_lastupdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `isPrinted` enum('Y','N') COLLATE latin1_german1_ci DEFAULT 'N',
  `profil_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`ID`,`profil_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='Kundenstamm Adressdaten';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_personals_profile
CREATE TABLE IF NOT EXISTS `yabe_personals_profile` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `eBay_account` varchar(50) COLLATE latin1_german1_ci NOT NULL DEFAULT '' COMMENT 'eBay Mitgliedsname',
  `email` varchar(150) CHARACTER SET latin1 NOT NULL,
  `isWebUser` enum('Y','N') CHARACTER SET latin1 DEFAULT 'N',
  `CRC` varchar(40) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `website_account` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  `website_pwd` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `PartnerID` int(11) DEFAULT NULL,
  `lastupdate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `sprache` varchar(35) COLLATE latin1_german1_ci DEFAULT NULL,
  `letzter_email_klick` datetime DEFAULT '0000-00-00 00:00:00',
  `letzte_mail` enum('Y','N') CHARACTER SET latin1 DEFAULT 'N',
  `eMail_click_count` int(10) unsigned DEFAULT '0',
  `getNewsletter` enum('Y','N') CHARACTER SET latin1 DEFAULT 'Y',
  `webseite_lastlogin` timestamp NULL DEFAULT NULL,
  `newsletter_sended` timestamp NULL DEFAULT NULL,
  `delcampe_userid` tinytext COLLATE latin1_german1_ci,
  `sprach_liste` tinytext COLLATE latin1_german1_ci,
  `delcampe_account` tinytext COLLATE latin1_german1_ci,
  PRIMARY KEY (`ID`,`eBay_account`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='Kundenstamm Grunddaten';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_personals_profile_copy
CREATE TABLE IF NOT EXISTS `yabe_personals_profile_copy` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `eBay_account` varchar(50) COLLATE latin1_german1_ci NOT NULL DEFAULT 'Webkunde' COMMENT 'eBay Mitgliedsname',
  `email` varchar(150) CHARACTER SET latin1 NOT NULL,
  `isWebUser` enum('Y','N') CHARACTER SET latin1 DEFAULT 'N',
  `CRC` varchar(40) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `website_account` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  `website_pwd` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `PartnerID` int(11) DEFAULT NULL,
  `lastupdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sprache` varchar(35) COLLATE latin1_german1_ci DEFAULT NULL,
  `letzter_email_klick` datetime DEFAULT '0000-00-00 00:00:00',
  `letzte_mail` enum('Y','N') CHARACTER SET latin1 DEFAULT 'N',
  `eMail_click_count` int(10) unsigned DEFAULT '0',
  `getNewsletter` enum('Y','N') CHARACTER SET latin1 DEFAULT 'Y',
  `webseite_lastlogin` timestamp NULL DEFAULT NULL,
  `newsletter_sended` timestamp NULL DEFAULT NULL,
  `delcampe_userid` tinytext COLLATE latin1_german1_ci,
  `sprach_liste` tinytext COLLATE latin1_german1_ci,
  `delcampe_account` tinytext COLLATE latin1_german1_ci,
  PRIMARY KEY (`ID`,`eBay_account`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_plattforms
CREATE TABLE IF NOT EXISTS `yabe_plattforms` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Orderid` smallint(6) NOT NULL DEFAULT '0',
  `Name` varchar(255) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='Stellt eine Liste mit verfügbaren Plattformen zur Verfügung';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_tbl_email_vorlage
CREATE TABLE IF NOT EXISTS `yabe_tbl_email_vorlage` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Text` text CHARACTER SET latin1 COLLATE latin1_german1_ci NOT NULL,
  `Bereich` varchar(300) CHARACTER SET latin1 COLLATE latin1_german1_ci DEFAULT NULL,
  `Text_sp` text CHARACTER SET latin1 COLLATE latin1_german1_ci,
  `Benutzer` varchar(200) CHARACTER SET latin1 COLLATE latin1_german1_ci DEFAULT NULL,
  `lastUpdate` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `yabe_function` tinytext COLLATE utf8_bin,
  `sprache` tinytext COLLATE utf8_bin,
  `sorting` tinyint(10) DEFAULT NULL,
  `Text_eng` text COLLATE utf8_bin,
  `Text_fr` text COLLATE utf8_bin,
  `Betreff` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Betreff_eng` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Betreff_fr` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `Text_ru` text COLLATE utf8_bin,
  `Text_cn` text COLLATE utf8_bin,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_tbl_email_vorlage_sprachen
CREATE TABLE IF NOT EXISTS `yabe_tbl_email_vorlage_sprachen` (
  `ID` int(10) NOT NULL DEFAULT '0',
  `Name` varchar(250) DEFAULT NULL,
  `ISO` varchar(10) DEFAULT NULL,
  `order` tinyint(10) DEFAULT NULL,
  `google_code` varchar(10) DEFAULT NULL,
  `visible` char(1) DEFAULT NULL,
  `continent` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_translate_search_replace
CREATE TABLE IF NOT EXISTS `yabe_translate_search_replace` (
  `suche` varchar(250) DEFAULT NULL,
  `ersetze` varchar(250) DEFAULT NULL,
  `sprache` varchar(50) DEFAULT NULL,
  `lastupdate` datetime DEFAULT NULL,
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ID`),
  KEY `ID` (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='Translator suchen und ersetzten ermöglichen';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_updater
CREATE TABLE IF NOT EXISTS `yabe_updater` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) COLLATE latin1_german1_ci DEFAULT NULL,
  `version` varchar(30) COLLATE latin1_german1_ci DEFAULT NULL,
  `url_download` varchar(350) COLLATE latin1_german1_ci DEFAULT NULL,
  `download_count` int(10) unsigned DEFAULT NULL COMMENT '0',
  `comment` varchar(500) COLLATE latin1_german1_ci DEFAULT NULL,
  `lastupdate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `lastdownload` timestamp NULL DEFAULT NULL,
  `upload_path` varchar(350) COLLATE latin1_german1_ci DEFAULT NULL,
  `upload_name` varchar(250) COLLATE latin1_german1_ci DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci COMMENT='YABE - Updater Überwachung';

# Data exporting was unselected.


# Dumping structure for table db_u10097_01.yabe_updater_history
CREATE TABLE IF NOT EXISTS `yabe_updater_history` (
  `history_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `customer_id` int(10) unsigned NOT NULL DEFAULT '0',
  `app_id` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `update_timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`history_id`,`customer_id`,`app_id`),
  KEY `history_id` (`history_id`,`customer_id`,`app_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='History über die Updates';

# Data exporting was unselected.
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
