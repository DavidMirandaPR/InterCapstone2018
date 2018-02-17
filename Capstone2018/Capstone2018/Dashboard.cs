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
using System.Xml;
using System.Xml.Serialization;

namespace Capstone2018
{
    public partial class Dashboard : Form
    {
        string PythonScriptsPath = ConfigurationManager.AppSettings["PythonScriptsPath"];
        string PythonEnvironmentName = ConfigurationManager.AppSettings["PythonEnvironmentName"];
        string PythonFile = "shapeRecognition.py";
        string XMLPath = ConfigurationManager.AppSettings["XMLPath"];
        Object myObject = new Object();


        /// <summary>
        /// Initializes the Windows Form Components
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();
            CurrentEnv.Text = PythonEnvironmentName;
        }

        /// <summary>
        /// Action When Run Script Button is Clicked
        /// </summary>
        private void RunScript_Click(object sender, EventArgs e)
        {
            //Setup CMD
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            //Activate Python Environment and run Script
            Console.WriteLine("Activating Environment...");
            cmd.StandardInput.WriteLine($"activate {PythonEnvironmentName}");
            cmd.StandardInput.WriteLine($"cd {PythonScriptsPath}");
            cmd.StandardInput.WriteLine($"python {PythonFile}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            myObject = XMLResultsDeserializer(myObject, XMLPath);
            ShapeDetectedLabel.Text = $"Shape Detected: {myObject.Shape}";
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        private static Object XMLResultsDeserializer(Object myObject, string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Object));
            using (XmlReader reader = XmlReader.Create(path))
            {
                myObject = (Object)ser.Deserialize(reader);
            }
            return myObject;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EnvironmentTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
