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
    public partial class MailDetail : UCPageBase
    {


        protected override bool IsAuthenticatedUser
        {
            get
            {
                return true;
            }
        }

        protected string NoticeTitle = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindNewsData();
            }
        }

        #region 数据绑定
        private void BindNewsData()
        {
            int strParm = Convert.ToInt32(Request.QueryString["Idx"]);
            if (strParm <= 0)
            {
                Redirect("MailFunction.aspx");
            }

            //获取公告信息
            Mail notice = aideNewTroyFacade.GetMailByidx(strParm);
            if (notice == null)
            {
                Response.Write("<script language='javascript'>alert('공지사항은 존재하지 않습니다');window.location.href='MailFunction.aspx';</script>");
            }
            CtrlHelper.SetText(lbContent, notice.M_Content);
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            int strParm = Convert.ToInt32(Request.QueryString["Idx"]);
            Message umsg = aideNewTroyFacade.DelMail(strParm);
            if (umsg.Success)
            {
                Response.Write("<script language='javascript'>alert('쪽지를 삭제하였습니다.');window.location.href='MailFunction.aspx';</script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('다시 시도해주세요.');window.location.href='MailFunction.aspx';</script>");
            }
        }

        #endregion
    }
}