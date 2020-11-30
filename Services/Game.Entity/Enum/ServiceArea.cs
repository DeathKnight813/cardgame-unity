using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utils;

namespace Game.Entity.Enum
{
    /// <summary>
    ///道具使用范围
    /// </summary>
    [Serializable]
    [EnumDescription( "道具使用范围" )]
    public enum ServiceArea : int
    {
        /// <summary>
        /// 自己范围
        /// </summary>
        [EnumDescription( "自己范围" )]
        A_MYSELF = 1,

        /// <summary>
        /// 玩家范围 
        /// </summary>
        [EnumDescription( "玩家范围" )]
        A_PLAYER = 2,

        /// <summary>
        /// 旁观范围 
        /// </summary>
        [EnumDescription( "旁观范围" )]
        A_LOOKER = 4


    }

    /// <summary>
    /// 辅助类
    /// </summary>
    public class ServiceAreaHelper
    {
        /// <summary>
        /// 获取描述
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string GetServiceAreaDes( ServiceArea status )
        {
            return EnumDescription.GetFieldText( status );
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IList<EnumDescription> GetServiceAreaList( Type t )
        {
            IList<EnumDescription> list = EnumDescription.GetFieldTexts( t );
            return list;
        }
    }
}
