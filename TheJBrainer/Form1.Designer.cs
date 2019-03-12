namespace TheJBrainer
{
    partial class Form1
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
            this.StartPairMatchingBtn = new System.Windows.Forms.Button();
            this.StartTheFlashBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EasyRB = new System.Windows.Forms.RadioButton();
            this.MediumRB = new System.Windows.Forms.RadioButton();
            this.HardRB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPairMatchingBtn
            // 
            this.StartPairMatchingBtn.Location = new System.Drawing.Point(271, 20);
            this.StartPairMatchingBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartPairMatchingBtn.Name = "StartPairMatchingBtn";
            this.StartPairMatchingBtn.Size = new System.Drawing.Size(215, 56);
            this.StartPairMatchingBtn.TabIndex = 0;
            this.StartPairMatchingBtn.Text = "Pair Matching";
            this.StartPairMatchingBtn.UseVisualStyleBackColor = true;
            this.StartPairMatchingBtn.Click += new System.EventHandler(this.StartPairMatchingBtn_Click);
            // 
            // StartTheFlashBtn
            // 
            this.StartTheFlashBtn.Location = new System.Drawing.Point(271, 152);
            this.StartTheFlashBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartTheFlashBtn.Name = "StartTheFlashBtn";
            this.StartTheFlashBtn.Size = new System.Drawing.Size(215, 56);
            this.StartTheFlashBtn.TabIndex = 1;
            this.StartTheFlashBtn.Text = "The Flash";
            this.StartTheFlashBtn.UseVisualStyleBackColor = true;
            this.StartTheFlashBtn.Click += new System.EventHandler(this.StartTheFlashBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HardRB);
            this.panel1.Controls.Add(this.MediumRB);
            this.panel1.Controls.Add(this.EasyRB);
            this.panel1.Location = new System.Drawing.Point(14, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 188);
            this.panel1.TabIndex = 2;
            // 
            // EasyRB
            // 
            this.EasyRB.AutoSize = true;
            this.EasyRB.Location = new System.Drawing.Point(17, 17);
            this.EasyRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EasyRB.Name = "EasyRB";
            this.EasyRB.Size = new System.Drawing.Size(52, 21);
            this.EasyRB.TabIndex = 0;
            this.EasyRB.TabStop = true;
            this.EasyRB.Text = "Easy";
            this.EasyRB.UseVisualStyleBackColor = true;
            // 
            // MediumRB
            // 
            this.MediumRB.AutoSize = true;
            this.MediumRB.Location = new System.Drawing.Point(17, 76);
            this.MediumRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MediumRB.Name = "MediumRB";
            this.MediumRB.Size = new System.Drawing.Size(74, 21);
            this.MediumRB.TabIndex = 0;
            this.MediumRB.TabStop = true;
            this.MediumRB.Text = "Medium";
            this.MediumRB.UseVisualStyleBackColor = true;
            // 
            // HardRB
            // 
            this.HardRB.AutoSize = true;
            this.HardRB.Location = new System.Drawing.Point(17, 132);
            this.HardRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HardRB.Name = "HardRB";
            this.HardRB.Size = new System.Drawing.Size(55, 21);
            this.HardRB.TabIndex = 0;
            this.HardRB.TabStop = true;
            this.HardRB.Text = "Hard";
            this.HardRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 239);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartTheFlashBtn);
            this.Controls.Add(this.StartPairMatchingBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "TheJBrainer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartPairMatchingBtn;
        private System.Windows.Forms.Button StartTheFlashBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton HardRB;
        private System.Windows.Forms.RadioButton MediumRB;
        private System.Windows.Forms.RadioButton EasyRB;
    }
}

