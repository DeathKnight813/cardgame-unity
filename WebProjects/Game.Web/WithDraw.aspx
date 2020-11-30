<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WithDraw.aspx.cs" Inherits="Game.Web.WithDraw" %>

<%@ Import Namespace="Game.Facade" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="scripts/jquery-1.8.3.js"></script>
    <link type="text/css" rel="stylesheet" href="css/index_style.css" />
    <link type="text/css" rel="stylesheet" href="css/notice.css" />
    <style type="text/css">
        .mid_div {
            width: 700px;
            height: 450px;
            margin: auto;
        }

        .message_div {
            width: 90%;
            margin: auto;
            background-color: #bed8ff;
            height: 60px;
            margin-top: 40px;
            padding: 2%;
            text-align: left;
            margin-bottom: 20px;
        }

        .price_btn {
            width: 100px;
            cursor: pointer;
        }

        .mid_div td {
            height: 40px;
            line-height: 40px;
            text-align: left;
        }

        .price_btn_h {
            height: 61px;
            width: 90px;
            cursor: pointer;
        }

        .red_txt {
            color: #F60;
            font-weight: bold;
        }
    </style>
    <script type="text/javascript">

        window.onkeypress = function () {
            if (event.keyCode == 13) {
                document.getElementById('btnsure').click();
            }
        }

        $(document).ready(function () {
            $("#txtWithdrawalsPass").focus();
        });
        function checkInput() {
            if ($("#txtWithdrawalsPass").val() == "") {
                alert("비밀번호를 입력해주세요.");
                $("#txtWithdrawalsPass").focus();
                return false;
            }
            return true;
        }
    </script>
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
                    <img src="images/logo.png" style="margin-top: 18px;border: 0px;" />
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
                <div class="title">환  전</div>
                <div class="context">
                    <div class="mid_div">
                        <div class="message_div">환전요청하시고 1대1에  문의해주시길 바랍니다.</div>
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td width="150px" style="text-align: right">아이디： </td>
                                <td colspan="2"><span class="red_txt">
                                    <asp:Label ID="labaccount" runat="server"></asp:Label></span></td>
                                <td colspan="3">보유머니：<span class="red_txt"><asp:Label ID="labnowmoney" runat="server"></asp:Label>만원</span></td>
                            </tr>
                            <tr>
                                <td style="text-align: right">환전금액：</td>
                                <td colspan="5">
                                    <label for="textfield"></label>
                                    <asp:TextBox ID="txtmoney" runat="server" Enabled="false"></asp:TextBox><span class="red_txt">만원</span></td>
                            </tr>
                            <tr>
                                <td rowspan="2">&nbsp;</td>
                                <td>
                                    <asp:Button ID="btnOne" runat="server" Text=" 1만원 " class="price_btn" OnClick="btnOne_Click" /></td>
                                <td>
                                    <asp:Button ID="btnTwo" runat="server" Text=" 2만원 " class="price_btn" OnClick="btnTwo_Click" /></td>
                                <td>
                                    <asp:Button ID="btnFive" runat="server" Text=" 5만원 " class="price_btn" OnClick="btnFive_Click" /></td>
                                <td>
                                    <asp:Button ID="btnTen" runat="server" Text=" 10만원" class="price_btn" OnClick="btnTen_Click" /></td>
                                <td rowspan="2">
                                    <asp:Button ID="btnclear" runat="server" class="price_btn_h" Text="초기화" OnClick="btnclear_Click" /></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnTwenty" runat="server" class="price_btn" Text="20만원" OnClick="btnTwenty_Click" /></td>
                                <td>
                                    <asp:Button ID="btnThirty" runat="server" class="price_btn" Text="30만원" OnClick="btnThirty_Click" /></td>
                                <td>
                                    <asp:Button ID="btnFifty" runat="server" class="price_btn" Text="50만원" OnClick="btnFifty_Click" /></td>
                                <td>
                                    <asp:Button ID="btnHundred" runat="server" class="price_btn" Text="100만원" OnClick="btnHundred_Click" /></td>
                            </tr>
                            <tr>
                                <td style="text-align: right">환전비밀번호：</td>
                                <td colspan="3">
                                    <asp:TextBox ID="txtWithdrawalsPass" runat="server" TextMode="Password"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td colspan="6" style="text-align: center">
                                    <asp:Button class="btn_style" ID="btnsure" runat="server" Text="환전신청" OnClientClick="return checkInput()" OnClick="btnsure_Click" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <input type="button" class="btn_style" value="닫기" onclick="javascrtpt: window.location.href = 'Main.aspx'" />
                                </td>
                            </tr>
                        </table>
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
