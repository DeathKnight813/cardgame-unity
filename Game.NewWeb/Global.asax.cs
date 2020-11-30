using PUBLICVAR;
using System;
using System.Text.RegularExpressions;
using System.Web;

namespace PUBLICVAR
{
    class pubvar
    {
        public static bool HomeStart = false;
    }
}

namespace Game.NewWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            pubvar.HomeStart = true;
            var userAgent = HttpContext.Current.Request.Headers["User-Agent"].ToLower();
            var reg = new Regex("(ipod|iphone|iphone os|midp|ucweb|android|windows ce|windows mobile)", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.ExplicitCapture);
            if (reg.IsMatch(userAgent))
            {
                HttpContext.Current.Response.Redirect("/wap/");
            }

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if (HttpContext.Current.Server.GetLastError() is HttpRequestValidationException)
            {
                HttpContext.Current.Response.Write("请输入合法的字符串【<a href=\"javascript:history.back(0);\">返回</a>】");
                HttpContext.Current.Server.ClearError();
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}