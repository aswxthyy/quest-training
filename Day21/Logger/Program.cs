using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using log4net.Repository;
using System;
using System.IO;

namespace Logger
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            ConfigureLogging(); 

            try
            {
                Console.WriteLine("Enter num1: ");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter num2: ");
                int j = int.Parse(Console.ReadLine());

                int sum = i + j;
                Console.WriteLine($"The sum is: {sum}");
            }
            catch (Exception e)
            {
                log.Error("An error occurred:", e);
            }
        }

        private static void ConfigureLogging()
        {
            var repository = LogManager.GetRepository();
            var layout = new PatternLayout
            {
                ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
            };
            layout.ActivateOptions();

            var consoleAppender = new ConsoleAppender
            {
                Layout = layout,
                Threshold = log4net.Core.Level.Info
            };
            consoleAppender.ActivateOptions();

            var errorFileLogger = new FileAppender
            {
                File = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "error.log"),
                AppendToFile = true,
                Layout = layout,
                Threshold = log4net.Core.Level.Error
            };
            errorFileLogger.ActivateOptions();

            BasicConfigurator.Configure(repository, consoleAppender, errorFileLogger);
        }
    }
}
