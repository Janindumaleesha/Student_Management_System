create table tbl_CourseDetails
(
	Id int identity(1,1) not null,
	Name varchar(100) not null,
	Code nvarchar(20) not null,
	Description nvarchar(500) null,
	Credits int not null,
	primary key(Id)
);