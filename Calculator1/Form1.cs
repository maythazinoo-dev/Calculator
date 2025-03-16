namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operation = "";
        double result = 0;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            textBox.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0"; // Keep the "0" when it's the first digit.
            }
            else
            {
                textBox.Text += btn0.Text; // Append "0" if there's already a number.
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            //if (textBox.Text == "0")
            //{
            //    textBox.Clear();
            //}
            textBox.Text += btnDot.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBox.Text += btnAdd.Text;
            operation = btnAdd.Text;

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            textBox.Text += btnSub.Text;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBox.Text += btnMultiply.Text;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textBox.Text += btnDivide.Text;
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            textBox.Text += btnPower.Text;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox.Text);
            textBox.Text = Math.Sqrt(num).ToString();
        }

        private void btnTube_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox.Text);
            textBox.Text = Math.Pow(num, 1.0 / 3.0).ToString();
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string input = textBox.Text;
            string curremtNumber = "";
            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();
            char[] chars = { '+', '-', '*', '/', '6' };

            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    curremtNumber += c;
                }
                else if (chars.Contains(c))
                {
                    if (!string.IsNullOrEmpty(curremtNumber))
                    {

                        numbers.Add(double.Parse(curremtNumber));
                        curremtNumber = "";

                    }

                    operators.Add(c);
                }

            }

            if (curremtNumber !="")
            {
                numbers.Add(double.Parse(curremtNumber));
            }

            if (numbers.Count == 0 || numbers.Count != operators.Count + 1)
            {
                textBox.Text = "Error";
                return;
            }

            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '^')
                {
                    numbers[i] = Math.Pow(numbers[i],numbers[i + 1]);
                    numbers.RemoveAt(i+1);
                    operators.RemoveAt(i);
                    i--;

                }

            }

            for(int i=0; i < operators.Count; i++)
            {
                if (operators[i] == '*'|| operators[i]=='/')
                {
                    if (operators[i] == '*')
                    {
                        numbers[i] = numbers[i] * numbers[i + 1];
                    }
                    else if(numbers[i+1] != 0)
                        {
                            numbers[i] = numbers[i] / numbers[i + 1];
                        }
                    else
                    {
                        textBox.Text = "not Devided by 0";
                        return;
                    }
                        numbers.RemoveAt(i+1);
                        operators.RemoveAt(i);
                         i--;
                 

                }
            }

            result = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            
            {
                if (operators[i] == '+')
                {
                    result += numbers[i + 1];
                }

                else if (operators[i] == '-')
                    result -= numbers[i + 1];
            }

            textBox.Text = result.ToString();
        }
    }

}
    


        

    

