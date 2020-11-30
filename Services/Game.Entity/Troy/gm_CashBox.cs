using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 gm_CashBox。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class gm_CashBox
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "gm_CashBox";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _Idx = "Idx";

        /// <summary>
        /// 会员帐号
        /// </summary>
        public const string _Account = "Account";

        /// <summary>
        /// 会员昵称
        /// </summary>
        public const string _NickName = "NickName";

        /// <summary>
        /// 交易前保有余额
        /// </summary>
        public const string _Before_money = "Before_money";

        /// <summary>
        /// 操作时间
        /// </summary>
        public const string _Reg_date = "Reg_date";

        /// <summary>
        /// 1充值  2提款
        /// </summary>
        public const string _InOut = "InOut";

        /// <summary>
        /// 交易的金额
        /// </summary>
        public const string _SettlementMoney = "SettlementMoney";

        /// <summary>
        /// 交易后保有余额
        /// </summary>
        public const string _AfterMoney = "AfterMoney";

        /// <summary>
        /// 手续费
        /// </summary>
        public const string _TaxMoney = "TaxMoney";

        /// <summary>
        /// 交易之前的金库金额
        /// </summary>
        public const string _CashBefore = "CashBefore";

        /// <summary>
        /// 交易后的金库金额
        /// </summary>
        public const string _CashAfter = "CashAfter";
        #endregion

        #region 私有变量
        private int m_Idx;				//标识
        private string m_Account;		//会员帐号
        private string m_NickName;  //会员昵称
        private decimal m_Before_money;		//交易前保有余额
        private DateTime m_Reg_date;	//操作时间
        private int m_InOut;	//1充值  2提款
        private decimal m_SettlementMoney;	    //交易的金额
        private decimal m_AfterMoney;			//交易后保有余额      
        private decimal m_TaxMoney;     //手续费
        private decimal m_CashBefore;
        private decimal m_CashAfter;
        
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化gm_CashBox
        /// </summary>
        public gm_CashBox()
        {
            m_Idx = 0;				    //标识
            m_Account = "";		        //会员帐号
            m_NickName = "";            //会员昵称
            m_Before_money = 0;		    //交易前保有余额
            m_Reg_date = DateTime.Now;	//操作时间
            m_InOut = 1;	//1充值  2提款
            m_SettlementMoney = 0;	        //交易的金额
            m_AfterMoney = 0;			    //交易后保有余额    
            m_TaxMoney = 0;     //手续费
            m_CashBefore = 0;
            m_CashAfter = 0;
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
        /// 会员帐号
        /// </summary>
        public string Account
        {
            get { return m_Account; }
            set { m_Account = value; }
        }

        /// <summary>
        /// 会员昵称
        /// </summary>
        public string NickName
        {
            get { return m_NickName; }
            set { m_NickName = value; }
        }

        /// <summary>
        /// 交易前保有余额
        /// </summary>
        public decimal Before_money
        {
            get { return m_Before_money; }
            set { m_Before_money = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime Reg_date
        {
            get { return m_Reg_date; }
            set { m_Reg_date = value; }
        }

        /// <summary>
        /// 1充值  2提款  3押注返钱
        /// </summary>
        public int InOut
        {
            get { return m_InOut; }
            set { m_InOut = value; }
        }

        /// <summary>
        /// 交易的金额
        /// </summary>
        public decimal SettlementMoney
        {
            get { return m_SettlementMoney; }
            set { m_SettlementMoney = value; }
        }

        /// <summary>
        /// 交易后保有余额
        /// </summary>
        public decimal AfterMoney
        {
            get { return m_AfterMoney; }
            set { m_AfterMoney = value; }
        }

        /// <summary>
        /// 手续费
        /// </summary>
        public decimal TaxMoney
        {
            get { return m_TaxMoney; }
            set { m_TaxMoney = value; }
        }

        /// <summary>
        /// 交易之前的金库金额
        /// </summary>
        public decimal CashBefore
        {
            get { return m_CashBefore; }
            set { m_CashBefore = value; }
        }

        /// <summary>
        /// 交易后的金库金额
        /// </summary>
        public decimal CashAfter
        {
            get { return m_CashAfter; }
            set { m_CashAfter = value; }
        }
        #endregion
    }
}
