using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void internetexplorer_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "http://www.sser.hr");
        }

        private void excel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void Word_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void startInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe");
            startInfo.Arguments = "http://www.sser.hr";
            Process.Start(startInfo);
        }
    }
}
