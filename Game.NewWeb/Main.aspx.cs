using Game.Entity.Troy;
using Game.Facade;
using Game.Kernel;
using Game.Utils;
using PUBLICVAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Game.NewWeb
{
    public partial class Main : UCPageBase
    {
        /// <summary>
        /// 用于存储 公告内容
        /// </summary>
        public static string PNOTICE = string.Empty;

        public static string PNOTICE2 = string.Empty;

        /// <summary>
        /// 滚动EVENT
        /// </summary>
        public static string EVENT = "";

        public static tb_notice Event1 = null;
        public static tb_notice Event2 = null;

        /// <summary>
        /// ??
        /// </summary>
        public int ratenum;

        /// <summary>
        /// 排行
        /// </summary>
        public int i = 1;

        public string memberID = string.Empty;
        public string MemberName = string.Empty;
        public string ScrollContents = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //加载公告内容
                GetPopupNotice();

                if (Fetch.GetUserCookie() != null)
                {
                    ezt_members members = aideNewTroyFacade.GetMembersByUserid(userTicket.Pid);
                    memberID = members.Id;
                    MemberName = members.Nickname;

                    CtrlHelper.SetText(ltAccount, members.Id); //登录信息
                    CtrlHelper.SetText(ltNickName, members.Nickname);//登录信息

                    ratenum = members.RateNum;

                    //如果用户未登录则退出？？
                    UserLongout();
                }


                //绑定数据？？
                BindWithDrawData();

                //绑定数据？？
                BindMoneyBackData();
                BindNewsData();
            }
        }



        #region 查询条件&排序条件
        /// <summary>
        /// 查询条件
        /// </summary>
        private string WhereItem
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

        /// <summary>
        /// 绑定活动
        /// </summary>
        private void BindNewsData()
        {
            tb_notice notice = aideNewTroyFacade.GetNoticeByIdx(76);
            ScrollContents = notice.Content;
        }


        /// <summary>
        /// 绑定提款
        /// </summary>
        private void BindWithDrawData()
        {
            //var pagerSet = aideNewTroyFacade2.GetOutComeList2(1, 100, WhereItem, Sortby);//wolf3
            //rptUserData2.DataSource = pagerSet.PageSet;
            //rptUserData2.DataBind();
        }

        /// <summary>
        /// 绑定假返钱
        /// </summary>
        private void BindMoneyBackData()
        {
            //var pagerSet = aideNewTroyFacade2.GetMoneyBackList2(1, 100, "where 1=1 ", "ORDER BY Money DESC");//wolf3
            //rptUserData1.DataSource = pagerSet.PageSet;
            //rptUserData1.DataBind();
        }


        private void GetPopupNotice()//wolf2
        {
            if (pubvar.HomeStart)
            {
                tb_notice pnotce = aideNewTroyFacade.GetNoticeByHome(1);
                if (pnotce != null)
                    PNOTICE = pnotce.Content;

                pnotce = aideNewTroyFacade.GetNoticeByHome(2);
                if (pnotce != null)
                    PNOTICE2 = pnotce.Content;

                //var notce = aideNewTroyFacade.GetNoticeByIdx(135);
                //if (notce != null)
                //    EVENT = notce.Content;

                Event1 = aideNewTroyFacade.GetNoticeByIdx(135);
                Event2 = aideNewTroyFacade.GetNoticeByIdx(136);

                pubvar.HomeStart = false;
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
                Response.Redirect("/main.aspx");
            }
        }


        protected void btnlogin_Click(object sender, EventArgs e)
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