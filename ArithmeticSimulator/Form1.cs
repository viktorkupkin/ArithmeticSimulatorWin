using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticSimulator
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        private void ButtonCheckOnOff()
        {
            if (textBox1.Text != "")
            {
                buttonChek.Enabled = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
            label1.Text = calculator.GetString();
            buttonChek.Enabled = false;
            labelPravOtvety.Text = "0";
            labelNepravOtvety.Text = "0";
            labelCountOfAnswer.Text = calculator.CountOfAnswer.ToString();
        }

        private void buttonChek_Click(object sender, EventArgs e)
        {

            buttonChek.Enabled = true;
            calculator.Otvet = Convert.ToInt32(textBox1.Text);
            if (calculator.Check())
            {
                labelPravOtvety.Text = calculator.Pravotvety.ToString();
                MessageBox.Show("Правильно! Продолжай в том же духе!", "Молодец!");
            }
            else
            {
                labelNepravOtvety.Text = calculator.NepravOtvety.ToString();
                MessageBox.Show("Ответ не правильный! Попробуй еще разок!", "Упс :(");
            }
            string message = "";
            string caption = "";
            if (calculator.CountOfAnswer == 0)
            {
                if (calculator.NepravOtvety < calculator.Pravotvety)
                {
                    message = $"Ты победил! Количество набранных очков: {calculator.Pravotvety - calculator.NepravOtvety}. Начать с начала?";
                    caption = "Поздравляем!";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        calculator.ResetCounts();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (calculator.NepravOtvety > calculator.Pravotvety)
                {
                    message = $"Ты проиграл! В следующий раз будь внимательнее. Попробовать еще раз?";
                    caption = "Сожалеем.";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        calculator.ResetCounts();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    message = $"Ничья! Надо позаниматься арифметикой. Сыграть еще раз?";
                    caption = "Ничья!.";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        calculator.ResetCounts();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            labelCountOfAnswer.Text = calculator.CountOfAnswer.ToString();
            label1.Text = calculator.GetString();
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                buttonChek.Enabled = true;
            }
            else
            {
                buttonChek.Enabled = false;
            }
        }
    }
}
