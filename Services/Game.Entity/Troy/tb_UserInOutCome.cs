using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 tb_UserInOutCome。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tb_UserInOutCome
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "tb_UserInOutCome";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _Idx = "Idx";

        /// <summary>
        /// 帐号
        /// </summary>
        public const string _UserAccount = "UserAccount";

        /// <summary>
        /// 昵称
        /// </summary>
        public const string _UserNickName = "UserNickName";

        /// <summary>
        /// 处理的钱
        /// </summary>
        public const string _ApplyMoney = "ApplyMoney";

        /// <summary>
        /// 添加时间
        /// </summary>
        public const string _InsertDate = "InsertDate";

        /// <summary>
        /// 银行名
        /// </summary>
        public const string _BankName = "BankName";

        /// <summary>
        /// 银行帐号
        /// </summary>
        public const string _BankAccount = "BankAccount";

        /// <summary>
        /// 汇款人
        /// </summary>
        public const string _BankAcowner = "BankAcowner";

        /// <summary>
        /// 0未处理 1处理中 2处理完成 3取消
        /// </summary>
        public const string _Type = "Type";

        /// <summary>
        /// 1充值 2提款
        /// </summary>
        public const string _InOut = "InOut";

        /// <summary>
        /// 0是假提款 1是真的
        /// </summary>
        public const string _Fack = "Fack";

        /// <summary>
        /// 备注
        /// </summary>
        public const string _Remark = "Remark";

        /// <summary>
        /// 手续费
        /// </summary>
        public const string _TaxMoney = "TaxMoney";

        /// <summary>
        /// 申请的金额
        /// </summary>
        public const string _RegMoney = "RegMoney";
        #endregion

        #region 私有变量
        private int m_Idx;						//标识
        private string m_UserAccount;			//帐号
        private string m_UserNickName;			//昵称
        private decimal m_ApplyMoney;           //处理的钱
        private DateTime m_InsertDate;          //申请时间
        private string m_BankName;              //银行名
        private string m_BankAccount;           //银行帐号
        private string m_BankAcowner;           //汇款人        
        private int m_Type;                     //0未处理 1处理中 2处理完成 3取消
        private int m_InOut;                    // 1充值 2提款
        private int m_Fack;                     // 0是假提款 1是真的
        private string m_Remark;                // 备注
        private decimal m_TaxMoney;             //手续费
        private decimal m_RegMoney;             //申请的钱

        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化tb_UserInOutCome
        /// </summary>
        public tb_UserInOutCome()
        {
            m_Idx = 0;
            m_UserAccount = "";
            m_UserNickName = "";
            m_ApplyMoney = 0;
            m_InsertDate = DateTime.Now;
            m_BankName = "";
            m_BankAccount = "";
            m_BankAcowner = "";
            m_Type = 0;
            m_InOut = 0;
            m_Fack = 0;
            m_Remark = "";
            m_TaxMoney = 0;
            m_RegMoney = 0;
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
        /// 账号
        /// </summary>
        public string UserAccount
        {
            get { return m_UserAccount; }
            set { m_UserAccount = value; }
        }

        /// <summary>
        /// 昵称
        /// </summary>
        public string UserNickName
        {
            get { return m_UserNickName; }
            set { m_UserNickName = value; }
        }

        /// <summary>
        /// 处理的钱
        /// </summary>
        public decimal ApplyMoney
        {
            get { return m_ApplyMoney; }
            set { m_ApplyMoney = value; }
        }

        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime InsertDate
        {
            get { return m_InsertDate; }
            set { m_InsertDate = value; }
        }

        /// <summary>
        /// 银行名
        /// </summary>
        public string BankName
        {
            get { return m_BankName; }
            set { m_BankName = value; }
        }

        /// <summary>
        /// 银行帐号
        /// </summary>
        public string BankAccount
        {
            get { return m_BankAccount; }
            set { m_BankAccount = value; }
        }

        /// <summary>
        /// 汇款人
        /// </summary>
        public string BankAcowner
        {
            get { return m_BankAcowner; }
            set { m_BankAcowner = value; }
        }

        /// <summary>
        /// 0未处理 1处理中 2处理完成 3取消
        /// </summary>
        public int Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        /// <summary>
        /// 1充值 2提款
        /// </summary>
        public int InOut
        {
            get { return m_InOut; }
            set { m_InOut = value; }
        }

        /// <summary>
        /// 0是假提款 1是真的
        /// </summary>
        public int Fack
        {
            get { return m_Fack; }
            set { m_Fack = value; }
        }

        /// <summary>
        /// 1正常提款 2金库提款 3充值 4是网页充值 5是网页提款
        /// </summary>
        public string Remark
        {
            get { return m_Remark; }
            set { m_Remark = value; }
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
        /// 申请的钱
        /// </summary>
        public decimal RegMoney
        {
            get { return m_RegMoney; }
            set { m_RegMoney = value; }
        }
        #endregion
    }
}
