drop table CompanyProfile
create table CompanyProfile(
	Id int identity(1,1) primary key,
	StockCode varchar(100) not null,--股票代码
	LegalName nvarchar(100),--法定名称
	EnglishName varchar(200),--英文名称
	EstablishDate datetime,--成立日期
	OwnedIndustry nvarchar(100),--所属行业
	RegisteredCapital decimal(18,2),--注册资本
	IssuePrice decimal(18,2),--发行价格
	EmployeesCount int,--职工总数
	LegalPerson nvarchar(100),--法人
	[Telephone] varchar(100),--公司电话
	--CompanySecretary nvarchar(100),--董事会秘书
	--CompanyFax varchar(100),--公司传真
	--SecretariesPhone varchar(100),--董秘电话
	[Email] varchar(100),--公司邮箱
	[Website] varchar(100),--公司网址
	--RegisteredAddress  nvarchar(100),--注册地址
	OfficeAddress nvarchar(100),--办公地址
	ListingDate datetime,--上市日期
	BusinessScope nvarchar(1000),--经营范围
	[Profile] nvarchar(2000),--公司简介
	ListedMarket nvarchar(100),--上市市场
)