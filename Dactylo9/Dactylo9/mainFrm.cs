﻿using System;
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
        private SqlConnector dbConnection;
        private T9Keyboard _keyboard;
        private Stopwatch sw2;
        private Stopwatch sw;
        public int actualPressedKey;
        private int lastPressedKey;
        private int cpt;
        private bool rightKey;
        KeyEventArgs ev;
        private Random rnd;
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
            this.ev = new KeyEventArgs(Keys.A); 
            this.dbConnection = new SqlConnector();
            this.Keyboard = new T9Keyboard();
            this.sw = new Stopwatch();
            this.rightKey = false;
            this.sw2 = new Stopwatch();
            this.actualPressedKey = 0;
            this.cpt = -1;
            this.lastPressedKey = 0;
            this.rnd = new Random();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            tbxInput.Focus();
            tbxTextSample.Text = GetRandomTextSample(this.dbConnection.SelectTexts(), rnd);

            if (!tmTheTimer.Enabled)
            {
                tmTheTimer.Start();
            }
        }

        public string GetRandomTextSample(List<string> samples, Random rnd)
        {
            int offset = rnd.Next(0, samples.Count);
            return samples[offset];
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }


        private void tmTheTimer_Tick(object sender, EventArgs e)
        {

            if (rightKey)
            {
                // Interval where the user can choose the character 
                var tElapsed = sw2.ElapsedMilliseconds;
                lblErrors.Text = tElapsed.ToString();

                if (tElapsed > 2000)
                {
                    char userInput = Convert.ToChar(this.Keyboard.Keys[actualPressedKey].Tap(cpt));
                    int actualPosition = tbxInput.Text.Length;
                    if (userInput == tbxTextSample.Text[actualPosition])
                    {
                        // Write the character
                        tbxInput.Text += this.Keyboard.Keys[actualPressedKey].Tap(cpt);
                        
                    }
                    cpt = -1;
                    // Reset the timer and the number of times the user keypressed
                    sw2.Reset();
                    sw2.Stop();
                    
                }

                lblTimeElapsed.Text = sw2.ElapsedMilliseconds.ToString();
                Debug.Print(lastPressedKey + " act | " + actualPressedKey);
            }
            tbxInput.SelectionStart = tbxInput.Text.Length;
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            this.Sw.Start();
            if (!sw2.IsRunning)
            {
                this.sw2.Start();
            }
            cpt += 1;
            ev = e;
        }

        private void tbxInput_KeyUp(object sender, KeyEventArgs e)
        {
            tbxInput.SelectionStart = tbxInput.Text.Length;
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

            for (int i = 0; i < vals.Length; i++)
            {
                if (e.KeyData == vals[i])
                {
                    actualPressedKey = i;
                    this.sw.Restart();
                    rightKey = true;
                    break;
                }
            }

            if (rightKey)
            {
                //The key is maintained
                if (elapsed > 1000)
                {
                    //this.sw2.Reset();
                    //this.sw2.Stop();
                }

                // The user pressed an another key while still selecting
                if ((actualPressedKey != lastPressedKey) && (sw2.ElapsedMilliseconds > 500))
                {
                    char userInput = Convert.ToChar(this.Keyboard.Keys[lastPressedKey].Tap(cpt - 1));
                    int actualPosition = tbxInput.Text.Length;

                    Debug.Print(actualPosition.ToString());

                    if (userInput == tbxTextSample.Text[actualPosition])
                    {
                        tbxInput.Text += userInput.ToString();
                    }

                    sw2.Reset();
                    sw2.Stop();
                    cpt = -1;
                    lastPressedKey = actualPressedKey;
                    tbxInput_KeyDown(sender, ev);
                }
            }
        }


    }
}
