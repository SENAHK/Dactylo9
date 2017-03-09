using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dactylo9
{
    public partial class mainFrm : Form
    {

        private T9Keyboard _keyboard;
        private Stopwatch sw = new Stopwatch();

        public Stopwatch sw2 = new Stopwatch();
        public int actualPressedKey = 0;
        int cpt = -1;
        int lastPressedKey = 0;

        KeyEventArgs ev = new KeyEventArgs(Keys.A);

        public Stopwatch Sw
        {
            get { return sw; }
            set { sw = value; }
        }

        public T9Keyboard Keyboard
        {
            get { return _keyboard; }
            set { _keyboard = value; }
        }

        public mainFrm()
        {
            InitializeComponent();
            this.Keyboard = new T9Keyboard();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            if (!tmTheTimer.Enabled)
            {
                tmTheTimer.Start();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //tbxInput.Text += this.Keyboard.Keys[0].Tap();
        }


        private void mainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            this.Sw.Start();
            if (!sw2.IsRunning)
            {
                this.sw2.Start();
            }

            cpt += 1;
            ev = e;
        }

        private void mainFrm_KeyUp(object sender, KeyEventArgs e)
        {            


            lastPressedKey = actualPressedKey;
            this.Sw.Stop();

            var elapsed = Sw.ElapsedMilliseconds;

            Keys[] vals = {
                              Keys.NumPad7,
                              Keys.NumPad8,
                              Keys.NumPad9,
                              Keys.NumPad4,
                              Keys.NumPad5,
                              Keys.NumPad6,
                              Keys.NumPad1,
                              Keys.NumPad2,
                              Keys.NumPad3,
                              Keys.NumPad0
                           };
            // 
            for (int i = 0; i < vals.Length; i++)
            {
                if (e.KeyData == vals[i])
                {
                    actualPressedKey = i;
                    this.sw.Restart();
                    break;
                }
            }

            //The key is maintained
            if (elapsed > 1000)
            {
                //this.sw2.Reset();
                //this.sw2.Stop();
            }
           
            // The user pressed an another key while stil selecting
            if (actualPressedKey != lastPressedKey && sw2.ElapsedMilliseconds > 500)
            {
                Debug.Print("is in");
                tbxInput.Text += this.Keyboard.Keys[lastPressedKey].Tap(cpt);
                sw2.Reset();
                sw2.Stop();
                cpt = -1;
                lastPressedKey = actualPressedKey;
                mainFrm_KeyDown(sender, ev);
            }
        }


        private void tmTheTimer_Tick(object sender, EventArgs e)
        {
            // Interval where the user can choose the character 
            var tElapsed = sw2.ElapsedMilliseconds;
            lblErrors.Text = tElapsed.ToString();

            if (tElapsed > 2000)
            {
                // Write the character
                tbxInput.Text += this.Keyboard.Keys[actualPressedKey].Tap(cpt);
               
                // Reset the timer and the number of times the user keypressed
                sw2.Reset();
                sw2.Stop();
                cpt = -1;
            }

            lblTimeElapsed.Text = sw2.ElapsedMilliseconds.ToString();
            Debug.Print(lastPressedKey + " act | " + actualPressedKey);
        }


    }
}
