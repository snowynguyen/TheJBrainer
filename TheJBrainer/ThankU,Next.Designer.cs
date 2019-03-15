namespace TheJBrainer
{
    partial class ThankU_Next
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
            this.GameplayPnl = new System.Windows.Forms.Panel();
            this.SeenBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.PlaygroundPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScoredLbl = new System.Windows.Forms.Label();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.ScoredTxb = new System.Windows.Forms.TextBox();
            this.LevelTxb = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GameplayPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameplayPnl
            // 
            this.GameplayPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameplayPnl.Controls.Add(this.SeenBtn);
            this.GameplayPnl.Controls.Add(this.NewBtn);
            this.GameplayPnl.Controls.Add(this.PlaygroundPnl);
            this.GameplayPnl.Location = new System.Drawing.Point(60, 18);
            this.GameplayPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameplayPnl.Name = "GameplayPnl";
            this.GameplayPnl.Size = new System.Drawing.Size(480, 600);
            this.GameplayPnl.TabIndex = 0;
            // 
            // SeenBtn
            // 
            this.SeenBtn.Location = new System.Drawing.Point(269, 512);
            this.SeenBtn.Name = "SeenBtn";
            this.SeenBtn.Size = new System.Drawing.Size(161, 41);
            this.SeenBtn.TabIndex = 1;
            this.SeenBtn.Text = "Seen";
            this.SeenBtn.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(63, 512);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(161, 41);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // PlaygroundPnl
            // 
            this.PlaygroundPnl.Location = new System.Drawing.Point(0, 0);
            this.PlaygroundPnl.Name = "PlaygroundPnl";
            this.PlaygroundPnl.Size = new System.Drawing.Size(480, 480);
            this.PlaygroundPnl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ScoredLbl);
            this.panel1.Controls.Add(this.LevelLbl);
            this.panel1.Controls.Add(this.ScoredTxb);
            this.panel1.Controls.Add(this.LevelTxb);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 643);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 95);
            this.panel1.TabIndex = 1;
            // 
            // ScoredLbl
            // 
            this.ScoredLbl.AutoSize = true;
            this.ScoredLbl.Location = new System.Drawing.Point(435, 0);
            this.ScoredLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoredLbl.Name = "ScoredLbl";
            this.ScoredLbl.Size = new System.Drawing.Size(55, 20);
            this.ScoredLbl.TabIndex = 2;
            this.ScoredLbl.Text = "Scored";
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.Location = new System.Drawing.Point(4, 0);
            this.LevelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(43, 20);
            this.LevelLbl.TabIndex = 2;
            this.LevelLbl.Text = "Level";
            // 
            // ScoredTxb
            // 
            this.ScoredTxb.BackColor = System.Drawing.Color.PaleGreen;
            this.ScoredTxb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoredTxb.ForeColor = System.Drawing.Color.DarkGreen;
            this.ScoredTxb.Location = new System.Drawing.Point(439, 25);
            this.ScoredTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScoredTxb.Name = "ScoredTxb";
            this.ScoredTxb.ReadOnly = true;
            this.ScoredTxb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ScoredTxb.Size = new System.Drawing.Size(132, 27);
            this.ScoredTxb.TabIndex = 1;
            this.ScoredTxb.Text = "0";
            // 
            // LevelTxb
            // 
            this.LevelTxb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LevelTxb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelTxb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LevelTxb.Location = new System.Drawing.Point(8, 25);
            this.LevelTxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LevelTxb.Name = "LevelTxb";
            this.LevelTxb.ReadOnly = true;
            this.LevelTxb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LevelTxb.Size = new System.Drawing.Size(132, 27);
            this.LevelTxb.TabIndex = 1;
            this.LevelTxb.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 60);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(584, 35);
            this.progressBar1.TabIndex = 0;
            // 
            // ThankU_Next
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GameplayPnl);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThankU_Next";
            this.Text = "ThankU_Next";
            this.GameplayPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameplayPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScoredLbl;
        private System.Windows.Forms.Label LevelLbl;
        private System.Windows.Forms.TextBox ScoredTxb;
        private System.Windows.Forms.TextBox LevelTxb;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SeenBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Panel PlaygroundPnl;
    }
}