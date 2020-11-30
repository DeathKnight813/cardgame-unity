using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Game.Kernel;
using Game.IData;
using Game.Entity.Troy;
using System.Data;
using System.Data.Common;

namespace Game.Data
{
    public class NewTroyDataProvider : BaseDataProvider, INewTroyDataProvider
    {
        #region Fields

        private ITableProvider aideezt_membersProvider;
        private ITableProvider aidetb_noticeProvider;
        private ITableProvider aidetb_AgentManagersProvider;
        private ITableProvider aidetb_configProvider;
        private ITableProvider aideMailProvider;
        private ITableProvider aideMoneyBackProvider;
        private ITableProvider aideezt_members_dayscoreProvider;
        private ITableProvider aideezt_connectionProvider;
        #endregion

        #region 构造方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public NewTroyDataProvider(string connString)
            : base(connString)
        {
            aideezt_membersProvider = GetTableProvider(ezt_members.Tablename);
            aidetb_noticeProvider = GetTableProvider(tb_notice.Tablename);
            aidetb_AgentManagersProvider = GetTableProvider(tb_AgentManagers.Tablename);
            aidetb_configProvider = GetTableProvider(tb_config.Tablename);
            aideMailProvider = GetTableProvider(Mail.Tablename);
            aideMoneyBackProvider = GetTableProvider(MoneyBack.Tablename);
            aideezt_members_dayscoreProvider = GetTableProvider(ezt_members_dayscore.Tablename);
            aideezt_connectionProvider = GetTableProvider(ezt_connection.Tablename);
        }
        #endregion

        #region 用户登录、注册

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Message Login(ezt_members user)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strAccounts", user.Id));
            prams.Add(Database.MakeInParam("strPassword", user.Passwd));
            prams.Add(Database.MakeInParam("strClientIP", user.IP));
            prams.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessageForObject<ezt_members>(Database, "NET_Front_EnterWeb", prams);
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        public Message Register(ezt_members user, string ShopId)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strAccounts", user.Id));
            prams.Add(Database.MakeInParam("strNickname", user.Nickname));
            prams.Add(Database.MakeInParam("strLogonPass", user.Passwd));
            prams.Add(Database.MakeInParam("strTruePasswd", user.TruePasswd));
            prams.Add(Database.MakeInParam("strWithdrawalsPass", user.WithdrawalsPass));
            prams.Add(Database.MakeInParam("strTrueWithdrawalsPass", user.TrueWithdrawalsPass));
            prams.Add(Database.MakeInParam("strphone", user.Phone));
            prams.Add(Database.MakeInParam("strBankName", user.BankName));
            prams.Add(Database.MakeInParam("strBankAccount", user.BankNumber));
            prams.Add(Database.MakeInParam("strBankAcowner", user.BankAccount));
            prams.Add(Database.MakeInParam("strIP", user.IP));
            prams.Add(Database.MakeInParam("dwUpmembersPID", user.UpmembersPID));
            prams.Add(Database.MakeInParam("strUrl", ShopId));
            prams.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessage(Database, "NET_Front_RegisterAccounts", prams);
        }

        /// <summary>
        /// 判断用户名是否存在
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public Message IsAccountsExist(string accounts)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strAccounts", accounts));
            prams.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessage(Database, "NET_Front_IsAccountsExists", prams);
        }

        /// <summary>
        /// 判断昵称是否存在
        /// </summary>
        /// <param name="NickName"></param>
        /// <returns></returns>
        public Message IsNickNameExist(string NickName)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strNickName", NickName));
            prams.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessage(Database, "NET_Front_IsNickNameExist", prams);
        }
        #endregion

        #region 会员信息
        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public ezt_members GetMembersByAccounts(string Account)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE Id= N'{0}'", Account);
            ezt_members user = aideezt_membersProvider.GetObject<ezt_members>(sqlQuery);
            return user;
        }

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public ezt_members GetMembersByUserid(int pid)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE Pid= N'{0}'", pid);
            ezt_members user = aideezt_membersProvider.GetObject<ezt_members>(sqlQuery);
            return user;
        }

        /// <summary>
        /// 获取用户全局信息
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="Accounts"></param>
        /// <returns></returns>
        public Message GetUserGlobalInfo(int userID, String Accounts)
        {
            List<DbParameter> parms = new List<DbParameter>();
            parms.Add(Database.MakeInParam("dwUserID", userID));
            parms.Add(Database.MakeInParam("strAccounts", Accounts));
            parms.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessageForObject<ezt_members>(Database, "NET_Front_GetUserGlobalsInfo", parms);
        }

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public ezt_members_dayscore GetMembersDayScoreByPid(int pid)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE pid= {0}", pid);
            ezt_members_dayscore user = aideezt_members_dayscoreProvider.GetObject<ezt_members_dayscore>(sqlQuery);
            return user;
        }

        /// <summary>
        /// 获取会员在线信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public ezt_connection GetMembersOnlineById(string id)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE id= '{0}'", id);
            ezt_connection user = aideezt_connectionProvider.GetObject<ezt_connection>(sqlQuery);
            return user;
        }
        #endregion

        #region 公告信息
        /// <summary>
        /// 获取公告列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="condition"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public PagerSet GetNoticeList(int pageIndex, int pageSize, string condition, string orderby)
        {
            PagerParameters pagerPrams = new PagerParameters(tb_notice.Tablename, orderby, condition, pageIndex, pageSize);

            return GetPagerSet2(pagerPrams);
        }

        /// <summary>
        /// 获取公告信息
        /// </summary>
        /// <param name="Title"></param>
        /// <returns></returns>
        public tb_notice GetNoticeByTitle(string Title)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE Title= N'{0}'", Title);
            tb_notice user = aidetb_noticeProvider.GetObject<tb_notice>(sqlQuery);
            return user;
        }

        /// <summary>
        /// 获取公告实体
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public tb_notice GetNoticeByIdx(int Idx)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE Idx= {0}", Idx);
            tb_notice notice = aidetb_noticeProvider.GetObject<tb_notice>(sqlQuery);
            return notice;
        }

        public tb_notice GetNoticeByHome(int homeIdx)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE IsHome= {0}", homeIdx);
            tb_notice notice = aidetb_noticeProvider.GetObject<tb_notice>(sqlQuery);
            return notice;
        }

        /// <summary>
        /// 获取公告实体
        /// </summary>
        /// <param name="noticeID"></param>
        /// <returns></returns>
        public tb_notice GetNoticeByType(int type)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE Notice_Type= {0}", type);//wolf2
            tb_notice notice = aidetb_noticeProvider.GetObject<tb_notice>(sqlQuery);
            return notice;
        }
        #endregion

        #region 提款信息
        /// <summary>
        /// 获取提款列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="condition"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public PagerSet GetOutComeList(int pageIndex, int pageSize, string condition, string orderby)
        {
            PagerParameters pagerPrams = new PagerParameters(tb_UserInOutCome.Tablename, orderby, condition, pageIndex, pageSize);

            return GetPagerSet2(pagerPrams);
        }
        #endregion

        #region 代理信息
        /// <summary>
        /// 获取代理信息
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public int GetDSByAccounts(string Account)
        {
            string sqlQuery = string.Format("SELECT Idx FROM tb_AgentManagers(NOLOCK) WHERE Account='{0}'", Account);
            tb_AgentManagers user = Database.ExecuteObject<tb_AgentManagers>(sqlQuery);
            return user == null ? 0 : user.Idx;
        }
        #endregion

        #region 系统设置
        /// <summary>
        /// 获取运营时间信息
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public tb_config GetOperationTimeByidx(int idx)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE idx= N'{0}'", idx);
            tb_config model = aidetb_configProvider.GetObject<tb_config>(sqlQuery);
            return model;
        }
        #endregion

        #region 邮件功能
        /// <summary>
        /// 获取邮件功能列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="condition"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public PagerSet GetMailList(int pageIndex, int pageSize, string condition, string orderby)
        {
            PagerParameters pagerPrams = new PagerParameters(Mail.Tablename, orderby, condition, pageIndex, pageSize);

            return GetPagerSet2(pagerPrams);
        }

        /// <summary>
        /// 获取运营时间信息
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public Mail GetMailByidx(int idx)
        {
            string sqlQuery = string.Format("(NOLOCK) WHERE idx= N'{0}'", idx);
            Mail model = aideMailProvider.GetObject<Mail>(sqlQuery);
            return model;
        }

        /// <summary>
        /// 给后台写邮件
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Message GiveMailToBack(Mail user)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strS_Account", user.S_Account));
            prams.Add(Database.MakeInParam("strS_NickName", user.S_NickName));
            prams.Add(Database.MakeInParam("strM_Content", user.M_Content));
            prams.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessage(Database, "NET_Front_GiveMailToBack", prams);
        }
        #endregion

        #region 充值提款
        /// <summary>
        /// 申请充值
        /// </summary>
        /// <param name="ApplyMoney"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public Message AddRequest(decimal ApplyMoney, int pid, string Acowner)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("dwApplyMoney", ApplyMoney));
            prams.Add(Database.MakeInParam("dwpid", pid));
            prams.Add(Database.MakeInParam("strAcowner", Acowner));
            prams.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessage(Database, "NET_Front_AddRequest", prams);
        }

        /// <summary>
        /// 申请提款
        /// </summary>
        /// <param name="ApplyMoney"></param>
        /// <param name="pid"></param>
        /// <param name="withdraw"></param>
        /// <returns></returns>
        public Message AddWithDraw(decimal ApplyMoney, int pid, string withdraw)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("dwApplyMoney", ApplyMoney));
            prams.Add(Database.MakeInParam("dwpid", pid));
            prams.Add(Database.MakeInParam("strwithdraw", withdraw));
            prams.Add(Database.MakeOutParam("strErrorDescribe", typeof(string), 127));

            return MessageHelper.GetMessage(Database, "NET_Front_AddWithDraw", prams);
        }

        /// <summary>
        /// 获取充值个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        public int CountHaveRequest(string UserId)
        {
            object obj;
            var prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strUserId", UserId));
            Database.RunProc("NET_Front_CountHaveRequest", prams, out obj);
            if (obj == null || obj.ToString().Length <= 0)
                return 0;
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 获取提款个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        public int CountHaveWithDraw(string UserId)
        {
            object obj;
            var prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strUserId", UserId));
            Database.RunProc("NET_Front_CountHaveWithDraw", prams, out obj);
            if (obj == null || obj.ToString().Length <= 0)
                return 0;
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 获取收件箱个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        public int CountMailNum(string ReceiveId)
        {
            object obj;
            var prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("strReceiveId", ReceiveId));
            Database.RunProc("NET_Front_CountMailNum", prams, out obj);
            if (obj == null || obj.ToString().Length <= 0)
                return 0;
            return int.Parse(obj.ToString());
        }

        public Message DelMail(int nDelIdx)
        {
            List<DbParameter> prams = new List<DbParameter>();
            prams.Add(Database.MakeInParam("DelIdx", nDelIdx));
            return MessageHelper.GetMessage(Database, "NET_Front_DelMail", prams);
        }

        #endregion

        #region 假返钱信息
        /// <summary>
        /// 获取假返钱列表
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="condition"></param>
        /// <param name="orderby"></param>
        /// <returns></returns>
        public PagerSet GetMoneyBackList(int pageIndex, int pageSize, string condition, string orderby)
        {
            PagerParameters pagerPrams = new PagerParameters(MoneyBack.Tablename, orderby, condition, pageIndex, pageSize);

            return GetPagerSet2(pagerPrams);
        }
        #endregion
    }
}
