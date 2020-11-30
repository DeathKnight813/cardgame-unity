<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Game.Web.Main" %>

<%@ Import Namespace="Game.Facade" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link type="text/css" rel="stylesheet" href="css/index_style.css" />
    <link type="text/css" rel="stylesheet" href="css/rotate.css" />
    <script type="text/javascript" src="scripts/jquery-1.8.3.js"></script>
    <script type="text/javascript" src="scripts/jQueryRotate.2.2.js"></script>
    <script type="text/javascript" src="scripts/jquery.easing.min.js"></script>
    <script src="scripts/swfobject_modified.js" type="text/javascript"></script>
    <script type="text/javascript">
        function NotLogin() {
            alert("로그인 해주세요.");
        }
        function checkInput() {
            if ($("#txtAccounts").val() == "") {
                alert("아이디를 입력해주세요");
                $("#txtAccounts").focus();
                return false;
            }
            if ($("#txtLogonPass").val() == "") {
                alert("비밀번호를 입력해주세요");
                $("#txtLogonPass").focus();
                return false;
            }
            return true;
        }
        function WaitForInt() {
            alert("等待开发");
        }
    </script>
    <style type="text/css">
        #apDiv1 {
            position: absolute;
            width: 200px;
            height: 115px;
            z-index: 1;
        }

        #apDiv2 {
            position: absolute;
            width: 377px;
            height: 413px;
            z-index: 1;
            left: 389px;
            top: 147px;
        }

        #show {
            width: 688px;
            margin: 0 auto;
        }

        a {
            color: #039;
        }

            a:hover {
                color: #f60;
            }

        .pop {
            position: absolute;
            left: 27%;
            top: 15%;
            height: 625px;
            background: url(video/5.png);
        }

        .pop_head {
            position: relative;
            height: 36px;
            background: url(video/1.png);
        }

            .pop_head a {
                position: absolute;
                right: 8px;
                line-height: 20px;
                color: #000;
                text-decoration: none;
            }

                .pop_head a:hover {
                    color: #f60;
                    text-decoration: none;
                }

        .pop_body {
            padding: 0px;
        }

        #logo img {
            border: 0px;
        }

        .t_sel a {
            display: inline-block;
            width: 100%;
            height: 40px;
            text-decoration: none;
            color: #fff;
        }
        .notice_popup{
            visibility:hidden;
            border:0;
            padding:0;
	        background: #1652c8;
	        float: left;
	        font-size: 1.2em;
	        position: fixed;
	        top: 300px; left: 400px;
            width:500px;
            height:300px;
	        z-index: 99999;
        }
        #mask {
	        display: none;
	        background: #000; 
	        position: fixed; left: 0; top: 0; 
	        z-index: 10;
	        width: 100%; height: 100%;
	        opacity: 0.8;
	        z-index: 999;
        }
        img.btn_close {
	        float: right; 
	        margin: -27px -27px 0 0;
        }
    </style>
</head>

<body>
    <form id="Form1" runat="server">
    	<div style="position:absolute; top:93px; left:50%; ">
			<div style="position:relative; top:0; left:-780px">
				<a href="http://happyland82.com/happykorea"><img src="images/sidebanner.gif"/></a>
			</div>
		</div>
		<div style="position:absolute; top:93px; left:50%;">
			<div style="position:relative; top:0; left:630px">
				<a href="http://happyland82.com/happykorea"><img src="images/sidebanner.gif"/></a>
			</div>
		</div>
        <div id="container">
            <div id="header">
                <div id="logo">
                    <a href="Main.aspx">
                        <img src="images/logo.png" style="margin-top: 8px;" /></a>
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
                        <li class="t_sel"><a href="EventList.aspx">이벤트</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="GameInt.aspx">게임방법</a></li>
                        <li><img src="images/col_line2.png" style="margin-top: 7px" /></li>
                        <li class="t_sel"><a href="javascript:void(0);" onclick="NotLogin();">쪽지</a></li>
                        <%} %>
                    </ul>

                </div>
            </div>
            <div id="main">
                <div id="login">
                    <% if (Fetch.GetUserCookie() == null)
                       { %>
                    <table id="login_begin" width="100%" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                    	    <td colspan="3" class="title">회원로그인</td>
                        </tr>
                	    <tr>
                    	    <td width="33%" style="text-align:right">아이디:</td>
                            <td colspan="2" width="67%"><asp:TextBox ID="txtAccounts" runat="server" TabIndex="1" class="txt_style"></asp:TextBox></td>
                        </tr>
                        <tr>
                    	    <td style="text-align:right">패스워드:</td>
                            <td colspan="2"><asp:TextBox ID="txtLogonPass" runat="server" TextMode="Password" TabIndex="2" class="txt_style"></asp:TextBox></td>
                        </tr>
                    
                        <tr>
						    <td>&nbsp;</td>
						    <td width="35%"><input type="button" value="회원가입" class="reg_btn" onclick="javascrtpt: window.location.href = 'Register.aspx'" /></td>
						    <td><input type="checkbox" />ID저장</td>
					    </tr>
                        <tr>
                    	    <td colspan="3" style="text-align:center"><asp:Button ID="btnlogin" runat="server" CssClass="log_btn" Text="로그인" OnClientClick="return checkInput()" OnClick="btnlogin_Click" TabIndex="3" /></td>
                        </tr>
                    </table>
                    <%}
                       else
                       { %>
                     <table  align="right" id="login_after2" width="100%" border="0" cellpadding="0" cellspacing="0"> 
                   		<tr>
                            <td style="text-align: center;">회원님의 게이지는 게임대기실에서</td>
                        </tr>
                        <tr>
                            <td style="text-align: center;">확인할수 있습니다</td>
                        </tr>

                    </table>
                    <table align="right" id="login_after" width="100%" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td style="text-align: right;">아 이 디：</td>
                            <td>
                                <asp:Literal ID="ltAccount" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">닉 네 임：</td>
                            <td>
                                <asp:Literal ID="ltNickName" runat="server"></asp:Literal>
                            </td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        </tr>
                        <tr><td /></tr>
                        <tr>
                            <td colspan="20" style="text-align: center ">
                                <input type="button" value="로그아웃" class="log_btn" onclick="javascrtpt: window.location.href = '/Main.aspx?exit=true'" />
                            </td>
                        </tr>
                        </table>
                    <%} %>
                </div>
                <div id="banner">
                    <img src="images/example.jpg" width="538px" height="257px" />
                </div>
                <div id="pic">
                    <ul>
                        <li class="row1 row4"></li>
                        <div class="pp">
                            <img src="images/ch_1.jpg" width="288px" height="170"/>
                        </div>
                        <li class="row2"></li>
                        <div class="pp" style="display: none;">
                            <img src="images/ch_2.jpg" width="288px" height="170"  onclick="javascrtpt: window.location.href = 'Event2.aspx'" />
                        </div>
                        <li class="row3"></li>
                        <div class="pp" style="display: none;">
                            <img src="images/ch_3.jpg" width="288px" height="170"  onclick="javascrtpt: window.location.href = 'Event1.aspx'" />
                        </div>
                    </ul>
                </div>
                <div id="left_div">
                    <div id="mid_btn">
                        <ul>
                            <% if (Fetch.GetUserCookie() != null)
                               { %>
                            <!--<li><a href="javascript:ShowMessage('충환전은 게임대기실에서 신청해주세요');" class="mid_btn4"></a>
                                <a href="javascript:ShowMessage('충환전은 게임대기실에서 신청해주세요');" class="mid_btn5"></a></li>-->
                                <li><a href="http://downloadus1.teamviewer.com/download/TeamViewer_Setup_ko.exe" class="mid_btn3"></a></li>
                            	<li><a href="download/Zeus_setup_1052.exe" class="mid_btn1"></a></li>
                            	<li><a href="http://114.108.165.133/download/Zeus.apk" class="mid_btn2"></a>
                                	<a href="download/Zeus.png" class="mid_btn6"></a></li>
                            	<li><a href="http://happyland82.com/happykorea" class="mid_btn7"></a></li>
                            <%}
                               else
                               { %>
                            <!-- <li><a href="javascript:void(0);" onclick="NotLogin();" class="mid_btn4"></a>
                                <a href="javascript:void(0);" onclick="NotLogin();" class="mid_btn5"></a></li>-->
                            	<li><a href="http://downloadus1.teamviewer.com/download/TeamViewer_Setup_ko.exe" class="mid_btn3"></a></li>
                            	<li><a href="javascript:void(0);" onclick="NotLogin();" class="mid_btn1"></a></li>
                            	<li><a href="javascript:void(0);" onclick="NotLogin();" class="mid_btn2"></a></li>
                            	<li><a href="http://happyland82.com/happykorea" class="mid_btn7"></a></li>
                            <%} %>
                        </ul>
                    </div>
                </div>
                <div id="mid">
                    <div class="mode" style="background-color: #eeeeee;">
                        <div class="m_title">실시간 환전</div>
                        <div class="tab_h">
                            <a href="#" style="border-right: #92c0ea 1px dashed">닉네임</a><a href="#">머니</a>
                        </div>
                        <div class="m_txt">
                            <div id="demo" style="height: 190px; overflow: hidden; width: 268px; float: left; display: inline;">
                                <div id="demo1">
                                    <ul>
                                        <asp:Repeater ID="repmoney" runat="server">
                                            <ItemTemplate>
                                                <li><span><%#Eval("UserNickName")%></span><span><%#Eval("ApplyMoney", "{0:N0}")%></span></li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div id="demo2">
                                </div>
                                <script type="text/javascript">
                                    //文字无间断滚动代码，兼容IE、Firefox、Opera
                                    var speed = 50;
                                    demo2.innerHTML = demo1.innerHTML
                                    function Marquee() {
                                        if (demo2.offsetHeight - demo.scrollTop <= 0)
                                            demo.scrollTop -= demo1.offsetHeight
                                        else {
                                            demo.scrollTop++
                                        }
                                    }

                                    var MyMar = setInterval(Marquee, speed)
                                    demo.onmouseover = function () { clearInterval(MyMar) }
                                    demo.onmouseout = function () { MyMar = setInterval(Marquee, speed) }
                                </script>
                            </div>
                        </div>
                    </div>
                    <div style="width: 8px; float: left">&nbsp;</div>
                    <div class="mode" style="background-color: #eeeeee;">
                        <div class="m_title">주 게이지 상금랭킹</div>
                        <div class="tab_h">
                            <a href="#" style="border-right: #92c0ea 1px dashed">닉네임</a><a href="#" style="border-right: #92c0ea 1px dashed">순위</a><a href="#">금액</a>
                        </div>
                        <div class="m_txt">
                            <div id="gundong5" style="height: 190px; overflow: hidden; width: 268px; float: left; display: inline;">
                                <div id="gundong6">
                                    <ul>
                                        <asp:Repeater ID="repbackmoney" runat="server">
                                            <ItemTemplate>
                                                <li><span><%#Eval("Name")%></span><span><%=i%></span><span><%#Eval("money", "{0:N0}")%></span></li>
                                                <%++i;%>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                </div>
                                <div id="gundong7">
                                </div>
                                <script type="text/javascript">
                                    //文字无间断滚动代码，兼容IE、Firefox、Opera
                                    var speed = 50;
                                    gundong7.innerHTML = gundong6.innerHTML
                                    function Marqueegundong() {
                                        if (gundong7.offsetHeight - gundong5.scrollTop <= 0)
                                            gundong5.scrollTop -= gundong6.offsetHeight
                                        else {
                                            gundong5.scrollTop++
                                        }
                                    }

                                    var MyMar2 = setInterval(Marqueegundong, speed)
                                    gundong5.onmouseover = function () { clearInterval(MyMar2) }
                                    gundong5.onmouseout = function () { MyMar2 = setInterval(Marqueegundong, speed) }
                                </script>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="notice"  style="background-color: #eeeeee;">
                    <div class="n_title">제우스만의 EVENT</div>
                    <div class="s_txt">
                                <marquee scrollamount="2" direction="up" behavior="scroll" style="width: 268px; height: 219px;" onmouseover="this.stop()" onmouseout="this.start()">
                                        <%=ScrollContents %>
                                </marquee>
                            </div>
                    <div class="n_txt">
                        <div id="pop" class="pop" style="display: none">
                            <div class="pop_head">
                                <a href="javascript:void(0);" onclick="hide()">
                                    <img src="images/dialog_closebtn_over.gif" width="100%" style="cursor: pointer; border: 0px;" /></a>
                            </div>
                            
                        </div>
                    </div>
                  </div>
                <div style="clear: both;"></div>
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
                            <li><a href="javascript:void(0);">이용약관</a></li>
                            <li><a href="javascript:void(0);">개인정보 취급방침</a></li>
                            <li><a href="javascript:void(0);">청소년보호정책</a></li>
                            <li><a href="javascript:void(0);">이용정책</a></li>
                            <li><a href="javascript:void(0);">이용제한정책</a></li>
                        </ul>

                    </div>
                    <div class="addr_div">
                        개인정보 책임관리자: 김남국  Email: zeus79@gmail.com &nbsp;&nbsp;대표자명: 김남국/ 사업자등록번호: 120-46-72181<br />
                        통신판매업 신고번호: 제 2011-서울 강남-03321호/ COPYRIGHT@ZEUS CO.ALL  RIGHTS RESERVED.
                    </div>
                </div>
            </div>
        </div>
        <div id="popup_layer" class="notice_popup" > 
            <a href="javascript:" class="close_pop"><img src="/images/close_pop.png" class="btn_close" title="Close Window" alt="Close" /></a>
            <table border="0" cellspacing="0" cellpadding="0" style="width:100%; height:100%;" >
                <tr height="30" style="text-align:center; background-color:#1652c8;font-size:18px; font-weight:bold;color:#fff;">
                    <td>공&nbsp;지</td>
                </tr>
                <tr style="text-align:center; background-color:#a9b9ed;font-size:14px;">
                    <td><span><%=PNOTICE %></span></td>
                </tr>
            </table>
        </div>
        <script type="text/javascript">
            function ShowMessage(msg)
            {
                alert(msg);
            }
            function AutoPopup() {
                <%if(PNOTICE != string.Empty){%>
                    var layer = document.getElementById("popup_layer");
                    layer.style.visibility = "visible";
                    $('body').append('<div id="mask"></div>');
                    $('#mask').fadeIn(100);
                <%}%>
            }
            $(document).ready(function () {
                AutoPopup();
                $('a.close_pop').live('click', function () {
                    $('#popup_layer').fadeOut(100, function () {
                        var layer = document.getElementById("popup_layer");
                        layer.style.visibility = "hidden";
                        $('#mask').remove();
                    });
                    return false;
                });
            });
            var pic_limouseover = undefined;
            $("#pic li").mouseover(function () {
                var _self = this;
                // 停止卷起事件 				
                clearTimeout(pic_limouseover);
                pic_limouseover = setTimeout(function (obj) {
                    $("#pic li").not(_self).next().slideUp();
                    $(_self).next().slideDown();
                    $("#pic li").not(_self).removeClass("row4");
                    $(_self).addClass("row4");
                }, 100);
            })
            swfobject.registerObject("FlashID");

        </script>
    </form>
</body>
</html>
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
