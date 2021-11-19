create table PManagerGroupInfo_TBL(
PGroup_ID int constraint pmgi_pk primary key,
PGroup_MembersCount int default 0 not null,
PGroup_name varchar(50) not null,
PManager_ID int foreign key references PManager_TBL(PManager_ID)
)

