using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheJBrainer
{
    public partial class PairMatching : Form
    {
        private DateTime BeginTime = new DateTime(), CurrentTime = new DateTime(), PreviousTime = new DateTime();
        private int TimeAllowed = 60000;
        private int TimeLeft = 60000, SecondaryTimer = 0;
        private bool IsCountingTime = true;
        public List<String> QuestionList = new List<string>();
        private List<int> AnswerList = new List<int>();
        private int GenerationRange, GenerationCount;
        private int Hold_Count = 0, Score = 0, CorrectCount = 0, Rating = 0, Lives = Constants._pm_lives;
        private List<PairMatching_TagStruct> Holds = new List<PairMatching_TagStruct>();
        

        public PairMatching(int generation_range, int lives, int generation_count, int time)
        {
            TimeAllowed = time;
            TimeLeft = time;
            GenerationRange = generation_range;
            Lives = lives;
            GenerationCount = generation_count;
            InitializeComponent();
            this.ShowDialog();
        }

        private void Data_Initialization()
        {
            GameplayPnl.Size = new Size(800, 480);
            QuestionList.Clear();
            AnswerList.Clear();
            List<String> tmp = new List<string>();
            for (int i = 0; i < GenerationCount; i++)
            {
                PairMatching_QuestionPair ptmp = new PairMatching_QuestionPair(GenerationRange, PairMatching_QuestionDifficulty.EASY);
                tmp = ptmp.GetQuestionPairasStrings();
                foreach(string s in tmp)
                {
                    QuestionList.Add(s);
                }
                AnswerList.Add(ptmp.GetCommonAnswer);
                AnswerList.Add(ptmp.GetCommonAnswer);
            }
            GameplayPnl.Controls.Clear();
            List<int> Permute = RandomPermute(QuestionList.Count);
            Point pt = new Point(0, 0);
            int max_horizontal_count = (int)Math.Truncate(Math.Sqrt(QuestionList.Count));
            int vertical_count = (int)Math.Ceiling(QuestionList.Count * 1.0 / max_horizontal_count);
            Constants._pm_btnvsize = (GameplayPnl.Size.Height - ((max_horizontal_count - 1) * Constants._pm_btnvgap)) / max_horizontal_count - Constants._pm_btnhgap;
            Constants._pm_btnhsize = (GameplayPnl.Size.Width - ((vertical_count - 1) * Constants._pm_btnvgap)) / vertical_count - Constants._pm_btnvgap;
            for (int i = 0, currow = 0, curcol = 0; i < QuestionList.Count; i++, curcol++)
            {
                Button btn = new Button();
                if (curcol >= max_horizontal_count)
                {
                    currow += curcol / max_horizontal_count;
                    curcol %= max_horizontal_count;
                }
                btn.Tag = new PairMatching_TagStruct(Permute[i], i, AnswerList[Permute[i]]);
                btn.Text = QuestionList[Permute[i]];
                btn.Size = new Size(Constants._pm_btnhsize, Constants._pm_btnvsize);
                btn.Location = new Point(currow * (Constants._pm_btnhsize + Constants._pm_btnhgap), curcol * (Constants._pm_btnvsize + Constants._pm_btnvgap));
                btn.BackColor = Color.LightGray;
                btn.Click += MatchBtn_Click;
                GameplayPnl.Controls.Add(btn);
            }
        }

        private List<int> RandomPermute(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result.Add(i);
            }
            int j = 0, tmp;
            for (int i = n - 1; i >= 0; i--)
            {
                j = Utilities.rd.Next(i + 1);
                tmp = result[i];
                result[i] = result[j];
                result[j] = tmp;
            }
            return result;
        }

        private void PairMatching_Load(object sender, EventArgs e)
        {
            PlayBtn.Visible = true;
            
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Data_Initialization();
            PlayBtn.Visible = false;
            PMTimer.Start();
        }

        private void MatchBtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            PairMatching_TagStruct tag = (PairMatching_TagStruct)btn.Tag;
            if (Hold_Count < Constants._pm_maxhold)
            {
                Hold_Count++;
                Holds.Add(tag);
                btn.BackColor = Color.LightYellow;
                btn.Enabled = false;
            } 
            if (Hold_Count >= Constants._pm_maxhold)
            {
                btn.Enabled = true;
                int res = Check();
                switch (res)
                {
                    case 1:
                        foreach(PairMatching_TagStruct h in Holds)
                        {
                            GameplayPnl.Controls[h.BIndex].Enabled = true;
                            GameplayPnl.Controls[h.BIndex].BackColor = Color.LawnGreen;
                            GameplayPnl.Controls[h.BIndex].Enabled = false;
                        }
                        Score += Constants._pm_base_score * Constants._pm_maxhold;
                        CorrectCount++;
                        if (CorrectCount == GenerationCount) StopGame(1);
                        break;
                    default:
                        foreach (PairMatching_TagStruct h in Holds)
                        {
                            GameplayPnl.Controls[h.BIndex].Enabled = true;
                            GameplayPnl.Controls[h.BIndex].BackColor = Color.LightGray;
                        }
                        Lives--;
                        break;
                }
                Holds.Clear();
                Hold_Count = 0;
                if (Lives <= 0)
                {
                    StopGame(-1);
                }
            }
            StatusBarUpdate();
        }

        private void StatusBarUpdate()
        {
            ScoreLbl.Text = Score.ToString();
            LivesLbl.Text = Lives.ToString();
        }

        private void PMTimer_Tick(object sender, EventArgs e)
        {
            PreviousTime = CurrentTime;
            CurrentTime = DateTime.Now;
            int TimeLoss = (CurrentTime - PreviousTime).Milliseconds;
            if (IsCountingTime) TimeLeft -= TimeLoss;
            else SecondaryTimer -= TimeLoss;
            if (SecondaryTimer <= 0)
            {
                IsCountingTime = true;
            }
            if (TimeLeft <= 0)
            {
                TimeLeftTxb.Text = "0.00";
                TimeLeftPb.Value = 0;
                StopGame(-1);
            }
            else
            {
                TimeLeftPb.Maximum = TimeAllowed;
                TimeLeftPb.Value = TimeLeft;
                TimeLeftTxb.Text = (TimeLeft / 1000.0).ToString("#0.00");
            }
        }

        private void EndGame()
        {
            PMTimer.Stop();
            GameplayPnl.Enabled = false;
        }

        private void PairMatching_SizeChanged(object sender, EventArgs e)
        {
            GameplayPnl.Size = new Size(this.Size.Width - 30, this.Size.Height - 80);
        }

        private void StopGame(int result)
        {
            EndGame();
            switch (result)
            {
                case 1:
                    MessageBox.Show("You win");
                    break;
                case -1:
                    MessageBox.Show("You lose");
                    break;
                default:
                    MessageBox.Show("Error 404");
                    break;
            }
            Rating = Convert.ToInt32(Score * (1 + 0.00001 * TimeLeft * Lives / (Lives + 1)) + 2.5 * Lives * (CorrectCount / GenerationCount));
            RatingLbl.Text = Rating.ToString();
        }

        private int Check()
        {
            if (Hold_Count == Constants._pm_maxhold)
            {
                int ans = Holds[0].Answer;
                foreach (var h in Holds)
                {
                    if (ans != h.Answer) return 0;
                }
                return 1;
            }
            else return -1;
        }
    }

    public enum PairMatching_QuestionDifficulty
    {
        EASY = 0,
        HARD = 1
    }

    public enum PairMatching_GameDifficulty
    {
        EASY = 0,
        MEDIUM = 1,
        HARD = 2
    }

    public enum BasicOperator
    {
        PLUS = 1,
        MINUS = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }

    public struct PairMatching_TagStruct
    {
        public int QIndex { get; set; }
        public int BIndex { get; set; }
        public int Answer { get; set; }

        public PairMatching_TagStruct(int qindex, int bindex, int answer)
        {
            QIndex = qindex;
            BIndex = bindex;
            Answer = answer;
        }
    }

    public static class Constants
    {
        public static int
            _pm_btnhsize = 100,
            _pm_btnvsize = 50,
            _pm_btnvgap = 10,
            _pm_btnhgap = 15,
            _pm_gencnt = 10,
            _pm_maxhold = 2,
            _pm_lives = 5,
            _pm_base_score = 5,
            gametick_length = 20;
    }

    public static class Utilities
    {
        public static Random rd = new Random();
        public static string GetBasicOperatorAsString(BasicOperator _operator)
        {
            switch (_operator)
            {
                case BasicOperator.PLUS:
                    return "+";
                case BasicOperator.MINUS:
                    return "-";
                case BasicOperator.MULTIPLY:
                    return "*";
                case BasicOperator.DIVIDE:
                    return "/";
                default:
                    return "";
            }
        }
    }

    public class PairMatching_Question
    {
        public int Operand1, Operand2;
        public BasicOperator Operator;

        public PairMatching_Question(int operand1, int operand2, BasicOperator _operator)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Operator = _operator;
        }

        public string GetQuestionAsString()
        {
            return Operand1.ToString() + Utilities.GetBasicOperatorAsString(Operator) + Operand2.ToString();
        }

        public string GetAnswerAsString()
        {
            int Answer = 0;
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
                    Answer = Operand1 / Operand2;
                    break;
                default:
                    Answer = 0;
                    break;
            }
            return Answer.ToString();
        }
    }

    public class PairMatching_QuestionPair
    {
        PairMatching_Question Question1 = new PairMatching_Question(1,1,BasicOperator.PLUS), 
            Question2 = new PairMatching_Question(1,1, BasicOperator.PLUS);
        PairMatching_QuestionDifficulty Difficulty;
        private int CommonAnswer;

        public PairMatching_QuestionPair(int generation_range, PairMatching_QuestionDifficulty difficulty)
        {
            Difficulty = difficulty;
            Question1.Operator = (BasicOperator)(Utilities.rd.Next(4) + 1);
            switch (Question1.Operator)
            {
                case BasicOperator.PLUS:
                    Question1.Operand1 = Utilities.rd.Next(1, generation_range);
                    Question1.Operand2 = Utilities.rd.Next(1, generation_range);
                    CommonAnswer = Question1.Operand1 + Question1.Operand2;
                    break;
                case BasicOperator.MINUS:
                    Question1.Operand2 = Utilities.rd.Next(1, generation_range);
                    CommonAnswer = Utilities.rd.Next(1, generation_range);
                    Question1.Operand1 = Question1.Operand2 + CommonAnswer;
                    break;
                case BasicOperator.MULTIPLY:
                    Question1.Operand1 = Utilities.rd.Next(1, generation_range);
                    Question1.Operand2 = Utilities.rd.Next(1, generation_range);
                    CommonAnswer = Question1.Operand1 * Question1.Operand2;
                    break;
                case BasicOperator.DIVIDE:
                    Question1.Operand2 = Utilities.rd.Next(1, generation_range);
                    CommonAnswer = Utilities.rd.Next(2, generation_range);
                    Question1.Operand1 = Question1.Operand2 * CommonAnswer;
                    break;
                default:
                    break;
            }
            Question2.Operator = (BasicOperator)(Utilities.rd.Next(4) + 1);
            double chance = 0.06, seed = 0.0;
            int i = 1;
            switch (Question2.Operator)
            {
                case BasicOperator.PLUS:
                    Question2.Operand1 = Utilities.rd.Next(0, Math.Min(generation_range, CommonAnswer));
                    Question2.Operand2 = CommonAnswer - Question2.Operand1;
                    break;
                case BasicOperator.MINUS:
                    Question2.Operand1 = Utilities.rd.Next(CommonAnswer, CommonAnswer + 2 * generation_range - 1);
                    Question2.Operand2 = Question2.Operand1 - CommonAnswer;
                    break;
                case BasicOperator.MULTIPLY:
                    while (true)
                    {
                        if (CommonAnswer % i != 0)
                        {
                            i++;
                            continue;
                        }
                        seed = Utilities.rd.NextDouble();
                        if (seed > chance) break;
                        i++;
                        chance = 1.0 - Math.Pow(1.0 - chance, Utilities.rd.NextDouble() + 1.0);
                    }
                    break;
                case BasicOperator.DIVIDE:
                    Question2.Operand2 = Utilities.rd.Next(1, generation_range);
                    Question2.Operand1 = CommonAnswer * Question2.Operand2;
                    break;
                default:
                    break;
            }
        }

        public List<String> GetQuestionPairasStrings()
        {
            List<String> result = new List<string>();
            result.Add(Question1.GetQuestionAsString());
            switch (Difficulty)
            {
                case PairMatching_QuestionDifficulty.EASY:
                    result.Add(Question1.GetAnswerAsString());
                    break;
                case PairMatching_QuestionDifficulty.HARD:
                    result.Add(Question2.GetQuestionAsString());
                    break;
                default:
                    break;
            }
            return result;
        }

        public int GetCommonAnswer
        {
            get { return CommonAnswer; }
        }

    }
    
}
