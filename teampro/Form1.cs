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
        Setting setForm;
        Coin coinForm;
        News newsForm;

        bool setOpened = false;
        bool coinOpened = false;
        bool newsOpened = false;
        
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
            // 부모 폼 배경색 지정
            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls) 
            { 
                try 
                {
                    ctlMDI = (MdiClient) ctl;
                    ctlMDI.BackColor = this.BackColor; 
                }
                catch (InvalidCastException) { }
            }

            // 메인 폼 오픈 - 뉴스 폼 오픈
            newsForm = new News();
            newsForm.MdiParent = this;
            newsOpened = true;
            newsForm.Show();
        }

        private void btnNEWS_Click(object sender, EventArgs e)
        {
            // 다른 폼 종료

            if (setOpened)
            {
                setOpened = false;
                setForm.Close();
            }
            else if (coinOpened)
            {
                coinOpened = false;
                coinForm.Close();
            }

            // 뉴스 폼 오픈
            if (!newsOpened)
            {
                newsForm = new News();
                newsForm.MdiParent = this;
                newsOpened = true;
                newsForm.Show();

                pnlMain.Height = btnNEWS.Height;
                pnlMain.Top = btnNEWS.Top;
                pnlMain.Left = btnNEWS.Left;
                btnNEWS.BackColor = Color.FromArgb(95, 158, 160);
                btnCOINS.BackColor = Color.FromArgb(47, 79, 79);
                btnSettings.BackColor = Color.FromArgb(47, 79, 79);
            }


        }

        private void btnCOINS_Click(object sender, EventArgs e)
        {
            // 다른 폼 종료
            if (setOpened)
            {
                setOpened = false;
                setForm.Close();
            }
            else if (newsOpened)
            {
                newsOpened = false;
                newsForm.Close();
            }

            // 코인 폼 오픈
            if (!coinOpened)
            {
                coinForm = new Coin();
                coinForm.MdiParent = this;
                coinOpened = true;
                coinForm.Show();

                pnlMain.Height = btnCOINS.Height;
                pnlMain.Top = btnCOINS.Top;
                pnlMain.Left = btnNEWS.Left;
                btnCOINS.BackColor = Color.FromArgb(95, 158, 160);
                btnNEWS.BackColor = Color.FromArgb(47, 79, 79);
                btnSettings.BackColor = Color.FromArgb(47, 79, 79);
            }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // 다른 폼 종료
            if (coinOpened)             
            {
                coinOpened = false;
                coinForm.Close();
            }
            else if (newsOpened)
            {
                newsOpened = false;
                newsForm.Close();
            }

            // 설정 폼 오픈
            if (!setOpened)
            {
                setForm = new Setting();
                setForm.MdiParent = this;
                setOpened = true;
                setForm.mainForm = this;
                setForm.Show();

                pnlMain.Height = btnSettings.Height;
                pnlMain.Top = btnSettings.Top;
                pnlMain.Left = btnNEWS.Left;
                btnSettings.BackColor = Color.FromArgb(95, 158, 160);
                btnNEWS.BackColor = Color.FromArgb(47, 79, 79);
                btnCOINS.BackColor = Color.FromArgb(47, 79, 79);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
