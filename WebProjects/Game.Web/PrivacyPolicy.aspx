<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrivacyPolicy.aspx.cs" Inherits="Game.Web.PrivacyPolicy" %>

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
                    개인정보 취급방침
                </div>
                <div class="context">
                    <div id="txt">
                        <table border="0" width="699" cellspacing="0" cellpadding="0">
                            <tr>
                                <td align="left">메가드림즈㈜(이하 "회사")는 회원의 개인정보를 중요시하며, '정보통신망 이용촉진 및 정보보호 등에 관한 법률' 및 개인정보보호법 등 회사가 준수하여야 할 관련 법령상의 개인정보보호 규정을 준수하고 있습니다.<br />
                                    회사는 개인정보취급(처리)방침을 통하여 회원이 제공하는 개인정보가 어떠한 용도와 방식으로 이용되고 있으며, 개인정보보호를 위해 어떠한 조치가 취해지고 있는지 알려드립니다.<br />
                                    회사는 개인정보취급(처리)방침을 개정하는 경우 웹사이트 공지사항(또는 개별공지)을 통하여 공지할 것입니다. 
                                </td>
                            </tr>
                            <tr>
                                <td style="padding-top: 20px" align="left">
                                    <b><a name="agree01">제1조 수집하는 개인정보의 항목 및 수집방법</a></b>
                                    <ol>
                                        <li>수집항목<br />
                                            회사는 회원가입, 상담, 서비스 신청 및 이용 등을 위해 아래와 같은 개인정보를 수집하고 있습니다.<br />
                                            <span class="red02_12">1) 회원가입 및 본인인증 시 수집하는 개인정보</span><br />
                                            - 수집항목 : 이름, 아이디, 비밀번호, 이메일, 연락처, 생년월일, 성별, 중복가입정보(DI), 연계정보(CI), 아이핀 회원은 아이핀 번호<br />
                                            - 본인인증 여부에 따라 수집하는 정보 : 본인인증 수단<br />
                                            <span class="red02_12">2) 이벤트 및 각종 프로모션 진행 시 선택적으로 입력하여 수집하는 개인정보</span><br />
                                            - 주소, 전화번호, 휴대폰번호<br />
                                            <span class="red02_12">3) 서비스 이용과정에서 아래와 같은 정보가 생성되어 수집될 수 있습니다.</span><br />
                                            - IP Address, 쿠키, 방문 일시, 서비스 이용 기록, 불량 이용 기록, 이벤트 쿠폰등록 기록
                                        </li>
                                        <li>개인정보 수집방법<br />
                                            홈페이지 회원가입, 서비스 이용, 서면양식, 회원정보 수정, 전화, 팩스, 고객센터 1:1문의, 이벤트 응모, 배송 요청, 생성정보 수집 툴을 통한 수집
                                        </li>
                                    </ol>
                                    <b><a name="agree02">제2조 개인정보의 수집 및 이용목적</a></b>
                                    <p style="padding-left: 40px;" class="red02_12">회사는 수집한 개인정보를 다음의 목적을 위해 활용합니다.</p>
                                    <ol>
                                        <li><span class="red02_12">서비스 제공에 관한 계약 이행 및 서비스 제공에 따른 요금정산</span><br />
                                            콘텐츠 제공, 물품배송 또는 청구서 등 발송, 본인 인증, 요금 추심
                                        </li>
                                        <li><span class="red02_12">회원 관리</span><br />
                                            회원제 서비스 이용에 따른 본인확인, 개인 식별, 불량회원의 부정 이용 방지와 비인가 사용 방지, 가입의사 확인, 연령확인, 불만처리 등 민원처리, 분쟁 조정을 위한 기록보존, 고지사항 전달
                                        </li>
                                        <li><span class="red02_12">마케팅 및 광고에 활용</span><br />
                                            신규 서비스(제품) 개발 및 특화, 이벤트 등 광고성 정보 전달, 인구통계학적 특성에 따른 서비스 제공 및 광고 게재, 접속 빈도 파악 또는 회원의 서비스 이용에 대한 통계
                                        </li>
                                    </ol>
                                    <!-- #3 -->
                                    <b><a name="agree03">제3조 개인정보의 보유 및 이용기간</a></b>
                                    <p style="padding-left: 40px">
                                        회원의 동의 하에 수집된 개인정보는 회원 자격이 유지되는 동안 보유 및 이용되며, 해지를 요청한 경우에는 재생할 수 없는 방법에 의하여 디스크에서 완전히 삭제하며 추후 열람이나 이용이 불가능한 상태로 처리됩니다.
                                        <br />
                                        단, 회사는 개인정보 도용 등으로 인한 원치 않는 회원탈퇴 등에 대비하기 위하여 회원탈퇴 요청 후, 7일간 개인정보를 보유합니다. ID는 타 서비스와의 연계로 인해 30일간 보유하고 이후에는 재생할 수 없는 방법으로 완전히 삭제합니다.
                                        <br />
                                        또한 아래의 각호에 해당되는 경우는 예외로 합니다.
                                    </p>
                                    <ol>
                                        <li>회사 내부 방침에 의한 정보보유 사유
                                            <br />
                                            부정이용기록<br />
                                            - 보존 이유 : 부정 이용 방지<br />
                                            - 보존 기간 : 1년<br />
                                            <br />
                                            과몰입 이용기록
                                            <br />
                                            - 보존 이유 : 과몰입 이용 방지
                                            <br />
                                            - 보존 기간 : 1년</li>
                                        <li style="padding-top: 15px">관련법령에 의한 정보보유 사유
                                            <br />
                                            <span>상법, 전자상거래 등에서의 소비자보호에 관한 법률 등 관계법령의 규정에 의하여 보존할 필요가 있는 경우 회사는 관계법령에서 정한 일정한 기간 동안 회원정보를 보관합니다.  이 경우 회사는 보관하는 정보를 그 보관의 목적으로만 이용하며 보존기간은 아래와 같습니다.</span><br />
                                            <span style="padding-top: 10px; display: inline-block">웹사이트 방문기록<br />
                                                - 보존 이유 : 통신비밀보호법<br />
                                                - 보존 기간 : 3개월 </span>
                                            <br />
                                            <span style="padding-top: 10px; display: inline-block">소비자의 불만 또는 분쟁처리에 관한 기록
                                                <br />
                                                - 보존 이유 : 전자상거래 등에서의 소비자보호에 관한 법률<br />
                                                - 보존 기간 : 3년</span><br />
                                            <span style="padding-top: 10px; display: inline-block">계약 또는 청약철회 등에 관한 기록
                                                <br />
                                                - 보존 이유 : 전자상거래 등에서의 소비자보호에 관한 법률<br />
                                                - 보존 기간 : 5년</span><br />
                                            <span style="padding-top: 10px; display: inline-block">대금결제 및 재화 등의 공급에 관한 기록
                                                <br />
                                                - 보존 이유 : 전자상거래 등에서의 소비자보호에 관한 법률<br />
                                                - 보존 기간 : 5년</span></li>
                                        <li style="padding-top: 15px">개별적으로 회원의 동의를 받은 경우</li>
                                    </ol>
                                    <b><a name="agree04">제4조 개인정보의 파기절차 및 방법</a></b>
                                    <p style="padding-left: 40px">회사는 원칙적으로 개인정보 수집 및 이용목적이 달성된 후에는 해당 정보를 지체없이 파기합니다. 파기절차 및 방법은 다음과 같습니다.</p>
                                    <ol>
                                        <li>파기절차
                                            <br />
                                            회원이 회원가입 등을 위해 입력한 정보는 목적이 달성된 후 내부 방침 및 기타 관련 법령에 의한 정보보호 사유에 따라 '제3조 개인정보의 보유기간 및 이용기간'의 일정 기간 저장된 후 파기됩니다. 개인정보는 법률에 의한 경우가 아니고서는 보유되는 이외의 다른 목적으로 이용되지 않습니다.
                                        </li>
                                        <li style="padding-top: 15px">파기방법
                                            <br />
                                            전자적 파일형태로 저장된 개인정보는 기록을 재생할 수 없는 기술적 방법을 사용하여 삭제합니다.<br />
                                            종이에 출력된 개인정보는 분쇄기로 분쇄하거나 소각을 통하여 파기합니다.
                                        </li>
                                    </ol>
                                    <b><a name="agree05">제5조 개인정보의 제공</a></b>
                                    <ol>
                                        <li>회사는 회원의 개인정보를 '제2조 개인정보의 수집 및 이용목적'에서 고지한 범위 내에서 사용하며, 원칙적으로 외부에 제공하지 않습니다.</li>
                                        <li>다음과 같은 경우에는 예외적으로 개인정보 공유 및 제공을 할 수 있습니다.<br />
                                            <span class="red02_12">- 회원이 사전에 공개에 동의하는 경우</span><br />
                                            - 홈페이지에 게시한 서비스 이용약관이나 정책 등을 위반한 경우<br />
                                            - 회사가 진행하는 이벤트에 당첨되었을 경우 경품의 원활한 배송을 위하여 당첨자 이름/연락처/주소를 경품 배송업무 대행 업체 및 배송업체에 제공하는 경우<br />
                                            - 통계작성, 학술연구나 시장조사를 위하여 특정 개인을 식별할 수 없는 형태로 광고주, 협력사나 연구단체 등에 제공하는 경우<br />
                                            - 관계법령에 의하여 수사상의 목적으로 정부기관으로부터의 요구가 있을 경우<br />
                                            - 회사는 회원별 맞춤 서비스, 기타 다양한 서비스 제공 등의 사업적인 이유로 회원의 개인정보를 파트너 업체에 제공하거나 또는 공유하는 경우(그러나 개인정보를 제공, 정보를 공유할 경우에는 정보 제공 이전에 제휴사명, 제휴 목적, 제공 또는 공유되는 개인정보의 범위, 그리고 언제까지 어떻게 보호, 관리되는지에 대해 고지하여 동의를 구하는 절차를 거치게 되며, 회원이 동의하지 않는 경우에는 제휴사에게 제공, 공유하지 않습니다.)
                                        </li>
                                        <li>회사가 게임 서비스의 제공, 판매 권리를 정당한 절차에 의해 양도 또는 양수할 경우 이로 인한 개인정보의 양도는 별도의 동의절차를 마련하여 진행합니다.</li>
                                    </ol>
                                    <b><a name="agree06">제6조 개인정보의 취급위탁</a></b>
                                    <p style="padding-left: 40px;" class="red02_12">
                                        회사는 서비스 향상을 위해서 아래와 같이 개인정보를 위탁하고 있으며, 관계 법령에 따라 위탁계약 시 개인정보가 안전하게 관리될 수 있도록 필요한 사항을 규정하고 있습니다.
                                        <br />
                                        회사의 개인정보 위탁처리 기관 및 위탁업무 내용은 아래와 같습니다.
                                    </p>
                                    <table cellpadding="2" cellspacing="1" bgcolor="#CCCCCC" style="width: 655px; margin-left: 40px; margin-bottom: 30px">
                                        <tr>
                                            <th style="font-size: 11px; text-align: center; background: #e1e1e1" width="135" height="30">수탁자</th>
                                            <th style="font-size: 11px; text-align: center; background: #e1e1e1" width="250">위탁업무 내용</th>
                                            <th style="font-size: 11px; text-align: center; background: #e1e1e1">개인정보 보유 및 이용기간</th>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; text-align: center; background: #ffffff">서울 신용평가정보</td>
                                            <td style="font-size: 11px; text-align: center; background: #ffffff">회원 가입 시 실명 확인 대행</td>
                                            <td style="font-size: 11px; text-align: center; background: #ffffff" rowspan="2" height="70">해당 업체에서 이미 보유하고 있는 개인정보이기<br />
                                                때문에 별도로 저장하지 않음</td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; text-align: center; background: #ffffff">가입한 이동통신사</td>
                                            <td style="font-size: 11px; text-align: center; background: #ffffff">회원 가입 시 본인 인증</td>
                                        </tr>
                                    </table>
                                    <b><a name="agree07">제7조 회원의 권리와 그 행사방법</a></b>
                                    <ol>
                                        <li class="red02_12">회원은 언제든지 등록되어 있는 자신의 개인정보를 조회하거나 수정할 수 있으며, 가입해지를 요청할 수도 있습니다. </li>
                                        <li class="red02_12">회원의 개인정보 조회/수정을 위해서는 '개인정보 변경'(또는 '회원정보 수정' 등)을 가입해지(동의철회)를 위해서는 '회원탈퇴 신청'을 클릭하여 본인 확인 절차를 거치신 후 직접 열람, 정정 또는 탈퇴가 가능합니다.
					            혹은 개인정보보호(관리)책임자에게 서면, 전화 또는 이메일로 연락하시면 지체 없이 조치하겠습니다.</li>
                                        <li>회원이 개인정보의 오류에 대한 정정을 요청하신 경우에는 정정을 완료하기 전까지 당해 개인정보를 이용 또는 제공하지 않습니다.
					            또한 잘못된 개인정보를 제3자에게 이미 제공한 경우에는 정정 처리결과를 제3자에게 지체 없이 통지하여 정정이 이루어지도록 하겠습니다. </li>
                                        <li>회사는 회원 혹은 법정 대리인의 요청에 의해 해지 또는 삭제된 개인정보는 '제3조 개인정보의 보유 및 이용기간'에 명시된 바에 따라 처리하고 그 외의 용도로 열람 또는 이용할 수 없도록 처리하고 있습니다.</li>
                                    </ol>
                                    <b><a name="agree08">제8조 인터넷 접속정보파일 등 개인정보를 자동으로 수집하는 장치의 설치,운영 및 그 거부에 관한 사항</a></b>
                                    <p style="padding-left: 40px">회사는 이용자의 정보를 수시로 저장하고 찾아내는 '쿠키(cookie)' 등을 운용합니다. 쿠키란 회사의 웹사이트를 운영하는데 이용되는 서버가 이용자의 브라우저에 보내는 아주 작은 텍스트 파일로서 이용자의 컴퓨터 하드디스크에 저장됩니다. 회사는 다음과 같은 목적을 위해 쿠키를 사용합니다.</p>
                                    <ol>
                                        <li>쿠키 등 사용 목적<br />
                                            회원과 비회원의 접속 빈도나 방문 시간 등을 분석, 이용자의 취향과 관심분야를 파악 및 자취 추적, 각종 이벤트 참여 정도 및 방문 회수 파악 등을 통한 타겟 마케팅 및 개인 맞춤 서비스 제공</li>
                                        <li>쿠키 설정 거부 방법<br />
                                            이용자는 쿠키 설치에 대한 선택권을 가지고 있습니다. 따라서, 이용자는 웹브라우저에서 옵션을 설정함으로써 모든 쿠키를 허용하거나, 쿠키가 저장될 때마다 확인을 거치거나, 아니면 모든 쿠키의 저장을 거부할 수도 있습니다.<br />
                                            &nbsp;<br />
                                            예: 쿠키 설정을 거부하는 방법으로는 이용자가 사용하는 웹 브라우저의 옵션을 선택함으로써 모든 쿠키를 허용하거나 쿠키를 저장할 때마다 확인을 거치거나, 모든 쿠키의 저장을 거부할 수 있습니다.<br />
                                            &nbsp;<br />
                                            - 쿠키 설치 허용 여부를 지정하는 방법(Internet Explorer의 경우)<br />
                                            ① [도구] 메뉴에서 [인터넷 옵션]을 선택합니다.<br />
                                            ② [개인정보 탭]을 클릭합니다.<br />
                                            ③ [개인정보취급 수준]을 설정하시면 됩니다.<br />
                                            단, 이용자가 쿠키 설치를 거부하였을 경우 서비스 제공에 어려움이 있을 수 있습니다.</li>
                                    </ol>
                                    <b><a name="agree09">제9조 개인정보의 안전성 확보 조치에 관한 사항</a></b>
                                    <p style="padding-left: 40px">회사는 회원의 개인정보를 취급함에 있어 개인정보가 분실, 도난, 누출, 변조 또는 훼손되지 않도록 안전성 확보를 위하여 다음과 같은 기술적, 관리적 대책을 강구하고 있습니다.</p>
                                    <ol>
                                        <li>기술적 대책<br />
                                            - 회원의 비밀번호는 암호와 처리되어 운영자도 회원 개개인의 비밀번호를 알 수 없도록 되어 있습니다.<br />
                                            - 허용되지 않은 IP에 대한 접근 권한을 두어 회사 내부 네트워크가 아닌 경우 회사의 서버로 접근이 불가능하게 되어 있습니다. 또한 허용되지 않은 포트에 대한 접근 금지 등 시스템 보안에 최선을 다하고 있습니다.<br />
                                            - 회사는 W3C(World Web Consortium)에서 표준으로 정한 P3P를 통하여 개인정보보호정책을 회원의 브라우저를 통해 알려주고 있습니다. 회원은 회사의 이용약관을 P3P 소프트웨어(인터넷 익스플로러)를 통하여 확인하고 손쉽게 정보제공 수준을 결정할 수 있습니다(인터넷 익스플로러 6.0 이상에서 지원).
                                        </li>
                                        <li>관리적 대책<br />
                                            - 개인정보관리책임자와 최소한 인원으로 구성된 별도의 부서를 마련하여 개인정보에 대한 접근권한을 제한하고 있습니다.<br />
                                            - 개인정보를 취급하는 직원을 대상으로 새로운 보안 기술 습득 및 개인정보보호 의무 등에 관해 정기적인 사내교육 및 외부 위탁교육을 실시하고 있습니다.<br />
                                            - 개인정보 관련 취급자의 업무인수인계는 보안이 유지된 상태에서 철저하게 이루어지고 있으며, 입사 및 퇴사 후 개인정보 사고에 대한 책임을 명확하게 하고 있습니다. 
                                        </li>
                                        <li>개인정보보호 전담부서의 운영<br />
                                            - 회사는 사내 개인정보보호전담부서 등을 통하여 신게임 개인정보 취급방침의 이행사항 및 담당자의 준수여부를 확인하여 문제가 발견될 경우 즉시 수정하고 바로 잡을 수 있도록 노력하고 있습니다.<br />
                                            - 회사는 회원의 개인정보를 보호하기 위하여 최선의 노력을 다하고 있지만 인터넷상의 데이터 전송은 완벽한 안전을 보장받을 수 없으며, 이러한 위험은 회사와 회원이 함께 부담해야 합니다. 단, 회사는 이용자 개인의 실수 혹은 인터넷의 본질적인 위험성으로 인하여 야기되는 개인정보유출에 대해 책임을 지지 않습니다.<br />
                                            - 회사는 앞으로도 회원의 개인정보를 보호할 기술 및 관리에 관한 노하우를 쌓아 갈 것을 약속합니다. 
                                        </li>
                                    </ol>
                                    <b><a name="agree10">제10조 고지의 의무</a></b>
                                    <p style="padding-left: 40px">현 개인정보취급방침의 내용 추가, 삭제 및 수정이 있을 시에는 개정 최소 7일전부터 홈페이지의 '공지사항'을 통해 고지할 것입니다. 다만, 개인정보의 수집 및 활용, 제3자 제공 등과 같이 이용 자 권리의 중요한 변경이 있을 경우에는 최소 30일 전에 고지합니다.</p>
                                    <b><a name="agree11">제11조 개인정보보호(관리)책임자 및 기타 개인정보침해 상담 기관의 연락처</a></b>
                                    <p style="padding-left: 40px">회사는 회원의 개인정보를 보호하고 개인정보와 관련한 불만을 처리하기 위하여 아래와 같이 관련 부서 및 개인정보보호(관리)책임자를 지정하고 있습니다.</p>
                                    <ol>
                                        <li>개인정보 관리 책임자
                                            <br />
                                            이름 : 이상국<br />
                                            직위 : 대표이사<br />
                                            전화 : 1588-3481<br />
                                            전자우편 : <span style="color: #007ebc">sklee@megadreams.co.kr</span>
                                        </li>
                                    </ol>
                                    <p style="padding-left: 40px;">
                                        회원은 회사의 서비스를 이용하며 발생하는 모든 개인정보보호 관련 민원을 개인정보보호(관리)책임자에게 신고하실 수 있습니다. 회사는 회원의 신고사항에 대해 신속하게 충분한 답변을 드릴 것입니다.<br />
                                        개인정보 관리 담당자의 근무시간은 평일: 10:00 ~ 19:00 (토요일 및 일요일, 공휴일은 휴무)입니다.<br />
                                        기타 개인정보침해에 대한 신고나 상담이 필요하신 경우에는 아래 기관에 문의하시기 바랍니다.<br>
                                        <br>
                                        [개인정보침해신고센터]<br>
                                        URL: <a href="http://privacy.kisa.or.kr" style="color: #007ebc" target="_blank">http://privacy.kisa.or.kr</a><br>
                                        전화: 국번없이 118
                                        <br>
                                        <br>
                                        [정보보호마크인증위원회]<br>
                                        URL: <a href="http://www.eprivacy.or.kr" style="color: #007ebc" target="_blank">http://www.eprivacy.or.kr</a><br>
                                        전화: 02-550-9531~2
                                        <br>
                                        <br>
                                        [검찰청 사이버범죄수사단 ]<br>
                                        URL: <a href="http://www.spo.go.kr/minwon/center/report/minwon24.jsp" style="color: #007ebc" target="_blank">http://www.spo.go.kr/minwon/center/report/minwon24.jsp</a><br>
                                        전화: 국번없이 1301
                                        <br>
                                        <br>
                                        [경찰청 사이버테러대응센터 ]<br>
                                        URL: <a href="http://www.ctrc.go.kr" style="color: #007ebc" target="_blank">http://www.ctrc.go.kr</a><br>
                                        전화: 국번없이 182<br>
                                        <br>
                                    </p>
                                    <b><a name="agree12">제12조 개인정보취급방침 시행일자</a></b>
                                    <p style="padding-left: 40px">2011년 11월 20일</p>
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
