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

        private void Setting_Load(object sender, EventArgs e)
        {
            // 최상단 상태 불러오기
            if(mainForm.TopMost)
            {
                chkTop.Checked = true;
            }
            else
            {
                chkTop.Checked = false;
            }

            // 위치 불러오기
            switch (mainForm.positon)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radioButton4.Checked = true;
                    break;
            }
        }

        // 다크모드 체크
        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
        }

        // 항상 위 체크
        private void chkTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTop.Checked)
            {
                mainForm.TopMost = true;
                labelTopMost.Visible = true;
            }
            else
            {
                mainForm.TopMost = false;
                labelTopMost.Visible = false;
            }
        }

        // 투명도 체크
        private void chkOpacity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOpacity.Checked)
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

        // 창 위치 체크
        private void chkPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPosition.Checked)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }

        }

        // 투명도 변경
        private void Opacity_Scroll(object sender, ScrollEventArgs e)
        {
            labelTransparency.Text = Opacity.Value.ToString();
            mainForm.Opacity = Opacity.Value * 0.01;
        }


        // 위치 변경
        private void position_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            switch (rbtn.Text)
            {
                case "좌측상단":
                    mainForm.Location = new Point(0, 0);
                    mainForm.positon = 1;
                    break;
                case "좌측하단":
                    mainForm.Location = new Point(0, screenHeight - mainForm.Height);
                    mainForm.positon = 2;
                    break;
                case "우측상단":
                    mainForm.Location = new Point(screenWidth - mainForm.Width, 0);
                    mainForm.positon = 3;
                    break;
                case "우측하단":
                    mainForm.Location = new Point(screenWidth - mainForm.Width, screenHeight - mainForm.Height);
                    mainForm.positon = 4;
                    break;
            }
        }
    }
}
