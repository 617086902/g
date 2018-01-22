using Core.Entities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService {
    public interface IUserService {
        
        /// <summary>
        /// 判断是否已注册
        /// </summary>
        /// <param name="usercode"></param>
        /// <returns></returns>
        bool CheckIsRegisted(string usercode);

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool RegistUser(BaseUser user);

        BaseUser Login(string usercode, string passcode);

        bool LoginOut(string usercode);

        /// <summary>
        /// 编辑资料
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        bool EditProfile(UserInformation info);

        bool AddThirdPartyAccount(ThirdPartyAccount thirdPartyAccount);

        ThirdPartyAccount GetThirdpartyAccount(string openId);

        string GetUserCodeById(int userId);
    }
}
