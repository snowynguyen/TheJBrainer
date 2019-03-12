namespace TheJBrainer
{
    partial class PairMatching
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
            this.components = new System.ComponentModel.Container();
            this.GameplayPnl = new System.Windows.Forms.Panel();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.StatusPnl = new System.Windows.Forms.Panel();
            this.TimeLeftLbl = new System.Windows.Forms.Label();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.LivesLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PMTimer = new System.Windows.Forms.Timer(this.components);
            this.GameplayPnl.SuspendLayout();
            this.StatusPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameplayPnl
            // 
            this.GameplayPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameplayPnl.AutoScroll = true;
            this.GameplayPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GameplayPnl.Controls.Add(this.PlayBtn);
            this.GameplayPnl.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.GameplayPnl.Location = new System.Drawing.Point(14, 16);
            this.GameplayPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GameplayPnl.Name = "GameplayPnl";
            this.GameplayPnl.Size = new System.Drawing.Size(800, 480);
            this.GameplayPnl.TabIndex = 0;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(350, 211);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(93, 52);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // StatusPnl
            // 
            this.StatusPnl.Controls.Add(this.progressBar1);
            this.StatusPnl.Controls.Add(this.TimeLeftLbl);
            this.StatusPnl.Controls.Add(this.ScoreLbl);
            this.StatusPnl.Controls.Add(this.LevelLbl);
            this.StatusPnl.Controls.Add(this.LivesLbl);
            this.StatusPnl.Controls.Add(this.label7);
            this.StatusPnl.Controls.Add(this.label3);
            this.StatusPnl.Controls.Add(this.label2);
            this.StatusPnl.Controls.Add(this.label1);
            this.StatusPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusPnl.Location = new System.Drawing.Point(0, 501);
            this.StatusPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusPnl.Name = "StatusPnl";
            this.StatusPnl.Size = new System.Drawing.Size(838, 75);
            this.StatusPnl.TabIndex = 1;
            // 
            // TimeLeftLbl
            // 
            this.TimeLeftLbl.AutoSize = true;
            this.TimeLeftLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftLbl.Location = new System.Drawing.Point(711, 26);
            this.TimeLeftLbl.Name = "TimeLeftLbl";
            this.TimeLeftLbl.Size = new System.Drawing.Size(36, 25);
            this.TimeLeftLbl.TabIndex = 1;
            this.TimeLeftLbl.Text = "oo";
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(387, 26);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(23, 25);
            this.ScoreLbl.TabIndex = 1;
            this.ScoreLbl.Text = "0";
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLbl.Location = new System.Drawing.Point(166, 26);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(23, 25);
            this.LevelLbl.TabIndex = 1;
            this.LevelLbl.Text = "1";
            // 
            // LivesLbl
            // 
            this.LivesLbl.AutoSize = true;
            this.LivesLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLbl.Location = new System.Drawing.Point(12, 26);
            this.LivesLbl.Name = "LivesLbl";
            this.LivesLbl.Size = new System.Drawing.Size(23, 25);
            this.LivesLbl.TabIndex = 1;
            this.LivesLbl.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lives";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(838, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // PMTimer
            // 
            this.PMTimer.Interval = 10;
            // 
            // PairMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(838, 576);
            this.Controls.Add(this.StatusPnl);
            this.Controls.Add(this.GameplayPnl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PairMatching";
            this.Text = "PairMatching";
            this.Load += new System.EventHandler(this.PairMatching_Load);
            this.SizeChanged += new System.EventHandler(this.PairMatching_SizeChanged);
            this.GameplayPnl.ResumeLayout(false);
            this.StatusPnl.ResumeLayout(false);
            this.StatusPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameplayPnl;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Panel StatusPnl;
        private System.Windows.Forms.Label TimeLeftLbl;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Label LevelLbl;
        private System.Windows.Forms.Label LivesLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer PMTimer;
    }
}