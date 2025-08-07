create table tbl_TeacherDetails
(
	Id int identity(1,1) not null,
	Name varchar(100) not null,
	Email nvarchar(100) not null,
	Phone nvarchar(15) not null,
	primary key(Id)
);