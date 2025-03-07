using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using WMPLib;

namespace DDR
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private WindowsMediaPlayer player;
        bool premuto = true;
        int punteggio = 100;
        int s;


        public Form1()
        {
            InitializeComponent();
            //imposto musica
            player = new WindowsMediaPlayer();
            player.URL = @"C:\Users\Eros\Desktop\PROGRAMMAZIONE\progetti_C#\DanceDanceRevolution\DDR\DDR\Resources\cosi-ghiacciato-tony.wav";
            player.settings.setMode("loop", true);
            player.controls.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Azioni per i pulsanti
        private void btn_up_Click(object sender, EventArgs e)
        {
            if (s == 1)
            {
                btn_up.Image = global::DDR.Properties.Resources.UpOn;
                premuto = true;
            }
            else
            {
                premuto = false;
                btn_up.BackColor = Color.Red;
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (s == 4)
            {
                btn_left.Image = global::DDR.Properties.Resources.LeftOn;
                premuto = true;
            }
            else
            {
                premuto = false;
                btn_left.BackColor = Color.Red;
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (s == 3)
            {
                btn_down.Image = global::DDR.Properties.Resources.DownOn;
                premuto = true;
            }
            else
            {
                premuto = false;
                btn_down.BackColor = Color.Red;
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (s == 2)
            {
                btn_right.Image = global::DDR.Properties.Resources.RightOn;
                premuto = true;
            }
            else
            {
                premuto = false;
                btn_right.BackColor = Color.Red;
            }
        }


        //Funzione che aggiorna e controlla ad ogni secondo
        private async void Timer_Tick(object sender, EventArgs e) // funzione che controlla ad ogni timer.Interval asicntrona perche senno non posso mettere il timer dentro
        {
            btn_left.BackColor = Color.Transparent;
            btn_up.BackColor = Color.Transparent;
            btn_right.BackColor = Color.Transparent;
            btn_down.BackColor = Color.Transparent;

            if (premuto && punteggio >= 0)
            {
                await Task.Delay(100);
                await accrnd(); // Accendi un pulsante random ogni secondo
                punteggio += 1;
            }
            else
            {
                punteggio -= 1;
            }

            lbl_punteggio.Text = "Punteggio " + punteggio.ToString();


            if (punteggio < 0)
            {
                lbl_punteggio.Text = "Hai Perso!";
                timer.Stop();
                btn_Start.Text = "Start";
                btn_up.Image = null;
                btn_right.Image = null;
                btn_down.Image = null;
                btn_left.Image = null;
                punteggio = 0;
            }
            premuto = false;
        }

        //Funzione per accendere un pulsante random
        private async Task accrnd()
        {
            Random rnd = new Random();

            s = rnd.Next(1, 5);
            // Resetta tutte le immagini prima di impostarne una nuova

            btn_up.Image = null;
            btn_right.Image = null;
            btn_down.Image = null;
            btn_left.Image = null;
            switch (s)
            {
                case 1:
                    btn_up.Image = global::DDR.Properties.Resources.UpOff;
                    break;
                case 2:
                    btn_right.Image = global::DDR.Properties.Resources.RightOff;
                    break;
                case 3:
                    btn_down.Image = global::DDR.Properties.Resources.DownOff;
                    break;
                case 4:
                    btn_left.Image = global::DDR.Properties.Resources.LeftOff;
                    break;
            }
        }

        //Pulsante Start
        private void button2_Click(object sender, EventArgs e)
        {
            btn_up.Image = null;
            btn_right.Image = null;
            btn_down.Image = null;
            btn_left.Image = null;
            if (btn_Start.Text == "Start")
            {
                accrnd();
                punteggio = 0;
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 800;
                timer.Tick += Timer_Tick;
                timer.Start();
                btn_Start.Text = "Stop";
                lbl_punteggio.Text = "Punteggio " + punteggio.ToString();
            }
            else
            {
                timer.Stop();
                btn_Start.Text = "Start";
                btn_up.Image = null;
                btn_right.Image = null;
                btn_down.Image = null;
                btn_left.Image = null;
            }
        }

    }
}
