using Microsoft.AspNetCore.SignalR;
using OchosApi.Services;
using OchosModel.Dto;
using OchosModel.Proxies;

namespace OchosApi.Hubs
{
    public class DeviceHub : Hub, IDeviceToApiProxy
    {
        public ConfigurationCacheService _configurationCacheService { get; set; }
        public ActionService _actionService { get; set; }

        public DeviceHub(ConfigurationCacheService configurationCacheService, ActionService actionService)
        {
            _configurationCacheService = configurationCacheService;
            _actionService = actionService;
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"ConnectionId: {Context.ConnectionId}");
            Console.WriteLine($"UserIdentifier: {Context.UserIdentifier}");
            return Task.CompletedTask;
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            Console.WriteLine($"ConnectionId: {Context.ConnectionId}");
            Console.WriteLine($"UserIdentifier: {Context.UserIdentifier}");
            return Task.CompletedTask;
        }


        public async Task<string> PrintMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
            return "reveived";
        }

        public void SetUpActions(List<DeviceAction> actions)
        {
            
        }

        public void OnActionExecuted(DeviceAction action)
        {
            
        }
    }
}
