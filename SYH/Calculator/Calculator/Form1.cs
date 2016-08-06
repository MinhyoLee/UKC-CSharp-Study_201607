using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum Operators { Add, Sub, Mul, Div }

    public partial class Form1 : Form
    {
        public float Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public bool memoryCheck = false;
        public float memoryData = 0;

        //소스점 (소스점 1개만 들어가는 예외처리)
        //전체적으로 보기


        public Form1()
        {
            InitializeComponent();
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                calculatorLabel.Text = num;
                isNewNum = false;
            }
            else if (calculatorLabel.Text == "0")
            {

                calculatorLabel.Text = num;
            }
            else
            {
                calculatorLabel.Text = calculatorLabel.Text + num;
            }
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                float num = float.Parse(calculatorLabel.Text);
                if (Opt == Operators.Add)
                {
                    Result = Result + num;
                }
                else if (Opt == Operators.Sub)
                {
                    Result = Result - num;
                }
                else if (Opt == Operators.Mul)
                {
                    Result = Result * num;
                }
                else if (Opt == Operators.Div)
                {
                    if(num == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                    }else
                    {
                        Result = Result / num;
                    }
                    
                }
                    

                calculatorLabel.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            calculatorTopLabel.Text = calculatorLabel.Text + " " + optButton.Text;            
            if (optButton.Text == "+") { 
                Opt = Operators.Add;
            }
            else if (optButton.Text == "-")
            {
                Opt = Operators.Sub;
            }                
            else if (optButton.Text == "*")
            {
                Opt = Operators.Mul;
            }                
            else if (optButton.Text == "/")
            {
                Opt = Operators.Div;
            }
            else
            {
                calculatorTopLabel.Text = "";
            }

        }


        private void CleanButton_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;
            calculatorLabel.Text = "0";
            calculatorTopLabel.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
          
            if(calculatorLabel.Text.Length == 1)
            {
                calculatorLabel.Text = "0";
            }
            else
            {
                calculatorLabel.Text = calculatorLabel.Text.Substring(0, calculatorLabel.Text.Length - 1);
            }

        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            float num = float.Parse(calculatorLabel.Text);
            calculatorLabel.Text = (0 - num).ToString();
        }

        private void memorySaveButton_Click(object sender, EventArgs e)
        {
            memoryCheck = true;
            memoryData = float.Parse(calculatorLabel.Text);
            memoryLabel.Text = "M";
        }

        private void memoryReadButton_Click(object sender, EventArgs e)
        {
            if (memoryCheck)
            {
                calculatorLabel.Text = memoryData.ToString();
            }
        }

        private void memoryCleanButton_Click(object sender, EventArgs e)
        {
            memoryCheck = false;
            memoryData = 0;
            memoryLabel.Text = "";
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if(calculatorLabel.Text.IndexOf(".") == -1)
            {
                isNewNum = false;
                calculatorLabel.Text = calculatorLabel.Text + ".";
            }
            
        }
    }
}
