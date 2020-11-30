using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utils;

namespace Game.Entity.Enum
{
    /// <summary>
    /// 支持类型
    /// </summary>
    [Serializable]
    [EnumDescription("支持类型")]
    public enum SupporTypeStatus : int
    {
        /// <summary>
        /// 金币类型
        /// </summary>
        [EnumDescription("金币类型")]
        SP_TREASURE = 1,

        /// <summary>
        /// 点值类型
        /// </summary>
        [EnumDescription("点值类型")]
        SP_SCORE = 2,

        /// <summary>
        /// 比赛类型
        /// </summary>
        [EnumDescription("比赛类型")]
        SP_GAME = 4,

        /// <summary>
        /// 训练类型
        /// </summary>
        [EnumDescription("训练类型")]
        SP_EXERCISE = 8
    }

    /// <summary>
    /// 游戏支持类型辅助类
    /// </summary>
    public class SupporTypeHelper
    {
        /// <summary>
        /// 获取支持类型描述
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string GetSupporTypeDes(SupporTypeStatus status)
        {
            return EnumDescription.GetFieldText(status);
        }

        /// <summary>
        /// 获取支持类型列表
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IList<EnumDescription> GetSupporTypeList(Type t)
        {
            IList<EnumDescription> list = EnumDescription.GetFieldTexts(t);
            return list;
        }

        /// <summary>
        /// 包含类型
        /// </summary>
        /// <param name="supporType"></param>
        /// <param name="status"></param>
        /// <returns>true:不存在,false:存在</returns>
        public static bool IsExists(int supporType, SupporTypeStatus status)
        {
            return (supporType & (int)status) == 0;
        }
    }
}
