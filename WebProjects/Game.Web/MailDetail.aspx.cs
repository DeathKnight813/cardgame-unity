using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Game.Entity.Troy;
using Game.Facade;
using Game.Utils;
using Game.Kernel;
using System.Text;

namespace Game.Web
{
    public partial class MailDetail : UCPageBase
    {
        #region 继承属性

        protected override bool IsAuthenticatedUser
        {
            get
            {
                return true;
            }
        }

        #endregion

        #region 窗口事件
        protected string NoticeTitle = string.Empty;
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindNewsData();
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

        #endregion

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