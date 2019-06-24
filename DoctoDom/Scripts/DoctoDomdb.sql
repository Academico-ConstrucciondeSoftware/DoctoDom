use master
go

create database DoctoDom
go

use DoctoDom
go

create table DocServices
(
	Id int primary key identity(1,1),
	ServiceName varchar(100) not null,
	DescripctionServices varchar(250) null
)
go
create table Specialties
(
	Id int primary key identity(1,1),
	SpecialtiesName varchar(100) not null,
	SpecialtiesDescripction varchar(250) null
)

go
create table Users
(
	Id int primary key identity(1,1),
	UserName varchar(80) not null,
	LastName varchar(80) not null,
	Cedula varchar(13) not null,
	Phone1 varchar(20) null,
	Phone2 varchar(20) null,
	Birthdate datetime not null,
	UserAddres varchar(250) null,
	Email varchar(60) null,
	Nickname varchar(10) not null,
	UserPassword varchar(20) not null,
	UserType int not null,
	Specialties int null,
	ImagePath varchar(500) null,
	CreatedDate datetime default getdate()
)

go
create table Quotes
(
	Id int primary key identity(1,1),
	QuotesDescription varchar(250) not null,
	QuotesDate Datetime not null,
	UserId int not null,
	Specialties int not null
)


SELECT * FROM Quotes;
SELECT * FROM Users;
SELECT * FROM Specialties;
SELECT * FROM DocServices;