using OchosModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosModel.Proxies
{
    public interface IApiToClientProxy
    {
        public void OnActionExecuted(DeviceAction action);
        public void OnDeviceDisconected();
    }
}
