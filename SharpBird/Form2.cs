using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpBird
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fon1.Left -= 1;
            fon2.Left = fon1.Left + fon1.Width;
            if (fon1.Left < -fon1.Width)
            {
                fon1.Left = 0;
            }
        }
    }
}
