
using OchosModel.Dto;

namespace OchosModel.Proxies
{
    public interface IDeviceToApiProxy
    {
        public void SetUpActions(List<DeviceAction> actions);
        public void OnActionExecuted(DeviceAction action);
    }
}
