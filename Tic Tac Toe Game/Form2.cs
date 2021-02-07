using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape3.Width += 1;
            if (rectangleShape3.Width >= 374)
            {
                timer1.Stop();
                this.Hide();
                Form1 f1 = new Form1();

                f1.Show();

            }
        }
    }
}
