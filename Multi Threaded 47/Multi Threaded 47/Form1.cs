using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Threaded_47
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                button1.Visible = false;
                int milisecondsPassed = 0;
                while (true)
                {
                    milisecondsPassed += 100;
                    label1.Text = DateTime.Now.ToString();
                    
                    if(milisecondsPassed % 200 == 0)
                        label1.ForeColor = Color.Green;
                    else
                        label1.ForeColor = Color.Red;

                    Thread.Sleep(100);
                }
            });
        }
    }
}
