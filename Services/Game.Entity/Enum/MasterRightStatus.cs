using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Utils;

namespace Game.Entity.Enum
{
    /// <summary>
    /// 管理权限
    /// </summary>
    [Serializable]
    [EnumDescription("管理权限")]
    public enum MasterRightStatus : int
    {
        /// <summary>
        /// 允许禁止游戏
        /// </summary>
        [EnumDescription("允许禁止游戏")]
        UR_CAN_LIMIT_PLAY = 1,

        /// <summary>
        /// 允许禁止旁观
        /// </summary>
        [EnumDescription("允许禁止旁观")]
        UR_CAN_LIMIT_LOOKON = 2,

        /// <summary>
        /// 允许禁止私聊
        /// </summary>
        [EnumDescription("允许禁止私聊")]
        UR_CAN_LIMIT_WISPER = 4,

        /// <summary>
        /// 允许禁止聊天
        /// </summary>
        [EnumDescription("允许禁止聊天")]
        UR_CAN_LIMIT_ROOM_CHAT = 8,

        /// <summary>
        /// 允许禁止聊天
        /// </summary>
        [EnumDescription("允许禁止聊天")]
        UR_CAN_LIMIT_GAME_CHAT = 16,

        /// <summary>
        /// 允许踢出用户
        /// </summary>
        [EnumDescription("允许踢出用户")]
        UR_CAN_KILL_USER = 256,

        /// <summary>
        /// 允许查看地址
        /// </summary>
        [EnumDescription("允许查看地址")]
        UR_CAN_SEE_USER_IP = 512,

        /// <summary>
        /// 允许解散游戏
        /// </summary>
        [EnumDescription("允许解散游戏")]
        UR_CAN_DISMISS_GAME = 1024,

        /// <summary>
        /// 允许禁止地址
        /// </summary>
        [EnumDescription("允许禁止地址")]
        UR_CAN_CONFINE_IP = 4096,

        /// <summary>
        /// 允许禁止机器
        /// </summary>
        [EnumDescription("允许禁止机器")]
        UR_CAN_CONFINE_MAC = 8192,

        /// <summary>
        /// 允许发送警告
        /// </summary>
        [EnumDescription("允许发送警告")]
        UR_CAN_SEND_WARNING = 16384,

        /// <summary>
        /// 允许修改积分
        /// </summary>
        [EnumDescription("允许修改积分")]
        UR_CAN_MODIFY_SCORE = 32768,

        /// <summary>
        /// 允许封锁帐号
        /// </summary>
        [EnumDescription("允许封锁帐号")]
        UR_CAN_FORBID_ACCOUNTS = 65536,

        /// <summary>
        /// 允许游戏绑定
        /// </summary>
        [EnumDescription("允许游戏绑定")]
        UR_CAN_BIND_GAME = 1048576,

        /// <summary>
        /// 允许全局绑定
        /// </summary>
        [EnumDescription("允许全局绑定")]
        UR_CAN_BIND_GLOBAL = 2097152,

        /// <summary>
        /// 允许发布消息
        /// </summary>
        [EnumDescription("允许发布消息")]
        UR_CAN_ISSUE_MESSAGE = 16777216,

        /// <summary>
        /// 允许管理房间
        /// </summary>
        [EnumDescription("允许管理房间")]
        UR_CAN_MANAGER_SERVER = 33554432,

        /// <summary>
        /// 允许管理配置
        /// </summary>
        [EnumDescription("允许管理配置")]
        UR_CAN_MANAGER_OPTION = 67108864,

        /// <summary>
        /// 允许管理机器
        /// </summary>
        [EnumDescription("允许管理机器")]
        UR_CAN_MANAGER_ANDROID = 134217728,
    }

    /// <summary>
    /// 管理权限辅助类
    /// </summary>
    public class MasterRightHelper
    {
        /// <summary>
        /// 获取管理权限描述
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string GetMasterRightDes(MasterRightHelper status)
        {
            return EnumDescription.GetFieldText(status);
        }

        /// <summary>
        /// 获取管理权限集合
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IList<EnumDescription> GetMasterRightList(Type t)
        {
            IList<EnumDescription> list = EnumDescription.GetFieldTexts(t);
            return list;
        }
    }
}
