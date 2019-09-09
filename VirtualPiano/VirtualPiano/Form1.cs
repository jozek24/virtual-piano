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
            {"C3",false }, { "C#3",false }, { "D3",false },{ "D#3",false },
            { "E3",false }, { "F3",false },  { "F#3",false }, { "G3",false },
            { "G#3",false },{ "A3",false },{ "A#3",false }, { "B3",false },
            { "C4",false }, { "C#4",false },{ "D4",false },{ "D#4",false },
            { "E4",false }, { "F4",false },{ "F#4",false }, { "G4",false },
            { "G#4",false }, { "A4",false },{ "A#4",false }, { "B4",false },
            { "C5",false }
        };
        private WaveOutEvent outputDevice;
        private ISampleProvider sampleProvider;
        private MixingSampleProvider mixer;

        string tembre = "GrandPiano";

        public Form1()
        {
            InitializeComponent();
            grandPianoCheckBox.Checked = true;
            sustainCheckBox.Checked = true;
            outputDevice = new WaveOutEvent();
            mixer = new MixingSampleProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2))
            {
                ReadFully = true
            };
            outputDevice.Init(mixer);
            outputDevice.Play();
        }

        #region keyUp and keyDown
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            e.Handled = true;


            switch (e.KeyCode)
            {
                case Keys.Space:
                    {
                        sustainCheckBox.Checked = !sustainCheckBox.Checked;
                        break;
                    }
                case Keys.Z: C3Key_MouseDown(c3Key, null); break;
                case Keys.S: Cis3Key_MouseDown(cis3Key, null); break;
                case Keys.X: D3Key_MouseDown(d3Key, null); break;
                case Keys.D: Dis3Key_MouseDown(dis3Key, null); break;
                case Keys.C: E3Key_MouseDown(e3Key, null); break;
                case Keys.V: F3Key_MouseDown(f3Key, null); break;
                case Keys.G: Fis3Key_MouseDown(fis3Key, null); break;
                case Keys.B: G3Key_MouseDown(g3Key, null); break;
                case Keys.H: Gis3Key_MouseDown(gis3Key, null); break;
                case Keys.N: A3Key_MouseDown(a3Key, null); break;
                case Keys.J: Ais3Key_MouseDown(ais3Key, null); break;
                case Keys.M: B3Key_MouseDown(b3Key, null); break;
                case Keys.Q: C4Key_MouseDown(c4Key, null); break;
                case Keys.D2: Cis4Key_MouseDown(cis4Key, null); break;
                case Keys.W: D4Key_MouseDown(d4Key, null); break;
                case Keys.D3: Dis4Key_MouseDown(dis4Key, null); break;
                case Keys.E: E4Key_MouseDown(e4Key, null); break;
                case Keys.R: F4Key_MouseDown(f4Key, null); break;
                case Keys.D5: Fis4Key_MouseDown(fis4Key, null); break;
                case Keys.T: G4Key_MouseDown(g4Key, null); break;
                case Keys.D6: Gis4Key_MouseDown(gis4Key, null); break;
                case Keys.Y: A4Key_MouseDown(a4Key, null); break;
                case Keys.D7: Ais4Key_MouseDown(ais4Key, null); break;
                case Keys.U: B4Key_MouseDown(b4Key, null); break;
                case Keys.I: C5Key_MouseDown(c5Key, null); break;
                default: e.Handled = true; break;
            };
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            switch (e.KeyCode)
            {
                case Keys.Z: C3Key_MouseUp(c3Key, null); break;
                case Keys.S: Cis3Key_MouseUp(cis3Key, null); break;
                case Keys.X: D3Key_MouseUp(d3Key, null); break;
                case Keys.D: Dis3Key_MouseUp(dis3Key, null); break;
                case Keys.C: E3Key_MouseUp(e3Key, null); break;
                case Keys.V: F3Key_MouseUp(f3Key, null); break;
                case Keys.G: Fis3Key_MouseUp(fis3Key, null); break;
                case Keys.B: G3Key_MouseUp(g3Key, null); break;
                case Keys.H: Gis3Key_MouseUp(gis3Key, null); break;
                case Keys.N: A3Key_MouseUp(a3Key, null); break;
                case Keys.J: Ais3Key_MouseUp(ais3Key, null); break;
                case Keys.M: B3Key_MouseUp(b3Key, null); break;
                case Keys.Q: C4Key_MouseUp(c4Key, null); break;
                case Keys.D2: Cis4Key_MouseUp(cis4Key, null); break;
                case Keys.W: D4Key_MouseUp(d4Key, null); break;
                case Keys.D3: Dis4Key_MouseUp(dis4Key, null); break;
                case Keys.E: E4Key_MouseUp(e4Key, null); break;
                case Keys.R: F4Key_MouseUp(f4Key, null); break;
                case Keys.D5: Fis4Key_MouseUp(fis4Key, null); break;
                case Keys.T: G4Key_MouseUp(g4Key, null); break;
                case Keys.D6: Gis4Key_MouseUp(gis4Key, null); break;
                case Keys.Y: A4Key_MouseUp(a4Key, null); break;
                case Keys.D7: Ais4Key_MouseUp(ais4Key, null); break;
                case Keys.U: B4Key_MouseUp(b4Key, null); break;
                case Keys.I: C5Key_MouseUp(c5Key, null); break;
                default: e.Handled = true; break;
            };
        }
        #endregion

        private void PlayKeySound(string tone, object sender)
        {
            if (isPressed[tone] == true) return;
            isPressed[tone] = true;
            sampleProvider = new AudioFileReader($@"..\..\Resources\{tembre}\{tone}.wav");
            mixer.AddMixerInput(sampleProvider);

            Button button = sender as Button;
            if (button != null)
                button.BackColor = Color.LightBlue;
        }
        private void StopTone(string tone, object sender)
        {
            isPressed[tone] = false;
            if (sustainCheckBox.Checked == false)
                mixer.RemoveMixerInput(sampleProvider);

            if (tone.Contains("#"))
            {
                Button button1 = sender as Button;
                if (button1 != null)
                    button1.BackColor = Color.Black;
                return;
            }
            Button button = sender as Button;
            if (button != null)
                button.BackColor = Color.FromArgb(224, 224, 224);
        }

        #region buttons
        private void C3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("C3", sender);
        private void C3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("C3", sender);
        private void Cis3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("C#3", sender);
        private void Cis3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("C#3", sender);
        private void D3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("D3", sender);
        private void D3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("D3", sender);
        private void Dis3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("D#3", sender);
        private void Dis3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("D#3", sender);
        private void E3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("E3", sender);
        private void E3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("E3", sender);
        private void F3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("F3", sender);
        private void F3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("F3", sender);
        private void Fis3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("F#3", sender);
        private void Fis3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("F#3", sender);
        private void G3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("G3", sender);
        private void G3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("G3", sender);
        private void Gis3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("G#3", sender);
        private void Gis3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("G#3", sender);
        private void A3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("A3", sender);
        private void A3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("A3", sender);
        private void Ais3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("A#3", sender);
        private void Ais3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("A#3", sender);
        private void B3Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("B3", sender);
        private void B3Key_MouseUp(object sender, MouseEventArgs e) => StopTone("B3", sender);
        private void C4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("C4", sender);
        private void C4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("C4", sender);
        private void Cis4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("C#4", sender);
        private void Cis4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("C#4", sender);
        private void D4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("D4", sender);
        private void D4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("D4", sender);
        private void Dis4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("D#4", sender);
        private void Dis4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("D#4", sender);
        private void E4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("E4", sender);
        private void E4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("E4", sender);
        private void F4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("F4", sender);
        private void F4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("F4", sender);
        private void Fis4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("F#4", sender);
        private void Fis4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("F#4", sender);
        private void G4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("G4", sender);
        private void G4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("G4", sender);
        private void Gis4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("G#4", sender);
        private void Gis4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("G#4", sender);
        private void A4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("A4", sender);
        private void A4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("A4", sender);
        private void Ais4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("A#4", sender);
        private void Ais4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("A#4", sender);
        private void B4Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("B4", sender);
        private void B4Key_MouseUp(object sender, MouseEventArgs e) => StopTone("B4", sender);
        private void C5Key_MouseDown(object sender, MouseEventArgs e) => PlayKeySound("C5", sender);
        private void C5Key_MouseUp(object sender, MouseEventArgs e) => StopTone("C5", sender);
        #endregion

        private void GrandPianoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (grandPianoCheckBox.Checked != true)
            {
                SynthesizedCheckBox.Checked = true;
                return;
            }
            SynthesizedCheckBox.Checked = false;
            tembre = "GrandPiano";
        }
        private void SynthesizedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SynthesizedCheckBox.Checked != true)
            {
                grandPianoCheckBox.Checked = true;
                return;
            }
            grandPianoCheckBox.Checked = false;
            tembre = "SynthesizedPiano";
        }
    }
}