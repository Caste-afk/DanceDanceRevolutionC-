using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {   

        }

        private void btn_left_Click(object sender, EventArgs e)
        {

        }

        private void btn_down_Click(object sender, EventArgs e)
        {

        }

        private void btn_right_Click(object sender, EventArgs e)
        {

        }
        private void accrnd()
        {
            Random rnd = new Random(Environment.TickCount);

            int n = rnd.Next(1, 5);
            switch (n)
            {
                case 1:
                    btn_up.Image = global::DDR.Properties.Resources.UpOn;
                    break;
                case 2:
                    btn_up.Image = global::DDR.Properties.Resources.RightOn;
                    break;
                case 3:
                    btn_up.Image = global::DDR.Properties.Resources.DownOn;
                    break;
                case 4:
                    btn_up.Image = global::DDR.Properties.Resources.LeftOn;
                    break;
            }
        }
    }
}
