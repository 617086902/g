
drop table UserAccount
create table UserAccount(
	Id int identity(1,1) primary key,
	MoneyValue decimal(18,2) not null default 0.00,
	ScoreValue decimal(18,2) not null default 0.00,
	UserLevel int not null,
	CreatedBy int not null,
	CreatedOn datetime not null,
	ModifyBy int null,
	ModifyOn datetime null,
	Deleted bit not null,
)

create table UserLevel(
	Id int identity(1,1) primary key,
	LevelNum int not null,
	LevelName nvarchar(100) not null,
	LevelScore int not null,
)

insert into UserLevel values (1,'股市新手',1)
insert into UserLevel values (2,'懵懵懂懂',20)
insert into UserLevel values (3,'小打小闹',50)
insert into UserLevel values (4,'不懂装懂',100)
insert into UserLevel values (5,'深跌不放',200)
insert into UserLevel values (6,'割在谷底',500)
insert into UserLevel values (7,'补在山腰',1000)
insert into UserLevel values (8,'高位站岗',2000)
insert into UserLevel values (9,'卧薪尝胆',3000)
insert into UserLevel values (10,'初盈小利',5000)
insert into UserLevel values (11,'智斗恶庄',10000)
insert into UserLevel values (12,'顺势而为',20000)
insert into UserLevel values (13,'进出自如',50000)
insert into UserLevel values (14,'日进斗金',100000)
insert into UserLevel values (15,'万贯家财',200000)
insert into UserLevel values (16,'富甲一方',300000)
insert into UserLevel values (17,'富可敌国',500000)
insert into UserLevel values (18,'探囊取物',1000000)

update userlevel set LevelName='小打小闹' where id=3