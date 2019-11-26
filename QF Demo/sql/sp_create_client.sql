create or alter procedure CreateClient
(
	@UserName as nvarchar(200),
	@Email as nvarchar(1000),
	@Alias as nvarchar(1000),
	@FirstName as nvarchar(1000),
	@LastName as nvarchar(1000),
	@Level as int
)

as
begin 

insert into Users
(
	UserName,
	Email,
	Alias,
	FirstName,
	LastName
)
values
(
	@UserName,
	@Email,
	@Alias,
	@FirstName,
	@LastName
)

declare @NewUserId int = (select top 1 UserId from Users order by UserId desc);

insert into Clients
(
	UserId,
	Level
)
values
(
	@NewUserId,
	@Level
)

end;