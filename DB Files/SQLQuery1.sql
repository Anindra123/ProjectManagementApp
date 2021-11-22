create table PMember_TBL(
PMember_ID INT identity(1,1) constraint pid_pk primary key,
PMember_FirstName varchar(100) not null,
PMemeber_LastName varchar(100) not null,
PMember_Password nvarchar(8) not null,
PMember_Email varchar(50) not null
)

drop table PMember_TBL
create table PGroup_TBL(
PGroup_ID int identity(1,1) constraint gid_pk primary key ,
PGroup_Name varchar(50),
PGroup_MembersCount int
)

exec sp_rename '[PMember_TBL].[PMemeber_LastName]', 'PMember_LastName','COLUMN'

select * from PMember_TBL

create table PMemberGroupInfo_TBL(
PMember_ID INT constraint pgid_pk primary key,
PMember_FirstName varchar(100) not null,
PMember_LastName varchar(100) not null,
PMember_Password nvarchar(8) not null,
PMember_Email varchar(50) not null,
PGroup_ID int foreign key references PGroup_TBL(PGroup_ID)
)