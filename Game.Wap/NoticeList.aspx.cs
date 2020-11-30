using Game.Facade;
using Game.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Game.Wap
{
    public partial class NoticeList : UCPageBase
    {
        public int currPageIndex = 1;
        public int PageSize = 10;
        public static int RecordCounts = 0;

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
            var p = Convert.ToInt32(Request["p"]);
            currPageIndex = p > 0 ? p : 1;

            if (!IsPostBack)
            {
                BindNewsData();
            }
        }


        private void BindNewsData()
        {
            PagerSet pagerSet = aideNewTroyFacade.GetNoticeList(1, currPageIndex * PageSize, SearchItems, Orderby);
            rptData.DataSource = pagerSet.PageSet;
            rptData.DataBind();
            RecordCounts = pagerSet.RecordCount;
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
                    condition.Append(" WHERE Notice_Type=1 ");

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

    }
}