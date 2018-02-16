using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace Capstone2018
{
    public partial class Dashboard : Form
    {
        string PythonScriptsPath = ConfigurationManager.AppSettings["PythonScriptsPath"];
        string PythonFile = "test.py";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void RunScript_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            Console.WriteLine("Activating Environment...");
            cmd.StandardInput.WriteLine("activate capstone");
            cmd.StandardInput.WriteLine("cd " + PythonScriptsPath);
            cmd.StandardInput.WriteLine("python " + PythonFile);
            //cmd.StandardInput.Flush();
            //cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
    }
}
