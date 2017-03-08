Use Master
Go
If Exists (Select * from sys.databases where name = 'BBLABS')
DROP DATABASE BBLABS
Go
Create Database BBLABS
Go

Use BBLABS
Go
-- --------------------------------------------------------
--
-- Table structure for table `bb_user`
--

--
-- Table structure for table contact
--

CREATE TABLE tblBLOB
(
	BLOBID int IDENTITY PRIMARY KEY,
    BLOBData IMAGE NOT NULL,
    BLOBName varchar(30) DEFAULT NULL
);


CREATE TABLE contact (
  CONTACT_ID int IDENTITY PRIMARY KEY,
  STUDENT_NUMBER varchar(8) DEFAULT NULL,
  PERSONAL_NUMBER varchar(13) DEFAULT NULL,
  ID_NUMBER varchar(13) DEFAULT NULL,
  CELL_PHONE varchar(10) DEFAULT NULL,
  EMAIL varchar(40) DEFAULT NULL,
  TEL_NUMBER varchar(10) DEFAULT NULL,
  ADDRESS varchar(100) DEFAULT NULL
);
-- --------------------------------------------------------

CREATE TABLE bb_user (
  USER_ID int IDENTITY PRIMARY KEY,
  USERNAME varchar(30) NOT NULL,
  PASSWORD varchar(20) NOT NULL,
  ACCESS_LEVEL int NOT NULL DEFAULT 1,
  TYPE int NOT NULL DEFAULT 1,
  NAME varchar(30) NOT NULL,
  SURNAME varchar(45) NOT NULL,
  STATUS int NOT NULL DEFAULT 1
);

-- --------------------------------------------------------

--
-- Table structure for table device
--

CREATE TABLE device (
  DEVICE_ID int IDENTITY PRIMARY KEY,
  CATEGORY int NOT NULL,
  IMIE_NUMBER varchar(30) NULL,
  DEVICE_NAME varchar(30) NOT NULL,
  SERIAL varchar(30) NULL,
  DEVICE_PIN varchar(30) NULL,
  DEVICE_TEL varchar(10) NULL,
  DEVICE_EMAIL varchar(30) NULL,
  DEVICE_PASSWORD varchar(30) NULL,
  MODEL_NUMBER varchar(30) NULL,
  DEVICE_STATUS int NOT NULL DEFAULT 1,
  BLOBID int references tblBLOB(BLOBID),
  DATE_ADDED date NOT NULL
);

-- --------------------------------------------------------
--
-- Table structure for table `audit_log`
--
CREATE TABLE audit_log 
(
  LOG_ID int IDENTITY PRIMARY KEY,
  USER_ID int NOT NULL references bb_user(USER_ID),
  ACTION varchar(200) NULL,
  AUDIT_DATE date NOT NULL,
  IMIE_NUMBER varchar(30) NULL
);
-- --------------------------------------------------------
--
-- Table structure for table event
--
CREATE TABLE event (
  EVENT_ID int IDENTITY PRIMARY KEY,
  CREATOR int NOT NULL references bb_user(USER_ID),
  LAB_USER int NOT NULL references bb_user(USER_ID),
  EVENT_NAME varchar(30) NOT NULL,
  COMMENTS varchar(500) NOT NULL,
  CREATION_DATE date NOT NULL,
  EVENT_DATE date NOT NULL,
  VENUE varchar(50) NOT NULL,
  PARTICIPANTS varchar(500) DEFAULT NULL,
  EVENT_STATUS int NOT NULL DEFAULT 1
);
-- --------------------------------------------------------
--
-- Table structure for table locker
--

CREATE TABLE locker (
  LOCKER_ID int IDENTITY PRIMARY KEY,
  KEY_ONE_USER int references bb_user(USER_ID) NULL,
  KEY_TWO_USER int references bb_user(USER_ID) NULL,
  LOCKER_STATUS int NOT NULL DEFAULT 1,
  LOCKER_NAME varchar(30) NOT NULL,
  DATE_FROM date NULL,
  DATE_TO date NULL
);

CREATE TABLE lockerItem (
  LOCK_ITEM_ID int IDENTITY PRIMARY KEY,
  LOCKER_ID int references locker(LOCKER_ID),
  DEVICE_ID int references device(DEVICE_ID),
  LOCK_ITEM_STATUS int NOT NULL DEFAULT 1
);

CREATE TABLE announcement (
  ANN_ID int IDENTITY PRIMARY KEY,
  USER_ID int NOT NULL references bb_user(USER_ID),
  DATE_POSTED date NOT NULL,
  HEADING varchar(30) DEFAULT NULL,
  MESSAGE varchar(1500) DEFAULT NULL
);

CREATE TABLE closedLockerItem
(
	closedLockID int IDENTITY PRIMARY KEY,
	DEVICE_ID int references device(DEVICE_ID),
	USER_ID int references bb_user(USER_ID) NULL,
	DATE_FROM date NULL,
	DATE_TO date NULL
);
