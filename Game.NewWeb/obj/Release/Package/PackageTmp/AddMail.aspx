<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMail.aspx.cs" Inherits="Game.NewWeb.AddMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="content/layui/css/layui.css" rel="stylesheet" />
    <link href="content/css/web.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="layui-form">
        <div class="header">
            <div class="content">
                <div class="logo">
                    <a href="Main.aspx">
                        <img src="/content/images/logo.jpg" /></a>
                </div>
                <div class="menu">
                    <a href="Main.aspx">
                        <div class="item itembg1">
                            홈
                        </div>
                    </a>
                    <div class="itemSplit"></div>
                    <a href="NoticeList.aspx">
                        <div class="item itembg2 ">
                            공지사항
                        </div>
                    </a>
                    <div class="itemSplit"></div>
                    <a href="EventList.aspx">
                        <div class="item itembg3">
                            이벤트
                        </div>
                    </a>
                    <div class="itemSplit"></div>
                    <a href="GameInt.aspx">
                        <div class="item itembg4">
                            게임방법
                        </div>
                    </a>
                    <div class="itemSplit"></div>
                    <a href="MailFunction.aspx">
                        <div class="item itembg5 item-this5">
                            쪽지
                        </div>
                    </a>
                </div>
            </div>
        </div>

        <div class="main">
            <div class="list">
                <div class="menu">
                    <a href="/main.aspx">홈</a> >> 쪽지
                </div>
                <div class="datalist">
                    <div class="layui-form-item">
                        <div class="layui-form-label title-label">
                            받는사람:
                        </div>
                        <div class="layui-input-block">
                            <span class="layui-form-mid">운영자</span>
                        </div>
                    </div>
                    <div class="layui-form-item radiuTop">
                        <div class="layui-form-label title-label">
                            내&emsp;&emsp;용: 
                        </div>
                        <div class="layui-input-block">
                            <asp:TextBox ID="txtContent" runat="server" class="layui-textarea" Rows="10" cols="30"
                                TextMode="MultiLine" MaxLength="200" placeholder="내용을 입력하세요"></asp:TextBox>
                        </div>
                    </div>
                    <div class="layui-form-item">
                        <div class="layui-input-block">
                            <asp:Button ID="btnsure" runat="server" Text="쪽지 보내기" class="layui-btn button" OnClientClick="return checkInput()" OnClick="btnsure_Click" />
                        </div>
                    </div>
                </div>

                <div class="download">
                    <%if (Game.Facade.Fetch.GetUserCookie() != null) { %>
                    <ul>
                        <li>
                            <a href="/download/Zeus_setup.exe">
                                <img src="/content/images/PC-button.jpg" />
                            </a>
                        </li>
                        <li>
                            <a href="/download/Zeus.apk">
                                <img src="/content/images/andr_button.jpg" />
                            </a>
                        </li>
                        <li>
                            <a href="http://downloadus1.teamviewer.com/download/TeamViewer_Setup_ko.exe">
                                <img src="/content/images/team_button.jpg" />
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                <img src="/content/images/time.jpg" />
                            </a>
                        </li>
                    </ul>
                    <%} else { %>
                     <ul>
                        <li>
                            <a href="javascript:NotLogin();">
                                <img src="/content/images/PC-button.jpg" />
                            </a>
                        </li>
                        <li>
                            <a href="javascript:NotLogin();">
                                <img src="/content/images/andr_button.jpg" />
                            </a>
                        </li>
                        <li>
                            <a href="javascript:NotLogin();">
                                <img src="/content/images/team_button.jpg" />
                            </a>
                        </li>
                        <li>
                            <a href="javascript:NotLogin();">
                                <img src="/content/images/time.jpg" />
                            </a>
                        </li>
                    </ul>
                    <%} %>
                </div>
            </div>
        </div>


        <div class="footer">
            <div class="content">
                <div class="logo">
                    <img src="/content/images/logo_b.jpg" />
                </div>
                <div class="message">
                    <div class="menu">
                        <div class="item"><a href="javascript:void(0);">이용약관</a></div>
                        <div class="item"><a href="javascript:void(0);">개인정보 취급방침</a></div>
                        <div class="item"><a href="javascript:void(0);">청소년보호정책</a></div>
                        <div class="item"><a href="javascript:void(0);">이용정책</a></div>
                        <div class="item"><a href="javascript:void(0);">이용제한정책</a></div>
                    </div>
                    <div class="info">
                        <span>개인정보 책임관리자: 김남국</span> <span>Email: zeus79@gmail.com</span><span>대표자명: 김남국/ 사업자등록번호: 120-46-72181</span><br />
                        <span>통신판매업 신고번호: 제 2011-서울 강남-03321호/ COPYRIGHT@ZEUS CO.ALL RIGHTS RESERVED.</span>
                    </div>
                </div>
            </div>
            <div class="content">
                <div class="logo2">
                    <img src="/content/images/18no.jpg" />
                </div>
                <div class="warning">
                    이 정보 내용은 청소년 유해 매체물로서 정보통신망이용 촉진 밑 정보 보호 등에 관한 법률 및 청소년보호법의 규정에 의하여 18세 청소년이 이용 하실 수 없습니다.<br />
                    COPYRING 2012 WTGAME ALL RIGHTS RESERYED 
                </div>
            </div>
        </div>
    </form>
</body>
</html>

<script src="content/scripts/jquery-1.12.4.min.js"></script>
<script src="content/layui/layui.js"></script>

<script type="text/javascript">
    function NotLogin() {
        alert("로그인 해주세요.");
    } 
</script>
<!-- TocPlus -->
<script type="text/javascript">
    tocplusTop = 90;
    tocplusLeft = 850;
    tocplusMinimizedImage = 'http://kr08.tocplus007.com/img/minimized_ko.gif';
    tocplusHAlign = 'right';
    tocplusWidth = 180;
    tocplusHeight = 200;
    tocplusUserName = '손님';
    tocplusFrameColor = 'orange';
    tocplusFloatingWindow = true;
    var tocplusHost = (("https:" == document.location.protocol) ? "https://" : "http://");
    document.write(unescape("%3Cscript src='" + tocplusHost + "kr07.tocplus007.com/chatLoader.do?userId=vipsky' type='text/javascript'%3E%3C/script%3E"));
</script>
<!-- End of TocPlus -->