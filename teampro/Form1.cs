using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace teampro
{
    public partial class Form1 : Form
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlMain.Height = btnNEWS.Height;
            pnlMain.Top = btnNEWS.Top;
            pnlMain.Left = btnNEWS.Left;
            btnNEWS.BackColor = Color.FromArgb(95, 158, 160);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNEWS_Click(object sender, EventArgs e)
        {
            pnlMain.Height = btnNEWS.Height;
            pnlMain.Top = btnNEWS.Top;
            pnlMain.Left = btnNEWS.Left;
            btnNEWS.BackColor = Color.FromArgb(95, 158, 160);
        }

        private void btnCOINS_Click(object sender, EventArgs e)
        {
            pnlMain.Height = btnCOINS.Height;
            pnlMain.Top = btnCOINS.Top;
            pnlMain.Left = btnNEWS.Left;
            btnCOINS.BackColor = Color.FromArgb(95, 158, 160);
            btnNEWS.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlMain.Height = btnSettings.Height;
            pnlMain.Top = btnSettings.Top;
            pnlMain.Left = btnNEWS.Left;
            btnSettings.BackColor = Color.FromArgb(95, 158, 160);
            btnNEWS.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNEWS_Leave_1(object sender, EventArgs e)
        {
            btnNEWS.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void btnCOINS_Leave_1(object sender, EventArgs e)
        {
            btnCOINS.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void btnSettings_Leave_1(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(47, 79, 79);
        }
    }
}
