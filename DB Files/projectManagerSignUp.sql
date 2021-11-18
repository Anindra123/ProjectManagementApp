DROP TABLE PManager_TBL;
DROP TABLE Task_TBL;
DROP TABLE AssignTask_TBL;
DROP TABLE PerformTask_TBL;
DROP TABLE TaskStatus_TBL;

CREATE TABLE PManager_TBL
(
	PMananger_ID int IDENTITY(1,1) PRIMARY KEY,
	PManager_FirstName varchar(100)  NOT NULL,
	PManager_LastName varchar(100) NOT NULL,
	PManager_Email nvarchar(50) NOT NULL UNIQUE,
	PManager_Password nvarchar(10) NOT NULL,
);

CREATE TABLE TaskStatus_TBL
(
	StatusID int IDENTITY(1,1) PRIMARY KEY,
	StatusName varchar(1) NOT NULL 
);

CREATE TABLE Task_TBL
(
	Task_ID int IDENTITY(1,1) PRIMARY KEY,
	Task_title varchar(100)  NOT NULL,
	Task_Desc varchar(100) NOT NULL,
	Task_CompleteDate int FOREIGN KEY REFERENCES TaskStatus_TBL(StatusID),
	Task_Attached varchar(100) NOT NULL,
	Task_Comment varchar(1000) NOT NULL,
	Project_ID int FOREIGN KEY REFERENCES TaskStatus_TBL(StatusID)
);

CREATE TABLE AssignTask_TBL
(
	Task_ID int IDENTITY(1,1) PRIMARY KEY,
	Task_title varchar(100)  NOT NULL,
	Task_Desc varchar(100) NOT NULL,
	Task_CompleteDate int FOREIGN KEY REFERENCES TaskStatus_TBL(StatusID),
	Task_Attached varchar(100) NOT NULL,
	Task_Comment varchar(1000) NOT NULL,
	PManager_ID int FOREIGN KEY REFERENCES TaskStatus_TBL(StatusID)
);

CREATE TABLE PerformTask_TBL
(
	Task_ID int IDENTITY(1,1) PRIMARY KEY,
	Task_title varchar(100)  NOT NULL,
	Task_Desc varchar(100) NOT NULL,
	Task_CompleteDate int FOREIGN KEY REFERENCES TaskStatus_TBL(StatusID),
	Task_Attached varchar(100) NOT NULL,
	Task_Comment varchar(1000) NOT NULL,
	PMember_ID int FOREIGN KEY REFERENCES TaskStatus_TBL(StatusID)
);

INSERT INTO TaskStatus_TBL (StatusName) VALUES
('P'), ('C')

INSERT INTO PManager_TBL (
PManager_FirstName, PManager_LastName, PManager_Email, PManager_Password
) VALUES (
'abcde', 'bcdef', 'abcde@gmail.com', 'abcde'
),
(
'fghij', 'fghij', 'fchij@gmail.com', 'fghij'
),
(
'fghij', 'fghij', 'jklmnop@gmail.com', 'fghij'
),
(
'qwerty', 'qwerty', 'qwerty@gmail.com', 'qwerty'
)






