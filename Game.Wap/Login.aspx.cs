using Game.Entity.Troy;
using Game.Facade;
using Game.Kernel;
using Game.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Game.Wap
{
    public partial class Login : UCPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!TextUtility.IsValidSQLStr(txtAccounts.Text.Trim()) || !TextUtility.IsValidSQLStr(txtLogonPass.Text.Trim()))
            {
                Show("죄송합니다! 아이디 혹은 비밀번호을 잘못 입력하였습니다.");
                this.txtLogonPass.Text = "";
                return;
            }
            if (TextUtility.EmptyTrimOrNull(txtAccounts.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtLogonPass.Text.Trim()))
            {
                Show("죄송합니다! 아이디 또는 비밀번호을 잘못 입력하였습니다.");
                this.txtLogonPass.Text = "";
                return;
            }

            Message umsg = aideNewTroyFacade.Logon(txtAccounts.Text.Trim(), txtLogonPass.Text.Trim());
            if (umsg.Success)
            {
                ezt_members ui = umsg.EntityList[0] as ezt_members;
                ui.Passwd = Utility.troymd5(txtLogonPass.Text.Trim(), 32);

                //SetUserCookie
                Fetch.SetUserCookie(ui.ToUserTicketInfo());

                if (GameRequest.GetQueryString("url") != "")
                    Response.Redirect(GameRequest.GetQueryString("url"));
                else
                    Response.Redirect("main.aspx");
            }
            else
            {
                Show(umsg.Content);
            }
        }
    }
}