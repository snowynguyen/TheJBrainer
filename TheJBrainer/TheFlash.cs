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
    public partial class TheFlash : Form
    {
        DateTime timer = new DateTime();


        public TheFlash()
        {
            InitializeComponent();
        }

        private void AnswerTxb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void FlashTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
