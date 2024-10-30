using System;
using Serilog;
using Serilog.Events;
using System.Threading;
using System.Globalization;

namespace MySerilog
{
    internal class Program
    {
        static void Action1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            System.Console.WriteLine($"Action 1 : {DateTime.Now}");
        }
        private static void Main(string[] args)
        {
            var ci = new CultureInfo("en-IN");
            CultureInfo.DefaultThreadCurrentCulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;

            System.Console.WriteLine($"Main : {DateTime.Now}");

            var t = new Thread(Action1);
            t.Start();
            t.Join();
            
            // var logger = new LoggerConfiguration()
            //     .WriteTo.Console(
            //         restrictedToMinimumLevel : LogEventLevel.Information,
            //         outputTemplate : "[{Timestamp} {Level:u3} {Message} {NewLine}]"
            //     )
            //     .CreateLogger();

            // logger.Information("Application starting");

        }
    }
}
