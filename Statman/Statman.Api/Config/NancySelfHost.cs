using System;
using System.Configuration.Abstractions;
using log4net;
using Nancy.Hosting.Self;

namespace Statman.Api.Config
{
    public class NancySelfHost : IDisposable
    {
        private NancyHost nancyHost;
        private readonly ApiSettings settings = ConfigurationManager.Instance.AppSettings.Map<ApiSettings>();
        private readonly ILog logger = LogManager.GetLogger(typeof(NancySelfHost));

        public void Start()
        {
            var hostConfiguration = new HostConfiguration()
            {
                UrlReservations = new UrlReservations()
                {
                    CreateAutomatically = true
                }
            };

            var bootstrapper = new Bootstrapper();

            nancyHost = new NancyHost(bootstrapper, hostConfiguration, new Uri(settings.Url));

            logger.InfoFormat("Statman is starting on " + settings.Url);
            nancyHost.Start();
        }

        public void Stop()
        {
            nancyHost.Stop();
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
