using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Game.Entity.Troy;
using Game.Facade;
using Game.Kernel;
using Game.Utils;

namespace Game.Web
{
    public partial class EventList : UCPageBase
    {
        #region 加载
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindNewsData();
            }
        }
        /// <summary>
        /// 增加页面标题Title
        /// </summary>
        protected override void AddHeaderTitle()
        {
            AddMetaTitle("" + ApplicationSettings.Get("title"));
            AddMetaKeywords(ApplicationSettings.Get("keywords"));
            AddMetaDescription(ApplicationSettings.Get("description"));
        }

        protected void anpPage_PageChanged(object sender, EventArgs e)
        {
            BindNewsData();
        }
        #endregion

        #region 绑定新闻
        /// <summary>
        /// 绑定新闻
        /// </summary>
        private void BindNewsData()
        {
            PagerSet pagerSet = aideNewTroyFacade.GetNoticeList(anpPage.CurrentPageIndex, anpPage.PageSize, SearchItems, Orderby);
            rptNewsList.DataSource = pagerSet.PageSet;
            rptNewsList.DataBind();
            anpPage.RecordCount = pagerSet.RecordCount;
        }

        /// <summary>
        /// 查询条件
        /// </summary>
        public string SearchItems
        {
            get
            {
                if (ViewState["SearchItems"] == null)
                {
                    StringBuilder condition = new StringBuilder();
                    condition.Append(" WHERE Notice_Type=2 ");

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
        public string Orderby
        {
            get
            {
                if (ViewState["Orderby"] == null)
                {
                    ViewState["Orderby"] = "ORDER BY Create_Date DESC";
                }

                return (string)ViewState["Orderby"];
            }

            set
            {
                ViewState["Orderby"] = value;
            }
        }
        #endregion
    }
}