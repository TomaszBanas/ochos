using OchosModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosModel.Proxies
{
    public interface IApiToDeviceProxy
    {
        public void ExecuteAction(DeviceAction action);
    }
}
