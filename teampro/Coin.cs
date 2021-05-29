using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teampro
{
    public partial class Coin : Form
    {
        public Form1 mainForm;

        public Coin()
        {
            InitializeComponent();
        }

        private void Coin_Load(object sender, EventArgs e)
        {
            if (mainForm.darkMode)
            {
                this.BackColor = Color.FromArgb(90, 90, 90);
            }
            else
            {
                this.BackColor = Color.FromArgb(95, 158, 160);
            }
        }
    }
}
