using System;
using System.IO;

namespace Ex01.Logger
{
    public class Program // Not finished!!!
    {
        public interface ILayout
        {
             string Format { get;}
        }
        public interface IAppender
        {
            public ILayout Layout { get; }
            void Append(string dateTime, ReportLevel reportLevel, string message);
        }
        public interface ILogger
        {
            public IAppender Appender { get;}
            void Info(string dateTime, string message);
            void Error(string datetime, string message);
            void Warning(string datetime, string message);
            void Critical(string datetime, string message);
            void Fatal(string datetime, string message);
        }
        public enum ReportLevel 
        {
            INFO = 0,
            WARNING = 1,
            ERROR = 2,
            CRITICAL = 3,
            FATAL = 4
        }
        internal class SimpleLayout : ILayout
        {
            public string Format => "{0} - {1} - {3}";         
        }
        internal class ConsoleAppender : IAppender
        {
            public ILayout Layout { get; }

            public ConsoleAppender(ILayout layout)
            {
                Layout = layout;
            }

            public void Append(string dateTime, string reportLevel, string message)
            {
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
            }

            public void Append(string dateTime, ReportLevel reportLevel, string message)
            {
                throw new NotImplementedException();
            }
        }
        internal class FileAppender : IAppender
        {
            private const string FilePath = "log.txt";
            public ILayout Layout { get; }
            public FileAppender(ILayout layout)
            {
                Layout = layout;
            }
            public void Append(string dateTime, string reportLevel, string message)
            {
                string appendMessage = 
                    string.Format(Layout.Format, dateTime, reportLevel, message);
                File.AppendAllText(FilePath, appendMessage);
            }

            public void Append(string dateTime, ReportLevel reportLevel, string message)
            {
                throw new NotImplementedException();
            }
        }
        public class Logger : ILogger
        {
            public IAppender Appender { get; }
            public Logger(IAppender appender)
            {
                Appender = appender;
            }
            public void Critical(string dateTime, string message)
            {
                Appender.Append(dateTime, ReportLevel.CRITICAL, message);
            }
            public void Error(string datetime, string message)
            {
                Appender.Append(datetime, ReportLevel.ERROR, message);
            }
            public void Fatal(string datetime, string message)
            {
                Appender.Append(datetime, ReportLevel.FATAL, message);
            }
            public void Info(string dateTime, string message)
            {
                Appender.Append(dateTime, ReportLevel.INFO, message);
            }
            public void Warning(string datetime, string message)
            {
                Appender.Append(datetime, ReportLevel.WARNING, message);
            }
        }

        static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender =
            new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
        }
    }
}