using OchosModel.Dto;

namespace OchosApi.Services
{
    public class ConfigurationCacheService
    {
        private List<DeviceModel> Devices { get; set; }
        private List<ClientModel> Clients { get; set; }


        public void AddDevice(Guid id, string name)
        {
            Devices.Add(new DeviceModel()
            {
                Id = id,
                Name = name,
            });
        }

    }
}
