using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ENode.Infrastructure.Logging;
using NLog;

namespace ENode.NLog
{
    public class NLogLogger : ILogger
    {
        private readonly Logger _logger;

        public NLogLogger(Type type)
        {
            _logger = LogManager.GetCurrentClassLogger(type);
        }

        public NLogLogger(string name)
        {
            _logger = LogManager.GetLogger(name);
        }

        public bool IsDebugEnabled { get { return _logger.IsDebugEnabled; } }
        public void Debug(object message)
        {
            _logger.Debug(message);
        }

        public void DebugFormat(string format, params object[] args)
        {
            _logger.Debug(format, args);
        }

        public void Debug(object message, Exception exception)
        {
            _logger.DebugException(message == null ? string.Empty : message.ToString(), exception);
        }

        public void Info(object message)
        {
            _logger.Info(message);
        }

        public void InfoFormat(string format, params object[] args)
        {
            _logger.Info(format, args);
        }

        public void Info(object message, Exception exception)
        {
            _logger.InfoException(message == null ? string.Empty : message.ToString(), exception);
        }

        public void Error(object message)
        {
            _logger.Error(message);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            _logger.Error(format, args);
        }

        public void Error(object message, Exception exception)
        {
            _logger.ErrorException(message == null ? string.Empty : message.ToString(), exception);
        }

        public void Warn(object message)
        {
            _logger.Warn(message);
        }

        public void WarnFormat(string format, params object[] args)
        {
            _logger.Warn(format, args);
        }

        public void Warn(object message, Exception exception)
        {
            _logger.WarnException(message == null ? string.Empty : message.ToString(), exception);
        }

        public void Fatal(object message)
        {
            _logger.Fatal(message);
        }

        public void FatalFormat(string format, params object[] args)
        {
            _logger.Fatal(format, args);
        }

        public void Fatal(object message, Exception exception)
        {
            _logger.FatalException(message == null ? string.Empty : message.ToString() , exception);
        }
    }
}
