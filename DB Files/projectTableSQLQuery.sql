create table ProjectStatus_TBL(
PStatus_ID INT identity(1,1) constraint psid_pk primary key,
PStatus_Name varchar(2)
)
create table Project_TBL(
Project_ID INT identity(1,1) constraint prid_pk primary key,
Project_Title varchar(100) not null,
Project_Desc varchar(1000) not null,
Project_StartDate date not null,
Project_EndDate date not null,
PStatus_ID int foreign key references ProjectStatus_TBL(PStatus_ID)
)
insert into ProjectStatus_TBL
(PStatus_Name) values ('C')
insert into ProjectStatus_TBL 
(PStatus_Name) values ('NC')


 