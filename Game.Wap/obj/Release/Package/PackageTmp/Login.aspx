<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Game.Wap.Login" %>

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
<body class="loginbody">
    <form id="form1" runat="server" class="layui-form">
        <div class="layui-form-item header">
            <div class="layui-col-xs3 fontleft">
                <a href="<%=ServerName %>/main.aspx">
                    <img src="<%=ServerName %>/content/images/back_icon.png" />
                    홈으로
                </a>
            </div>
        </div>
        <div class="layui-form-item">
            <div class="logo">
                <img src="<%=ServerName %>/content/images/logo1.png" />
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                ID:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtAccounts" runat="server" placeholder="아이디를 입력해주세요" CssClass="layui-input"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                PW:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtLogonPass" TextMode="Password" runat="server" placeholder="비밀번호를 입력해주세요" CssClass="layui-input"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">

            <div class="layui-input-block">
                <a class="layui-btn login-btn1 floatLeft" href="<%=ServerName %>/Register.aspx">회원가입</a>
                <asp:Button ID="btnSubmit" runat="server" CssClass="layui-btn login-btn2 floatRight" OnClientClick="return checkInput()" Text="로그인" OnClick="btnSubmit_Click"></asp:Button>
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
<script src="/content/layui/layui.js"></script>

