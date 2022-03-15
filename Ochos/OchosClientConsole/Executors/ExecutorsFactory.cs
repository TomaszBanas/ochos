using OchosClientConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchosClientConsole.Executors
{
    internal class ExecutorsFactory
    {
        public IExecutor Get(string type)
        {
            if (type.ToUpper() == "POWERSHELL")
                return new PowershellExecutor();
            
            if (type.ToUpper() == "EXE")
                return new ExeExecutor();

            return null;
        }
    }
}
