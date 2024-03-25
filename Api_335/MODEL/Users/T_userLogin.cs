using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Users
{
    [Table("T_userLogin")]
    public class T_userLogin
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [Key]
        public Guid U_id { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        [StringLength(30)]
        public string UL_Name { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        [StringLength(100)]
        public string UL_Pwd { get; set; }
        /// <summary>
        /// 用户注册时间
        /// </summary>
        public DateTime UL_Date { get; set; } = DateTime.Now;


    }
}
