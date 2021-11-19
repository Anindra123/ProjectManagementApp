create table ManageProject_TBL(
Project_ID INT identity(1,1) constraint mprid_pk primary key,
Project_Title varchar(100) not null,
Project_Desc varchar(1000) not null,
Project_StartDate date not null,
Project_EndDate date not null,
PStatus_ID int foreign key references ProjectStatus_TBL(PStatus_ID),
PManager_ID int foreign key references PManager_TBL(PManager_ID)
)