/*
SQLyog - Free MySQL GUI v5.02
Host - 5.0.7-beta-nt : Database - hq_db
*********************************************************************
Server version : 5.0.7-beta-nt
*/


create database if not exists `hq_db`;

USE `hq_db`;

/*Table structure for table `consultation_tbl` */

DROP TABLE IF EXISTS `consultation_tbl`;

CREATE TABLE `consultation_tbl` (
  `Cons_id` varchar(50) default NULL,
  `Cons_name` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `consultation_tbl` */

insert into `consultation_tbl` values 
('c87dec2a-e745-446e-9593-2ac250e6a7be','Family Medicine'),
('6e57e6e0-5c2f-49f4-b535-52206ef486aa','Pediatric'),
('ba80c611-1489-4b4f-975a-f8bae7d1e10c','Pulmonologist'),
('60690c7b-1c13-400c-9fba-201a0f703cc8','Endocrinologist'),
('0a515395-5c83-45c6-8748-d8d97f51555e','Obstetrics and Gynecology'),
('67ed019b-fed9-46cd-be8c-eb39bd2af9ad','Cardiologist'),
('5ad4e0ce-6eec-4261-9907-435d9be0dbfd','E.N.T'),
('46ad69b5-1575-47d6-9130-4adede89f4c4','E.E.N.T.'),
('b2df1ee2-9dd3-42a5-9ee7-8262b5e0d49b','Urologist'),
('a8e86d66-330c-4dfe-8555-80553f101b37','Orthopedic Surgeon'),
('c8e16c79-1a4a-46ce-8f1c-81932034f71c','Nephrologist');

/*Table structure for table `department_tbl` */

DROP TABLE IF EXISTS `department_tbl`;

CREATE TABLE `department_tbl` (
  `dept_id` varchar(50) default NULL,
  `dept_name` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `department_tbl` */

insert into `department_tbl` values 
('001','OB-Gynecology'),
('002','Internal Medicine'),
('2eee0f67-0b43-411d-8b48-04c6b1a5d7be','Family Medicine'),
('ea3f4419-3082-4362-9da3-953bed95e96a','Pediatric'),
('9dea19f1-cd2a-4e7c-a787-ab67567837f6','IM-Nephrology'),
('bed61a03-39be-46df-9c34-524e9a8dc8b4','IM-Gastroenterology'),
('5f6faa9b-ca06-4e64-8360-e9c8f55339ef','IM-Cardiology'),
('ae6ccdbe-52fd-4345-b0f5-c02866a7b4cd','Surgery'),
('8c1fe0bf-e241-42ae-9661-fcd16867e9c1','ENT'),
('f55cb3de-bf30-430f-87c9-bbdfb91f8cdd','Surgery');

/*Table structure for table `doctor_tbl` */

DROP TABLE IF EXISTS `doctor_tbl`;

CREATE TABLE `doctor_tbl` (
  `doc_id` varchar(50) default NULL,
  `doc_name` varchar(50) default NULL,
  `doc_contact` varchar(11) default NULL,
  `doc_address` text,
  `specialization` varchar(50) default NULL,
  `consultation` varchar(50) default NULL,
  `department` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `doctor_tbl` */

insert into `doctor_tbl` values 
('7e4cd04a-d7e9-49dd-8c8d-33d1b5073af4','Gloria Samson','09255014465','','OB-GYN','','OB-Gyn'),
('ccf1b187-0e86-4a4e-adc2-97980d71ea0a','Tisha Briola','09228812307','','PEDIATRIC','','Pediatric'),
('c13dac62-1f7b-4af6-8edf-74cb025d521d','Mary Grace Viray','09228785988','','PEDIATRIC','Pediatric','Pediatric'),
('e0cadcbd-b889-45a7-bb5d-41ee9a4c101a','Consolacion Albornoz','09178719832','','FAMILY MEDICINE','Pediatric','Family Medicine'),
('d5c63314-4096-4ed4-928f-8199c98f1232','Antonietta Asuncion','09209533738','','OB-GYN','','OB-Gyn'),
('08fe3fca-c9f4-4c5d-8aef-b8092653d213','Jovic Bartolabac','09228508017','','OB-GYN','','OB-Gyn'),
('d815322c-254a-4fcc-bc03-38927a543bcc','Susan Bolima','09165395911','','PEDIATRIC','Pediatric','Pediatric'),
('f6540fb1-7dd4-41c9-87f9-e3e1ef805c7e','Violy Casiguran','09155052582','','FAMILY MEDICINE','Family Medicine','Family Medicine'),
('460328ff-0bae-49ce-a855-27762a0397c3','Karen June Dumlao','09285022804','','INTERNAL MEDICINE','',''),
('2f32bcd9-62c9-4159-8eb4-f5740644a2b0','Mayshara Montojo','','','','',''),
('18340027-af2d-4521-b3ec-4c0e92a0ec77','Cindy Esquivel','09285249244','','PEDIATRIC','Pediatric','Pediatric'),
('47bee28d-5542-41af-b033-161fc86be9e2','Teresa Marie Felizardo','09178235540','','OB-GYN','','OB-Gyn'),
('af6de2d0-8b8d-48c1-8164-f10da221f773','Lyndon Samson','0922832069','','INTERNAL MEDICINE','Pulmonologist','IM-Pulmonology'),
('98e2dcd5-f4f6-459b-8bc8-e80608499a44','Teresa Marie Felizardo','09178235540','','OB-GYN','','OB-Gyn'),
('0212c8ee-e77a-462c-b6fa-d8bfde5e01cc','Jose Mari Galauran','09175529057','','INTERNAL MEDICINE','','IM-Nephrology'),
('5eed8cb7-052c-45da-96fe-a39c06f01337','Marianne Garcia','09173290292','','INTERNAL MEDICINE','','IM-Gastroenterology'),
('372630da-ab35-4195-b1ef-0068f37aee28','Dra. Macapugay','09178653014','','INTERNAL MEDICINE','','IM-Cardiology'),
('89cde479-e4f1-4a7e-bf7e-af62c861d1fd','Dra. Millanes','09053256781','','PEDIATRIC','Pediatric','Pediatric'),
('cc46722c-c6b3-4456-ad93-4b529e8ee9dd','Cathleen Santiago','09175161208','','RADIOLOGIST','','OB-Gyn'),
('643ac881-9148-4a64-b6fb-b9f99aa63a1c','Ciely Pastores','09228298178','','RADIOLOGIST','',''),
('70593ab4-d565-4a60-a8f2-ac7f47f81a12','Vic Asuncion','09178103381','','RADIOLOGIST','',''),
('809d770e-b568-4fa8-a13a-b5827efec52c','Precious Diaz','','','RADIOLOGIST','','OB-Gyn'),
('c39f23e2-b7ab-46ba-9232-5e9f4fb83886','Joseph Tiangco','09228358810','','INTERNAL MEDICINE','','General Surgeon'),
('cadc3548-6f43-4a7a-9f48-6d25f9c94b5e','Dra. Go','09228324611','','FAMILY MEDICINE','','Family Medicine'),
('c1494287-ca29-4cef-b382-f2eb6a6c2719','Dra. Chua','','','INTERNAL MEDICINE','','Family Medicine'),
('806cdd3d-bbad-4601-9d1f-911189c25fc2','Dra. Olay','09228107951','','','',''),
('c8418012-4d8d-4491-896a-9ac22fbd7fa3','Dra. Borge','09228107951','','OB-SONOLOGY','Family Medicine','OB-Gynecology'),
('d7144639-7662-4fc8-b648-68ff3549d4b7','Dra. Adan','09228107951','','','','');

/*Table structure for table `id_tbl` */

DROP TABLE IF EXISTS `id_tbl`;

CREATE TABLE `id_tbl` (
  `id` int(4) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `id_tbl` */

insert into `id_tbl` values 
(1304);

/*Table structure for table `inventory_tbl` */

DROP TABLE IF EXISTS `inventory_tbl`;

CREATE TABLE `inventory_tbl` (
  `item_id` varchar(50) default NULL,
  `quantity` int(7) default NULL,
  `description` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `inventory_tbl` */

insert into `inventory_tbl` values 
('252f935b-29ee-4fae-b737-9dc678a4c478',60,'test'),
('ca8140e9-a188-4149-9125-47ed4a18f10d',150,'test'),
('1d42f372-c133-49f9-b090-d3110a394e66',5,'large'),
('cee85d4c-b4f9-4b66-852a-f9edd325bc3f',25,'large');

/*Table structure for table `item_category_tbl` */

DROP TABLE IF EXISTS `item_category_tbl`;

CREATE TABLE `item_category_tbl` (
  `item_cat_id` varchar(50) default NULL,
  `item_category` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `item_category_tbl` */

insert into `item_category_tbl` values 
('5048cdfd-bc40-42e5-a925-c2329b09d43f','LABORATORY-SUPPLIES'),
('011d8045-8ea9-485b-86ff-6131de29f891','LABORATORY-EQUIPMENT'),
('e17b8373-22a8-4372-a23f-3718adcb7a2a','X-RAY-SUPPLIES'),
('240f8fad-4c2f-4267-8f33-d873c2c4c192','ULTRASOUND-SUPPLIES'),
('a8919563-4f10-478f-b48c-8026172ed633','ECG-SUPPLIES'),
('ab8ec521-ebe7-4435-a615-ac185915eb0a','ADMIN-SUPPLIES'),
('e3d7419b-0191-4cc1-a472-bd1ba02a1736','MEDICAL-SUPPLIES'),
('7dad0307-4be0-41aa-951b-4bf57a649a6e','MEDICAL-EQUIPMENT'),
('a8cc851f-0544-4126-bad5-2808a316cc9b','ADMIN-EQUIPMENT');

/*Table structure for table `item_type_tbl` */

DROP TABLE IF EXISTS `item_type_tbl`;

CREATE TABLE `item_type_tbl` (
  `item_id` varchar(50) default NULL,
  `item_category` varchar(50) default NULL,
  `item` varchar(50) default NULL,
  `stat` int(1) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `item_type_tbl` */

insert into `item_type_tbl` values 
('252f935b-29ee-4fae-b737-9dc678a4c478','LABORATORY-SUPPLIES','LYSE GENIUS KT-03',1),
('ca8140e9-a188-4149-9125-47ed4a18f10d','LABORATORY-SUPPLIES','TEST',1),
('1d42f372-c133-49f9-b090-d3110a394e66','X-RAY-SUPPLIES','TEST3',1),
('cee85d4c-b4f9-4b66-852a-f9edd325bc3f','LABORATORY-SUPPLIES','SAMPLE ITEM',1);

/*Table structure for table `package_service_tbl` */

DROP TABLE IF EXISTS `package_service_tbl`;

CREATE TABLE `package_service_tbl` (
  `ID` varchar(50) default NULL,
  `package_name` varchar(50) default NULL,
  `service_type` varchar(50) default NULL,
  `gross` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `package_service_tbl` */

insert into `package_service_tbl` values 
('309f96b9-aa5d-4a47-93b9-5677158f8a97','Annual Physical Exam','CBC WITH PLT. COUNT','180'),
('78bf1ea4-35ed-40c2-9f90-88f3b0144ae6','Annual Physical Exam','PLATELET COUNT','90'),
('8e5b19fc-5c76-4d33-bb4d-801ec1e1057c','test-package','COMPLETE BLOOD COUNT','110'),
('b01f994e-8476-4976-9c32-376fb0f284c8','Annual Physical Exam','COMPLETE BLOOD COUNT','110'),
('782f07e7-8f3f-43b5-9d9f-e58c73068085','Annual Physical Exam','BLOOD + RH TYPING','140'),
('8b07006d-e02c-4df2-90a1-e20403f670aa','Annual Physical Exam','PHYSICAL EXAM W/CERTIFICATE','250'),
('a7a6f4aa-0328-407c-82ce-c9d890222f58','Driver/Yaya Package','COMPLETE BLOOD COUNT','110'),
('096ad95d-366b-4b65-913f-ddb878c063a3','Driver/Yaya Package','URINALYSIS','85'),
('53ad29da-42bd-4766-abd1-cee49f9c8135','Driver/Yaya Package','FECALYSIS','70'),
('7a93c48b-ad3e-4aaa-828b-5c23cb5f5983','Driver/Yaya Package','HBSAG (SCREENING ONLY)','160'),
('8278e7ac-54db-4935-bc06-d510f5091fdf','Driver/Yaya Package','CHEST PA','210'),
('8996c077-b1e4-44b0-a68e-fa56e936d968','Standard Chemistry','FBS','90'),
('33f80a14-39c2-4d35-b087-d69d8c1bae7b','Standard Chemistry','BUN','90'),
('7a9590e2-b373-4df6-9ad6-a225419dc45d','Standard Chemistry','CREATININE','90'),
('7ba8090e-0835-4d30-b2c1-e02a336194fb','Standard Chemistry','URIC ACID','100'),
('152531ff-7f9e-4606-ac8d-43364f532fb7','Standard Chemistry','LIPID PROFILE (CHOLE, TRIGLY & HDL)','370'),
('b58e5702-45bb-4402-9a34-db8455457b8e','Standard Chemistry','SGPT/ALT','130'),
('77c7dea2-261c-40df-a93b-1d4fc2d083e4','Standard Chemistry','SGOT/AST','130'),
('d39bfa5f-6bb0-4aa2-9f3a-2d65d07b78db','Routine Check-Up','COMPLETE BLOOD COUNT','110'),
('9b7d7757-fb97-424f-8a22-3a66c674484f','Routine Check-Up','FASTING BLOOD SUGAR (FBS)','90'),
('b335f7f3-7a4d-4501-b625-00c966228ddc','Routine Check-Up','BUN + CREATININE','170'),
('afcd4d68-8758-45a5-9771-7b902777eab1','Routine Check-Up','URIC ACID','100'),
('cd3d22cd-9a11-43cb-9aa0-39d9543cfd76','Routine Check-Up','LIPID PROFILE (CHOLE, TRIGLY & HDL)','370'),
('25ba68a5-77cf-40c4-adff-3f6849545970','Routine Check-Up','SGPT/ALT','130'),
('b1aa28a7-c401-4f43-90f2-0a139e5bec0f','Routine Check-Up','SGOT/AST','130'),
('5bf0dd80-edac-4265-8479-7e6bad375263','Routine Check-Up','ALKALINE PHOSPHATASE','150'),
('2d6aa164-50b5-4f54-b7f8-194955e54556','Routine Check-Up','COMPLETE URINALYSIS','100'),
('9c17e1b9-cfe1-417a-b02e-c2e501c7421a','Routine Check-up with Imaging','COMPLETE BLOOD COUNT','110'),
('633cd8cf-8949-4923-8817-3bbc940c8389','Routine Check-up with Imaging','FASTING BLOOD SUGAR (FBS)','90'),
('36a4eb37-d0e9-49af-8abf-a04dea463751','Routine Check-up with Imaging','BUN + CREATININE','170'),
('5c8ad37e-b5dc-4cf0-944a-9ef384a1911e','Routine Check-up with Imaging','LIPID PROFILE (CHOLE, TRIGLY & HDL)','370'),
('2783f74c-e100-4a8c-819c-aa510a173492','Routine Check-up with Imaging','URIC ACID','100'),
('6cb9e933-be0b-41f6-84b2-bc52040a4757','Routine Check-up with Imaging','SGPT/ALT','130'),
('3b37a4c3-21bc-4f64-85cf-0bc75a2b2b27','Routine Check-up with Imaging','SGOT/AST','130'),
('b17dc391-7332-40c8-ac19-14c20b0c50e8','Routine Check-up with Imaging','ALKALINE PHOSPHATASE','150'),
('d6867af3-b115-416d-b99e-43bdb4e98e26','Routine Check-up with Imaging','COMPLETE URINALYSIS','100'),
('ebe2527c-3f50-4513-805c-c5f6d9fd34e2','Routine Check-up with Imaging','CHEST PA','210'),
('24c788ea-ff0f-424a-b2fa-b18021a87b52','Routine Check-up with Imaging','12 LEAD ECG','300'),
('7809bd48-2cd8-465c-aadf-aca707d401b0','Basic Health Check-up','COMPLETE BLOOD COUNT','110'),
('0e274476-8e85-4a4a-964a-ba0ebdb06ad0','Basic Health Check-up','LIPID PROFILE (CHOLE, TRIGLY & HDL)','370'),
('f9fbdcc7-28b2-4d79-b147-c9fa81564248','Basic Health Check-up','BUN + CREATININE','170'),
('b7928dfb-843e-453b-a4ee-6a7bbb05830f','Basic Health Check-up','URIC ACID','100'),
('e419dbd1-f5b3-4b00-875a-553b83fa8017','Basic Health Check-up','SGPT/ALT','130'),
('b7f570de-0958-4cb9-8b66-c5c656887afc','Basic Health Check-up','SGOT/AST','130'),
('dda49093-feb3-49a4-a958-95c5a94a9028','Basic Health Check-up','ALKALINE PHOSPHATASE','150'),
('4450381f-6aa1-43f0-adad-c22cf86ae4af','Basic Health Check-up','FASTING BLOOD SUGAR (FBS)','90'),
('28891b72-1a3d-4e83-970f-c09dae7e287b','Basic Health Check-up','SODIUM (NA)','110'),
('6cd88c0a-eba7-4630-9a70-618dcf7207ad','Basic Health Check-up','POTASSIUM (K)','110'),
('526ad62c-3ddf-43c7-bbbf-c5603394b8b8','Basic Health Check-up','COMPLETE URINALYSIS','100'),
('644fccd8-ec6f-47d7-a4ac-0e5d9511297e','Basic Health Check-up with Imaging','COMPLETE BLOOD COUNT','110'),
('6793bf0a-2180-4cdf-986f-a9697fe317a4','Basic Health Check-up with Imaging','FBS','90'),
('7c2e827e-a911-4bc1-a460-967bca577200','Basic Health Check-up with Imaging','BUN + CREATININE','170'),
('906d79eb-47db-4047-aa95-c843e979b9a1','Basic Health Check-up with Imaging','LIPID PROFILE (CHOLE, TRIGLY & HDL)','370'),
('f5b98863-f8b4-468a-8804-fa1f17f13af8','Basic Health Check-up with Imaging','SODIUM (NA)','110'),
('66f20d77-f768-41fa-998f-c49f8467c183','Basic Health Check-up with Imaging','POTASSIUM (K)','110'),
('a155b38a-2b14-41c8-9e01-8dbae49e7c81','Basic Health Check-up with Imaging','SGPT/ALT','130'),
('9d41953e-bd95-48d1-9f19-17811dadb73b','Basic Health Check-up with Imaging','SGOT/AST','130'),
('a9db524d-09e1-4ab3-ae83-55117f7bce99','Basic Health Check-up with Imaging','ALKALINE PHOSPHATASE','150'),
('502f1269-ac85-4a8d-9d55-f0db641806ac','Basic Health Check-up with Imaging','COMPLETE URINALYSIS','100'),
('bd231952-6bb3-4030-a799-49834a8b2a29','Basic Health Check-up with Imaging','CHEST PA','210'),
('f9fd38cb-518d-4987-a22d-6ee319138e55','Basic Health Check-up with Imaging','12 LEAD ECG','300'),
('ee6631ba-f805-427c-9309-0760603bc03b','Basic Health Check-up with Imaging','WHOLE ABDOMEN','1200'),
('7918f2d4-99bf-4370-8286-21406182c156','General Health Program','COMPLETE BLOOD COUNT','110'),
('0999b80a-fd25-4132-b489-1bd9bf280dcc','General Health Program','FBS','90'),
('f1562b3f-27ab-4706-bb3b-adb3975559e2','General Health Program','BUN + CREATININE','170'),
('1b10af41-3582-44bd-90a3-29a08a0a412f','General Health Program','ESR','80'),
('09614064-e87e-4165-92a8-77f9f76aba2c','General Health Program','HBA1C','420'),
('8388662f-6e61-4be8-aea6-00356acdf0b6','General Health Program','URIC ACID','100'),
('c19d512b-39e2-404b-b634-bd8c2c79818d','General Health Program','SGPT/ALT','130'),
('1a7b700c-dc4a-4204-99c1-2bd5db591424','General Health Program','SGOT/AST','130'),
('547c06c1-bc70-4b61-bbf3-a3daceb626eb','General Health Program','ALKALINE PHOSPHATASE','150'),
('d1a532c9-6807-44f2-8d11-1ee8b066a9d3','General Health Program','TP, A/G RATIO','175'),
('68f28368-4e22-407f-a6c5-26f9bea4ab69','General Health Program','BILIRUBIN (TB, ID, DB)','130'),
('a65d685f-237f-417a-88f5-ce543ce1061d','General Health Program','SODIUM (NA)','110'),
('87d77709-1adb-4882-b924-8a48343f768d','General Health Program','POTASSIUM (K)','110'),
('ad937cd6-51a3-4e85-940b-f0f0ec28328c','General Health Program','CHLORIDE (CL)','110'),
('ffb6ff02-ff62-4d3a-ba04-fcd1ec2fdeb6','General Health Program','CALCIUM (CA)','120'),
('f9b6e195-1b10-4170-b41b-3d96d6500017','General Health Program','CEA (COLORECTAL CA)','675'),
('89ca2b57-221e-4219-9cdb-8afbb54499ac','General Health Program','COMPLETE URINALYSIS','100'),
('256a1075-a5d6-4f2f-bf5a-40610f6723b5','General Health Program','FECALYSIS','70'),
('72b2ecae-f3a9-4b58-b809-8330454908cf','General Health Program','OCCULT BLOOD','110'),
('e4e20d40-8abf-411f-a6b6-3f63d48ba291','General Health Care Program with Imaging','COMPLETE BLOOD COUNT','110'),
('95570efb-c2c7-4565-b5d8-f6f94a9cb42f','General Health Care Program with Imaging','ESR','80'),
('d0d2693a-8fa6-4b85-addf-59e689c988db','General Health Care Program with Imaging','FBS','90'),
('363751f1-49b7-4b55-8635-d340f0e254a9','General Health Care Program with Imaging','BUN + CREATININE','170'),
('23f86a0a-efd9-46fd-9be6-2d87ff9807dd','General Health Care Program with Imaging','URIC ACID','100'),
('579ab3c5-44af-4ae3-a686-306c1a6e23c7','General Health Care Program with Imaging','LIPID PROFILE (CHOLE, TRIGLY & HDL)','370'),
('39139712-2d4d-49b7-9e34-00529c9e039d','General Health Care Program with Imaging','TOTAL BILIRUBIN','130'),
('f66bb5b0-c876-4b07-bbc6-eec2709f0dd2','General Health Care Program with Imaging','TP, A/G RATIO','175'),
('3bb994b8-e242-42de-9757-e0c006cbd3fd','General Health Care Program with Imaging','HBA1C','420'),
('8b69e348-7404-4e6e-9f4f-4b97ed8a7692','General Health Care Program with Imaging','SODIUM (NA)','110'),
('2b96e812-bb9b-4eab-a19c-a571a32becd6','General Health Care Program with Imaging','POTASSIUM (K)','110'),
('ed507617-2d37-45f5-af54-4141014e31c8','General Health Care Program with Imaging','CHLORIDE (CL)','110'),
('bda0cfc8-5033-4226-b25a-f4635782ffe1','General Health Care Program with Imaging','CALCIUM (CA)','120'),
('8aef974a-5255-4270-b1a7-290f804be011','General Health Care Program with Imaging','SGPT/ALT','130'),
('550b0be2-e122-4fbf-a0fe-a38ad32a23e8','General Health Care Program with Imaging','SGOT/AST','130'),
('f89b8aca-08a0-430e-8044-bc80620966e9','General Health Care Program with Imaging','ALKALINE PHOSPHATASE','150'),
('b6358b1c-16c4-4207-969a-42c66a0f432d','General Health Care Program with Imaging','CEA (COLORECTAL CA)','675'),
('0d7f3f3e-5c01-4afb-b161-1af79374e58b','General Health Care Program with Imaging','COMPLETE URINALYSIS','100'),
('6ddc14f4-a660-4ac6-a5bd-92efdf5ca2a8','General Health Care Program with Imaging','FECALYSIS','70'),
('ae0db2ae-1d1b-45a1-9dc4-b56bba105fbf','General Health Care Program with Imaging','OCCULT BLOOD','110'),
('fcdc6530-518f-4a1c-aa33-e06ab311f000','General Health Care Program with Imaging','WHOLE ABDOMEN','1200'),
('5fe4c517-384d-4c69-b8f7-59d430cc9e40','General Health Care Program with Imaging','CHEST PA','210'),
('87d12462-2c89-4ada-9ad8-addda0ac8901','General Health Care Program with Imaging','12 LEAD ECG','300');

/*Table structure for table `package_tbl` */

DROP TABLE IF EXISTS `package_tbl`;

CREATE TABLE `package_tbl` (
  `pack_id` varchar(50) default NULL,
  `pack_name` varchar(50) default NULL,
  `price` double(11,5) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `package_tbl` */

insert into `package_tbl` values 
('3875bdc3-45fe-47dc-8e6b-aa1ddb56821d','Annual Physical Exam',485.00000),
('7ea1ce5e-9c73-4655-8258-b8c8e73eaebd','Standard Chemistry',780.00000),
('0eadcce2-7b32-43fb-a4f9-1e269277b1b5','Routine Check-Up',1000.00000),
('7eea51f4-9626-41f8-9bfd-250b033b05ac','Basic Health Check-up',1150.00000),
('1911fd6f-ccca-4d1a-9d77-4320b6348ae1','General Health Program',2800.00000),
('aa22ca48-4a1e-4787-8a62-0f30ca136159','Prime Health Check-up (Female)',NULL),
('87df9307-8a71-4edc-b82c-9061152bd17f','Prime Health Check-up (Male)',NULL),
('bffddd8f-19ee-4396-bae5-2cdc3e4dda26','Cardiac Care Plan',NULL),
('2b909fed-924a-492a-9ee6-5bde5f57eb58','Diabetic Care Plan',NULL),
('396f4ab0-2830-4d95-ba9c-43d6cbd05458','Geriatric Health Plan',NULL),
('7d4b111e-ff64-4a4e-a0ab-b7ea26a1c8ae','test-package',150.00000),
('1a78f167-2b56-4317-a692-4450893ebb6e','Driver/Yaya Package',385.00000),
('6dae1b05-4945-4943-9aeb-9634610826fb','Routine Check-up with Imaging',1500.00000),
('b50f194f-a6fc-41e0-b2b3-485b882bec30','Basic Health Check-up',1150.00000),
('cc5598c1-f96f-4db6-8ffa-1ac480397dbc','Basic Health Check-up with Imaging',2800.00000),
('2479bbd3-b3e3-4b2a-b15b-7f286dc0ff44','General Health Care Program with Imaging',4400.00000);

/*Table structure for table `patient_doctor_tbl` */

DROP TABLE IF EXISTS `patient_doctor_tbl`;

CREATE TABLE `patient_doctor_tbl` (
  `p_d_id` varchar(50) default NULL,
  `doctor_name` varchar(50) default NULL,
  `patient_id` varchar(50) default NULL,
  `cons_fee` double(11,2) default NULL,
  `t_r` varchar(50) default NULL,
  `stat` int(1) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `patient_doctor_tbl` */

/*Table structure for table `patient_laboratory_tbl` */

DROP TABLE IF EXISTS `patient_laboratory_tbl`;

CREATE TABLE `patient_laboratory_tbl` (
  `patient_id` varchar(50) default NULL,
  `l_type` varchar(50) default NULL,
  `bp` varchar(50) default NULL,
  `diagnosis` varchar(50) default NULL,
  `cc` varchar(50) default NULL,
  `hip` varchar(50) default NULL,
  `pe` varchar(50) default NULL,
  `lmp` varchar(50) default NULL,
  `ht` varchar(50) default NULL,
  `wt` varchar(50) default NULL,
  `stat` int(11) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `patient_laboratory_tbl` */

insert into `patient_laboratory_tbl` values 
('20140004','X-RAY','','','test','test','test','','','',0),
('','','','','','','','','','',0);

/*Table structure for table `patient_service_tbl` */

DROP TABLE IF EXISTS `patient_service_tbl`;

CREATE TABLE `patient_service_tbl` (
  `record_id` varchar(50) default NULL,
  `patient_id` varchar(50) default NULL,
  `service_type` varchar(50) default NULL,
  `gross` varchar(50) default NULL,
  `status` varchar(50) default NULL,
  `tdate` date default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `patient_service_tbl` */

insert into `patient_service_tbl` values 
('1fee7740-06d2-444f-b64f-478fa804646b','20140003','COMPLETE BLOOD COUNT','110','paid','2014-12-08'),
('1fee7740-06d2-444f-b64f-478fa804646b','20140003','PLATELET COUNT','90','paid','2014-12-08'),
('e44acc06-7f10-48d5-9a4e-ab9d834d288e','20140004','MALARIAL SMEAR','105','unpaid','2014-12-08'),
('e44acc06-7f10-48d5-9a4e-ab9d834d288e','20140004','PERIPHERAL SMEAR','105','unpaid','2014-12-08');

/*Table structure for table `patient_service_tbl2` */

DROP TABLE IF EXISTS `patient_service_tbl2`;

CREATE TABLE `patient_service_tbl2` (
  `record_id2` varchar(50) NOT NULL,
  `record_id` varchar(50) default NULL,
  `Total_Gross` double(11,2) default NULL,
  `payment` double(11,2) default NULL,
  `changes` double(11,2) default NULL,
  `status` varchar(50) default NULL,
  PRIMARY KEY  (`record_id2`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `patient_service_tbl2` */

insert into `patient_service_tbl2` values 
('13f71aa9-8d91-4350-9b82-7b825572ec5c','e44acc06-7f10-48d5-9a4e-ab9d834d288e',210.00,210.00,0.00,'normal'),
('abdeb47d-39a8-4ba3-af03-0708f6375c01','1fee7740-06d2-444f-b64f-478fa804646b',100.00,150.00,50.00,'Discounted');

/*Table structure for table `patient_tbl` */

DROP TABLE IF EXISTS `patient_tbl`;

CREATE TABLE `patient_tbl` (
  `patient_number` varchar(50) default NULL,
  `lname` varchar(30) default NULL,
  `fname` varchar(30) default NULL,
  `mname` varchar(30) default NULL,
  `bday` date default NULL,
  `age` int(3) default NULL,
  `gender` varchar(10) default NULL,
  `address` text,
  `tel` varchar(11) default NULL,
  `mob` varchar(11) default NULL,
  `p_name` varchar(50) default NULL,
  `email` text,
  `c_fee` double(11,5) default NULL,
  `t_r` text,
  `med_information` varchar(30) default NULL,
  `tdate` date default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `patient_tbl` */

insert into `patient_tbl` values 
('20140003','Gomez','Ester','Malgapo','1940-02-22',74,'FEMALE','#24 Chronicle St., Bgy. West Triangle Quezon City','','','Lyndon Samson','',0.00000,'Package 1','','2014-02-08'),
('20140004','Gumop-as','Wilver','De-Asis','1991-01-18',23,'MALE','#23 ipil Interior Feria Road Diliman Quezon City','4348439','09304515983','','',0.00000,'','','2014-02-18'),
('20140005','MALIMBAN','SHERRY','N/A','1970-10-16',44,'FEMALE','','','','','',0.00000,'','','2014-03-12'),
('20141183','Carcer','Ryan','Dela Cruz','1994-10-26',20,'MALE','55 West Riverside St., S.F.D.M. Bgy. Del Monte Quezon City','','09102423172','','',0.00000,'Drug Testing','','2014-03-12'),
('20141184','DE LEON','Abelardo','N/A','1993-05-10',21,'MALE','Corocan St., Masambong Quezon City','','','','',0.00000,'Chest X-ray','','2014-03-13'),
('20141185','UBALDO','Priscila','B','1927-07-08',87,'FEMALE','32 Baler St., Bgy. Paltok SFDM Quezon City','4128263','','','',0.00000,'','','2014-03-13'),
('20141186','DIONISIO','Nicomedes Jr.','N/A','1948-03-13',66,'MALE','21 Inaman St., Masambong Quezon City','3653074','','','',0.00000,'','','2014-03-13'),
('20141187','DIONISIO','Myrna','R','1953-04-13',61,'FEMALE','21 Inaman St., Masambong Quezon City','3653074','','','',0.00000,'','','2014-03-13'),
('20141188','CUISON','Rebecca ','O.L.','1973-09-09',41,'FEMALE','18 Guerrero St., SFDM Quezon City','5693857','09292163298','','reblacson@yahoo.com',0.00000,'','','2014-03-13'),
('20141189','CAMEROS','Daniel','C','1931-04-10',83,'MALE','1-C Manalo St., SFDM Quezon City','','','','',0.00000,'','','2014-03-13'),
('20141190','GUEVARRA','John Homer','Linda','2010-09-09',4,'MALE','19 Caragay St., SFDM Quezon City','','09266586164','','',0.00000,'','','2014-03-13'),
('20141191','SINSAY','Michael John','M. ','1988-03-21',26,'MALE','9 F. Bautista St., SFDM Quezon City','','09493638728','','',0.00000,'','','2014-03-13'),
('20141192','Fune','Iluminada','Rosales','1944-05-06',70,'FEMALE','1 Umali St., SFDM Quezon City','','','','',0.00000,'','','2014-03-13'),
('20141193','Lacanilao','Lolita','S.','1942-07-07',72,'FEMALE','15 Marinduques St. SFDM QC','4126282','','Karen June Dumlao','',0.00000,'','','2014-03-13'),
('20141194','PERALTA','Peter John','N/A','1985-01-29',29,'MALE','60 Basa SFDM QC','','09274980129','Lyndon Samson','',400.00000,'','','2014-03-13'),
('20141195','Vergara','Shernelle Lourence','A.','1989-01-02',25,'FEMALE','Balintawak QC','','09263680897','','',0.00000,'','','2014-03-13'),
('20141196','Yulay','Froilan','Suico','1982-11-14',32,'MALE','Frisco Del Monte QC','','09179890113','','',0.00000,'','','2014-03-13'),
('20141198','Mamansag','Monica','L.','1984-10-10',30,'FEMALE','5G. Del Pilar St. SFDM QC','','N/A','','',0.00000,'','','2014-03-13'),
('20141199','Coquilla','Kyle Brylle','S.','2009-03-21',5,'FEMALE','86A San Pedro Bautista St SFDM QC','3731728','09173549655','','',0.00000,'','','2014-03-13'),
('20141200','Bringas ','Fe','M.','1936-08-01',78,'FEMALE','939 Del Monte Ave. SFDM QC','7829776','','','',0.00000,'','','2014-03-13'),
('20141201','Tanuga','Novemae','S.','1994-11-24',20,'MALE','5 Kaingin Road Don MAnuel St SFDM QC','','09302319053','','',0.00000,'','','2014-03-13'),
('20141203','Panganiban','Rudolfo','C.','1989-08-08',25,'MALE','164 Fernandez St. SFDM QC','','09063191539','','',0.00000,'','','2014-03-13'),
('20141204','Valdez','Lucita','F.','1941-08-10',73,'FEMALE','Talipapa Novaliches Caloocan City','9837822','','','',0.00000,'','','2014-03-13'),
('20141205','Manabe','Shiela Ann','N/A','1989-06-06',25,'FEMALE','2584 Sct. Fernandez Tomas Morato QC','','09223860042','','',0.00000,'','','2014-03-13'),
('20141206','Somine','Diane','M.','1994-11-12',20,'FEMALE','108 Roosevelt QC','','09335821920','','',0.00000,'','','2014-03-13'),
('20141207','Rusiana ','Dejie','M.','1992-08-28',22,'FEMALE','39 Ilocos St Bago Bantay QC','','09359494184','','',0.00000,'','','2014-03-13'),
('20141208','uy','Aida','J','1957-03-24',57,'FEMALE','12-C Bakil St Masambong QC','3528767','','Dra. Chua','',0.00000,'','','2014-03-13'),
('20141209','Bernal','Lyn Angelie','S.','1997-06-06',17,'FEMALE','SFDM','','NA','','',0.00000,'','','2014-03-13'),
('20141210','Ong','Victoria','N/A','1926-04-14',88,'FEMALE','71 Kundiman St. SFDM QC','7886410','','','',0.00000,'','','2014-03-14'),
('20141211','Laurente','Lenelyn','Balinuyos','1979-12-21',35,'FEMALE','Casingsingan Sur Cagayan','N/A','','','',0.00000,'','','2014-03-14'),
('20141212','De Castro','Moira Izabel','R.','2008-10-29',6,'FEMALE','33B Sto. Nino St SFDM QC','3756564','09282181098','','',0.00000,'','','2014-03-14'),
('20141213','Labrador','Michelle','M.','1990-10-10',24,'FEMALE','13 Villa Arca Ave. Baesa QC','','09253015416','','',0.00000,'','','2014-03-14'),
('20141214','Reyes','Norman','M.','1949-08-28',65,'MALE','Proj. 8 QC','','09054156993','','',0.00000,'','','2014-03-14'),
('20141215','De Guzman','Ariane','A.','1989-06-19',25,'FEMALE','46 East Riverside St. SFDM QC','','09158001294','','',0.00000,'','','2014-03-14'),
('20141216','Gaudencio','Vicente','Yulo','1942-01-20',72,'MALE','Soteo Mendez QC','','09203000111','','',0.00000,'','','2014-03-14'),
('20141217','Arce','Michael','N/A','1977-04-09',37,'MALE','67 West Riverside SFDM QC','3876043','09331651410','','',0.00000,'','','2014-03-14'),
('20141218','Adlao','Ma. Sandra','F.','1989-11-29',25,'FEMALE','36 Umbel Street Roxas QC','','09394430343','','',0.00000,'','','2014-03-14'),
('20141219','Llanda','Clarita','M.','1966-08-14',48,'','Mexico Pampanga','','09215103220','','',0.00000,'','','2014-03-14'),
('20141220','Maranan','Adelino Alden','T.','1970-12-16',44,'MALE','79 Old Samson Road Balintawak QC','4106280','09064640997','','',0.00000,'','','2014-03-14'),
('20141221','Ramilla','Nina Relita','Espiritu','1981-08-16',33,'','7 Aquino St QC','','09266778666','','',0.00000,'','','2014-03-14'),
('20141222','Aday ','Dialyn','A','1977-12-03',37,'FEMALE','4 Samuel St. SFDM QC','','09493255837','','',0.00000,'','','2014-03-14'),
('20141223','PATRICIO','TEODORO ','CRUZ','1953-11-09',61,'MALE','5 NAVARETE ST SFDM QC','','09233136449','','',0.00000,'','','2014-03-15'),
('20141224','CALZADO','CATHERINE','A.','1978-01-05',36,'FEMALE','30 NATIVIDAD ST. PALTOK SFDM QC','','09082649063','','',0.00000,'','','2014-03-15'),
('20141225','PELAEZ','DONNA MAE','C.','1979-10-22',35,'FEMALE','61B OSMENA ST. SFDM QC','','09215667367','','',0.00000,'','','2014-03-15'),
('20141226','MAYUGA','MARIA KAREN PATRICIA','S.L.','1983-05-15',31,'FEMALE','40 SAN ANTONIO PAT SENADOR QC','4118882','09053400001','','',0.00000,'','','2014-03-15'),
('20141227','VILLANOZA','SAVANNAH','N/A','2013-10-27',1,'FEMALE','ROOSEVELT AVE STO.NINO QC','4155206','09223943420','','',0.00000,'','','2014-03-15'),
('20141228','URBANO','ANDREA','D.','1995-06-08',19,'FEMALE','163 ROOSEVELT AVE. QC','3725222','09275955454','','',0.00000,'','','2014-03-15'),
('20141229','CHENG','THERESE ANNE','V.','2002-11-21',12,'FEMALE','SFDM QC','','09228659918','','',0.00000,'','','2014-03-15'),
('20141230','REVECHO','FRANZMAE','R.','1990-02-03',24,'FEMALE','ARANETA AVE. QC','7122631','09095735898','','',0.00000,'','','2014-03-18'),
('20141231','BALICANTA','DOMINIC MARTIN','M.','2005-03-19',9,'MALE','5 ROAD 12 EXT PROJ.8 QC','','09224343992','','',0.00000,'','','2014-03-18'),
('20141232','MADRIDEO','MABEL','L.','1988-12-04',26,'FEMALE','100 TALAYAN VILLAGE QC','','09154134530','','',0.00000,'','','2014-03-18'),
('20141233','BAEL','ANGELA','B.','1990-10-10',24,'FEMALE','CALAMBA, LAGUNA','','09269508191','','',0.00000,'','','2014-03-18'),
('20141234','VELASQUEZ','MARIFE','F','1972-11-04',42,'FEMALE','RM 304 LYRA BLDG QUEZON AVENUE QC','4124042','09205366709','','',0.00000,'','','2014-03-18'),
('20141235','RODA','JOY','M.','1984-09-28',30,'FEMALE','392 7TH AVE BONIFACIO QC','3655637','','','',0.00000,'','','2014-03-18'),
('20141236','NERPIO','LORETO','OREAS','1960-08-23',54,'MALE','PANLO ST GREEN FIELDS NOVALICHES QC','9393543','09266994701','','',0.00000,'','','2014-03-18'),
('20141237','ARIATE','KEVIN','E.','1990-06-27',24,'MALE','20-4 WEST RIVER SIDE SFDM QC','','09077189500','','',0.00000,'','','2014-03-18'),
('20141238','CRISOSTOMO','OFELIA','M.','1978-06-25',36,'FEMALE','3E SAN JOAQUIN SFDM','4105379','09322171623','','',0.00000,'','','2014-03-18'),
('20141239','OLIVAR','ANTONINA','S.','1947-11-25',67,'FEMALE','287 MABITOAN ST MASAMBONG QC','','09498181044','','',0.00000,'','','2014-03-18'),
('20141240','GUEVARRA','JENNIFER','D.','1977-11-17',37,'FEMALE','6 UMALI ST FRISCO QC','','09333583503','','',0.00000,'','','2014-03-18'),
('20141241','DIZON','MA. ELOISA','S.','1933-02-13',81,'FEMALE','99B GOMEZ ST SFDM QC','9258862','09326315229','','',0.00000,'','','2014-03-18'),
('20141242','DE VERA','DOMINADOR','S.','1941-10-09',73,'MALE','63 MORATO ST BRGY PARAISO QC','4410212','','','',0.00000,'','','2014-03-18'),
('20141243','DE CASTRO','JUANITO','JUSON','1934-03-05',80,'MALE','31A MABITUAN ST MASAMBONG QC','','09084985204','','',0.00000,'','','2014-03-18'),
('20141244','TUBERA','EMILY','DE CASTRO','1998-02-16',16,'FEMALE','31A MABITOAN ST. MASAMBONG QC','','09084985204','','',0.00000,'','','2014-03-18'),
('20141245','GARCES','LALAINE','LIM','2013-03-18',1,'FEMALE','QC','','','','',0.00000,'','','2014-03-18'),
('20141246','GARCES','NELIZA','LIM','1986-03-18',28,'FEMALE','QC','','','','',0.00000,'','','2014-03-18'),
('20141247','TABON','MONICA','O.','1939-05-14',75,'FEMALE','71 WEST RIVERSIDE SFDM QC','','','','',0.00000,'','','2014-03-18'),
('20141248','LIBRES','JOANA MARIE','PANTUAN','1991-08-02',23,'FEMALE','18A GITNA ST BRGY APOLONIO SAMSON QC','','09073818041','','',0.00000,'','','2014-03-18'),
('20141249','ROYO','CYNTHIA','PAMAT','1991-02-12',23,'FEMALE','48B STO CRISTO QC','','','','',0.00000,'','','2014-03-18'),
('20141250','OCAMPO','ANGEL SOPHIA','G.','2008-12-30',6,'FEMALE','27B GASAN ST MASAMBONG QC','4131452','09178093856','','',0.00000,'','','2014-03-18'),
('20141251','MAGSALAY','GILBERT','O.','1979-12-12',35,'MALE','27 VALENCIA ST SFDM QC','','09302228273','','',0.00000,'','','2014-03-18'),
('20141252','BARREDO','VICENTE','L.','1930-07-19',84,'MALE','20A PARAISO ST SFDM QC','4140438','','','',0.00000,'','','2014-03-18'),
('20141253','MARCOS','MA. CRISELLE','O.','1982-08-18',32,'FEMALE','33 NAVARETTES ST FRISCO QC','','09192499567','','',0.00000,'','','2014-03-18'),
('20141254','SALVANTE','RYONA DHAE','D.','2013-05-27',1,'FEMALE','90 KAINGIN RD. BATANES QC','','09081399059','','',0.00000,'','','2014-03-18'),
('20141255','SUMILAY','MA. JESSICA','GALLARDO','2004-07-23',10,'FEMALE','8A WEST RIVERSIDE SFDM QC','','09359975709','','',0.00000,'','','2014-03-18'),
('20141256','DIZON','THOMAS','T.','1956-03-07',58,'MALE','8 BERNARDO ST SEDA QC','','09262572822','','',0.00000,'','','2014-03-18'),
('20141257','BATINDAAN','RACHEL','PESANTE','1981-06-06',33,'FEMALE','TALAYAN QC','','','','',0.00000,'','','2014-03-18'),
('20141258','CAGUILLA','EDNA','P.','1985-10-03',29,'FEMALE','ROOSEVELT PETRON QC','4142487','09176253154','','',0.00000,'','','2014-03-18'),
('20141259','DIZON','LEONIDA','M.','1960-03-18',54,'FEMALE','QC','','','','',0.00000,'','','2014-03-18'),
('20141260','TARONTOWAN','MOHAMMAD','N/A','2014-01-18',0,'MALE','7 MAPALAD ST SFDM QC','','09197384763','','',0.00000,'','','2014-03-18'),
('20141261','PANGINDIAN','CYRUZ JAHN','L.','2006-08-06',8,'MALE','62 BAHAWAN ST. MASAMBONG QC','4116436','','','',0.00000,'','','2014-03-18'),
('20141262','MORALES','JUDYLYN','D.','1984-06-10',30,'FEMALE','2N WESTRIVERSIDE ST SFDM QC','','09172089608','','',0.00000,'','','2014-03-18'),
('20141263','TANORA','JAMES','T.','1967-08-23',47,'MALE','PASIG CITY','','09275549950','','',0.00000,'','','2014-03-18'),
('20141264','CAOILI','JAYNEE','N.','1983-02-24',31,'FEMALE','2 HERMOSA ST SFDM QC','','09468888635','','',0.00000,'','','2014-03-18'),
('20141265','AWITAN','GABRIELLE ERWIN','C.','1979-06-30',35,'MALE','EAST SIDE LOS BANOS LAGUNA','5366687','09152489381','','',0.00000,'','','2014-03-18'),
('20141266','LACOYANGA','KRYZZAE','G.','1993-02-21',21,'FEMALE','62 OSMENA ST SFDM QC','','09353710697','','',0.00000,'','','2014-03-18'),
('20141267','GASPAN','MARIETA','A.','1940-12-19',74,'FEMALE','822 SISA ST SAMP MLA','','','','',0.00000,'','','2014-03-18'),
('20141268','GASPAN','GEMMA ','A.','1965-02-10',49,'FEMALE','822 SISA ST SAMP MLA','','','','',0.00000,'','','2014-03-18'),
('20141269','NICOLAS','JUANITA','A.','1943-08-21',71,'FEMALE','3C SAN JOAQUIN ST SFDM QC','','','','',0.00000,'','','2014-03-18'),
('20141270','ANARETE','DIANA ','D.','2014-09-08',0,'FEMALE','2 PANAY AVE NOVALICHES QC','','','','',0.00000,'','','2014-03-18'),
('20141271','MONDEJAR','JONILISA','B.','1979-12-29',35,'FEMALE','25F BASA ST SFDM QC','3455315','09172436332','','',0.00000,'','','2014-03-18'),
('20141272','INFANTE','PACIANO','B.','1937-12-07',77,'MALE','8 SAN PEDRO BAUTISTA ST FRISCO QC','','','','',0.00000,'','','2014-03-18'),
('20141273','DELOS REYES','JAYJAY','V.','1981-08-08',33,'MALE','51 BANAHAW MASAMBONG SFDM QC','','','','',0.00000,'','','2014-03-18'),
('20141274','SANTIAGO','MARIE CATHELEEN','P.','1976-03-09',38,'FEMALE','L10 B12 ST. JOHN ST SACRED HEART VILLAGE CALOOCAN CITY','','','','',0.00000,'','','2014-03-18'),
('20141275','DE GUIA','NANETTE','L.','1995-04-27',19,'FEMALE','34-8 GEN D. JESUS QUEZON AVE. QC','','09284658234','','',0.00000,'','','2014-03-18'),
('20141276','GUILAS','MARIA','C.','1954-11-02',60,'FEMALE','SCT BORROMEO','','09194615565','','',0.00000,'','','2014-03-18'),
('20141278','CRISOSTOMO','LORENZA','M.','1948-08-09',66,'FEMALE','SFDM QC','4105379','09322171623','','',0.00000,'','','2014-03-19'),
('20141279','CABRAL','MARIA CECILIA','G','1972-08-02',42,'FEMALE','43 DEXTER ST CONGRESSIONAL VILLAGE PROJ.8 QC','4173393','09278619277','','',0.00000,'','','2014-03-19'),
('20141280','LUSTICO','ROSELYN','V.','1987-03-19',27,'FEMALE','QC','','','','',0.00000,'','','2014-03-19'),
('20141281','TOPACIO','DONNA THEA','M.','1996-10-26',18,'FEMALE','4 BAKIL ST. MASAMBONG QC','3652915','09057790262','','',0.00000,'','','2014-03-19'),
('20141282','LANDICHO','JOY','B.','1984-02-05',30,'FEMALE','4 PABILARE SFDM QC','','09082311652','','',0.00000,'','','2014-03-19'),
('20141283','MACADANGDANG','TYRA CASHMERE','ARCE','2012-12-13',2,'FEMALE','341 ANAKBAYAN ST. BRGY PALTOK QC','','09093345807','','',0.00000,'','','2014-03-19'),
('20141284','BAYTION','REYNALDO','JOSE','1959-12-24',55,'MALE','103 WEST RIVERSIDE SFDM QC','4413223','','','',0.00000,'','','2014-03-19'),
('20141285','SANTIAGO','APOLINARIO','L.','1944-07-23',70,'MALE','74 CAPAOS ST. MASAMBONG QC','','','','',0.00000,'','','2014-03-19'),
('20141286','AQUINO','DOLORES','P.','1926-03-26',88,'FEMALE','18 FLORES DE MAYO QC','','09226919738','','',0.00000,'','','2014-03-19'),
('20141287','RAZON','ANALIZA','CAPILE','1975-01-22',39,'FEMALE','1138 LA UNION ST SFDM QC','','09127934332','','',0.00000,'','','2014-03-19'),
('20141288','DELUSA ','GREG','I.','1983-03-12',31,'MALE','','','09334048271','','',0.00000,'','','2014-03-19'),
('20141289','VINZON','JENILYN','PORTIZ','1961-05-12',53,'FEMALE','4881 GUNDAL CANAL OLD STA. MESA QC','7162132','','','',0.00000,'','','2014-03-19'),
('20141290','HIZOLA','JOSEFINA','M.','1940-08-27',74,'FEMALE','15 MARIDUQUES ST SFDM QC','','09283556098','','',0.00000,'','','2014-03-19'),
('20141291','ESTRELLA','RIA JOY','D.','1996-12-18',18,'FEMALE','16C GABO ST MASAMBONG QC','','09065716538','','',0.00000,'','','2014-03-19'),
('20141292','CRISOSTOMO','ANGELITO','A.','1946-06-09',68,'MALE','3E SAN JOAQUIN ST SFDM QC','4105379','','','',0.00000,'','','2014-03-19'),
('20141293','CONFESOR','ROSELYN','D.','1989-10-08',25,'FEMALE','30 D BF ROAD HOLY SPIRIT','','09485334811','','',0.00000,'','','2014-03-19'),
('20141294','PUNAY','EVELYN','A.','1987-06-27',27,'FEMALE','SITIO P[ETERSON BARAS RIZAL','','09206089255','','',0.00000,'','','2014-03-19'),
('20141295','ANDAGAN','CHERRY JANE','TABANO','1931-10-11',83,'FEMALE','MORNING BREEZE CALOOCAN CITY','','09168789861','','',0.00000,'','','2014-03-19'),
('20141296','SAYAS','ERNESTO','C.','1953-12-15',61,'FEMALE','93L TOLENTINO ST FRISCO DEL MONTE','3324390','','','',0.00000,'','','2014-03-19'),
('20141297','SERDONCILLO ','JUSTINE JOHN','A.','1999-12-26',15,'MALE','PHIL SCIENCE HS','9263101','09078986646','','',0.00000,'','','2014-03-19'),
('20141298','CORONADO','JUAN CARLOS','F.','1999-11-09',15,'FEMALE','PHIL SCIENCE HS','9263101','09078986646','','',0.00000,'','','2014-03-19'),
('20141299','ESTINIDO','LENARD','A.','1999-08-04',15,'FEMALE','PHIL SCIENCE HS','9263101','09192692299','','',0.00000,'','','2014-03-19'),
('20141300','PILLOS','MYRA','CONTILLO','1984-08-02',30,'FEMALE','CAGAYAN','','09064985652','','',0.00000,'','','2014-03-19'),
('20141301','DERECHO','MYRA','GUZMAN','1988-04-29',26,'FEMALE','CAGAYAN','','09356179674','','',0.00000,'','','2014-03-19'),
('20141302','DUMOL','CARLA LUZ','G.','1992-07-06',22,'FEMALE','34C ANAKBAYAN ST PALTOK SFDM QC','','09425672732','','',0.00000,'','','2014-03-19'),
('20141303','ABOG','JOHANN','A.','1997-06-18',17,'FEMALE','179 DENMARK ST. TANDANG SORA QC','4825535','09163514480','','',0.00000,'','','2014-03-19'),
('1001','Gumop-as','William','De-Asis','2010-03-19',4,'MALE','Address','4348439','09304515983','','WilverGumopas@yahoo.com',0.00000,'','','2014-03-19'),
('20141305','Valero','Zafrina','R.','1980-01-26',34,'FEMALE','','','','','',0.00000,'','','2014-03-19'),
('20141306','NOLLA ','REYNALYN','E.','1993-08-27',21,'FEMALE','','','09125956806','','',0.00000,'','','2014-03-20'),
('20141307','PASION ','RICA RHOSE','B.','1983-10-10',31,'FEMALE','','','09123291917','','',0.00000,'','','2014-03-20'),
('20140001','micke','mikce','m','1986-01-04',28,'MALE','mymymymy','','','','',0.00000,'','','2014-03-22'),
('20140002','Gomez','Romeo','Mateo','1939-09-27',75,'MALE','#24 Chronicle St., Bgy. West Triangle Quezon City','','','Samson, Lyndon','',400.00000,'FBS, BUN, Creatinine, Blood Uric Acid, Cholesterol, Triglyceride, Lipoprotein Profile, SGPT, SGOT','','2014-03-25'),
('20141827','Cabutaje','Sinamar','G.','1971-11-21',43,'FEMALE','Navarette West SFDM, Quezon City','','','','',0.00000,'','','2014-04-26'),
('20141849','Madlangsakay','Marylyn','C.','1971-06-03',43,'FEMALE','15 G Anakbayan St SFDM','3769765','09993784257','Dr. Casiguran','',280.00000,'Consultation','','2014-04-28'),
('20141990','Madlangsakay','Marylyn','C.','1971-06-03',43,'FEMALE','15 G Anakbayan St SFDM','3769765','09993784257','Dr. Casiguran','',280.00000,'Consultation','','2014-04-28'),
('20141851','NISPEROS','RUBY JEAN','C.','1991-05-12',23,'FEMALE','10 REAL ESTATE ST. GSIS VILLAGE, BRGY. SANGANDAAN, QC.','','09158621506','DRA. FELIZARDO','',350.00000,'CONSULTATION','','2014-04-28'),
('20141880','Galvez','Richard','Z','1979-04-23',35,'MALE','113 Palayan, Bgy. Culiat Q.C.','','09128011594','','',0.00000,'Basic 5','','2014-04-30'),
('20141879','Pagsolingan','Zeth Jendrix','T.','2003-09-22',11,'MALE','14 San Joaquin St. SFDM, QC.','','09183432732','OLD','',0.00000,'Circumcision','','2014-04-30'),
('20141881','Alavado','Duchess Kalia Saffrone','F.','2013-06-13',1,'FEMALE','14 San Jose St. SFDM, QC.','','09274703622','Dr. Modesta Avendano','',0.00000,'','','2014-04-30'),
('20141202','Reyes','Rommel','D.','1977-04-29',37,'FEMALE','2C Fernandez St. SFDM QC','','09273001974','','',0.00000,'','','2014-04-30'),
('20141197','Abaja','Lewelyn','L.','1975-08-21',39,'MALE','Frisco QC','','N/A','','',0.00000,'','','2014-04-30'),
('20141886','NAVARRO','KIMBERLY','M.','1994-08-01',20,'FEMALE','15 B SAN PEDRO BAUTISTA ST. BRGY. MARIBLO, QC.','','09163596064','DR. GLORIA SAMSON','',0.00000,'','','2014-04-30'),
('20141768','GABRIEL','KENJIE','O.','2008-06-20',6,'MALE','1-D ILAGAN ST. BRGY. PALTOK, SFDM, QC.','','09268290106','DR. SUSAN BOLIMA','',0.00000,'','','2014-04-30'),
('20141769','GABRIEL','KIJIMA','O.','2007-04-12',7,'MALE','1-D ILAGAN ST. BRGY. PALTOK, SFDM, QC.','','09268290106','DR. SUSAN BOLIMA','',0.00000,'','','2014-04-30'),
('20141884','MANARANG','CYNTHIA','N/A','1979-04-10',35,'FEMALE','78 WEST RIVERSIDE, SFDM, QC.','','09481300741','NEW','',0.00000,'CHEST PA','','2014-04-30'),
('20141883','SASOT','SHEMARIE','M.','1988-12-09',26,'FEMALE','31 BASA ST. SFDM, QC.','','09298359790','NEW','',0.00000,'PELVIC ULTRASOUND','','2014-04-30'),
('20141878','Escueta','Marvin','A.','1998-11-10',16,'MALE','62 B KAINGIN ROAD, QC.','','09465260686','NEW','',0.00000,'CXR PA','','2014-04-30'),
('20141877','Miravite','Zacarias IV','G','1960-11-07',0,'MALE','32 Santiago St., SFDM, Quezon City','','09189119449','NEW','',0.00000,'BUA, CREATININE','','2014-04-30'),
('20141876','Carmen','Alfredo','Amascual','1995-12-08',19,'MALE','San Joaquin, Munoz, Quezon City','','09107265897','','',0.00000,'Drug Test, Fecalysis, HbsAg Screening','','2014-04-30'),
('20141930','OBISPO','ANJEANETTE DOMINIK','M.','1997-10-23',17,'FEMALE','5 OSMENA ST. SFDM, QC.','','09253971023','NEW','',0.00000,'CXR PA','','2014-05-05'),
('20141929','GANCIL','JENNYLYN','A.','1985-11-25',29,'FEMALE','5-A BLK A STO. NINO ST. SFDM, QUEZON CITY','','09428004260','NEW','',0.00000,'FBS','','2014-05-05'),
('20141928','GANCIL','MINDA','R.','1949-11-01',65,'FEMALE','5-A BLK A STO. NINO ST. SFDM, QUEZON CITY','','09428004260','NEW','',0.00000,'FBS','','2014-05-05'),
('20141909','KASAN','SHERINA','I.','1959-09-17',55,'FEMALE','20 DOLLAR ST. CB TOWN HOMES, CAPITOL SITE, QUEZON CITY','','','DRA. CASIGURAN','',0.00000,'CONSULTATION','','2014-05-05'),
('20141926','ORQUIA','JOVELYN','A.','1979-09-19',35,'FEMALE','42 SAN JOAQUIN ST. SFDM, QUEZON CITY','','09485692812','DR. BENJAMIN CHUA','',0.00000,'CONSULT','','2014-05-05'),
('20141924','DELA PAZ','RONALDO JR.','O.','2002-10-26',12,'MALE','13 WILSON ST. BRGY DAMAYAN, QUEZON CITY','3756376','','NEW','',0.00000,'CIRCUMCISION','','2014-05-05'),
('20141920','MATIAS','MELVIN','C.','1971-01-06',43,'MALE','3 MATIAS ST. SFDM, QUEZON CITY','','09255044016','NEW','',0.00000,'ECG','','2014-05-05'),
('20141925','NUNAG','REBECCA','C.','1969-02-09',45,'FEMALE','29 B OSMENA ST. SFDM, QUEZON CITY','','09165551338','NEW','',0.00000,'DRUG TEST','','2014-05-05'),
('20141923','LAZATIN','ANGELICA','J.','1991-11-02',23,'FEMALE','7 ZORRA ST. BRGY. PALTOK, SFDM, QUEZON CITY','','09097204062','NEW','',0.00000,'TVS UTZ','','2014-05-05'),
('20141922','ABIUL','RUBY ROSE','S.','1990-12-31',24,'FEMALE','11 ZAMBOANGA ST. WEST AVE, QUEZON CITY','','09178942802','DRA. ASUNCION','',0.00000,'CONSULT WITH PAPSMEAR','','2014-05-05'),
('','PABILLARE','MELQUIADES','N.','1962-11-07',0,'MALE','8 PABILLARE ST. BRGY. DAMAYAN, QUEZON CITY 1104','','09293657596','OLD','',0.00000,'PACKAGE 1, HBA1C, CBC W/ PLATELET','','2014-05-12'),
('20142023','YADAO','SANDY','B.','1972-08-06',42,'MALE','10 CARAGAY ST. SFDM, QUEZON CITY','','09279294739','Vic Asuncion','',0.00000,'CERVICAL SPINE AP/L','','2014-05-12'),
('','ODOSIS','JOSEPH IVAN','E.','1988-03-01',26,'MALE','4 D H. FRANCISCO ST. SFDM, QUEZON CITY','','09291192498','Lyndon Samson','',0.00000,'2D ECHO W/ DOPPLER, CXR APICO, SGOT, SGPT','','2014-05-12'),
('','GO','YOLANDA','P.','1958-07-08',56,'FEMALE','SAMAR','','09205113697','','',0.00000,'SGPT, SGOT, CBC W/ PLATELET, BILIRUBIN, BUN, CREA','','2014-05-12'),
('20142024','MIRALLES','ANA FELNA','R.','1996-09-20',18,'FEMALE','46 BASA ST. SFDM, QUEZON CITY','','09061839969','Vic Asuncion','',0.00000,'CXR PA','','2014-05-12'),
('','ACUBA','KENNETH','V.','1972-12-09',42,'MALE','146 ROOSEVELT AVE., SFDM, QUEZON CITY','','09352390693','Lyndon Samson','',0.00000,'CXR PA','','2014-05-12'),
('20142025','DELA CRUZ','CANDIDA','C.','1960-09-22',54,'FEMALE','31 F BAUTISTA ST. SFDM, QUEZON CITY','','','NEW','',0.00000,'FBS, LIPID PROFILE','','2014-05-12'),
('20141277','DE GUIA','NANETTE','L.','1995-04-27',19,'FEMALE','34-8 GEN D. QUEZON AVE','','09284658234','','',0.00000,'','','2014-05-12'),
('20143631','Catriz','Merly','B','1938-10-18',76,'FEMALE','49 A Felipe St., SFDM, Q.C.','','','','',0.00000,'','','2014-06-26'),
('20143627','Marasigan','Merrian','V.','1979-11-08',35,'FEMALE','Phase 4 Blk. 15 Cot. 33 Eastwood Residence Rodriguez, Rizal','','','','',0.00000,'','','2014-06-26'),
('20143629','Berida','Eunice','De Jesus','1992-03-09',22,'FEMALE','34 J.P. Rizal Pembo Makati City','','','','',0.00000,'','','2014-06-26'),
('20143633','pasion','aleli','f','1969-04-18',45,'f','','','','','',0.00000,'','','2014-06-26');

/*Table structure for table `report_tbl` */

DROP TABLE IF EXISTS `report_tbl`;

CREATE TABLE `report_tbl` (
  `patient_id` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `report_tbl` */

/*Table structure for table `request_tbl` */

DROP TABLE IF EXISTS `request_tbl`;

CREATE TABLE `request_tbl` (
  `request_id` varchar(50) default NULL,
  `staff_name` varchar(50) default NULL,
  `item_name` varchar(50) default NULL,
  `quantity` int(7) default NULL,
  `stat` int(1) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `request_tbl` */

/*Table structure for table `schedule_tbl` */

DROP TABLE IF EXISTS `schedule_tbl`;

CREATE TABLE `schedule_tbl` (
  `doctor_id` varchar(50) NOT NULL,
  `monday` varchar(50) default NULL,
  `tuesday` varchar(50) default NULL,
  `wednesday` varchar(50) default NULL,
  `thursday` varchar(50) default NULL,
  `friday` varchar(50) default NULL,
  `saturday` varchar(50) default NULL,
  PRIMARY KEY  (`doctor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `schedule_tbl` */

insert into `schedule_tbl` values 
('0212c8ee-e77a-462c-b6fa-d8bfde5e01cc','1 PM - 4 PM','','2 PM - 6 PM','','',''),
('08fe3fca-c9f4-4c5d-8aef-b8092653d213','','','11:30 AM to 1 PM','','11:30 AM to 1 PM',''),
('18340027-af2d-4521-b3ec-4c0e92a0ec77','','','','','','9 AM to 12 NN'),
('2f32bcd9-62c9-4159-8eb4-f5740644a2b0','','12 NN to 3 PM','','','',''),
('372630da-ab35-4195-b1ef-0068f37aee28','','','10 AM to 12 NN','','4 PM to 6 PM',''),
('460328ff-0bae-49ce-a855-27762a0397c3','','10 AM to 12 NN','','10 AM to 12 NN','','10 AM to 12 NN'),
('47bee28d-5542-41af-b033-161fc86be9e2','1 PM to 3 PM','','','','1 PM to 3 PM',''),
('5eed8cb7-052c-45da-96fe-a39c06f01337','4 PM to 6 PM','','','','1 PM to 4 PM',''),
('643ac881-9148-4a64-b6fb-b9f99aa63a1c',NULL,NULL,NULL,NULL,NULL,NULL),
('70593ab4-d565-4a60-a8f2-ac7f47f81a12',NULL,NULL,NULL,NULL,NULL,NULL),
('7e4cd04a-d7e9-49dd-8c8d-33d1b5073af4','9 AM to 12 NN','','9 AM to 12 NN','','9 AM to 12 NN','4 PM to 6 PM'),
('806cdd3d-bbad-4601-9d1f-911189c25fc2',NULL,NULL,NULL,NULL,NULL,NULL),
('809d770e-b568-4fa8-a13a-b5827efec52c','8 AM to 10 AM','','','','','8 AM to 10 AM'),
('89cde479-e4f1-4a7e-bf7e-af62c861d1fd','','3 PM to 6 PM','','','1 PM to 3 PM',''),
('98e2dcd5-f4f6-459b-8bc8-e80608499a44',NULL,NULL,NULL,NULL,NULL,NULL),
('af6de2d0-8b8d-48c1-8164-f10da221f773','','9 AM to 12 NN','','9 AM to 12 NN','','4 PM to 6 PM'),
('bd8876ad-47a9-489a-a69f-1ad2bcd7b6da',NULL,NULL,NULL,NULL,NULL,NULL),
('c13dac62-1f7b-4af6-8edf-74cb025d521d','1 PM to 4 PM','','','3 PM to 6 PM','',''),
('c1494287-ca29-4cef-b382-f2eb6a6c2719','','2 PM to 6 PM ','','2 PM to 6 PM','',''),
('c39f23e2-b7ab-46ba-9232-5e9f4fb83886','','','5 PM to 6 PM','5 PM to 6 PM','5 PM to 6 PM',''),
('c8418012-4d8d-4491-896a-9ac22fbd7fa3',NULL,NULL,NULL,NULL,NULL,NULL),
('cadc3548-6f43-4a7a-9f48-6d25f9c94b5e','','','','','',''),
('cc46722c-c6b3-4456-ad93-4b529e8ee9dd','','8:30 AM to 10:30 AM','','','',''),
('ccf1b187-0e86-4a4e-adc2-97980d71ea0a','9 AM to 12 NN','','','9 AM to 12 NN','',''),
('d5c63314-4096-4ed4-928f-8199c98f1232','','4 PM to 6 PM','','4 PM to 6 PM','','1 PM to 3 PM'),
('d7144639-7662-4fc8-b648-68ff3549d4b7','On-Call','','','','',''),
('d815322c-254a-4fcc-bc03-38927a543bcc','','','9 AM to 12 NN','','3 PM to 6 PM',''),
('e0cadcbd-b889-45a7-bb5d-41ee9a4c101a','','10 AM to 12 NN','','1 PM to 3 PM','','1 PM to 3 PM'),
('f6540fb1-7dd4-41c9-87f9-e3e1ef805c7e','9 AM to 12 NN','','','','9 AM to 12 NN','');

/*Table structure for table `service_category_tbl` */

DROP TABLE IF EXISTS `service_category_tbl`;

CREATE TABLE `service_category_tbl` (
  `Scat_id` varchar(50) default NULL,
  `Scat_name` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service_category_tbl` */

insert into `service_category_tbl` values 
('e56cb3f3-a05f-48f1-9c16-673d507006d4','HEMATOLOGY'),
('eab4a4f4-2836-4a81-af48-bf9f6ac7520a','BLOOD CHEMISTRY'),
('012e3487-f943-43d4-af4e-a923895b6719','CYTOLOGY'),
('bc404d50-4e6c-43ea-8d59-7979042cae8e','HEPATITIS MARKERS'),
('ab33092c-01c1-4adf-a8b1-92b03e77cba6','ELECTROLYTES'),
('a30fd766-a8cf-4e3e-8237-79583c9890e2','CONSULTATION'),
('3e17d6ec-2204-48be-a7a3-e7831c52447b','IMMUNOLOGY/SEROLOGY'),
('f0597683-2f1a-4470-9b40-9dcb5206ce88','THYROID FUNCTION TEST'),
('63829d78-244d-474b-b784-76aee2d68ef0','TUMOR MARKERS'),
('c3361cbc-ff5e-4005-a077-b139d37e9a58','MICROSCOPY'),
('59f2fcc5-3ed7-47f8-a143-8efb22c278c0','HISTOPATHOLOGY'),
('1b4f1848-abe0-4c77-90a4-8d8348e6f9d6','BACTERIOLOGY'),
('f10a95f2-f60d-4105-8b0d-2a359e0e795d','CARDIOVASCULAR PROCEDURE'),
('d0f9b32a-f1cb-4c55-b0bd-61e98b598aac','ULTRASONOGRAPHY'),
('ae886696-f07e-48cc-9242-5304896bfd04','RADIOGRAPHY'),
('72737953-7259-460c-ab09-d3a51f05f846','ENZYMES'),
('6c250c00-22d8-4fbb-9dd3-d25a8f02f364','CONSULTATION');

/*Table structure for table `service_price_tbl` */

DROP TABLE IF EXISTS `service_price_tbl`;

CREATE TABLE `service_price_tbl` (
  `service_id` varchar(50) NOT NULL,
  `service_net` double(11,2) default NULL,
  `service_vat` double(11,2) default NULL,
  `service_gross` double(11,2) default NULL,
  PRIMARY KEY  (`service_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service_price_tbl` */

insert into `service_price_tbl` values 
('0',110.00,13.20,123.20),
('00a58489-937e-401c-b0f4-dd08f4475a03',848.21,101.79,950.00),
('0185f476-fda3-4f17-8e79-474509ac9fd8',517.86,62.14,580.00),
('02803242-352a-4734-b91d-688c8713b4d8',535.71,64.29,600.00),
('039e74c1-7610-40df-b577-2456d748c79d',80.36,9.64,90.00),
('061b743b-43a7-4459-b484-f6566d1313e6',178.57,21.43,200.00),
('0694029f-2a9b-48a4-81bc-5468d9097790',116.07,13.93,130.00),
('06ac3166-881f-4343-861e-acd51d577140',267.86,32.14,300.00),
('08037b8b-ec2d-4b02-850e-3ae224bed63d',580.36,69.64,650.00),
('083b2f56-81f5-4707-907b-fc5c6263fb7e',2544.64,305.36,2850.00),
('09d0b388-52e6-4bc0-b58e-855d75a99468',455.36,54.64,510.00),
('0abb9f7f-90cc-4846-b1e4-89df23a76dac',625.00,75.00,700.00),
('0aeae0c8-711c-43f3-865b-090a538a11c3',187.50,22.50,210.00),
('0af8fa4f-152d-4ed4-b7aa-16cd9700e50d',428.57,51.43,480.00),
('0b520849-e102-4d04-93e0-4609b5334263',214.29,25.71,240.00),
('0bffbde7-9148-43fe-a687-d7e9781ac869',446.43,53.57,500.00),
('0c2e924b-e5e8-4bd3-92d3-88e24290fdf8',2410.71,289.29,2700.00),
('0ce15f87-4165-4c1e-a401-ecc0a06de6b7',401.79,48.21,450.00),
('0d27f105-a5de-4b56-8380-28aa521ba341',187.50,22.50,210.00),
('0d4215c3-6756-405b-880e-533288096a67',758.93,91.07,850.00),
('0e935073-cdc1-473f-af5e-7fc7194f915d',245.54,29.46,275.00),
('0f5b4ab1-128c-43c9-b68d-0eccdb758376',839.29,100.71,940.00),
('11af803d-522f-46fd-9906-f9796cec03a7',357.14,42.86,400.00),
('124340c4-2cf0-4b65-87e9-a6e5d5f874bc',160.71,19.29,180.00),
('12d9f4a3-96e0-4f83-acc7-0980bcabbe70',267.86,32.14,300.00),
('134efac5-0a05-4208-a52d-80df3d236e94',267.86,32.14,300.00),
('13731701-7bc9-4141-8c3d-02353d33c62c',89.29,10.71,100.00),
('13c905b7-bedc-4531-aa97-f3da3a2f6f6f',80.36,9.64,90.00),
('14e9ba83-d348-4221-8b70-ad74d2f06eae',2232.14,267.86,2500.00),
('15ed8bf2-fd24-4a66-bd84-8496b85e83d2',848.21,101.79,950.00),
('187ae4ca-9c87-4c81-8d21-915d1d7349f5',267.86,32.14,300.00),
('19351e8c-d32e-42d2-a887-ab537632651c',133.93,16.07,150.00),
('1a9ee895-315f-422f-bbe1-9cc8da437e06',312.50,37.50,350.00),
('1ce11103-46e4-4286-a71b-216e85d1195f',133.93,16.07,150.00),
('1d388981-9e29-4152-9b7a-04de2094a7ec',267.86,32.14,300.00),
('1eff1a7b-1913-4b3e-a831-6e73066a6961',1071.43,128.57,1200.00),
('1fe1ad12-1738-499b-bb70-916442a2450e',580.36,69.64,650.00),
('2068319d-90e3-43be-b278-32bae3806deb',232.14,27.86,260.00),
('2155ac8c-6873-48fa-8e80-075cd7631725',1071.43,128.57,1200.00),
('218c22d1-438f-4dcc-8a2f-c02cbac9efff',267.86,32.14,300.00),
('21ab0fb1-15cf-4021-9a07-fee10efb9ff5',1071.43,128.57,1200.00),
('224d3060-df7f-4a87-97ce-62b811da7a1d',848.21,101.79,950.00),
('2326d9c5-03d2-4061-8502-1e5c37fbceb6',1339.29,160.71,1500.00),
('25364c14-4db4-41a1-92b1-ed15d1bfe9cc',803.57,96.43,900.00),
('26e72573-b61e-4bf0-99d8-aedbec95adc1',1339.29,160.71,1500.00),
('2703182c-6248-4d60-aaa0-f1d9249a87eb',455.36,54.64,510.00),
('278a391b-5ebf-4829-9418-4f794ea39342',625.00,75.00,700.00),
('29141ba4-4c5f-47a5-b94b-39be171aa6c6',848.21,101.79,950.00),
('29597903-90b0-4f2c-9a91-f5eaf0a3cee8',89.29,10.71,100.00),
('29e3a051-f7ec-4660-b217-bdad59d87113',875.00,105.00,980.00),
('2b5fa9a3-159e-45d5-8f69-44170ee8fc21',53.57,6.43,60.00),
('2d60e325-e307-4bdd-91da-0899f66d1a2b',98.21,11.79,110.00),
('2f7068fe-f668-4c44-a0f2-56bbb3fe9d21',1607.14,192.86,1800.00),
('2fa6511b-0a7c-4038-b184-e69ecf6ea8e3',714.29,85.71,800.00),
('2fc788af-bbd2-48f8-8639-20d604d61cc4',357.14,42.86,400.00),
('310c975f-9e9b-4121-a6a8-84563edba526',294.64,35.36,330.00),
('32571dc0-b4c7-4af2-a1f1-7e48f196ada6',98.21,11.79,110.00),
('337e9a68-cfad-41de-8c9b-e9d4a7113471',375.00,45.00,420.00),
('33a7ac8c-fb42-4e11-8eec-6ab0c0a81a87',98.21,11.79,110.00),
('346d3d18-a24c-44b3-a091-0d6aa7ced429',383.93,46.07,430.00),
('3470bc17-7828-4fa8-b299-74cb3ba9719b',267.86,32.14,300.00),
('34734244-5aea-4b45-a041-3d5a9ffba81f',517.86,62.14,580.00),
('34dfe1ca-2257-41cc-89cf-306d30afa357',330.36,39.64,370.00),
('37e9e8b7-7806-4024-aeba-0bac7dbcae50',151.79,18.21,170.00),
('3882d30f-e3e1-4085-b6fa-c827cccff585',107.14,12.86,120.00),
('3b903c1a-4c5d-4794-8de9-049cc0dfe6ce',357.14,42.86,400.00),
('3c046568-b582-43c9-b6b2-9946a059841a',669.64,80.36,750.00),
('3cc3441e-da76-483a-a15b-f138436f3987',517.86,62.14,580.00),
('3cd3a089-0673-44f4-a71b-120121e85158',892.86,107.14,1000.00),
('3f5f79a1-2b7f-45a3-9f2d-b4afc91ececc',892.86,107.14,1000.00),
('43b68d16-a307-4174-bfcb-e28e59a76144',98.21,11.79,110.00),
('4533f6be-53f2-406e-8eac-579a07a729e0',1294.64,155.36,1450.00),
('45ec9bb6-d53b-4bb3-a726-ee3cddf0a3f9',535.71,64.29,600.00),
('4772b0aa-0d94-499b-8de2-73b499dd1c37',267.86,32.14,300.00),
('4846f264-16aa-4a98-b5b8-c55f4d3c2fd7',107.14,12.86,120.00),
('48835fc6-c2d7-4903-b740-dcfb9b06a2ce',1607.14,192.86,1800.00),
('49ca84ce-bdf2-4bfa-b7b7-75f3c6d16c7d',892.86,107.14,1000.00),
('4a0f32dc-1ec4-4fef-af1d-fa8f50931971',267.86,32.14,300.00),
('4cac4ace-4971-4b11-aeb4-82801eae205c',839.29,100.71,940.00),
('4ec5c2cc-3ee1-4c9b-ac2c-9c7614008699',535.71,64.29,600.00),
('4faa5079-cc6b-4188-a080-9cdefee8f25e',580.36,69.64,650.00),
('55e62f55-50d7-4908-b11f-02c1d1c3a5f6',89.29,10.71,100.00),
('57ae1afd-1073-40d4-9867-5ab30a2c9bfc',294.64,35.36,330.00),
('5ca9f1bc-5bae-47e4-b903-0cd7109ed5b5',267.86,32.14,300.00),
('5ddb71dc-20a9-46df-bdf8-53c2af4874f6',267.86,32.14,300.00),
('5f6aa930-bb6e-4fc2-82f8-413796d8403f',66.96,8.04,75.00),
('5f6aef3c-85c2-4551-bcea-73c75240c52c',428.57,51.43,480.00),
('5f980aae-7ade-475d-b712-8b51b9ea7340',758.93,91.07,850.00),
('62008986-a58f-4e71-9135-46fcaa2e49ab',214.29,25.71,240.00),
('6442e225-07cc-4fec-94b6-baf2a447d4bb',232.14,27.86,260.00),
('66507c3b-8b49-4b01-8e46-552e1de42510',125.00,15.00,140.00),
('67fc47ea-46f8-4b35-ba81-3f149426a5ef',165.18,19.82,185.00),
('68b6b323-5697-4890-86b1-4e776281a53a',80.36,9.64,90.00),
('69018df7-5518-4d93-af54-d6979b6bb69d',267.86,32.14,300.00),
('69172c3c-0bf7-42aa-8104-768bca090e12',267.86,32.14,300.00),
('6a98f053-1cce-4022-b933-226f48d6a50b',321.43,38.57,360.00),
('6c7523bf-1ed8-476f-a5e4-4a7f76dff537',339.29,40.71,380.00),
('6d438b68-db6a-4ae5-bd61-aa1aac59e9c2',267.86,32.14,300.00),
('6ddcf9d2-864d-4143-b512-72eeb854dd16',133.93,16.07,150.00),
('6df659bb-b615-46db-8c68-7f2063bcf0c1',223.21,26.79,250.00),
('70bf63c4-4e74-41ad-828c-5ebce7bc5eae',116.07,13.93,130.00),
('72c15001-1743-4316-85a7-96b5808c38a4',625.00,75.00,700.00),
('7639d49f-3960-45cd-a325-681349f2ce2a',116.07,13.93,130.00),
('79448c95-1fba-4392-9109-c14872b6a2c5',625.00,75.00,700.00),
('79457b4b-eb27-4ab0-ae69-5ee03374151f',1785.71,214.29,2000.00),
('79ca804a-3a1e-4b24-8ca0-3ba283c9d9cf',455.36,54.64,510.00),
('7a8a798b-2609-4ab1-b429-857b75509b22',535.71,64.29,600.00),
('7ab9480b-9cf9-4c94-8b46-aaf7be0812b4',285.71,34.29,320.00),
('7c49590b-eb99-41a3-a656-db1553e61d86',107.14,12.86,120.00),
('7e6996a2-d92b-4559-856b-a8c92db2ad47',758.93,91.07,850.00),
('7ed95363-2d29-491a-bce4-9a586b4f45d9',178.57,21.43,200.00),
('81342b8c-ef42-4643-be0e-ee725fb24aeb',321.43,38.57,360.00),
('82177263-9b28-4511-9575-e91ed27ce318',75.89,9.11,85.00),
('829e0570-f5fd-483c-962c-d41f553c4040',89.29,10.71,100.00),
('851f8c6d-ae73-48a0-81cb-7a4d95115873',669.64,80.36,750.00),
('8a553e0e-44c0-489e-a023-430ab727f1e1',223.21,26.79,250.00),
('8aa61b2e-d7a9-40f3-bb78-f0f2961f6ffd',267.86,32.14,300.00),
('8ac654de-a4ae-46ce-ba1b-b6015e9e6a1a',133.93,16.07,150.00),
('8b5d5aea-3e16-4b0f-a437-3431fedada94',267.86,32.14,300.00),
('8c201401-6a69-4951-862c-e7e8d18539fb',80.36,9.64,90.00),
('8c22f05b-1dae-476a-b8ca-50a6efbd944d',446.43,53.57,500.00),
('8c232d86-7a95-4c11-9029-7a1bf538bd51',401.79,48.21,450.00),
('8c23e4fc-604b-4d2c-baa4-2177eb2898d3',321.43,38.57,360.00),
('8cf1ac4e-84cb-41c6-9142-0c2c5e8e60df',892.86,107.14,1000.00),
('8f1d07e8-16cc-46a6-adeb-712a54da6985',267.86,32.14,300.00),
('909c638f-2297-474c-bfae-2add9649d184',339.29,40.71,380.00),
('91022201-5900-4a39-91f3-ecdc987d2782',107.14,12.86,120.00),
('9161b211-0856-49c4-a162-85afe64ca94f',80.36,9.64,90.00),
('927166f9-b456-42f6-a96c-46246ba87314',107.14,12.86,120.00),
('92ea2354-d409-43da-aea5-2f61d6445e09',1294.64,155.36,1450.00),
('99b7c6ca-f716-42c3-961c-86257fcbc6e5',348.21,41.79,390.00),
('9ad71043-47bd-454f-aaaa-5b1dd2b0268d',267.86,32.14,300.00),
('9b18b5b0-fd5f-49d9-936c-d7faf2163388',339.29,40.71,380.00),
('9c07e4b4-727c-4b5e-8c01-b30de7935254',267.86,32.14,300.00),
('9d4e8055-8b8a-44db-ba73-9734643266dc',116.07,13.93,130.00),
('9d829319-00eb-4644-af35-6a4da48b7992',758.93,91.07,850.00),
('a0d7166d-4b14-42dc-9fb8-5b0d45710514',602.68,72.32,675.00),
('a0fdaaea-7073-41fd-94ae-ec7cdb2b66b2',156.25,18.75,175.00),
('a1391200-0155-443f-8636-1b95063ef791',178.57,21.43,200.00),
('a19522ee-c082-4e8a-9f9d-184e7c8cbb9c',107.14,12.86,120.00),
('a24ec7be-c1cf-4322-8c0d-4b78f9e5f628',285.71,34.29,320.00),
('a372d6b7-8dd2-4221-b25d-71cb892591a1',285.71,34.29,320.00),
('a747899f-8296-4f47-94bd-8f7af0e9c4a0',223.21,26.79,250.00),
('a85394dd-f824-4b52-af99-0743ac12130c',196.43,23.57,220.00),
('a85c0d9f-2e06-488c-a2e0-518b78ba8aa9',89.29,10.71,100.00),
('a97eb2fd-6431-4a6c-bcea-292207bbc54d',848.21,101.79,950.00),
('a991da42-c589-4d4a-8878-36cd8d109ee6',669.64,80.36,750.00),
('ade3a347-cdae-44a6-b2d6-e3835186a2fe',80.36,9.64,90.00),
('ae4a2785-407a-4d42-8f98-d2dc815f605d',80.36,9.64,90.00),
('aed844ec-0fd9-481a-91d7-35d95202894b',196.43,23.57,220.00),
('af0a902a-fc41-4145-a449-db8bf063c309',348.21,41.79,390.00),
('af35d7a5-f356-4c68-8b40-37db684b5850',625.00,75.00,700.00),
('affc881a-766d-46f1-8f05-81243c63854f',160.71,19.29,180.00),
('b2def962-fb82-4ff4-b1f3-58cd5135d22b',223.21,26.79,250.00),
('b2e2afd9-116b-4ed4-a6d4-725ced0b00fa',93.75,11.25,105.00),
('b33933a4-2e61-4003-8a9a-d9f9db0a3ef0',71.43,8.57,80.00),
('b47df8c1-32d5-4aff-bb9f-7ced3783b022',62.50,7.50,70.00),
('b4fdc17e-3d59-46f5-8a7f-323c340458a8',535.71,64.29,600.00),
('b5a92891-fba2-40a8-8114-616cb1bbccdd',205.36,24.64,230.00),
('b60b7457-5ff5-45ba-80b5-2bd7b3b5018c',714.29,85.71,800.00),
('b6b4d486-030f-4fa2-bd0b-2047b53396aa',98.21,11.79,110.00),
('b6bf8792-58c5-4850-9ce8-031f07815055',267.86,32.14,300.00),
('be10a30e-d8a6-47e4-bb03-12db5665b6ff',187.50,22.50,210.00),
('bf3ce230-e796-44fe-9bd0-af19708120db',625.00,75.00,700.00),
('c0e9517e-7ca8-4576-947f-6eaeb50a6456',196.43,23.57,220.00),
('c3d48e2d-13a2-4905-83c7-184ee114aa5e',89.29,10.71,100.00),
('c3e447db-cdb8-499f-bfb4-6281acfa5fe4',1071.43,128.57,1200.00),
('c442bb23-2f88-4067-b02e-1d69e77fb517',116.07,13.93,130.00),
('c4d4bb0a-90d5-4865-89dd-e816c2e9db8b',446.43,53.57,500.00),
('c5195abb-1792-4947-8e82-761c650a47d3',848.21,101.79,950.00),
('c5cf3e74-88a5-4361-bad1-f4a949279352',375.00,45.00,420.00),
('c688d343-f39d-4f5f-ae39-141d099e1893',276.79,33.21,310.00),
('c719b104-c011-4243-8630-5409f93d4f4d',66.96,8.04,75.00),
('c77a26ee-2e94-487b-994a-5dc7183ecf7b',491.07,58.93,550.00),
('c7a5a79d-50af-4d56-afb9-d5bbc7c69c6e',196.43,23.57,220.00),
('cb1d8d16-5b30-45b5-84cc-1353b8e3e09e',93.75,11.25,105.00),
('ce863a6a-3dc8-4e6b-9f75-1ca8af17d6b1',1607.14,192.86,1800.00),
('cebd6acd-7cf1-44e1-a085-46d6c166341b',1339.29,160.71,1500.00),
('cf6944cf-96e3-4242-b4c1-b2ad24cdc262',178.57,21.43,200.00),
('cf7c5633-7936-43dd-a32a-b4a1f4a1c5dc',1071.43,128.57,1200.00),
('d15c797a-d3ce-4dad-ae88-24a3d533d3f9',625.00,75.00,700.00),
('d17001f4-5a66-4a39-be4e-8f2898c47514',178.57,21.43,200.00),
('d2cda657-3305-43dc-adcb-3908cd40b9f6',1785.71,214.29,2000.00),
('d4f5f37b-f78a-4704-a29e-d67446ba8883',267.86,32.14,300.00),
('d4f9073c-df92-4fc5-b107-e355113e737d',625.00,75.00,700.00),
('d50257fa-a50d-4681-858d-41c170c4f3fb',53.57,6.43,60.00),
('d7c33bae-c1e0-4832-b857-95e33e6fb28f',669.64,80.36,750.00),
('d9090ffa-93fe-4433-9b1e-8982e526040c',98.21,11.79,110.00),
('d94679bb-d6d8-4717-b316-43e77fa5b35e',875.00,105.00,980.00),
('dbe08930-5704-4c00-aff8-4c4798a29c87',1500.00,180.00,1680.00),
('dc1dc786-3779-46ba-b235-3108275b4d7a',205.36,24.64,230.00),
('dd527a2e-9ecc-43f2-b842-3d2b41bcbbbc',758.93,91.07,850.00),
('dd56be0b-e39f-437f-bbd0-b591dd964fd0',107.14,12.86,120.00),
('de5841ed-cc32-45d4-b7c3-b09133303c86',151.79,18.21,170.00),
('dfac8233-25ee-4355-a99d-84ad1b4456d2',875.00,105.00,980.00),
('e0384fb1-499c-425f-8416-28e920644516',151.79,18.21,170.00),
('e0c6da06-df0c-4d23-bf71-f9698dca00a5',267.86,32.14,300.00),
('e20a9e4f-764d-431f-a92b-b7823ba5fc4a',535.71,64.29,600.00),
('e3d03553-a4cb-4e22-91c3-7eed980b7fc4',93.75,11.25,105.00),
('e4d66895-457b-4d3d-a827-1177168440ee',339.29,40.71,380.00),
('e6935be1-d630-49d2-adb5-29da193eeb43',312.50,37.50,350.00),
('e7f3dc9d-733b-4746-81bc-2faac5865040',602.68,72.32,675.00),
('eceb736b-7439-432c-9b85-3b57f287cf02',758.93,91.07,850.00),
('edd4e930-2bc3-4c55-8661-15d73cb38074',142.86,17.14,160.00),
('ee997788-f666-4465-a789-696a71f3651a',535.71,64.29,600.00),
('f3750883-9d2e-41a8-9294-b7b2a0d0d441',2642.86,317.14,2960.00),
('f3c31707-d450-4af1-ac68-94886b90b4b4',151.79,18.21,170.00),
('f5214d23-9a20-48ea-8929-7217bdc36ebb',116.07,13.93,130.00),
('f6e9fe3d-e1e8-4f0b-b640-f78077e9e528',392.86,47.14,440.00),
('f9d854fd-ca28-416f-98a3-04f27b784ae9',669.64,80.36,750.00),
('fa03d93d-d32b-44b9-a757-47ed398a57eb',98.21,11.79,110.00),
('fa1b2c6c-16ea-497d-89bc-44062b34d3a5',383.93,46.07,430.00),
('fd280a5e-d555-4a25-b795-3afda981faf8',80.36,9.64,90.00);

/*Table structure for table `service_type_tbl` */

DROP TABLE IF EXISTS `service_type_tbl`;

CREATE TABLE `service_type_tbl` (
  `stype_id` varchar(50) default NULL,
  `stype_name` varchar(50) default NULL,
  `stype_category` varchar(50) default NULL,
  `stat` int(1) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `service_type_tbl` */

insert into `service_type_tbl` values 
('32571dc0-b4c7-4af2-a1f1-7e48f196ada6','COMPLETE BLOOD COUNT','HEMATOLOGY',1),
('ade3a347-cdae-44a6-b2d6-e3835186a2fe','PLATELET COUNT','HEMATOLOGY',1),
('124340c4-2cf0-4b65-87e9-a6e5d5f874bc','CBC WITH PLT. COUNT','HEMATOLOGY',1),
('c719b104-c011-4243-8630-5409f93d4f4d','BLOOD TYPING','HEMATOLOGY',1),
('5f6aa930-bb6e-4fc2-82f8-413796d8403f','RH TYPING','HEMATOLOGY',1),
('66507c3b-8b49-4b01-8e46-552e1de42510','BLOOD + RH TYPING','HEMATOLOGY',1),
('b33933a4-2e61-4003-8a9a-d9f9db0a3ef0','ESR','HEMATOLOGY',1),
('cb1d8d16-5b30-45b5-84cc-1353b8e3e09e','PERIPHERAL SMEAR','HEMATOLOGY',1),
('e3d03553-a4cb-4e22-91c3-7eed980b7fc4','MALARIAL SMEAR','HEMATOLOGY',1),
('c0e9517e-7ca8-4576-947f-6eaeb50a6456','PTPA','HEMATOLOGY',1),
('d50257fa-a50d-4681-858d-41c170c4f3fb','CLOTTING TIME','HEMATOLOGY',1),
('2b5fa9a3-159e-45d5-8f69-44170ee8fc21','BLEEDING TIME','HEMATOLOGY',1),
('33a7ac8c-fb42-4e11-8eec-6ab0c0a81a87','CLOTTING + BLEEDING','HEMATOLOGY',1),
('9ad71043-47bd-454f-aaaa-5b1dd2b0268d','APTT','HEMATOLOGY',1),
('62008986-a58f-4e71-9135-46fcaa2e49ab','PROTIME','HEMATOLOGY',1),
('039e74c1-7610-40df-b577-2456d748c79d','HGB & HCT','HEMATOLOGY',1),
('b2e2afd9-116b-4ed4-a6d4-725ced0b00fa','RETICULOCYTE COUNT','HEMATOLOGY',1),
('aed844ec-0fd9-481a-91d7-35d95202894b','CRP','HEMATOLOGY',1),
('8c201401-6a69-4951-862c-e7e8d18539fb','WBC + DIFF COUNT','HEMATOLOGY',1),
('67fc47ea-46f8-4b35-ba81-3f149426a5ef','LE PREP','HEMATOLOGY',1),
('fd280a5e-d555-4a25-b795-3afda981faf8','FBS','BLOOD CHEMISTRY',1),
('68b6b323-5697-4890-86b1-4e776281a53a','BUN','BLOOD CHEMISTRY',1),
('9161b211-0856-49c4-a162-85afe64ca94f','CREATININE','BLOOD CHEMISTRY',1),
('37e9e8b7-7806-4024-aeba-0bac7dbcae50','BUN + CREATININE','BLOOD CHEMISTRY',1),
('c3d48e2d-13a2-4905-83c7-184ee114aa5e','URIC ACID','BLOOD CHEMISTRY',1),
('13c905b7-bedc-4531-aa97-f3da3a2f6f6f','TOTAL CHOLESTEROL','BLOOD CHEMISTRY',1),
('dd56be0b-e39f-437f-bbd0-b591dd964fd0','TRIGLYCERIDES','BLOOD CHEMISTRY',1),
('f3c31707-d450-4af1-ac68-94886b90b4b4','HDL','BLOOD CHEMISTRY',1),
('34dfe1ca-2257-41cc-89cf-306d30afa357','LIPID PROFILE (CHOLE, TRIGLY & HDL)','BLOOD CHEMISTRY',1),
('0694029f-2a9b-48a4-81bc-5468d9097790','TOTAL BILIRUBIN','BLOOD CHEMISTRY',1),
('55e62f55-50d7-4908-b11f-02c1d1c3a5f6','TOTAL PROTEIN','BLOOD CHEMISTRY',1),
('29597903-90b0-4f2c-9a91-f5eaf0a3cee8','ALBUMIN','BLOOD CHEMISTRY',1),
('a0fdaaea-7073-41fd-94ae-ec7cdb2b66b2','TP, A/G RATIO','BLOOD CHEMISTRY',1),
('6442e225-07cc-4fec-94b6-baf2a447d4bb','OGCT (50 GRAMS)','BLOOD CHEMISTRY',1),
('909c638f-2297-474c-bfae-2add9649d184','OGTT (50 GRAMS)','BLOOD CHEMISTRY',1),
('6c7523bf-1ed8-476f-a5e4-4a7f76dff537','OGTT (75 GRAMS)','BLOOD CHEMISTRY',1),
('9b18b5b0-fd5f-49d9-936c-d7faf2163388','OGTT (100 GRAMS)','BLOOD CHEMISTRY',1),
('c5cf3e74-88a5-4361-bad1-f4a949279352','HBA1C','BLOOD CHEMISTRY',1),
('a991da42-c589-4d4a-8878-36cd8d109ee6','PAP SMEAR COLLECTION AND READING','CYTOLOGY',1),
('19351e8c-d32e-42d2-a887-ab537632651c','PAP SMEAR SLIDE READ ONLY','CYTOLOGY',1),
('7a8a798b-2609-4ab1-b429-857b75509b22','PAP SMEAR COLLECTION ONLY','CYTOLOGY',1),
('edd4e930-2bc3-4c55-8661-15d73cb38074','HBSAG (SCREENING ONLY)','HEPATITIS MARKERS',1),
('cf6944cf-96e3-4242-b4c1-b2ad24cdc262','HBSAG WITH TITER','HEPATITIS MARKERS',1),
('be10a30e-d8a6-47e4-bb03-12db5665b6ff','ANTI-HBS','HEPATITIS MARKERS',1),
('a24ec7be-c1cf-4322-8c0d-4b78f9e5f628','HBE AG','HEPATITIS MARKERS',1),
('a372d6b7-8dd2-4221-b25d-71cb892591a1','ANTI-HBE','HEPATITIS MARKERS',1),
('310c975f-9e9b-4121-a6a8-84563edba526','ANTI-HBC IGM','HEPATITIS MARKERS',1),
('57ae1afd-1073-40d4-9867-5ab30a2c9bfc','ANTI-HBC IGG','HEPATITIS MARKERS',1),
('e4d66895-457b-4d3d-a827-1177168440ee','ANTI-HAV IGM','HEPATITIS MARKERS',1),
('af0a902a-fc41-4145-a449-db8bf063c309','ANTI-HAV IGG','HEPATITIS MARKERS',1),
('c77a26ee-2e94-487b-994a-5dc7183ecf7b','ANTI-HCV','HEPATITIS MARKERS',1),
('3c046568-b582-43c9-b6b2-9946a059841a','HEPATITIS A PROFILE','HEPATITIS MARKERS',1),
('dbe08930-5704-4c00-aff8-4c4798a29c87','HEPATITIS B PROFILE','HEPATITIS MARKERS',1),
('79457b4b-eb27-4ab0-ae69-5ee03374151f','HEPATITIS A & B PROFILE','HEPATITIS MARKERS',1),
('f3750883-9d2e-41a8-9294-b7b2a0d0d441','HEPATITIS A,B,C PROFILE','HEPATITIS MARKERS',1),
('fa03d93d-d32b-44b9-a757-47ed398a57eb','SODIUM (NA)','ELECTROLYTES',1),
('2d60e325-e307-4bdd-91da-0899f66d1a2b','POTASSIUM (K)','ELECTROLYTES',1),
('b6b4d486-030f-4fa2-bd0b-2047b53396aa','CHLORIDE (CL)','ELECTROLYTES',1),
('7c49590b-eb99-41a3-a656-db1553e61d86','IONIZED CHLORIDE','ELECTROLYTES',1),
('a19522ee-c082-4e8a-9f9d-184e7c8cbb9c','CALCIUM (CA)','ELECTROLYTES',1),
('f6e9fe3d-e1e8-4f0b-b640-f78077e9e528','IONIZED CALCIUM (CA)','ELECTROLYTES',1),
('b5a92891-fba2-40a8-8114-616cb1bbccdd','MAGNESIUM','ELECTROLYTES',1),
('6ddcf9d2-864d-4143-b512-72eeb854dd16','PHOSPHORUS (P)','ELECTROLYTES',1),
('d4f5f37b-f78a-4704-a29e-d67446ba8883','SERUM IRON (FE)','ELECTROLYTES',1),
('ee997788-f666-4465-a789-696a71f3651a','TOTAL IRON','ELECTROLYTES',1),
('2fa6511b-0a7c-4038-b184-e69ecf6ea8e3','FERRITIN','ELECTROLYTES',1),
('c442bb23-2f88-4067-b02e-1d69e77fb517','SGPT/ALT','BLOOD CHEMISTRY',1),
('70bf63c4-4e74-41ad-828c-5ebce7bc5eae','SGOT/AST','BLOOD CHEMISTRY',1),
('8ac654de-a4ae-46ce-ba1b-b6015e9e6a1a','ALKALINE PHOSPHATASE','BLOOD CHEMISTRY',1),
('dc1dc786-3779-46ba-b235-3108275b4d7a','ACID PHOSPHATASE (PROSTATE)','BLOOD CHEMISTRY',1),
('2068319d-90e3-43be-b278-32bae3806deb','TOTAL ACID PHOSPHATASE','BLOOD CHEMISTRY',1),
('0b520849-e102-4d04-93e0-4609b5334263','AMYLASE','BLOOD CHEMISTRY',1),
('c688d343-f39d-4f5f-ae39-141d099e1893','LIPASE','BLOOD CHEMISTRY',1),
('d17001f4-5a66-4a39-be4e-8f2898c47514','LDH','BLOOD CHEMISTRY',1),
('0ce15f87-4165-4c1e-a401-ecc0a06de6b7','TOTAL CPK','BLOOD CHEMISTRY',1),
('5f6aef3c-85c2-4551-bcea-73c75240c52c','CPK-MB','BLOOD CHEMISTRY',1),
('0af8fa4f-152d-4ed4-b7aa-16cd9700e50d','CPK-MM','BLOOD CHEMISTRY',1),
('0e935073-cdc1-473f-af5e-7fc7194f915d','GGTP','BLOOD CHEMISTRY',1),
('4faa5079-cc6b-4188-a080-9cdefee8f25e','TIBC+TOTAL IRON','ELECTROLYTES',1),
('fa749ff1-3975-4b6d-b6ba-abbf065a4246','TROPONIN I','BLOOD CHEMISTRY',1),
('00a58489-937e-401c-b0f4-dd08f4475a03','TROPONIN T','BLOOD CHEMISTRY',1),
('29e3a051-f7ec-4660-b217-bdad59d87113','DENGUE DUO','IMMUNOLOGY/SEROLOGY',1),
('dfac8233-25ee-4355-a99d-84ad1b4456d2','DENGUE NS1 ANTIGEN','IMMUNOLOGY/SEROLOGY',1),
('d94679bb-d6d8-4717-b316-43e77fa5b35e','DENGUE BLOT (IGG/IGM)','IMMUNOLOGY/SEROLOGY',1),
('927166f9-b456-42f6-a96c-46246ba87314','VDRL/RPR','IMMUNOLOGY/SEROLOGY',1),
('3b903c1a-4c5d-4794-8de9-049cc0dfe6ce','RPR (WITH TITER)','IMMUNOLOGY/SEROLOGY',1),
('a747899f-8296-4f47-94bd-8f7af0e9c4a0','TPHA SCREENING','IMMUNOLOGY/SEROLOGY',1),
('8c232d86-7a95-4c11-9029-7a1bf538bd51','TPHA WITH TITER ','IMMUNOLOGY/SEROLOGY',1),
('8a553e0e-44c0-489e-a023-430ab727f1e1','WIDAL TEST','IMMUNOLOGY/SEROLOGY',1),
('4cac4ace-4971-4b11-aeb4-82801eae205c','TYPHIDOT TEST','IMMUNOLOGY/SEROLOGY',1),
('7ab9480b-9cf9-4c94-8b46-aaf7be0812b4','ASO SCREENING','IMMUNOLOGY/SEROLOGY',1),
('346d3d18-a24c-44b3-a091-0d6aa7ced429','ASO WITH TITER','IMMUNOLOGY/SEROLOGY',1),
('c7a5a79d-50af-4d56-afb9-d5bbc7c69c6e','CRP','IMMUNOLOGY/SEROLOGY',1),
('a85394dd-f824-4b52-af99-0743ac12130c','RA/RF LATEX','IMMUNOLOGY/SEROLOGY',1),
('1fe1ad12-1738-499b-bb70-916442a2450e','ANA WITH TITER','IMMUNOLOGY/SEROLOGY',1),
('dd527a2e-9ecc-43f2-b842-3d2b41bcbbbc','LEPTOSPIRAL TEST (ELISA) IGM','IMMUNOLOGY/SEROLOGY',1),
('0d4215c3-6756-405b-880e-533288096a67','LEPTOSPIRAL TEST (ELISA) IGG','IMMUNOLOGY/SEROLOGY',1),
('224d3060-df7f-4a87-97ce-62b811da7a1d','RUBELLA IGM ','IMMUNOLOGY/SEROLOGY',1),
('d7c33bae-c1e0-4832-b857-95e33e6fb28f','RUBELLA IGG','IMMUNOLOGY/SEROLOGY',1),
('1eff1a7b-1913-4b3e-a831-6e73066a6961','VARICELLA IGM','IMMUNOLOGY/SEROLOGY',1),
('c3e447db-cdb8-499f-bfb4-6281acfa5fe4','VARICELLA IGG','IMMUNOLOGY/SEROLOGY',1),
('1ce11103-46e4-4286-a71b-216e85d1195f','TORCH (TOXOPLASMA, RUBELLA, CMV, HSV)','IMMUNOLOGY/SEROLOGY',1),
('26e72573-b61e-4bf0-99d8-aedbec95adc1','HSV 1&2 ELISA IGM','IMMUNOLOGY/SEROLOGY',1),
('2326d9c5-03d2-4061-8502-1e5c37fbceb6','HSV 1&2 ELISA IGG','IMMUNOLOGY/SEROLOGY',1),
('fa1b2c6c-16ea-497d-89bc-44062b34d3a5','TSH','THYROID FUNCTION TEST',1),
('81342b8c-ef42-4643-be0e-ee725fb24aeb','FT3','THYROID FUNCTION TEST',1),
('6a98f053-1cce-4022-b933-226f48d6a50b','FT4','THYROID FUNCTION TEST',1),
('e0c6da06-df0c-4d23-bf71-f9698dca00a5','T3','THYROID FUNCTION TEST',1),
('3470bc17-7828-4fa8-b299-74cb3ba9719b','T4','THYROID FUNCTION TEST',1),
('0f5b4ab1-128c-43c9-b68d-0eccdb758376','PSA','TUMOR MARKERS',1),
('a0d7166d-4b14-42dc-9fb8-5b0d45710514','AFP (LIVER CA)','TUMOR MARKERS',1),
('e7f3dc9d-733b-4746-81bc-2faac5865040','CEA (COLORECTAL CA)','TUMOR MARKERS',1),
('4533f6be-53f2-406e-8eac-579a07a729e0','CA 125 (OVARIAN CA)','TUMOR MARKERS',1),
('92ea2354-d409-43da-aea5-2f61d6445e09','CA 15-3 (BREAST CA)','TUMOR MARKERS',1),
('48835fc6-c2d7-4903-b740-dcfb9b06a2ce','CA 19-9 (PANCREATIC CA)','TUMOR MARKERS',1),
('f9d854fd-ca28-416f-98a3-04f27b784ae9','B-HCG (H-MOLE)','TUMOR MARKERS',1),
('82177263-9b28-4511-9575-e91ed27ce318','URINALYSIS','MICROSCOPY',1),
('b47df8c1-32d5-4aff-bb9f-7ced3783b022','FECALYSIS','MICROSCOPY',1),
('d9090ffa-93fe-4433-9b1e-8982e526040c','OCCULT BLOOD','microscopy',1),
('e0384fb1-499c-425f-8416-28e920644516','PREGNANCY TEST (URINE)','MICROSCOPY',1),
('7ed95363-2d29-491a-bce4-9a586b4f45d9','MICRAL TEST','MICROSCOPY',1),
('a1391200-0155-443f-8636-1b95063ef791','SPERM/SEMEN ANALYSIS','MICROSCOPY',1),
('4846f264-16aa-4a98-b5b8-c55f4d3c2fd7','KOH MOUNT','MICROSCOPY',1);
insert into `service_type_tbl` values 
('851f8c6d-ae73-48a0-81cb-7a4d95115873','FNAB (3-6 SIDES)','MICROSCOPY',1),
('c4d4bb0a-90d5-4865-89dd-e816c2e9db8b','SMALL HISTOPATH','HISTOPATHOLOGY',1),
('08037b8b-ec2d-4b02-850e-3ae224bed63d','MEDIUM HISTOPATH','HISTOPATHOLOGY',1),
('eceb736b-7439-432c-9b85-3b57f287cf02','LARGE HISTOPATH','histopathology',1),
('cebd6acd-7cf1-44e1-a085-46d6c166341b','EXTRA LARGE HISTOPATH','histopathology',1),
('4ec5c2cc-3ee1-4c9b-ac2c-9c7614008699','CULTURE & SENSITIVITY','BACTERIOLOGY',1),
('9c07e4b4-727c-4b5e-8c01-b30de7935254','CULTURE ONLY','BACTERIOLOGY',1),
('3882d30f-e3e1-4085-b6fa-c827cccff585','GRAM STAIN','BACTERIOLOGY',1),
('13731701-7bc9-4141-8c3d-02353d33c62c','AFB SMEAR','BACTERIOLOGY',1),
('12d9f4a3-96e0-4f83-acc7-0980bcabbe70','12 LEAD ECG','CARDIOVASCULAR PROCEDURE',1),
('d2cda657-3305-43dc-adcb-3908cd40b9f6','2D ECHOCARDIOGRAPHY','CARDIOVASCULAR PROCEDURE',1),
('083b2f56-81f5-4707-907b-fc5c6263fb7e','2D ECHO WITH DOPPLER','CARDIOVASCULAR PROCEDURE',1),
('0c2e924b-e5e8-4bd3-92d3-88e24290fdf8','PEDIATRIC 2D ECHO ','CARDIOVASCULAR PROCEDURE',1),
('0aeae0c8-711c-43f3-865b-090a538a11c3','CHEST PA','X-RAY',1),
('0d27f105-a5de-4b56-8380-28aa521ba341','CHEST LATERAL','X-RAY',1),
('affc881a-766d-46f1-8f05-81243c63854f','CHEST APICOLORDOTIC','X-RAY',1),
('11af803d-522f-46fd-9906-f9796cec03a7','CHEST PA-LATERAL','X-RAY',1),
('8c23e4fc-604b-4d2c-baa4-2177eb2898d3','CHEST PA-APICOLORDOTIC','X-RAY',1),
('e6935be1-d630-49d2-adb5-29da193eeb43','CHEST AP-LAT (PEDIA)','X-RAY',1),
('6df659bb-b615-46db-8c68-7f2063bcf0c1','CONED DOWN VIEW','X-RAY',1),
('99b7c6ca-f716-42c3-961c-86257fcbc6e5','RIB CAGE','X-RAY',1),
('09d0b388-52e6-4bc0-b58e-855d75a99468','SKULL','X-RAY',1),
('2703182c-6248-4d60-aaa0-f1d9249a87eb','PARANASAL SINUS','X-RAY',1),
('79ca804a-3a1e-4b24-8ca0-3ba283c9d9cf','CERVICAL SPINE','X-RAY',1),
('337e9a68-cfad-41de-8c9b-e9d4a7113471','THORACIC SPINE','X-RAY',1),
('0185f476-fda3-4f17-8e79-474509ac9fd8','THORACOLUMBAR SPINE','X-RAY',1),
('3cc3441e-da76-483a-a15b-f138436f3987','LUMBOSACRAL SPINE','X-RAY',1),
('69018df7-5518-4d93-af54-d6979b6bb69d','CLAVICLE','X-RAY',1),
('8f1d07e8-16cc-46a6-adeb-712a54da6985','SHOULDER (ONE SIDE)','X-RAY',1),
('134efac5-0a05-4208-a52d-80df3d236e94','ELBOW','X-RAY',1),
('8b5d5aea-3e16-4b0f-a437-3431fedada94','HUMERUS/FOREARM','X-RAY',1),
('b6bf8792-58c5-4850-9ce8-031f07815055','HAND','X-RAY',1),
('218c22d1-438f-4dcc-8a2f-c02cbac9efff','PELVIS X-RAY','X-RAY',1),
('8aa61b2e-d7a9-40f3-bb78-f0f2961f6ffd','HIP JOINT (ONE SIDE)','X-RAY',1),
('187ae4ca-9c87-4c81-8d21-915d1d7349f5','KNEE','X-RAY',1),
('6d438b68-db6a-4ae5-bd61-aa1aac59e9c2','FEMUR/TIBIA','X-RAY',1),
('06ac3166-881f-4343-861e-acd51d577140','ANKLE/FOOT','X-RAY',1),
('4772b0aa-0d94-499b-8de2-73b499dd1c37','PLAIN ABDOMEN','X-RAY',1),
('5ca9f1bc-5bae-47e4-b903-0cd7109ed5b5','KUB','X-RAY',1),
('7e6996a2-d92b-4559-856b-a8c92db2ad47','TRANSVAGINAL','ULTRASONOGRAPHY',1),
('9d829319-00eb-4644-af35-6a4da48b7992','TRANSRECTAL','ULTRASONOGRAPHY',1),
('2f7068fe-f668-4c44-a0f2-56bbb3fe9d21','CONGENITAL ANOMALY SCAN (2D)','ULTRASONOGRAPHY',1),
('ce863a6a-3dc8-4e6b-9f75-1ca8af17d6b1','CONGENITAL ANOMALY SCAN (3D)','ULTRASONOGRAPHY',1),
('8cf1ac4e-84cb-41c6-9142-0c2c5e8e60df','BIOPHYSICAL SCAN (BPS)','ULTRASONOGRAPHY',1),
('b60b7457-5ff5-45ba-80b5-2bd7b3b5018c','BREASTS','ULTRASONOGRAPHY',1),
('b4fdc17e-3d59-46f5-8a7f-323c340458a8','THYROID','ULTRASONOGRAPHY',1),
('278a391b-5ebf-4829-9418-4f794ea39342','ABDOMINAL AORTA','ULTRASONOGRAPHY',1),
('79448c95-1fba-4392-9109-c14872b6a2c5','ADRENALS ','ULTRASONOGRAPHY',1),
('d15c797a-d3ce-4dad-ae88-24a3d533d3f9','SCROTAL SAC & CONTENTS','ULTRASONOGRAPHY',1),
('25364c14-4db4-41a1-92b1-ed15d1bfe9cc','SCROTAL WITH DOPPLER','ULTRASONOGRAPHY',1),
('af35d7a5-f356-4c68-8b40-37db684b5850','PROSTATE','ULTRASONOGRAPHY',1),
('d4f9073c-df92-4fc5-b107-e355113e737d','CHEST','ULTRASONOGRAPHY',1),
('0abb9f7f-90cc-4846-b1e4-89df23a76dac','KUB','ULTRASONOGRAPHY',1),
('0bffbde7-9148-43fe-a687-d7e9781ac869','ANY ONE ORGAN','ULTRASONOGRAPHY',1),
('72c15001-1743-4316-85a7-96b5808c38a4','ANY TWO ORGANS','ULTRASONOGRAPHY',1),
('5f980aae-7ade-475d-b712-8b51b9ea7340','ANY THREE ORGANS','ULTRASONOGRAPHY',1),
('3cd3a089-0673-44f4-a71b-120121e85158','ANY FOUR ORGANS','ULTRASONOGRAPHY',1),
('49ca84ce-bdf2-4bfa-b7b7-75f3c6d16c7d','UPPER ABDOMEN','ULTRASONOGRAPHY',1),
('3f5f79a1-2b7f-45a3-9f2d-b4afc91ececc','LOWER ABDOMEN','ULTRASONOGRAPHY',1),
('cf7c5633-7936-43dd-a32a-b4a1f4a1c5dc','WHOLE ABDOMEN','ULTRASONOGRAPHY',1),
('bf3ce230-e796-44fe-9bd0-af19708120db','PELVIC UTZ','ULTRASONOGRAPHY',1),
('1a9ee895-315f-422f-bbe1-9cc8da437e06','OB, FAMILY MEDICINE','CONSULTATION',1),
('2fc788af-bbd2-48f8-8639-20d604d61cc4','IM & OTHER SPECIALTIES','CONSULTATION',1),
('de5841ed-cc32-45d4-b7c3-b09133303c86','LDL','BLOOD CHEMISTRY',1),
('9d4e8055-8b8a-44db-ba73-9734643266dc','DIRECT BILIRUBIN','BLOOD CHEMISTRY',1),
('7639d49f-3960-45cd-a325-681349f2ce2a','INDIRECT BILIRUBIN','BLOOD CHEMISTRY',1),
('34734244-5aea-4b45-a041-3d5a9ffba81f','FLAVORED OGTT','BLOOD CHEMISTRY',1),
('1d388981-9e29-4152-9b7a-04de2094a7ec','TOTAL IRON','ENZYMES',1),
('c5195abb-1792-4947-8e82-761c650a47d3','TROPONIN I','ENZYMES',1),
('43b68d16-a307-4174-bfcb-e28e59a76144','TROPONIN I','ENZYMES',1),
('29141ba4-4c5f-47a5-b94b-39be171aa6c6','CMV IGM','IMMUNOLOGY/SEROLOGY',1),
('15ed8bf2-fd24-4a66-bd84-8496b85e83d2','CMV IGG','IMMUNOLOGY/SEROLOGY',1),
('a97eb2fd-6431-4a6c-bcea-292207bbc54d','TOXOPLASMA IGM','IMMUNOLOGY/SEROLOGY',1),
('21ab0fb1-15cf-4021-9a07-fee10efb9ff5','PSA W/TITER','TUMOR MARKERS',1),
('061b743b-43a7-4459-b484-f6566d1313e6','SERUM PREGNANCY TEST','MICROSCOPY',1),
('02803242-352a-4734-b91d-688c8713b4d8','CULTURE & SENSITIVITY','BACTERIOLOGY',1),
('69172c3c-0bf7-42aa-8104-768bca090e12','CULTURE ONLY','BACTERIOLOGY',1),
('91022201-5900-4a39-91f3-ecdc987d2782','GRAM STAIN','BACTERIOLOGY',1),
('829e0570-f5fd-483c-962c-d41f553c4040','AFB SMEAR','BACTERIOLOGY',1),
('e20a9e4f-764d-431f-a92b-b7823ba5fc4a','URINE CULTURE AND SENSITIVITY','BACTERIOLOGY',1),
('8c22f05b-1dae-476a-b8ca-50a6efbd944d','CD COPY','ULTRASONOGRAPHY',1),
('4a0f32dc-1ec4-4fef-af1d-fa8f50931971','FOOT','RADIOGRAPHY',1),
('2155ac8c-6873-48fa-8e80-075cd7631725','WHOLE ABDOMEN','ULTRASONOGRAPHY',1),
('45ec9bb6-d53b-4bb3-a726-ee3cddf0a3f9','PELVIC','ULTRASONOGRAPHY',1),
('14e9ba83-d348-4221-8b70-ad74d2f06eae','CONGENITAL ANOMALY SCAN (3D)','ULTRASONOGRAPHY',1),
('bbced356-4603-4f8e-8b4d-e9d33ec8d90c','OB-GYNECOLOGY','CONSULTATION',0),
('5d219d04-5514-4550-8d46-fb2bb98020e1','PEDIATRICS','CONSULTATION',0),
('c7f2aa62-650d-47c2-a897-89e4e79928c4','FAMILY MEDICINE','CONSULTATION',0),
('c9d4f51a-db53-419d-8adc-debdc34a5e78','IM-PULMONOLOGY','CONSULTATION',0),
('59a82e69-4596-4b8f-8b0d-d0a618b45a40','IM-NEPHROLOGY','CONSULTATION',0),
('f0dcd054-37d2-46cf-a231-e5c6ecc71561','IM-GASTROENTEROLOGY','CONSULTATION',0),
('6a1cb80d-fb5b-4a09-907f-6bee80c2beb7','IM-CARDIOLOGY','CONSULTATION',0),
('b1cab60c-01a8-45b5-b2b5-7c08e1311246','IM-INTERNAL MEDICINE','CONSULTATION',0),
('4859ec66-dcd7-4b5b-b076-c1ab041bc98d','E.N.T.','CONSULTATION',0),
('815ac820-41c8-4d5c-9377-b184fbc7e1a0','SURG-UROLOGY','CONSULTATION',0),
('799a09db-fcce-4c07-86d6-d2c56780792e','SURG-ORTHOPEDIC','CONSULTATION',0),
('5ddb71dc-20a9-46df-bdf8-53c2af4874f6','DRUG TESTING','ENZYMES',1),
('b2def962-fb82-4ff4-b1f3-58cd5135d22b','PHYSICAL EXAM W/CERTIFICATE','CONSULTATION',1),
('a85c0d9f-2e06-488c-a2e0-518b78ba8aa9','COMPLETE URINALYSIS','MICROSCOPY',1),
('ae4a2785-407a-4d42-8f98-d2dc815f605d','FASTING BLOOD SUGAR (FBS)','BLOOD CHEMISTRY',1),
('f5214d23-9a20-48ea-8929-7217bdc36ebb','BILIRUBIN (TB, ID, DB)','ENZYMES',1);

/*Table structure for table `specialization_tbl` */

DROP TABLE IF EXISTS `specialization_tbl`;

CREATE TABLE `specialization_tbl` (
  `spec_id` varchar(50) default NULL,
  `spec_name` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `specialization_tbl` */

insert into `specialization_tbl` values 
('72f6c754-70be-449b-b2ea-4a95df5ef1e7','GASTROENTEROLOGY'),
('adb8b2b1-4aec-4943-a9b1-5575f95558a0','FAMILY MEDICINE'),
('ae532009-395a-48cc-8bfe-c6a90155b368','PEDIATRIC'),
('94823a50-b2f8-4af7-8e79-e6d06559720d','OB-GYN'),
('a0515d6d-587c-4447-9c9f-bd959a5a1258','RADIOLOGIST'),
('16da7675-dc34-484f-be96-f0dfc3e59a6a','ORTHOPEDIC SURGERY'),
('63ed4998-8327-4a39-b051-0d61997d08fd','OB-SONOLOGY'),
('8c3d9aea-f423-45d9-87b6-de0cf0ead632','UROLOGY'),
('4f1158fc-5eba-4a2c-947d-123cc69f8db8','NEPHROLOGY'),
('7477b18a-0a07-46f4-8b55-2c8818a590bb','PULMONOLOGY'),
('50c36df6-472f-4d7e-827d-a2a8587bd05e','CARDIOLOGY'),
('11914c57-2cf3-4ea8-80f3-0759f09bee88','PEDIATRIC CARDIOLOGY');

/*Table structure for table `staff_tbl` */

DROP TABLE IF EXISTS `staff_tbl`;

CREATE TABLE `staff_tbl` (
  `record_id` varchar(50) default NULL,
  `name` varchar(50) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `staff_tbl` */

insert into `staff_tbl` values 
('c1dcdfbc-4298-4f84-b3ce-ea4d6ebb6ccc','MICHAEL BUENDIA'),
('00a84e90-cc0e-4ea0-a4ce-578a23f00b1f','SHERRY MALIMBAN'),
('00c913d5-f56b-40b7-8e59-46f9149e1a1e','RECHELLE RAMOS'),
('5135020b-eda2-4547-9774-973e95d12b82','ANTONETTE SALAS'),
('196b03dd-ac68-45f5-894d-23ac4364892f','MARIA LYNDENJIM NERMAL'),
('1c333577-92f2-4c7f-9455-941e8cf50d5d','EDELTRUDES SUARIN');

/*Table structure for table `user_tbl` */

DROP TABLE IF EXISTS `user_tbl`;

CREATE TABLE `user_tbl` (
  `User_id` varchar(50) default NULL,
  `u_name` varchar(50) default NULL,
  `Username` varchar(20) NOT NULL,
  `Passwords` varchar(20) default NULL,
  `Position` varchar(15) default NULL,
  `contact` varchar(11) default NULL,
  PRIMARY KEY  (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user_tbl` */

insert into `user_tbl` values 
('9145eca2-78ad-4b4a-ae02-2dd55e1b9037','Kristine Sanceja','ksanceja','Tokyo8love','ADMINISTRATOR','09228107951'),
('73378b2d-e500-4005-a1fd-8239957cb628','Michael Buendia','mbuendia','michael','Receptionist',''),
('6fd70d7b-487b-41fd-b5fd-61d25e2bf318','Rechelle Ramos','rramos','123456','Cashier',''),
('1642634d-ef6c-4763-8c9a-f387eb257ea7','Sherry D. Malimban','smalimban','sherryd','Receptionist',''),
('','wilver','wilver','wilver','ADMINISTRATOR',''),
('','wilver1','wilver1','wilver1','Receptionist',''),
('','wilver2','wilver2','wilver2','Cashier','');
