using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheJBrainer
{
    public partial class TheFlash : Form
    {
        private DateTime BeginTime = new DateTime(), CurrentTime = new DateTime(), PreviousTime = new DateTime();
        private int TimeAllowed = 20000;
        private int TimeLeft = 20000, SecondaryTimer = 0;
        private int GenerationRange;
        private int CorrectCount = 0, Score = Constants.UNDEFINED, IncorrectCount = 0;
        private double CorrectAnswerGain = 0, IncorrectAnswerLoss = 0;
        private double Difficulty, NegativeChance, Drain;
        private FlashQuestion Question;
        private bool IsCountingTime = true;

        public TheFlash(int generation_range, double difficulty, double negative_chance)
        {
            InitializeComponent();
            GenerationRange = generation_range;
            Difficulty = difficulty;
            NegativeChance = negative_chance;
            Drain = 1;
            CorrectAnswerGain = 5.0 * (90.0 + GenerationRange * 1.8) / 100.0;
            IncorrectAnswerLoss = CorrectAnswerGain * 0.4;
        }

        private void NewQuestion()
        {
            Question = new FlashQuestion(GenerationRange, ref Difficulty, ref NegativeChance);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (IsCountingTime) Check();
        }
        
        private void Check()
        {
            IsCountingTime = false;
            string input = AnswerTxb.Text;
            AnswerTxb.Text = "";
            int user_answer;
            try
            {
                user_answer = Convert.ToInt32(input);
                if (user_answer == Question.GetAnswer())
                {
                    AcceptAnswer();
                }
                else
                {
                    WrongAnswer();
                }
            }
            catch (FormatException)
            {
                WrongAnswer();
            }
            SecondaryTimer = 1000;
            ShowAnswer();
            NewQuestion();
        }

        private void TheFlash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.TheFlash_FormClosing(sender, e, Score);
        }

        private void startFlashBtn_Click(object sender, EventArgs e)
        {
            BeginTime = DateTime.Now;
            CurrentTime = DateTime.Now;
            QuestionTxb.Visible = true;
            AnswerTxb.Visible = true;
            SubmitBtn.Visible = true;
            NewQuestion();
            ShowQuestion();
            Score = 0;
            startFlashBtn.Visible = false;
            FlashTimer.Start();
            AnswerTxb.Focus();
        }

        private void ShowQuestion()
        {
            QuestionTxb.Text = Question.GetQuestionAsString();
            AnswerTxb.Focus();
        }

        private void AnswerTxb_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && IsCountingTime)
            {
                Check();
            }
        }

        private void WrongAnswer()
        {
            Difficulty *= (0.9 + 0.1 * Utilities.rd.NextDouble());
            GenerationRange += Utilities.rd.Next(-1, 1);
            TimeLeft -= 1000;
            Score -= (int)IncorrectAnswerLoss;
            IncorrectCount++;
            IncorrectCountTxb.Text = IncorrectCount.ToString();
            CorrectAnswerTxb.Visible = true;
            CorrectAnswerTxb.BackColor = Color.Salmon;
        }

        private void AcceptAnswer()
        {
            CorrectCount++;
            Score += (int)CorrectAnswerGain;
            CorrectAnswerGain *= 1.02;
            CorrectCountTxb.Text = CorrectCount.ToString();
            Difficulty = 1 - ((1 - Difficulty) * (Utilities.rd.NextDouble() * 0.06 + 0.92));
            GenerationRange += Utilities.rd.Next(1, 1 + GenerationRange / 16 + CorrectCount / 4);
            TimeLeft += Convert.ToInt32(1500.0 * Drain);
            TimeAllowed += Convert.ToInt32(1500.0 * Drain);
            Drain *= 0.988;
            CorrectAnswerTxb.Visible = true;
            CorrectAnswerTxb.BackColor = Color.Lime;
        }

        private void FlashTimer_Tick(object sender, EventArgs e)
        {
            PreviousTime = CurrentTime;
            CurrentTime = DateTime.Now;
            int TimeLoss = (CurrentTime - PreviousTime).Milliseconds;
            if (IsCountingTime) TimeLeft -= TimeLoss;
            else SecondaryTimer -= TimeLoss;
            if (SecondaryTimer <= 0)
            {
                IsCountingTime = true;
                CorrectAnswerTxb.Visible = false;
                ShowQuestion();
            }
            if (TimeLeft <= 0)
            {
                TimeLeftTxb.Text = "0.00";
                TimeLeftPb.Value = 0;
                EndGame();
            }
            else
            {
                TimeLeftPb.Maximum = TimeAllowed;
                TimeLeftPb.Value = TimeLeft;
                TimeLeftTxb.Text = (TimeLeft / 1000.0).ToString("#0.00");
            }
        }

        private void ShowAnswer ()
        {
            CorrectAnswerTxb.Text = Question.GetAnswer().ToString();
        }

        private void EndGame()
        {
            ShowAnswer();
            SecondaryTimer = Int32.MaxValue;
            IsCountingTime = true;
            AnswerTxb.Enabled = false;
            FlashTimer.Stop();
            ScoreLbl.Text = Score.ToString();
            SubmitBtn.Enabled = false;
        }
    }

    public class FlashQuestion
    {
        public int Operand1, Operand2;
        public BasicOperator Operator;
        private int Answer;

        public FlashQuestion(int generation_range, ref double difficulty, ref double negative_chance)
        {
            double o1 = Utilities.rd.NextDouble();
            int o2 = Utilities.rd.Next(2);
            bool negative_allowed = Utilities.rd.NextDouble() < negative_chance;
            bool n1 = false, n2 = false;
            if (negative_allowed)
            {
                negative_chance *= 0.9;
                n1 = Convert.ToBoolean(Utilities.rd.Next(2));
                n2 = Convert.ToBoolean(Utilities.rd.Next(2));
            }
            else negative_chance += (1 - negative_chance) * 0.04;
            if (o1 > difficulty)
            {
                switch (o2)
                {
                    case 0:
                        Operator = BasicOperator.PLUS;
                        break;
                    case 1:
                        Operator = BasicOperator.MINUS;
                        break;
                    default:
                        break;
                }
                difficulty += (1 - difficulty) * 0.0625;
            }
            else
            {
                switch(o2)
                {
                    case 0:
                        Operator = BasicOperator.MULTIPLY;
                    break;
                    case 1:
                        Operator = BasicOperator.DIVIDE;
                    break;
                    default:
                        break;
                }
                difficulty *= 0.925;
            }
            switch (Operator)
            {
                case BasicOperator.PLUS:
                    Operand1 = Utilities.rd.Next(generation_range + 1);
                    Operand2 = Utilities.rd.Next(generation_range + 1);
                    if (n1) Operand1 = -Operand1;
                    if (n2) Operand2 = -Operand2;
                    Answer = Operand1 + Operand2;
                    break;
                case BasicOperator.MINUS:
                    Operand2 = Utilities.rd.Next(generation_range + 1);
                    Operand1 = Utilities.rd.Next(Operand2 + generation_range + 1);
                    if (n1) Operand1 = -Operand1;
                    if (n2) Operand2 = -Operand2;
                    Answer = Operand1 - Operand2;
                    break;
                case BasicOperator.MULTIPLY:
                    Operand1 = Utilities.rd.Next(generation_range + 1);
                    Operand2 = Utilities.rd.Next(generation_range + 1);
                    if (n1) Operand1 = -Operand1;
                    if (n2) Operand2 = -Operand2;
                    Answer = Operand1 * Operand2;
                    break;
                case BasicOperator.DIVIDE:
                    Operand2 = Utilities.rd.Next(generation_range) + 1;
                    Operand1 = Operand2 * Utilities.rd.Next(generation_range + 1);
                    if (n1) Operand1 = -Operand1;
                    if (n2) Operand2 = -Operand2;
                    Answer = Operand1 / Operand2;
                    break;
                default:
                    break;
            }
        }
        
        public FlashQuestion(int operand1, int operand2, BasicOperator _operator)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Operator = _operator;
            switch (Operator)
            {
                case BasicOperator.PLUS:
                    Answer = Operand1 + Operand2;
                    break;
                case BasicOperator.MINUS:
                    Answer = Operand1 - Operand2;
                    break;
                case BasicOperator.MULTIPLY:
                    Answer = Operand1 * Operand2;
                    break;
                case BasicOperator.DIVIDE:
                    if (Operand2 != 0) Answer = Operand1 / Operand2;
                    else Answer = 0;
                    break;
                default:
                    break;
            }
        }

        public int GetAnswer () { return Answer; }

        public string GetQuestionAsString()
        {
            string result = "";
            if (Operand1 >= 0) result += Operand1.ToString();
            else result += "(" + Operand1.ToString() + ")";
            switch (Operator)
            {
                case BasicOperator.PLUS:
                    result += " + ";
                    break;
                case BasicOperator.MINUS:
                    result += " - ";
                    break;
                case BasicOperator.MULTIPLY:
                    result += " * ";
                    break;
                case BasicOperator.DIVIDE:
                    result += " / ";
                    break;
                default:
                    break;
            }
            if (Operand2 >= 0) result += Operand2.ToString();
            else result += "(" + Operand2.ToString() + ")";
            return result;
        }
    }

}
