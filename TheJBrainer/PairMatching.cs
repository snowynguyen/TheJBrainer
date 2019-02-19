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
        public PairMatching()
        {
            InitializeComponent();
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

    public static class Utilities
    {
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

        PairMatching_QuestionPair(int generation_range, PairMatching_Difficulty difficulty)
        {

        }

        

    }

}
