using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
//wolf2
using PUBLICVAR;
namespace PUBLICVAR
{
    class pubvar
    {
        public static bool HomeStart = false;
    }
}
namespace Game.Web
{
    public class Global : System.Web.HttpApplication
    {
        
        protected void Application_Start( object sender, EventArgs e )
        {
            
        }

        protected void Session_Start( object sender, EventArgs e )
        {
            pubvar.HomeStart = true;
        }

        protected void Application_BeginRequest( object sender, EventArgs e )
        {
            
        }

        protected void Application_AuthenticateRequest( object sender, EventArgs e )
        {
            
        }

        protected void Application_Error( object sender, EventArgs e )
        {
            Exception ex = Server.GetLastError( );
            if ( HttpContext.Current.Server.GetLastError( ) is HttpRequestValidationException )
            {
                HttpContext.Current.Response.Write( "请输入合法的字符串【<a href=\"javascript:history.back(0);\">返回</a>】" );
                HttpContext.Current.Server.ClearError( );
            }
        }

        protected void Session_End( object sender, EventArgs e )
        {

        }

        protected void Application_End( object sender, EventArgs e )
        {

        }
    }
}