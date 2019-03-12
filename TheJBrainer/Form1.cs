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
        public Form1()
        {
            InitializeComponent();            
        }

        private void StartPairMatchingBtn_Click(object sender, EventArgs e)
        {
            if (EasyRB.Checked)
            {
                PairMatching pm = new PairMatching(20, 5, 10);
            }
            else if (MediumRB.Checked)
            {
                PairMatching pm = new PairMatching(30, 4, 12);
            }
            else if (HardRB.Checked)
            {
                PairMatching pm = new PairMatching(50, 3, 15);
            }
        }

        private void StartTheFlashBtn_Click(object sender, EventArgs e)
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
            }
        }
    }
}
