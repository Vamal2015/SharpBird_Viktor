using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SharpBird_Menu : Form
    {
        public SharpBird_Menu()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {
            SharpBird_Menu.ActiveForm.Close();
            
        }
    }
}
