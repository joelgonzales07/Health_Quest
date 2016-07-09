/*
SQLyog Community v10.3 
MySQL - 5.5.24-log : Database - hq_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`hq_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `hq_db`;

/*Table structure for table `consultation_tbl` */

DROP TABLE IF EXISTS `consultation_tbl`;

CREATE TABLE `consultation_tbl` (
  `Cons_id` varchar(50) DEFAULT NULL,
  `Cons_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `consultation_tbl` */

insert  into `consultation_tbl`(`Cons_id`,`Cons_name`) values ('eaade466-88a7-482a-aea6-20e54f65d2e4','C101');

/*Table structure for table `department_tbl` */

DROP TABLE IF EXISTS `department_tbl`;

CREATE TABLE `department_tbl` (
  `dept_id` varchar(50) DEFAULT NULL,
  `dept_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `department_tbl` */

insert  into `department_tbl`(`dept_id`,`dept_name`) values ('eb0e7abd-3b48-489b-a82c-937a1520d0e0','ICT');

/*Table structure for table `doctor_tbl` */

DROP TABLE IF EXISTS `doctor_tbl`;

CREATE TABLE `doctor_tbl` (
  `doc_id` varchar(50) DEFAULT NULL,
  `doc_name` varchar(50) DEFAULT NULL,
  `doc_contact` varchar(11) DEFAULT NULL,
  `doc_address` text,
  `specialization` varchar(50) DEFAULT NULL,
  `consultation` varchar(50) DEFAULT NULL,
  `department` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `doctor_tbl` */

insert  into `doctor_tbl`(`doc_id`,`doc_name`,`doc_contact`,`doc_address`,`specialization`,`consultation`,`department`) values ('1001','Dr. Gumop-as','4348439','#101','BATONY','C101','ICT'),('d473751c-e3fb-437f-a618-0230984af5d5','Dr. Gonzales','4348439','#23 Ipil Interior Feria Road Diliman Matandang Balara Street Quezon City','','',''),('f1fb9d1c-7f20-4a5d-b849-99d7f8b2261d','DR. Alvarez','','','BATONY','C101','ICT');

/*Table structure for table `hmo_tbl` */

DROP TABLE IF EXISTS `hmo_tbl`;

CREATE TABLE `hmo_tbl` (
  `Record_ID` varchar(50) NOT NULL,
  `hmo_num` varchar(50) DEFAULT NULL,
  `company_name` text,
  PRIMARY KEY (`Record_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `hmo_tbl` */

insert  into `hmo_tbl`(`Record_ID`,`hmo_num`,`company_name`) values ('1','101','101'),('c8373446-98d3-484b-9f91-7c9d5b26d703','G11011','GLOBAL'),('fbd36cbf-b3e7-4df9-82e1-c2ffde4ec0e4','001761-01439-9','ACCENTURE');

/*Table structure for table `id_tbl` */

DROP TABLE IF EXISTS `id_tbl`;

CREATE TABLE `id_tbl` (
  `id` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `id_tbl` */

/*Table structure for table `inventory_tbl` */

DROP TABLE IF EXISTS `inventory_tbl`;

CREATE TABLE `inventory_tbl` (
  `item_id` varchar(50) DEFAULT NULL,
  `quantity` int(7) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `inventory_tbl` */

insert  into `inventory_tbl`(`item_id`,`quantity`,`description`) values ('79b3910a-3fb1-4301-a603-f827a8cf7fac',50,'1/4'),('a0af6999-1a44-4b13-8280-27473a7c57cb',40,'liquid state 500ml');

/*Table structure for table `item_category_tbl` */

DROP TABLE IF EXISTS `item_category_tbl`;

CREATE TABLE `item_category_tbl` (
  `item_cat_id` varchar(50) DEFAULT NULL,
  `item_category` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `item_category_tbl` */

insert  into `item_category_tbl`(`item_cat_id`,`item_category`) values ('5be944c3-e97b-4ce6-819b-8aed7e7f8a3c','TEST');

/*Table structure for table `item_type_tbl` */

DROP TABLE IF EXISTS `item_type_tbl`;

CREATE TABLE `item_type_tbl` (
  `item_id` varchar(50) DEFAULT NULL,
  `item_category` varchar(50) DEFAULT NULL,
  `item` varchar(50) DEFAULT NULL,
  `stat` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `item_type_tbl` */

insert  into `item_type_tbl`(`item_id`,`item_category`,`item`,`stat`) values ('79b3910a-3fb1-4301-a603-f827a8cf7fac','TEST','TEST1',1),('a0af6999-1a44-4b13-8280-27473a7c57cb','TEST','TEST',1),('c27db732-2545-424f-beaf-03897b125e11','TEST','TESTEST',0),('d594d725-2ca1-48c8-90cd-0389af49af8c','TEST','TEST3',0),('c308629d-a015-4ddf-a27c-3f245ad1f7e2','TEST','TESTTEST',0);

/*Table structure for table `package_service_tbl` */

DROP TABLE IF EXISTS `package_service_tbl`;

CREATE TABLE `package_service_tbl` (
  `ID` varchar(50) DEFAULT NULL,
  `package_name` varchar(50) DEFAULT NULL,
  `service_type` varchar(50) DEFAULT NULL,
  `gross` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `package_service_tbl` */

insert  into `package_service_tbl`(`ID`,`package_name`,`service_type`,`gross`) values ('708ae208-2ddf-45d5-91b5-29f79b5e6922','Package 1','TEST11','110'),('d655b00b-d3ea-4115-95a5-7b69f5466a98','Package 1','TEST12','150');

/*Table structure for table `package_tbl` */

DROP TABLE IF EXISTS `package_tbl`;

CREATE TABLE `package_tbl` (
  `pack_id` varchar(50) DEFAULT NULL,
  `pack_name` varchar(50) DEFAULT NULL,
  `price` double(11,5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `package_tbl` */

insert  into `package_tbl`(`pack_id`,`pack_name`,`price`) values ('fbc2218c-6295-46e6-9e12-b8521edeb29e','Package 1',200.00000),('fc29a3e2-5b24-4acb-8412-19d82ad4ff30','Package 2',NULL),('caf74008-97df-4458-8955-b550983f714b','Package 3',NULL);

/*Table structure for table `patient_laboratory_tbl` */

DROP TABLE IF EXISTS `patient_laboratory_tbl`;

CREATE TABLE `patient_laboratory_tbl` (
  `patient_id` varchar(50) DEFAULT NULL,
  `l_type` varchar(50) DEFAULT NULL,
  `bp` varchar(50) DEFAULT NULL,
  `diagnosis` varchar(50) DEFAULT NULL,
  `cc` varchar(50) DEFAULT NULL,
  `hip` varchar(50) DEFAULT NULL,
  `pe` varchar(50) DEFAULT NULL,
  `lmp` varchar(50) DEFAULT NULL,
  `ht` varchar(50) DEFAULT NULL,
  `wt` varchar(50) DEFAULT NULL,
  `stat` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `patient_laboratory_tbl` */

/*Table structure for table `patient_tbl` */

DROP TABLE IF EXISTS `patient_tbl`;

CREATE TABLE `patient_tbl` (
  `patient_number` varchar(50) DEFAULT NULL,
  `lname` varchar(30) DEFAULT NULL,
  `fname` varchar(30) DEFAULT NULL,
  `mname` varchar(30) DEFAULT NULL,
  `bday` date DEFAULT NULL,
  `age` int(3) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `address` text,
  `tel` varchar(11) DEFAULT NULL,
  `mob` varchar(11) DEFAULT NULL,
  `p_name` varchar(50) DEFAULT NULL,
  `email` text,
  `c_fee` double(11,5) DEFAULT NULL,
  `t_r` text,
  `med_information` varchar(30) DEFAULT NULL,
  `tdate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `patient_tbl` */

insert  into `patient_tbl`(`patient_number`,`lname`,`fname`,`mname`,`bday`,`age`,`gender`,`address`,`tel`,`mob`,`p_name`,`email`,`c_fee`,`t_r`,`med_information`,`tdate`) values ('20150001','Gumop-as','Wilver','De Asis','1991-11-30',24,'MALE','','','','Dr. Gumop-as','',0.00000,'','','2015-02-19'),('20150002','Gonzales','Airabell','','2015-01-18',0,'FEMALE','#23 Ipil Interior Feria Road Diliman Quezon City','4348439','09304515983','Dr. Gumop-as','miss.kizmeeh@yahoo.com',0.00000,'','','2015-03-18');

/*Table structure for table `report_tbl` */

DROP TABLE IF EXISTS `report_tbl`;

CREATE TABLE `report_tbl` (
  `patient_id` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `report_tbl` */

/*Table structure for table `request_tbl` */

DROP TABLE IF EXISTS `request_tbl`;

CREATE TABLE `request_tbl` (
  `request_id` varchar(50) DEFAULT NULL,
  `staff_name` varchar(50) DEFAULT NULL,
  `item_name` varchar(50) DEFAULT NULL,
  `quantity` int(7) DEFAULT NULL,
  `stat` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `request_tbl` */

/*Table structure for table `schedule_tbl` */

DROP TABLE IF EXISTS `schedule_tbl`;

CREATE TABLE `schedule_tbl` (
  `doctor_id` varchar(50) NOT NULL,
  `monday` varchar(50) DEFAULT NULL,
  `tuesday` varchar(50) DEFAULT NULL,
  `wednesday` varchar(50) DEFAULT NULL,
  `thursday` varchar(50) DEFAULT NULL,
  `friday` varchar(50) DEFAULT NULL,
  `saturday` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`doctor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `schedule_tbl` */

insert  into `schedule_tbl`(`doctor_id`,`monday`,`tuesday`,`wednesday`,`thursday`,`friday`,`saturday`) values ('d473751c-e3fb-437f-a618-0230984af5d5','7:00 - 10:00am','7:00- 10:00pm','','','',''),('f1fb9d1c-7f20-4a5d-b849-99d7f8b2261d','','','','','8:00-9:00am','');

/*Table structure for table `service_category_tbl` */

DROP TABLE IF EXISTS `service_category_tbl`;

CREATE TABLE `service_category_tbl` (
  `Scat_id` varchar(50) DEFAULT NULL,
  `Scat_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service_category_tbl` */

insert  into `service_category_tbl`(`Scat_id`,`Scat_name`) values ('4651f0b8-e75c-4723-9dce-0600cec66593','TEST1');

/*Table structure for table `service_information_tbl` */

DROP TABLE IF EXISTS `service_information_tbl`;

CREATE TABLE `service_information_tbl` (
  `record_id` varchar(50) DEFAULT NULL,
  `patient_id` varchar(50) DEFAULT NULL,
  `service_type` varchar(50) DEFAULT NULL,
  `gross` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `tdate` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service_information_tbl` */

insert  into `service_information_tbl`(`record_id`,`patient_id`,`service_type`,`gross`,`status`,`tdate`) values ('8324b4ab-f4a8-418c-8e75-1e266e231953','20150002','TEST11','110','paid','2015-03-18'),('8324b4ab-f4a8-418c-8e75-1e266e231953','20150002','TEST12','150','paid','2015-03-18'),('aedd747f-a5ac-4dd7-a36f-89298db7e5ad','20150001','Package 1','200','paid','2015-03-18'),('2e498fcf-9d1f-4175-b718-99e8b9eb2a9e','20150001','Package 1','200','unpaid','2015-03-18'),('4723a849-f52e-47f8-9d9a-11c7b46a88d5','20150002','TEST11','110','paid','2015-03-18');

/*Table structure for table `service_payment_tbl` */

DROP TABLE IF EXISTS `service_payment_tbl`;

CREATE TABLE `service_payment_tbl` (
  `record_id2` varchar(50) DEFAULT NULL,
  `record_id` varchar(50) DEFAULT NULL,
  `Total_Gross` double(11,2) DEFAULT NULL,
  `payment` double(11,2) DEFAULT NULL,
  `changes` double(11,2) DEFAULT NULL,
  `balance` double(11,2) DEFAULT NULL,
  `service_status` varchar(50) DEFAULT NULL,
  `payment_status` varchar(50) DEFAULT NULL,
  `service_number` int(100) NOT NULL AUTO_INCREMENT,
  `hmo_number` varchar(50) DEFAULT NULL,
  `hmo_status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`service_number`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

/*Data for the table `service_payment_tbl` */

insert  into `service_payment_tbl`(`record_id2`,`record_id`,`Total_Gross`,`payment`,`changes`,`balance`,`service_status`,`payment_status`,`service_number`,`hmo_number`,`hmo_status`) values ('76358f5b-4cee-4dd4-b161-65f0b61c1019','8324b4ab-f4a8-418c-8e75-1e266e231953',260.00,60.00,0.00,0.00,'normal','Downpayment',20,NULL,'FALSE'),('e3901762-5e67-4429-ad27-5eeb1f37a169','aedd747f-a5ac-4dd7-a36f-89298db7e5ad',160.00,200.00,40.00,NULL,'Discounted','Fullpayment',21,NULL,'FALSE'),('9f4c7f32-bc52-49d9-8461-41e103aaacd9','2e498fcf-9d1f-4175-b718-99e8b9eb2a9e',200.00,NULL,NULL,NULL,NULL,NULL,22,'001761-01439-9','HMO'),('9cd8cf44-82b4-447b-9ecd-44cb7c81a773','4723a849-f52e-47f8-9d9a-11c7b46a88d5',110.00,10.00,0.00,0.00,'normal','Downpayment',23,NULL,'FALSE');

/*Table structure for table `service_price_tbl` */

DROP TABLE IF EXISTS `service_price_tbl`;

CREATE TABLE `service_price_tbl` (
  `service_id` varchar(50) NOT NULL,
  `service_net` double(11,2) DEFAULT NULL,
  `service_vat` double(11,2) DEFAULT NULL,
  `service_gross` double(11,2) DEFAULT NULL,
  PRIMARY KEY (`service_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service_price_tbl` */

insert  into `service_price_tbl`(`service_id`,`service_net`,`service_vat`,`service_gross`) values ('cb45666b-ea36-4783-af13-25196f5325d7',98.21,11.79,110.00),('f857374f-2e47-4d14-8517-3705f1f7de56',133.93,16.07,150.00);

/*Table structure for table `service_type_tbl` */

DROP TABLE IF EXISTS `service_type_tbl`;

CREATE TABLE `service_type_tbl` (
  `stype_id` varchar(50) DEFAULT NULL,
  `stype_name` varchar(50) DEFAULT NULL,
  `stype_category` varchar(50) DEFAULT NULL,
  `stat` int(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service_type_tbl` */

insert  into `service_type_tbl`(`stype_id`,`stype_name`,`stype_category`,`stat`) values ('cb45666b-ea36-4783-af13-25196f5325d7','TEST11','TEST1',1),('f857374f-2e47-4d14-8517-3705f1f7de56','TEST12','TEST1',1),('a8398af2-e378-4536-b14a-0e1ebf04dacc','TEST3','TEST1',0);

/*Table structure for table `specialization_tbl` */

DROP TABLE IF EXISTS `specialization_tbl`;

CREATE TABLE `specialization_tbl` (
  `spec_id` varchar(50) DEFAULT NULL,
  `spec_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `specialization_tbl` */

insert  into `specialization_tbl`(`spec_id`,`spec_name`) values ('3e9120fb-bf39-4bf0-bdd7-f4a9c55d40b8','BATONY');

/*Table structure for table `staff_tbl` */

DROP TABLE IF EXISTS `staff_tbl`;

CREATE TABLE `staff_tbl` (
  `record_id` varchar(50) DEFAULT NULL,
  `name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `staff_tbl` */

/*Table structure for table `user_tbl` */

DROP TABLE IF EXISTS `user_tbl`;

CREATE TABLE `user_tbl` (
  `User_id` varchar(50) DEFAULT NULL,
  `u_name` varchar(50) DEFAULT NULL,
  `Username` varchar(20) NOT NULL,
  `Passwords` varchar(20) DEFAULT NULL,
  `Position` varchar(15) DEFAULT NULL,
  `contact` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user_tbl` */

insert  into `user_tbl`(`User_id`,`u_name`,`Username`,`Passwords`,`Position`,`contact`) values ('ksanceja','ksanceja','ksanceja','tokyo8love','ADMINISTRATOR',''),('mbuendia','mbuendia','mbuendia','michael','Receptionist',''),('rramos','rramos','rramos','123456','Cashier','');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
