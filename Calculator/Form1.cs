namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double result = 0;
        private string operation = "";
      


        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btn0.Text;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += btnDot.Text;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

       
       
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(num).ToString();
        }

        private void btnTube_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(num, 1.0 / 3.0).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //reslt = double.Parse(textBox1.Text);
                operation = btn.Text;
                //textBox1.Text += " " + operation + " ";
                textBox1.Text += operation;


            }
        }

        private void btnMinute_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //result = double.Parse(textBox1.Text);
                operation = btn.Text;
                textBox1.Text += operation;


            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //result = double.Parse(textBox1.Text);
                operation = btn.Text;
                textBox1.Text += operation;


            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //result = double.Parse(textBox1.Text);
                operation = btn.Text;
                textBox1.Text += operation;


            }
        }


        private void btnPower_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //result = double.Parse(textBox1.Text);
                operation = btn.Text;
                textBox1.Text += operation;


            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {


            double secondNum = 0;
            double firstNum = 0;
            //char[] operators = { '+', '-', '*', '/', '^' };
            char[] AriOperator = { '+', '-', '*', '/', '^' };
            int firstOperator = textBox1.Text.IndexOfAny(AriOperator);
            int lastOperator = textBox1.Text.LastIndexOfAny(AriOperator);
            firstNum = double.Parse(textBox1.Text.Substring(0, firstOperator));
            secondNum = double.Parse(textBox1.Text.Substring(lastOperator + 1));
            //operation = textBox1.Text.Substring(firstOperator, 1);// work first operator
            //operation = textBox1.Text.Substring(lastOperator,1);// work last operator

            //switch (operation)
            //{
            //    case "+":
            //        result = firstNum + secondNum;
            //        //result += secondNum;
            //        break;
            //    case "-":
            //        result = firstNum - secondNum;
            //        break;
            //    case "*":
            //        result = firstNum * secondNum;
            //        break;
            //    case "/":
            //        result = (secondNum != 0) ? firstNum / secondNum : double.NaN;
            //        break;
            //    case "^":
            //        result = Math.Pow(firstNum, secondNum);
            //        break;
            //}
            //textBox1.Text = result.ToString();

            string input = textBox1.Text;
            string currentNumber ="";
            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();
           

            foreach(char ch in input)
            {
                if (char.IsDigit(ch) || ch == '.')
                {

                    currentNumber += ch;
                }
                else if (AriOperator.Contains(ch))
                {
                    if (!string.IsNullOrEmpty(currentNumber))
                    {
                        numbers.Add(double.Parse(currentNumber));
                        currentNumber = "";
                    }
                    operators.Add(ch);
                }
            }



            if(currentNumber != "")
            {
                numbers.Add(double.Parse(currentNumber));
            }

            if (numbers.Count == 0 || numbers.Count != operators.Count + 1)
            {
                textBox1.Text = "Error";
                return;
            }

            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '^')
                {
                    numbers[i] = Math.Pow(numbers[i], numbers[i + 1]);
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    if (operators[i] == '*')
                        numbers[i] *= numbers[i + 1];
                    else if (numbers[i + 1] != 0)
                        numbers[i] /= numbers[i + 1];
                    else
                    {
                        textBox1.Text = "Error (Divide by 0)";
                        return;
                    }
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
            }

            double result = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '+')
                    result += numbers[i + 1];
                else if (operators[i] == '-')
                    result -= numbers[i + 1];
            }
            textBox1.Text = result.ToString();
        }




    }
}
