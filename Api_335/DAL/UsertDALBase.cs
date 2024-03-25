using MODEL.Users;
using System;

namespace DAL
{
    public class UsertDALBase
    {
        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="info">用户注册实体</param>
        /// <returns>返回受影响的行数</returns>
        public int UserRegister(T_userLogin info)
        {
            try
            {
                db.T_userLogin.Add(info);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}