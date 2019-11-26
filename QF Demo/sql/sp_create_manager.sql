create or alter procedure CreateManager
(
	@UserName as nvarchar(200),
	@Email as nvarchar(1000),
	@Alias as nvarchar(1000),
	@FirstName as nvarchar(1000),
	@LastName as nvarchar(1000),
	@PositionType as int
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

insert into Managers
(
	UserId,
	PositionType
)
values
(
	@NewUserId,
	@PositionType
)

end;