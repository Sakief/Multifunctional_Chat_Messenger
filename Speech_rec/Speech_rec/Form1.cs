﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Speech_rec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Please enter some text first!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(reader!=null)
            {
                if(reader.State==SynthesizerState.Speaking)
                {
                    reader.Pause();

                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(reader!=null)
            {
                reader.Dispose();
            }
        }
    }
}
