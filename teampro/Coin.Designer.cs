
namespace teampro
{
    partial class Coin
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
            this.lvwCoinData = new System.Windows.Forms.ListView();
            this.cHCoinName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHCoinTradePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHCoinPriceChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbBoxCoinSearch = new System.Windows.Forms.ComboBox();
            this.btnCoinSearchAdd = new System.Windows.Forms.Button();
            this.btnCoinSearchDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coin Form";
            // 
            // lvwCoinData
            // 
            this.lvwCoinData.AutoArrange = false;
            this.lvwCoinData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHCoinName,
            this.cHCoinTradePrice,
            this.cHCoinPriceChange});
            this.lvwCoinData.GridLines = true;
            this.lvwCoinData.HideSelection = false;
            this.lvwCoinData.Location = new System.Drawing.Point(18, 43);
            this.lvwCoinData.Name = "lvwCoinData";
            this.lvwCoinData.Size = new System.Drawing.Size(523, 347);
            this.lvwCoinData.TabIndex = 3;
            this.lvwCoinData.UseCompatibleStateImageBehavior = false;
            this.lvwCoinData.View = System.Windows.Forms.View.Details;
            // 
            // cHCoinName
            // 
            this.cHCoinName.Text = "이름";
            this.cHCoinName.Width = 127;
            // 
            // cHCoinTradePrice
            // 
            this.cHCoinTradePrice.Text = "거래 가격";
            this.cHCoinTradePrice.Width = 86;
            // 
            // cHCoinPriceChange
            // 
            this.cHCoinPriceChange.Text = "변화량";
            // 
            // cmbBoxCoinSearch
            // 
            this.cmbBoxCoinSearch.FormattingEnabled = true;
            this.cmbBoxCoinSearch.Location = new System.Drawing.Point(18, 396);
            this.cmbBoxCoinSearch.Name = "cmbBoxCoinSearch";
            this.cmbBoxCoinSearch.Size = new System.Drawing.Size(427, 20);
            this.cmbBoxCoinSearch.TabIndex = 4;
            // 
            // btnCoinSearchAdd
            // 
            this.btnCoinSearchAdd.Location = new System.Drawing.Point(451, 393);
            this.btnCoinSearchAdd.Name = "btnCoinSearchAdd";
            this.btnCoinSearchAdd.Size = new System.Drawing.Size(42, 23);
            this.btnCoinSearchAdd.TabIndex = 5;
            this.btnCoinSearchAdd.Text = "추가";
            this.btnCoinSearchAdd.UseVisualStyleBackColor = true;
            this.btnCoinSearchAdd.Click += new System.EventHandler(this.btnCoinSearchAdd_Click);
            // 
            // btnCoinSearchDel
            // 
            this.btnCoinSearchDel.Location = new System.Drawing.Point(499, 393);
            this.btnCoinSearchDel.Name = "btnCoinSearchDel";
            this.btnCoinSearchDel.Size = new System.Drawing.Size(42, 23);
            this.btnCoinSearchDel.TabIndex = 6;
            this.btnCoinSearchDel.Text = "제거";
            this.btnCoinSearchDel.UseVisualStyleBackColor = true;
            this.btnCoinSearchDel.Click += new System.EventHandler(this.btnCoinSearchDel_Click);
            // 
            // Coin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(564, 428);
            this.Controls.Add(this.btnCoinSearchDel);
            this.Controls.Add(this.btnCoinSearchAdd);
            this.Controls.Add(this.cmbBoxCoinSearch);
            this.Controls.Add(this.lvwCoinData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Coin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoinSearchForm_FormClosed);
            this.Load += new System.EventHandler(this.Coin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwCoinData;
        private System.Windows.Forms.ColumnHeader cHCoinName;
        private System.Windows.Forms.ColumnHeader cHCoinTradePrice;
        private System.Windows.Forms.ColumnHeader cHCoinPriceChange;
        private System.Windows.Forms.ComboBox cmbBoxCoinSearch;
        private System.Windows.Forms.Button btnCoinSearchAdd;
        private System.Windows.Forms.Button btnCoinSearchDel;
    }
}