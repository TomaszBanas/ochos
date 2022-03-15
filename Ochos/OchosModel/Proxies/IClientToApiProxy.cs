using OchosModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosModel.Proxies
{
    public interface IClientToApiProxy
    {
        public Task<List<DeviceAction>> GetDevices();
        public void SetDevice(Guid id);
        public void ExecuteAction(DeviceAction action);
    }
}
