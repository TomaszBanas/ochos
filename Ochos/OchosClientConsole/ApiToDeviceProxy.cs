using Microsoft.AspNetCore.SignalR.Client;
using OchosModel.Dto;
using OchosModel.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosClientConsole
{
    internal class ApiToDeviceProxy : IApiToDeviceProxy
    {
        private HubConnection _hubConnection { get; set; }
        private IDeviceToApiProxy _deviceToApiProxy { get; set; }
        private ActionManager _actionManager { get; set; }

        public ApiToDeviceProxy(HubConnection hubConnection, IDeviceToApiProxy deviceToApiProxy, ActionManager actionManager)
        {
            _hubConnection = hubConnection;
            _deviceToApiProxy = deviceToApiProxy;
            _actionManager = actionManager;

            _hubConnection.On<DeviceAction>("ExecuteAction", ExecuteAction);
        }

        public void ExecuteAction(DeviceAction action)
        {
            Console.WriteLine(action.Name);
        }
    }
}
