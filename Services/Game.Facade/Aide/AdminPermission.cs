using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Game.Entity;
using Game.Entity.Troy;

namespace Game.Facade
{
    /// <summary>
    /// 用户权限
    /// </summary>
    public class AdminPermission
    {
        #region Fields

        private Base_Users _user;

        private int _moduleID = 0;

        private Dictionary<string, long> _userPriv;
        #endregion

        #region 属性

        /// <summary>
        /// 用户实体
        /// </summary>
        public Base_Users User
        {
            get { return _user; }
            set { _user = value; }
        }
        /// <summary>
        /// 模块标识
        /// </summary>
        public int ModuleID
        {
            get { return _moduleID; }
            set { _moduleID = value; }
        }

        /// <summary>
        /// 用户权限-->取决于用户的角色权限，不存在角色之外的权限
        /// </summary>
        public Dictionary<string, long> UserPermission
        {
            get { return _userPriv; }
            set { _userPriv = value; }
        }

        #endregion

        #region 构造函数

        /// <summary>
        /// 初始化权限验证类的基础数据
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <param name="moduleID">模块标识</param>
        public AdminPermission(Base_Users user, int moduleID)
        {
            User = user;
            ModuleID = moduleID;
            UserPermission = new NewTroyFacade().GetPermissionByUserID(user.UserID);
        }

        #endregion

        #region 用户权限判断: 有权限:true ; 无权限: false;

        /// <summary>给出用户权限，返回 bool 值</summary>
        /// <param name="modelid">当前需要判断模块的模块标识</param>
        /// <param name="authValue">当前模块ModelID中需要判断的权限码</param>
        /// <returns>bool值</returns>
        public bool GetPermission(long authValue)
        {
            bool havePermission = true;
            //超级管理员(一切权限)
            if (User.RoleID == ApplicationConfig.SUPER_ADMINISTRATOR_ID)
            {
                return havePermission;
            }
            long privValue = 0;
            //如果存在需要判断权限的模块标识的权限值
            if (UserPermission.TryGetValue(ModuleID.ToString().Trim(), out privValue))
            {
                if ((privValue & authValue) > 0)
                {
                    return havePermission;
                }
                else
                {
                    havePermission = false;
                }
            }
            else
            {
                havePermission = false;
            }
            return havePermission;
        }

        /// <summary>
        /// 判断页面的访问权限
        /// </summary>
        /// <param name="modelid"></param>
        /// <returns></returns>
        public bool GetUserPagePermission()
        {
            bool havePermission = true;
            //超级管理员(一切权限)
            if (User.RoleID == ApplicationConfig.SUPER_ADMINISTRATOR_ID)
            {
                return havePermission;
            }
            long privValue = 0;
            //如果存在需要判断权限的模块标识的权限值
            if (UserPermission.TryGetValue(ModuleID.ToString().Trim(), out privValue))
            {
                havePermission = true;
            }
            else
            {
                havePermission = false;
            }
            return havePermission;
        }

        #endregion
    }
}
