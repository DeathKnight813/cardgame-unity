using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading;

namespace Game.Facade
{
    public class Fetch
    {
        #region 页面重定向

        /// <summary>
        /// 页面重定向
        /// </summary>
        /// <param name="url"></param>
        public static void Redirect(string url)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.StatusCode = 301;
            HttpContext.Current.Response.AppendHeader("location", url);
            HttpContext.Current.Response.End();
        }

        #endregion

        #region 获取验证码

        /// <summary>
        /// 获取验证码
        /// </summary>
        public static string GetVerifyCodeVer2
        {
            get
            {
                HttpContext context = HttpContext.Current;
                if (context == null || context.Session.Count == 0)
                    return "";
                return context.Session["CheckCode"].ToString();
            }
        }

        /// <summary>
        /// 校验验证码
        /// </summary>
        /// <param name="verifyCode"></param>
        /// <returns></returns>
        public static bool ValidVerifyCodeVer2(string verifyCode)
        {
            HttpContext context = HttpContext.Current;
            if (context == null || context.Session.Count == 0)
                return false;

            if (verifyCode.Equals(context.Session["CheckCode"].ToString(),
                StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }

            return false;
        }

        #endregion

        #region 当前Cookie名称

        /// <summary>
        /// 获取当前Cookie名称
        /// </summary>
        public static string GetCookieName
        {
            get
            {
                return "NewTroy";
            }
        }

        #endregion

        #region 日期处理

        /// <summary>
        /// 获取开始时间
        /// </summary>
        /// <param name="bgDate"></param>
        /// <returns></returns>
        public static string GetStartTime(DateTime bgDate)
        {
            DateTime bgTime = new DateTime(bgDate.Year, bgDate.Month, bgDate.Day, 0, 0, 0);
            return Convert.ToString(bgTime);
        }

        /// <summary>
        /// 获取结束时间
        /// </summary>
        /// <param name="enDate"></param>
        /// <returns></returns>
        public static string GetEndTime(DateTime enDate)
        {
            DateTime enTime = new DateTime(enDate.Year, enDate.Month, enDate.Day, 23, 59, 59);
            return Convert.ToString(enTime);
        }

        /// <summary>
        /// 获取指定日期的开始时间和结束时间(日期格式：开始时间$结束时间)
        /// </summary>
        /// <param name="bgDate"></param>
        /// <param name="enDate"></param>
        /// <returns></returns>
        public static string GetTimeByDate(DateTime bgDate, DateTime enDate)
        {
            DateTime bgTime = new DateTime(bgDate.Year, bgDate.Month, bgDate.Day, 0, 0, 0);
            DateTime enTime = new DateTime(enDate.Year, enDate.Month, enDate.Day, 23, 59, 59);
            return Convert.ToString(bgTime) + "$" + Convert.ToString(enTime);
        }


        /// <summary>
        /// 获取当天的开始时间和结束时间
        /// </summary>
        public static string GetTodayTime()
        {
            DateTime dt = DateTime.Now;
            return GetTimeByDate(dt, dt);
        }

        /// <summary>
        /// 获取昨天的开始时间和结束时间
        /// </summary>
        /// <returns></returns>
        public static string GetYesterdayTime()
        {
            DateTime dt = DateTime.Now.AddDays(-1);
            return GetTimeByDate(dt, dt);
        }

        /// <summary>
        /// 获取本周的开始时间和结束时间
        /// </summary>
        public static string GetWeekTime()
        {
            DateTime dt = DateTime.Now;
            DateTime startWeek = dt.AddDays(0 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));  //本周周日
            DateTime endWeek = startWeek.AddDays(6);  //本周周六
            return GetTimeByDate(startWeek, endWeek);
        }

        /// <summary>
        /// 获取上周的开始时间和结束时间
        /// </summary>
        public static string GetLastWeekTime()
        {
            DateTime dt = DateTime.Now;
            DateTime startWeek = dt.AddDays(0 - 7 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));  //本周周日
            DateTime endWeek = startWeek.AddDays(6);  //本周周日六
            return GetTimeByDate(startWeek, endWeek);
        }

        /// <summary>
        /// 获取本月的开始时间和结束时间
        /// </summary>
        /// <returns></returns>
        public static string GetMonthTime()
        {
            DateTime dt = DateTime.Now;
            DateTime startMonth = dt.AddDays(1 - dt.Day);  //本月月初
            DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);  //本月月末
            return GetTimeByDate(startMonth, endMonth);
        }
        /// <summary>
        /// 获取给定日期距离1900-01-01的天数
        /// </summary>
        /// <param name="DateTime"></param>
        /// <returns></returns>
        public static string GetDateID( DateTime DateTime )
        {
            TimeSpan ts1 = new TimeSpan( DateTime.Ticks );
            TimeSpan ts2 = new TimeSpan( Convert.ToDateTime( "1900-01-01" ).Ticks );
            TimeSpan ts = ts1.Subtract( ts2 ).Duration( );
            return ts.Days.ToString( );
        }
        /// <summary>
        ///  返回指定天数所对应的日期
        /// </summary>
        /// <param name="dateID"></param>
        /// <returns></returns>
        public static string ShowDate( int dateID )
        {
            return Convert.ToDateTime( "1900-01-01" ).AddDays( dateID ).ToString( "yyyy-MM-dd" );
        }
        /// <summary>
        /// 获取时间间隔
        /// </summary>
        /// <param name="dtStartDate">开始时间</param>
        /// <param name="dtEndDate">结束时间</param>
        /// <returns></returns>
        public static string GetTimeSpan( DateTime dtStartDate, DateTime dtEndDate )
        {
            StringBuilder sb = new StringBuilder( );
            TimeSpan ts = dtEndDate.Subtract( dtStartDate );
            if ( ts.Days != 0 )
                sb.AppendFormat( "{0}天", ts.Days );
            if ( ts.Hours != 0 )
                sb.AppendFormat( "{0}小时", ts.Hours );
            if ( ts.Minutes != 0 )
                sb.AppendFormat( "{0}分钟", ts.Minutes );
            if ( ts.Seconds != 0 )
                sb.AppendFormat( "{0}秒", ts.Seconds );
            if ( string.IsNullOrEmpty( sb.ToString( ) ) )
                return "0秒";
            return sb.ToString( );
        }
        /// <summary>
        /// 秒数转换成 0天0小时0分钟0秒
        /// </summary>
        /// <param name="seconds">秒</param>
        /// <returns></returns>
        public static string ConverTimeToDHMS( long seconds )
        {
            StringBuilder sb = new StringBuilder( );
            if ( seconds <= 0 )
                return "0秒";
            long day = seconds / 0x15180;
            long hour = ( seconds % 0x15180 ) / 0xe10;
            long minute = ( seconds % 0xe10 ) / 60;
            long second = seconds % 60;
            if ( day > 0 )
                sb.AppendFormat( "{0}天", day );
            if ( hour > 0 )
                sb.AppendFormat( "{0}小时", hour );
            if ( minute > 0 )
                sb.AppendFormat( "{0}分钟", minute );
            if ( second > 0 )
                sb.AppendFormat( "{0}秒", second );
            if ( string.IsNullOrEmpty( sb.ToString( ) ) )
                return "0秒";
            return sb.ToString( );

        }
        #endregion

        #region 字符串
        /// <summary>
        /// 随机生成指定长度的数字串
        /// </summary>
        /// <param name="length">指定长度</param>
        /// <returns></returns>
        public static string GetRandomNumeric( int length )
        {
            if ( length <= 0 )
            {
                return "";
            }
            StringBuilder builder = new StringBuilder( );
            for ( int i = length; i > 0; i-- )
            {
                builder.Append( GetRandomSingleDigit( ).ToString( ) );
            }
            return builder.ToString( );
        }
        /// <summary>
        /// 随机生成指定长度的数字串
        /// </summary>
        /// <param name="length">指定长度</param>
        /// <returns></returns>
        public static string GetRandomNumeric( int length , Random rand )
        {
            if ( length <= 0 )
            {
                return "";
            }
            StringBuilder builder = new StringBuilder( );
            for ( int i = length; i > 0; i-- )
            {
                builder.Append( rand.Next(0 , 10 ).ToString( ) );
            }
            return builder.ToString( );
        }
        /// <summary>
        /// 随机生成指定长度的数字英文串
        /// </summary>
        /// <param name="length">指定长度</param>
        /// <returns></returns>
        public static string GetRandomNumericAndEn( int length )
        {
            if ( length <= 0 )
            {
                return "";
            }
            string str = "nMe7lcIPKpQ1oAtuGCzL2qf8NO9X4mdFSaHbsOj3DvJrwV6ghiUYZWx5kETRyB";
            int num = length;
            StringBuilder builder = new StringBuilder( );
            List<char> list = new List<char>( );
            Random random = new Random( );
            while ( num > 0 )
            {
                char item = str[random.Next( str.Length )];
                if ( !list.Contains( item ) )
                {
                    list.Add( item );
                    num--;
                }
            }
            foreach ( char ch2 in list )
            {
                builder.Append( ch2.ToString( ) );
            }
            return builder.ToString( );
        }
        /// <summary>
        /// 随机生成单个数字
        /// </summary>
        /// <returns></returns>
        public static int GetRandomSingleDigit( )
        {
            Random random = new Random( );
            Thread.Sleep( 10 );
            return random.Next( 10 );
        }
        /// <summary>
        /// 随机生成指定长度的英文字符串
        /// </summary>
        /// <param name="length">指定长度</param>
        /// <param name="notRepeat">是否允许字母重复 true:不允许 false:允许</param>
        /// <returns></returns>
        public static string GetRandomStr( int length, bool notRepeat )
        {
            if ( length <= 0 )
            {
                return "";
            }
            string str = "cohxMLdeabzEFGNmQZPAstpvwTHOkKnlWqrSYyijXufgRIJUVBCD";
            int num = length;
            StringBuilder builder = new StringBuilder( );
            List<char> list = new List<char>( );
            Random random = new Random( );
            while ( num > 0 )
            {
                char item = str[random.Next( str.Length )];
                if ( notRepeat )
                {
                    if ( length >= 0x1a )
                    {
                        throw new Exception( "指定了不允许字母重复，并且要生成的字符串长度大于等于26，将造成系统陷入死循环。" );
                    }
                    if ( !list.Contains( item ) )
                    {
                        list.Add( item );
                    }
                }
                else
                {
                    list.Add( item );
                }
                num--;
            }
            foreach ( char ch2 in list )
            {
                builder.Append( ch2.ToString( ) );
            }
            return builder.ToString( );
        }

        #endregion
    }
}
