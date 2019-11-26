create or alter procedure MapManagerToClient
(
	@ManagerId as int,
	@ClientId as int
)
as
begin

if exists(select UserId from Managers where UserId = @ManagerId) and exists(select UserId from Clients where UserId = @ClientId)
	insert into Manager_Client_Mapping
	(
		ManagerId,
		ClientId
	)
	values
	(
		@ManagerId,
		@ClientId
	)
else
	return -1

end