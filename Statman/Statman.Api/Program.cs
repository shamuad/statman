using System.Configuration.Abstractions;
using Statman.Api.Config;
using Topshelf;

namespace Statman.Api
{
    class Program
    {
        public static void Main(string[] args)
        {
            var settings = ConfigurationManager.Instance.AppSettings.Map<ApiSettings>();

            HostFactory.Run(config =>
            {
                config.Service<NancySelfHost>(selfHost =>
                {
                    selfHost.ConstructUsing(s => new NancySelfHost());
                    selfHost.WhenStarted(s => s.Start());
                    selfHost.WhenStopped(s => s.Stop());
                });

                config.SetServiceName("Statman Service");
                config.SetDisplayName("Nancy Statman Service");
                config.SetDescription("Statman Service Tutorial");
            });
        }
    }


}
