using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 用户票证信息
    /// </summary>
    [Serializable]
    public class UserTicketInfo
    {
        #region Fields

        private int m_Pid;									//用户标识
        private string m_Id;  		                        //登录帐号
        private string m_Passwd;				                //用户密码

        #endregion

        #region 构造方法
        /// <summary>
        /// 初始化用户票证对象实例
        /// </summary>
        public UserTicketInfo()
        {
            m_Pid = 0;
            m_Id = "";
            m_Passwd = "";
        }

        /// <summary>
        /// 初始化用户票证对象实例
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="gameID"></param>
        /// <param name="stationID"></param>
        /// <param name="currencyID"></param>
        /// <param name="accounts"></param>
        /// <param name="logonPasswd"></param>
        /// <param name="passwordID"></param>
        /// <param name="protectID"></param>
        public UserTicketInfo(int userID, string accounts, string logonPasswd)
        {
            m_Pid = userID;
            m_Id = accounts;
            m_Passwd = logonPasswd;
        }
        #endregion

        #region 公开属性
        // <summary>
        /// 用户标识
        /// </summary>		
        public int Pid
        {
            get { return m_Pid; }
            set { m_Pid = value; }
        }

        /// <summary>
        /// 登录帐号
        /// </summary>		
        public virtual string Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Passwd
        {
            get { return m_Passwd; }
            set { m_Passwd = value; }
        }

        #endregion

        #region 公开方法

        /// <summary>
        /// 序列化为Json对象
        /// </summary>
        /// <returns></returns>
        public string SerializeText()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// 反序列化Json对象
        /// </summary>
        /// <param name="jsonText"></param>
        /// <returns></returns>
        public static UserTicketInfo DeserializeObject(string jsonText)
        {
            UserTicketInfo userTicket = JsonConvert.DeserializeObject<UserTicketInfo>(jsonText);
            return userTicket;
        }

        #endregion
    }
}
