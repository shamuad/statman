﻿using System.Configuration.Abstractions;
using Statman.Api.Config;
using Topshelf;
using Statman.Api.Client;

namespace Statman.Api
{
    class Program
    {
        public static void Main(string[] args)
        {
            HostFactory.Run(config =>
            {
                config.Service<NancySelfHost>(selfHost =>
                {
                    selfHost.ConstructUsing(s => new NancySelfHost());
                    selfHost.WhenStarted(s => s.Start());
                    selfHost.WhenStopped(s => s.Stop());
                });

                config.SetServiceName("Statman.Api");
                config.SetDisplayName("Statman");
                config.SetDescription("Statman Service for monitoring servers and services");
            });
        }
    }
}
