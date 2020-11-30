using Game.Entity.Troy;
using Game.Facade;
using Game.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Game.NewWeb
{
    public partial class NewsDetail : UCPageBase
    {

        /// <summary>
        /// 登录验证
        /// </summary>
        protected override bool IsAuthenticatedUser
        {
            get
            {
                return true;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindNewsData();
            }

        }
        private void BindNewsData()
        {
            string strParm = Request.QueryString["param"].ToString();
            if (strParm == "")
            {
                Redirect("EventList.aspx");
            }

            //获取活动信息
            tb_notice notice = aideNewTroyFacade.GetNoticeByTitle(strParm);
            if (notice == null)
            {
                Response.Write("<script language='javascript'>alert('공지사항은 존재하지 않습니다');window.location.href='EventList.aspx';</script>");
            }

            CtrlHelper.SetText(ltTitle, notice.Title);
            CtrlHelper.SetText(ltTime, notice.Create_Date.ToString("yyyy-MM-dd"));
            CtrlHelper.SetText(ltContent, notice.Content);
        }
    }
}