using System;
using System.Windows.Forms;

namespace Calc
{
  public partial class Form1 : Form
  {
    private double CurrentNum { get; set; }
    private double MemoryNum { get; set; }
    private double TypedNum { get; set; }
    private bool IsFirstNum { get; set; }
    private double LastCalNum { get; set; }

    public Form1()
    {
      InitializeComponent();

      ClearAll();
    }

    /// <summary>
    /// 초기화
    /// </summary>
    private void ClearAll()
    {
      CurrentNum = 0;
      MemoryNum = 0;
      TypedNum = 0;
      IsFirstNum = true;
      txtResultNum.Text = "0";
      txtLastFuntion.Text = string.Empty;
    }

    /// <summary>
    /// 숫자 버튼 클릭
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnNumber_Click(object sender, EventArgs e)
    {
      if (IsFirstNum && !((Button)sender).Text.Equals("."))
      {
        txtResultNum.Text = string.Empty;
        IsFirstNum = false;
      }

      txtResultNum.Text = txtResultNum.Text + ((Button)sender).Text;
    }

    /// <summary>
    /// 기능 버튼 클릭
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnFunction_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtLastFuntion.Text) && IsFirstNum == false)
      {
        if (!IsFirstNum)
          LastCalNum = double.Parse(txtResultNum.Text);

        CurrentNum = Cal(txtLastFuntion.Text, CurrentNum, LastCalNum);
        txtResultNum.Text = CurrentNum.ToString();
      }
      else
      {
        CurrentNum = double.Parse(txtResultNum.Text);
      }

      if (!((Button)sender).Text.Equals("="))
        txtLastFuntion.Text = ((Button)sender).Text;

      IsFirstNum = true;
    }

    /// <summary>
    /// 초기화
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnClear_Click(object sender, EventArgs e)
    {
      ClearAll();
    }

    /// <summary>
    /// 사칙연산 수행
    /// </summary>
    /// <param name="function"></param>
    /// <param name="firstNum"></param>
    /// <param name="secondNum"></param>
    /// <returns></returns>
    private double Cal(string function, double firstNum, double secondNum)
    {
      double result = 0;

      switch (function)
      {
        case "+":
          result = firstNum + secondNum;
          break;

        case "-":
          result = firstNum - secondNum;
          break;

        case "X":
          result = firstNum * secondNum;
          break;

        case "/":
          result = secondNum.Equals(0) ? 0 : firstNum / secondNum; //divide by zero
          break;
      }

      return result;
    }

    private void btnMemoryFunction_Click(object sender, EventArgs e)
    {
      switch (((Button)sender).Text)
      {
        case "M+":
          MemoryNum = MemoryNum + double.Parse(txtResultNum.Text);
          IsFirstNum = true;
          break;
        case "M-":
          MemoryNum = MemoryNum - double.Parse(txtResultNum.Text);
          IsFirstNum = true;
          break;
        case "MR":
          txtResultNum.Text = MemoryNum.ToString();
          CurrentNum = MemoryNum;
          txtLastFuntion.Text = string.Empty;
          break;
      }

      txtMemoryNum.Text = MemoryNum.ToString();
    }
  }
}
