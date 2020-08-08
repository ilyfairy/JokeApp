using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeApp
{
    public partial class off : Form
    {
        [DllImport("ntdll.dll")]
        public static extern void RtlSetProcessIsCritical(bool a, bool b, bool c);
        public off()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "xiaoxiannvlalala")
            {
                RtlSetProcessIsCritical(false, false, false);
                Environment.Exit(0);
                return;
            }
            MessageBox.Show(new List<string>() { "猜错啦！", "猜不到怎么办QAQ", "QwQ" }[new Random().Next(0, 3)], "qwq");
        }
    }
}
