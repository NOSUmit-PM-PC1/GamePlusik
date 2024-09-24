using System;
using System.Windows.Forms;

namespace GamePlusik
{
    public partial class FormGame : Form
    {
        int currentNumber = 1;
        int targetNumber = 15;
        int countSteps = 0;

        public FormGame()
        {
            InitializeComponent();
        }

        void CheckStep()
        {
            countSteps++;
            labelCountSteps.Text = "Количество шагов: " + countSteps.ToString();
            labelCurrent.Text = currentNumber.ToString();
            string message = "";
            if (currentNumber == targetNumber)
                message = "Победа!";
            else
                if (currentNumber > targetNumber)
                message = "Проиграл!";
            if (message != "")
            {
                MessageBox.Show(message);
                currentNumber = 1;
                labelCurrent.Text = currentNumber.ToString();
                countSteps = 0;
                labelCountSteps.Text = "Количество шагов: " + countSteps.ToString();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            currentNumber++;
            CheckStep();
        }

        private void buttonMulty_Click(object sender, EventArgs e)
        {
            currentNumber *= 2;
            CheckStep();
        }
    }
}
