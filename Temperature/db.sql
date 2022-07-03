/*
SQLyog Ultimate v12.14 (64 bit)
MySQL - 8.0.24 : Database - temperaturedb
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`temperaturedb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `temperaturedb`;

/*Table structure for table `city` */

DROP TABLE IF EXISTS `city`;

CREATE TABLE `city` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `morning` double DEFAULT NULL,
  `day` double DEFAULT NULL,
  `evening` double DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `city` */

insert  into `city`(`Id`,`name`,`date`,`morning`,`day`,`evening`) values (1,'Хуҷанд','2022-07-01',25,42,23);
insert  into `city`(`Id`,`name`,`date`,`morning`,`day`,`evening`) values (2,'Хуҷанд','2022-07-02',24,41,26);
insert  into `city`(`Id`,`name`,`date`,`morning`,`day`,`evening`) values (3,'Хуҷанд','2022-07-03',23,40,22);
insert  into `city`(`Id`,`name`,`date`,`morning`,`day`,`evening`) values (4,'Душанбе','2022-07-01',20,38,22);
insert  into `city`(`Id`,`name`,`date`,`morning`,`day`,`evening`) values (5,'Душанбе','2022-07-02',22,39,25);
insert  into `city`(`Id`,`name`,`date`,`morning`,`day`,`evening`) values (6,'Душанбе','2022-07-03',26,42,25);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
