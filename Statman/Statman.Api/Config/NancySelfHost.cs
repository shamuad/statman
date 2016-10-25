using System;
using Nancy.Hosting.Self;

namespace Statman.Api.Config
{
    public class NancySelfHost : IDisposable
    {
        private NancyHost nancyHost;

        public void Start()
        {
            var uri = new Uri("http://localhost:1973");

            var hostConfiguration = new HostConfiguration()
            {
                UrlReservations = new UrlReservations()
                {
                    CreateAutomatically = true
                }
            };

            var bootstrapper = new Bootstrapper();

            nancyHost = new NancyHost(bootstrapper, hostConfiguration, new Uri[] { uri });
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
