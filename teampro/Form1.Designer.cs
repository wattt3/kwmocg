
namespace teampro
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCOINS = new System.Windows.Forms.Button();
            this.btnNEWS = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlMain.Controls.Add(this.button2);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.btnSettings);
            this.pnlMain.Controls.Add(this.btnCOINS);
            this.pnlMain.Controls.Add(this.btnNEWS);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 69);
            this.pnlMain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(763, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("배달의민족 주아", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::teampro.Properties.Resources.Settings;
            this.btnSettings.Location = new System.Drawing.Point(412, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(257, 69);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave_1);
            // 
            // btnCOINS
            // 
            this.btnCOINS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCOINS.FlatAppearance.BorderSize = 0;
            this.btnCOINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOINS.Font = new System.Drawing.Font("배달의민족 주아", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCOINS.ForeColor = System.Drawing.Color.White;
            this.btnCOINS.Image = global::teampro.Properties.Resources.Coins;
            this.btnCOINS.Location = new System.Drawing.Point(199, 0);
            this.btnCOINS.Name = "btnCOINS";
            this.btnCOINS.Size = new System.Drawing.Size(213, 69);
            this.btnCOINS.TabIndex = 0;
            this.btnCOINS.Text = "COINS";
            this.btnCOINS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCOINS.UseVisualStyleBackColor = true;
            this.btnCOINS.Click += new System.EventHandler(this.btnCOINS_Click);
            this.btnCOINS.Leave += new System.EventHandler(this.btnCOINS_Leave_1);
            // 
            // btnNEWS
            // 
            this.btnNEWS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNEWS.FlatAppearance.BorderSize = 0;
            this.btnNEWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNEWS.Font = new System.Drawing.Font("배달의민족 주아", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNEWS.ForeColor = System.Drawing.Color.White;
            this.btnNEWS.Image = global::teampro.Properties.Resources.Earth1;
            this.btnNEWS.Location = new System.Drawing.Point(0, 0);
            this.btnNEWS.Name = "btnNEWS";
            this.btnNEWS.Size = new System.Drawing.Size(199, 69);
            this.btnNEWS.TabIndex = 0;
            this.btnNEWS.Text = "NEWS";
            this.btnNEWS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNEWS.UseVisualStyleBackColor = true;
            this.btnNEWS.Click += new System.EventHandler(this.btnNEWS_Click);
            this.btnNEWS.Leave += new System.EventHandler(this.btnNEWS_Leave_1);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("배달의민족 도현", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(734, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximumSize = new System.Drawing.Size(1600, 1000);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Button btnCOINS;
        public System.Windows.Forms.Button btnNEWS;
        private System.Windows.Forms.Button button2;
    }
}

