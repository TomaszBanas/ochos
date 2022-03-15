using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosClientConsole.Models
{
    internal class ActionConfig
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ActionCommand Command { get; set; }
    }

    internal class ActionCommand
    {
        public string Type { get; set; }
        public string Command { get; set; }
        public string[] Args { get; set; }
    }
}
