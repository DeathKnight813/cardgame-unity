using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Game.Utils;

namespace Game.Entity.Enum
{
    /// <summary>
    /// 用户权限
    /// </summary>
    [Serializable]
    [EnumDescription("用户权限")]
    public enum UserRightStatus : int
    {
        /// <summary>
        /// 不能进行游戏
        /// </summary>
        [EnumDescription("不能进行游戏")]
        UR_CANNOT_PLAY = 1,
        
        /// <summary>
        /// 不能旁观游戏
        /// </summary>
        [EnumDescription("不能旁观游戏")]
        UR_CANNOT_LOOKON = 2,

        /// <summary>
        /// 不能旁观游戏
        /// </summary>
        [EnumDescription("不能发送私聊")]
        UR_CANNOT_WISPER = 4,

        /// <summary>
        /// 不能大厅聊天
        /// </summary>
        [EnumDescription("不能大厅聊天")]
        UR_CANNOT_ROOM_CHAT = 8,

        /// <summary>
        /// 不能游戏聊天
        /// </summary>
        [EnumDescription("不能游戏聊天")]
        UR_CANNOT_GAME_CHAT = 16,

        /// <summary>
        /// 游戏双倍积分
        /// </summary>
        [EnumDescription("游戏双倍积分")]
        UR_GAME_DOUBLE_SCORE = 256,

        /// <summary>
        /// 游戏踢出用户
        /// </summary>
        [EnumDescription("游戏踢出用户")]
        UR_GAME_KICK_OUT_USER = 512,

        /// <summary>
        /// 游戏比赛用户
        /// </summary>
        [EnumDescription("游戏比赛用户")]
        UR_GAME_MATCH_USER = 268435456,
    }

    /// <summary>
    /// 用户权限辅助类
    /// </summary>
    public class UserRightHelper
    {
        /// <summary>
        /// 获取用户权限描述
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string GetUserRightDes(UserRightStatus status)
        {
            return EnumDescription.GetFieldText(status);
        }

        /// <summary>
        /// 获取用户权限集合
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IList<EnumDescription> GetUserRightList(Type t)
        {
            IList<EnumDescription> list = EnumDescription.GetFieldTexts(t);
            return list;
        }
    }
}
