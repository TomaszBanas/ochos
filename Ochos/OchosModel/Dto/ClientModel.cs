using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosModel.Dto
{
    public class ClientModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid DeviceId { get; set; }
        public IClientProxy Proxy { get; set; }
    }
}
