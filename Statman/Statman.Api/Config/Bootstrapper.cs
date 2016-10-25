using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Nancy.Bootstrappers.Autofac;

namespace Statman.Api.Config
{
    public class Bootstrapper : AutofacNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(ILifetimeScope existingContainer)
        {
            base.ConfigureApplicationContainer(existingContainer);

            var builder = new ContainerBuilder();

        }


    }
}
