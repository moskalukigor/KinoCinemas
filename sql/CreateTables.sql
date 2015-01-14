create table Cinemas(
	Id int not null identity(1,1),
	Name nvarchar(128),
	primary key (Id)
);


create table Movie(
	Id int not null identity(1,1),
	Name nvarchar(128),
	Genre nvarchar(64),
	Price decimal not null,
	Lenght decimal not null,
	CinemaId int not null,
	Foreign key (CinemaId) References Cinemas(Id)
);


