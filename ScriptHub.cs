using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hovac_API;

namespace ProjectX
{
    public partial class ScriptHub : Form
    {
        ExploitAPI exploitAPI = new ExploitAPI();
        

        public ScriptHub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://darkhub.xyz/remote-script.lua");
            exploitAPI.SendLuaScript(Script);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ZC70W0dr");
            exploitAPI.SendLuaScript(Script);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/apfkh6XK");
            exploitAPI.SendLuaScript(Script);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/EqQcrCAh");
            exploitAPI.SendLuaScript(Script);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/vWehADmw");
            exploitAPI.SendLuaScript(Script);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(@".\rbxfpsunlocker\fps");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process[] roblox = Process.GetProcesses();
            foreach (Process openedroblox in roblox)
            {
                bool flag = openedroblox.ProcessName == "RobloxPlayerBeta";
                if (flag)
                {
                    openedroblox.Kill();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.pl/view/raw/9a595529");
            exploitAPI.SendLuaScript(Script);
        }
    }
}
