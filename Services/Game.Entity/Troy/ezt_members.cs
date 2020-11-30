using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 ezt_members。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ezt_members
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "ezt_members";

        /// <summary>
        /// 用户标识
        /// </summary>
        public const string _pid = "pid";

        /// <summary>
        /// 帐号
        /// </summary>
        public const string _id = "id";

        /// <summary>
        /// 昵称
        /// </summary>
        public const string _nickname = "nickname";

        /// <summary>
        /// 余额
        /// </summary>
        public const string _BalanceMoney = "BalanceMoney";

        /// <summary>
        /// 金库余额
        /// </summary>
        public const string _CashMoney = "CashMoney";

        /// <summary>
        /// 登录密码
        /// </summary>
        public const string _Passwd = "Passwd";

        /// <summary>
        /// 电话
        /// </summary>
        public const string _phone = "phone";

        /// <summary>
        /// 是否允许登录
        /// </summary>
        public const bool _allowinvite = true;

        /// <summary>
        /// 注册时间
        /// </summary>
        public const string _reg_dt = "reg_dt";

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public const string _update_dt = "update_dt";

        /// <summary>
        /// IP
        /// </summary>
        public const string _IP = "IP";

        /// <summary>
        /// 代理帐号
        /// </summary>
        public const string _ShopCode = "ShopCode";

        /// <summary>
        /// 银行名
        /// </summary>
        public const string _BankName = "BankName";

        /// <summary>
        /// 汇款人
        /// </summary>
        public const string _BankAccount = "BankAccount";

        /// <summary>
        /// 银行帐号
        /// </summary>
        public const string _BankNumber = "BankNumber";

        /// <summary>
        /// 注册地址
        /// </summary>
        public const string _Remark1 = "Remark1";

        /// <summary>
        /// 备注
        /// </summary>
        public const string _Remark2 = "Remark2";

        /// <summary>
        /// 1正常  2踢出房间  3踢出游戏
        /// </summary>
        public const string _IsExit = "IsExit";

        /// <summary>
        /// 0会员 1看牌 2机器人
        /// </summary>
        public const string _UserType = "UserType";

        /// <summary>
        /// 金库密码
        /// </summary>
        public const string _CashBoxPass = "CashBoxPass";

        /// <summary>
        /// 提款密码
        /// </summary>
        public const string _WithdrawalsPass = "WithdrawalsPass";

        /// <summary>
        /// 自己总押注金额
        /// </summary>
        public const string _Gauge_money = "Gauge_money";

        /// <summary>
        /// 上级会员标识
        /// </summary>
        public const string _UpmembersPID = "UpmembersPID";

        /// <summary>
        /// 全部押注金额
        /// </summary>
        public const string _TotalAllGauge_money = "TotalAllGauge_money";

        /// <summary>
        /// 返钱比例1
        /// </summary>
        public const string _prize1 = "prize1";

        /// <summary>
        /// 返钱比例2
        /// </summary>
        public const string _prize2 = "prize2";

        /// <summary>
        /// 返钱比例3
        /// </summary>
        public const string _prize3 = "prize3";

        /// <summary>
        /// 返钱比例4
        /// </summary>
        public const string _prize4 = "prize4";

        /// <summary>
        /// 返钱比例5
        /// </summary>
        public const string _prize5 = "prize5";

        /// <summary>
        /// 总返钱
        /// </summary>
        public const string _Totalprize = "Totalprize";

        /// <summary>
        /// 每天押注金额
        /// </summary>
        public const string _Gauge_money_Day = "Gauge_money_Day";

        /// <summary>
        /// 登录密码明文
        /// </summary>
        public const string _TruePasswd = "TruePasswd";

        /// <summary>
        /// 金库密码明文
        /// </summary>
        public const string _TrueCashBoxPass = "TrueCashBoxPass";

        /// <summary>
        /// 提款密码明文
        /// </summary>
        public const string _TrueWithdrawalsPass = "TrueWithdrawalsPass";

        /// <summary>
        /// 会员总充值
        /// </summary>
        public const string _InComeTotal = "InComeTotal";

        /// <summary>
        /// 会员总提款
        /// </summary>
        public const string _OutComeTotal = "OutComeTotal";

        /// <summary>
        /// 
        /// </summary>
        public const string _allowtag = "allowtag";

        /// <summary>
        /// 后台给会员钱
        /// </summary>
        public const string _Addprize = "Addprize";

        /// <summary>
        /// 0未登录  1登录
        /// </summary>
        public const string _IsLog = "IsLog";

        /// <summary>
        /// 会员水子
        /// </summary>
        public const string _RateNum = "RateNum";
        #endregion

        #region 私有变量
        private int m_pid;
        private string m_id;
        private string m_nickname;
        private decimal m_BalanceMoney;
        private decimal m_CashMoney;
        private string m_passwd;
        private string m_phone;
        private bool m_allowinvite;
        private DateTime m_reg_dt;
        private DateTime m_update_dt;
        private string m_IP;
        private int m_ShopCode;
        private string m_BankName;
        private string m_BankAccount;
        private string m_BankNumber;
        private string m_Remark1;
        private string m_Remark2;
        private int m_IsExit;
        private int m_UserType;
        private string m_CashBoxPass;
        private string m_WithdrawalsPass;
        private decimal m_Gauge_money;
        private int m_UpmembersPID;
        private decimal m_TotalAllGauge_money;
        private decimal m_prize1;
        private decimal m_prize2;
        private decimal m_prize3;
        private decimal m_prize4;
        private decimal m_prize5;
        private decimal m_Totalprize;
        private decimal m_Gauge_money_Day;
        private string m_TruePasswd;
        private string m_TrueCashBoxPass;
        private string m_TrueWithdrawalsPass;
        private decimal m_InComeTotal;
        private decimal m_OutComeTotal;
        private bool m_allowtag;
        private int m_Addprize;
        private int m_IsLog;
        private int m_RateNum;

        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化NewTroy
        /// </summary>
        public ezt_members()
        {
            m_pid = 0;
            m_id = "";
            m_nickname = "";
            m_BalanceMoney = 0;
            m_CashMoney = 0;
            m_passwd = "";
            m_phone = "";
            m_allowinvite = true;
            m_reg_dt = DateTime.Now;
            m_update_dt = DateTime.Now;
            m_IP = "";
            m_ShopCode = 0;
            m_BankName = "";
            m_BankAccount = "";
            m_BankNumber = "";
            m_Remark1 = "";
            m_Remark2 = "";
            m_IsExit = 0;
            m_UserType = 0;
            m_CashBoxPass = "";
            m_WithdrawalsPass = "";
            m_Gauge_money = 0;
            m_UpmembersPID = 0;
            m_TotalAllGauge_money = 0;
            m_prize1 = 0;
            m_prize2 = 0;
            m_prize3 = 0;
            m_prize4 = 0;
            m_prize5 = 0;
            m_Totalprize = 0;
            m_Gauge_money_Day = 0;
            m_TruePasswd = "";
            m_TrueCashBoxPass = "";
            m_TrueWithdrawalsPass = "";
            m_InComeTotal = 0;
            m_OutComeTotal = 0;
            m_allowtag = true;
            m_Addprize = 0;
            m_IsLog = 0;
            m_RateNum = 0;
        }
        public ezt_members(int userID, string accounts, string logonPasswd)
        {
            m_pid = userID;
            m_id = accounts;
            m_passwd = logonPasswd;
        }

        /// <summary>
        /// 初始化实例对象
        /// </summary>
        /// <param name="userTicket"></param>
        public ezt_members(UserTicketInfo userTicket)
            : this(userTicket.Pid, userTicket.Id, userTicket.Passwd)
        {
        }
        #endregion

        #region 公共属性
        /// <summary>
        /// 会员标识
        /// </summary>
        public int Pid
        {
            get { return m_pid; }
            set { m_pid = value; }
        }

        /// <summary>
        /// 帐号
        /// </summary>
        public string Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname
        {
            get { return m_nickname; }
            set { m_nickname = value; }
        }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal BalanceMoney
        {
            get { return m_BalanceMoney; }
            set { m_BalanceMoney = value; }
        }

        /// <summary>
        /// 金库余额
        /// </summary>
        public decimal CashMoney
        {
            get { return m_CashMoney; }
            set { m_CashMoney = value; }
        }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Passwd
        {
            get { return m_passwd; }
            set { m_passwd = value; }
        }

        /// <summary>
        /// 电话号
        /// </summary>
        public string Phone
        {
            get { return m_phone; }
            set { m_phone = value; }
        }

        /// <summary>
        /// 是否允许登录
        /// </summary>
        public bool Allowinvite
        {
            get { return m_allowinvite; }
            set { m_allowinvite = value; }
        }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime Reg_dt
        {
            get { return m_reg_dt; }
            set { m_reg_dt = value; }
        }

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime Update_dt
        {
            get { return m_update_dt; }
            set { m_update_dt = value; }
        }

        /// <summary>
        /// 登录IP
        /// </summary>
        public string IP
        {
            get { return m_IP; }
            set { m_IP = value; }
        }

        /// <summary>
        /// 代理标识
        /// </summary>
        public int ShopCode
        {
            get { return m_ShopCode; }
            set { m_ShopCode = value; }
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
        /// 汇款人
        /// </summary>
        public string BankAccount
        {
            get { return m_BankAccount; }
            set { m_BankAccount = value; }
        }

        /// <summary>
        /// 银行卡号
        /// </summary>
        public string BankNumber
        {
            get { return m_BankNumber; }
            set { m_BankNumber = value; }
        }

        /// <summary>
        /// 注册地址
        /// </summary>
        public string Remark1
        {
            get { return m_Remark1; }
            set { m_Remark1 = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark2
        {
            get { return m_Remark2; }
            set { m_Remark2 = value; }
        }

        /// <summary>
        /// 1正常  2踢出房间  3踢出游戏
        /// </summary>
        public int IsExit
        {
            get { return m_IsExit; }
            set { m_IsExit = value; }
        }

        /// <summary>
        /// 0会员 1看牌 2机器人
        /// </summary>
        public int UserType
        {
            get { return m_UserType; }
            set { m_UserType = value; }
        }

        /// <summary>
        /// 金库密码
        /// </summary>
        public string CashBoxPass
        {
            get { return m_CashBoxPass; }
            set { m_CashBoxPass = value; }
        }

        /// <summary>
        /// 提款密码
        /// </summary>
        public string WithdrawalsPass
        {
            get { return m_WithdrawalsPass; }
            set { m_WithdrawalsPass = value; }
        }

        /// <summary>
        /// 自己押注金额
        /// </summary>
        public decimal Gauge_money
        {
            get { return m_Gauge_money; }
            set { m_Gauge_money = value; }
        }

        /// <summary>
        /// 上级会员标识
        /// </summary>
        public int UpmembersPID
        {
            get { return m_UpmembersPID; }
            set { m_UpmembersPID = value; }
        }

        /// <summary>
        /// 总押注金额
        /// </summary>
        public decimal TotalAllGauge_money
        {
            get { return m_TotalAllGauge_money; }
            set { m_TotalAllGauge_money = value; }
        }

        /// <summary>
        /// 返钱比例1
        /// </summary>
        public decimal Prize1
        {
            get { return m_prize1; }
            set { m_prize1 = value; }
        }

        /// <summary>
        /// 返钱比例2
        /// </summary>
        public decimal Prize2
        {
            get { return m_prize2; }
            set { m_prize2 = value; }
        }

        /// <summary>
        /// 返钱比例3
        /// </summary>
        public decimal Prize3
        {
            get { return m_prize3; }
            set { m_prize3 = value; }
        }

        /// <summary>
        /// 返钱比例4
        /// </summary>
        public decimal Prize4
        {
            get { return m_prize4; }
            set { m_prize4 = value; }
        }

        /// <summary>
        /// 返钱比例5
        /// </summary>
        public decimal Prize5
        {
            get { return m_prize5; }
            set { m_prize5 = value; }
        }

        /// <summary>
        /// 总返钱金额
        /// </summary>
        public decimal Totalprize
        {
            get { return m_Totalprize; }
            set { m_Totalprize = value; }
        }

        /// <summary>
        /// 日押注金额
        /// </summary>
        public decimal Gauge_money_Day
        {
            get { return m_Gauge_money_Day; }
            set { m_Gauge_money_Day = value; }
        }

        /// <summary>
        /// 登录密码明文
        /// </summary>
        public string TruePasswd
        {
            get { return m_TruePasswd; }
            set { m_TruePasswd = value; }
        }

        /// <summary>
        /// 金库密码明文
        /// </summary>
        public string TrueCashBoxPass
        {
            get { return m_TrueCashBoxPass; }
            set { m_TrueCashBoxPass = value; }
        }

        /// <summary>
        /// 提款密码明文
        /// </summary>
        public string TrueWithdrawalsPass
        {
            get { return m_TrueWithdrawalsPass; }
            set { m_TrueWithdrawalsPass = value; }
        }

        /// <summary>
        /// 总充值金额
        /// </summary>
        public decimal InComeTotal
        {
            get { return m_InComeTotal; }
            set { m_InComeTotal = value; }
        }

        /// <summary>
        /// 总提款金额
        /// </summary>
        public decimal OutComeTotal
        {
            get { return m_OutComeTotal; }
            set { m_OutComeTotal = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Allowtag
        {
            get { return m_allowtag; }
            set { m_allowtag = value; }
        }

        /// <summary>
        /// 后台给会员钱
        /// </summary>
        public int Addprize
        {
            get { return m_Addprize; }
            set { m_Addprize = value; }
        }

        /// <summary>
        /// 0未登录 1已登录
        /// </summary>
        public int IsLog
        {
            get { return m_IsLog; }
            set { m_IsLog = value; }
        }

        /// <summary>
        /// 水子
        /// </summary>
        public int RateNum
        {
            get { return m_RateNum; }
            set { m_RateNum = value; }
        }
        #endregion

        #region ezt_members 对象 到 UserTicketInfo 转换

        /// <summary>
        /// ezt_members 对象 到 UserTicketInfo 转换
        /// </summary>
        /// <returns></returns>
        public UserTicketInfo ToUserTicketInfo()
        {
            return ToUserTicketInfo(this);
        }


        /// <summary>
        /// ezt_members 对象 到 UserTicketInfo 转换
        /// </summary>
        /// <param name="suInfo"></param>
        /// <returns></returns>
        public UserTicketInfo ToUserTicketInfo(ezt_members suInfo)
        {
            return new UserTicketInfo(suInfo.Pid, suInfo.Id, suInfo.Passwd);
        }

        #endregion
    }
}
