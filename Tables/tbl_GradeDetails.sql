create table tbl_GradeDetails
(
	Id int identity(1,1) not null,
	StudentId int not null,
	CourseId int not null,
	Score decimal(3,2) not null,
	LetterGrade varchar(2) not null,
	primary key(Id)
);