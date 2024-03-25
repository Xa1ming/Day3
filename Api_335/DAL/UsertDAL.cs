using MODEL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsertDAL
    {
        MyDbCount db = new MyDbCount();
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
        /// <summary>
        /// 验证用户名称是否唯一
        /// </summary>
        /// <param name="Uname">用户名称</param>
        /// <returns>返回满足条件的行数</returns>
        public int SearchUname(string Uname)
        {
            try
            {
                int res = db.T_userLogin.Where(x =>x.UL_Name == Uname).Count();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int UsertLogin(string Uname,string Upwd)
        {

        }

        
    }
}
