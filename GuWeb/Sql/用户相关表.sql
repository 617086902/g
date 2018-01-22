
create table [User](
	Id int identity (1,1) primary key,
	UserCode varchar(100) null,
	Email varchar(100) null,
	Mobile varchar(50) null,
	PassCode varchar(100) not null,
	CreatedOn datetime not null default getdate(),
	CreatedBy int not null,
	Deleted bit not null default 0,
)

create table [UserInformation](
	Id int identity (1,1) primary key,
	UserId int not null,
	Nickname nvarchar(100) null,
	Realname nvarchar(100) null,
	ProfilePhoto varchar(200) null,
	Gender int null,
	Birthday datetime null,
	Contry varchar(100) null,
	Province varchar(100) null,
	City varchar(100) null,
	LastLoginTime datetime null,
	CreatedOn datetime not null default getdate(),
	CreatedBy int not null,
	Deleted bit not null default 0,
)