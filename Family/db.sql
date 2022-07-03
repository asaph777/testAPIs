/*
SQLyog Ultimate v12.14 (64 bit)
MySQL - 8.0.24 : Database - family
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`family` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `family`;

/*Table structure for table `odam` */

DROP TABLE IF EXISTS `odam`;

CREATE TABLE `odam` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `dateBirth` date DEFAULT NULL,
  `father` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `father` (`father`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `odam` */

insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (1,'Амир','2022-05-31',NULL);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (2,'Карим','2022-06-01',1);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (3,'Ҳаким','2022-06-02',1);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (4,'Мунир','2022-06-03',1);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (5,'Камол','2022-06-08',2);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (6,'Комил','2022-06-15',2);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (7,'Комрон','2022-06-22',2);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (8,'Ҳаниф','2022-06-09',3);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (9,'Ҳоким','2022-06-16',3);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (10,'Ҳомид','2022-06-23',3);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (11,'Малик','2022-06-10',4);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (12,'Мавлон','2022-06-17',4);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (13,'Ману','2022-06-24',4);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (14,'Камила','2022-07-08',5);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (15,'Каромат','2022-07-15',5);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (16,'Кумри','2022-07-09',6);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (17,'Кумуш','2022-07-16',6);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (18,'Хабиба','2022-07-10',8);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (19,'Ховар','2022-07-17',8);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (20,'Хадича','2022-07-18',9);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (21,'Хамро','2022-07-25',9);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (22,'Кахрамон','2022-07-26',7);
insert  into `odam`(`id`,`name`,`dateBirth`,`father`) values (23,'Халима','2022-07-27',10);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
