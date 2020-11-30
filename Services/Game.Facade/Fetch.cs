using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Web;

using Game.Entity;
using Game.Kernel;
//using Game.Kernel.DBLink;
using Game.Utils;
using Game.Entity.Troy;

namespace Game.Facade
{
    /// <summary>
    /// 为网站提供全局服务，如：用户Cookie读写等等
    /// </summary>
    public sealed class Fetch
    {
        #region Fields

        private const string UC_COOKIE_NAME = "Baduki";                 //Cookie 组名称
        private const string UC_COOKIE_LOGON_TOKEN = "NewTroyGame";       //登录Cookie令牌
        private const string CookieEncryptKey = "BDKGame_long";              //Cookie加密文本

        //private static ISoapHeaderUC m_soapHeaderUC= null;                      //授权配置
        //private static List<string> m_protectionQuestiongs = null;              //密保问题        

        private static NewTroyFacade NewTroyData = null;                        //用户外观

        #endregion

        #region 构造方法
        //
        private Fetch()
        { }

        //
        static Fetch()
        {
            NewTroyData = new NewTroyFacade();
        }

        #endregion

        #region 公开属性

        /// <summary>
        /// 站点标识
        /// </summary>
        public static int StationID
        {
            get
            {
                return 1;
            }
        }

        /// <summary>
        /// 网站根路径
        /// </summary>
        public static string WebRoot
        {
            get { return "/"; }
        }

        #endregion

        #region 网站相关

        /// <summary>
        /// 获取验证码数值
        /// </summary>
        /// <returns></returns>
        public static string GetVerifyCode()
        {
            string vcode = "";
            if (HttpContext.Current != null && HttpContext.Current.Session != null)
            {
                vcode = SessionState.Get(Fetch.UC_VERIFY_CODE_KEY) as string;
                //Session 保存，无需解密
                if (!string.IsNullOrEmpty(vcode))
                {
                    return vcode;
                }
            }
            else
            {
                vcode = Utility.GetCookie(Fetch.UC_VERIFY_CODE_KEY);
            }

            if (!String.IsNullOrEmpty(vcode))
            {
                vcode = Utils.CWHEncryptNet.XorCrevasse(vcode);
            }

            return vcode;
        }

        #endregion

        #region 用户相关

        /// <summary>
        /// 根据用户ID获取用户名
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static string GetAccountsByUserID(int userID)
        {
            return NewTroyData.GetMembersByUserid(userID) == null ? "" : NewTroyData.GetMembersByUserid(userID).Id;
        }

        /// <summary>
        /// 获取ID号码描述，没分配 显示 “尚未分配”
        /// </summary>
        /// <param name="gameID"></param>
        /// <returns></returns>
        public static string GetGameID(int gameID)
        {
            if (gameID <= 0) return "尚未分配";

            return gameID.ToString();
        }

        /// <summary>
        /// 获取用户标识
        /// </summary>
        /// <param name="strUserID"></param>
        /// <returns></returns>
        public static int GetUserID(string strUserID)
        {
            int dwUserID = TypeParse.StrToInt(CWHEncryptNet.XorCrevasse(strUserID), 0);
            return dwUserID;
        }

        /// <summary>
        /// 获取加密后的用户标识
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static string GetStrUserID(int userID)
        {
            return CWHEncryptNet.XorEncrypt(userID.ToString());
        }


        #endregion

        #region cookie

        #region 常规读写

        /// <summary>
        /// 写 Cookies
        /// </summary>
        /// <param name="strName">项</param>
        /// <param name="strValue">值</param>
        public static void SetCookie(string strName, string strValue)
        {
            HttpContext context = HttpContext.Current;
            if (context == null)
            {
                return;
            }

            HttpCookie cookie = context.Request.Cookies[UC_COOKIE_NAME];
            if (cookie == null)
            {
                cookie = new HttpCookie(UC_COOKIE_NAME);
                cookie.Values[strName] = HttpUtility.UrlEncode(strValue);
            }
            else
            {

                cookie.Values[strName] = Utility.UrlEncode(strValue);
                if (context.Request.Cookies[UC_COOKIE_NAME]["expires"] != null)
                {
                    int expires = TypeParse.StrToInt(context.Request.Cookies[UC_COOKIE_NAME]["expires"].ToString(), 0);
                    if (expires > 0)
                    {
                        cookie.Expires = DateTime.Now.AddMinutes(TypeParse.StrToInt(context.Request.Cookies[UC_COOKIE_NAME]["expires"].ToString(), 0));
                    }
                }
            }

            context.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="strName">名称</param>
        /// <param name="intValue">值</param>
        public static void SetCookie(string strName, int intValue)
        {
            SetCookie(strName, intValue.ToString());
        }

        /// <summary>
        /// 获得网站cookie值
        /// </summary>
        /// <param name="strName">项</param>
        /// <returns>值</returns>
        public static string GetCookie(string strName)
        {
            HttpContext context = HttpContext.Current;
            if (context == null)
            {
                return "";
            }

            if (context.Request.Cookies != null
                && context.Request.Cookies[UC_COOKIE_NAME] != null
                && context.Request.Cookies[UC_COOKIE_NAME][strName] != null)
            {
                return HttpUtility.UrlDecode(context.Request.Cookies[UC_COOKIE_NAME][strName].ToString());
            }

            return "";
        }

        /// <summary>
        /// 删除 Cookies by Cookie 键值
        /// </summary>
        /// <param name="cookieName"></param>
        public static void DeleteCookie(string cookieName)
        {
            HttpContext context = HttpContext.Current;
            if (context == null)
            {
                return;
            }

            HttpCookie cookie = new HttpCookie(cookieName);
            cookie.Values.Clear();
            cookie.Expires = DateTime.Now.AddYears(-1);

            context.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 删除 Cookies
        /// </summary>
        public static void DeleteSiteCookies()
        {
            DeleteCookie(UC_COOKIE_NAME);
        }

        #endregion

        #region User cookie

        /// <summary>
        /// 设置用户cookie
        /// </summary>
        /// <param name="userTicket"></param>
        public static void SetUserCookie(UserTicketInfo userTicket)
        {
            if (userTicket == null)
            {
                return;
            }

            string jsonText = userTicket.SerializeText();
            string ciphertext = Utils.AES.Encrypt(jsonText, CookieEncryptKey);
            Fetch.SetCookie(Fetch.UC_COOKIE_LOGON_TOKEN, ciphertext);
        }

        /// <summary>
        /// 获取用户对象
        /// </summary>
        /// <returns></returns>
        public static UserTicketInfo GetUserCookie()
        {
            //平台跳转判断是否登录
            if (HttpContext.Current.Request.Cookies["Accounts"] != null && HttpContext.Current.Request.Cookies["Password"] != null)
            {
                //string userID = HttpContext.Current.Request.Cookies["UserID"].Value.ToString( );
                //string gameID = HttpContext.Current.Request.Cookies["GameID"].Value.ToString( );
                string accounts = HttpContext.Current.Request.Cookies["Accounts"].Value.ToString();
                string password = HttpContext.Current.Request.Cookies["Password"].Value.ToString();
                //userID = userID.Trim( );
                //gameID = gameID.Trim( );
                password = password.Trim();
                accounts = accounts.Trim();
                ezt_members suInfo = new ezt_members(0, accounts, password.Trim());
                suInfo.IP = GameRequest.GetUserIP();
                NewTroyFacade NewTroyFacade = new NewTroyFacade();
                Message umsg = NewTroyFacade.Logon(suInfo, true);
                if (umsg.Success)
                {
                    ezt_members ui = umsg.EntityList[0] as ezt_members;
                    ui.Passwd = password.Trim();
                    Fetch.SetUserCookie(ui.ToUserTicketInfo());
                }
            }

            string plaintext = Fetch.GetCookie(Fetch.UC_COOKIE_LOGON_TOKEN);
            if (TextUtility.EmptyTrimOrNull(plaintext))
            {
                return null;
            }

            string jsonText = Utils.AES.Decrypt(plaintext, CookieEncryptKey);
            if (TextUtility.EmptyTrimOrNull(jsonText))
            {
                return null;
            }

            return UserTicketInfo.DeserializeObject(jsonText);
        }

        /// <summary>
        /// 删除用户cookie
        /// </summary>
        public static void DeleteUserCookie()
        {
            Fetch.SetCookie(Fetch.UC_COOKIE_LOGON_TOKEN, "");
        }

        /// <summary>
        /// 用户是否在线 判断用户登录 cookie
        /// 在线 true 离线 false
        /// </summary>
        /// <returns></returns>
        public static bool IsUserOnline()
        {
            UserTicketInfo uti = Fetch.GetUserCookie();
            if (uti == null || uti.Pid <= 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 后台登录并重写 Cookie
        /// </summary>
        public static void ReWriteUserCookie()
        {
            if (Fetch.IsUserOnline())
            {
                UserTicketInfo uti = Fetch.GetUserCookie();
                Message msg = NewTroyData.Logon(new ezt_members(uti), false);
                if (msg.Success)
                {
                    ezt_members usInfo = msg.EntityList[0] as ezt_members;
                    UserTicketInfo utiServer = usInfo.ToUserTicketInfo();
                    utiServer.Passwd = uti.Passwd;

                    Fetch.SetUserCookie(utiServer);
                }
            }
        }

        #endregion

        #endregion

        #region 系统信息

        /// <summary>
        /// 获取缓存的使用状况
        /// </summary>
        /// <returns></returns>
        public static string GetCacheCurrentRunStatus()
        {
            StringBuilder builderCacheName = new StringBuilder();
            StringBuilder builderText = new StringBuilder();
            IDictionaryEnumerator a = HttpRuntime.Cache.GetEnumerator();

            a.Reset();
            a.MoveNext();

            for (int i = 0; i < HttpRuntime.Cache.Count; i++)
            {
                builderCacheName.Append(a.Key);
                if (i < HttpRuntime.Cache.Count - 1) builderCacheName.Append("&#10;&#13;");

                a.MoveNext();
            }

            //输出状态   
            builderText.AppendFormat("内存使用量：{0}KB &nbsp; ", (GC.GetTotalMemory(false) / 1024).ToString("#,#"));
            builderText.AppendFormat("共使用 <span title=\"{1}\">{0}</span> 个系统缓存对象", HttpRuntime.Cache.Count, builderCacheName.ToString());

            return builderText.ToString();
        }

        #endregion

        #region 常规变量

        /// <summary>
        /// 验证码Session键值
        /// </summary>
        public const string UC_VERIFY_CODE_KEY = "bdk_verifycode_key";

        /// <summary>
        /// 密码允许错误次数
        /// </summary>
        public const int DW_PASSWD_ERROR_COUNT = 3;
        #endregion

    }
}
