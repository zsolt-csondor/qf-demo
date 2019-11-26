--Run this script to fill the database with some dummy data

--Creating clients
exec CreateClient 'Mengyao', null, 'Miya', 'Mengyao', 'Zheng', 1
exec CreateClient 'Zsozso', null, null, 'Zsolt', 'Csondor', 0
exec CreateClient 'Gyuszko', null, 'Padre', 'Gyula', 'Csondor', 1
exec CreateClient 'Johnny123', 'johnny@fakeemails.com', 'Johnny', 'Johnny', 'Smith', 2
exec CreateClient 'Andrea', 'andi@fakeemails.com', 'Mum', 'Andrea', 'Kontor', 500
exec CreateClient 'Imruska', 'vimre@fakeemails.com', 'Imi', 'Imre', 'Varga', 2
exec CreateClient 'Somci', 'ksoma@fakeemails.com', 'Soma', 'Zoltan', 'Karpati', 2

--Creating managers
exec CreateManager 'Bill', 'momoney@gettingthatcash.com', '$', 'Bill', 'Gates', 5
exec CreateManager 'Gerchik', 'gmoshes@lotsofmoney.com', 'Gera', 'German', 'Moshes', 0
exec CreateManager 'Joe', 'joe@someprovider.com', 'Joe', 'Joe', 'Justjoe', 5

--Mapping managers to clients
exec MapManagerToClient 8, 1
exec MapManagerToClient 8, 2
exec MapManagerToClient 8, 3
exec MapManagerToClient 9, 4
exec MapManagerToClient 10, 5
exec MapManagerToClient 10, 6
exec MapManagerToClient 10, 7
