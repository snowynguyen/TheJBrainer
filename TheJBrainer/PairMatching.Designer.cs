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
            this.GameplayPnl = new System.Windows.Forms.Panel();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.GameplayPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameplayPnl
            // 
            this.GameplayPnl.Controls.Add(this.PlayBtn);
            this.GameplayPnl.Location = new System.Drawing.Point(12, 12);
            this.GameplayPnl.Name = "GameplayPnl";
            this.GameplayPnl.Size = new System.Drawing.Size(880, 480);
            this.GameplayPnl.TabIndex = 0;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(400, 220);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(80, 40);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "button1";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // PairMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 551);
            this.Controls.Add(this.GameplayPnl);
            this.Name = "PairMatching";
            this.Text = "PairMatching";
            this.Load += new System.EventHandler(this.PairMatching_Load);
            this.GameplayPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameplayPnl;
        private System.Windows.Forms.Button PlayBtn;
    }
}