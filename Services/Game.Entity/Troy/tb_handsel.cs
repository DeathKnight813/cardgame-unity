using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 tb_handsel。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tb_handsel
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "tb_handsel";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _give_money_idx = "give_money_idx";

        /// <summary>
        /// 改变的钱数
        /// </summary>
        public const string _give_money = "give_money";

        /// <summary>
        /// 时间
        /// </summary>
        public const string _give_date = "give_date";

        /// <summary>
        /// 方式
        /// </summary>
        public const string _code = "code";

        /// <summary>
        /// 帐号
        /// </summary>
        public const string _UserId = "UserId";

        /// <summary>
        /// 昵称
        /// </summary>
        public const string _UserNickName = "UserNickName";

        #endregion

        #region 私有变量
        private int m_give_money_idx;			     //标识
        private decimal m_give_money;             //改变的钱数
        private DateTime m_give_date;                 //时间   
        private string m_code;                 //方式
        private string m_UserId;                 //帐号
        private string m_UserNickName;        //昵称
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化tb_handsel
        /// </summary>
        public tb_handsel()
        {
            m_give_money_idx = 0;
            m_give_money = 0;
            m_give_date = DateTime.Now;
            m_code = "";
            m_UserId = "";
            m_UserNickName = "";
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 标识
        /// </summary>
        public int give_money_idx
        {
            get { return m_give_money_idx; }
            set { m_give_money_idx = value; }
        }

        /// <summary>
        /// 改变的钱数
        /// </summary>
        public decimal give_money
        {
            get { return m_give_money; }
            set { m_give_money = value; }
        }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime give_date
        {
            get { return m_give_date; }
            set { m_give_date = value; }
        }

        /// <summary>
        /// 1 余额充值 2金库充值 3余额提款 4金库提款
        /// </summary>
        public string code
        {
            get { return m_code; }
            set { m_code = value; }
        }

        /// <summary>
        /// 帐号
        /// </summary>
        public string UserId
        {
            get { return m_UserId; }
            set { m_UserId = value; }
        }

        /// <summary>
        /// 昵称
        /// </summary>
        public string UserNickName
        {
            get { return m_UserNickName; }
            set { m_UserNickName = value; }
        }
        #endregion
    }
}