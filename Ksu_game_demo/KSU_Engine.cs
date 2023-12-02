using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu_game_demo
{
    public partial class KSU_Engine : Form
    {
        public string fileLoc = "";
        SoundPlayer soundPlayer = new SoundPlayer();
        public KSU_Engine(string fileLoc)
        {
            InitializeComponent();
            this.fileLoc = fileLoc;
            KeytoPressLB.Text = "";
        }

        private void KSU_Engine_Load(object sender, EventArgs e)
        {
            soundPlayer.SoundLocation = File.ReadAllLines(fileLoc)[0];
            soundPlayer.Play();
            Action action = () => { StartKeyGame(); };
            Task t = new Task(action);
            t.Start();
            Action pointsAction = () => { PointsFunc(); };
            Task pointsTask = new Task(pointsAction);
            pointsTask.Start();
        }

        Task StartKeyGame()
        {
            string[] lines = File.ReadAllLines(fileLoc)[1..];
            foreach (string line in lines)
            {
                
                string timing = line.Split("-")[0];
                string key = line.Split("-")[1];
                Thread.Sleep(Convert.ToInt32(Math.Round(Convert.ToDouble(timing) * 1000)));
                Action action = () => { KeytoPressLB.Text = key; };
                Invoke(action);
            }
            return null;
        }

        Task PointsFunc()
        {
            //while (true)
            //{
            //    if (KeytoPressLB.Text == "") continue;

            //    char keyPressed = 'A'; // Replace 'A' with the desired key

            //    if (keyPressed == KeytoPressLB.Text.ToCharArray()[0])
            //    {
            //        Action action = () => { pointsLB.Text = $"{Convert.ToInt32(pointsLB.Text) + 5}"; };
            //        Invoke(action);
            //    }
            //    else
            //    {
            //        Action action = () => { pointsLB.Text = $"{Convert.ToInt32(pointsLB.Text) - 2}"; };
            //        Invoke(action);
            //    }
            //}
            //// Note: Returning null doesn't make sense for a Task, consider changing the return type.
            return null;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedKey = e.KeyChar;

            if (KeytoPressLB.Text.Length > 0 && pressedKey == KeytoPressLB.Text[0])
            {
                Action action = () => { pointsLB.Text = $"{Convert.ToInt32(pointsLB.Text) + 5}"; };
                Action action2 = async () => { KeytoPressLB.ForeColor = Color.Green; await Task.Delay(100); KeytoPressLB.ForeColor = Color.White; };
                Invoke(action);
                Task t = new Task(() => { Invoke(action2); });
                t.Start();
            }
            else
            {
                Action action = () => { pointsLB.Text = $"{Convert.ToInt32(pointsLB.Text) - 2}";};
                Action action2 = async () => { KeytoPressLB.ForeColor = Color.Red; await Task.Delay(100); KeytoPressLB.ForeColor = Color.White; };
                Invoke(action);
                Task t = new Task(() => { Invoke(action2); });
                t.Start();
            }
        }

        private void KSU_Engine_FormClosing(object sender, FormClosingEventArgs e)
        {
            soundPlayer.Stop();
            soundPlayer.Dispose();
        }
    }
}
