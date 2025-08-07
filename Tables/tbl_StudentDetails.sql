create table tbl_StudentDetails
(
	Id int identity(1,1) not null,
	Name varchar(100) not null,
	Dob datetime not null,
	Gender varchar(10) not null,
	Email nvarchar(100) not null,
	Phone nvarchar(15) not null,
	Address nvarchar(200) not null,
	primary key(Id)
);