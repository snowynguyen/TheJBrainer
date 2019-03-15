using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheJBrainer
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        int diffcnt = 0;
        List<string> dstr = new List<string>() {"Easy", "Medium", "Hard" };
        List<Color> dclr = new List<Color>() { Color.DarkSlateGray, Color.Goldenrod, Color.LightCoral };

        public Form1()
        {
            InitializeComponent();
            string path = Application.StartupPath;
            this.BackgroundImage = new Bitmap(path + @"\Resources\TitleScreen.png");
        }

        /*
        private void StartPairMatchingBtn_Click2(object sender, EventArgs e)
        {
            if (EasyRB.Checked)
            {
                PairMatching pm = new PairMatching(20, 5, 8, 30000);
            }
            else if (MediumRB.Checked)
            {
                PairMatching pm = new PairMatching(30, 4, 10, 40000);
            }
            else if (HardRB.Checked)
            {
                PairMatching pm = new PairMatching(50, 3, 15, 50000);
            }
        }

        private void StartTheFlashBtn_Click2(object sender, EventArgs e)
        {
            if (EasyRB.Checked)
            {
                TheFlash tf = new TheFlash(15, 0.25, 0.1);
                tf.ShowDialog();
            }
            else if (MediumRB.Checked)
            {
                TheFlash tf = new TheFlash(25, 0.3, 0.2);
                tf.ShowDialog();
            }
            else if (HardRB.Checked)
            {
                TheFlash tf = new TheFlash(40, 0.5, 0.3);
                tf.ShowDialog();
            }
        }
        */
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ms =  MessageBox.Show("Are you sure want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            switch (ms)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PairMatching pm;
            switch (diffcnt)
            {
                case 0:
                    pm = new PairMatching(20, 5, 8, 30000);
                    break;
                case 1:
                    pm = new PairMatching(30, 4, 10, 40000);
                    break;
                case 2:
                    pm = new PairMatching(50, 3, 15, 50000);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TheFlash tf;
            switch (diffcnt)
            {
                case 0:
                    tf = new TheFlash(15, 0.25, 0.1);
                    tf.ShowDialog();
                    break;
                case 1:
                    tf = new TheFlash(25, 0.3, 0.2);
                    tf.ShowDialog();
                    break;
                case 2:
                    tf = new TheFlash(40, 0.5, 0.3);
                    tf.ShowDialog();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diffcnt++;
            diffcnt %= 3;
            button4.Text = dstr[diffcnt];
            button4.BackColor = dclr[diffcnt];
        }
    }
}
