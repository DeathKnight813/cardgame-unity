using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 模块页面类
    /// </summary>
    [Serializable]
    public class ModulePage
    {
        private int m_moduleID;
        private string m_moduleName;
        private string m_pageName;

        /// <summary>
        /// 初始化模块页面
        /// </summary>
        public ModulePage()
        { }

        /// <summary>
        /// 初始化模块页面
        /// </summary>
        /// <param name="moduleID"></param>
        /// <param name="moduleName"></param>
        /// <param name="pageName"></param>
        public ModulePage(int moduleID, string moduleName, string pageName)
        {
            m_moduleID = moduleID;
            m_moduleName = moduleName;
            m_pageName = pageName;
        }

        /// <summary>
        /// 模块标识
        /// </summary>
        public int ModuleID
        {
            get { return m_moduleID; }
            set { m_moduleID = value; }
        }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName
        {
            get { return m_moduleName; }
            set { m_moduleName = value; }
        }

        /// <summary>
        /// 页面名称
        /// </summary>
        public string PageName
        {
            get { return m_pageName; }
            set { m_pageName = value; }
        }
    }
}
