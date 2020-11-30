using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using Game.Entity.Troy;
using Game.Facade;
using Game.Utils;
using System.Text;
using System.Collections.Generic;
using Game.Kernel;

namespace Game.Wap.WS
{
    /// <summary>
    /// WSAccount 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    [System.Web.Script.Services.ScriptService]
    public class WSAccount : System.Web.Services.WebService
    {
        private NewTroyFacade aideNewTroyFacade = new NewTroyFacade();
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPass"></param>
        /// <returns></returns>
        [WebMethod]
        public string Logon(string userName, string userPass)
        {
            string msg = "";

            if (TextUtility.EmptyTrimOrNull(userName) || TextUtility.EmptyTrimOrNull(userPass))
            {
                msg = "죄송합니다.입력하신 아이디 또는 비밀번호가 잘못되였습니다.";
                return "{success:'error',msg:'" + msg + "'}";
            }
            Message umsg = aideNewTroyFacade.Logon(userName, userPass);
            if (umsg.Success)
            {
                ezt_members ui = umsg.EntityList[0] as ezt_members;
                ui.Passwd = Utility.troymd5(userPass, 32);

                //SetUserCookie
                Fetch.SetUserCookie(ui.ToUserTicketInfo());

                msg = "{success:'success',account:'" + ui.Id
                    + "',NickName:'" + ui.Nickname
                    + "',Pid:'" + ui.Pid + "'}";
            }
            else
            {
                msg = "{success:'error',msg:'" + umsg.Content + "'}";
            }
            return msg;
        }

        /// <summary>
        /// 获取用户登录信息
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string GetUserInfo()
        {
            UserTicketInfo userTick = Fetch.GetUserCookie();
            if (userTick == null) return "{}";
            Message umsg = aideNewTroyFacade.GetUserGlobalInfo(userTick.Pid, "");
            if (umsg.Success)
            {
                ezt_members ui = umsg.EntityList[0] as ezt_members;
                return "{success:'success',account:'" + ui.Id + "',NickName:'" + ui.Nickname + "'}";
            }
            return "{}";
        }

        /// <summary>
        /// 检测用户名
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [WebMethod]
        public string CheckName(string userName)
        {
            Message umsg = aideNewTroyFacade.IsAccountsExist(userName);
            if (umsg.Success)
            {
                return "{success:\"success\"}";
            }
            return "{success:\"error\"}";
        }

        /// <summary>
        /// 检测昵称
        /// </summary>
        /// <param name="NickName"></param>
        /// <returns></returns>
        [WebMethod]
        public string CheckNickName(string NickName)
        {
            Message umsg = aideNewTroyFacade.IsNickNameExist(NickName);
            if (umsg.Success)
            {
                return "{success:\"success\"}";
            }
            return "{success:\"error\"}";
        }
    }
}
