using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosModel.Dto
{
    public class DeviceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IClientProxy Proxy { get; set; }
        public List<DeviceAction> DeviceActions { get; set; }

        public DeviceModel()
        {
            DeviceActions = new List<DeviceAction>();
        }
    }
}
