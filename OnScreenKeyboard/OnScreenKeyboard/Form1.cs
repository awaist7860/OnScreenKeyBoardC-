using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OnScreenKeyboard
{
    public partial class Form1 : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                    param.ExStyle |= 0x08000000;
                    return param;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SendKeys.Send("A");

            messageSend();



        }

        public void messageSend()
        {
            int i = 1;
            int t = 10000000;
            int c = 1;
            string amount;

            while(i < t)
            {
                SendKeys.Send("Y");
                SendKeys.Send("O");
                SendKeys.Send(" ");
                SendKeys.Send("C");
                SendKeys.Send("a");
                SendKeys.Send("l");
                SendKeys.Send("l");
                SendKeys.Send(" ");
                SendKeys.Send("M");
                SendKeys.Send("e");
                SendKeys.Send("{ENTER}");
                i++;
                c++;
                amount = c.ToString();
                Thread.Sleep(400);
                label1.Text = amount;

            }
        }
    }
}
