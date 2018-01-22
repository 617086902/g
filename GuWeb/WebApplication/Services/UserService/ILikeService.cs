using BusinessService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public interface ILikeService
    {
        bool LikeOrUnLike(int targetId, TargetType targetType, bool isLike);

        bool IsLike(int targetId, TargetType targetType);

        UserPostModel GetLikePostList(int userId, int pageIndex, int pageSize);
    }
}
