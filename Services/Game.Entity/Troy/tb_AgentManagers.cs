
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 tb_AgentManagers。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tb_AgentManagers
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "tb_AgentManagers";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _Idx = "Idx";

        /// <summary>
        /// 帐号
        /// </summary>
        public const string _Account = "Account";

        /// <summary>
        /// 昵称
        /// </summary>
        public const string _NickName = "NickName";

        /// <summary>
        /// 登录密码
        /// </summary>
        public const string _PassWord = "PassWord";

        /// <summary>
        /// 登录密码明文
        /// </summary>
        public const string _TruePassWord = "TruePassWord";

        /// <summary>
        /// 上级代理标识
        /// </summary>
        public const string _UpShopIdx = "UpShopIdx";

        /// <summary>
        /// 级别
        /// </summary>
        public const string _Levels = "Levels";

        /// <summary>
        /// 域名
        /// </summary>
        public const string _Url = "Url";

        /// <summary>
        /// 水子
        /// </summary>
        public const string _Rate = "Rate";

        /// <summary>
        /// 注册时间
        /// </summary>
        public const string _RegDate = "RegDate";

        /// <summary>
        /// 收入
        /// </summary>
        public const string _BalanceMoney = "BalanceMoney";

        /// <summary>
        /// 0不允许登录 1允许登录
        /// </summary>
        public const string _States = "States";

        /// <summary>
        /// 结算金额
        /// </summary>
        public const string _SettlementMoney = "SettlementMoney";

        /// <summary>
        /// 下面会员总充值
        /// </summary>
        public const string _TotalInCome = "TotalInCome";

        /// <summary>
        /// 下面会员总提款
        /// </summary>
        public const string _TotalOutCome = "TotalOutCome";

        /// <summary>
        /// 负责人
        /// </summary>
        public const string _Responsible = "Responsible";

        /// <summary>
        /// 金库存入
        /// </summary>
        public const string _GetCashMoney = "GetCashMoney";

        /// <summary>
        /// 金库取出
        /// </summary>
        public const string _GetCashOutMoney = "GetCashOutMoney";

        /// <summary>
        /// 银行信息
        /// </summary>
        public const string _Remark = "Remark";
        #endregion

        #region 私有变量
        private int m_Idx;						//标识
        private string m_Account;					//帐号
        private string m_NickName;					//昵称
        private string m_PassWord;						//登录密码
        private string m_TruePassWord;						//登录密码明文
        private int m_UpShopIdx;			//
        private int m_Levels;				//
        private string m_Url;			//
        private int m_Rate;				//      
        private DateTime m_RegDate;
        private decimal m_BalanceMoney;
        private int m_States;
        private decimal m_SettlementMoney;
        private decimal m_TotalInCome;
        private decimal m_TotalOutCome;
        private string m_Responsible;
        private decimal m_GetCashMoney;
        private decimal m_GetCashOutMoney;
        private string m_Remark;
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化tb_AgentManagers
        /// </summary>
        public tb_AgentManagers()
        {
            m_Idx = 0;
            m_Account = "";
            m_NickName = "";
            m_PassWord = "";
            m_TruePassWord = "";
            m_UpShopIdx = 0;
            m_Levels = 0;
            m_Url = "";
            m_Rate = 0;
            m_RegDate = DateTime.Now;
            m_BalanceMoney = 0;
            m_States = 1;
            m_SettlementMoney = 0;
            m_TotalInCome = 0;
            m_TotalInCome = 0;
            m_Responsible = "";
            m_GetCashMoney = 0;
            m_GetCashOutMoney = 0;
            m_Remark = "";
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
        /// 帐号
        /// </summary>
        public string Account
        {
            get { return m_Account; }
            set { m_Account = value; }
        }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName
        {
            get { return m_NickName; }
            set { m_NickName = value; }
        }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string PassWord
        {
            get { return m_PassWord; }
            set { m_PassWord = value; }
        }

        /// <summary>
        /// 登录密码明文
        /// </summary>
        public string TruePassWord
        {
            get { return m_TruePassWord; }
            set { m_TruePassWord = value; }
        }

        /// <summary>
        /// 上级代理标识
        /// </summary>
        public int UpShopIdx
        {
            get { return m_UpShopIdx; }
            set { m_UpShopIdx = value; }
        }

        /// <summary>
        /// 级别
        /// </summary>
        public int Levels
        {
            get { return m_Levels; }
            set { m_Levels = value; }
        }

        /// <summary>
        /// 域名
        /// </summary>
        public string Url
        {
            get { return m_Url; }
            set { m_Url = value; }
        }

        /// <summary>
        /// 水子
        /// </summary>
        public int Rate
        {
            get { return m_Rate; }
            set { m_Rate = value; }
        }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegDate
        {
            get { return m_RegDate; }
            set { m_RegDate = value; }
        }

        /// <summary>
        /// 充值提款收入
        /// </summary>
        public decimal BalanceMoney
        {
            get { return m_BalanceMoney; }
            set { m_BalanceMoney = value; }
        }

        /// <summary>
        /// 0不允许登录 1允许登录
        /// </summary>
        public int States
        {
            get { return m_States; }
            set { m_States = value; }
        }

        /// <summary>
        /// 结算金额
        /// </summary>
        public decimal SettlementMoney
        {
            get { return m_SettlementMoney; }
            set { m_SettlementMoney = value; }
        }

        /// <summary>
        /// 下面会员总充值
        /// </summary>
        public decimal TotalInCome
        {
            get { return m_TotalInCome; }
            set { m_TotalInCome = value; }
        }

        /// <summary>
        /// 下面会员总提款
        /// </summary>
        public decimal TotalOutCome
        {
            get { return m_TotalOutCome; }
            set { m_TotalOutCome = value; }
        }

        /// <summary>
        /// 负责人
        /// </summary>
        public string Responsible
        {
            get { return m_Responsible; }
            set { m_Responsible = value; }
        }

        /// <summary>
        /// 金库存入
        /// </summary>
        public decimal GetCashMoney
        {
            get { return m_GetCashMoney; }
            set { m_GetCashMoney = value; }
        }

        /// <summary>
        /// 金库取出
        /// </summary>
        public decimal GetCashOutMoney
        {
            get { return m_GetCashOutMoney; }
            set { m_GetCashOutMoney = value; }
        }

        /// <summary>
        /// 银行信息
        /// </summary>
        public string Remark
        {
            get { return m_Remark; }
            set { m_Remark = value; }
        }
        #endregion
    }
}
