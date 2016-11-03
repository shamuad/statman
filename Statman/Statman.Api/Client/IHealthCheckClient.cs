namespace Statman.Api.Client
{
    public interface IHealthCheckClient
    {
        bool BasicStatusCheck(string url);
    }
}