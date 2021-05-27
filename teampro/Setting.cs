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
    public partial class Setting : Form
    {
        public Form1 mainForm;

        public Setting()
        {
            InitializeComponent();
        }
     
        private void chkTransparency_CheckedChanged(object sender, EventArgs e)
        {
            if(chkOpacity.Checked)
            {
                Opacity.Visible = true;
                labelTransparency.Visible = true;
                Opacity.Value = (int)(mainForm.Opacity * 100);
                labelTransparency.Text = Opacity.Value.ToString();
                labelPercent.Visible = true;
            }
            else
            {
                Opacity.Visible = false;
                labelTransparency.Visible = false;
                labelPercent.Visible = false;
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if(mainForm.TopMost)
            {
                chkTop.Checked = true;
            }
            else
            {
                chkTop.Checked = false;
            }
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Opacity_Scroll(object sender, ScrollEventArgs e)
        {
            labelTransparency.Text = Opacity.Value.ToString();
            mainForm.Opacity = Opacity.Value * 0.01;
        }

        private void chkTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTop.Checked)
            {
                mainForm.TopMost = true;
            }
            else
            {
                mainForm.TopMost = false;
            }
        }
    }
}
