<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Game.Wap.Register" %>

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
<body class="registerBody">
    <form id="form1" runat="server" class="layui-form">
        <div class="layui-form-item header">
            <div class="layui-col-xs3 fontleft">
                <a href="<%=ServerName %>/main.aspx">
                    <img src="<%=ServerName %>/content/images/back_icon_w.png" />
                    홈으로
                </a>
            </div>
            <div class="layui-col-xs6">
                <span>회원가입</span>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                아이디:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtAccounts" runat="server" CssClass="layui-input" placeholder="한글 2~4자로 입력해주십시요"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                비밀번호:	
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtLogonPass" runat="server" placeholder="비밀번호를 입력해주세요" CssClass="layui-input" TextMode="Password"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                비밀번호확인:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtLogonPass2" runat="server" placeholder="비밀번호를 입력해주세요" CssClass="layui-input" TextMode="Password"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                닉네임:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtNickname" runat="server" placeholder="한글 2~4자리까지 입력해주세요" CssClass="layui-input"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                전화번호:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtRegisterMobile" runat="server" placeholder="전화번호를 입력해주세요" CssClass="layui-input"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                은행:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtBankName" runat="server" placeholder="은행명을 입력해주세요" CssClass="layui-input"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                계좌:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtBankAcccount" runat="server" onkeypress="if (event.keyCode&lt;48 || event.keyCode>57) event.returnValue=false;" onpaste="return false" placeholder="은행계좌번호를 입력해주세요" CssClass="layui-input" Style="ime-mode: disabled"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                예금주:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtBankAcowner" runat="server" placeholder="은행예금주를 입력해주세요" CssClass="layui-input" onclick="this.select();"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                환전비번:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtInsurePass1" runat="server" placeholder="환전비번을 입력해주세요" CssClass="layui-input" TextMode="Password" onclick="this.select();"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                환전비번확인:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtInsurePass2" runat="server" placeholder="환전비번을 입력해주세요" CssClass="layui-input" TextMode="Password" onclick="this.select();"></asp:TextBox>
            </div>
        </div>
        <div class="layui-form-item">
            <label class="layui-form-label">
                추천인:
            </label>
            <div class="layui-input-block">
                <asp:TextBox ID="txtUpmemberPID" runat="server" placeholder="추천인 아이디가 없으시면 입력 안하셔도 됩니다" CssClass="layui-input" autocomplete="off" onclick="this.select();"></asp:TextBox>
            </div>
        </div>

        <div class="layui-form-item login-div-button"> 
            <div class="layui-input-block">
                <asp:Button ID="btnSubmit" runat="server" CssClass="layui-btn login-btn1" OnClientClick="return checkInput()" Text="회원가입" OnClick="btnSubmit_Click"></asp:Button>
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
    function hintMessage(hintObj, message) {
        alert(message);
    }

    function checkAccounts() {
        if ($.trim($("#txtAccounts").val()) == "") {
            hintMessage("txtAccounts", "아이디를 입력해주세요");
            return false;
        }

        if ($("#txtAccounts").val().length < 2 || $("#txtAccounts").val().length > 4) {
            hintMessage("txtAccounts", "한글 2~4자로입력해주십시요");
            return false;
        }
        var koreanReg = /[(\\x3131-\\x318E|\\xAC00-\\xD7A3)]/gi;
        if ($("#txtAccounts").val().match(koreanReg)) {
            hintMessage("txtAccounts", "한글 2~4자로입력해주십시요");
            return false;
        }

        return true;
    }
    function clickAccounts() {
        if ($.trim($("#txtAccounts").val()) == "") {
            hintMessage("txtAccounts", "아이디를 입력해주세요");
        }
    }
    function checkNickName() {
        if ($.trim($("#txtNickname").val()) == "") {
            hintMessage("txtNickname", "닉네임을 입력해주세요");
            return false;
        }
        if ($("#txtNickname").val().length < 2 || $("#txtNickname").val().length > 4) {
            hintMessage("txtNickname", "한글2~4자리까지 입력해주세요");
            return false;
        }
        var koreanReg = /[(\\x3131-\\x318E|\\xAC00-\\xD7A3)]/gi;
        if ($("#txtNickname").val().match(koreanReg)) {
            hintMessage("txtNickname", "한글2~4자리까지 입력해주세요");
            return false;
        }
        return true;
    }
    function clickNickName() {
        if ($.trim($("#txtNickname").val()) == "") {
            hintMessage("txtNickname", "닉네임을 입력해주세요");
        }
    }
    var isExitsUserName = true;
    function checkUserName() {
        $.ajax({
            async: false,
            contentType: "application/json",
            url: "WS/WSAccount.asmx/CheckName",
            data: "{userName:'" + $("#txtAccounts").val() + "'}",
            type: "POST",
            dataType: "json",
            success: function (json) {
                json = eval("(" + json.d + ")");

                if (json.success == "error") {
                    hintMessage("txtAccounts", json.msg);
                    isExitsUserName = true;
                    return;
                } else if (json.success == "success") {
                    //hintMessage("txtAccounts", "<span style='color:#329E32'>가입가능합니다</span>");
                    isExitsUserName = false;
                    return;
                }
            },
            error: function (err, ex) {
                //alert(err.responseText);
            }
        });
    }
    var isExitsNickName = true
    function checknickname() {
        $.ajax({
            async: false,
            contentType: "application/json",
            url: "WS/WSAccount.asmx/CheckNickName",
            data: "{NickName:'" + $("#txtNickname").val() + "'}",
            type: "POST",
            dataType: "json",
            success: function (json) {
                json = eval("(" + json.d + ")");

                if (json.success == "error") {
                    hintMessage("txtNickname", json.msg);
                    isExitsNickName = true;
                    return;
                } else if (json.success == "success") {
                    //hintMessage("txtNickname", "<span style='color:#329E32'>가입가능합니다</span>");
                    isExitsNickName = false;
                    return;
                }
            },
            error: function (err, ex) {
                //alert(err.responseText);
            }
        });
    }

    function checkLoginPass() {
        if ($("#txtLogonPass").val() == "") {
            hintMessage("txtLogonPass", "비밀번호를 입력해주세요");
            return false;
        }
        if ($("#txtLogonPass").val().length < 6) {
            hintMessage("txtLogonPass", "비밀번호를 영문또는 숫자 6자이상입력하세요");
            return false;
        }
        return true;
    }
    function clickLoginPass() {
        if ($.trim($("#txtLogonPass").val()) == "") {
            hintMessage("txtLogonPass", "비밀번호를 입력해주세요)");
        }
    }
    function checkLoginConPass() {
        if ($("#txtLogonPass2").val() == "") {
            hintMessage("txtLogonPass2", "비밀번호 다시 입력해주세요");
            return false;
        }
        if ($("#txtLogonPass2").val() != $("#txtLogonPass").val()) {
            hintMessage("txtLogonPass2", "원래 비밀번호와 다르게 입력하였습니다");
            return false;
        }
        return true;
    }
    function clickLoginConPass() {
        if ($.trim($("#txtLogonPass2").val()) == "") {
            hintMessage("txtLogonPass2", "비밀번호 다시 입력해주세요");
        }
    }
    function checkInsurePass() {
        if ($("#txtInsurePass1").val() == "") {
            hintMessage("txtInsurePass1", "환전비번을 입력해주세요");
            return false;
        }
        if ($("#txtInsurePass1").val().length < 6) {
            hintMessage("txtInsurePass1", "비밀번호를 영문또는 숫자 6자이상입력하세요");
            return false;
        }
        return true;
    }

    function clickInsurePass() {
        if ($.trim($("#txtInsurePass1").val()) == "") {
            hintMessage("txtInsurePass1", "환전비번을 입력해주세요");
        }
    }

    function checkInsureConPass() {
        if ($("#txtInsurePass2").val() == "") {
            hintMessage("txtInsurePass2", "환전비번 다시 입력해주세요");
            return false;
        }
        if ($("#txtInsurePass2").val() != $("#txtInsurePass1").val()) {
            hintMessage("txtInsurePass2", "원래 비번와 다르게 입력하였습니다.다시 입력해주세요");
            return false;
        }
        return true;
    }

    function clickInsureConPass() {
        if ($.trim($("#txtInsurePass2").val()) == "") {
            hintMessage("txtInsurePass2", "환전비번 다시 입력해주세요");
        }
    }

    function checkMobile() {
        if ($.trim($("#txtRegisterMobile").val()) == "") {
            hintMessage("txtRegisterMobile", "전화번호 입력해주세요");
            return false;
        }
        return true;
    }

    function clickMobile() {
        if ($.trim($("#txtRegisterMobile").val()) == "") {
            hintMessage("txtRegisterMobile", "전화번호 입력해주세요");
        }
    }

    function checkRealName() {
        if ($.trim($("#txtRealName").val()) == "") {
            hintMessage("txtRealName", "실명을 입력해주세요");
            return false;
        }
        return true;
    }

    function clickRealName() {
        if ($.trim($("#txtRealName").val()) == "") {
            hintMessage("txtRealName", "실명을 입력해주세요");
        }
    }

    function checkBankName() {
        if ($.trim($("#txtBankName").val()) == "") {
            hintMessage("txtBankName", "은행명을 입력해주세요");
            return false;
        }
        return true;
    }

    function clickBankName() {
        if ($.trim($("#txtBankName").val()) == "") {
            hintMessage("txtBankName", "은행명을 입력해주세요");
        }
    }

    function checkBankAcccount() {
        if ($.trim($("#txtBankAcccount").val()) == "") {
            hintMessage("txtBankAcccount", "은행계좌번호를 입력해주세요");
            return false;
        }
        var koreanReg = /^[0-9]+$/;
        if ($("#txtBankAcccount").val().match(koreanReg)) {
            //hintMessage("txtBankAcccount", "");
            return true;
        }
        else {
            hintMessage("txtBankAcccount", "계좌번호는 숫자만 입력가능합니다 .");
            return false;
        }
        //hintMessage("txtBankAcccount", "");
        return true;
    }

    function clickBankAcccount() {
        if ($.trim($("#txtBankAcccount").val()) == "") {
            hintMessage("txtBankAcccount", "은행계좌번호를 입력해주세요");
        }
    }

    function checkBankAcowner() {
        if ($.trim($("#txtBankAcowner").val()) == "") {
            hintMessage("txtBankAcowner", "은행예금주를 입력해주세요");
            return false;
        }
        //hintMessage("txtBankAcowner", "");
        return true;
    }

    function clickBankAcowner() {
        if ($.trim($("#txtBankAcowner").val()) == "") {
            hintMessage("txtBankAcowner", "은행예금주를 입력해주세요");
        }
    }

    function checkInput() {
        if (!checkAccounts()) {
            $("#txtAccounts").focus();
            return false;
        } else {
            if (isExitsUserName) {
                $("#txtAccounts").focus();
                hintMessage("txtAccounts", "죄송합니다.이미 가입된 아이디입니다.다시 입력해주세요");
                return false;
            }
        }

        if (!checkNickName()) {
            $("#txtNickname").focus();
            return false;
        } else {
            if (isExitsNickName) {
                $("#txtNickname").focus();
                hintMessage("txtNickname", "죄송합니다.이미 가입된 닉네임입니다.다시 입력해주세요");
                return false;
            }
        }

        if (!checkLoginPass()) { $("#txtLogonPass").focus(); return false; }
        if (!checkLoginConPass()) { $("#txtLogonPass2").focus(); return false; }
        if (!checkInsurePass()) { $("#txtInsurePass1").focus(); return false; }
        if (!checkInsureConPass()) { $("#txtInsurePass2").focus(); return false; }
        if (!checkMobile()) { $("#txtRegisterMobile").focus(); return false; }
        //if (!checkRealName()) { $("#txtRealName").focus(); return false; }

        if (!checkBankName()) { $("#txtBankName").focus(); return false; }
        if (!checkBankAcccount()) { $("#txtBankAcccount").focus(); return false; }
        if (!checkBankAcowner()) { $("#txtBankAcowner").focus(); return false; }
        return true;
    }

    $(document).ready(function () {
        $("#txtAccounts").blur(function () {
            if (checkAccounts()) {
                checkUserName();
            }
        });

        $("#txtNickname").blur(function () {
            if (checkNickName()) {
                checknickname();
            }
        });
        //$("#txtLogonPass").blur(function () { checkLoginPass(); });
        //$("#txtLogonPass2").blur(function () { checkLoginConPass(); });

        //$("#txtInsurePass1").blur(function () { checkInsurePass(); });
        //$("#txtInsurePass2").blur(function () { checkInsureConPass(); });

        //$("#txtRegisterMobile").blur(function () { checkMobile(); });
        //$("#txtRealName").blur(function () { checkRealName(); });

        //$("#txtBankName").blur(function () { checkBankName(); });
        //$("#txtBankAcccount").blur(function () { checkBankAcccount(); });
        //$("#txtBankAcowner").blur(function () { checkBankAcowner(); });
    });

    //$("#txtAccounts").focus(function () { clickAccounts(); });
    //$("#txtNickname").focus(function () { checkNickName(); });
    //$("#txtLogonPass").focus(function () { checkLoginPass(); });
    //$("#txtLogonPass2").focus(function () { checkLoginConPass(); });

    //$("#txtInsurePass1").focus(function () { checkInsurePass(); });
    //$("#txtInsurePass2").focus(function () { checkInsureConPass(); });

    //$("#txtRegisterMobile").focus(function () { checkMobile(); });
    //$("#txtRealName").focus(function () { checkRealName(); });

    //$("#txtBankName").focus(function () { checkBankName(); });
    //$("#txtBankAcccount").focus(function () { checkBankAcccount(); });
    //$("#txtBankAcowner").focus(function () { checkBankAcowner(); });
    function NotLogin() {
        alert("로그인 해주세요.");
    }
</script>
