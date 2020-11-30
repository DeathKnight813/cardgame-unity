<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YouthProtecPolicy.aspx.cs" Inherits="Game.Web.YouthProtecPolicy" %>

<%@ Import Namespace="Game.Facade" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link type="text/css" rel="stylesheet" href="css/index_style.css" />
    <link type="text/css" rel="stylesheet" href="css/notice.css" />
    <style type="text/css">
        #txt {
            height: 530px;
            overflow: auto;
            color: #306;
        }

        .red02_12 {
            color: #eb1900;
            font-family: verdana,Dotum,applegothic;
            font-size: 12px;
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
            <div id="main">
                <div class="title">
                    청소년보호정책
                </div>
                <div class="context">
                    <div id="txt">
                        <table border="0" width="699" cellspacing="0" cellpadding="0">
                            <tr>
                                <td align="left">메가드림즈㈜ (이하 "회사")는 각종 청소년 유해정보로부터 청소년을 보호하고자 관계법령에 따라 만19세 미만의 청소년들이 유해정보에 접근할 수 없도록 청소년보호정책을 수립하여 시행하고 있습니다. 또한 회사는 청소년의 건전한 성장을 저해하는 음란, 불법 등의 유해정보와 비윤리적, 반사회적 행위에 대해서는 엄격하게 제재하기 위하여 다음과 같이 활동하고 있습니다.</p>
						<ol style="padding-top: 10px;">
                            <li>청소년유해정보로부터의 청소년보호계획의 수립</li>
                            <li>청소년유해정보에 대한 청소년 접근제한 및 관리조치</li>
                            <li>정보통신업무 종사자에 대한 청소년유해정보로부터의 청소년보호를 위한 교육</li>
                            <li>청소년유해정보로 인한 피해상담 및 고충처리</li>
                            <li>그 밖에 청소년유해정보로부터 청소년을 보호하기 위하여 필요한 사항</li>
                        </ol>
                                    <p style="padding-top: 20px;">회사는 청소년들이 인터넷을 이용함에 있어, 밝고 건전한 환경을 조성하고, 올바른 인터넷 이용을 선도하며 청소년이 나와 타인을 존중할 수 있는 인격체로의 성장할 수 있도록 돕기 위해 "청소년보호를 위한 인터넷기업 윤리강령"과 "실천지침"을 준수합니다.</p>
                                    <br>
                                    <b><a name="agree01" id="agree01" class="red02_12">1. 청소년보호를 위한 인터넷기업 윤리강령</a></b><br />
                                    <ol>
                                        <li>청소년보호정책의 추진<br />
                                            <p>회사는 청소년이 미래를 책임지고 발전시켜 나갈 소중한 보호 대상임을 인식하며, 청소년보호와 관련된 제 규정을 준수 하고 적극적인 청소년 보호정책을 통해 청소년이 인터넷을 올바로 활용할 수 있는 능력을 갖추어, 가정, 학교, 사회, 국가, 인류 공동체의 성원으로서 타인의 삶을 존중할 수 있는 인격적 성장을 위한 환경제공에 앞장선다.</p>
                                        </li>
                                        <li>건전한 인터넷환경 제공 책임<br />
                                            <p>회사는 청소년이 인터넷을 통하여 음란, 언어폭력 등 유해한 환경에 노출되지 않도록 최대한 노력하고, 건전한 인터넷 사용 환경을 조성하는데 지속적인 개선방안을 마련한다. </p>
                                        </li>
                                        <li>사회적 협력 강화<br />
                                            <p>회사는 청소년이 성, 나이, 학력 등의 사유로 인해 서비스를 차별 받지 않도록 하여 정보접근에 대한 기회균등을 보장하려는 사회적 노력을 지지하며, 청소년의 가족 및 청소년보호단체와 협력하여 청소년 자신이 스스로 유해한 환경에 대하여 적절히 판단할 수 있는 능력을 키울 수 있도록 지원한다.</p>
                                        </li>
                                        <li>개인정보보호<br />
                                            <p>회사는 청소년의 개인정보를 소중하게 생각하고 이를 철저하게 보호하여, 인격체로서 그들의 권리가 보호되고 존중될 수 있도록 노력한다.</p>
                                        </li>
                                    </ol>
                                    <br />
                                    <b><a name="agree01" id="agree02" class="red02_12">청소년보호를 위한 인터넷기업 실천지침</a></b><br />
                                    <ol>
                                        <li>회사는 청소년을 보호하기 위하여 인터넷 역기능 방지 캠페인 및 사회공헌 활동을 적극적으로 전개한다.</li>
                                        <li>회사는 청소년에게 권장할 사이트 및 컨텐츠를 적극적으로 홍보하며, 청소년을 보호하기 위한 지원서비스 (ex. 청소년전화 1388 등)를 발굴하여 알린다.</li>
                                        <li>회사는 불법행위(사이버폭력, 저작권침해, 명예훼손, 명의도용 등) 및 유해환경에 대한 청소년 계도 활동을 통해 사이버 피해 예방활동에 참여한다.</li>
                                        <li>회사는 국가청소년위원회 등 정부기관 및 관련단체와 청소년보호를 위한 유기적인 협력체계를 고착한다.</li>
                                        <li>회사는 청소년의 회원가입에 따른 법정대리인 동의절차를 준수하고, 청소년 결제상한제 등을 도입하여 청소년의 건전한 인터넷 이용을 도모한다.</li>
                                        <li>회사는 불법/유해정보 유통방지를 위한 모니터링 체계를 강화하고, 공조체계를 구축한다.</li>
                                        <li>회사는 청소년의 개인정보 침해 등 피해 방지를 위한 정보보안활동을 강화하고, 사내 개인정보 취급자 등에 대한 교육활동을 실시한다.</li>
                                        <li>회사는 청소년보호 담당자에 대하여 주기적으로 청소년 유해환경 피해예방교육을 실시한다.</li>
                                        <li>회사는 건전한 인터넷 문화 조성을 위해 정부기관과 함께 청소년 및 학부모 대상 참여프로그램을 개발하고 실시한다.</li>
                                        <li>회사는 위에서 정한 실천지침을 따르고, 정기적으로 추진결과 및 성과를 평가하여 지침이 적극적으로 실천되도록 노력한다.</li>
                                    </ol>
                                    <p style="padding-top: 20px;">회사는 청소년보호를 위해 인터넷기업 및 청소년보호책임자협의회 등과 함께 공동으로 노력하고 있으며, 유해정보로 인한 피해상담 및 고충처리, 청소년보호에 대한 의견 수렴과 불만처리를 위하여 창구를 제공합니다.</p>
                                    청소년 보호 책임자<br>
                                    이름 : 이상국<br>
                                    직위 : 대표이사<br>
                                    전화 : 1588-3481<br>
                                    전자우편 : megadreams77@gmail.com<br>
                                </td>
                            </tr>
                        </table>
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
