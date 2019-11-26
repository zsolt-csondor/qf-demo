create or alter procedure DeleteUser
(
	@id int
)
as
begin

	--Let's not care whether the user is a manager or a client, we just
	--want to delete their record
	if exists(select UserId from Managers where UserId = @id)
		begin
			delete from Manager_Client_Mapping where ManagerId = @id
			delete from Managers where UserId = @id
		end
	else if exists(select UserId from Clients where UserId = @id)
		begin
			delete from Manager_Client_Mapping where ClientId = @id
			delete from Clients where UserId = @id
		end
	else
		return -1 --No such user exists

	delete from Users where UserId = @id

end


