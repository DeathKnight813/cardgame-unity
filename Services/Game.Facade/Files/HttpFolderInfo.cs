using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Facade.Files
{
    /// <summary>
    /// 文件夹信息(Http 方式处理文件)
    /// </summary>
    public class HttpFolderInfo
    {
        #region Fields

        private string m_name;
        private string m_fullName;
        private string m_formatName;
        private string m_extName;
        private long m_size;
        private string m_type;
        private DateTime m_modifyDate;

        #endregion

        #region 构造方法

        /// <summary>
        /// 构造方法
        /// </summary>
        public HttpFolderInfo()
        {
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="p_name">文件名</param>
        /// <param name="p_fullName">包含完整路径的文件名</param>
        /// <param name="p_formatName">处理过的文件名, 含超链接</param>
        /// <param name="p_ext">扩展名</param>
        /// <param name="p_size">文件大小</param>
        /// <param name="p_type">类型</param>
        /// <param name="p_modifyDate">修改日期</param>
        public HttpFolderInfo(string p_name, string p_fullName, string p_formatName, string p_ext, long p_size, string p_type, DateTime p_modifyDate)
        {
            m_name = p_name;
            m_fullName = p_fullName;
            m_formatName = p_formatName;
            m_extName = p_ext;
            m_size = p_size;
            m_type = p_type;
            m_modifyDate = p_modifyDate;
        }

        #endregion

        #region 公开属性

        /// <summary>
        /// 文件名
        /// </summary>
        public string Name
        {
            get { return m_name; }
        }

        /// <summary>
        /// 包含完整路径的文件名
        /// </summary>
        public string FullName
        {
            get { return m_fullName; }
        }

        /// <summary>
        /// 文件名, 含超链接 (已处理)
        /// </summary>
        public string FormatName
        {
            get { return m_formatName; }
        }

        /// <summary>
        /// 扩展名
        /// </summary>
        public string ExtName
        {
            get { return m_extName; }
        }

        /// <summary>
        /// 文件大小 (已处理)
        /// </summary>
        public string FormatSize
        {
            get
            {
                if (m_size == 0)
                {
                    return string.Empty;
                }

                if (this.m_size.ToString().Length < 8)
                {
                    return m_size / 1024 + " KB";
                }
                else
                {
                    return m_size / 1024 / 1024 + " MB";
                }
            }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            get { return m_type; }
        }

        /// <summary>
        /// 修改日期 (已处理)
        /// </summary>
        public string FormatModifyDate
        {
            get { return DateTime.Parse(m_modifyDate.ToString("U")).AddHours(8).ToString("yyyy-MM-dd hh:mm:ss"); }
        }

        #endregion
    }
}
