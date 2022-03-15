using Newtonsoft.Json;
using OchosClientConsole.Executors;
using OchosClientConsole.Models;
using OchosModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosClientConsole
{
    public class ActionManager
    {
        private ConfigModel Config;
        private readonly ExecutorsFactory _executorsFactory = new ExecutorsFactory();
        private string FolderPath = "Actions";
        private string FilePath = Path.Combine("Actions", "config.json");

        public ActionManager()
        {
            Load();
        }

        public List<DeviceAction> GetActions()
        {
            return Config.Scripts.Select(x => new DeviceAction
            {
                Id = x.Id,
                Name = x.Name,
                Type = ActionType.Single,
                CurrentValue = null,
                Data = null
            }).ToList();
        }
        public async Task ExecuteAction(DeviceAction action)
        {
            var exec = Config.Scripts.First(x => x.Id == action.Id);
            var executor = _executorsFactory.Get(exec.Command.Type);
            await executor.Execute(exec.Command);
        }


        private void Load()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), FilePath);
            var jsonConfigData = File.ReadAllText(path);

            Config = JsonConvert.DeserializeObject<ConfigModel>(jsonConfigData);

            foreach (var item in Config.Scripts)
            {
                if(item.Id == null || item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();
            }

            File.WriteAllText(path, JsonConvert.SerializeObject(Config));
        }
    }
}
