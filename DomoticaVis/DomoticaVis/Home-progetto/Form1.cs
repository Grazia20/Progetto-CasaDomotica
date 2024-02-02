using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home_progetto
{
    public partial class home : Form
    {
        public delegate void d1(string indata);
        private bool luceStanzaSpento = true; 
        private bool luceBagnoSpento = true;
        private bool luceLettoSpento = true;
        private bool tvAccesa = false;
        private bool allarmeOn = true;

        public home()
        {
            InitializeComponent();
            this.Size = new Size(1300, 700);

            serialPort2.Open();
            
            
            pb_LuceStanza.Parent = pictureBox1;
            pb_LuceBagno.Parent = pictureBox1;
            pb_LuceLetto.Parent = pictureBox1;
            pb_lucchetto.Parent = pictureBox1;
            pb_fan.Parent = pictureBox1;
            pb_tv.Parent = pictureBox1;

            pb_LuceStanza.BackColor = Color.Transparent;
            pb_LuceBagno.BackColor = Color.Transparent;
            pb_LuceLetto.BackColor = Color.Transparent;

            DisattivaBottoni();



        }

        //legge dati dalla porta CM
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try {
                string indata = serialPort2.ReadLine();
                d1 writeit = new d1(Write2Form);
                Invoke(writeit, indata);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Write2Form(string indata)
        {
            char firstchar;
            string temp;
            string humidity;
            firstchar = indata[0];
            try
            {
                switch (firstchar)
                {
                    //temperatura
                    case 't': 
                        temp = Convert.ToString(indata.Substring(1));
                        lb_temp.Text = temp + " °C";
                        Console.WriteLine(temp);
                        cirPro_temp.Value = Convert.ToInt16(indata.Substring(1));
                        break;
                    // umidità
                    case 'u':
                        humidity = Convert.ToString(indata.Substring(1));
                        lb_hum.Text = String.Format("{0:0.00}", humidity + " %");
                        cirPro_umi.Value = Convert.ToInt16(indata.Substring(1));
                        break;
                    // allarme attivo
                    case 'a':
                        lb_allarme.Text = "ON";
                        allarmeOn = true;
                        DisattivaBottoni();
                        //btn_LuceStanza.Enabled = false;
                        //btn_LuceBagno.Enabled = false;
                        //btn_LuceLetto.Enabled = false;
                        //btn_Aggiorna.Enabled = false;
                        break;
                    //allarme disattivo
                    case 'd':
                        lb_allarme.Text = "OFF";
                        allarmeOn = false;
                        DisattivaBottoni();
                        //btn_LuceStanza.Enabled = true;
                        //btn_LuceBagno.Enabled = true;
                        //btn_LuceLetto.Enabled = true;
                        //btn_Aggiorna.Enabled = true;
                        break;
                    //luce stanza accesa
                    case 'q':
                        pb_LuceStanza.Image = Properties.Resources.lamp_on;
                        luceStanzaSpento = false;
                        break;
                    //luce stanza spenta
                    case 'w':
                        pb_LuceStanza.Image = Properties.Resources.lamp__off;
                        luceStanzaSpento = true;
                        break;
                    // apertura cancello 
                    case 'o':
                        pb_lucchetto.Image = Properties.Resources.unlocked1;
                        break;
                    //chiusura cancello
                    case 'c':
                        pb_lucchetto.Image = Properties.Resources.padlock;
                        break;
                    // ventola accessa
                    case 'v':
                        pb_fan.Image = Properties.Resources.fan_On;
                        break;
                    // ventola spenta
                    case 'f':
                        pb_fan.Image = Properties.Resources.fan_Off;
                        break;
                    //tv on
                    case 'b':                       
                        if(tvAccesa)
                        {
                            pb_tv.Image = Properties.Resources.tv_spenta;
                            tvAccesa = false;
                        }
                        else
                        {
                            pb_tv.Image = Properties.Resources.tv_accesa;
                            tvAccesa = true;
                        }
                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void DisattivaBottoni()
        {
            if (allarmeOn)
            {
                btn_LuceStanza.Enabled = false;
                btn_LuceBagno.Enabled = false;
                btn_LuceLetto.Enabled = false;
                btn_Aggiorna.Enabled = false;
            }else
            {
                btn_LuceStanza.Enabled = true;
                btn_LuceBagno.Enabled = true;
                btn_LuceLetto.Enabled = true;
                btn_Aggiorna.Enabled = true;
            }
        }

        private void btn_LuceStanza_Click(object sender, EventArgs e)
        {
            try
            {
                if (luceStanzaSpento)
                {
                    pb_LuceStanza.Image = Properties.Resources.lamp_on;
                    luceStanzaSpento = false;
                    serialPort2.Write("A");
                }
                else
                {
                    pb_LuceStanza.Image = Properties.Resources.lamp__off;
                    luceStanzaSpento = true;
                    serialPort2.Write("B");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_LuceBagno_Click(object sender, EventArgs e)
        {
            if (luceBagnoSpento)
            {
                pb_LuceBagno.Image = Properties.Resources.lamp_on;
                luceBagnoSpento = false;
            }
            else
            {
                pb_LuceBagno.Image = Properties.Resources.lamp__off;
                luceBagnoSpento = true;
            }
        }

        private void btn_LuceLetto_Click(object sender, EventArgs e)
        {
            if (luceLettoSpento)
            {
                pb_LuceLetto.Image = Properties.Resources.lamp_on;
                luceLettoSpento = false;
            }
            else
            {
                pb_LuceLetto.Image = Properties.Resources.lamp__off;
                luceLettoSpento = true;
            }
        }

        private void btn_Aggiorna_Click(object sender, EventArgs e)
        {
            //serialPort2.Open();
            string nuovoSetPoint;
            nuovoSetPoint = "S" + textBox1.Text;
            serialPort2.Write(nuovoSetPoint);
           // serialPort2.Close();
        }

        private void rbt_temaChiaro_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
            panel2.BackColor = Color.AliceBlue;
            panel3.BackColor = Color.AliceBlue;

            btn_Aggiorna.ForeColor = Color.Black;

            gb_info.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;

            rbt_temaChiaro.ForeColor = Color.Black;
            rbt_temaScuro.ForeColor = Color.Black;
            gb_impostazioni.ForeColor = Color.Black;
            Allarme.ForeColor = Color.Black;
            gb_temp.ForeColor = Color.Black;

            cirPro_temp.InnerColor = Color.AliceBlue;
            cirPro_umi.InnerColor = Color.AliceBlue;

            lb_hum.ForeColor = Color.Black;
            l_temp.ForeColor = Color.Black;
            lb_temp.ForeColor = Color.Black;
            l_umid.ForeColor = Color.Black;
        }

        private void rbt_temaScuro_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromKnownColor(KnownColor.WindowFrame);
            panel2.BackColor = Color.FromKnownColor(KnownColor.WindowFrame);
            panel3.BackColor = Color.FromKnownColor(KnownColor.WindowFrame);

            btn_Aggiorna.ForeColor = Color.Black;

            gb_info.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;

            rbt_temaChiaro.ForeColor = Color.White;
            rbt_temaScuro.ForeColor = Color.White;
            gb_impostazioni.ForeColor = Color.White;
            Allarme.ForeColor = Color.White;
            gb_temp.ForeColor = Color.White;

            cirPro_temp.InnerColor = Color.FromKnownColor(KnownColor.WindowFrame);
            cirPro_umi.InnerColor = Color.FromKnownColor(KnownColor.WindowFrame);

            lb_hum.ForeColor = Color.White;
            l_temp.ForeColor = Color.White;
            lb_temp.ForeColor = Color.White;
            l_umid.ForeColor = Color.White;
        }
    }
}
