using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hovac_API;


namespace ProjectX
{
    public partial class prxm : Form
    {
        ExploitAPI exploitAPI = new ExploitAPI();
        public prxm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exploitAPI.LaunchExploit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                WebClient wb = new WebClient();
                string Script = wb.DownloadString("https://controlc.com/d253605a/fullscreen.php?hash=bba78abce974e4ea24ccbddd29f0efa2&toolbar=true&linenum=false");
                exploitAPI.SendLuaScript(Script);
            }
        }
    }
}
