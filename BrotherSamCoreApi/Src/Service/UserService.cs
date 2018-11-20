using BrotherSamCoreApi.Src.Const;
using BrotherSamCoreApi.Src.DBClass;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BrotherSamCoreApi.Src.Service
{
    /// <summary>
    /// 用户信息服务类
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// 根据姓名查询用户资料集合
        /// </summary>
        /// <param name="userName">姓名</param>
        /// <returns></returns>
        public List<Brothersam_User> FindListByUserName(string userName)
        {
            //SELECT * FROM  BrotherSamUser WHERE UserName='userName'
            //这里用using 语句块，当运行完了，会自动释放db连接资源。不用using就需要手动释放db资源
            //using (IDbConnection db = new MySqlConnection("Server=localhost;Database=brothersam;Port=3306;Uid=root;Pwd=zlsmysql;"))
            using (IDbConnection db = new MySqlConnection(AppConst.SQL_CONNCTION_STRING))
            {
                //普通拼接
                //string sql = "SELECT * FROM  BrotherSamUser WHERE UserName='" + userName + "'";
                //用string.Format拼接
                //string sql = string.Format("SELECT * FROM  BrotherSamUser WHERE UserName='{0}'", userName);
                //用用c# 6 语法拼接
                string sql = $"SELECT * FROM  brothersam_user WHERE userName='{userName}'";
                // db.Query 是 Dapper 实现的查询扩展；
                //<BrotherSamUser>表示转换成这个约束格式
                //IEnumerable 是因为 db.Query返回的是IEnumerable 集合

                IEnumerable<Brothersam_User> list = db.Query<Brothersam_User>(sql);
                return list.ToList();
            }
        }
    }
}
