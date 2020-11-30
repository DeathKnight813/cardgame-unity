<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Game.NewWeb.Main" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="content/layui/css/layui.css" rel="stylesheet" />
    <link href="content/css/web.css" rel="stylesheet" />
    <style>
        .ogImg {
            width: 0px;
            height: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="layui-form">
        <img class="ogImg" src="/wap/content/images/banner.jpg" />
        <div class="header">
            <div class="content">
                <div class="logo">
                    <a href="Main.aspx">
                        <img src="/content/images/logo.jpg" /></a>
                </div>
                <div class="menu">

                    <% if (Game.Facade.Fetch.GetUserCookie() != null)
                        { %>
                    <a href="Main.aspx">
                        <div class="item itembg1 item-this1">
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
                        <div class="item itembg5">
                            쪽지
                        </div>
                    </a>
                    <%}
                        else
                        { %>
                    <a href="Main.aspx">
                        <div class="item itembg1 item-this1">
                            홈 
                        </div>
                    </a>
                    <div class="itemSplit"></div>
                    <a href="javascript:NotLogin();">
                        <div class="item itembg2">
                            공지사항
                        </div>
                    </a>
                    <div class="itemSplit"></div>
                    <a href="javascript:NotLogin();">
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
                    <a href="javascript:NotLogin();">
                        <div class="item itembg5">
                            쪽지
                        </div>
                    </a>
                    <%} %>
                </div>
            </div>
        </div>
        <div class="main">
            <div class="content">
                <div class="login floatLeft">
                    <% if (Game.Facade.Fetch.GetUserCookie() == null)
                        { %>
                    <div class="layui-form-item logo">
                        <img src="/content/images/login_title.jpg" />
                    </div>
                    <div class="layui-form-item">
                        <label class="layui-row">아이디:</label>
                        <div class="layui-row">
                            <asp:TextBox ID="txtAccounts" runat="server" TabIndex="1" class="layui-input" />
                        </div>
                    </div>
                    <div class="layui-form-item">
                        <label class="layui-row">패스워드:</label>
                        <div class="layui-row">
                            <asp:TextBox ID="txtLogonPass" runat="server" TabIndex="1" class="layui-input" TextMode="Password" />
                        </div>
                    </div>
                    <div class="layui-form-item">
                        <div class="layui-row">
                            <asp:Button ID="btnlogin" runat="server" CssClass="layui-btn log_btn" Text="로그인" OnClientClick="return checkInput()" OnClick="btnlogin_Click" TabIndex="3" />
                        </div>
                    </div>

                    <div class="layui-form-item">
                        <div class="bottomDiv">
                            <div class="floatLeft">
                                <input type="checkbox" id="cbRemember" title="ID저장" lay-skin="primary" />
                            </div>
                            <div class="floatRight">
                                <input type="button" value="회원가입" class="layui-btn reg_btn" onclick="javascrtpt: window.location.href = 'Register.aspx'" />
                            </div>
                        </div>
                    </div>

                    <%}
                        else
                        { %>

                    <div class="layui-form-item logo">
                        <img src="/content/images/login_title.jpg" />
                    </div>
                    <div class="layui-form-item">
                        <div class="layui-row">
                            회원님의 게이지는 게임대기실에서 확인할수 있습니다
                        </div>
                    </div>
                    <div class="layui-form-item">
                        <label class="layui-form-label">아 이 디:</label>
                        <div class="layui-form-mid">
                            <asp:Literal ID="ltAccount" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="layui-form-item">
                        <label class="layui-form-label">패스워드:</label>
                        <div class="layui-form-mid">
                            <asp:Literal ID="ltNickName" runat="server"></asp:Literal>
                        </div>
                    </div>
                    <div class="layui-form-item">
                        <div class="layui-row">
                            <input type="button" value="로그아웃" class="layui-btn log_btn" onclick="javascrtpt: window.location.href = '/Main.aspx?exit=true'" />
                        </div>
                    </div>
                    <%} %>
                </div>

                <div class="banner">
                    <img src="/content/images/pc_banner.jpg" />
                </div>

                <div class="Events floatRight">
                    <div class="eventInfo" id="events">
                        <div class="info" id="info1">
                            <%=ScrollContents %>
                        </div>
                        <div class="info" id="info2"></div>
                    </div>
                </div>
            </div>
            <div class="content">
                <div class="download floatLeft">

                    <%if (Game.Facade.Fetch.GetUserCookie() != null)
                        { %>
                    <a href="/download/Zeus_setup_1052.exe" class="down1">&nbsp;</a>
                    <a href="/download/Zeus.apk" class="down2">&nbsp;</a>
                    <a href="http://downloadus1.teamviewer.com/download/TeamViewer_Setup_ko.exe" class="down3">&nbsp;</a>
                    <a href="#" class="down4">&nbsp;</a>
                    <%}
                        else
                        { %>
                    <a href="javascript:NotLogin();" class="down1">&nbsp;</a>
                    <a href="javascript:NotLogin();" class="down2">&nbsp;</a>
                    <a href="http://downloadus1.teamviewer.com/download/TeamViewer_Setup_ko.exe" class="down3">&nbsp;</a>
                    <a href="javascript:NotLogin();" class="down4">&nbsp;</a>
                    <%} %>
                </div>

                <div class="data1 floatLeft">
                    <div class="title">
                        <%=Event1.Title %>
                        <%--EVENT--%>
                    </div>
                    <div class="menu layui-col-xs10 layui-col-xs-offset1">
                    </div>
                    <div class="datacontent layui-col-xs10 layui-col-xs-offset1" id="data2">
                        <div id="divUserData3" class="divUserData">
                            <%=  Event1.Content %>
                        </div>
                        <div id="divUserData4" class="divUserData"></div>
                    </div>
                </div>

                <div class="data1 floatLeft">
                    <div class="title">
                        <%=Event2.Title %>
                        <%--주 게이지 상금랭킹--%>
                    </div>
                    <%--                    <div class="menu layui-col-xs10 layui-col-xs-offset1">
                        <div class="item layui-col-xs4 border-right">
                            <b>닉네임</b>
                        </div>
                        <div class="item layui-col-xs4">
                            <b>순위</b>
                        </div>
                        <div class="item layui-col-xs4 border-left">
                            <b>금액</b>
                        </div>
                    </div>--%>
                    <div class="datacontent layui-col-xs10 layui-col-xs-offset1" id="data1">
                        <div id="divUserData1" class="divUserData">
                            <%=Event2.Content %>
                            <%--                            <asp:Repeater ID="rptUserData1" runat="server">
                                <ItemTemplate>
                                    <div class="layui-row data-item">
                                        <div class="layui-col-xs4">
                                            <b><%#Eval("Name")%></b>
                                        </div>
                                        <div class="layui-col-xs4">
                                            <b><%=i%></b>
                                        </div>
                                        <div class="layui-col-xs4">
                                            <b><%#Eval("money", "{0:N0}")%></b>
                                        </div>
                                    </div>
                                    <%++i;%>
                                </ItemTemplate>
                            </asp:Repeater>--%>
                        </div>
                        <div id="divUserData2" class="divUserData"></div>
                    </div>
                </div>

                <div class="accordion floatRight">
                    <ul>
                        <li class="row1 row4">제우스게임 영업시간안내
                        </li>
                        <div class="pp">
                            <img src="/content/images/pic1.jpg" />
                        </div>
                        <li class="row2">제우스게임 게이지EVENT
                        </li>
                        <div class="pp" style="display: none;">
                            <img src="/content/images/pic2.jpg" />
                        </div>
                        <li class="row3">제우스게임 잭팟&봉황EVENT
                        </li>
                        <div class="pp" style="display: none;">
                            <img src="/content/images/pic3.jpg" />
                        </div>
                    </ul>
                </div>
            </div>
            <div class="FriendLink">
                <div class="layui-row">
                    <div class="layui-col-xs2 layui-col-xs-offset1">
                        <a href="https://www.naver.com/" target="_blank">
                            <img src="/content/images/naver.jpg" />
                        </a>
                    </div>
                    <div class="layui-col-xs2">
                        <a href="http://named.com/" target="_blank">
                            <img src="/content/images/named.jpg" />
                        </a>
                    </div>
                    <div class="layui-col-xs2">
                        <a href="https://www.facebook.com/" target="_blank">
                            <img src="/content/images/facebook.jpg" />
                        </a>
                    </div>
                    <div class="layui-col-xs2">
                        <a href="https://twitter.com/" target="_blank">
                            <img src="/content/images/twitter.jpg" />
                        </a>
                    </div>
                    <div class="layui-col-xs2">
                        <a href="https://www.youtube.com/" target="_blank">
                            <img src="/content/images/youtube.jpg" />
                        </a>
                    </div>
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
                    이 정보 내용은 청소년 유해 매체물로서 정보통신망이용 촉진 밑 정보 보호 등에 관한 법률 및 청소년보호법의 규정에 의하여 18세
                    <br />
                    청소년이 이용 하실 수 없습니다.<br />
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
    layui.use(['element', 'form'], function () {
        var layElement = layui.element,
            layForm = layui.form;

        <%
    if (!string.IsNullOrEmpty(PNOTICE))
    {
%>  
        if (document.cookie.indexOf("todayShow=1") < 0) {
            var index1 = layer.open({
                skin: 'layui-layer-molv' //样式类名
                , closeBtn: 0
                , type: 1
                , offset: ['100px', $(document).width() / 2]
                , title: '공지'
                , content: '<%=  PNOTICE.ToString() %><br><div style="text-align:center;"><input type="checkbox" id="cbtoday" /><label for="cbtoday">하루동안 이 창을 열지 않음</label></div>'
                , btn: ['닫기']
                , btn1: function () {
                    if ($('#cbtoday').get(0).checked) {
                        var exp = new Date();
                        var nowTime = 86400 - (exp.getHours() * 60 * 60 + exp.getMinutes() * 60 + exp.getSeconds());
                        exp.setTime(exp.getTime() + nowTime * 1000);
                        document.cookie = "todayShow=1" + ";expires=" + exp.toGMTString();
                        layer.close();
                        //console.log("하루동안 이 창을 열지 않음");
                    } else {
                        //console.log("닫기");
                    }
                    layer.close(index1);
                }
                , btnAlign: 'c'
                , shade: 0
            });
        }
<%
    }

    if (!string.IsNullOrEmpty(PNOTICE2))
    {
        %>
        if (document.cookie.indexOf("todayShow=1") < 0) {
            var index2 = layer.open({
                skin: 'layui-layer-molv' //样式类名
                , closeBtn: 0
                , type: 1
                , offset: ['100px', $(document).width() / 2 - 400]
                , title: '공지'
                , content: '<%=  PNOTICE2.ToString() %><br><div style="text-align:center;"><input type="checkbox" id="cbtoday" /><label for="cbtoday">하루동안 이 창을 열지 않음</label></div>'
                , btn: ['닫기']
                , btn1: function () {
                    if ($('#cbtoday').get(0).checked) {
                        var exp = new Date();
                        var nowTime = 86400 - (exp.getHours() * 60 * 60 + exp.getMinutes() * 60 + exp.getSeconds());
                        exp.setTime(exp.getTime() + nowTime * 1000);
                        document.cookie = "todayShow=1" + ";expires=" + exp.toGMTString();
                        layer.close();
                        //console.log("하루동안 이 창을 열지 않음");
                    } else {
                        //console.log("닫기");
                    }
                    layer.close(index2);
                }
                , btnAlign: 'c'
                , shade: 0
            });
        }
<%
    }
%>

        var pic_limouseover = undefined;
        $(".accordion li").mouseover(function () {
            var _self = this;
            // 停止卷起事件 				
            clearTimeout(pic_limouseover);
            pic_limouseover = setTimeout(function (obj) {
                $(".accordion li").not(_self).next().slideUp();
                $(_self).next().slideDown();
                $(".accordion li").not(_self).removeClass("row4");
                $(_self).addClass("row4");
            }, 100);
        })

        var speed = 50;
        divUserData2.innerHTML = divUserData1.innerHTML
        function Marquee() {
            if (divUserData2.offsetHeight - data1.scrollTop <= 0)
                data1.scrollTop -= divUserData1.offsetHeight
            else {
                data1.scrollTop++
            }
        }
        var MyMar = setInterval(Marquee, speed)

        data1.onmouseover = function () { clearInterval(MyMar) }
        data1.onmouseout = function () { MyMar = setInterval(Marquee, speed) }


        divUserData4.innerHTML = divUserData3.innerHTML
        function Marquee2() {
            if (divUserData4.offsetHeight - data2.scrollTop <= 0) {
                data2.scrollTop -= divUserData3.offsetHeight
            }
            else {
                //console.log(data2.scrollTop + '----' + divUserData3.offsetHeight);
                data2.scrollTop++
            }
        }
        var MyMar2 = setInterval(Marquee2, speed)

        data2.onmouseover = function () { clearInterval(MyMar2) }
        data2.onmouseout = function () { MyMar2 = setInterval(Marquee2, speed) }


        info2.innerHTML = info1.innerHTML
        function Marquee3() {
            if (info2.offsetHeight - events.scrollTop <= 0)
                events.scrollTop -= info1.offsetHeight
            else {
                events.scrollTop++
            }
        }

        var MyMar3 = setInterval(Marquee3, speed)
        events.onmouseover = function () { clearInterval(MyMar3) }
        events.onmouseout = function () { MyMar3 = setInterval(Marquee3, speed) }
    });
</script>

<script type="text/javascript">

    function NotLogin() {
        alert("로그인 해주세요.");
    }

    function urlredirect() {
        var sUserAgent = navigator.userAgent.toLowerCase();
        if ((sUserAgent.match(/(ipod|iphone os|midp|ucweb|android|windows ce|windows mobile)/i))) {

            window.location.href = 'wap/';
        }
    }
    urlredirect();
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
