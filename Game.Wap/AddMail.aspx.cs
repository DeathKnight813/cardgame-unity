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
    public partial class AddMail : UCPageBase
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

        }


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