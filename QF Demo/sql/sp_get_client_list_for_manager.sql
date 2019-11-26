create or alter procedure GetClientListForManager
(
@UserName as nvarchar(200)
)
as
begin
	select 
		c.UserId as 'ClientUserId',
		u.UserName as 'ClientUsername',
		u.Email as 'ClientEmail',
		u.Alias as 'ClientAlias',
		u.FirstName as 'ClientFirstName',
		u.LastName as 'ClientLastName',
		c.Level as 'Level'
	from
		Manager_Client_Mapping mcm
		join Clients c
		on mcm.ClientId = c.UserId
		join Users u
		on u.UserId = c.UserId
		join Users u2
		on u2.UserId = mcm.ManagerId
	where u2.UserName = @UserName
end