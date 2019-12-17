using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public static string prevEq = "", prevOp = "", oper = "";
        public static double ans = 0;
        private void Allbutt_Click(object sender, EventArgs e)
        {
            Button butt = sender as Button;

            switch (butt.Name)
            {
                case "buttce":
                    display.ResetText();
                    break;
                case "buttcle":
                    oper = "";
                    display.ResetText();
                    display2.ResetText();
                    break;
                case "buttdel":
                    if (display.Text.Length > 0) ;
                    {
                        display.Text = display.Text.Substring(0, display.Text.Length - 1);
                    }
                    break;
                case "buttdec":
                    if (!display.Text.Contains("."))
                    {
                        display.Text += ".";
                    }
                    break;
                case "buttadmin":
                    if (display.Text.Length > 0)
                    {
                        if (!display.Text.Contains("-"))
                        {
                            display.Text = "-" + display.Text;
                        }
                        else if (display.Text.Contains("-"))
                        {
                            display.Text = display.Text.Substring(1, display.Text.Length - 1);
                        }
                    }
                    break;
                default:
                    if (oper == "=")
                    {
                        oper = "";
                        display.ResetText();
                    }
                    display.Text += butt.Text;
                    break;
            }
        }
        private void AllOper_Click(object sender, EventArgs e)
        {
            Button opr = sender as Button;

            switch (opr.Text)
            {
                case "+":
                    if (display.Text.Length > 0)
                    {
                        if (oper == "" || oper == "=")
                        {
                            oper = "+";
                            prevOp = oper;
                            prevEq = display.Text;
                            display2.Text = display.Text + oper;
                            display.ResetText();

                        }
                    }
                    else
                    {
                        oper = "+";
                        multi_equa();
                    }
                    break;
                case "-":
                    if (display.Text.Length > 0)
                    {
                        if (oper == "" || oper == "=")
                        {
                            oper = "-";
                            prevOp = oper;
                            prevEq = display.Text;
                            display2.Text = display.Text + oper;
                            display.ResetText();

                        }
                    }
                    else
                    {
                        oper = "-";
                        multi_equa();
                    }
                    break;
                case "*":
                    if (display.Text.Length > 0)
                    {
                        if (oper == "" || oper == "=")
                        {
                            oper = "*";
                            prevOp = oper;
                            prevEq = display.Text;
                            display2.Text = display.Text + oper;
                            display.ResetText();

                        }
                    }
                    else
                    {
                        oper = "*";
                        multi_equa();
                    }
                    break;
                case "/":
                    if (display.Text.Length > 0)
                    {
                        if (oper == "" || oper == "=")
                        {
                            oper = "/";
                            prevOp = oper;
                            prevEq = display.Text;
                            display2.Text = display.Text + oper;
                            display.ResetText();

                        }
                    }
                    else
                    {
                        oper = "/";
                        multi_equa();
                    }
                    break;
                case "=":
                    if (display.Text.Length > 0)
                    {
                        oper = "=";
                        multi_equa();
                        display2.ResetText();
                        display.Text = ans.ToString();
                    }
                    break;
            }
        }
        private void multi_equa()
        {
            if (prevOp == "+")
            {
                prevOp = oper;
                ans = Convert.ToDouble(prevEq) + Convert.ToDouble(display.Text);

                prevEq = ans.ToString();
                display2.Text = prevEq + oper;
                display.ResetText();
            }
            else if (prevOp == "-")
            {
                prevOp = oper;
                ans = Convert.ToDouble(prevEq) - Convert.ToDouble(display.Text);

                prevEq = ans.ToString();
                display2.Text = prevEq + oper;
                display.ResetText();
            }
            else if (prevOp == "/")
            {
                prevOp = oper;
                ans = Convert.ToDouble(prevEq) / Convert.ToDouble(display.Text);

                prevEq = ans.ToString();
                display2.Text = prevEq + oper;
                display.ResetText();
            }
            if (prevOp == "*")
            {
                prevOp = oper;
                ans = Convert.ToDouble(prevEq)*Convert.ToDouble(display.Text);

                prevEq = ans.ToString();
                display2.Text = prevEq + oper;
                display.ResetText();
            }
        }
    }
}
