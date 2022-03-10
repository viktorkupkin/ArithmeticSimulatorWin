using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticSimulator
{
    class Calculator
    {
        public int Num1 { set; get; } = 0;
        public int Num2 { set; get; } = 0;
        private string MyString = "";
        private char Add = '+';
        private char Substract = '-';
        private char Space = ' ';
        private Random rnd = new Random();
        private Random rnd2 = new Random();
        public int Otvet { set; get; }
        public int Result { set; get; }
        public int Pravotvety { set; get; } = 0;
        public int NepravOtvety { set; get; } = 0;
        public int CountOfAnswer { set; get; } = 20;
        public void ResetCounts()
        {
            Pravotvety = 0;
            NepravOtvety = 0;
            CountOfAnswer = 20;
        }
        public Calculator() { }
        public Calculator(int n1, int n2)
        {
            Num1 = n1;
            Num2 = n2;
        }
        public string GetString()
        {
            Num1 = rnd.Next(1, 10);
            Num2 = rnd.Next(1, 10);
            char[] arithmeticSigns = new Char[] { Add, Substract };
            //Console.WriteLine(Convert.ToString(arithmeticSigns[0]) + " " + Convert.ToString( arithmeticSigns[1]));
            char sign = arithmeticSigns[rnd2.Next(0, 2)];
            //Console.WriteLine(Convert.ToString(sign));
            switch (sign)
            {
                case '+':
                    MyString = Num1.ToString() + Space + Add + Space + Num2.ToString();
                    Result = Num1 + Num2;
                    break;
                case '-':
                    if(Num1 >= Num2)
                    {
                        MyString = Num1.ToString() + Space + Substract + Space + Num2.ToString();
                        Result = Num1 - Num2;
                    }
                    else
                    {
                        MyString = Num2.ToString() + Space + Substract + Space + Num1.ToString();
                        Result = Num2 - Num1;
                    }
                    break;
            }
            return MyString;
        }
        public bool Check()
        {
            if(Result == Otvet)
            {
                ++Pravotvety;
            }
            else
            {
                ++NepravOtvety;
            }
            --CountOfAnswer;
            return Result == Otvet;
        }
    }
}
