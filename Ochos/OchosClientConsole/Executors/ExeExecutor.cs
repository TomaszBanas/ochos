using OchosClientConsole.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace OchosClientConsole.Executors
{
    internal class ExeExecutor : IExecutor
    {
        public async Task Execute(ActionCommand command)
        {
            var scriptPath = Path.Combine(Directory.GetCurrentDirectory(), "Actions", command.Command);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = scriptPath;
            startInfo.Arguments = string.Join(' ', command.Args);
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

        }
    }
}
