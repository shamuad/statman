using Nancy;
using Nancy.Routing;

namespace Statman.Api.Modules
{
    public class HealthCheckModule : NancyModule
    {
        public HealthCheckModule()
        {
            Get["/ping"] = parameters =>
            {
                return "pong";
            };
        }
    }
}
