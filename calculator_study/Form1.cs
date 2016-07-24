using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        List<double> numberBin = new List<double>();

        bool calTyped = false;
        bool numberProcessing = true;
        string now_cal = "";

        private double calTypeChecker(string type, double first, double second)
        {
            if (type.Equals("/"))
            {
                if(second == 0)
                {
                    return 0;
                }
                else
                {
                    return first / second;
                }             
                 
            }
            else if (type.Equals("*"))
            {
                if (second == 0)
                {
                    return 0;
                }
                else
                {
                    return first * second;
                }


            }
            else if (type.Equals("+"))
            {
                return first + second;
            }
            else
            {
                return first - second;
            }            
        }

        private void numberType(object sender)
        {
            Button checker = sender as Button;

            if (resultTextBox.Text.Equals("0"))
            {
                resultTextBox.Clear();
            }

            if (numberProcessing)
            {
                resultTextBox.Text += checker.Text;
            }
            else
            {
                resultTextBox.Clear();
                resultTextBox.Text += checker.Text;
                numberProcessing = true;
            }
          
            calTyped = false;
        }

        private void calType(object sender)
        {          
            if (!calTyped)
            {
                Button checker = sender as Button;               
                calTyped = true;
                numberProcessing = false;
                processTextBox.Text += resultTextBox.Text + " " + checker.Text + " ";              
                numberBin.Add(double.Parse(resultTextBox.Text));    
                
                if(numberBin.Count == 2)
                {
                    double subResult = calTypeChecker(now_cal, numberBin[0], numberBin[1]);
                    resultTextBox.Text = subResult.ToString("G");
                    numberBin.Clear();
                    numberBin.Add(double.Parse(resultTextBox.Text));
                }

                now_cal = checker.Text;
            }
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 1
            numberType(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //2
            numberType(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //3
            numberType(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4
            numberType(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            numberType(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6
            numberType(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //7
            numberType(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //8
            numberType(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //9
            numberType(sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //0
            numberType(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //00
            numberType(sender);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //process
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //result
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //divide
            calType(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //multiple
            calType(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //substraction
            calType(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //addition
            calType(sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //equal
            calTyped = true;
            numberProcessing = false;

            processTextBox.Clear();
            if(numberBin.Count > 0)
            {
                numberBin.Add(double.Parse(resultTextBox.Text));
                double subResult = calTypeChecker(now_cal, numberBin[0], numberBin[1]);
                resultTextBox.Text = subResult.ToString("G");
                numberBin.Clear();
                now_cal = resultTextBox.Text;
            }          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //point
            numberType(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //clear result view
            resultTextBox.Clear();
            resultTextBox.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //clear all
            resultTextBox.Clear();
            numberBin.Clear();
            processTextBox.Clear();
            resultTextBox.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //erase one point
            if (numberProcessing)
            {
                if (resultTextBox.Text.Length > 0)
                {
                    if(resultTextBox.Text.Length == 1)
                    {
                        resultTextBox.Text = "0";
                    }
                    else
                    {
                        resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Length - 1);
                    }
                }
            }
         
        }
    }
}
