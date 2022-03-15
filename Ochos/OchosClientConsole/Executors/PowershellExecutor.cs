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
    internal class PowershellExecutor : IExecutor
    {
        public async Task Execute(ActionCommand command)
        {
            //PowerShell ps = PowerShell.Create();
            //ps.AddScript(Path.Combine(Directory.GetCurrentDirectory(), "Actions", command.Command), true);
            //ps.Invoke();

            var scriptPath = Path.Combine(Directory.GetCurrentDirectory(), "Actions", command.Command);

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"powershell.exe";
            startInfo.Arguments = scriptPath;
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
