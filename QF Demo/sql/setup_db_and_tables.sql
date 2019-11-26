--The database and tables needed for the demo
use master

create database Demo
go

use Demo
go

CREATE TABLE [Users] 
(
 [UserId] INT IDENTITY (1, 1) NOT NULL,
 [UserName] NVARCHAR (200) NOT NULL,
 [Email] NVARCHAR (1000) NULL,
 [Alias] NVARCHAR (1000) NULL,
 [FirstName] NVARCHAR (1000) NULL,
 [LastName] NVARCHAR (1000) NULL
 CONSTRAINT [PK_Domain.Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
)

create table Positions 
(
	Id int,
	Name nvarchar(150) not null,

	constraint PK_Positions_Id primary key clustered(Id)
)

insert into Positions
(
	Id,
	Name
)
values 
(1, 'Junior'),
(5, 'Senior')

create table Managers 
(

	UserId int,
	PositionType int

	constraint PK_Managers_UserId primary key clustered(UserId),
	constraint FK_Managers__Positions_UserId foreign key(UserId) references Users(UserId)
)


create table Clients
(
	UserId int,
	Level int,

	constraint PK_Clients_UserId primary key clustered(UserId),
	constraint FK_Clients__Users_UserId foreign key(UserId) references Users(UserId)
)

create table Manager_Client_Mapping
(
	Id int identity(1,1) not null,
	ManagerId int,
	ClientId int

	constraint PK_Id primary key clustered(Id),
	constraint FK_Manager_Client_Mapping__Managers foreign key(ManagerId) references Managers(UserId),
	constraint FK_Manager_Client_Mapping__Clients foreign key(ClientId) references Clients(UserId),
	constraint UQ_Index unique(ManagerId, ClientId)
)

