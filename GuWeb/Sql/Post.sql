--����
drop table Post
create table Post(
	Id int identity(1,1) primary key,
	StockCode varchar(100) not null,
	Title nvarchar(500) not null,
	Content nvarchar(max) not null,
	IsBoutique bit not null,--�Ƿ��Ǿ�Ʒ��
	IsTop bit not null,--�Ƿ��ö�
	HotValue int not null,
	CreatedOn datetime not null,
	CreatedBy int not null,
	ModifyOn datetime,
	ModifyBy int,
	Deleted bit not null,
)
drop table comment
--�ظ�
create table Comment(
	Id int identity(1,1) primary key,
	PostId int not null,
	ParentCommentId int not null,
	ToUserName nvarchar(200) null,
	Content nvarchar(max) not null,
	[Floor] int not null,
	CreatedOn datetime not null,
	CreatedBy int not null,
	ModifyOn datetime,
	ModifyBy int,
	Deleted bit not null,
)

--��/�ȱ� likecount/dislikecount

--�ղر� 