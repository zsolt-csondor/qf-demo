create or alter procedure GetAllManagersWithClients
as
begin

select 
	u2.UserId as 'ManagerUserId',
	u2.UserName as 'ManagerUsername',
	u2.Email as 'ManagerEmail',
	u2.Alias as 'ManagerAlias',
	u2.FirstName as 'ManagerFirstName',
	u2.LastName as 'ManagerLastName',
	p.Name as 'ManagerPosition',
	u.UserId as 'ClientUserId',
	u.UserName as 'ClientUsername',
	u.Email as 'ClientEmail',
	u.Alias as 'ClientAlias',
	u.FirstName as 'ClientFirstName',
	u.LastName as 'ClientLastName',
	c.Level as 'Level'
from
	Manager_Client_Mapping mcm
	join Clients c
	on
	c.UserId = mcm.ClientId
	join Users u
	on
	mcm.ClientId = u.UserId
	join Users u2
	on
	mcm.ManagerId = u2.UserId
	join Managers m
	on
	m.UserId = mcm.ManagerId
	join Positions p
	on
	p.Id = m.PositionType

end