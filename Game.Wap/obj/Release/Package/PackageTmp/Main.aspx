<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Game.Wap.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="renderer" content="webkit" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" /> 
    <meta property="og:title" content="zeus" />
    <meta property="og:image" content="/WAP/content/images/banner.jpg" />
    <meta property="og:description" content="zeus" /> 
    <title></title>
    <link href="content/layui/css/layui.css" rel="stylesheet" />
    <link href="content/css/wap.css?v=1" rel="stylesheet" />
</head>
<body class="homebody">
    <form id="form1" runat="server">
        <div class="layui-layout layui-layout-admin top">
            <div class="header header-demo">
                <div class="layui-row">
                    <div class="layui-col-xs3 item fontleft">

                        <% if (Game.Facade.Fetch.GetUserCookie() == null)
                            { %>
                        <a href="<%=ServerName %>/login.aspx">
                            <span class="radiusBtn">로그인</span>
                        </a>
                        <%}
                            else
                            { %>
                        <span class="radiusBtn" id="loginedSpan">ID:<asp:Literal ID="ltAccount" runat="server"></asp:Literal>
                        </span>
                        <%} %>
                    </div>
                    <div class="layui-col-xs6 item">
                        <img src="<%=ServerName %>/content/images/top_logo.png" />
                    </div>
                    <div class="layui-col-xs3 item fontright">

                        <% if (Game.Facade.Fetch.GetUserCookie() == null)
                            { %>
                        <a href="<%=ServerName %>/Register.aspx">
                            <span class="radiusBtn">회원가입</span>
                        </a>
                        <%}
                            else
                            { %>
                        <a href="<%=ServerName %>/main.aspx?exit=true">
                            <span class="radiusBtn">로그아웃</span>
                        </a>
                        <%} %>
                    </div>
                </div>
            </div>

            <div class="layui-row">
                <ul class="nav">
                    <li class="nav-item nav-this"><a href="<%=ServerName %>/main.aspx">홈</a></li>

                    <% if (Game.Facade.Fetch.GetUserCookie() != null)
                        { %>
                    <li class="nav-item"><a href="NoticeList.aspx">공지사항</a></li>
                    <li class="nav-item"><a href="EventList.aspx">이벤트</a></li>
                    <li class="nav-item"><a href="GameInt.aspx">게임방법</a></li>
                    <li class="nav-item"><a href="MailFunction.aspx">쪽지</a></li>
                    <%}
                        else
                        {%>
                    <li class="nav-item"><a href="javascript:NotLogin()">공지사항</a></li>
                    <li class="nav-item"><a href="EventList.aspx">이벤트</a></li>
                    <li class="nav-item"><a href="GameInt.aspx">게임방법</a></li>
                    <li class="nav-item"><a href="javascript:NotLogin()">쪽지</a></li>

                    <%} %>
                </ul>
            </div>

            <div class="layui-row banner">
                <img src="<%=ServerName %>/content/images/banner.jpg" />
            </div>

            <div class="layui-row data">

                <div class="layui-tab layui-tab-brief" lay-filter="docDemoTabBrief">
                    <ul class="layui-tab-title">
                        <li class="layui-col-xs6 layui-this">주 게이지 상금랭킹</li>
                        <li class="layui-col-xs6">실시간 환전</li>
                    </ul>
                    <div class="layui-tab-content">
                        <div class="layui-tab-item layui-show">
                            <div class="title bgE8">
                                <div class="layui-col-xs5">
                                    <b>닉네임</b>
                                </div>
                                <div class="layui-col-xs2">
                                    <b>순위</b>
                                </div>
                                <div class="layui-col-xs5">
                                    <b>금액</b>
                                </div>
                            </div>
                            <div id="week1" class="week">
                                <div id="divUserData1" class="divUserData">
                                    <asp:Repeater ID="rptUserData1" runat="server">
                                        <ItemTemplate>
                                            <div class="item <%=i%2==0?"bgE8":"" %>">
                                                <div class="layui-col-xs5">
                                                    <b><%#Eval("Name")%></b>
                                                </div>
                                                <div class="layui-col-xs2">
                                                    <b><%=i%></b>
                                                </div>
                                                <div class="layui-col-xs5">
                                                    <b><%#Eval("money", "{0:N0}")%></b>
                                                </div>
                                            </div>
                                            <%++i;%>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>

                                <div id="divUserData2" class="divUserData"></div>
                            </div>
                        </div>
                        <div class="layui-tab-item">
                            <div id="week2" class="week">
                                <div id="divUserData3" class="divUserData">
                                    <%=EVENT.ToString() %>
                                </div>
                                <div id="divUserData4" class="divUserData"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class="layui-row client">
            <div class="client-item">

                <% if (Game.Facade.Fetch.GetUserCookie() != null)
                    { %>
                <a href="/download/Zeus.apk">
                    <img src="<%=ServerName %>/content/images/android_download.jpg" />
                </a>

                <%}
                    else
                    { %>
                <a href="javascript:NotLogin()">
                    <img src="<%=ServerName %>/content/images/android_download.jpg" />
                </a>
                <%} %>
            </div>
            <div class="client-item">
                <img src="<%=ServerName %>/content/images/work_time.jpg" />
            </div>
        </div>
        <div class="layui-row introduce1">
            제우스만의 EVENT
        </div>
        <div class="layui-row introduce2">
            <div id="events" class="events">
                <div id="eventInfo1">
                    <%=ScrollContents %>
                </div>
                <div id="eventInfo2"></div>
            </div>
        </div>
        <div class="layui-row footer">
            <div class="logo">
                <img src="<%=ServerName %>/content/images/bottom_logo.png" />
            </div>
            <div class="info">
                개인정보 책임관리자:김남국&emsp;Email:zeus79@gmail.com<br />
                대표자명:김남국/사업자등&emsp;사업자등록번호: 120-46-72181<br />
                통신판매업 신고번호:제 2011-서울 강남-03321호<br />
                COPYRIGHT@ZEUS CO.ALL RIGHTS RESERVED.
            </div>
            <div class="warning">
                이 정보 내용은 청소년 유해 매체물로서 정보통신망이용 촉진 밑 정보 보호 등에 관한 법률 및 청소년보호법의 규정에 의하여 18세 청소년이 이용 하실 수 없습니다.
            </div>
        </div>

    </form>
</body>
</html>

<script src="content/scripts/jquery-1.12.4.min.js"></script>
<script src="content/layui/layui.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        layui.use(['form', 'element', 'layer'], function () {
            var layer = layui.layer,
                layElement = layui.element,
                layform = layui.form;


<%
    if (!string.IsNullOrEmpty(PNOTICE))
    {
%>  
            if (document.cookie.indexOf("todayShow=1") < 0) {
                var index1 = layer.open({
                    skin: 'layui-layer-molv' //样式类名
                    , closeBtn: 0
                    , type: 1
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
                            console.log("하루동안 이 창을 열지 않음");
                        } else {
                            console.log("닫기");
                        }
                        layer.close(index1);
                    }
                    , btnAlign: 'c'
                    , shade: [0.5, '#000']
                });
            }
<%
    }
    if (!string.IsNullOrEmpty(PNOTICE2))
    {
        %> 
            if (document.cookie.indexOf("todayShow2=1") < 0) {
                var index2 = layer.open({
                    skin: 'layui-layer-molv' //样式类名
                    , closeBtn: 0
                    , type: 1
                    , title: '공지'
                    , content: '<%=  PNOTICE2.ToString() %><br><div style="text-align:center;"><input type="checkbox" id="cbtoday" /><label for="cbtoday">하루동안 이 창을 열지 않음</label></div>'
                    , btn: ['닫기']
                    , btn1: function () {
                        if ($('#cbtoday').get(0).checked) {
                            var exp = new Date();
                            var nowTime = 86400 - (exp.getHours() * 60 * 60 + exp.getMinutes() * 60 + exp.getSeconds());
                            exp.setTime(exp.getTime() + nowTime * 1000);
                            document.cookie = "todayShow2=1" + ";expires=" + exp.toGMTString();
                            layer.close();
                            console.log("하루동안 이 창을 열지 않음");
                        } else {
                            console.log("닫기");
                        }
                        layer.close(index2);
                    }
                    , btnAlign: 'c'
                    , shade: [0.5, '#000']
                });
            }
<%
    }
%>

            <%
    if (Game.Facade.Fetch.GetUserCookie() != null)
    {
        %>
            $('#loginedSpan').on('click', function () {

                layer.open({
                    skin: 'layui-layer-molv' //样式类名
                    , closeBtn: 0
                    , title: '공지'
                    , content: '<div><div>회원님의 게이지는 게임대기실에서</div><div>확인할수 있습니다</div><%= string.Format("<div>아 이 디：{0}</div><div>닉 네 임：{1}</div>",memberID,MemberName) %></div>'
                    , btn: ['Close']
                    , btnAlign: 'c'
                    , shade: [0.5, '#000']
                });
            });
            <%
    }
    %>

            var speed = 50;
            divUserData2.innerHTML = divUserData1.innerHTML
            function Marquee() {
                if (divUserData2.offsetHeight - week1.scrollTop <= 0) {
                    week1.scrollTop -= divUserData1.offsetHeight;
                }
                else {
                    week1.scrollTop++;
                }
            }
            setInterval(Marquee, speed);


            divUserData4.innerHTML = divUserData3.innerHTML
            function Marquee2() {
                if (divUserData4.offsetHeight - week2.scrollTop <= 0) {
                    week2.scrollTop -= divUserData3.offsetHeight;
                }
                else {
                    week2.scrollTop++;
                }
            }
            setInterval(Marquee2, speed);



            eventInfo2.innerHTML = eventInfo1.innerHTML
            function Marquee3() {
                if (eventInfo2.offsetHeight - events.scrollTop <= 0)
                    events.scrollTop -= eventInfo1.offsetHeight;
                else {
                    events.scrollTop++;
                }
            }

            setInterval(Marquee3, speed);


        });
    });

    function NotLogin() {
        alert("로그인 해주세요.");
    }
</script>
