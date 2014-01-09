using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENode.Infrastructure.Logging;
using NLog;

namespace ENode.NLog
{
    class NLogLoggerFactory : ILoggerFactory
    {
        public ILogger Create(string name)
        {
            return new NLogLogger(name);
        }

        public ILogger Create(Type type)
        {
            return new NLogLogger(type);
        }
    }
}
