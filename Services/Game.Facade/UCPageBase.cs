using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using Game.Utils;
using Game.Kernel;
using Game.IData;
using System.Security.Cryptography;
using Game.Entity.Troy;

namespace Game.Facade
{
    /// <summary>
    /// 页面基类
    /// </summary>
    public abstract class UCPageBase : Page
    {
        #region Fields

        //标题间的分割线 "_"
        private const string SEPARATE_LINE = " - ";

        //是否验证用户身份
        private bool m_isAuthenticatedUser = false;

        //是否验证会员身份
        private bool m_isAuthenticatedMember = false;

        //是否在线
        private bool m_isOnLine = Fetch.IsUserOnline();

        //站点标识
        private int m_stationID = Fetch.StationID;

        /// <summary>
        /// 系统目录
        /// </summary>
        public const string ServerName = "/WAP";

        #endregion

        #region 继承属性

        /// <summary>
        /// 网站外观
        /// </summary>
        protected NewTroyFacade aideNewTroyFacade;
        protected NewTroyFacade aideNewTroyFacade2;

        /// <summary>
        /// 是否验证用户身份
        /// </summary>
        protected virtual bool IsAuthenticatedUser { get { return m_isAuthenticatedUser; } }

        /// <summary>
        /// 是否验证会员身份
        /// </summary>
        protected virtual bool IsAuthenticatedMember { get { return m_isAuthenticatedMember; } }

        /// <summary>
        /// 设置页面标题
        /// </summary>
        public virtual string ChannelTitle { get { return "首页"; } }

        /// <summary>
        /// 是否在线 在线 true 离线 false
        /// </summary>
        protected bool IsOnLine { get { return m_isOnLine; } }

        /// <summary>
        /// 个人中心登陆地址
        /// </summary>
        protected string LogonUrl;

        /// <summary>
        /// 原始请求地址
        /// </summary>
        protected string RawUrl;

        /// <summary>
        /// 重新定向地址
        /// </summary>
        protected string RedirectUrl;

        /// <summary>
        /// 用户基本Cookies信息
        /// </summary>
        protected UserTicketInfo userTicket;

        /// <summary>
        /// 站点标识
        /// </summary>
        protected int StationID { get { return m_stationID; } }

        #endregion

        #region 页面事件

        #region 构造方法
        /// <summary>
        /// 初始化页面基类
        /// </summary>
        public UCPageBase()
        {

            aideNewTroyFacade = new NewTroyFacade();
            aideNewTroyFacade2 = new NewTroyFacade(1);

            LogonUrl = "Main.aspx";
            RawUrl = Utils.GameRequest.GetUrl();
            RedirectUrl = Utility.UrlDecode(GameRequest.GetQueryString("redirectUrl"));
        }

        #endregion

        /// <summary>
        /// 初始化并验证用户身份
        /// </summary>
        /// <param name="e"></param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            //*
            if (IsAuthenticatedUser)
            {
                UserLogon();
            }
            else if (IsOnLine)
            {
                //在线 刷新 Cookie
                userTicket = Fetch.GetUserCookie();
            }
            //*/
            SetStyle();
        }

        /// <summary>
        /// 添加 links 和 javascript 到页面头部 header
		/// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //header标签
            AddHeaderTitle();

            if (!Page.IsCallback && !Page.IsPostBack)
            {
                AddDefaultLanguages();

                //link
                //AddGenericLink("image/x-icon", "shortcut icon", "", "/images/favicon.ico");
                //AddGenericLink("image/gif", "icon", "", "/images/animated_favicon1.gif");               

                //加载数据
                OnInitLoad();
            }
        }

        /// <summary>
        /// 添加页面标题
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRenderComplete(EventArgs e)
        {
            base.OnPreRenderComplete(e);
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        protected virtual void OnInitLoad()
        { }

        #endregion

        #region 追加标签

        /// <summary>
        /// 添加默认的样式语言
        /// </summary>
        protected virtual void AddDefaultLanguages()
        {
            Response.AppendHeader("Content-Style-Type", "text/css");
            Response.AppendHeader("Content-Script-Type", "text/javascript");
        }

        /// <summary>
        /// 页头
        /// </summary>
        protected virtual void AddHeaderTitle()
        {
            AddMetaTitle(ApplicationSettings.Get("title"));
        }

        /// <summary>
        /// 页头
        /// </summary>
        protected virtual void AddMetaTitle(string content)
        {
            //if (content == "") return;
            //HtmlTitle title = new HtmlTitle();
            //title.Text = content;
            //Page.Header.Controls.Add(title);
        }

        /// <summary>
        /// 添加 meta 标签到页面头部
        /// </summary>
        protected virtual void AddMetaTag(string name, string value)
        {
            //if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(value))
            //    return;

            //HtmlMeta meta = new HtmlMeta();
            //meta.Name = name;
            //meta.Content = value;
            //Page.Header.Controls.Add(meta);
        }

        /// <summary>
        /// 添加 meta 标签到页面头部
        /// </summary>
        /// <param name="httpEquiv"></param>
        /// <param name="content"></param>
        protected virtual void AddMetaTagForHttpEquiv(string httpEquiv, string content)
        {
            if (string.IsNullOrEmpty(httpEquiv) || string.IsNullOrEmpty(content))
                return;

            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = httpEquiv;
            meta.Content = content;
            Page.Header.Controls.Add(meta);
        }

        /// <summary>
        /// 添加一条常规 link 到页面头部
        /// </summary>
        public virtual void AddGenericLink(string relation, string title, string href)
        {
            HtmlLink link = new HtmlLink();
            link.Attributes["rel"] = relation;
            link.Attributes["title"] = title;
            link.Attributes["href"] = href;
            Page.Header.Controls.Add(link);
        }

        /// <summary>
        /// 添加常规 link 到页面头部
        /// </summary>
        public virtual void AddGenericLink(string type, string relation, string title, string href)
        {
            HtmlLink link = new HtmlLink();
            link.Attributes["type"] = type;
            link.Attributes["rel"] = relation;
            link.Attributes["title"] = title;
            link.Attributes["href"] = href;
            Page.Header.Controls.Add(link);
        }

        /// <summary>
        /// 添加一条 JavaScript 引用到页面头部 head 标签
        /// </summary>
        public virtual void AddJavaScriptInclude(string url)
        {
            HtmlGenericControl script = new HtmlGenericControl("script");
            script.Attributes["type"] = "text/javascript";
            script.Attributes["src"] = url;
            Page.Header.Controls.Add(script);
        }

        /// <summary>
        /// 添加样式引用到页面头部 head 标签
        /// </summary>
        /// <param name="url">相对路径</param>
        public virtual void AddStylesheetInclude(string url)
        {
            HtmlLink link = new HtmlLink();
            link.Attributes["type"] = "text/css";
            link.Attributes["href"] = url;
            link.Attributes["rel"] = "stylesheet";
            link.Attributes["media"] = "screen";
            Page.Header.Controls.Add(link);
        }

        /// <summary>
        /// 添加栏目描述到 meta description 标签
        /// </summary>
        protected virtual void AddMetaDescription(string description)
        {
            AddMetaTag("description", HttpUtility.HtmlEncode(description));
        }

        /// <summary>
        /// 添加栏目关键词到 meta keywords 标签
        /// </summary>
        protected virtual void AddMetaKeywords(string keywords)
        {
            AddMetaTag("keywords", HttpUtility.HtmlEncode(keywords));
        }

        /// <summary>
        /// 添加缓存清理 Meta
        /// </summary>
        protected virtual void AddMetaClearCache()
        {
            AddMetaTagForHttpEquiv("Pragma", "no-cache");
            AddMetaTagForHttpEquiv("Cache-Control", "no-cache");
            AddMetaTagForHttpEquiv("Expires", "0");

            Utility.ClearPageClientCache();
        }

        #endregion

        #region 页面跳转

        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="url"></param>
        protected virtual void Redirect(string url)
        {
            /*
           Response.Clear();
           Response.StatusCode = 301;
           Response.AppendHeader("location", url);
           Response.End();
           // */


            Response.Redirect(url);


        }

        /// <summary>
        /// 跳转并添加验证地址
        /// </summary>
        /// <param name="url"></param>
        protected virtual void RedirectAndValidUrl(string url)
        {
            string reurl = string.Format("{0}&RedirectUrl={1}", url, Utility.UrlEncode(RawUrl));
            Redirect(reurl);
        }

        /// <summary>
        /// 客户端跳转
        /// </summary>
        /// <param name="url"></param>
        protected virtual void RedirectByClient(string url)
        {
            //JavaScript.Redirect(url);
        }

        #endregion

        #region  登录用户

        /// <summary>
        /// 获取当前登录用户
        /// </summary>
        /// <returns></returns>
        protected virtual ezt_members GetCurrentUser()
        {
            return aideNewTroyFacade.GetMembersByUserid(userTicket.Pid);
        }

        /// <summary>
        /// 根据用户ID获取账号
        /// </summary>
        /// <returns></returns>
        public string GetAccountsByUserID(int userID)
        {
            ezt_members user = aideNewTroyFacade.GetMembersByUserid(userID);
            if (user == null)
                return "";
            return user.Id;
        }

        /// <summary>
        /// 根据用户ID获取用户昵称
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public string GetNickNameByUserID(int userID)
        {
            ezt_members user = aideNewTroyFacade.GetMembersByUserid(userID);
            if (user == null)
                return "";
            return user.Nickname.ToString();
        }


        #endregion

        #region 用户登录

        /// <summary>
        /// 用户登录
        /// </summary>
        protected virtual void UserLogon()
        {
            if (Fetch.IsUserOnline())
            {
                userTicket = Fetch.GetUserCookie();

                //是否会员
                if (IsAuthenticatedMember)
                {
                    IsMember();
                }
            }
            else
            {
                ReLogon();
            }
        }

        /// <summary>
        /// 重定向到登录页
        /// </summary>
        protected virtual void ReLogon()
        {
            string url = String.Format("{0}?url={1}", LogonUrl, RawUrl);
            Redirect(url);
        }

        /// <summary>
        /// 判断是否会员
        /// </summary>
        protected virtual void IsMember()
        {
            ezt_members user = aideNewTroyFacade.GetMembersByUserid(userTicket.Pid);
            if (user == null || user.UserType == 0)
            {
                ShowAndRedirect("会员功能页面，欢迎成为会员！", "Index.aspx");
            }
        }
        #endregion

        #region 公共服务

        /// <summary>
        /// 加载公告
        /// </summary>
        public virtual bool IsNotice
        {
            get { return true; }
        }

        #endregion

        #region 交互提示

        #region 消息对话框

        /// <summary>
        /// 显示消息提示对话框
        /// </summary>
        /// <param name="msg">提示信息</param>
        public void Show(string msg)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript'>alert('" + msg.ToString() + "');</script>");
        }

        /// <summary>
        /// 控件点击 消息确认提示框
        /// </summary>
        /// <param name="Control"></param>
        /// <param name="msg"></param>
        public static void ShowConfirm(System.Web.UI.WebControls.WebControl Control, string msg)
        {
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }

        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="url"></param>
        public void ShowAndRedirect(string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<script language='javascript' defer>");
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("top.location.href='{0}'", url);
            Builder.Append("</script>");
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", Builder.ToString());

        }

        #endregion

        #region 页面切换提示

        //提示样式类
        private static string[] ALERT_STYLE_CLASS = { "tips_correct_big", "green14font bold", "tips_error_big", "red14font bold" };

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="isError"></param>
        /// <param name="alertText"></param>
        /// <param name="step"></param>
        public virtual void RenderAlertInfo(bool isError, string alertText, int step)
        {
            bool moveSuccess = SwitchStep(step);

            if (moveSuccess)
            {
                //查找提示控件
                Label lblAlertIcon = this.FindControl("lblAlertIcon") as Label;
                Label lblAlertInfo = this.FindControl("lblAlertInfo") as Label;
                if (lblAlertIcon != null && lblAlertInfo != null)
                {
                    if (isError)
                    {
                        lblAlertIcon.CssClass = ALERT_STYLE_CLASS[2];
                        lblAlertInfo.CssClass = ALERT_STYLE_CLASS[3];
                        lblAlertInfo.Text = alertText;
                    }
                    else
                    {
                        lblAlertIcon.CssClass = ALERT_STYLE_CLASS[0];
                        lblAlertInfo.CssClass = ALERT_STYLE_CLASS[1];
                        lblAlertInfo.Text = alertText;
                    }
                }
            }
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="isError"></param>
        /// <param name="alertText"></param>
        public virtual void RenderAlertInfo2(bool isError, string alertText)
        {
            RenderAlertInfo(isError, alertText, 2);
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="isError"></param>
        /// <param name="alertText"></param>
        public virtual void RenderAlertInfo3(bool isError, string alertText)
        {
            RenderAlertInfo(isError, alertText, 3);
        }

        /// <summary>
        /// 步骤切换
        /// </summary>
        /// <param name="moveStep"></param>
        public virtual bool SwitchStep(int moveStep)
        {
            //Panel 查找
            Control step1 = this.FindControl("pnlStep1");
            Control step2 = this.FindControl("pnlStep2");
            Control step3 = this.FindControl("pnlStep3");

            //PlaceHolder
            if (step1 == null) step1 = this.FindControl("phStep1");
            if (step2 == null) step2 = this.FindControl("phStep2");
            if (step3 == null) step3 = this.FindControl("phStep3");

            //Form 查找
            if (step1 == null) step1 = this.FindControl("fmStep1");
            if (step2 == null) step2 = this.FindControl("fmStep2");
            if (step3 == null) step3 = this.FindControl("fmStep3");

            bool moveSuccess = false;

            if (step1 != null)
            {
                moveSuccess = true;
                step1.Visible = (moveStep == 1 || moveStep == 0);
            }
            if (step2 != null)
            {
                moveSuccess = true;
                step2.Visible = (moveStep == 2);
            }
            if (step3 != null)
            {
                moveSuccess = true;
                step3.Visible = (moveStep == 3);
            }

            return moveSuccess;
        }

        #endregion

        #endregion

        #region 刷新令牌

        /// <summary>
        /// 页面刷新令牌
        /// </summary>
        protected const string UC_Page_Refresh = "61631d1b1f3624e6ec24a4e6b8852a79";

        /// <summary>
        /// 是否刷新
        /// </summary>
        protected virtual bool IsPageRefresh
        {
            get
            {
                string clientToken = Utility.GetCookie(UC_Page_Refresh);
                string serverToken = SessionState.Get(UC_Page_Refresh) as string;

                if (string.IsNullOrEmpty(clientToken) && string.IsNullOrEmpty(serverToken))
                {
                    return false;
                }

                if (!clientToken.Equals(serverToken))
                {
                    return false;
                }

                return true;
            }
        }

        /// <summary>
        /// 更新服务端刷新令牌
        /// </summary>
        protected void SetRefreshServerToken()
        {
            string tokenPage = DateTime.Now.Ticks.ToString();
            SessionState.Set(UC_Page_Refresh, tokenPage);
        }

        /// <summary>
        /// 设置刷新令牌
        /// </summary>
        protected void SetRefreshToken()
        {
            string tokenPage = DateTime.Now.Ticks.ToString();
            SessionState.Set(UC_Page_Refresh, tokenPage);
            Utility.WriteCookie(UC_Page_Refresh, tokenPage);
        }

        /// <summary>
        /// 初始刷新令牌
        /// </summary>
        protected void InitRefreshToken()
        {
            SessionState.Set(UC_Page_Refresh, "");
            Utility.WriteCookie(UC_Page_Refresh, "");
        }

        #endregion

        #region 统一设置调用的JS

        /// <summary>
        /// 统一设置调用的
        /// </summary>
        private void SetStyle()
        {
            if (Header != null)
            {
                //RegJs(this, "/scripts/Common.js");
            }
        }

        /// <summary>
        /// 注册一段脚本包含到页面上
        /// </summary>
        /// <param name="page"></param>
        /// <param name="url"></param>
        public void RegJs(System.Web.UI.Page page, string url)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("type", "text/javascript");
            dic.Add("src", url);
            System.Web.UI.HtmlControls.HtmlGenericControl js = CreateGenericControl("script", dic);
            page.Header.Controls.Add(js);
        }

        /// <summary>
        /// 创建一个HtmlGenericControl类型的标签
        /// </summary>
        /// <param name="tagName">标签名称</param>
        /// <param name="dic">属性列表</param>
        /// <returns></returns>
        public System.Web.UI.HtmlControls.HtmlGenericControl CreateGenericControl(string tagName, IDictionary<string, string> dic)
        {
            System.Web.UI.HtmlControls.HtmlGenericControl obj = new System.Web.UI.HtmlControls.HtmlGenericControl();
            obj.TagName = tagName;
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                obj.Attributes.Add(kvp.Key, kvp.Value);
            }
            return obj;
        }
        #endregion

        #region 给定的日期时间距离现在的天/小时/分钟/秒数
        /// <summary>
        /// 给定的日期时间距离现在的天数。
        /// </summary>
        /// <param name="date">给定的日期时间字符串。</param>       
        /// <returns>返回与现在相差的秒数。</returns>
        public static int StrDateDiffDays(DateTime date)
        {
            TimeSpan span = (TimeSpan)(DateTime.Now - date);
            if (span.TotalDays > 2147483647)
            {
                return 0x7fffffff;
            }
            if (span.TotalSeconds < -2147483648)
            {
                return -2147483648;
            }
            return (int)span.TotalDays;
        }
        /// <summary>
        /// 给定的日期时间累加上给定的小时数，与现在相差的小时数。
        /// </summary>
        /// <param name="time">给定的日期时间字符串。</param>
        /// <param name="hours">累加的小时数。</param>
        /// <returns>返回与现在相差的小时数。</returns>
        public static int StrDateDiffHours(string time, int hours)
        {
            if ((time == "") || (time == null))
            {
                return 1;
            }
            TimeSpan span = (TimeSpan)(DateTime.Now - DateTime.Parse(time).AddHours((double)hours));
            if (span.TotalHours > 2147483647)
            {
                return 0x7fffffff;
            }
            if (span.TotalHours < -2147483648)
            {
                return -2147483648;
            }
            return (int)span.TotalHours;
        }

        /// <summary>
        /// 给定的日期时间累加上给定的分钟数，与现在相差的分钟数。
        /// </summary>
        /// <param name="time">给定的日期时间字符串。</param>
        /// <param name="minutes">累加的分钟数。</param>
        /// <returns>返回与现在相差的分钟数。</returns>
        public static int StrDateDiffMinutes(string time, int minutes)
        {
            if ((time == "") || (time == null))
            {
                return 1;
            }
            TimeSpan span = (TimeSpan)(DateTime.Now - DateTime.Parse(time).AddMinutes((double)minutes));
            if (span.TotalMinutes > 2147483647)
            {
                return 0x7fffffff;
            }
            if (span.TotalMinutes < -2147483648)
            {
                return -2147483648;
            }
            return (int)span.TotalMinutes;
        }

        /// <summary>
        /// 给定的日期时间累加上给定的秒数，与现在相差的秒数。
        /// </summary>
        /// <param name="time">给定的日期时间字符串。</param>
        /// <param name="sec">累加的秒数。</param>
        /// <returns>返回与现在相差的秒数。</returns>
        public static int StrDateDiffSeconds(string time, int sec)
        {
            TimeSpan span = (TimeSpan)(DateTime.Now - DateTime.Parse(time).AddSeconds((double)sec));
            if (span.TotalSeconds > 2147483647)
            {
                return 0x7fffffff;
            }
            if (span.TotalSeconds < -2147483648)
            {
                return -2147483648;
            }
            return (int)span.TotalSeconds;
        }

        /// <summary>
        /// 把给定的日期格式化为距现在的模糊时间段，比如 1 分钟前
        /// </summary>
        /// <param name="dateSpan"></param>
        /// <returns></returns>
        public static string FormatDateSpan(object dateSpan)
        {
            DateTime dtDateSpan = (DateTime)dateSpan;
            TimeSpan span = (TimeSpan)(DateTime.Now - dtDateSpan);

            if (span.TotalDays >= 365)
            {
                return String.Format("{0} 年前", (int)(span.TotalDays / 365));
            }
            else if (span.TotalDays >= 30)
            {
                return String.Format("{0} 月前", (int)(span.TotalDays / 30));
            }
            else if (span.TotalDays > 7 && (span.TotalDays / 7 <= 4))
            {
                return String.Format("{0} 周前", (int)(span.TotalDays / 7));
            }
            else if (span.TotalDays >= 1)
            {
                return String.Format("{0} 天前", (int)span.TotalDays);
            }
            else if (span.TotalHours >= 1)
            {
                return String.Format("{0} 小时前", (int)span.TotalHours);
            }
            else if (span.TotalMinutes >= 1)
            {
                return String.Format("{0} 分钟前", (int)span.TotalMinutes);
            }

            return "1 分钟前";
        }
        #endregion

        #region MD5加密

        /// <summary>
        /// MD5加密函数
        /// </summary>
        /// <param name="text">需要加密的字符串</param>
        /// <param name="isLower">是否小写</param>
        /// <param name="bit">16位或32位</param>
        /// <returns>密文</returns>
        public string EncryptMD5(string text, bool isLower, int bit)
        {
            string ciphertext = string.Empty;
            if (bit != 32 && bit != 16)
            {
                return ciphertext;
            }
            if (bit == 32)    //32位
            {
                MD5 md5 = MD5.Create();//实例化一个md5对像
                byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(text));    // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
                // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
                for (int i = 0; i < s.Length; i++)
                {
                    ciphertext = ciphertext + s[i].ToString("X");   // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符
                }
            }
            else    //16位
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                ciphertext = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(text)), 4, 8);
                ciphertext = ciphertext.Replace("-", "");
            }
            if (isLower)
            {
                ciphertext = ciphertext.ToLower();
            }
            return ciphertext;
        }

        #endregion

        /// <summary>
        /// 邮件状态
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        protected string MailState(int state)
        {
            if (state == 0)
            {
                return "未读";
            }
            else
            {
                return "已读";
            }
        }
    }
}
