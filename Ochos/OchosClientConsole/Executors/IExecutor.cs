using OchosClientConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosClientConsole.Executors
{
    internal interface IExecutor
    {
        public Task Execute(ActionCommand command);
    }
}
