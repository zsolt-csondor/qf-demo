create or alter procedure GetAllClients
as
begin
	select
		c.UserId as 'UserId',
		UserName as 'UserName',
		Email as 'Email',
		Alias as 'Alias',
		FirstName as 'FirstName',
		LastName as 'LastName',
		Level as 'Level'
	from
		Clients c
		join Users u
		on c.UserId = u.UserId
end