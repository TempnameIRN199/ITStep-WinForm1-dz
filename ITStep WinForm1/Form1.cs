using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITStep_WinForm1
{
    public partial class Угадайка : Form
    {
        private int secretNumber;
        private int numGuesses;

        public Угадайка()
        {
            InitializeComponent();
            NewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void NewGame()
        {
            secretNumber = new Random().Next(1, 2001);
            numGuesses = 0;
            MessageBox.Show("Я загадал число от 1 до 2000. Угадайте его!", "Игра началась");
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess;
            if (int.TryParse(GuessTextBox.Text, out guess))
            {
                numGuesses++;
                if (guess == secretNumber)
                {
                    MessageBox.Show($"Вы угадали число за {numGuesses} попыток!", "Победа!");
                    if (MessageBox.Show("Хотите сыграть еще раз?", "Новая игра", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        NewGame();
                    }
                    else
                    {
                        Close();
                    }
                }
                else if (guess < secretNumber)
                {
                    MessageBox.Show("Загаданное число больше.");
                }
                else
                {
                    MessageBox.Show("Загаданное число меньше.");
                }
            }
            else
            {
                MessageBox.Show("Введите целое число.");
            }
            GuessTextBox.Clear();
            GuessTextBox.Focus();
        }
    }
}
