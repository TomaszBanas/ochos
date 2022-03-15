using Microsoft.AspNetCore.SignalR;
using OchosApi.Services;

namespace OchosApi.Hubs
{
    public class ClientHub : Hub
    {
        public ConfigurationCacheService _configurationCacheService { get; set; }

        public ClientHub(ConfigurationCacheService configurationCacheService)
        {
            _configurationCacheService = configurationCacheService;
        }
    }
}
