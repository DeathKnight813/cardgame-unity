<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameInt.aspx.cs" Inherits="Game.Web.GameInt" %>

<%@ Import Namespace="Game.Facade" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" rel="stylesheet" href="css/index_style.css" />
    <link type="text/css" rel="stylesheet" href="css/notice.css" />
    <style type="text/css">
        #txt {
            height: 530px;
            overflow: auto;
            color: #306;
        }
        .t_sel a {
            display: inline-block;
            width: 100%;
            height: 40px;
            text-decoration: none;
            color: #fff;
        }
    </style>
    <script type="text/javascript">
        function NotLogin() {
            alert("로그인 해주세요.");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="header">
                <div id="logo">
                    <a href="Main.aspx">
                        <img src="images/logo.png" style="margin-top: 18px;border: 0px;" /></a>
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
            <div id="main">
                <div class="title">
                    게임방법
                </div>
                <div class="context">
                    <div id="txt">
                        <div class="tbody m-tcol-c" id="tbody">
                            <h3>
                                <span style="font-size: 11pt;">★ 골프 / 세컨드 / 써드: <span class="highlight">바둑이</span> 최고의 <span class="highlight">족보</span></span>
                            </h3>
                            <p>
                                네장의 카드에 중 무늬와 숫자가 모두 다르고 숫자가 가장 낮은 조합의 경우, 로우<span class="highlight">바둑이</span>의 <span class="highlight">족보</span>에서 가장 높은 <span class="highlight">족보</span>입니다.
                                <br>
                                가장 <span class="highlight">족보</span> 3가지는 <strong>"골프 =&gt; 세컨드 =&gt; 써드"</strong>라고 합니다.
                            </p>
                            <p><strong></strong></p>
                            <p>
                                <strong>① ♠1, ♡2, ◇3, ♣4</strong><br>
                                골프: 무늬가 모두 다르면서 A, 2, 3, 4로 이루어졌기 때문에 로우<span class="highlight">바둑이</span>에서 가장 높은 <span class="highlight">족보</span>입니다.
                            </p>
                            <p>
                                <span style="font-size: 11pt;">
                                    <img name="cafeuserimg" id="userImg5508984" style="width: 250px; height: 84px;" onclick="popview(this)" onload="resizeImage(5508984)" src="images/a234.gif"></span>
                            </p>
                            <p><span style="font-size: 11pt;"></span></p>
                            <p>
                                <span style="font-size: 9pt;"><strong><span style="font-size: 9pt;">② ♠1, ◇2, ♡3, ♣5</span><br>
                                </strong>세컨드: 역시 무늬가 모두 다르면서 A, 2, 3, 5로 이루어졌기 때문에 로우<span class="highlight">바둑이</span>에서 두번째로 높은 <span class="highlight">족보</span>입니다. </span>
                            </p>
                            <p>
                                <span style="font-size: 9pt;">
                                    <img name="cafeuserimg" id="userImg9781712" style="width: 250px; height: 84px;" onclick="popview(this)" onload="resizeImage(9781712)" src="images/a235.gif"></span>
                            </p>
                            <p><span style="font-size: 9pt;"></span></p>
                            <p>
                                <span style="font-size: 9pt;"><strong>③ ◇1, ♣2, ♡4, ♠5<br>
                                </strong>써드: 마지막으로 무늬가 모두 다르면서 A, 2, 4, 5로 이루어졌기 때문에 로우<span class="highlight">바둑이</span>에서 세번째로 높은 <span class="highlight">족보</span>입니다.</span>
                            </p>
                            <p>
                                <span style="font-size: 9pt;">
                                    <img name="cafeuserimg" id="userImg6363652" style="width: 250px; height: 84px;" onclick="popview(this)" onload="resizeImage(6363652)" src="images/a245.gif"></span>
                            </p>
                            <p><span style="font-size: 9pt;"></span></p>
                            <p><span style="font-size: 9pt;"></span></p>
                            <span style="font-size: 9pt;">
                                <h3><span style="font-size: 11pt;">★ 메이드: 카드의 무늬와 숫자가 모두 다른 경우</span></h3>
                                <p>
                                    <strong>① ♠4, ♡6, ◇J, ♣K</strong><br>
                                    4장의 무늬와 숫자가 모두 다르기 때문에 메이드 입니다.
                                </p>
                                <p>
                                    <img name="cafeuserimg" id="userImg6812030" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(6812030)" src="images/46jk.gif">
                                </p>
                                <p></p>
                                <p>
                                    <strong>② ♠8, ◇10, ♡J, ♣Q<br>
                                    </strong>역시 메이드. 예시 1번과 비교했을 때 가장 높은 숫자가 낮기 때문에 (K와 Q를 비교) 예시 2번이 예시1번을 이깁니다.
                                </p>
                                <p>
                                    <img name="cafeuserimg" id="userImg2797788" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(2797788)" src="images/810jq.gif">
                                </p>
                                <p></p>
                                <p></p>
                                <p>
                                    <strong>③ ◇4, ♣5, ♡J, ♠K</strong><br>
                                    메이드 성립. 예시 1번과 비교했을 때 가장 높은 숫자가 같기 때문에 (K와 K비교) 그 다음으로 높은 숫자를 비교합니다.
                                </p>
                                <p>두 번째로 높은 숫자도 J로 같기 때문에 다시 그 다음으로 높은 숫자를 비교합니다. 6과 5중에 5가 더 작은 숫자이기 때문에</p>
                                <p>예시 3번이 예시 1번을 이깁니다. </p>
                                <p>
                                    <img name="cafeuserimg" id="Img1" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(2797788)" src="images/45jk.gif" alt="45jk.gif">
                                </p>
                                <p></p>
                                <p></p>
                                <h3><span style="font-size: 11pt;">★ 베이스: 카드의 무늬와 숫자가 3장만 다른 경우</span></h3>
                                <p>네장의 카드 중에 두장의 무늬나 숫자가 같은 경우, 중복되는 무늬나 숫자의 카드 2장 중 높은 숫자의 카드를 빼고</p>
                                <p>나머지 3장을 베이스로 사용합니다. 이때, 뺀 카드는 베이스 끼리의 비교에서 완전히 제외시킵니다. </p>
                                <p><strong></strong></p>
                                <p>
                                    <strong>① ♠A, ◇4, ♡8, ♡Q</strong><br>
                                    같은 무늬가 두개이므로 중복되는 무늬를 가진 카드 중, 높은 숫자의 카드(♡Q)를 빼고 베이스가 성립됩니다.
                                </p>
                                <p>(A, 4, 8 베이스) </p>
                                <p>
                                    <img name="cafeuserimg" id="userImg9630976" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(9630976)" src="images/a48q.gif">
                                </p>
                                <p></p>
                                <p>
                                    <strong>② ♠4, ◇4, ♡8, ♣Q<br>
                                    </strong>같은 숫자가 두개 이므로 하나를 빼고(♠4 혹은 ◇4) 베이스가 성립됩니다.
                                </p>
                                <p>
                                    <img name="cafeuserimg" id="userImg9394798" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(9394798)" src="images/448q.gif">
                                </p>
                                <p></p>
                                <p>
                                    <strong>③ ♡3, ◇4, ♠4, ♠K<br>
                                    </strong>♠4가 ◇4와는 숫자가, ♠K와는 무늬가 중복됩니다. 다른 카드와 중복을 더 많이 가지고 있는 카드(♠4)를 빼고 나면
                                </p>
                                <p>♡3, ◇4, ♠K로 3, 4, K베이스가 됩니다.</p>
                                <p>
                                    <img name="cafeuserimg" id="userImg4763436" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(4763436)" src="images/344k.gif">
                                </p>
                                <p></p>
                                <p></p>
                                <h3><span style="font-size: 11pt;">★ 투베이스: 카드의 무늬와 숫자가 2장만 다른 경우</span></h3>
                                <p>네장의 카드 중 두장의 카드만 다른 무늬와 다른 숫자를 가질 경우 투베이스라고 합니다. 나머지 두장은 투베이스끼리의</p>
                                <p>비교에서 완전히 제외시킵니다. </p>
                                <p><strong></strong></p>
                                <p>
                                    <strong>① ♠A, ♡4, ♡8, ♡Q</strong><br>
                                    하트가 세장이므로 높은 숫자의 카드 두장을 제외시키고, ♠A, ♡4로 A, 4 투베이스가 됩니다
                                </p>
                                <p>
                                    <img name="cafeuserimg" id="userImg3557551" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(3557551)" src="images/a48q_2.gif">
                                </p>
                                <p></p>
                                <p>
                                    <strong>② ♡4, ◇4, ♠4, ♠K<br>
                                    </strong>4자 석장 중 무늬가 ♠K와 중복되는 ♠4를 포함한 두장을 제외시키고 4, K 투베이스가 됩니다.
                                </p>
                                <p>
                                    <img name="cafeuserimg" id="userImg2087874" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(2087874)" src="images/444k.gif">
                                </p>
                                <p></p>
                                <p>
                                    <strong>③ ◇4, ◇5, ♠4, ♠K</strong><br>
                                    ◇가 두장, ♠가 두장이므로 각각 한장씩을 제외시켜야 합니다. ♠K를 제외시키고, ♠4와 숫자가 중복되는 ◇4를 제외시켜서
                                </p>
                                <p>♠4,◇5로 4,5 투베이스가 됩니다 </p>
                                <p>
                                    <img name="cafeuserimg" id="Img2" style="width: 260px; height: 85px;" onclick="popview(this)" onload="resizeImage(2797788)" src="images/454k.gif" alt="454k.gif">
                                </p>
                                <p></p>
                                <p></p>
                                <p></p>
                                <p class="notice"><span style="font-size: 11pt;"><font color="#3a32c3"><span class="highlight">바둑이</span>에서는 무늬와 숫자가 다 다르고, 제일 높은 숫자가 낮을수록 좋은 패입니다.</font></span></p>
                                <p class="notice"><font color="#3a32c3"><span style="font-size: 11pt;"><span class="highlight">족보</span>의 순서는</span><strong><span style="font-size: 11pt;"> 메이드 &gt; 베이스 &gt; 투베이스</span></strong><span style="font-size: 11pt;"> 순입니다.</span></font></p>
                                <p class="notice"><span style="font-size: 11pt;"><font color="#3a32c3">같은 <span class="highlight">족보</span>가 나왔을 경우에는 가장 높은 숫자부터 비교해서 낮은 숫자를 가진 쪽이 이깁니다.</font></span></p>
                                <p class="notice"><span style="font-size: 11pt;"><font color="#3a32c3">같은 <span class="highlight">족보</span>에 숫자까지 같으면 무승부 처리하여 판돈을 나눠가지게 됩니다.</font></span></p>
                                <p class="notice"><span style="font-size: 11pt;"><font color="#3a32c3"></font></span></p>
                                <p class="notice"><span style="font-size: 11pt;"></span></p>
                            </span>
                        </div>
                    </div>
                    <div class="btn_div">
                        <input type="button" value="돌아가기" class="btn_style" onclick="javascrtpt: window.location.href = 'Main.aspx'" />
                    </div>
                </div>
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
