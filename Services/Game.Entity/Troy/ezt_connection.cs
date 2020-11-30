using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 ezt_connection。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ezt_connection
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "ezt_connection";

        /// <summary>
        /// 会员标识
        /// </summary>
        public const string _pid = "pid";

        /// <summary>
        /// 会员帐号
        /// </summary>
        public const string _id = "id";

        /// <summary>
        /// 会员昵称
        /// </summary>
        public const string _nickname = "nickname";

        /// <summary>
        /// 会员IP
        /// </summary>
        public const string _UserIP = "UserIP";

        /// <summary>
        /// 游戏标识
        /// </summary>
        public const string _pid_game = "pid_game";

        /// <summary>
        /// 服务名称
        /// </summary>
        public const string _locate_server = "locate_server";

        /// <summary>
        /// 频道
        /// </summary>
        public const string _locate_channel = "locate_channel";

        /// <summary>
        /// 房间
        /// </summary>
        public const string _locate_room = "locate_room";

        /// <summary>
        /// 桌号
        /// </summary>
        public const string _locate_slot = "locate_slot";

        /// <summary>
        /// 时间
        /// </summary>
        public const string _logdate = "logdate";

        /// <summary>
        /// 
        /// </summary>
        public const string _server_number = "server_number";

        /// <summary>
        /// 房间分值
        /// </summary>
        public const string _Room_Pin = "Room_Pin";

        /// <summary>
        /// 0没有密码 1有密码
        /// </summary>
        public const string _Room_PW = "Room_PW";
        #endregion

        #region 私有变量
        private int m_pid;
        private string m_id;
        private string m_nickname;
        private string m_UserIP;
        private int m_pid_game;
        private string m_locate_server;
        private string m_locate_channel;
        private int m_locate_room;
        private int m_locate_slot;
        private DateTime m_logdate;
        private int m_server_number;
        private int m_Room_Pin;
        private int m_Room_PW;
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化ezt_connection
        /// </summary>
        public ezt_connection()
        {
            m_pid = 0;
            m_id = "";
            m_nickname = "";
            m_UserIP = "";
            m_pid_game = 0;
            m_locate_server = "";
            m_locate_channel = "";
            m_locate_room = 0;
            m_locate_slot = 0;
            m_logdate = DateTime.Now;
            m_server_number = 0;
            m_Room_Pin = 0;
            m_Room_PW = 0;
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 会员标识
        /// </summary>
        public int pid
        {
            get { return m_pid; }
            set { m_pid = value; }
        }

        /// <summary>
        /// 会员帐号
        /// </summary>
        public string id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        /// <summary>
        /// 会员昵称
        /// </summary>
        public string nickname
        {
            get { return m_nickname; }
            set { m_nickname = value; }
        }

        /// <summary>
        /// 会员帐号
        /// </summary>
        public string UserIP
        {
            get { return m_UserIP; }
            set { m_UserIP = value; }
        }

        /// <summary>
        /// 游戏标识
        /// </summary>
        public int pid_game
        {
            get { return m_pid_game; }
            set { m_pid_game = value; }
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        public string locate_server
        {
            get { return m_locate_server; }
            set { m_locate_server = value; }
        }

        /// <summary>
        /// 1 Baduki   2 Sudba
        /// </summary>
        public string locate_channel
        {
            get { return m_locate_channel; }
            set { m_locate_channel = value; }
        }

        /// <summary>
        /// 房间号
        /// </summary>
        public int locate_room
        {
            get { return m_locate_room; }
            set { m_locate_room = value; }
        }

        /// <summary>
        /// 桌号
        /// </summary>
        public int locate_slot
        {
            get { return m_locate_slot; }
            set { m_locate_slot = value; }
        }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime logdate
        {
            get { return m_logdate; }
            set { m_logdate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int server_number
        {
            get { return m_server_number; }
            set { m_server_number = value; }
        }

        /// <summary>
        /// 房间分值
        /// </summary>
        public int Room_Pin
        {
            get { return m_Room_Pin; }
            set { m_Room_Pin = value; }
        }

        /// <summary>
        /// 0没有密码 1有密码
        /// </summary>
        public int Room_PW
        {
            get { return m_Room_PW; }
            set { m_Room_PW = value; }
        }
        #endregion
    }
}
