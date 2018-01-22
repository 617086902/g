

create table ThirdPartyAccount(
	Id int identity(1,1) primary key,
	UserId int not null,
	OpenId varchar(200),
	AccountType int,
	AuthDate datetime,
	Deleted bit not null,
)