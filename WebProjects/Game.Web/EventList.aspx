<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventList.aspx.cs" Inherits="Game.Web.EventList" %>

<%@ Import Namespace="Game.Facade" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="css/index_style.css" />
    <link type="text/css" rel="stylesheet" href="css/notice.css" />
    <style type="text/css">
        .t_sel a {
            display: inline-block;
            width: 100%;
            height: 40px;
            text-decoration: none;
            color: #fff;
        }
    </style>
    <script type="text/javascript">
        function NotLogin() {
            alert("로그인 해주세요.");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="header">
                <div id="logo">
                    <a href="Main.aspx">
                        <img src="images/logo.png" style="margin-top: 18px;border: 0px;" /></a>
                </div>
                <div id="menu">
                    <ul>
                        <% if (Fetch.GetUserCookie() != null)
                           { %>
                        <li class="t_sel"><a href="Main.aspx">홈</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel t_click"><a href="NoticeList.aspx">공지사항</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="EventList.aspx">이벤트</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="GameInt.aspx">게임방법</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="MailFunction.aspx">쪽지</a></li>
                        <%}
                           else
                           { %>
                        <li class="t_sel"><a href="Main.aspx">홈</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel t_click"><a href="javascript:void(0);" onclick="NotLogin();">공지사항</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="javascript:void(0);"onclick="NotLogin();">이벤트</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="GameInt.aspx">게임방법</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="javascript:void(0);" onclick="NotLogin();">쪽지</a></li>
                        <%} %>
                    </ul>

                </div>
            </div>
            <div id="main">
                <div class="title">
                    이벤트
                </div>
                <div class="context">
                    <div id="txt">
                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                            <asp:Repeater ID="rptNewsList" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td width="50%"><a href='EventDetail.aspx?param=<%# Eval("Title") %>'>
                                            <%#Eval("Title")%></a></td>
                                        <td width="50%"><%#Eval("Create_Date", "{0:yyyy/MM/dd}")%></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </table>
                    </div>
                    <div id="pagecode">
                        <div id="page_code">
                            <gsp:AspNetPager ID="anpPage" OnPageChanged="anpPage_PageChanged" runat="server" AlwaysShow="true" FirstPageText="" LastPageText=""
                                PageSize="13" NextPageText="" PrevPageText="" ShowBoxThreshold="0" ShowCustomInfoSection="Left" LayoutType="Table"
                                NumericButtonCount="5" CustomInfoHTML="총：%RecordCount%　현재：%CurrentPageIndex%/%PageCount% 페이지　" UrlPaging="false">
                            </gsp:AspNetPager>
                        </div>
                    </div>
                    <div class="btn_div">
                        <input type="button" value="돌아가기" class="btn_style" onclick="javascrtpt: window.location.href = 'Main.aspx'" />
                    </div>
                </div>
            </div>
            <div id="footer">
                <img src="images/foot.jpg" align="left" style="margin: 0px 10px;" />이 정보 내용은 청소년 유해 매체물로서 정보통신망이용 촉진 밑 정보 보호 등에 관한 법률 및 청소년보호법의 규정에 의하여 18세 청소년이 이용 하실 수 없습니다.<br />
                COPYRING 2012 WTGAME ALL RIGHTS RESERYED
            </div>
            <div>
                <div style="float: left; margin-right: 30px;">
                    <img src="images/logo2.png" style="margin-top: 20px;" />
                </div>
                <div style="float: left">
                    <div class="navi">
                        <ul>
                            <li><a href="Agreement.aspx">이용약관</a></li>
                            <li><a href="PrivacyPolicy.aspx">개인정보 취급방침</a></li>
                            <li><a href="YouthProtecPolicy.aspx">청소년보호정책</a></li>
                            <li><a href="UtilizationPolicy.aspx">이용정책</a></li>
                            <li><a href="UtilizationLimitPolicy.aspx">이용제한정책</a></li>
                        </ul>
                    </div>
                    <div class="addr_div">
                        개인정보 책임관리자: 김남국  Email: zeus79@gmail.com &nbsp;&nbsp;대표자명: 김남국/ 사업자등록번호: 120-46-72181<br />
                        통신판매업 신고번호: 제 2011-서울 강남-03321호/ COPYRIGHT@ZEUS CO.ALL  RIGHTS RESERVED.
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
