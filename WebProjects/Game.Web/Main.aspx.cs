using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Game.Entity.Troy;
using Game.Facade;
using Game.Kernel;
using Game.Utils;

using PUBLICVAR;
namespace Game.Web
{
    public partial class Main : UCPageBase
    {
        public string ScrollContents = string.Empty;
        public string StrCurTime = string.Empty;
        public string MyTmpIP = string.Empty;
        public string MyHomeIP = string.Empty;
        public int i = 1;
        public int ratenum;
        public string PNOTICE = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPageRefresh)
            {
                GetPopupNotice();
                if (Fetch.GetUserCookie() != null)
                {
                    ezt_members members = aideNewTroyFacade.GetMembersByUserid(userTicket.Pid);
                    CtrlHelper.SetText(ltAccount, members.Id);
                    CtrlHelper.SetText(ltNickName, members.Nickname);
                    //CtrlHelper.SetText(ltBalanceMoney, members.BalanceMoney.ToString("n0"));
                    //CtrlHelper.SetText(ltCashMoney, members.CashMoney.ToString("n0"));
                    //CtrlHelper.SetText(ltAllGaugeMoeny, members.Gauge_money.ToString("n0"));
                    //CtrlHelper.SetText(ltDayGaugeMoney, members.Gauge_money_Day.ToString("n0"));
                    ratenum = members.RateNum;
                    ezt_members_dayscore dayscore = aideNewTroyFacade.GetMembersDayScoreByPid(userTicket.Pid);
                    //CtrlHelper.SetText(ltRateMoeny , dayscore.rateMoney.ToString("n0"));
                }
                UserLongout();
                BindWithDrawData();
                ViewState["SearchItems"] = null;
                ViewState["Orderby"] = null;
                BindMoneyBackData();
                ViewState["SearchItems"] = null;
                ViewState["Orderby"] = null;
                BindNewsData();

                StrCurTime = DateTime.Now.ToString("HH:mm:ss"); ;
                MyTmpIP = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (MyTmpIP == "" || MyTmpIP == null) 
                     MyTmpIP = Request.ServerVariables["REMOTE_ADDR"];
                MyHomeIP = "접속 IP : " + MyTmpIP;
                // CtrlHelper.SetText(ltMyHomeIP, MyHomeIP);
            }
        }
        private void GetPopupNotice()//wolf2
        {
            if(pubvar.HomeStart)
            {
                tb_notice pnotce = aideNewTroyFacade.GetNoticeByIdx(130);
                if (pnotce == null) return;
                PNOTICE = pnotce.Content;
                pubvar.HomeStart = false;
            }
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            //wolf3
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
                    Response.Redirect("Main.aspx");
            }
            else
            {
                Show(umsg.Content);
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        private void UserLongout()
        {
            string logout = GameRequest.GetQueryString("exit");
            if (logout == "true")
            {
                Fetch.DeleteUserCookie();
                Response.Redirect("/Main.aspx");
            }
        }

        /// <summary>
        /// 增加页面标题
        /// </summary>
        protected override void AddHeaderTitle()
        {
            AddMetaTitle("" + ApplicationSettings.Get("title"));
            AddMetaKeywords(ApplicationSettings.Get("keywords"));
            AddMetaDescription(ApplicationSettings.Get("description"));
        }

        private void BindNewsData()
        {
            tb_notice notice = aideNewTroyFacade.GetNoticeByIdx(76);
            ScrollContents = notice.Content;
        }


        #region 绑定提款
        /// <summary>
        /// 绑定提款
        /// </summary>
        private void BindWithDrawData()
        {
            PagerSet pagerSet = aideNewTroyFacade2.GetOutComeList2(1, 100, WhereItem, Sortby);//wolf3
            repmoney.DataSource = pagerSet.PageSet;
            repmoney.DataBind();
        }

        /// <summary>
        /// 查询条件
        /// </summary>
        public string WhereItem
        {
            get
            {
                if (ViewState["SearchItems"] == null)
                {
                    StringBuilder condition = new StringBuilder();
                    tb_config time = aideNewTroyFacade.GetOperationTimeByidx(1);
                    string a1 = DateTime.Now.ToShortDateString() + " " + time.BeginTime + ":00:00";
                    string a2 = DateTime.Now.ToShortDateString() + " 23:59:59";
                    string b1 = DateTime.Now.ToShortDateString() + " 00:00:00";
                    string b2 = DateTime.Now.ToShortDateString() + " " + time.EndTime + ":00:00";
                    string a3 = DateTime.Now.AddDays(-1).ToShortDateString() + " " + time.BeginTime + ":00:00";
                    if (DateTime.Now > Convert.ToDateTime(a1) && DateTime.Now < Convert.ToDateTime(a2))
                    {
                        condition.Append(" where InOut =2 and Type=2 and InsertDate >= '" + a1 + " ' and InsertDate <= '" + a2 + "' ");
                    }
                    else if (DateTime.Now > Convert.ToDateTime(b1) && DateTime.Now < Convert.ToDateTime(b2))
                    {
                        condition.Append(" where InOut =2 and Type=2 and InsertDate >= '" + a3 + " ' and InsertDate <= '" + b2 + "' ");
                    }
                    ViewState["SearchItems"] = condition.ToString();
                }

                return (string)ViewState["SearchItems"];
            }
            set
            {
                ViewState["SearchItems"] = value;
            }
        }

        /// <summary>
        /// 排序条件
        /// </summary>
        public string Sortby
        {
            get
            {
                if (ViewState["Orderby"] == null)
                {
                    ViewState["Orderby"] = " ORDER BY InsertDate DESC";
                }

                return (string)ViewState["Orderby"];
            }

            set
            {
                ViewState["Orderby"] = value;
            }
        }
        #endregion

        #region 绑定假返钱
        /// <summary>
        /// 绑定假返钱
        /// </summary>
        private void BindMoneyBackData()
        {
            PagerSet pagerSet = aideNewTroyFacade2.GetMoneyBackList2(1, 100, "where 1=1 ", "ORDER BY Money DESC");//wolf3
            repbackmoney.DataSource = pagerSet.PageSet;
            repbackmoney.DataBind();
        }
        #endregion
    }
}