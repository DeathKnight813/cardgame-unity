<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UtilizationPolicy.aspx.cs" Inherits="Game.Web.UtilizationPolicy" %>

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
                    이용정책
                </div>
                <div class="context">
                    <div id="txt">
                        <table border="0" width="699" cellspacing="0" cellpadding="10">
                            <tr>
                                <td align="left"><b><a name="agree01" id="agree01">제1조 총칙</a></b><br />
                                    <br />
                                    <ol>
                                        <li>이 운영 정책은 메가드림즈㈜(이하 "회사")에서 운영하는 포털 게임 사이트 신게임(이하 "서비스")의 웹 보드 게임(고스톱/포커/캐쥬얼 등) 운영에 관한 기본적인 사항을 규정하는 것을 목적으로 합니다.</li>
                                        <li>테스트 기간에는 전반적인 서비스 사항에 대한 테스트 및 안정성을 목적으로 진행되기 때문에 게임 데이터의 초기화 및 데이터 변경이 수시로 진행될 수 있으며, 이로 인한 별도의 복구는 제공되지 않습니다.</li>
                                        <li>웹 보드 게임을 제외한 온라인 게임의 경우 해당 사이트의 운영 정책이 적용되며, 각 서비스 정책에 따라 운영 정책을 별도로 확인해야 합니다.</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree02" id="agree02">제2조 정책의 효력 및 변경</a></b><br />
                                    <br />
                                    <ol>
                                        <li>이 운영정책은 신게임 홈페이지(www.ssingame.com)(이하 "홈페이지")에 명시하고, 회원이 회원가입 시 약관에 "동의"를 함으로써 효력이 발생합니다.</li>
                                        <li>회사는 이 운영정책을 서비스 진행 사항에 따라 수시로 변경할 수 있으며, 변경된 운영정책은 적용일 전 15일간 홈페이지에서 지원하는 방법을 통해 고객에게 고지되고 적용 일에 효력이 발생합니다. 운영정책에 자세히 언급되어 있지 않으면서 특별히 중요하다고 판단되는 사안인 경우 홈페이지에서 지원하는 방법을 통해 고객에게 별도고지 할 수 있으며, 별도고지 된 내용은 그 즉시 효력이 발생합니다.</li>
                                        <li>고객은 변경된 운영정책에 대해 동의하지 않을 권리가 있으며, 이 경우 서비스 이용을 중단하고 서비스 이용계약을 해지 요청할 수 있습니다. 다만, 고객이 운영정책의 적용 일로부터 30일 이내에 회사에 대해 "거부"의 의사표시를 하지 아니하는 경우에는 운영정책에 동의한 것으로 간주합니다.</li>
                                        <li>운영정책 및 공지 미숙지로 인해 발생하는 불이익에 대해서는 도움을 드릴 수 없습니다.</li>
                                        <li>운영정책에 자세히 언급되지 않은 모든 사항에 대해서는 약관, 법률, 사회적 통념, 고객과 회사가 공유하는 게임 내 일반적인 규율을 적용해 사안을 판단하거나 조율할 수 있습니다.</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree03" id="agree03">제3조 용어의 정의</a></b><br />
                                    <br />
                                    <ol>
                                        <li>신게임(ssingame): 메가드림즈㈜에서 제공하는 온라인 포털 사이트로 웹 보드게임, 온라인 게임, 운세 등 다양한 컨텐츠를 제공합니다.</li>
                                        <li>게임 머니: 게임 머니는 고스톱 머니, 포커 머니 등이 있으며, 신게임(ssingame)의 게임 서비스 이용을 위한 도구입니다.</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree04" id="agree04">제4조 회사와 회원의 의무</a></b><br />
                                    <br />
                                    <ol>
                                        <li>회사의 의무<br />
                                            (1) 각 서비스를 이용하면서 생성 또는 취득하는 게임 머니는 현금이나 상품권과는 관계가 없으며, 해당 서비스에 한해서만 이용됩니다.<br />
                                            (2) 게임 머니에 대한 일체의 권리는 회사에 있습니다.
                                            <br />
                                            (3) 회사는 회원 간의 게임 머니 거래 및 양도 등 불법적인 거래는 인정하지 않습니다.<br />
                                            (4) 회사는 회원 개인의 인터넷 환경, 인터넷 끊김(또는 비정상 종료) 등 개인적인 컴퓨터 환경으로 인해 발생한 문제나 과실로 인해 게임 머니를 손실 할 경우 도움을 드리기 어렵습니다.<br />
                                            (5) 회사는 서비스 운영상 필요하다고 판단될 때 회원의 게임 머니 및 등급, 아이템 등을 수정할 수 있습니다.</li>
                                        <li>회원의 의무<br />
                                            (1) 회원은 본 정책에 규정하는 사항과 서비스 이용안내 또는 공지사항 등 회사가 공지 또는 통지하는 사항을 준수하여야 하며, 기타 회사의 업무에 방해되는 행위를 하여서는 안됩니다.<br />
                                            (2) 이용 약관, 이용제한정책, 이용 정책 등의 약관 및 정책, 규정 등을 위반하는 경우 이용제한정책 및 관계 법령에 따라 경고 없이 제재를 받을 수 있습니다.</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree05" id="agree05">제5조 서비스 이용 제한</a></b><br />
                                    <br />
                                    <ol>
                                        <li>회사는 회원이 다음 각 호의 사유에 해당하는 경우 사전통지 없이 회원의 서비스 이용제한 및 적법한 조치를 취할 수 있으며 모든 데이터 초기화 및 이용계약을 해지하거나 또는 기간을 정하여 서비스를 중지할 수 있습니다.<br />
                                            (1) 회원가입 신청 또는 변경 시 허위 내용을 등록한 경우<br />
                                            (2) 타인의 서비스 이용을 방해하거나 그 정보를 도용한 경우<br />
                                            (3) 회사의 운영진, 직원 또는 관계자를 사칭하는 경우<br />
                                            (4) 회사의 사전 승낙 없이 서비스를 이용하여 영업활동을 하는 경우<br />
                                            (5) 회원 ID를 타인과 거래하거나 회원 ID의 게임상 아이템, 게임머니 등을 타인과 매매하는 행위를 하는 경우<br />
                                            (6) 회사 프로그램상의 버그를 악용하거나 비정상적인 방법으로 이벤트쿠폰, 게임상 아이템, 게임머니 등을 취득하는 행위를 하는 경우<br />
                                            (7) 서비스를 통하여 얻은 정보를 회사의 사전 승낙 없이 서비스 이용 외의 목적으로 복제하거나 이를 출판 및 방송 등에 사용하거나, 제3자에게 제공하는 경우<br />
                                            (8) 회사 또는 제3자의 저작권 등 기타 지적재산권을 침해하는 내용을 전송, 게시, 전자우편 또는 기타의 방법으로 타인에게 유포하는 경우<br />
                                            (9) 공공질서 및 미풍양속에 위반되는 음란한 내용의 정보, 문장, 도형, 음향, 동영상을 전송, 게시, 전자우편 또는 기타의 방법으로 타인에게 유포하는 경우<br />
                                            (10) 심히 모욕적이거나 개인신상에 대한 내용이어서 타인의 명예나 프라이버시를 침해할 수 있는 내용을 전송, 게시, 전자우편 또는 기타의 방법으로 타인에게 유포하는 경우<br />
                                            (11) 서비스에 위해를 가하거나 고의로 방해한 경우<br />
                                            (12) 다른 회원을 희롱, 위협하거나 특정 이용자에게 지속적으로 고통, 불편을 주는 행위를 하는 경우<br />
                                            (13) 범죄와 관련이 있다고 객관적으로 판단되는 경우<br />
                                            (14) 회원 가입 후 연속하여 12개월 이상 신게임 홈페이지 log-in 기록이 없는 경우<br />
                                            (15) 본 서비스를 이용함에 있어 본 약관 및 기타 회사가 정한 정책 또는 운영규칙을 위반하는 경우<br />
                                            (16) 회사의 명예를 손상시키는 행위를 하는 경우<br />
                                            (17) 회사로부터 특별한 권리를 받지 않고 회사의 클라이언트 프로그램을 변경하거나, 회사의 서버를 해킹 하거나 웹사이트 또는 게시된 정보의 일부분 또는 전체를 임의로 변경하거나, 회사의 서비스를 비정상적인 방법으로 사용하는 경우<br />
                                            (18) 회사의 승인을 받지 않고 다른 사용자의 개인정보를 수집 또는 저장하는 경우<br />
                                            (19) 게임 대전 시 승부를 조작하는 경우<br />
                                            (20) 정보통신 윤리위원회 등 관련 공공 기관의 시정 요구가 있는 경우<br />
                                            (21) 미풍양속을 저해하는 비속한 ID 및 별명 사용<br />
                                            (22) 기타 정상적인 서비스 운영에 방해가 될 경우<br />
                                            (23) 기타 관계법령에 위반하는 행위를 하는 경우</li>
                                        <li>회원은 전항의 귀책사유로 인하여 회사나 다른 회원에게 입힌 손해를 배상할 책임이 있습니다.</li>
                                        <li>카드 게임의 경우 관련 법이 정하는 기준에 따라 연령 19세 미만 회원은 카드게임(고스톱류, 포커류 등)을 이용 할 수 없으며, 카드 게임과 관련된 길드, 기타 커뮤니티에 대한 활동도 불가능합니다.</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree06" id="agree06">제6조 홈페이지 및 게시물의 관리</a></b><br />
                                    <br />
                                    <ol>
                                        <li>회사는 회원이 게시 또는 전달하는 서비스 내의 모든 게시물이 다음의 각 항에 해당된다고 판단되는 경우 경고 없이 게시물이 삭제 될 수 있으며, 임시조치 및 이용계약을 해지, 기간을 정하여 서비스 이용을 중지할 수 있습니다.<br />
                                            (1) 다른 회원이나 타인을 비방할 목적으로 허위사실을 유포, 명예를 훼손하는 내용인 경우<br />
                                            (2) 미풍양속에 위반되는 내용인 경우<br />
                                            (3) 범죄적 행위에 관련된다고 인정되는 내용인 경우<br />
                                            (4) 회사의 저작권 혹은 제 3자의 저작권 등 기타 지적재산권을 침해하는 내용인 경우<br />
                                            (5) 청소년보호법에 위반되는 내용의 정보, 문장, 도형 등을 게시하거나 링크 하는 경우<br />
                                            (6) 청소년보호법에 위반되는 음란한 내용이거나 음란사이트를 링크 하는 경우<br />
                                            (7) 영리를 목적으로 하는 광고성 게시물일 경우<br />
                                            (8) 게시판의 성격에 부합하지 않는 게시물의 경우<br />
                                            (9) 중복적인 게시물을 계속적으로 게시하여 제 3자에게 불편을 준다고 판단되는 경우<br />
                                            (10) 스팸성 게시물인 경우<br />
                                            (11) 회원 ID 또는 게임머니 매매와 관련된 게시물의 경우<br />
                                            (12) 정상적인 서비스 운영을 방해하는 경우<br />
                                            (13) 서비스의 운영 또는 회사의 사정으로 서비스를 중단할 경우<br />
                                            (14) 회사 관계자 및 연관된 이름에 관련하여 사칭의 오해가 있는 경우<br />
                                            (15) 인종, 종교, 민족, 성적인 차별에 관한 사항이 포함된 경우<br />
                                            (16) 반 사회적이거나 현행법상 사용할 수 없는 내용인 경우<br />
                                            (17) 불법복제 또는 해킹, 어뷰징 등을 조장하는 내용인 경우<br />
                                            (18) 위의 내용 외에 보편적으로 타인에게 불편함을 줄 수 있다고 판단되는 모든 경우<br />
                                            (19) 기타 관계 법령에 위배된다고 판단되는 경우</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree07" id="agree07">제7조 아바타, 아이템서비스 및 장애 보상</a></b><br />
                                    <br />
                                    <ol>
                                        <li>아바타, 아이템서비스<br />
                                            (1) 모든 캐릭터(아바타) 및 아이템의 사용 유효기간은 365일(1년)입니다. 기간 경과 후에는 소멸 및 이용권을 제한할 수 있습니다. 다만, 회사가 별도로 사용 유효기간을 정한 캐릭터(아바타)는 제외합니다.<br />
                                            (2) 기타 게임 머니를 지급하는 서비스를 통하여 사용할 수 있는 아이템의 보유 기간은 각 서비스 업체의 기준에 따르며, 서비스에 따라 기간 경과 후에는 사용권을 상실할 수도 있습니다.</li>
                                        <li>장애 보상<br />
                                            장애로 인해 게임 이용에 손해를 본 사용자에게는 소비자 피해보상 규정에 근거하여 보상을 해드리며, 장애 시간에 따라 게임 머니 등의 추가 보상이 지급 될 수 있습니다. 단, 임시 점검 등의 부득이하게 발생되는 점검에 대해서는 보상에서 제외가 됩니다.</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree08" id="agree08">제8조 회원의 계정 관리</a></b><br />
                                    <br />
                                    <ol>
                                        <li>회원의 계정 및 비밀번호 관리<br />
                                            모든 서비스를 이용하는 고객의 계정관리 책임은 고객 본인에게 있으며, 관리 소홀이나 부주의로 인한 피해에 대해서는 도움을 드릴 수 없습니다.</li>
                                        <li>계정 관리<br />
                                            회원이 신게임 홈페이지 (www.ssingame.com)에 12개월간 로그인 하지 않을 경우 회사는 회원의 게임 전적 및 게임 머니 등 개인의 게임 관련 정보를 초기화 할 수 있습니다.</li>
                                        <li>게임 전적 관리<br />
                                            회사는 회원의 게임 플레이와 관련된 정보는 7일까지 보관하고 있습니다. 따라서 해당 게임의 종료 이후 7일이 지나 발생한 문제에 대해서는 도움을 드리기 어렵습니다.</li>
                                    </ol>
                                    <br />
                                    <b><a name="agree09" id="agree09">제9조 서비스 장애</a></b><br />
                                    <br />
                                    <ol>
                                        <li>기술상 오류에 의한 서비스 장애<br />
                                            (1) 특정 서버 및 특정 기능에 이상이 발생하거나 게임진행에 방해가 된다고 판단되는 경우 해당 서버 및 기능의 전부 또는 일부를 제한하거나 중지할 수 있습니다.<br />
                                            (2) 기술상 오류에 의한 서비스 장애가 발생하면 그 사유 및 기간 등을 고객에게 사전 또는 사후에 고지합니다.<br />
                                            (3) 기술상 오류에 의한 서비스 장애로 인해 아이템 또는 캐릭터가 소실되거나 정보가 변경된 경우 게임기록이 확인 가능한 범위 내에서 게임밸런스에 무리를 주지 않는 정보를 복구 조치합니다.</li>
                                        <li>외부에 의한 서비스 장애<br />
                                            (1) 회사는 천재지변이나 국가 비상사태, 정전 또는 서비스 이용의 폭주 등으로 인하여 정상적인 서비스를 제공 할 수 없을 경우 서비스의 전부 또는 일부를 제한하거나 중지할 수 있습니다.<br />
                                            (2) 외부에 의한 서비스 장애가 발생하면 사유 및 기간 등을 고객에게 사전 또는 사후에 고지합니다.<br />
                                            (3) 외부에 의한 서비스 장애로 인해 고객 또는 다른 3자가 입은 손해가 발생할 경우 회사는 그에 대한 책임을 지지 않습니다.</li>
                                        <li>서비스 장애로 처리되지 않는 사항<br />
                                            (1) 고객의 과실이나 운영정책 및 이용약관에 명시된 내용, 홈페이지에서 지원하는 방법을 통한 고지 내용 또는 게임 내에서 지원하는 방법을 통한 고지 내용 등을 숙지하지 못해 손해가 발생할 경우 회사는 그에 대한 책임을 지지 않습니다.<br />
                                            (2) 회사는 게임의 기획이나 운영상 필요하다고 판단될 경우 게임 내용을 추가, 수정 또는 삭제할 수 있으며 이로 인해 고객에게 손해가 발생할 경우 회사는 그에 대한 책임을 지지 않습니다.</li>
                                    </ol>
                                    <p>
                                        <b><a name="agree07" id="a1">부칙</a></b><br />
                                    </p>
                                    <p style="padding-left; margin-left: 15px">
                                        제1조 시행일<br />
                                        본 약관은 2011년 11월 20일부터 시행합니다.
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td height="20"></td>
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
