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
    public partial class EventDetail : UCPageBase
    {
        protected string EventTitle = string.Empty;

        #region 窗口事件
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
            EventTitle = notice.Title;
            CtrlHelper.SetText(lbContent, notice.Content);
        }
        #endregion
    }
}