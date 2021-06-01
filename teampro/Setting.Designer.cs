
namespace teampro
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkOpacity = new System.Windows.Forms.CheckBox();
            this.Opacity = new System.Windows.Forms.HScrollBar();
            this.labelTransparency = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.chkPosition = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.labelTopMost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 주아", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "설정";
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkDarkMode.Location = new System.Drawing.Point(44, 93);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(126, 35);
            this.chkDarkMode.TabIndex = 7;
            this.chkDarkMode.Text = "다크모드";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkTop.Location = new System.Drawing.Point(44, 168);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(113, 35);
            this.chkTop.TabIndex = 8;
            this.chkTop.Text = "항상 위";
            this.chkTop.UseVisualStyleBackColor = true;
            this.chkTop.CheckedChanged += new System.EventHandler(this.chkTop_CheckedChanged);
            // 
            // chkOpacity
            // 
            this.chkOpacity.AutoSize = true;
            this.chkOpacity.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkOpacity.Location = new System.Drawing.Point(44, 241);
            this.chkOpacity.Name = "chkOpacity";
            this.chkOpacity.Size = new System.Drawing.Size(103, 35);
            this.chkOpacity.TabIndex = 9;
            this.chkOpacity.Text = "투명도";
            this.chkOpacity.UseVisualStyleBackColor = true;
            this.chkOpacity.CheckedChanged += new System.EventHandler(this.chkOpacity_CheckedChanged);
            // 
            // Opacity
            // 
            this.Opacity.Location = new System.Drawing.Point(159, 241);
            this.Opacity.Maximum = 109;
            this.Opacity.Minimum = 50;
            this.Opacity.Name = "Opacity";
            this.Opacity.Size = new System.Drawing.Size(297, 26);
            this.Opacity.TabIndex = 10;
            this.Opacity.Value = 50;
            this.Opacity.Visible = false;
            this.Opacity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Opacity_Scroll);
            // 
            // labelTransparency
            // 
            this.labelTransparency.AutoSize = true;
            this.labelTransparency.Font = new System.Drawing.Font("배달의민족 주아", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTransparency.Location = new System.Drawing.Point(475, 244);
            this.labelTransparency.Name = "labelTransparency";
            this.labelTransparency.Size = new System.Drawing.Size(0, 27);
            this.labelTransparency.TabIndex = 11;
            this.labelTransparency.Tag = "";
            this.labelTransparency.Visible = false;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("배달의민족 주아", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPercent.Location = new System.Drawing.Point(512, 244);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(31, 27);
            this.labelPercent.TabIndex = 12;
            this.labelPercent.Text = "%";
            this.labelPercent.Visible = false;
            // 
            // chkPosition
            // 
            this.chkPosition.AutoSize = true;
            this.chkPosition.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkPosition.Location = new System.Drawing.Point(44, 309);
            this.chkPosition.Name = "chkPosition";
            this.chkPosition.Size = new System.Drawing.Size(112, 35);
            this.chkPosition.TabIndex = 13;
            this.chkPosition.Text = "창 위치";
            this.chkPosition.UseVisualStyleBackColor = true;
            this.chkPosition.CheckedChanged += new System.EventHandler(this.chkPosition_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(158, 314);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 25);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "좌측상단";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.position_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(254, 314);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 25);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "좌측하단";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.position_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(350, 314);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 25);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "우측상단";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.position_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(446, 314);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(97, 25);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "우측하단";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.position_CheckedChanged);
            // 
            // labelTopMost
            // 
            this.labelTopMost.AutoSize = true;
            this.labelTopMost.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTopMost.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTopMost.Location = new System.Drawing.Point(155, 174);
            this.labelTopMost.Name = "labelTopMost";
            this.labelTopMost.Size = new System.Drawing.Size(280, 21);
            this.labelTopMost.TabIndex = 18;
            this.labelTopMost.Text = "이 프로그램이 가장 위에 보여집니다.";
            this.labelTopMost.Visible = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(564, 428);
            this.Controls.Add(this.labelTopMost);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chkPosition);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelTransparency);
            this.Controls.Add(this.Opacity);
            this.Controls.Add(this.chkOpacity);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkOpacity;
        private System.Windows.Forms.HScrollBar Opacity;
        private System.Windows.Forms.Label labelTransparency;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.CheckBox chkPosition;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label labelTopMost;
    }
}