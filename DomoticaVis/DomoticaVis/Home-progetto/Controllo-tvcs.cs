using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_progetto
{
    public partial class Controllo_tvcs : Form

    {

        private bool offTv = true;

        public Controllo_tvcs()
        {
            InitializeComponent();
            serialPort1.Open();

            Display.Parent = pictureBox1;

        }
        private home mainForm = null;
        public Controllo_tvcs(Form callingForm)
        {
            mainForm = callingForm as home;
            InitializeComponent();
        }

        private void bt_OnOffTV_Click(object sender, EventArgs e)
        {
            if (offTv)
            {
                Display.Image = Properties.Resources.on_off_button;
                //serialPort2.Write("A");
                offTv = false;
            }
            else
            {
                Display.Image = Properties.Resources.lamp__off;
                // serialPort2.Write("B");
                offTv = true;
            }
        }

        private void bt_volPiuTv_Click(object sender, EventArgs e)
        {

        }

        private void bt_volMenTv_Click(object sender, EventArgs e)
        {

        }

        // 1 
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bt_2Tv_Click(object sender, EventArgs e)
        {

        }

        private void bt_3Tv_Click(object sender, EventArgs e)
        {

        }

        private void bt_4Tv_Click(object sender, EventArgs e)
        {

        }

        private void bt_5Tv_Click(object sender, EventArgs e)
        {

        }

        private void bt_6Tv_Click(object sender, EventArgs e)
        {

        }

        private void bt_7Tv_Click(object sender, EventArgs e)
        {

        }

        private void bt_8Tv_Click(object sender, EventArgs e)
        {

        }

        private void bt_9Tv_Click(object sender, EventArgs e)
        {

        }
    }
}
