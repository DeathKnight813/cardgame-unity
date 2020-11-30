using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Game.Utils;
using Game.Kernel;
using Game.IData;

namespace Game.Data.Factory
{
    /// <summary>
    /// 数据访问创建工厂
    /// </summary>
    public class ClassFactory
    {
        /// <summary>
        /// 创建后台库对象实例
        /// </summary>
        /// <returns></returns>
        public static INewTroyDataProvider GetINewTroyDataProvider()
        {
            return ProxyFactory.CreateInstance<NewTroyDataProvider>(ApplicationSettings.Get("DBNewTroy"));
        }

        /// <summary>
        /// 创建后台库对象实例
        /// </summary>
        /// <returns></returns>
        public static INewTroyDataProvider GetINewTroyDataProvider2()
        {
            return ProxyFactory.CreateInstance<NewTroyDataProvider>(ApplicationSettings.Get("DBNewTroy2"));
        }
    }
}
