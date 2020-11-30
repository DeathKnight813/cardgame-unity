<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMail.aspx.cs" Inherits="Game.Wap.AddMail" %>

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
<body class="mailBody">
    <form id="form1" runat="server" class="layui-form">
        <div class="layui-row header">
            <div class="layui-col-xs3 fontleft">
                <a href="<%=ServerName %>/MailFunction.aspx">
                    <img src="<%=ServerName %>/content/images/back_icon_w.png" />
                    돌아가기
                </a>
            </div>
            <div class="layui-col-xs6">
                <span>쪽지발송</span>
            </div>
        </div>

        <div class="add">
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
            </div>
            <div class="radiubottom">
                <asp:TextBox ID="txtContent" runat="server" class="layui-textarea" Rows="10" cols="30"
                    TextMode="MultiLine" MaxLength="200" placeholder="내용을 입력하세요"></asp:TextBox>
            </div>
            <div class="layui-form-item">
                <asp:Button ID="btnsure" runat="server" Text="쪽지 보내기" class="layui-btn button" OnClientClick="return checkInput()" OnClick="btnsure_Click" />
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
        $("#txtContent").focus();
    });
    function checkInput() {
        if ($("#txtContent").val() == "") {
            alert("내용을 비워 둘수 없습니다");
            $("#txtAccounts").focus();
            return false;
        }
        return true;
    }
    function NotLogin() {
        alert("로그인 해주세요.");
    }
</script>
