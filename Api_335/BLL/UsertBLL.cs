using DAL.Migrations;
using MODEL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Security.Cryptography;

namespace BLL
{
    public class UsertBLL
    {
        UsertDAL dal = new UsertDAL();
        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="info">用户注册实体</param>
        /// <returns>返回受影响的行数</returns>
        public int UserRegister(T_userLogin info)
        {
            try
            {
               int res = dal.SearchUname(info.UL_Name);
                if(res > 0)
                {
                    return -1;
                }
                else
                {
                   info.UL_Pwd =  Md5String(info.UL_Pwd);
                    return dal.UserRegister(info);
                }
                
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// 加密密码信息
        /// </summary>
        /// <param name="pwd">需要加密的密码</param>
        /// <returns>返回加密后的字符串</returns>
        public string Md5String(string pwd)
        {
            MD5 md = MD5.Create();
            byte[] newPwd =   md.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            return BitConverter.ToString(newPwd);
        }
    }
}
