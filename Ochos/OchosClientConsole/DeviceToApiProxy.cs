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
    public class DeviceToApiProxy : IDeviceToApiProxy
    {
        private HubConnection _hubConnection { get; set; }

        public DeviceToApiProxy(HubConnection hubConnection)
        {
            _hubConnection = hubConnection;
        }

        public void OnActionExecuted(DeviceAction action)
        {
            _hubConnection.InvokeAsync("OnActionExecuted", action);
        }

        public void SetUpActions(List<DeviceAction> actions)
        {
            _hubConnection.InvokeAsync("SetUpActions", actions);
        }
    }
}
