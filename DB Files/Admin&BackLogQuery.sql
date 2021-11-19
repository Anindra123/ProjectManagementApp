create table Admin(
Admin_Name varchar(100) not null,
Admin_Pass nvarchar(8) not null
)

create table BackLog(
BackLog_ID int IDENTITY(1,1) constraint bl_pk primary key,
BackLog_ProjectTitle varchar(100) not null,
BackLog_GroupName varchar(100) not null,
BackLog_TaskTitle varchar(100) not null,
BackLog_TaskCompletedby varchar(100) not null
)

