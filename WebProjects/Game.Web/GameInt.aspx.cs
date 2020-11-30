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
namespace Game.Web
{
    public partial class GameInt : UCPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPageRefresh)
            {
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
    }
}