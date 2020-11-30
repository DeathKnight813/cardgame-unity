using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 tb_cashinfo。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tb_cashinfo
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "tb_cashinfo";

        /// <summary>
        /// 银行名
        /// </summary>
        public const string _bank_name = "bank_name";

        /// <summary>
        /// 银行帐号
        /// </summary>
        public const string _accountNo = "accountNo";

        /// <summary>
        /// 汇款人
        /// </summary>
        public const string _accountName = "accountName";
        #endregion

        #region 私有变量
        private string m_bank_name;					//银行名
        private string m_accountNo;				//银行帐号
        private string m_accountName;			//汇款人
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化tb_cashinfo
        /// </summary>
        public tb_cashinfo()
        {
            m_bank_name = "";
            m_accountNo = "";
            m_accountName = "";
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 银行名
        /// </summary>
        public string bank_name
        {
            get { return m_bank_name; }
            set { m_bank_name = value; }
        }

        /// <summary>
        /// 银行帐号
        /// </summary>
        public string accountNo
        {
            get { return m_accountNo; }
            set { m_accountNo = value; }
        }

        /// <summary>
        /// 汇款人
        /// </summary>
        public string accountName
        {
            get { return m_accountName; }
            set { m_accountName = value; }
        }
        #endregion
    }
}
