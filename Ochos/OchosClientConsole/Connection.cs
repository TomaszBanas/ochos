using Microsoft.AspNetCore.SignalR.Client;
using OchosModel.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosClientConsole
{
    public class Connection
    {
        private IApiToDeviceProxy _apiToDeviceProxy { get; set; }
        private IDeviceToApiProxy _deviceToApiProxy { get; set; }
        private HubConnection _hubConnection { get; set; }
        private ActionManager _actionManager { get; set; }

        public async Task Connect(string url)
        {

            _hubConnection = new HubConnectionBuilder()
                            .WithUrl(url + "/devicehub")
                            .WithAutomaticReconnect()
                            .Build();
            _actionManager = new ActionManager();
            _deviceToApiProxy = new DeviceToApiProxy(_hubConnection);
            _apiToDeviceProxy = new ApiToDeviceProxy(_hubConnection, _deviceToApiProxy, _actionManager);

            await _hubConnection.StartAsync();

            _deviceToApiProxy.SetUpActions(_actionManager.GetActions());
        }
        
        public async Task Dispose()
        {
            await _hubConnection.StopAsync();
            await _hubConnection.DisposeAsync();
        }
    }
}
