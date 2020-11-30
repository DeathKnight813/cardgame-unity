<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventList.aspx.cs" Inherits="Game.Wap.EventList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="renderer" content="webkit" />
    <meta name="viewport" content="width=device-width,initial-scale=1.0,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <title></title>
    <link href="content/layui/css/layui.css" rel="stylesheet" />
    <link href="content/css/wap.css?v=1" rel="stylesheet" />
</head>
<body class="eventBody">
    <form id="form1" runat="server">
        <div class="layui-row header">
            <div class="layui-col-xs3 fontleft">
                <a href="<%=ServerName %>/main.aspx">
                    <img src="<%=ServerName %>/content/images/back_icon_w.png" />
                    홈으로
                </a>
            </div>
            <div class="layui-col-xs6">
                <span>이벤트</span>
            </div>
        </div>

        <div class="event-list">
            <%
                if (RecordCounts != 0)
                {
            %>

            <asp:Repeater ID="rptData" runat="server">
                <ItemTemplate>
                    <div class="event-item">
                        <div class="layui-col-xs8 title">
                            <a href="<%=ServerName %>/EventDetails.aspx?param=<%# Eval("Title")%>">
                                <%#Eval("Title")%>
                            </a>
                        </div>
                        <div class="layui-col-xs-4 time">
                            <img src="<%=ServerName %>/content/images/time_icon.png" />
                            <%#Eval("Create_Date", "{0:yyyy-MM-dd}")%>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <%
                if (currPageIndex * PageSize < RecordCounts)
                {
            %>
            <div class="More">
                <a href="<%=ServerName %>/EventList.aspx?p=<%=currPageIndex + 1 %>">
                    <img src="<%=ServerName %>/content/images/next_page.png" />
                    <br />
                    <span class="layui-btn button">다음 페이지 </span>
                </a>
            </div>
            <%
                }
            %>

            <%
                }
                else
                {
            %>
            <div class="event-nothing">
                <img src="<%=ServerName %>/content/images/notice_null.jpg" /><br />
                <span>돌발이벤트 진행중...</span>
            </div>
            <%
                }
            %>
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
