
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 주아", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting Form";
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkDarkMode.Location = new System.Drawing.Point(44, 115);
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
            this.chkTop.Location = new System.Drawing.Point(44, 190);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(105, 35);
            this.chkTop.TabIndex = 8;
            this.chkTop.Text = "최상단";
            this.chkTop.UseVisualStyleBackColor = true;
            this.chkTop.CheckedChanged += new System.EventHandler(this.chkTop_CheckedChanged);
            // 
            // chkOpacity
            // 
            this.chkOpacity.AutoSize = true;
            this.chkOpacity.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkOpacity.Location = new System.Drawing.Point(44, 263);
            this.chkOpacity.Name = "chkOpacity";
            this.chkOpacity.Size = new System.Drawing.Size(103, 35);
            this.chkOpacity.TabIndex = 9;
            this.chkOpacity.Text = "투명도";
            this.chkOpacity.UseVisualStyleBackColor = true;
            this.chkOpacity.CheckedChanged += new System.EventHandler(this.chkTransparency_CheckedChanged);
            // 
            // Opacity
            // 
            this.Opacity.Location = new System.Drawing.Point(187, 264);
            this.Opacity.Maximum = 109;
            this.Opacity.Minimum = 50;
            this.Opacity.Name = "Opacity";
            this.Opacity.Size = new System.Drawing.Size(494, 25);
            this.Opacity.TabIndex = 10;
            this.Opacity.Value = 50;
            this.Opacity.Visible = false;
            this.Opacity.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Opacity_Scroll);
            // 
            // labelTransparency
            // 
            this.labelTransparency.AutoSize = true;
            this.labelTransparency.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTransparency.Location = new System.Drawing.Point(689, 265);
            this.labelTransparency.Name = "labelTransparency";
            this.labelTransparency.Size = new System.Drawing.Size(0, 31);
            this.labelTransparency.TabIndex = 11;
            this.labelTransparency.Tag = "";
            this.labelTransparency.Visible = false;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("배달의민족 주아", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPercent.Location = new System.Drawing.Point(731, 265);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(36, 31);
            this.labelPercent.TabIndex = 12;
            this.labelPercent.Text = "%";
            this.labelPercent.Visible = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(787, 412);
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
    }
}