using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Game.Utils;
using System.Web.Security;
using Game.Entity.Troy;

namespace Game.Facade
{
    /// <summary>
    /// 用户Cookie数据
    /// </summary>
    public class AdminCookie
    {

        /// <summary>
        /// 设置用户 Cookie
        /// </summary>
        /// <param name="user"></param>
        public static void SetUserCookie(Base_Users user)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add(Base_Users._UserID, user.UserID);
            dic.Add(Base_Users._Username, user.Username);
            dic.Add(Base_Users._RoleID, user.RoleID);
            Add(dic, 600);
        }

        /// <summary>
        /// 获取用户对象 by Cookie
        /// </summary>
        /// <returns></returns>
        public static Base_Users GetUserFromCookie()
        {
            HttpContext context = HttpContext.Current;
            if (context == null)
                return null;

            Base_Users user = new Base_Users();
            object objUserID = GetValue(Base_Users._UserID);
            object objAccount = GetValue(Base_Users._Username);
            object objStates = GetValue(Base_Users._RoleID);
            if (objUserID == null || objAccount == null)
                return null;
            user.UserID = int.Parse(objUserID.ToString());
            user.Username = objAccount.ToString();
            user.RoleID = int.Parse(objStates.ToString());
            return user;
        }

        /// <summary>
        /// 清理用户Cookie
        /// </summary>
        public static void ClearUserCookie()
        {
            if (HttpContext.Current == null)
                return;

            HttpCookie cookie = HttpContext.Current.Request.Cookies[Fetch.GetCookieName];
            cookie.Expires = DateTime.Now.AddYears(-1);
            HttpContext.Current.Response.Cookies.Add(cookie);
            //Cookie.Remove( cookie );
        }

        /// <summary>
        /// 检查用户登录状态
        /// </summary>
        /// <returns></returns>
        public static bool CheckedUserLogon()
        {
            Base_Users user = AdminCookie.GetUserFromCookie();
            if (user == null || user.UserID <= 0)
                return false;
            else
                AdminCookie.SetUserCookie(user);

            return true;
        }

        //根据键值获取Cookie值
        private static string GetCookie(string strKey)
        {
            return Utility.UrlDecode(Utility.GetCookie(Fetch.GetCookieName, strKey));
        }

        #region Cookie操作
        private static string ValidateKey = "{2EF1D4CB-16BA-471D-9DFC-12C1E4D15253}";
        private static string ValidateName = "NewTroy";
        private static string ExpireTimeStr = "_NewTroyETS";
        /// <summary>
        /// Cookie名称
        /// </summary>
        protected static string CookiesName
        {
            get
            {
                string strName = Utility.GetAppSetting("CookiesName");
                if (!string.IsNullOrEmpty(strName))
                {
                    return strName;
                }
                else if (!string.IsNullOrEmpty(Fetch.GetCookieName))
                {
                    return Fetch.GetCookieName;
                }
                return "Default";
            }
        }
        /// <summary>
        /// Cookie过期时间(分钟)
        /// </summary>
        protected static DateTime CookiesExpire
        {
            get
            {
                int num;
                if (!int.TryParse(Utility.GetAppSetting("CookiesExpireMinutes"), out num))
                {
                    num = 600;
                }
                return DateTime.Now.AddMinutes((double)num);
            }
        }
        /// <summary>
        /// Cookie路径
        /// </summary>
        protected static string CookiesPath
        {
            get
            {
                string strPath = Utility.GetAppSetting("CookiesPath");
                if (!string.IsNullOrEmpty(strPath))
                {
                    return strPath;
                }
                return "/";
            }
        }
        /// <summary>
        /// Cookie域
        /// </summary>
        protected static string CookiesDomain
        {
            get
            {
                string strDomain = Utility.GetAppSetting("CookiesDomain");
                if (!string.IsNullOrEmpty(strDomain))
                {
                    return strDomain;
                }
                return "";
            }
        }
        /// <summary>
        /// 设置用户Cookie
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="timeout">过期时间(分钟)</param>
        public static void Add(string key, object value, int? timeout)
        {
            HttpCookie ck = HttpContext.Current.Request.Cookies[CookiesName];
            if (ck == null)
            {
                ck = new HttpCookie(CookiesName);
            }
            ck.Expires = DateTime.Now.AddYears(50);
            ck.Domain = CookiesDomain;
            ck.Values[key] = HttpUtility.UrlEncode(value.ToString());
            ck.Values[key + ExpireTimeStr] = !timeout.HasValue ? HttpUtility.UrlEncode(CookiesExpire.ToString("yyyy-MM-dd HH:mm:ss")) : HttpUtility.UrlEncode(DateTime.Now.AddMinutes((double)timeout.Value).ToString("yyyy-MM-dd HH:mm:ss"));
            ck.Values[ValidateName] = GetValidateStr(ck);
            HttpContext.Current.Response.Cookies.Add(ck);
        }
        /// <summary>
        /// 设置用户Cookie
        /// </summary>
        /// <param name="dic">键值集合</param>
        /// <param name="timeout">过期时间(分钟)</param>
        public static void Add(Dictionary<string, object> dic, int? timeout)
        {
            HttpCookie ck = HttpContext.Current.Request.Cookies[CookiesName];
            if (ck == null)
            {
                ck = new HttpCookie(CookiesName);
            }
            ck.Expires = DateTime.Now.AddYears(50);
            ck.Domain = CookiesDomain;
            foreach (KeyValuePair<string, object> pair in dic)
            {
                ck.Values[pair.Key] = HttpUtility.UrlEncode(pair.Value.ToString());
                ck.Values[pair.Key + ExpireTimeStr] = !timeout.HasValue ? HttpUtility.UrlEncode(CookiesExpire.ToString("yyyy-MM-dd HH:mm:ss")) : HttpUtility.UrlEncode(DateTime.Now.AddMinutes((double)timeout.Value).ToString("yyyy-MM-dd HH:mm:ss"));
            }
            ck.Values[ValidateName] = GetValidateStr(ck);
            HttpContext.Current.Response.Cookies.Add(ck);
        }
        /// <summary>
        /// 根据键名获取Cookie值
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static object GetValue(string key)
        {
            if ((key != null) && (key != ""))
            {
                DateTime time;
                HttpCookie ck = HttpContext.Current.Request.Cookies[CookiesName];
                if (ck == null)
                {
                    return null;
                }
                ck.Expires = DateTime.Now.AddYears(50);
                ck.Domain = CookiesDomain;
                if (!ValidateCookies(ck))
                {
                    ck.Expires = DateTime.Now.AddYears(-1);
                    HttpContext.Current.Response.Cookies.Add(ck);
                    return null;
                }
                string str = ck.Values[key + ExpireTimeStr];
                if (string.IsNullOrEmpty(str) || !DateTime.TryParse(HttpUtility.UrlDecode(str), out time))
                {
                    ck.Values[key] = "";
                    ck.Values[key + ExpireTimeStr] = "";
                    ck.Values[ValidateName] = GetValidateStr(ck);
                    HttpContext.Current.Response.Cookies.Add(ck);
                    return null;
                }
                DateTime now = DateTime.Now;
                if (time > now)
                {
                    return HttpUtility.UrlDecode(ck.Values[key]);
                }
                ck.Values[key] = "";
                ck.Values[key + ExpireTimeStr] = "";
                ck.Values[ValidateName] = GetValidateStr(ck);
                HttpContext.Current.Response.Cookies.Add(ck);
            }
            return null;
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="ck"></param>
        /// <returns></returns>
        private static string GetValidateStr(HttpCookie ck)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string str in ck.Values.AllKeys)
            {
                if (str != ValidateName)
                {
                    builder.Append(ck.Values[str]);
                }
            }
            builder.Append(ValidateKey);
            builder.Append(HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"]);
            builder.Append(HttpContext.Current.Request.ServerVariables["INSTANCE_ID"]);
            builder.Append(HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"]);
            return FormsAuthentication.HashPasswordForStoringInConfigFile(builder.ToString(), "sha1").ToLower().Substring(8, 0x10);
        }
        /// <summary>
        ///  验证
        /// </summary>
        /// <param name="ck"></param>
        /// <returns></returns>
        private static bool ValidateCookies(HttpCookie ck)
        {
            string strSourse = ck.Values[ValidateName];
            StringBuilder builder = new StringBuilder();
            foreach (string str in ck.Values.AllKeys)
            {
                if (str != ValidateName)
                {
                    builder.Append(ck.Values[str]);
                }
            }
            builder.Append(ValidateKey);
            builder.Append(HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"]);
            builder.Append(HttpContext.Current.Request.ServerVariables["INSTANCE_ID"]);
            builder.Append(HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"]);
            string strValidate = FormsAuthentication.HashPasswordForStoringInConfigFile(builder.ToString(), "sha1").ToLower().Substring(8, 0x10);
            return strSourse.Equals(strValidate);
        }
        #endregion
    }
}
