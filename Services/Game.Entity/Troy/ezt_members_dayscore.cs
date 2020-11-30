using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 ezt_members_dayscore。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ezt_members_dayscore
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "ezt_members_dayscore";

        /// <summary>
        /// 用户标识
        /// </summary>
        public const string _pid = "pid";

        /// <summary>
        /// 周一
        /// </summary>
        public const string _Monday = "Monday";

        /// <summary>
        /// 周二
        /// </summary>
        public const string _Tuesday = "Tuesday";

        /// <summary>
        /// 周三
        /// </summary>
        public const string _Wednesday = "Wednesday";

        /// <summary>
        /// 周四
        /// </summary>
        public const string _Thursday = "Thursday";

        /// <summary>
        /// 周五
        /// </summary>
        public const string _Friday = "Friday";

        /// <summary>
        /// 周六
        /// </summary>
        public const string _Saturday = "Saturday";

        /// <summary>
        /// 周日
        /// </summary>
        public const string _Sunday = "Sunday";

        /// <summary>
        /// 1返钱  0不返钱
        /// </summary>
        public const string _rateType = "rateType";

        /// <summary>
        /// 返钱比例
        /// </summary>
        public const string _rateNum = "rateNum";

        /// <summary>
        /// 返的钱数
        /// </summary>
        public const string _rateMoney = "rateMoney";

        #endregion

        #region 私有变量
        private int m_pid;
        private decimal m_Monday;
        private decimal m_Tuesday;
        private decimal m_Wednesday;
        private decimal m_Thursday;
        private decimal m_Friday;
        private decimal m_Saturday;
        private decimal m_Sunday;
        private int m_rateType;
        private int m_rateNum;
        private decimal m_rateMoney;
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化NewTroy
        /// </summary>
        public ezt_members_dayscore()
        {
            m_pid = 0;
            m_Monday = 0;
            m_Tuesday = 0;
            m_Wednesday = 0;
            m_Thursday = 0;
            m_Friday = 0;
            m_Saturday = 0;
            m_Sunday = 0;
            m_rateType = 0;
            m_rateNum = 0;
            m_rateMoney = 0;
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 标识
        /// </summary>
        public int pid
        {
            set { m_pid = value; }
            get { return m_pid; }
        }
        /// <summary>
        /// 周一
        /// </summary>
        public decimal Monday
        {
            set { m_Monday = value; }
            get { return m_Monday; }
        }

        /// <summary>
        /// 周二
        /// </summary>
        public decimal Tuesday
        {
            set { m_Tuesday = value; }
            get { return m_Tuesday; }
        }

        /// <summary>
        /// 周三
        /// </summary>
        public decimal Wednesday
        {
            set { m_Wednesday = value; }
            get { return m_Wednesday; }
        }

        /// <summary>
        /// 周四
        /// </summary>
        public decimal Thursday
        {
            set { m_Thursday = value; }
            get { return m_Thursday; }
        }

        /// <summary>
        /// 周五
        /// </summary>
        public decimal Friday
        {
            set { m_Friday = value; }
            get { return m_Friday; }
        }

        /// <summary>
        /// 周六
        /// </summary>
        public decimal Saturday
        {
            set { m_Saturday = value; }
            get { return m_Saturday; }
        }

        /// <summary>
        /// 周日
        /// </summary>
        public decimal Sunday
        {
            set { m_Sunday = value; }
            get { return m_Sunday; }
        }

        /// <summary>
        /// 1返钱  0不返钱
        /// </summary>
        public int rateType
        {
            set { m_rateType = value; }
            get { return m_rateType; }
        }

        /// <summary>
        /// 返钱比例
        /// </summary>
        public int rateNum
        {
            set { m_rateNum = value; }
            get { return m_rateNum; }
        }

        /// <summary>
        /// 返的钱数
        /// </summary>
        public decimal rateMoney
        {
            set { m_rateMoney = value; }
            get { return m_rateMoney; }
        }

        #endregion
    }
}
