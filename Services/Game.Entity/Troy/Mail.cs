using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 Mail。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Mail
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "Mail";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _Idx = "Idx";

        /// <summary>
        /// 发送人帐号
        /// </summary>
        public const string _S_Account = "S_Account";

        /// <summary>
        /// 发送人昵称
        /// </summary>
        public const string _S_NickName = "S_NickName";

        /// <summary>
        /// 时间
        /// </summary>
        public const string _SendDate = "SendDate";

        /// <summary>
        /// 内容
        /// </summary>
        public const string _M_Content = "M_Content";

        /// <summary>
        /// 收件人帐号
        /// </summary>
        public const string _R_Account = "R_Account";

        /// <summary>
        /// 收件人昵称
        /// </summary>
        public const string _R_NickName = "R_NickName";

        /// <summary>
        /// 0 未读  1已读
        /// </summary>
        public const string _Status = "Status";

        /// <summary>
        /// 0后台给会员 1会员给后台
        /// </summary>
        public const string _Type = "Type";
        #endregion

        #region 私有变量
        private int m_Idx;					//标识
        private string m_S_Account;					//发送人帐号
        private string m_S_NickName;					//发送人昵称
        private DateTime m_SendDate;					//时间
        private string m_M_Content;					//内容
        private string m_R_Account;					//收件人帐号
        private string m_R_NickName;					//收件人昵称
        private int m_Status;			//0 未读  1已读
        private int m_Type;			//0后台给会员 1会员给后台
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化Mail
        /// </summary>
        public Mail()
        {
            m_Idx = 0;
            m_S_Account = "";
            m_S_NickName = "";
            m_SendDate = DateTime.Now;
            m_M_Content = "";
            m_R_Account = "";
            m_R_NickName = "";
            m_Status = 0;
            m_Type = 0;
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 标识
        /// </summary>
        public int Idx
        {
            get { return m_Idx; }
            set { m_Idx = value; }
        }

        /// <summary>
        /// 发送人帐号
        /// </summary>
        public string S_Account
        {
            get { return m_S_Account; }
            set { m_S_Account = value; }
        }

        /// <summary>
        /// 发送人昵称
        /// </summary>
        public string S_NickName
        {
            get { return m_S_NickName; }
            set { m_S_NickName = value; }
        }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime SendDate
        {
            get { return m_SendDate; }
            set { m_SendDate = value; }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string M_Content
        {
            get { return m_M_Content; }
            set { m_M_Content = value; }
        }

        /// <summary>
        /// 收件人帐号
        /// </summary>
        public string R_Account
        {
            get { return m_R_Account; }
            set { m_R_Account = value; }
        }

        /// <summary>
        /// 收件人昵称
        /// </summary>
        public string R_NickName
        {
            get { return m_R_NickName; }
            set { m_R_NickName = value; }
        }

        /// <summary>
        /// 0 未读  1已读
        /// </summary>
        public int Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }

        /// <summary>
        /// 0后台给会员 1会员给后台
        /// </summary>
        public int Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }
        #endregion
    }
}
