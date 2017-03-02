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

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //tbxInput.Text += this.Keyboard.Keys[0].Tap();
        }


        private void mainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            this.Sw.Start();
        }

        private void mainFrm_KeyUp(object sender, KeyEventArgs e)
        {
            this.Sw.Stop();

            var elapsed = Sw.ElapsedMilliseconds;
            //lblTimeElapsed.Text = elapsed.ToString();

            switch (e.KeyData)
            {
                case Keys.NumPad7:
                    {
                        if (elapsed > 1000)
                        {
                            tbxInput.Text += this.Keyboard.Keys[0].Tap();
                            elapsed = 0;
                        }
                    }
                    break;
                case Keys.NumPad8:
                    {
                        if (elapsed > 1000)
                        {
                            tbxInput.Text += this.Keyboard.Keys[1].Tap();
                            elapsed = 0;
                        }
                    }
                    break;
            }
        }


        private void tmTheTimer_Tick(object sender, EventArgs e)
        {
            // Réinitialiser le chrono après un certain temps
            var elapsed = Sw.ElapsedMilliseconds;
            if (elapsed > 3000)
            {
                this.Sw.Reset();
            }
        }


    }
}
