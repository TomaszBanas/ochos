using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosModel.Dto
{
    public class DeviceAction
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ActionType Type { get; set; }
        public object CurrentValue { get; set; }
        public object Data { get; set; }
    }
}
