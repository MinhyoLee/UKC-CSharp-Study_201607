using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Cacluator
    {
        string expression;
        string convExp;

        public Cacluator(string expression)
        {
            convExp = "";
            this.expression = expression;
        }

        public string Expression { get { return this.expression; }  set { this.expression = value; } }
        public string ConvExpreesion { get { return this.convExp;  } set { } }

        int getOpPrec(char op)
        {
            switch (op)
            {
                case '*':
                case '/':
                    return 5;
                case '+':
                case '-':
                    return 3;
                case '(':
                    return 1;
            }
            return -1;
        }

        int whoPreOp(char op1, char op2)
        {
            int op1Prec = getOpPrec(op1);
            int op2Prec = getOpPrec(op2);

            if (op1Prec > op2Prec)
            {
                return 1;
            }
            else if (op1Prec < op2Prec)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public void ConvToRPNExp()
        {
            Stack<char> stack = new Stack<char>();
            int i;
            int numInt;
            char tok, popOp;
            for (i = 0; i < expression.Length; i++)
            {
                tok = expression[i];
                if (int.TryParse(tok.ToString(), out numInt) || tok == '.')
                {
                    convExp += tok.ToString();
                }
                else
                {
                    switch (tok)
                    {
                        case '(':
                            stack.Push(tok);
                            break;
                        case ')':
                            while (true)
                            {
                                popOp =  stack.Pop() ;
                                if (popOp == '(')
                                {
                                    break;
                                }
                                convExp += popOp.ToString();
                            }
                            break;
                        case '+': case '-':
                        case '*': case '/':
                            while (stack.Count != 0 && whoPreOp(stack.Peek(), tok) >= 0)
                            {
                                convExp += " ";
                                convExp += stack.Pop().ToString();
                            }
                            stack.Push(tok);
                            break;
                    }
                }

            }
            while (stack.Count != 0)
            {
                convExp += " ";
                convExp += stack.Pop().ToString();
            }
        }

        public string EvalRPNExp()
        {
            this.ConvToRPNExp();
            double  op1, op2;
            double tempDouble;
            //int tempInt;
            MessageBox.Show(convExp);
            string[] splited = convExp.Split(' ');
            Stack<double> stack = new Stack<double>();



            foreach (string i in splited)
            {
                if (double.TryParse(i, out tempDouble))
                {
                    stack.Push(tempDouble);
                }
                else
                {
                    
                    op2 = stack.Pop();
                    op1 = stack.Pop();

                    switch (i)
                    {
                        case "+":
                            stack.Push(op1 + op2);
                            break;
                        case "-":
                            stack.Push(op1 - op2);
                            break;
                        case "*":
                            stack.Push(op1 * op2);
                            break;
                        case "/":
                            try
                            {
                                stack.Push(op1 / op2);
                            }
                            catch (DivideByZeroException e)
                            {
                                MessageBox.Show(e.Message);
                                return "Z";
                            }
                            break;
                    } 
                }
                
            }
            //return double.Parse(stack.Pop());
            return stack.Pop().ToString();
        }
    }
}
