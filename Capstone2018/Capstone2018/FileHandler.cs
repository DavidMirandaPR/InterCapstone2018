using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2018
{
    class FileHandler
    {
        public void run_cmd(string filename = "")
        {
            var ipy = Python.CreateRuntime();
            dynamic test = ipy.UseFile("~/Scripts/Python/test.py");
            test.Simple();
        }
    }
}
