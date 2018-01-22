drop table [UserLike]
--收藏的帖子/喜欢的用户/等
create table [UserLike](
	Id int identity(1,1) primary key,
	TargetId int not null,
	TargetType int not null,
	CreatedBy int not null,
	CreatedOn datetime not null,
	Deleted bit not null
)