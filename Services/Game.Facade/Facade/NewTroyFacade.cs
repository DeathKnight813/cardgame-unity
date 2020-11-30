using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.IData;
using Game.Data.Factory;
using Game.Kernel;
using Game.Entity.Troy;
using System.Data;
using Game.Utils;

namespace Game.Facade
{
    /// <summary>
    /// NewTroy库外观
    /// </summary>
    public class NewTroyFacade
    {
        #region Fields

        private INewTroyDataProvider aideNewTroyData;
        private INewTroyDataProvider aideNewTroyData2;//wolf3

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public NewTroyFacade()
        {
            aideNewTroyData = ClassFactory.GetINewTroyDataProvider();
        }
        public NewTroyFacade(int nIdx)//wolf4
        {
            aideNewTroyData2 = ClassFactory.GetINewTroyDataProvider2();
        }
        #endregion

        #region 用户登录、注册

        /// <summary>
        /// 用户登录
        /// </summary>
        public Message Logon(ezt_members user, bool isEncryptPasswd)
        {
            Message umsg;
            if (!isEncryptPasswd)
            {
                user.Passwd = Utility.troymd5(user.Passwd, 32);
            }

            umsg = aideNewTroyData.Login(user);
            return umsg;
        }

        /// <summary>
        /// 用户登录，登录密码必须是密文。并且验证登录参数
        /// </summary>
        /// <param name="accounts"></param>
        /// <param name="logonPasswd"></param>
        /// <returns></returns>
        public Message Logon(string accounts, string logonPasswd)
        {
            ezt_members suInfo = new ezt_members(0, accounts, logonPasswd);
            suInfo.IP = GameRequest.GetUserIP();

            return Logon(suInfo, false);
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        public Message Register(ezt_members user, string ShopId)
        {
            return aideNewTroyData.Register(user, ShopId);
        }

        /// <summary>
        /// 判断用户名是否存在
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public Message IsAccountsExist(string accounts)
        {
            return aideNewTroyData.IsAccountsExist(accounts);
        }

        /// <summary>
        /// 判断昵称是否存在
        /// </summary>
        /// <param name="NickName"></param>
        /// <returns></returns>
        public Message IsNickNameExist(string NickName)
        {
            return aideNewTroyData.IsNickNameExist(NickName);
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
            return aideNewTroyData.GetMembersByAccounts(Account);
        }

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public ezt_members GetMembersByUserid(int pid)
        {
            return aideNewTroyData.GetMembersByUserid(pid);
        }

        /// <summary>
        /// 获取用户全局信息
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="Accounts"></param>
        /// <returns></returns>
        public Message GetUserGlobalInfo(int userID, String Accounts)
        {
            return aideNewTroyData.GetUserGlobalInfo(userID, Accounts);
        }

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public ezt_members_dayscore GetMembersDayScoreByPid(int pid)
        {
            return aideNewTroyData.GetMembersDayScoreByPid(pid);
        }

        /// <summary>
        /// 获取会员在线信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public ezt_connection GetMembersOnlineById(string id)
        {
            return aideNewTroyData.GetMembersOnlineById(id);
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
            return aideNewTroyData.GetNoticeList(pageIndex, pageSize, condition, orderby);
        }

        /// <summary>
        /// 获取公告信息
        /// </summary>
        /// <param name="Title"></param>
        /// <returns></returns>
        public tb_notice GetNoticeByTitle(string Title)
        {
            return aideNewTroyData.GetNoticeByTitle(Title);
        }

        /// <summary>
        /// 获取公告实体
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public tb_notice GetNoticeByIdx(int Idx)
        {
            return aideNewTroyData.GetNoticeByIdx(Idx);
        }

        public tb_notice GetNoticeByHome(int homeIdx)
        {
            return aideNewTroyData.GetNoticeByHome(homeIdx);
        }

        /// <summary>
        /// 获取公告实体
        /// </summary>
        /// <param name="noticeID"></param>
        /// <returns></returns>
        public tb_notice GetNoticeByType(int type)
        {
            return aideNewTroyData.GetNoticeByType(type);
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
            return aideNewTroyData.GetOutComeList(pageIndex, pageSize, condition, orderby);
        }
        public PagerSet GetOutComeList2(int pageIndex, int pageSize, string condition, string orderby)
        {
            return aideNewTroyData2.GetOutComeList(pageIndex, pageSize, condition, orderby);
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
            return aideNewTroyData.GetDSByAccounts(Account);
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
            return aideNewTroyData.GetOperationTimeByidx(idx);
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
            return aideNewTroyData.GetMailList(pageIndex, pageSize, condition, orderby);
        }

        /// <summary>
        /// 获取运营时间信息
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public Mail GetMailByidx(int idx)
        {
            return aideNewTroyData.GetMailByidx(idx);
        }

        /// <summary>
        /// 给后台写邮件
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        public Message GiveMailToBack(Mail user)
        {
            return aideNewTroyData.GiveMailToBack(user);
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
            return aideNewTroyData.AddRequest(ApplyMoney, pid, Acowner);
        }

        /// <summary>
        /// 申请提款
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        public Message AddWithDraw(decimal ApplyMoney, int pid, string withdraw)
        {
            return aideNewTroyData.AddWithDraw(ApplyMoney, pid, withdraw);
        }

        /// <summary>
        /// 获取充值个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        public int CountHaveRequest(string UserId)
        {
            return aideNewTroyData.CountHaveRequest(UserId);
        }

        /// <summary>
        /// 获取提款个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        public int CountHaveWithDraw(string UserId)
        {
            return aideNewTroyData.CountHaveWithDraw(UserId);
        }

        /// <summary>
        /// 获取收件箱个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        public int CountMailNum(string ReceiveId)
        {
            return aideNewTroyData.CountMailNum(ReceiveId);
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
            return aideNewTroyData.GetMoneyBackList(pageIndex, pageSize, condition, orderby);
        }
        public PagerSet GetMoneyBackList2(int pageIndex, int pageSize, string condition, string orderby)
        {
            return aideNewTroyData2.GetMoneyBackList(pageIndex, pageSize, condition, orderby);
        }
        #endregion

        public Message DelMail(int nDelIdx)
        {
            return aideNewTroyData.DelMail(nDelIdx);
        }

    }
}
