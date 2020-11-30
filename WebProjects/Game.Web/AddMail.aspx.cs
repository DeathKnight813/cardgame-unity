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
    public partial class AddMail : UCPageBase
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
        /// <summary>
        /// 发送成功 발송성공!
        /// 发送失败  발송실패!
        /// 内容不能为空  내용을 비워 둘수 없습니다!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnsure_Click(object sender, EventArgs e)
        {
            if (TextUtility.EmptyTrimOrNull(txtContent.Text.Trim()))
            {
                Show(" 내용을 비워 둘수 없습니다!");
                this.txtContent.Text = "";
                return;
            }
            else
            {
                Mail model = new Mail();
                ezt_members member = aideNewTroyFacade.GetMembersByUserid(Fetch.GetUserCookie().Pid);
                model.S_Account = member.Id;
                model.S_NickName = member.Nickname;
                model.SendDate = DateTime.Now;
                model.M_Content = txtContent.Text.Trim();
                model.Status = 0;
                model.Type = 1;
                Message umsg = aideNewTroyFacade.GiveMailToBack(model);
                if (umsg.Success)
                {
                    Response.Write("<script language='javascript'>alert('발송성공!');window.location.href='AddMail.aspx';</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert(' 발송실패!');window.location.href='AddMail.aspx';</script>");
                }
            }
        }
        #endregion
    }
}