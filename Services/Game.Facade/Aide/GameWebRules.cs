using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Entity.Troy;
using Game.Kernel;
using Game.Utils;

namespace Game.Facade
{
    /// <summary>
    /// 规则检查
    /// </summary>
    public class GameWebRules
    {
        #region Fields

        /// <summary>
        /// 登录密码最小长度
        /// </summary>
        internal static int MIN_LOGONPASSWD_LENGTH = 6;

        #endregion

        #region 登录检查

        /// <summary>
        /// 帐号登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Message CheckedUserLogon(Base_Users user)
        {
            //用户帐号
            Message msg = GameWebRules.CheckedAccounts(user.Username);
            if (!msg.Success)
                return msg;

            //用户密码
            msg = GameWebRules.CheckedPassword(user.Password);
            if (!msg.Success)
                return msg;

            user.Username = TextUtility.SqlEncode(user.Username);
            user.Username = Utility.HtmlEncode(TextFilter.FilterScript(user.Username));

            return new Message(true);
        }

        #endregion
               
        #region 资料修改

        /// <summary>
        /// 资料修改
        /// </summary>
        /// <param name="userExt">可根据用户可修改的项在此增加用户更改的字段</param>
        /// <returns></returns>
        public static Message CheckedUserToModify(ref Base_Users user)
        {
            Message msg = new Message(false);

            //邮件地址
            /*  msg = GameWebRules.CheckedEmail(user.LinkEmail);
              if (!msg.Success)
                  return msg;

              user.RealName = Utility.HtmlEncode(Utils.TextFilter.FilterScript(user.RealName));
              user.LinkEmail = Utility.HtmlEncode(Utils.TextFilter.FilterScript(user.LinkEmail));
  */
            return new Message(true);
        }
        #endregion

        #region 密码修改
        /// <summary>
        /// 密码修改
        /// </summary>
        /// <param name="oldPasswd"></param>
        /// <param name="newPasswd"></param>
        /// <returns></returns>
        public static Message CheckUserPasswordForModify(ref string oldPasswd, ref string newPasswd)
        {
            if (TextUtility.EmptyTrimOrNull(oldPasswd))
                return new Message(false, "原密码不能为空。");

            Message msg = GameWebRules.CheckedPassword(newPasswd);
            if (!msg.Success)
                return msg;

            return new Message(true);
        }
        #endregion

        #region 常规检查

        /// <summary>
        /// 检查用户帐号
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public static Message CheckedAccounts(string accounts)
        {
            //用户帐号
            if (TextUtility.EmptyTrimOrNull(accounts))
                return new Message(false, "用户帐号为空。");

            return new Message(true);
        }

        /// <summary>
        /// 检查登录密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Message CheckedPassword(string password)
        {
            //登录密码
            if (TextUtility.EmptyTrimOrNull(password))
                return new Message(false, "密码为空。");

            if (password.Length < GameWebRules.MIN_LOGONPASSWD_LENGTH)
                return new Message(false, "密码长度最少为6位。");

            return new Message(true);
        }

        /// <summary>
        /// 检查用户姓名
        /// </summary>
        /// <param name="realname"></param>
        /// <returns></returns>
        public static Message CheckedRealname(string realname)
        {
            //真实姓名
            if (TextUtility.EmptyTrimOrNull(realname))
                return new Message(false, "用户姓名为空。");

            return new Message(true);
        }

        /// <summary>
        /// 检查 Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Message CheckedEmail(string email)
        {
            if (TextUtility.EmptyTrimOrNull(email))
                return new Message(false, "邮件地址为空。");

            if (!Validate.IsEmail(email))
                return new Message(false, "邮件地址非法。");

            return new Message(true);
        }

        #endregion
    }
}
