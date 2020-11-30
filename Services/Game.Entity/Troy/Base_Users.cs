
using System;
using System.Collections.Generic;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 Base_Users。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Base_Users
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "Base_Users";

        /// <summary>
        /// 管理员ID
        /// </summary>
        public const string _UserID = "UserID";

        /// <summary>
        /// 帐号
        /// </summary>
        public const string _Username = "Username";

        /// <summary>
        /// 密码
        /// </summary>
        public const string _Password = "Password";

        /// <summary>
        /// 角色ID
        /// </summary>
        public const string _RoleID = "RoleID";

        /// <summary>
        /// 冻结标志 0-启用，1-冻结
        /// </summary>
        public const string _Nullity = "Nullity";

        /// <summary>
        /// 
        /// </summary>
        public const string _PreLogintime = "PreLogintime";

        /// <summary>
        /// 
        /// </summary>
        public const string _PreLoginIP = "PreLoginIP";

        /// <summary>
        /// 
        /// </summary>
        public const string _LastLogintime = "LastLogintime";

        /// <summary>
        /// 
        /// </summary>
        public const string _LastLoginIP = "LastLoginIP";

        /// <summary>
        /// 
        /// </summary>
        public const string _LoginTimes = "LoginTimes";

        /// <summary>
        /// 绑定IP 0-绑定 1-未绑定
        /// </summary>
        public const string _IsBand = "IsBand";

        /// <summary>
        /// 绑定的IP
        /// </summary>
        public const string _BandIP = "BandIP";

        /// <summary>
        /// 余额
        /// </summary>
        public const string _OwnMoney = "OwnMoney";
        #endregion

        #region 私有变量
        private int m_userID;						//管理员ID
        private string m_username;					//帐号
        private string m_password;					//密码
        private int m_roleID;						//角色ID
        private byte m_nullity;						//冻结标志 0-启用，1-冻结
        private DateTime m_preLogintime;			//
        private string m_preLoginIP;				//
        private DateTime m_lastLogintime;			//
        private string m_lastLoginIP;				//
        private int m_loginTimes;					//
        private int m_isBand;						//绑定IP 0-绑定 1-未绑定
        private string m_bandIP;					//
        private decimal m_OwnMoney;

        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化Base_Users
        /// </summary>
        public Base_Users()
        {
            m_userID = 0;
            m_username = "";
            m_password = "";
            m_roleID = 0;
            m_nullity = 0;
            m_preLogintime = DateTime.Now;
            m_preLoginIP = "";
            m_lastLogintime = DateTime.Now;
            m_lastLoginIP = "";
            m_loginTimes = 0;
            m_isBand = 0;
            m_bandIP = "";
            m_OwnMoney = 0;
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 管理员ID
        /// </summary>
        public int UserID
        {
            get { return m_userID; }
            set { m_userID = value; }
        }

        /// <summary>
        /// 帐号
        /// </summary>
        public string Username
        {
            get { return m_username; }
            set { m_username = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID
        {
            get { return m_roleID; }
            set { m_roleID = value; }
        }

        /// <summary>
        /// 冻结标志 0-启用，1-冻结
        /// </summary>
        public byte Nullity
        {
            get { return m_nullity; }
            set { m_nullity = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime PreLogintime
        {
            get { return m_preLogintime; }
            set { m_preLogintime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PreLoginIP
        {
            get { return m_preLoginIP; }
            set { m_preLoginIP = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime LastLogintime
        {
            get { return m_lastLogintime; }
            set { m_lastLogintime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LastLoginIP
        {
            get { return m_lastLoginIP; }
            set { m_lastLoginIP = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int LoginTimes
        {
            get { return m_loginTimes; }
            set { m_loginTimes = value; }
        }

        /// <summary>
        /// 绑定IP 0-绑定 1-未绑定
        /// </summary>
        public int IsBand
        {
            get { return m_isBand; }
            set { m_isBand = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BandIP
        {
            get { return m_bandIP; }
            set { m_bandIP = value; }
        }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal OwnMoney
        {
            get { return m_OwnMoney; }
            set { m_OwnMoney = value; }
        }
        #endregion
    }
}
