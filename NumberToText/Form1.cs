using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberToText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private Dictionary<int, string> less20;
        private Dictionary<int, string> multiple10;
        private Dictionary<int, string> multiple100;

        private string RemoveDecimal(string number)
        {
            if(number.IndexOf('.') > -1)
            {
                return number.Split('.')[0].ToString();
            }
            return number;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            lblWordedNumber.Text = string.Empty;
            lblFormatedNumber.Text = string.Empty;

            long.TryParse(RemoveDecimal(txtNum.Text), out long num);
            
            string numStr = $"{num:#,###,##0}";
            lblFormatedNumber.Text += numStr;

            string[] numArray = numStr.Split(',');
            for (int i = 0; i < numArray.Length; i++)
            {
                string word = $"{WholeNumberToWords(int.Parse(numArray[i]))}";
                word += word != string.Empty ? $" {multiple100[numArray.Length - i]} " : string.Empty;
                lblWordedNumber.Text += word;
            }
        }

        private string WholeNumberToWords(int num)
        {
            if (num > 0 && num < 20)
            {
                return less20[num];
            }
            else if (num > 0 && num < 100)
            {
                return $"{multiple10[num / 10]} {WholeNumberToWords(num % 10)}";
            }
            else if (num > 99)
            {
                return $"{less20[num / 100]} Hundred {WholeNumberToWords(num % 100)}";
            }

            return string.Empty;
        }

        private void Init()
        {
            less20 = new Dictionary<int, string>();
            less20.Add(1, "One");
            less20.Add(2, "Two");
            less20.Add(3, "Three");
            less20.Add(4, "Four");
            less20.Add(5, "Five");
            less20.Add(6, "Six");
            less20.Add(7, "Seven");
            less20.Add(8, "Eight");
            less20.Add(9, "Nine");
            less20.Add(10, "Ten");
            less20.Add(11, "Eleven");
            less20.Add(12, "Twelve");
            less20.Add(13, "Thirteen");
            less20.Add(14, "Fourteen");
            less20.Add(15, "Fifteen");
            less20.Add(16, "Sixteen");
            less20.Add(17, "Seventeen");
            less20.Add(18, "Eighteen");
            less20.Add(19, "Nineteen");

            multiple10 = new Dictionary<int, string>();
            multiple10.Add(2, "Twenty");
            multiple10.Add(3, "Thirty");
            multiple10.Add(4, "Forty");
            multiple10.Add(5, "Fifty");
            multiple10.Add(6, "Sixty");
            multiple10.Add(7, "Seventy");
            multiple10.Add(8, "Eighty");
            multiple10.Add(9, "Ninety");

            multiple100 = new Dictionary<int, string>();
            multiple100.Add(1, "");
            multiple100.Add(2, "Thousand");
            multiple100.Add(3, "Million");
            multiple100.Add(4, "Billion");
            multiple100.Add(5, "Trillion");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            lblFormatedNumber.Text = string.Empty;
            lblWordedNumber.Text = string.Empty;
        }
    }

   
}

