namespace TheJBrainer
{
    partial class TheFlash
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.TimeLeftTxb = new System.Windows.Forms.TextBox();
            this.IncorrectCountTxb = new System.Windows.Forms.Label();
            this.CorrectCountTxb = new System.Windows.Forms.Label();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.TimeLeftPb = new System.Windows.Forms.ProgressBar();
            this.LivesLbl = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuestionTxb = new System.Windows.Forms.TextBox();
            this.AnswerTxb = new System.Windows.Forms.TextBox();
            this.FlashTimer = new System.Windows.Forms.Timer(this.components);
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.CorrectAnswerTxb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ScoreLbl);
            this.panel1.Controls.Add(this.TimeLeftTxb);
            this.panel1.Controls.Add(this.IncorrectCountTxb);
            this.panel1.Controls.Add(this.CorrectCountTxb);
            this.panel1.Controls.Add(this.LevelLbl);
            this.panel1.Controls.Add(this.TimeLeftPb);
            this.panel1.Controls.Add(this.LivesLbl);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 98);
            this.panel1.TabIndex = 0;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(472, 68);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(36, 25);
            this.ScoreLbl.TabIndex = 5;
            this.ScoreLbl.Text = "---";
            // 
            // TimeLeftTxb
            // 
            this.TimeLeftTxb.BackColor = System.Drawing.Color.Honeydew;
            this.TimeLeftTxb.ForeColor = System.Drawing.Color.Tomato;
            this.TimeLeftTxb.Location = new System.Drawing.Point(10, 3);
            this.TimeLeftTxb.Name = "TimeLeftTxb";
            this.TimeLeftTxb.ReadOnly = true;
            this.TimeLeftTxb.Size = new System.Drawing.Size(100, 29);
            this.TimeLeftTxb.TabIndex = 5;
            // 
            // IncorrectCountTxb
            // 
            this.IncorrectCountTxb.AutoSize = true;
            this.IncorrectCountTxb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectCountTxb.Location = new System.Drawing.Point(349, 68);
            this.IncorrectCountTxb.Name = "IncorrectCountTxb";
            this.IncorrectCountTxb.Size = new System.Drawing.Size(23, 25);
            this.IncorrectCountTxb.TabIndex = 6;
            this.IncorrectCountTxb.Text = "0";
            // 
            // CorrectCountTxb
            // 
            this.CorrectCountTxb.AutoSize = true;
            this.CorrectCountTxb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectCountTxb.Location = new System.Drawing.Point(263, 68);
            this.CorrectCountTxb.Name = "CorrectCountTxb";
            this.CorrectCountTxb.Size = new System.Drawing.Size(23, 25);
            this.CorrectCountTxb.TabIndex = 6;
            this.CorrectCountTxb.Text = "0";
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLbl.Location = new System.Drawing.Point(191, 68);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(23, 25);
            this.LevelLbl.TabIndex = 6;
            this.LevelLbl.Text = "1";
            // 
            // TimeLeftPb
            // 
            this.TimeLeftPb.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeLeftPb.Location = new System.Drawing.Point(112, 0);
            this.TimeLeftPb.Maximum = 20000;
            this.TimeLeftPb.Name = "TimeLeftPb";
            this.TimeLeftPb.Size = new System.Drawing.Size(459, 32);
            this.TimeLeftPb.Step = 1;
            this.TimeLeftPb.TabIndex = 1;
            this.TimeLeftPb.Value = 20000;
            // 
            // LivesLbl
            // 
            this.LivesLbl.AutoSize = true;
            this.LivesLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLbl.Location = new System.Drawing.Point(117, 68);
            this.LivesLbl.Name = "LivesLbl";
            this.LivesLbl.Size = new System.Drawing.Size(36, 25);
            this.LivesLbl.TabIndex = 7;
            this.LivesLbl.Text = "oo";
            this.LivesLbl.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(112, 98);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Incorrect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correct";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lives";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Level";
            // 
            // QuestionTxb
            // 
            this.QuestionTxb.Location = new System.Drawing.Point(10, 12);
            this.QuestionTxb.Name = "QuestionTxb";
            this.QuestionTxb.ReadOnly = true;
            this.QuestionTxb.Size = new System.Drawing.Size(549, 29);
            this.QuestionTxb.TabIndex = 3;
            // 
            // AnswerTxb
            // 
            this.AnswerTxb.BackColor = System.Drawing.Color.White;
            this.AnswerTxb.Location = new System.Drawing.Point(10, 47);
            this.AnswerTxb.Name = "AnswerTxb";
            this.AnswerTxb.Size = new System.Drawing.Size(549, 29);
            this.AnswerTxb.TabIndex = 1;
            this.AnswerTxb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AnswerTxb_KeyUp);
            // 
            // FlashTimer
            // 
            this.FlashTimer.Interval = 10;
            this.FlashTimer.Tick += new System.EventHandler(this.FlashTimer_Tick);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(449, 82);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(110, 34);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // CorrectAnswerTxb
            // 
            this.CorrectAnswerTxb.Location = new System.Drawing.Point(10, 84);
            this.CorrectAnswerTxb.Name = "CorrectAnswerTxb";
            this.CorrectAnswerTxb.ReadOnly = true;
            this.CorrectAnswerTxb.Size = new System.Drawing.Size(433, 29);
            this.CorrectAnswerTxb.TabIndex = 4;
            // 
            // TheFlash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 220);
            this.Controls.Add(this.CorrectAnswerTxb);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.AnswerTxb);
            this.Controls.Add(this.QuestionTxb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TheFlash";
            this.Text = "TheFlash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheFlash_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TimeLeftTxb;
        private System.Windows.Forms.ProgressBar TimeLeftPb;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Label LevelLbl;
        private System.Windows.Forms.Label LivesLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuestionTxb;
        private System.Windows.Forms.TextBox AnswerTxb;
        private System.Windows.Forms.Timer FlashTimer;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox CorrectAnswerTxb;
        private System.Windows.Forms.Label IncorrectCountTxb;
        private System.Windows.Forms.Label CorrectCountTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}