
create table HotStockBar(
	Id int identity(1,1) primary key,
	StockId int not null,
	HeatValue int not null,
)
create table HotPost(
	Id int identity(1,1) primary key,
	PostId int not null,
	HeatValue int not null,
)