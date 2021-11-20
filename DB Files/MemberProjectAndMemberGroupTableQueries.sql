create table PMemberProjectInfo_TBL(
PMember_ID INT identity(1,1) constraint pmpid_pk primary key,
PMember_FirstName varchar(100) not null,
PMemeber_LastName varchar(100) not null,
PMember_Password nvarchar(8) not null,
PMember_Email varchar(50) not null,
Project_ID int foreign key references Project_TBL(Project_ID)
)

create table GroupContainsProject_TBL(
PGroup_ID int identity(1,1) constraint gcpid_pk primary key ,
PGroup_Name varchar(50),
PGroup_MembersCount int,
Project_ID int foreign key references Project_TBL(Project_ID)
)