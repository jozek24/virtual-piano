using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VirtualPiano
{
    public partial class Form1 : Form
    {
        Dictionary<string, bool> isPressed = new Dictionary<string, bool>()
        {
            {"C4",false },
            { "Cis4",false },
            { "D4",false },
            { "Dis4",false },
            { "E4",false },
            { "F4",false },
            { "Fis4",false },
            { "G4",false },
            { "Gis4",false },
            { "A4",false },
            { "Ais4",false },
            { "B4",false },
            { "C5",false },
            { "Cis5",false },
            { "D5",false },
            { "Dis5",false },
            { "E5",false },
            { "F5",false },
            { "Fis5",false },
            { "G5",false },
            { "Gis5",false },
            { "A5",false },
            { "Ais5",false },
            { "B5",false },
            { "C6",false }

        };
        private WaveOutEvent outputDevice;
        private WaveFileReader audioFile;
        private MixingSampleProvider mixer;

        public Form1()
        {
            InitializeComponent();

            outputDevice = new WaveOutEvent();
            mixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2))
            {
                ReadFully = true  //ustawia niekończączy się stream
            };
            outputDevice.Init(mixer);
            outputDevice.Play();
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            
            
            switch (e.KeyCode)
            {
                case Keys.Z: C4Key_MouseDown(null, null); break;
                case Keys.S: Cis4Key_MouseDown(null, null); break;
                case Keys.X: D4Key_MouseDown(null, null); break;
                case Keys.D: Dis4Key_MouseDown(null, null); break;
                case Keys.C: E4Key_MouseDown(null, null); break;
                case Keys.V: F4Key_MouseDown(null, null); break;
                case Keys.G: Fis4Key_MouseDown(null, null); break;
                case Keys.B: G4Key_MouseDown(null, null); break;
                case Keys.H: Gis4Key_MouseDown(null, null); break;
                case Keys.N: A4Key_MouseDown(null, null); break;
                case Keys.J: Ais4Key_MouseDown(null, null); break;
                case Keys.M: B4Key_MouseDown(null, null); break;
                case Keys.Q: C5Key_MouseDown(null, null); break;
                case Keys.D2: Cis5Key_MouseDown(null, null); break;
                case Keys.W: D5Key_MouseDown(null, null); break;
                case Keys.D3: Dis5Key_MouseDown(null, null); break;
                case Keys.E: E5Key_MouseDown(null, null); break;
                case Keys.R: F5Key_MouseDown(null, null); break;
                case Keys.D5: Fis5Key_MouseDown(null, null); break;
                case Keys.T: G5Key_MouseDown(null, null); break;
                case Keys.D6: Gis5Key_MouseDown(null, null); break;
                case Keys.Y: A5Key_MouseDown(null, null); break;
                case Keys.D7: Ais5Key_MouseDown(null, null); break;
                case Keys.U: B5Key_MouseDown(null, null); break;
                case Keys.I: C6Key_MouseDown(null, null); break;
                default: e.Handled = true; break;
            };
        }

       
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            switch (e.KeyCode)
            {
              //  case Keys.S: Break;
                case Keys.Z: C4Key_MouseUp(null, null); break;
                case Keys.S: Cis4Key_MouseUp(null, null); break;
                case Keys.X: D4Key_MouseUp(null, null); break;
                case Keys.D: Dis4Key_MouseUp(null, null); break;
                case Keys.C: E4Key_MouseUp(null, null); break;
                case Keys.V: F4Key_MouseUp(null, null); break;
                case Keys.G: Fis4Key_MouseUp(null, null); break;
                case Keys.B: G4Key_MouseUp(null, null); break;
                case Keys.H: Gis4Key_MouseUp(null, null); break;
                case Keys.N: A4Key_MouseUp(null, null); break;
                case Keys.J: Ais4Key_MouseUp(null, null); break;
                case Keys.M: B4Key_MouseUp(null, null); break;
                case Keys.Q: C5Key_MouseUp(null, null); break;
                case Keys.D2: Cis5Key_MouseUp(null, null); break;
                case Keys.W: D5Key_MouseUp(null, null); break;
                case Keys.D3: Dis5Key_MouseUp(null, null); break;
                case Keys.E: E5Key_MouseUp(null, null); break;
                case Keys.R: F5Key_MouseUp(null, null); break;
                case Keys.D5: Fis5Key_MouseUp(null, null); break;
                case Keys.T: G5Key_MouseUp(null, null); break;
                case Keys.D6: Gis5Key_MouseUp(null, null); break;
                case Keys.Y: A5Key_MouseUp(null, null); break;
                case Keys.D7: Ais5Key_MouseUp(null, null); break;
                case Keys.U: B5Key_MouseUp(null, null); break;
                case Keys.I: C6Key_MouseUp(null, null); break;
                default: e.Handled = true; break;
            };
        }
    
        private void C4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["C4"] == true) return;
            isPressed["C4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._1C4);
            mixer.AddMixerInput(audioFile);
            c4Key.BackColor = Color.Red;
        }


        private void C4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["C4"] = false;
            c4Key.BackColor = Color.White;
        }

        private void Cis4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Cis4"] == true) return;
            isPressed["Cis4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._2Cis4);
            mixer.AddMixerInput(audioFile);
            cis4Key.BackColor = Color.Red;
        }

        private void Cis4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Cis4"] = false;
            cis4Key.BackColor = Color.Black;
        }

        private void D4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["D4"] == true) return;
            isPressed["D4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._3D4);
            mixer.AddMixerInput(audioFile);
            d4Key.BackColor = Color.Red;
        }

        private void D4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["D4"] = false;
            d4Key.BackColor = Color.White;
        }

        private void Dis4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Dis4"] == true) return;
            isPressed["Dis4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._4Dis4);
            mixer.AddMixerInput(audioFile);
            dis4Key.BackColor = Color.Red;
        }

        private void Dis4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Dis4"] = false;
            dis4Key.BackColor = Color.Black;
        }

        private void E4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["E4"] == true) return;
            isPressed["E4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._5E4);
            mixer.AddMixerInput(audioFile);
            e4Key.BackColor = Color.Red;
        }

        private void E4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["E4"] = false;
            e4Key.BackColor = Color.White;
        }

        private void F4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["F4"] == true) return;
            isPressed["F4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._6F4);
            mixer.AddMixerInput(audioFile);
            f4Key.BackColor = Color.Red;
        }

        private void F4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["F4"] = false;
            f4Key.BackColor = Color.White;
        }

        private void Fis4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Fis4"] == true) return;
            isPressed["Fis4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._7Fis4);
            mixer.AddMixerInput(audioFile);
            fis4Key.BackColor = Color.Red;
        }

        private void Fis4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Fis4"] = false;
            fis4Key.BackColor = Color.Black;
        }

        private void G4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["G4"] == true) return;
            isPressed["G4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._8G4);
            mixer.AddMixerInput(audioFile);
            g4Key.BackColor = Color.Red;
        }

        private void G4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["G4"] = false;
            g4Key.BackColor = Color.White;
        }

        private void Gis4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Gis4"] == true) return;
            isPressed["Gis4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._9Gis4);
            mixer.AddMixerInput(audioFile);
            gis4Key.BackColor = Color.Red;
        }

        private void Gis4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Gis4"] = false;
            gis4Key.BackColor = Color.Black;
        }

        private void A4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["A4"] == true) return;
            isPressed["A4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._10A4);
            mixer.AddMixerInput(audioFile);
            a4Key.BackColor = Color.Red;
        }

        private void A4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["A4"] = false;
            a4Key.BackColor = Color.White;
        }

        private void Ais4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Ais4"] == true) return;
            isPressed["Ais4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._11Ais4);
            mixer.AddMixerInput(audioFile);
            ais4Key.BackColor = Color.Red;
        }

        private void Ais4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Ais4"] = false;
            ais4Key.BackColor = Color.Black;
        }

        private void B4Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["B4"] == true) return;
            isPressed["B4"] = true;
            audioFile = new WaveFileReader(Properties.Resources._12B4);
            mixer.AddMixerInput(audioFile);
            b4Key.BackColor = Color.Red;
        }

        private void B4Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["B4"] = false;
            b4Key.BackColor = Color.White;
        }

        private void C5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["C5"] == true) return;
            isPressed["C5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._13C5);
            mixer.AddMixerInput(audioFile);
            c5Key.BackColor = Color.Red;
        }

        private void C5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["C5"] = false;
            c5Key.BackColor = Color.White;
        }

        private void Cis5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Cis5"] == true) return;
            isPressed["Cis5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._14Cis5);
            mixer.AddMixerInput(audioFile);
            cis5Key.BackColor = Color.Red;
        }

        private void Cis5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Cis5"] = false;
            cis5Key.BackColor = Color.Black;
        }

        private void D5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["D5"] == true) return;
            isPressed["D5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._15D5);
            mixer.AddMixerInput(audioFile);
            d5Key.BackColor = Color.Red;
        }

        private void D5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["D5"] = false;
            d5Key.BackColor = Color.White;
        }

        private void Dis5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Dis5"] == true) return;
            isPressed["Dis5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._16Dis5);
            mixer.AddMixerInput(audioFile);
            dis5Key.BackColor = Color.Red;
        }

        private void Dis5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Dis5"] = false;
            dis5Key.BackColor = Color.Black;
        }

        private void E5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["E5"] == true) return;
            isPressed["E5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._17E5);
            mixer.AddMixerInput(audioFile);
            e5Key.BackColor = Color.Red;
        }

        private void E5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["E5"] = false;
            e5Key.BackColor = Color.White;
        }

        private void F5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["F5"] == true) return;
            isPressed["F5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._18F5);
            mixer.AddMixerInput(audioFile);
            f5Key.BackColor = Color.Red;
        }

        private void F5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["F5"] = false;
            f5Key.BackColor = Color.White;
        }

        private void Fis5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Fis5"] == true) return;
            isPressed["Fis5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._19Fis5);
            mixer.AddMixerInput(audioFile);
            fis5Key.BackColor = Color.Red;
        }

        private void Fis5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Fis5"] = false;
            fis5Key.BackColor = Color.Black;
        }

        private void G5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["G5"] == true) return;
            isPressed["G5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._20G5);
            mixer.AddMixerInput(audioFile);
            g5Key.BackColor = Color.Red;
        }

        private void G5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["G5"] = false;
            g5Key.BackColor = Color.White;
        }

        private void Gis5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Gis5"] == true) return;
            isPressed["Gis5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._21Gis5);
            mixer.AddMixerInput(audioFile);
            gis5Key.BackColor = Color.Red;
        }

        private void Gis5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Gis5"] = false;
            gis5Key.BackColor = Color.Black;
        }

        private void A5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["A5"] == true) return;
            isPressed["A5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._22A5);
            mixer.AddMixerInput(audioFile);
            a5Key.BackColor = Color.Red;
        }

        private void A5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["A5"] = false;
            a5Key.BackColor = Color.White;
        }

        private void Ais5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["Ais5"] == true) return;
            isPressed["Ais5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._23Ais5);
            mixer.AddMixerInput(audioFile);
            ais5Key.BackColor = Color.Red;
        }

        private void Ais5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["Ais5"] = false;
            ais5Key.BackColor = Color.Black;
        }

        private void B5Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["B5"] == true) return;
            isPressed["B5"] = true;
            audioFile = new WaveFileReader(Properties.Resources._24B5);
            mixer.AddMixerInput(audioFile);
            b5Key.BackColor = Color.Red;
        }

        private void B5Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["B5"] = false;
            b5Key.BackColor = Color.White;
        }

        private void C6Key_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPressed["C6"] == true) return;
            isPressed["C6"] = true;
            audioFile = new WaveFileReader(Properties.Resources._25C6);
            mixer.AddMixerInput(audioFile);
            c6Key.BackColor = Color.Red;
        }

        private void C6Key_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed["C6"] = false;
            c6Key.BackColor = Color.White;
        }
    }
}
