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
    public partial class Register : UCPageBase
    {
        protected string domain = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                UserTicketInfo userTick = Fetch.GetUserCookie();
                if (userTick != null)
                {
                    ShowAndRedirect("이미 아이디 등록하였습니다.가입하실려면 로그아웃해주세요", "main.aspx");
                }
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            ezt_members user = new ezt_members();
            if (TextUtility.EmptyTrimOrNull(txtAccounts.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtNickname.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtLogonPass.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtLogonPass2.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtInsurePass1.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtInsurePass2.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtRegisterMobile.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtBankName.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtBankAcccount.Text.Trim()) || TextUtility.EmptyTrimOrNull(txtBankAcowner.Text.Trim()))
            {
                Show("죄송합니다.정보 모두 입력해주세요");
                this.txtAccounts.Focus();
                return;
            }
            //wolf3
            if (!TextUtility.IsValidSQLStr(txtAccounts.Text.Trim()) || !TextUtility.IsValidSQLStr(txtNickname.Text.Trim()) || !TextUtility.IsValidSQLStr(txtLogonPass.Text.Trim()) || !TextUtility.IsValidSQLStr(txtInsurePass1.Text.Trim())
                 || !TextUtility.IsValidSQLStr(txtRegisterMobile.Text.Trim()) || !TextUtility.IsValidSQLStr(txtBankName.Text.Trim()) || !TextUtility.IsValidSQLStr(txtBankAcccount.Text.Trim())
                 || !TextUtility.IsValidSQLStr(txtBankAcowner.Text.Trim()) || !TextUtility.IsValidSQLStr(txtUpmemberPID.Text.Trim()))
            {
                Show("입력정보에 유효하지 못한 문자열이 있습니다. 다시 입력해주세요");
                return;
            }
            if (txtAccounts.Text.Length < 2 || txtAccounts.Text.Length > 4)
            {
                Show("한글 2~4자로입력해주십시요");
                this.txtAccounts.Focus();
                return;
            }
            if (txtNickname.Text.Length < 2 || txtNickname.Text.Length > 4)
            {
                Show("한글2~4자리까지 입력해주세요");
                this.txtNickname.Focus();
                return;
            }
            Message umsg = aideNewTroyFacade.IsAccountsExist(CtrlHelper.GetText(txtAccounts));//判断用户名是否重复
            if (!umsg.Success)
            {
                Show(umsg.Content);
                this.txtNickname.Focus();
                return;
            }
            if (this.txtUpmemberPID.Text.Trim() != "")
            {
                ezt_members member = aideNewTroyFacade.GetMembersByAccounts(CtrlHelper.GetText(txtUpmemberPID));//判断推荐人是否存在
                if (member == null)
                {
                    Show("추천인이 존재하지 않습니다.다시 확인해주세요");
                    this.txtUpmemberPID.Focus();
                    return;
                }
                user.UpmembersPID = member.Pid;
            }
            else
            {
                user.UpmembersPID = 0;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAccounts.Text, @"^[(\\x3131-\\x318F|\\xAC00-\\xD7A3)]+$") && System.Text.RegularExpressions.Regex.IsMatch(txtNickname.Text, @"^[(\\x3131-\\x318F|\\xAC00-\\xD7A3)]+$") && System.Text.RegularExpressions.Regex.IsMatch(txtNickname.Text, @"^[0-9]+$") && System.Text.RegularExpressions.Regex.IsMatch(txtAccounts.Text, @"^[0-9]+$"))
            {
                Show("한글2~4자리까지 입력해주세요");
                this.txtAccounts.Focus();
                return;
            }
            else
            {
                user.Id = CtrlHelper.GetText(txtAccounts);
                user.Nickname = CtrlHelper.GetText(txtNickname);
                user.Passwd = Utility.troymd5(CtrlHelper.GetText(txtLogonPass), 32);
                user.TruePasswd = CtrlHelper.GetText(txtLogonPass);
                user.WithdrawalsPass = Utility.troymd5(CtrlHelper.GetText(txtInsurePass1), 32);
                user.TrueWithdrawalsPass = CtrlHelper.GetText(txtInsurePass1);

                user.Phone = CtrlHelper.GetText(txtRegisterMobile);
                user.BankName = CtrlHelper.GetText(txtBankName);
                string number = CtrlHelper.GetText(txtBankAcccount);
                decimal banknum = decimal.Parse(number);
                banknum = banknum + 1;
                user.BankNumber = banknum.ToString();
                user.BankAccount = CtrlHelper.GetText(txtBankAcowner);
                user.IP = GameRequest.GetUserIP();
                domain = Utils.GameRequest.GetServerDomain();
                string url = domain;
                if (domain.ToString().Substring(0, 4) == "www.")
                {
                    url = url.Substring(4);
                }
                Message msg = aideNewTroyFacade.Register(user, domain);
                if (msg.Success)
                {
                    ezt_members ui = aideNewTroyFacade.GetMembersByAccounts(user.Id);
                    ui.Pid = ui.Pid;
                    ui.Id = ui.Id;
                    ui.Passwd = Utility.troymd5(txtLogonPass.Text.Trim(), 32);

                    //SetUserCookie
                    Fetch.SetUserCookie(ui.ToUserTicketInfo());
                    Response.Write("<script language='javascript'>alert('가입성공하였습니다.');window.location.href='Main.aspx';</script>");
                }
                else
                {
                    Show(msg.Content);
                    this.txtAccounts.Focus();
                }
            }
        }
    }
}