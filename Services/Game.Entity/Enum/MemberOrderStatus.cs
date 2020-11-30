using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utils;

namespace Game.Entity.Enum
{
    /// <summary>
    /// 会员等级
    /// </summary>
    [Serializable]
    [EnumDescription( "会员等级" )]
    public enum MemberOrderStatus : int
    {
        /// <summary>
        /// 普通会员
        /// </summary>
        [EnumDescription( "普通会员" )]
        普通会员 = 0,
        /// <summary>
        /// 蓝钻会员 
        /// </summary>
        [EnumDescription( "蓝钻会员" )]
        蓝钻 = 1,

        /// <summary>
        /// 黄钻会员
        /// </summary>
        [EnumDescription( "黄钻会员" )]
        黄钻 = 2,

        /// <summary>
        /// 白钻会员
        /// </summary>
        [EnumDescription( "白钻会员" )]
        白钻 = 3,

        /// <summary>
        /// 红钻会员
        /// </summary>
        [EnumDescription( "红钻会员" )]
        红钻 = 4
    }

    /// <summary>
    /// 辅助类
    /// </summary>
    public class MemberOrderHelper
    {
        /// <summary>
        /// 获取描述
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string GetMemberOrderStatusDes( MemberOrderStatus status )
        {
            return EnumDescription.GetFieldText( status );
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IList<EnumDescription> GetMemberOrderStatusList( Type t )
        {
            IList<EnumDescription> list = EnumDescription.GetFieldTexts( t );
            return list;
        }       
    }
}
