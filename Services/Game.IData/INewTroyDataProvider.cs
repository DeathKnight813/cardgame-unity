using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Game.Kernel;
using System.Data;
using Game.Entity.Troy;
namespace Game.IData
{
    /// <summary>
    /// troy数据层接口
    /// </summary>
    public interface INewTroyDataProvider
    {
        #region 用户登录、注册
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Message Login(ezt_members user);

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        Message Register(ezt_members user, string ShopId);

        /// <summary>
        /// 判断用户名是否存在
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        Message IsAccountsExist(string accounts);

        /// <summary>
        /// 判断昵称是否存在
        /// </summary>
        /// <param name="NickName"></param>
        /// <returns></returns>
        Message IsNickNameExist(string NickName);
        #endregion

        #region 会员信息
        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        ezt_members GetMembersByAccounts(string Account);

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        ezt_members GetMembersByUserid(int pid);

        /// <summary>
        /// 获取用户全局信息
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="Accounts"></param>
        /// <returns></returns>
        Message GetUserGlobalInfo(int userID, String Accounts);

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        ezt_members_dayscore GetMembersDayScoreByPid(int pid);

        /// <summary>
        /// 获取会员在线信息
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        ezt_connection GetMembersOnlineById(string id);
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
        PagerSet GetNoticeList(int pageIndex, int pageSize, string condition, string orderby);

        /// <summary>
        /// 获取公告信息
        /// </summary>
        /// <param name="Title"></param>
        /// <returns></returns>
        tb_notice GetNoticeByTitle(string Title);

        /// <summary>
        /// 获取公告实体
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        tb_notice GetNoticeByIdx(int Idx);

        tb_notice GetNoticeByHome(int homeIdx);

        /// <summary>
        /// 获取公告实体
        /// </summary>
        /// <param name="noticeID"></param>
        /// <returns></returns>
        tb_notice GetNoticeByType(int type);
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
        PagerSet GetOutComeList(int pageIndex, int pageSize, string condition, string orderby);
        #endregion

        #region 代理信息
        /// <summary>
        /// 获取代理信息
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        int GetDSByAccounts(string Account);
        #endregion

        #region 系统设置
        /// <summary>
        /// 获取运营时间信息
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        tb_config GetOperationTimeByidx(int idx);
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
        PagerSet GetMailList(int pageIndex, int pageSize, string condition, string orderby);

        /// <summary>
        /// 获取运营时间信息
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        Mail GetMailByidx(int idx);

        /// <summary>
        /// 给后台写邮件
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        Message GiveMailToBack(Mail user);
        #endregion

        #region 充值提款
        /// <summary>
        /// 申请充值
        /// </summary>
        /// <param name="ApplyMoney"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        Message AddRequest(decimal ApplyMoney, int pid, string Acowner);

        /// <summary>
        /// 申请提款
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ShopId"></param>
        /// <returns></returns>
        Message AddWithDraw(decimal ApplyMoney, int pid, string withdraw);

        /// <summary>
        /// 获取充值个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        int CountHaveRequest(string UserId);

        /// <summary>
        /// 获取提款个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        int CountHaveWithDraw(string UserId);

        /// <summary>
        /// 获取收件箱个数
        /// </summary>
        /// <param name="intou"></param>
        /// <returns></returns>
        int CountMailNum(string ReceiveId);

        Message DelMail(int nDelIdx);

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
        PagerSet GetMoneyBackList(int pageIndex, int pageSize, string condition, string orderby);
        #endregion
    }
}
