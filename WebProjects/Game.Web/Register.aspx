<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Game.Web.Register" %>

<%@ Import Namespace="Game.Facade" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="css/index_style.css" />
    <link type="text/css" rel="stylesheet" href="css/regist.css" />
    <script type="text/javascript" src="scripts/jquery-1.8.3.js"></script>
    <script type="text/javascript" src="scripts/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="scripts/reg_check.js"></script>
    <script type="text/javascript">
        function hintMessage(hintObj, error, message) {
            //删除样式
            if (error == "error") {
                $("#" + hintObj + "").removeClass("onCorrect");
                $("#" + hintObj + "").removeClass("onFocus");
                $("#" + hintObj + "").addClass("onError");
            } else if (error == "right") {
                $("#" + hintObj + "").removeClass("onError");
                $("#" + hintObj + "").removeClass("onFocus");
                $("#" + hintObj + "").addClass("onCorrect");
            } else if (error == "info") {
                $("#" + hintObj + "").removeClass("onError");
                $("#" + hintObj + "").addClass("onFocus");
                $("#" + hintObj + "").removeClass("onCorrect");
            }

            $("#" + hintObj + "").html(message);
        }

        function checkAccounts() {
            if ($.trim($("#txtAccounts").val()) == "") {
                hintMessage("txtAccountsTip", "error", "아이디를 입력해주세요");
                return false;
            }

            if ($("#txtAccounts").val().length < 2 || $("#txtAccounts").val().length > 4) {
                hintMessage("txtAccountsTip", "error", "한글 2~4자로입력해주십시요");
                return false;
            }
            var koreanReg = /[(\\x3131-\\x318E|\\xAC00-\\xD7A3)]/gi;
            if ($("#txtAccounts").val().match(koreanReg)) {
                hintMessage("txtAccountsTip", "error", "한글 2~4자로입력해주십시요");
                return false;
            }
                    //hintMessage("txtAccountsTip", "right", "이미 가입된 아이디입니다.다시 입력해주세요");
            return true;
        }
        function clickAccounts() {
            if ($.trim($("#txtAccounts").val()) == "") {
                hintMessage("txtAccountsTip", "info", "아이디를 입력해주세요");
            }
        }
        function checkNickName() {
            if ($.trim($("#txtNickname").val()) == "") {
                hintMessage("txtNicknameTip", "error", "닉네임을 입력해주세요");
                return false;
            }
            if ($("#txtNickname").val().length < 2 || $("#txtNickname").val().length > 4) {
                hintMessage("txtNicknameTip", "error", "한글2~4자리까지 입력해주세요");
                return false;
            }
            var koreanReg = /[(\\x3131-\\x318E|\\xAC00-\\xD7A3)]/gi;
            if ($("#txtNickname").val().match(koreanReg)) {
                hintMessage("txtNicknameTip", "error", "한글2~4자리까지 입력해주세요");
                return false;
            }
                    //hintMessage("txtNicknameTip", "right", "이미 가입된 닉네임입니다.다시 입력해주세요");
            return true;
        }
        function clickNickName() {
            if ($.trim($("#txtNickname").val()) == "") {
                hintMessage("txtNicknameTip", "info", "닉네임을 입력해주세요");
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
                        hintMessage("txtAccountsTip", "error", json.msg);
                        isExitsUserName = true;
                        return;
                    } else if (json.success == "success") {
                        hintMessage("txtAccountsTip", "right", "<span style='color:#329E32'>가입가능합니다</span>");
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
                        hintMessage("txtNicknameTip", "error", json.msg);
                        isExitsNickName = true;
                        return;
                    } else if (json.success == "success") {
                        hintMessage("txtNicknameTip", "right", "<span style='color:#329E32'>가입가능합니다</span>");
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
                hintMessage("txtLogonPassTip", "error", "비밀번호를 입력해주세요");
                return false;
            }
            if ($("#txtLogonPass").val().length < 6) {
                hintMessage("txtLogonPassTip", "error", "비밀번호를 영문또는 숫자 6자이상입력하세요");
                return false;
            }
            hintMessage("txtLogonPassTip", "right", "");
            return true;
        }
        function clickLoginPass() {
            if ($.trim($("#txtLogonPass").val()) == "") {
                hintMessage("txtLogonPassTip", "info", "비밀번호를 입력해주세요)");
            }
        }
        function checkLoginConPass() {
            if ($("#txtLogonPass2").val() == "") {
                hintMessage("txtLogonPass2Tip", "error", "비밀번호 다시 입력해주세요");
                return false;
            }
            if ($("#txtLogonPass2").val() != $("#txtLogonPass").val()) {
                hintMessage("txtLogonPass2Tip", "error", "원래 비밀번호와 다르게 입력하였습니다");
                return false;
            }
            hintMessage("txtLogonPass2Tip", "right", "");
            return true;
        }
        function clickLoginConPass() {
            if ($.trim($("#txtLogonPass2").val()) == "") {
                hintMessage("txtLogonPass2Tip", "info", "비밀번호 다시 입력해주세요");
            }
        }
        function checkInsurePass() {
            if ($("#txtInsurePass1").val() == "") {
                hintMessage("txtInsurePass1Tip", "error", "환전비번을 입력해주세요");
                return false;
            }
            if ($("#txtInsurePass1").val().length < 6) {
                hintMessage("txtInsurePass1Tip", "error", "비밀번호를 영문또는 숫자 6자이상입력하세요");
                return false;
            }
            hintMessage("txtInsurePass1Tip", "right", "");
            return true;
        }

        function clickInsurePass() {
            if ($.trim($("#txtInsurePass1").val()) == "") {
                hintMessage("txtInsurePass1Tip", "info", "환전비번을 입력해주세요");
            }
        }

        function checkInsureConPass() {
            if ($("#txtInsurePass2").val() == "") {
                hintMessage("txtInsurePass2Tip", "error", "환전비번 다시 입력해주세요");
                return false;
            }
            if ($("#txtInsurePass2").val() != $("#txtInsurePass1").val()) {
                hintMessage("txtInsurePass2Tip", "error", "원래 비번와 다르게 입력하였습니다.다시 입력해주세요");
                return false;
            }
            hintMessage("txtInsurePass2Tip", "right", "");
            return true;
        }

        function clickInsureConPass() {
            if ($.trim($("#txtInsurePass2").val()) == "") {
                hintMessage("txtInsurePass2Tip", "info", "환전비번 다시 입력해주세요");
            }
        }

        function checkMobile() {
            if ($.trim($("#txtRegisterMobile").val()) == "") {
                hintMessage("txtRegisterMobileTip", "error", "전화번호 입력해주세요");
                return false;
            }
            hintMessage("txtRegisterMobileTip", "right", "");
            return true;
        }

        function clickMobile() {
            if ($.trim($("#txtRegisterMobile").val()) == "") {
                hintMessage("txtRegisterMobileTip", "info", "전화번호 입력해주세요");
            }
        }

        function checkRealName() {
            if ($.trim($("#txtRealName").val()) == "") {
                hintMessage("txtRealNameTip", "error", "실명을 입력해주세요");
                return false;
            }
            hintMessage("txtRealNameTip", "right", "");
            return true;
        }

        function clickRealName() {
            if ($.trim($("#txtRealName").val()) == "") {
                hintMessage("txtRealNameTip", "info", "실명을 입력해주세요");
            }
        }

        function checkBankName() {
            if ($.trim($("#txtBankName").val()) == "") {
                hintMessage("txtBankNameTip", "error", "은행명을 입력해주세요");
                return false;
            }
            hintMessage("txtBankNameTip", "right", "");
            return true;
        }

        function clickBankName() {
            if ($.trim($("#txtBankName").val()) == "") {
                hintMessage("txtBankNameTip", "info", "은행명을 입력해주세요");
            }
        }

        function checkBankAcccount() {
            if ($.trim($("#txtBankAcccount").val()) == "") {
                hintMessage("txtBankAcccountTip", "error", "은행계좌번호를 입력해주세요");
                return false;
            }
            var koreanReg = /^[0-9]+$/;
            if ($("#txtBankAcccount").val().match(koreanReg)) {
                hintMessage("txtBankAcccountTip", "right", "");
                return true;
            }
            else {
                hintMessage("txtBankAcccountTip", "error", "계좌번호는 숫자만 입력가능합니다 .");
                return false;
            }
            hintMessage("txtBankAcccountTip", "right", "");
            return true;
        }

        function clickBankAcccount() {
            if ($.trim($("#txtBankAcccount").val()) == "") {
                hintMessage("txtBankAcccountTip", "info", "은행계좌번호를 입력해주세요");
            }
        }

        function checkBankAcowner() {
            if ($.trim($("#txtBankAcowner").val()) == "") {
                hintMessage("txtBankAcownerTip", "error", "은행예금주를 입력해주세요");
                return false;
            }
            hintMessage("txtBankAcownerTip", "right", "");
            return true;
        }
        function clickBankAcowner() {
            if ($.trim($("#txtBankAcowner").val()) == "") {
                hintMessage("txtBankAcownerTip", "info", "은행예금주를 입력해주세요");
            }
        }

        function checkInput() {
            if (!checkAccounts()) {
                $("#txtAccounts").focus(); return false;
            } else {
                if (isExitsUserName) {
                    $("#txtAccounts").focus();
                    hintMessage("txtAccountsTip", "error", "죄송합니다.이미 가입된 아이디입니다.다시 입력해주세요");
                    return false;
                }
            }

            if (!checkNickName()) {
                $("#txtNickname").focus(); return false;
            } else {
                if (isExitsNickName) {
                    $("#txtNickname").focus();
                    hintMessage("txtNicknameTip", "error", "죄송합니다.이미 가입된 닉네임입니다.다시 입력해주세요");
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
            $("#txtLogonPass").blur(function () { checkLoginPass(); });
            $("#txtLogonPass2").blur(function () { checkLoginConPass(); });

            $("#txtInsurePass1").blur(function () { checkInsurePass(); });
            $("#txtInsurePass2").blur(function () { checkInsureConPass(); });

            $("#txtRegisterMobile").blur(function () { checkMobile(); });
            $("#txtRealName").blur(function () { checkRealName(); });

            $("#txtBankName").blur(function () { checkBankName(); });
            $("#txtBankAcccount").blur(function () { checkBankAcccount(); });
            $("#txtBankAcowner").blur(function () { checkBankAcowner(); });
        });

        $("#txtAccounts").focus(function () { clickAccounts(); });
        $("#txtNickname").focus(function () { checkNickName(); });
        $("#txtLogonPass").focus(function () { checkLoginPass(); });
        $("#txtLogonPass2").focus(function () { checkLoginConPass(); });

        $("#txtInsurePass1").focus(function () { checkInsurePass(); });
        $("#txtInsurePass2").focus(function () { checkInsureConPass(); });

        $("#txtRegisterMobile").focus(function () { checkMobile(); });
        $("#txtRealName").focus(function () { checkRealName(); });

        $("#txtBankName").focus(function () { checkBankName(); });
        $("#txtBankAcccount").focus(function () { checkBankAcccount(); });
        $("#txtBankAcowner").focus(function () { checkBankAcowner(); });
        function NotLogin() {
            alert("로그인 해주세요.");
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
</head>

<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="header">
                <div id="logo">
                    <a href="Main.aspx">
                        <img src="images/logo.png" style="margin-top: 18px; border: 0px;" /></a>
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
            <div id="regist">
                <div class="reg_tit">
                    회원가입
                </div>
                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td width="30%">아이디:</td>
                        <td width="22%">
                            <asp:TextBox ID="txtAccounts" runat="server" MaxLength="9" CssClass="cztk_text" onclick="this.select();"></asp:TextBox>
                        </td>
                        <td>
                            <span id="txtAccountsTip" class="onError"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>비밀번호:</td>
                        <td>
                            <asp:TextBox ID="txtLogonPass" runat="server" CssClass="cztk_text" TextMode="Password" onclick="this.select();"></asp:TextBox></td>
                        <td>
                            <span id="txtLogonPassTip" class="onError"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>비밀번호확인：</td>
                        <td>
                            <asp:TextBox ID="txtLogonPass2" runat="server" CssClass="cztk_text" TextMode="Password" onclick="this.select();"></asp:TextBox></td>
                        <td>
                            <span id="txtLogonPass2Tip" class="onError"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>닉네임:</td>
                        <td>
                            <asp:TextBox ID="txtNickname" runat="server" CssClass="cztk_text" MaxLength="9" onclick="this.select();"></asp:TextBox></td>
                        <td>
                            <span id="txtNicknameTip" class="onError"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>전화번호:</td>
                        <td>
                            <asp:TextBox ID="txtRegisterMobile" runat="server" CssClass="cztk_text" onclick="this.select();"></asp:TextBox></td>
                        <td>
                            <span id="txtRegisterMobileTip" class="onError"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>은행</td>
                        <td>
                            <asp:TextBox ID="txtBankName" runat="server" CssClass="cztk_text" onclick="this.select();"></asp:TextBox></td>
                        <td>
                            <span id="txtBankNameTip" class="onError"></span>
                        </td>
                    </tr>
                    <tr>
                        <td>계좌</td>
                        <td>
                            <asp:TextBox ID="txtBankAcccount" runat="server" onkeypress="if (event.keyCode&lt;48 || event.keyCode>57) event.returnValue=false;" onpaste="return false" CssClass="cztk_text" Style="ime-mode: disabled"></asp:TextBox></td>
                        <td>
                            <span id="txtBankAcccountTip" class="onError"></span></td>
                    </tr>
                    <tr>
                        <td>예금주</td>
                        <td>
                            <asp:TextBox ID="txtBankAcowner" runat="server" CssClass="cztk_text" onclick="this.select();"></asp:TextBox></td>
                        <td>
                            <span id="txtBankAcownerTip" class="onError"></span></td>
                    </tr>
                    <tr>
                        <td>환전비번:</td>
                        <td>
                            <asp:TextBox ID="txtInsurePass1" runat="server" CssClass="cztk_text" TextMode="Password" onclick="this.select();"></asp:TextBox></td>
                        <td>
                            <span id="txtInsurePass1Tip" class="onError"></span></td>
                    </tr>
                    <tr>
                        <td>환전비번확인:</td>
                        <td>
                            <asp:TextBox ID="txtInsurePass2" runat="server" CssClass="cztk_text" TextMode="Password" onclick="this.select();"></asp:TextBox></td>

                        <td>
                            <span id="txtInsurePass2Tip" class="onError"></span></td>
                    </tr>
                    <tr>
                        <td>추천인:</td>
                        <td>
                            <asp:TextBox ID="txtUpmemberPID" runat="server" CssClass="cztk_text" name="txtUpmemberPID" onblur="Check_UpmemberPID()" autocomplete="off" onclick="this.select();"></asp:TextBox></td>
                        <td><span id="txtUpmemberPIDTip" class="onError">추천인 아이디가 없거나 모르시면 입력하지 않아도 됩니다.</span>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnAdd" runat="server" class="btn_style" Text="가입신청"  OnClientClick="return checkInput()"
                                OnClick="btnRegister_Click" />
                            <input id="btnBack" type="button" value="돌아가기" class="btn_style" onclick="javascrtpt: window.location.href = 'Main.aspx'" />
                        </td>
                    </tr>
                </table>
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
