using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 MoneyBack。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MoneyBack
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "MoneyBack";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _Idx = "Idx";

        /// <summary>
        /// 返钱帐号
        /// </summary>
        public const string _Name = "Name";

        /// <summary>
        /// 反的钱数
        /// </summary>
        public const string _money = "money";

        #endregion

        #region 私有变量
        private int m_Idx;					//标识
        private string m_Name;					//返钱帐号
        private decimal m_money;					//反的钱数

        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化MoneyBack
        /// </summary>
        public MoneyBack()
        {
            m_Idx = 0;
            m_Name = "";
            m_money = 0;
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
        /// 返钱帐号
        /// </summary>
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        /// <summary>
        /// 反的钱数
        /// </summary>
        public decimal money
        {
            get { return m_money; }
            set { m_money = value; }
        }

        #endregion
    }
}
