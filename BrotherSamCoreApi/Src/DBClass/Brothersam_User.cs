using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrotherSamCoreApi.Src.DBClass
{
    /// <summary>
    /// 数据库Brothersam_User实体类
    /// </summary>
    public class Brothersam_User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 归属团队编号
        /// </summary>
        public int TeamId { get; set; }
        /// <summary>
        /// 用户性别 1：男。0：女。null/空格：未知
        /// </summary>
        public string UserSex { get; set; }
        /// <summary>
        /// 用户电话号码
        /// </summary>
        public string UserPhoneNumber { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string UserRemark { get; set; }
    }
}
