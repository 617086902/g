
create table Stock(
	Id int identity(1,1) primary key,
	StockCode varchar(100) null,
	StockName nvarchar(100) null,
	PyFullName varchar(100) null,--ƴ��ȫ��
	PyAbbre varchar(100) null,--ƴ�����
)