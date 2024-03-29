﻿using LogForU.Core.Appendres.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Loggers.Interfaces;
using LogForU.Core.Models;
using LogForU.Core.Models.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace LogForU.Core.Loggers
{
    public class Logger : ILogger
    {
        private readonly ICollection<IAppender> appendres;

        public Logger(params IAppender[] appenders)
        {
            this.appendres = appenders;
        }

        public void Info(string dateTime, string text)
        {
            AppendAll(dateTime, text, ReportLevel.Info);
        }
        
        public void Warning(string dateTime, string text)
        {
            AppendAll(dateTime, text, ReportLevel.Warning);
        }

        public void Error(string dateTime, string text)
        {
            AppendAll(dateTime, text, ReportLevel.Error);
        }

        public void Critical(string dateTime, string text)
        {
            AppendAll(dateTime, text, ReportLevel.Critical);
        }

        public void Fatal(string dateTime, string text)
        {
            AppendAll(dateTime, text, ReportLevel.Fatal);
        }

        private void AppendAll (string dateTime, string text, ReportLevel reportLevel) 
        {
            IMessage message = new Message(dateTime, text, reportLevel); 

            foreach (IAppender appender in appendres)
            {
                if (message.ReportLevel >= appender.ReportLevel)
                {
                    appender.AppendMessage(message);
                }
            }
        }
    }
}
