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
    public partial class PairMatching : Form
    {
        public List<String> QuestionList;
        public List<Button> QBtnList;

        public PairMatching()
        {
            InitializeComponent();
        }

        private void Data_Initialization()
        {
            QuestionList.Clear();
            List<String> tmp = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                tmp = (new PairMatching_QuestionPair(20, PairMatching_Difficulty.EASY)).GetQuestionPairasStrings();
                foreach(string s in tmp)
                {
                    QuestionList.Add(s);
                }
            }
            QBtnList.Clear();
            List<int> Permute = RandomPermute(QuestionList.Count);
            Button btn = new Button();
            Point pt = new Point(0, 0);
            int max_horizontal_size = (int)Math.Truncate(Math.Sqrt(QuestionList.Count));
            for (int i = 0, currow = 0, curcol = 0; i < QuestionList.Count; i++, curcol++)
            {
                if (curcol >= max_horizontal_size)
                {
                    currow += curcol / max_horizontal_size;
                    curcol %= max_horizontal_size;
                }
                btn.Tag = (i / 2) + 1;
                btn.Text = QuestionList[Permute[i]];
                btn.Size = new Size(Constants._pm_btnhsize, Constants._pm_btnvsize);
                btn.Location = new Point(currow * (Constants._pm_btnhsize + Constants._pm_btnhgap), curcol * (Constants._pm_btnvsize + Constants._pm_btnvgap));
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

        }
    }

    public enum PairMatching_Difficulty
    {
        EASY = 0,
        HARD = 1
    }

    public enum BasicOperator
    {
        PLUS = 1,
        MINUS = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }

    public static class Constants
    {
        public const int _pm_btnhsize = 100, _pm_btnvsize = 50, _pm_btnvgap = 15, _pm_btnhgap = 15;
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
        PairMatching_Question Question1, Question2;
        PairMatching_Difficulty Difficulty;
        int CommonAnswer;

        public PairMatching_QuestionPair(int generation_range, PairMatching_Difficulty difficulty)
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
                case PairMatching_Difficulty.EASY:
                    result.Add(Question1.GetAnswerAsString());
                    break;
                case PairMatching_Difficulty.HARD:
                    result.Add(Question2.GetQuestionAsString());
                    break;
                default:
                    break;
            }
            return result;
        }

    }
    
}
