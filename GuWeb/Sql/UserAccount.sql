
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

insert into UserLevel values (1,'��������',1)
insert into UserLevel values (2,'���¶���',20)
insert into UserLevel values (3,'С��С��',50)
insert into UserLevel values (4,'����װ��',100)
insert into UserLevel values (5,'�������',200)
insert into UserLevel values (6,'���ڹȵ�',500)
insert into UserLevel values (7,'����ɽ��',1000)
insert into UserLevel values (8,'��λվ��',2000)
insert into UserLevel values (9,'��н����',3000)
insert into UserLevel values (10,'��ӯС��',5000)
insert into UserLevel values (11,'�Ƕ���ׯ',10000)
insert into UserLevel values (12,'˳�ƶ�Ϊ',20000)
insert into UserLevel values (13,'��������',50000)
insert into UserLevel values (14,'�ս�����',100000)
insert into UserLevel values (15,'���Ҳ�',200000)
insert into UserLevel values (16,'����һ��',300000)
insert into UserLevel values (17,'���ɵй�',500000)
insert into UserLevel values (18,'̽��ȡ��',1000000)

update userlevel set LevelName='С��С��' where id=3