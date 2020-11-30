using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 NewReg。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class NewReg
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "NewReg";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _Idx = "Idx";

        /// <summary>
        /// 会员标识
        /// </summary>
        public const string _Pid = "Pid";

        #endregion

        #region 私有变量
        private int m_Idx;					//标识
        private string m_Pid;					//会员标识
      
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化NewReg
        /// </summary>
        public NewReg()
        {
            m_Idx = 0;
            m_Pid = "";
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
        /// 会员标识
        /// </summary>
        public string Pid
        {
            get { return m_Pid; }
            set { m_Pid = value; }
        }

        #endregion
    }
}
