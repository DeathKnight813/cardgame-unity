using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 tb_configModel。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tb_config
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "tb_config";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _idx = "idx";

        /// <summary>
        /// 开始时间
        /// </summary>
        public const string _BeginTime = "BeginTime";

        /// <summary>
        /// 结束时间
        /// </summary>
        public const string _EndTime = "EndTime";

        /// <summary>
        /// 备注
        /// </summary>
        public const string _Remark = "Remark";
        #endregion

        #region 私有变量
        private int m_idx;					//标识
        private string m_BeginTime;				//开始时间
        private string m_EndTime;			//结束时间
        private string m_Remark;            //备注
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化tb_configModel
        /// </summary>
        public tb_config()
        {
            m_idx = 0;
            m_BeginTime = "";
            m_EndTime = "";
            m_Remark = "";
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 标识
        /// </summary>
        public int idx
        {
            get { return m_idx; }
            set { m_idx = value; }
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime
        {
            get { return m_BeginTime; }
            set { m_BeginTime = value; }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime
        {
            get { return m_EndTime; }
            set { m_EndTime = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get { return m_Remark; }
            set { m_Remark = value; }
        }
        #endregion
    }
}
