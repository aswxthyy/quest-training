using log4net;
using log4net.Config;
using System.IO;

public static class BasicConfigure
{
    public static void Configure()
    {
        XmlConfigurator.Configure(new FileInfo("log4net.config"));
    }
}
