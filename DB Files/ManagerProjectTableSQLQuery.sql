create table PManager_TBL(
PManager_ID int identity(1,1) constraint pmid_pk primary key,
PManager_FirstName varchar(100) not null,
PManager_LastName varchar(100) not null,
PManager_Password nvarchar(10) not null,
PManager_Email nvarchar(50) unique not null
)
drop table ManageProject_TBL
create table ManageProject_TBL(
Project_ID INT identity(1,1) constraint mprid_pk primary key,
Project_Title varchar(100) not null,
Project_Desc varchar(1000) not null,
Project_StartDate date not null,
Project_EndDate date not null,
PStatus_ID int foreign key references ProjectStatus_TBL(PStatus_ID),
PManager_ID int foreign key references PManager_TBL(PManager_ID)
)