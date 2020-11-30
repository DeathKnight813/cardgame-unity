// JavaScript Document

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

            //var reg = /[\x3130-\x318F]+/;
            //if (!reg.test($("#txtAccounts").val())) {
            //    hintMessage("txtAccountsTip", "error", "用户名是2到4个韩文字组成！");
            //    return false;
            //}

            if ($("#txtAccounts").val().length < 5) {
                hintMessage("txtAccountsTip", "error", "아이디를  5자 이상입력해 주세요");
                return false;
            }
            hintMessage("txtAccountsTip", "right", "이미 가입된 아이디입니다.다시 입력해주세요");
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
                //var reg = /[\x3130-\x318F]+/;
                //if (!reg.test($("#txtNickname").val())) {
                //    hintMessage("txtNicknameTip", "error", "昵称是2到4个韩文字组成！");
                //    return false;
                //}
            else if ($("#txtNickname").val().length < 2 || $("#txtNickname").val().length > 5) {
                hintMessage("txtNicknameTip", "error", "닉네임은 2자~5자로 입력하세요");
                return false;
            }
            hintMessage("txtNicknameTip", "right", "이미 가입된 닉네임입니다.다시 입력해주세요");
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
                        hintMessage("txtAccountsTip", "right", "가입가능합니다");
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
                        hintMessage("txtNicknameTip", "right", "가입가능합니다");
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
            if ($("#txtLogonPass").val().length < 5) {
                hintMessage("txtLogonPassTip", "error", "비밀번호를 영문또는 숫자 5자이상입력하세요");
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
            if ($("#txtInsurePass1").val().length < 5) {
                hintMessage("txtInsurePass1Tip", "error", "비밀번호를 영문또는 숫자 5자이상입력하세요");
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
            if (!checkRealName()) { $("#txtRealName").focus(); return false; }

            if (!checkBankName()) { $("#txtBankName").focus(); return false; }
            if (!checkBankAcccount()) { $("#txtBankAcccount").focus(); return false; }
            if (!checkBankAcowner()) { $("#txtBankAcowner").focus(); return false; }
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