<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UtilizationLimitPolicy.aspx.cs" Inherits="Game.Web.UtilizationLimitPolicy" %>

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
                    이용제한정책
                </div>
                <div class="context">
                    <div id="txt">
                        <table border="0" width="699" cellspacing="0" cellpadding="10">
                            <tr>
                                <td align="left" style="padding: 15px 20px 15px 20px">
                                    <b><a name="agree01" id="agree01">제1조 총칙</a></b><br />
                                    <br />
                                    <p>
                                        메가드림즈㈜(이하 "회사")에서 운영하는 포털 게임 사이트 신게임(이하 "서비스")의 게임(고스톱/포커/캐쥬얼 등) 운영에 관한 기본적인 사항을 규정하는 것을 목적으로 합니다. 
				            신게임 전체 게임에 이용제한 정책이 적용되며, 각 게임 서비스 정책에 따라 운영 정책 및 이용제한 정책을 별도로 확인해야 합니다. 
				            올바른 게임 문화 정책과 불량 이용에 따른 회원 보호를 위해 실시되는 해당 정책 사항을 숙지하시어 신게임 게임 이용에 불편이 없으시길 바랍니다.
                                    </p>
                                    <p>
                                        <br />
                                        <b><a name="agree02" id="agree02">제2조 이용 제한 안내 및 제재 단계</a></b><br />
                                        <br />
                                        1. 이용 제한 안내: 이용 제한은 다음과 같은 제재 단계에 따라 적용되며, 안내해드린 제재 사항 이외에 운영진이 객관적으로 판단한 사항에 대해서는 경고 없이 서비스 이용이 제한 될 수 있습니다.
                                    </p>
                                    <p></p>
                                    <p>
                                        2. 이용 제한 제재 단계<br />
                                    </p>
                                    <p>1) 전체 게임 제재 단계</p>
                                    <table width="650" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
                                        <tr bgcolor="#f5f5f5">
                                            <td colspan="8" align="center" class="gray01_11 b" style="height: 30px;">서비스 이용제한은 홈페이지 및 게임을 포함되며, 6차 제제 이후 적발되는 경우 365일단위로 누적 적용됩니다.</td>
                                        </tr>
                                        <tr bgcolor="#f5f5f5">
                                            <td colspan="2" rowspan="2" align="center"><strong>위반항목 </strong></td>
                                            <td colspan="6" align="center" style="height: 40px;"><strong>제재 단계</strong></td>
                                        </tr>
                                        <tr bgcolor="#f5f5f5" style="height: 40px;">
                                            <td align="center"><strong>1차 </strong></td>
                                            <td align="center"><strong>2차 </strong></td>
                                            <td align="center"><strong>3차 </strong></td>
                                            <td align="center"><strong>4차 </strong></td>
                                            <td align="center"><strong>5차 </strong></td>
                                            <td align="center"><strong>6차 </strong></td>
                                        </tr>
                                        <tr>
                                            <td rowspan="3" bgcolor="#f5f5f5">
                                                <p align="center">
                                                    <strong>미풍양속 저해 </strong>
                                            </td>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">욕설 및 비방 </p>
                                            </td>
                                            <td rowspan="7" bgcolor="#FFFFFF">
                                                <p align="center">경고 </p>
                                            </td>
                                            <td rowspan="7" bgcolor="#FFFFFF">
                                                <p align="center">1일 </p>
                                            </td>
                                            <td rowspan="7" bgcolor="#FFFFFF">
                                                <p align="center">3일 </p>
                                            </td>
                                            <td rowspan="7" bgcolor="#FFFFFF">
                                                <p align="center">5일 </p>
                                            </td>
                                            <td rowspan="7" bgcolor="#FFFFFF">
                                                <p align="center">10일 </p>
                                            </td>
                                            <td rowspan="7" bgcolor="#FFFFFF">
                                                <p align="center">365일 </p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">지속적 괴롭힘</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">기타 불량이용</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="2" bgcolor="#f5f5f5">
                                                <p align="center">
                                                    <strong>게임이용 방해 </strong>
                                            </td>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">채팅 도배</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">상습적인 게임 지연, 고의 도주 행위 </p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="2" bgcolor="#f5f5f5">
                                                <p align="center">
                                                    <strong>운영서비스방해 </strong>
                                            </td>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">허위 신고, 중복신고</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">타 사이트 광고, 영리 목적의 홍보</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td rowspan="2" bgcolor="#f5f5f5">
                                                <p align="center">
                                                    <strong>이름 정책</strong>
                                            </td>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">부적절 아이디 또는 닉네임</p>
                                            </td>
                                            <td colspan="6" rowspan="2" bgcolor="#FFFFFF" style="padding: 0 10px 0 15px">
                                                <p>
                                                    <strong>1차:</strong> 임시이용 제한 후 변경조치<br />
                                                    <strong>2차:</strong> 365일 이용 정지
                                                </p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#FFFFFF">
                                                <p align="center">
                                                    비정상 이용, 회사에서 허용되지 않은 거래,<br />
                                                    홍보 등을 목적으로 생성된 아이디 또는 닉네임
                                                </p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" bgcolor="#f5f5f5">
                                                <p align="center"><strong>계정도용</strong> </p>
                                            </td>
                                            <td colspan="6" bgcolor="#FFFFFF">
                                                <p align="center">머니 회수 및 영구 이용 제한</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" bgcolor="#f5f5f5">
                                                <p align="center"><strong>이벤트 쿠폰 도용 및 판매</strong> </p>
                                            </td>
                                            <td colspan="6" bgcolor="#FFFFFF">
                                                <p align="center">머니 회수 및 영구 이용 제한</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" bgcolor="#f5f5f5">
                                                <p align="center"><strong>버그 플레이 및 회사에서 허용되지 않은 비정상적 프로그램 사용</strong> </p>
                                            </td>
                                            <td colspan="6" rowspan="4" bgcolor="#FFFFFF">
                                                <p align="center">365일 이용 정지</p>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" bgcolor="#f5f5f5">
                                                <p align="center">
                                                    <strong>현금거래 및 회사에서 허용되지 않은 거래</strong>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" bgcolor="#f5f5f5">
                                                <p align="center">
                                                    <strong>기타 운영 서비스 방해 (위의 동일한 항목 제외)</strong>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" bgcolor="#f5f5f5">
                                                <p align="center">
                                                    <strong>비정상 게임 진행 및 어뷰징</strong>
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    <p>2) 포커류 제재 단계</p>
                                    <table width="650" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
                                        <tr>
                                            <td align="center" width="20%" bgcolor="#f5f5f5"><strong>제한사유</strong></td>
                                            <td align="center" width="60%" bgcolor="#f5f5f5"><strong>상세내용</strong></td>
                                            <td align="center" width="20%" bgcolor="#f5f5f5"><strong>제한내용</strong></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#f5f5f5" align="center"><strong>비정상적인 포커류 게임 이용</strong></td>
                                            <td bgcolor="#FFFFFF">* 비정상적인 방법으로 게임을 진행하는 행위<br />
                                                * 최소 2명 이상이 접속지역에 관계없이 특정시간 함께 게임을 지속하며 승패에 영향을 줄 경우 (예: 짜고치기)<br />
                                                * 최소 2명 이상이 방을 옮겨 다니며 여러 아이디로 번갈아 게임을 하는 경우<br />
                                                * 최소 2명 이상이 정상적이지 않은 룰을 통해 게임을 지속하는 경우 (예: 삥콜 / 전적작업)<br />
                                                * 최소 2명 이상이 임의 베팅 룰에서 게임을 지속하는  경우<br />
                                                * 다른 이용자가 비정상적 게임진행을 통해 획득한 게임머니를 받거나 제공하는 행위
                                            </td>
                                            <td bgcolor="#FFFFFF">1년 고스톱/포커류 게임 이용제한<br />
                                                (동일정보 아이디 모두 제한)</td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#f5f5f5" align="center"><strong>머니매매/매매유도 행위</strong></td>
                                            <td bgcolor="#FFFFFF">게임머니 매매, 교환 목적의 게임이용 및 홍보 행위</td>
                                            <td bgcolor="#FFFFFF">1년 고스톱/포커류 게임 이용제한<br />
                                                (동일정보 아이디 모두 제한)</td>
                                        </tr>
                                    </table>
                                    <br />
                                    <p>3) 고스톱류 제재 단계</p>
                                    <table width="650" border="0" cellpadding="2" cellspacing="1" bgcolor="#CCCCCC">
                                        <tr>
                                            <td align="center" width="20%" bgcolor="#f5f5f5"><strong>제한사유</strong></td>
                                            <td align="center" width="60%" bgcolor="#f5f5f5"><strong>상세내용</strong></td>
                                            <td align="center" width="20%" bgcolor="#f5f5f5"><strong>제한내용</strong></td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#f5f5f5" align="center"><strong>비정상적인 고스톱류 게임 이용</strong></td>
                                            <td bgcolor="#FFFFFF">* 비정상적인 방법으로 게임을 진행하는 행위<br />
                                                * 다른 이용자가 비정상적 게임진행을 통해 획득한 게임머니를 받거나 제공하는 행위</td>
                                            <td bgcolor="#FFFFFF">1년 고스톱/포커류 게임 이용제한<br />
                                                (동일정보 아이디 모두 제한)</td>
                                        </tr>
                                        <tr>
                                            <td bgcolor="#f5f5f5" align="center"><strong>머니매매/매매유도 행위</strong></td>
                                            <td bgcolor="#FFFFFF">게임머니 매매, 교환 목적의 게임이용 및 홍보 행위</td>
                                            <td bgcolor="#FFFFFF">1년 고스톱/포커류 게임 이용제한<br />
                                                (동일정보 아이디 모두 제한)</td>
                                        </tr>
                                    </table>
                                    <br />
                                    <p align="left">
                                        <strong>※ 전체 게임 이용제한은 별도의 이용약관 및 정책이 적용되는 개별 서비스를 제외한 모든
				            서비스에 적용되며, 전체 게임 중 일부에서 제한사유에 해당하는 행위가 확인된 경우 모든
				            서비스에서 동일한 제한내용에 따라 이용이 제한됩니다. </strong>
                                        <br />
                                        <strong>※ 모든 위반항목에 대해서는 확인이 필요한 경우, 임시적으로 이용제한이 적용될 수 있습니다.</strong><br />
                                        <strong>※ 미풍양속 저해, 게임이용 방해, 운영서비스 방해의 처벌 기준은 중복되어 제재가 됩니다.</strong><br />
                                        (예 : 미풍양속 저해로 1차 처벌을 받은 상태에서 게임 이용 방해 처벌을 받는 경우 2차인 1일 정지가 됩니다.)<br />
                                        <strong>※ 이용제한 항목에 따라 게임머니가 회수될 수 있습니다.</strong>
                                        <p>3. 이용 제한 제재 상세 기준</p>
                                        <p>
                                            1) 미풍양속 저해: 예전부터 전해 내려오는 아름답고 좋은 전통(풍습, 관습)에 해를 끼치는 행위<br />
                                            - 욕설 및 음란성 등 불건전 단어를 사용하는 경우<br />
                                            - 인종, 특정인, 특정 단체를 비방하거나 인격을 비방하는 경우<br />
                                            - 다른 이용자를 희롱 또는 위협하거나, 특정 이용자에게 지속적으로 고통, 또는 불편을 주는 행위<br />
                                            - 상대방의 욕설에 맞대응 하여 쌍방욕설을 하는 행위<br />
                                            - 운영자 또는 회사, 회사 관계자에 대한 욕설<br />
                                            - 기타 상대방으로 하여금 불쾌감이나 피해를 줄 수 있다고 판단되는 경우<br />
                                            - 기타 관계 법령 또는 사회 통념(일반적으로  알려져 있는 건전한 상식, 견해)에 위반 된다고 판단되는 경우
                                        </p>
                                        <p>
                                            2) 게임 이용 방해<br />
                                            - 의미 없는 내용을 반복하여 불필요한 도배로 게임 이용을 방해하는 경우<br />
                                            - 고의적으로 장시간 게임 진행을 지연시키는 경우<br />
                                            - 고의 도주<br />
                                            ① 고스톱류 게임<br />
                                            * 게임 중 고의로 도주하는 경우<br />
                                            - 도주한 회원을 대신하여 AI가 대신 게임 플레이를 진행하게 됩니다.<br />
                                            * 다른 회원이 점수를 냈을 경우<br />
                                            - 도주한 회원은 난 점수만큼 고스톱 머니를 지불하게 됩니다.<br />
                                            * 도주한 회원 대신 게임을 하는 컴퓨터가 점수를 냈을 경우<br />
                                            - 컴퓨터 AI가 대신 플레이를 하며 게임이 끝난 후 결과도 반영 되므로 게임을 하지 않거나 다른 방에서 플레이를 하고 있을 때 바로 전에 접속이 끊긴 방에서 게임 결과가 반영 되어 고스톱 머니에 변동이 생길 수 있습니다. 단, 네트워크 사정으로 의도되지 않은 접속 끊김이 된 경우 그 판이 끝나기 전에 다시 게임을 실행할 수 없습니다.<br />
                                            ② 포커류 게임<br />
                                            - 게임 중 고의 도주한 경우, '다이' 한 것으로 처리합니다.<br />
                                            <p>
                                                3) 운영 서비스 방해<br />
                                                - 허위 내용을 신고하여 운영 서비스에 방해를 주는 경우<br />
                                                - 중복 내용을 지속적으로 신고하여 운영 서비스에 방해를 주는 경우<br />
                                                - 영리를 목적으로 하는 각종 광고나 음란 사이트, 전화번호 등의 홍보 행위
                                            </p>
                                            <p>
                                                4) 이름 정책<br />
                                                - 타인에게 불쾌감을 주거나 피해를 줄 수 있다고 판단되는 아이디 또는 닉네임<br />
                                                - 비정상 이용, 게임 머니, 아이템등의 거래, 홍보 등을 목적으로 생성된 아이디 또는 닉네임 (영구 이용 제한)
                                            </p>
                                            <p>
                                                5) 계정도용 (영구 이용 제한)<br />
                                                - 다른 회원의 개인정보를 해당 회원의 동의 없이 취득하는 경우<br />
                                                - 아이디를 도용하여 개인정보를 무단으로 변경하는 경우<br />
                                                - 다른 회원의 ID를 도용(또는 해킹)하여 비밀번호를 변경하거나 개인정보를 획득하여 이용하는 경우<br />
                                                - 다른 회원의 ID를 도용(또는 해킹)하여 타 회원의 아이디를 해지(회원탈퇴)하는 경우<br />
                                                - 다른 회원의 ID를 도용(또는 해킹)하여 그 회원의 게임 머니를 이용하는 경우<br />
                                                - 주민번호 생성기, 회사에서 허용하지 않는 비정상적 프로그램 등을 통해 불명의 아이디를 생성하는 경우<br />
                                                - 신용카드, 주민등록증 등을 통해서 타 회원의 개인정보를 취득하는 경우<br />
                                                - 타인의 개인정보(이름, 성별, 주민등록번호, 전화번호, 주소 등)을 무단으로 게시하는 경우<br />
                                                - 서비스 내에서 타인의 e-메일/핸드폰 번호/사진 등의 무단 도용 행위
                                            </p>
                                            <p>
                                                6) 이벤트 쿠폰 도용 (영구 이용 제한)<br />
                                                - 이벤트 쿠폰을 판매하거나 영리목적으로 거래하는 경우<br />
                                                - 이벤트 쿠폰을 도용해서 사용하는 경우
                                            </p>
                                            <p>
                                                7) 버그 플레이 및 회사에서 허용되지 않은 비정상적 프로그램 사용 (영구 이용 제한)<br />
                                                - 게임 내 버그를 악용하여 부당이득을 취득, 공유, 이용하는 경우<br />
                                                - 게임 내 버그 또는 회사에서 허용되지 않은 비정상적 프로그램을 무단으로 유포하는 경우<br />
                                                - 부적절한 방법으로 아바타, 아이템 사용 행위<br />
                                                - 회사에서 허용되지 않은 비정상적 프로그램을 이용하여 아이디를 다수 생성하는 행위<br />
                                                - 회사에서 허용되지 않은 비정상적 프로그램을 이용하여 다른 사용자에게 게임 머니 획득, 게임 진행의 피해를 주는 경우<br />
                                                - 회사의 클라이언트 프로그램을 변경하거나, 회사의 서버를 해킹 하거나, 웹사이트 또는 게시된 정보의<br />
                                                일부분 또는 전체를 임의로 변경, 회사의 서비스를 비정상적인 방법으로 사용하는 행위
                                            </p>
                                            <p>
                                                8) 현금거래 및 회사에서 허용되지 않은 거래<br />
                                                - 게임 머니를 상품권 혹은 현금으로 사고 파는 행위 및 기타 동일한 거래  의도가 있는 모든 행위<br />
                                                (회원간의 암묵적 거래 시 발생하는 사고에 대해서는 전적으로 회원 본인의 책임입니다.)<br />
                                                - 게임 대기실, 게임 방 내 채팅 창에 현금거래 광고를 하는 경우<br />
                                                - 게임 머니를 상품권 및 현금으로 팔거나 사고자 하는 경우<br />
                                                - 쪽지 또는 이메일을 통해 현금거래 행위를 유도하는 경우<br />
                                                - 현금거래 관련된 게임 방을 개설하여 현금거래를 하려는 경우<br />
                                                - 대화명(닉네임)에 현금거래 행위를 유도하는 단어를 이용하는 경우<br />
                                                - 핸드폰 번호 또는 유선 연락처를 아이디 생성 시 포함하여 이용하는 경우<br />
                                                - 아이템 거래 사이트 등을 통해서 불량 이용과 연관된 아이디가 확인된 경우<br />
                                                - 계정 도용 및 어뷰징된 게임 머니를 도우미 하는 경우
                                            </p>
                                            <p>
                                                9) 운영 서비스 방해<br />
                                                - 운영자 또는 회사 직원을 사칭하여 회원에게 개인정보를 요구하거나 서비스 이용에 피해를 주는 행위<br />
                                                - 불법 사이트 광고를 신게임 서비스 내 쪽지, 채팅 등을 동원하여 회원에게 홍보, 권유하는 행위<br />
                                                - 회사의 사전 승낙 없이 서비스를 이용하여 영업활동을 하는 행위
                                            </p>
                                            <p>
                                                10) 비정상 게임 진행 및 어뷰징<br />
                                                - 비정상적인 방법으로 게임 플레이 및 게임 머니를 축적하는 행위<br />
                                                - 조직적으로 다수의 사용자가 일정시간 이상 같이 플레이를 하여 승패를 조작하는 경우 (예: 짱구, 짜고치기 등)<br />
                                                - 정상적이지 않은 룰을 통해 게임을 하는 경우 (예: 삥콜 등)<br />
                                                - 다른 회원의 비정상적으로 습득한 게임 머니가 자신의 아이디에 유입된 경우 (예: 도용된 머니, 어뷰징 머니, 해킹 머니 등)<br />
                                                - 게임 초보 이용자의 리필 머니를 과도하게 모으는 행위 (예: 초기 지급 머니 등)<br />
                                                - 시스템 버그 및 홀을 이용하여 게임 머니를 취득하는 행위<br />
                                                - 기타 정당하지 못한 방법을 이용하여 게임을 하는 행위<br />
                                                - 불량 이용이 발생하는 특정 지역에서 접속하는 모든 아이디 및 연속된 시리즈 아이디
                                                <br />
                                                - 불량 이용이 발생하는 특정 아이피에서 접속하는 모든 아이디 및 연속된 시리즈 아이디
                                                <br />
                                                - 포커류에서 최소 2명 이상이 접속지역에 관계없이 특정시간 함께 게임을 지속하며 승패에 영향을 줄 경우 (예: 짜고치기)<br />
                                                - 포커류에서 최소 2명 이상이 방을 옮겨 다니며 여러 아이디로 번갈아 게임을 하는 경우<br />
                                                - 포커류에서 최소 2명 이상이 정상적이지 않은 룰을 통해 게임을 지속하는 경우 (예: 삥콜 / 전적작업)<br />
                                                - 포커류에서 최소 2명 이상이 임의 베팅 룰에서 게임을 지속하는 경우<br />
                                                - 고스톱류 및 포커류에서 다른 이용자가 비정상적 게임진행을 통해 획득한 게임머니를 받거나 제공하는 행위
                                            </p>
                                            <p>
                                                11) 기타 (영구 이용 제한)<br />
                                                - 사회에 물의를 빚는 행위나 범죄와 결부된다고 객관적으로 판단 될 경우<br />
                                                - 정보 통신망 이용 촉진 및 정보 보호  등에 관한 법률, 청소년 보호법 등 현행 관계 법률을 위반하는 경우<br />
                                                - 기타 관계 법령 또는 사회 통념(일반적으로  알려져 있는 건전한 상식, 견해)에 위반된다고 판단되는 행위
                                            </p>
                                            <p>
                                                <br />
                                                <b><a name="agree03" id="agree03">제3조 제재 처리 공통 사항</a></b><br />
                                                <br />
                                                1. 불량이용 행위의 종류 및 누적된 처벌 횟수에 따라, 아이디 이용 제한이 달라지게 됩니다.<br />
                                                2. 영구 이용 제한이 되었을 경우 동일 개인 정보로 재가입이 금지되며, 삭제된 아이디에 의하여 개설된 커뮤니티에<br />
                                                &nbsp;&nbsp;&nbsp;대해서는 시정 권고나 접근 금지 조치가 적용 될 수 있습니다.<br />
                                                3. 계정에 대한 관리 부족으로 계정 도용 피해가 발생한 경우 복구나 보상이 불가능합니다.<br />
                                                4. 불량이용자 제재로 인해 정지된 아이디의 잔여 이벤트쿠폰은 무료 이벤트 쿠폰임으로 별도 환불처리가 없습니다.<br />
                                                5. 이용자는 행위의 종류에 따라 서비스/게임 이용제한, 로그인 제한, 아이디 삭제 등의 이용제한 조치가 적용됩니다.
                                                <br />
                                                6. 회사는 고객센터 및 각종 기관에서 접수된 민원 내용, 경찰 수사 내용, 운영자의 모니터링을통해 정황을 확인한 후
                                                <br />
                                                &nbsp;&nbsp;&nbsp;제한사유 행위를 한 것으로 추정되는 이용자에 대하여 이용제한을 할수 있습니다.<br />
                                                7. 객관적인 증거가 불충분하거나, 해당 아이디가 이미 제한/삭제된 경우 처리되지 않습니다. 단, 조사를 통해 더 심각한<br />
                                                &nbsp;&nbsp;&nbsp;제한 사유에 해당하는 행위나 반복 상습적인 위반행위가 추가 발견되는 경우 이미 제한 중이더라도 가중 처리될 수<br />
                                                &nbsp;&nbsp;&nbsp;있습니다.<br />
                                                8. 제한사유에 구체적으로 해당되지 않는 사항이라 하더라도 불법행위에 해당하거나, 게임 운영 및 타 회원의 게임진행에<br />
                                                &nbsp;&nbsp;&nbsp;심각한 악영향을 미치는 경우는 서비스 이용이 제한될 수 있습니다.
                                                <br />
                                                9. 회사는 제한 사유에 해당하는 방법으로 생성, 획득한 게임자산을 회수할 수 있습니다.
                                                <br />
                                                10. 제한 사유에 해당하는 방법으로 생성된 게임머니, 경험치, 포인트, 아이템 등을 주고 받는 등 객관적으로 보아<br />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;불법행위 가담이 의심되는 이용자도 이용제한 대상이 될 수 있습니다.<br />
                                                11. 이용자의 행위 확인 후 이용제한이 진행되므로 행위 시점과 이용제한시점이 상이할 수 있습니다.<br />
                                                12. 이용제한기간 중 탈퇴 신청하는 경우 이용제한 기간 종료 시까지 게임/서비스 이용 혹은 회원가입이 제한됩니다.<br />
                                                13. 이용제한에 관하여는 위 개별 게임 제한 규정에 특별한 규정이 있는 경우를 제외하고는 본 공통 규정에서 정하는 바에<br />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;따릅니다.
                                                <br />
                                            </p>
                                            <p>
                                                <b><a name="agree07" id="agree07">부칙</a></b><br />
                                            </p>
                                            <p style="padding-left; margin-left: 15px">
                                                시행일 : 
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
