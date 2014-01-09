using ENode.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ENode.NLog
{
    /// <summary>ENode configuration class NLog extensions.
    /// </summary>
    public static class ConfigurationExtensions
    {
        
        /// <summary>Use Log4Net as the logger for the enode framework.
        /// </summary>
        /// <returns></returns>
        public static Configuration UseNLog(this Configuration configuration)
        {
            configuration.SetDefault<ILoggerFactory, NLogLoggerFactory>(new NLogLoggerFactory());
            return configuration;
        }
    }
}
