drop table CompanyProfile
create table CompanyProfile(
	Id int identity(1,1) primary key,
	StockCode varchar(100) not null,--��Ʊ����
	LegalName nvarchar(100),--��������
	EnglishName varchar(200),--Ӣ������
	EstablishDate datetime,--��������
	OwnedIndustry nvarchar(100),--������ҵ
	RegisteredCapital decimal(18,2),--ע���ʱ�
	IssuePrice decimal(18,2),--���м۸�
	EmployeesCount int,--ְ������
	LegalPerson nvarchar(100),--����
	[Telephone] varchar(100),--��˾�绰
	--CompanySecretary nvarchar(100),--���»�����
	--CompanyFax varchar(100),--��˾����
	--SecretariesPhone varchar(100),--���ص绰
	[Email] varchar(100),--��˾����
	[Website] varchar(100),--��˾��ַ
	--RegisteredAddress  nvarchar(100),--ע���ַ
	OfficeAddress nvarchar(100),--�칫��ַ
	ListingDate datetime,--��������
	BusinessScope nvarchar(1000),--��Ӫ��Χ
	[Profile] nvarchar(2000),--��˾���
	ListedMarket nvarchar(100),--�����г�
)