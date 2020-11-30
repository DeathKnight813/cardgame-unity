using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 tb_notice。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class tb_notice
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "tb_notice";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _Idx = "Idx";

        /// <summary>
        /// 标题
        /// </summary>
        public const string _Title = "Title";

        /// <summary>
        /// 内容
        /// </summary>
        public const string _Content = "Content";

        /// <summary>
        /// 添加时间
        /// </summary>
        public const string _Create_Date = "Create_Date";

        /// <summary>
        /// 
        /// </summary>
        public const string _IsHome = "IsHome";

        /// <summary>
        /// 
        /// </summary>
        public const string _Remark = "Remark";

        /// <summary>
        /// 1公告 2新闻 3游戏滚动公告 4主页滚动公告 5首页弹出页面上部  6首页弹出页面下部
        /// </summary>
        public const string _Notice_Type = "Notice_Type";

        #endregion

        #region 私有变量
        private int m_Idx;			         //标识
        private string m_Title;              //标题
        private string m_Content;           //内容
        private DateTime m_Create_Date;      //添加时间 
        private bool m_IsHome;
        private string m_Remark;
        private int m_Notice_Type;                 //1公告 2新闻 3游戏滚动公告 4主页滚动公告 5首页弹出页面上部  6首页弹出页面下部
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化tb_notice
        /// </summary>
        public tb_notice()
        {
            m_Idx = 0;
            m_Title = "";
            m_Content = "";
            m_Create_Date = DateTime.Now;
            m_IsHome = false;
            m_Remark = "";
            m_Notice_Type = 0;
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
        /// 标题
        /// </summary>
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get { return m_Content; }
            set { m_Content = value; }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime Create_Date
        {
            get { return m_Create_Date; }
            set { m_Create_Date = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsHome
        {
            get { return m_IsHome; }
            set { m_IsHome = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            get { return m_Remark; }
            set { m_Remark = value; }
        }

        /// <summary>
        /// 1公告 2新闻 3游戏滚动公告 4主页滚动公告 5首页弹出页面上部  6首页弹出页面下部
        /// </summary>
        public int Notice_Type
        {
            get { return m_Notice_Type; }
            set { m_Notice_Type = value; }
        }
        #endregion
    }
}