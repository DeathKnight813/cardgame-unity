using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity.Troy
{
    /// <summary>
    /// 实体类 ezt_games_config。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ezt_games_config
    {
        #region 常量

        /// <summary>
        /// 表名
        /// </summary>
        public const string Tablename = "ezt_games_config";

        /// <summary>
        /// 标识
        /// </summary>
        public const string _pid_game = "pid_game";

        /// <summary>
        /// 名字
        /// </summary>
        public const string _title_game = "title_game";

        /// <summary>
        /// 
        /// </summary>
        public const string _begin_channelNO = "begin_channelNO";

        /// <summary>
        /// 
        /// </summary>
        public const string _end_channelNO = "end_channelNO";

        /// <summary>
        /// 
        /// </summary>
        public const string _num_subchannel = "num_subchannel";

        /// <summary>
        /// 
        /// </summary>
        public const string _capacity_subchannel = "capacity_subchannel";

        /// <summary>
        /// 
        /// </summary>
        public const string _port_recv = "port_recv";

        /// <summary>
        /// 游戏名称
        /// </summary>
        public const string _table_name = "table_name";

        /// <summary>
        /// 
        /// </summary>
        public const string _table_conn = "table_conn";

        /// <summary>
        /// 水子钱
        /// </summary>
        public const string _money_dealer = "money_dealer";

        /// <summary>
        /// 实际彩金
        /// </summary>
        public const string _money_jackpot = "money_jackpot";

        /// <summary>
        /// 假彩金钱
        /// </summary>
        public const string _FackJackpot = "FackJackpot";

        /// <summary>
        /// 
        /// </summary>
        public const string _money_saving = "money_saving";

        /// <summary>
        /// 水子比例
        /// </summary>
        public const string _rate_dealer = "rate_dealer";

        /// <summary>
        /// 彩金比例
        /// </summary>
        public const string _rate_jackpot = "rate_jackpot";

        /// <summary>
        /// 
        /// </summary>
        public const string _description = "description";

        #endregion

        #region 私有变量
        private int m_pid_game;					//标识
        private string m_title_game;					//名字
        private int m_begin_channelNO;					//
        private int m_end_channelNO;					//
        private int m_num_subchannel;					//
        private int m_capacity_subchannel;					//
        private int m_port_recv;					//
        private string m_table_name;			//
        private string m_table_conn;			//
        private decimal m_money_dealer;					//
        private decimal m_money_jackpot;
        private decimal m_FackJackpot;
        private decimal m_money_saving;
        private int m_rate_dealer;
        private int m_rate_jackpot;
        private string m_description;
        #endregion

        #region 构造方法

        /// <summary>
        /// 初始化ezt_games_config
        /// </summary>
        public ezt_games_config()
        {
            m_pid_game = 0;					//标识
            m_title_game = "";					//名字
            m_begin_channelNO = 0;					//
            m_end_channelNO = 0;					//
            m_num_subchannel = 0;					//
            m_capacity_subchannel = 0;					//
            m_port_recv = 0;					//
            m_table_name = "";			//
            m_table_conn = "";			//
            m_money_dealer = 0;					//
            m_money_jackpot = 0;					//
            m_FackJackpot = 0;
            m_money_saving = 0;					//
            m_rate_dealer = 0;					//
            m_rate_jackpot = 0;			//
            m_description = "";			//
        }

        #endregion

        #region 公共属性

        /// <summary>
        /// 标识
        /// </summary>
        public int pid_game
        {
            get { return m_pid_game; }
            set { m_pid_game = value; }
        }

        /// <summary>
        /// 名字
        /// </summary>
        public string title_game
        {
            get { return m_title_game; }
            set { m_title_game = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int begin_channelNO
        {
            get { return m_begin_channelNO; }
            set { m_begin_channelNO = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int end_channelNO
        {
            get { return m_end_channelNO; }
            set { m_end_channelNO = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int num_subchannel
        {
            get { return m_num_subchannel; }
            set { m_num_subchannel = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int capacity_subchannel
        {
            get { return m_capacity_subchannel; }
            set { m_capacity_subchannel = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int port_recv
        {
            get { return m_port_recv; }
            set { m_port_recv = value; }
        }

        /// <summary>
        /// 游戏名
        /// </summary>
        public string table_name
        {
            get { return m_table_name; }
            set { m_table_name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string table_conn
        {
            get { return m_table_conn; }
            set { m_table_conn = value; }
        }

        /// <summary>
        /// 水子钱
        /// </summary>
        public decimal Money_dealer
        {
            get { return m_money_dealer; }
            set { m_money_dealer = value; }
        }

        /// <summary>
        /// 彩金
        /// </summary>
        public decimal Money_jackpot
        {
            get { return m_money_jackpot; }
            set { m_money_jackpot = value; }
        }

        /// <summary>
        /// 假彩金
        /// </summary>
        public decimal FackJackpot
        {
            get { return m_FackJackpot; }
            set { m_FackJackpot = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal Money_saving
        {
            get { return m_money_saving; }
            set { m_money_saving = value; }
        }

        /// <summary>
        /// 游戏抽水
        /// </summary>
        public int Rate_dealer
        {
            get { return m_rate_dealer; }
            set { m_rate_dealer = value; }
        }

        /// <summary>
        /// 彩金抽水
        /// </summary>
        public int Rate_jackpot
        {
            get { return m_rate_jackpot; }
            set { m_rate_jackpot = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }
        #endregion
    }
}
