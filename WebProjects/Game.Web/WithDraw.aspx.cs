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
using Game.Facade;
using Game.Kernel;
using Game.Utils;
using Game.Entity.Troy;
using System.Text.RegularExpressions;
namespace Game.Web
{
    public partial class WithDraw : UCPageBase
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
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ezt_members model = aideNewTroyFacade.GetMembersByUserid(Fetch.GetUserCookie().Pid);
                labaccount.Text = model.Id;
                labnowmoney.Text = (model.BalanceMoney / 10000).ToString();
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

        protected void btnOne_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 1).ToString();
        }
        protected void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 2).ToString();
        }
        protected void btnFive_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 5).ToString();
        }
        protected void btnTen_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 10).ToString();
        }
        protected void btnTwenty_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 20).ToString();
        }
        protected void btnThirty_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 30).ToString();
        }
        protected void btnFifty_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 50).ToString();
        }
        protected void btnHundred_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = (Convert.ToInt32(txtmoney.Text) + 100).ToString();
        }
        protected void btnclear_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == null || txtmoney.Text == "")
            {
                txtmoney.Text = "0";
            }
            txtmoney.Text = "";
        }
        #endregion

        #region 数据绑定

        protected void btnsure_Click(object sender, EventArgs e)
        {
            ezt_members model = aideNewTroyFacade.GetMembersByUserid(Fetch.GetUserCookie().Pid);
            ezt_connection online = aideNewTroyFacade.GetMembersOnlineById(userTicket.Id);
            if (model.WithdrawalsPass != Utility.troymd5(txtWithdrawalsPass.Text.Trim(), 32))
            {
                Response.Write("<script language='javascript'>alert('비밀번호가 일치하지 않습니다.다시 시도해주세요.');window.location.href='WithDraw.aspx';</script>");
            }
            else if (aideNewTroyFacade.CountHaveWithDraw(userTicket.Id) > 0)
            {
                Response.Write("<script language='javascript'>alert('머니처리중입니다,궁굼한점있으시면 상담원에게 문의해주세요.');window.location.href='WithDraw.aspx';</script>");
            }
            else if (online != null && online.Room_Pin > 0)
            {
                Response.Write("<script language='javascript'>alert('게임중에서는 환전신청을할수 없습니다. ');window.location.href='WithDraw.aspx';</script>");
            }
            else
            {
                if (txtmoney.Text == "" || txtmoney.Text == null || Convert.ToDecimal(txtmoney.Text) <= 0 || Convert.ToDecimal(txtmoney.Text) * 10000 > model.BalanceMoney)
                {
                    Response.Write("<script language='javascript'>alert('완전한 정보를입력하시길바랍니다 .');window.location.href='WithDraw.aspx';</script>");
                }
                else
                {
                    Message umsg = aideNewTroyFacade.AddWithDraw(Convert.ToDecimal(txtmoney.Text) * 10000, Fetch.GetUserCookie().Pid, Utility.troymd5(txtWithdrawalsPass.Text.Trim(), 32));
                    if (umsg.Success)
                    {
                        Response.Write("<script language='javascript'>alert(' 환정신청이 완료되였습니다.');window.location.href='WithDraw.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('신청실패되였습니다 .');window.location.href='WithDraw.aspx';</script>");
                    }
                }
            }
        }
        #endregion
    }
}