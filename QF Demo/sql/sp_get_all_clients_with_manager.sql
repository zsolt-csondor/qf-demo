create or alter procedure GetAllClientsWithManagers
as
begin
	select 
		u.UserId as 'ClientUserId',
		u.UserName as 'ClientUsername',
		u.Alias as 'ClientEmail',
		u.Alias as 'ClientAlias',
		u.FirstName as 'ClientFirstName',
		u.LastName as 'ClientLastName',
		c.Level as 'Level',
		u2.UserId as 'ManagerUserId',
		u2.UserName as 'ManagerUsername',
		u2.Email as 'ManagerEmail',
		u2.Alias as 'ManagerAlias',
		u2.FirstName as 'ManagerFirstName',
		u2.LastName as 'ManagerLastName',
		p.Name as 'Position'
	from
		Manager_Client_Mapping mcm
		join Clients c
		on c.UserId = mcm.ClientId
		join Users u
		on u.UserId = mcm.ClientId
		join Users u2
		on
		u2.UserId = mcm.ManagerId
		join Managers m
		on 
		m.UserId = mcm.ManagerId
		join Positions p
		on
		m.PositionType = p.Id
end