using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Windows.Forms;

namespace VirtualPiano
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private WaveFileReader audioFile;
        private MixingSampleProvider mixer;

        public Form1()
        {
            InitializeComponent();

            outputDevice = new WaveOutEvent();
            mixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2));
            mixer.ReadFully = true;  //ustawia niekończączy się stream
            outputDevice.Init(mixer);
            outputDevice.Play();
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.Z: C4Key_Click(null, null); break;
                case Keys.S: Cis4Key_Click(null, null); break;
                case Keys.X: D4Key_Click(null, null); break;
                case Keys.D: Dis4Key_Click(null, null); break;
                case Keys.C: E4Key_Click(null, null); break;
                case Keys.V: F4Key_Click(null, null); break;
                case Keys.G: Fis4Key_Click(null, null); break;
                case Keys.B: G4Key_Click(null, null); break;
                case Keys.H: Gis4Key_Click(null, null); break;
                case Keys.N: A4Key_Click(null, null); break;
                case Keys.J: Ais4Key_Click(null, null); break;
                case Keys.M: B4Key_Click(null, null); break;
                case Keys.Q: C5Key_Click(null, null); break;
                case Keys.D2: Cis5Key_Click(null, null); break;
                case Keys.W: D5Key_Click(null, null); break;
                case Keys.D3: Dis5Key_Click(null, null); break;
                case Keys.E: E5Key_Click(null, null); break;
                case Keys.R: F5Key_Click(null, null); break;
                case Keys.D5: Fis5Key_Click(null, null); break;
                case Keys.T: G5Key_Click(null, null); break;
                case Keys.D6: Gis5Key_Click(null, null); break;
                case Keys.Y: A5Key_Click(null, null); break;
                case Keys.D7: Ais5Key_Click(null, null); break;
                case Keys.U: B5Key_Click(null, null); break;
                case Keys.I: C6Key_Click(null, null); break;
                default: e.Handled = true; break;
            };
        }

        private void C4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._1C4);
            mixer.AddMixerInput(audioFile);
        }
        private void Cis4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._2Cis4);
            mixer.AddMixerInput(audioFile);
        }

        private void D4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._3D4);
            mixer.AddMixerInput(audioFile);
        }

        private void Dis4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._4Dis4);
            mixer.AddMixerInput(audioFile);                     
        }                                                       
                                                                
        private void E4Key_Click(object sender, EventArgs e)    
        {                                                       
            audioFile = new WaveFileReader(Properties.Resources._5E4);
            mixer.AddMixerInput(audioFile);                     
        }                                                       
                                                                
        private void F4Key_Click(object sender, EventArgs e)    
        {                                                       
            audioFile = new WaveFileReader(Properties.Resources._6F4);
            mixer.AddMixerInput(audioFile);
        }

        private void Fis4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._7Fis4);
            mixer.AddMixerInput(audioFile);
        }

        private void G4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._8G4);
            mixer.AddMixerInput(audioFile);
        }

        private void Gis4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._9Gis4);
            mixer.AddMixerInput(audioFile);
        }

        private void A4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._10A4);
            mixer.AddMixerInput(audioFile);
        }

        private void Ais4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._11Ais4);
            mixer.AddMixerInput(audioFile);
        }

        private void B4Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._12B4);
            mixer.AddMixerInput(audioFile);
        }

        private void C5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._13C5);
            mixer.AddMixerInput(audioFile);
        }

        private void Cis5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._14Cis5);
            mixer.AddMixerInput(audioFile);
        }

        private void D5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._15D5);
            mixer.AddMixerInput(audioFile);
        }

        private void Dis5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._16Dis5);
            mixer.AddMixerInput(audioFile);
        }

        private void E5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._17E5);
            mixer.AddMixerInput(audioFile);
        }

        private void F5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._18F5);
            mixer.AddMixerInput(audioFile);
        }

        private void Fis5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._19Fis5);
            mixer.AddMixerInput(audioFile);
        }

        private void G5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._20G5);
            mixer.AddMixerInput(audioFile);
        }

        private void Gis5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._21Gis5);
            mixer.AddMixerInput(audioFile);
        }
        private void A5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._22A5);
            mixer.AddMixerInput(audioFile);
        }

        private void Ais5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._23Ais5);
            mixer.AddMixerInput(audioFile);
        }

        private void B5Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._24B5);
            mixer.AddMixerInput(audioFile);
        }

        private void C6Key_Click(object sender, EventArgs e)
        {
            audioFile = new WaveFileReader(Properties.Resources._25C6);
            mixer.AddMixerInput(audioFile);
        }
    }
}
