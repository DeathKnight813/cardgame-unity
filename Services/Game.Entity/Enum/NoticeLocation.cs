using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utils;

namespace Game.Entity.Enum
{
    /// <summary>
    ///  公告范围
    /// </summary>
    [Serializable]
    [EnumDescription( "公告范围" )]
    public enum NoticeLocation : int
    {
        /// <summary>
        /// 首页
        /// </summary>
        [EnumDescription( "首页" )]
        A_Index = 0,

        /// <summary>
        /// 新闻公告
        /// </summary>
        [EnumDescription( "新闻公告" )]
        A_Notice = 1,

        /// <summary>
        /// 会员中心
        /// </summary>
        [EnumDescription( "会员中心" )]
        A_Member = 2,

        /// <summary>
        /// 充值中心
        /// </summary>
        [EnumDescription( "充值中心" )]
        A_Pay = 3,
        /// <summary>
        /// 比赛中心 
        /// </summary>
        [EnumDescription( "比赛中心" )]
        A_Match = 4,
        /// <summary>
        /// 充值中心
        /// </summary>
        [EnumDescription( "游戏商城" )]
        A_Mall = 5,

        /// <summary>
        /// 推广系统 
        /// </summary>
        [EnumDescription( "推广系统" )]
        A_Spread = 6,
        /// <summary>
        /// 客服中心
        /// </summary>
        [EnumDescription( "客服中心" )]
        A_Server = 7

    }

    /// <summary>
    /// 辅助类
    /// </summary>
    public class NoticeLocationHelper
    {
        /// <summary>
        /// 获取描述
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string GetNoticeLocationDes( NoticeLocation status )
        {
            return EnumDescription.GetFieldText( status );
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IList<EnumDescription> GetNoticeLocationList( Type t )
        {
            IList<EnumDescription> list = EnumDescription.GetFieldTexts( t );
            return list;
        }
    }
}
