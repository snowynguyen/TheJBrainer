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
        public List<PairMatching_QuestionPair> QuestionList;

        public PairMatching()
        {
            InitializeComponent();
        }

        private void PairMatching_Load(object sender, EventArgs e)
        {
            PlayBtn.Visible = true;
            QuestionList.Clear();
            for (int i=0; i<5; i++)
            {
                QuestionList.Add(new PairMatching_QuestionPair(20, PairMatching_Difficulty.EASY));
                QuestionList.Add(new PairMatching_QuestionPair(20, PairMatching_Difficulty.HARD));
            }
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

    public class PairMathcing_Question
    {
        public int Operand1, Operand2;
        public BasicOperator Operator;

        public PairMathcing_Question(int operand1, int operand2, BasicOperator _operator)
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
        PairMathcing_Question Question1, Question2;
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

        

    }

}
