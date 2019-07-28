using System;
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
using System.Speech.Recognition;
using System.Threading;

namespace VoiceRecognization
{
    public partial class Form1 : Form
    {
        //Form Declarations...
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtContents_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start ( button click )
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            clist.Add(new string[] { "hello", "how are you", "what is the current time", "open chrome", "thank you", "close" });
            Grammar gr = new Grammar(new GrammarBuilder(clist));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

            void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            {
                switch (e.Result.Text.ToString())
                {
                    case "hello":
                        ss.SpeakAsync("Hello Sakief");
                        break;
                    case "how are you":
                        ss.SpeakAsync("I am doing great");
                        break;
                    case "what is the current time":
                        ss.SpeakAsync("Current time is " +DateTime.Now.ToLongTimeString());
                        break;
                    case "thank you":
                        ss.SpeakAsync("Pleasure is mine");
                        break;
                   // case "open chrome":
                       // Process.Start("chrome","https://www.google.com/");
                       // break;
                    case "close":
                        Application.Exit();
                        break;




                }
                txtContents.Text += e.Result.Text.ToString() + Environment.NewLine;
            }

        private void btnStop_Click(object sender, EventArgs e)
        {
                  sre.RecognizeAsyncStop();
                  btnStart.Enabled=true;
                  btnStop.Enabled=false;
                  
        }
        }
    }


