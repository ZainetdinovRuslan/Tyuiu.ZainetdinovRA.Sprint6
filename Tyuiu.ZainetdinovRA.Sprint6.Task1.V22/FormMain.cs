using System;
using System.Windows.Forms;
using Tyuiu.ZainetdinovRA.Sprint6.Task1.V22.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint6.Task1.V22
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }
        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {

            try
            {
                int startValue = int.Parse(textBoxStart.Text);
                int stopValue = int.Parse(textBoxStop.Text);

                if (startValue > stopValue)
                {
                    MessageBox.Show("Начальное значение должно быть меньше или равно конечному значению.", "Неверный диапазон", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double[] results = ds.GetMassFunction(startValue, stopValue);

                textBoxResults.Clear();
                textBoxResults.AppendText("X\tf(X)\r\n");
                textBoxResults.AppendText("----------------\r\n");

                for (int i = 0; i < results.Length; i++)
                {
                    int x = startValue + i;
                    textBoxResults.AppendText($"{x}\t{results[i]:F2}\r\n");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные целые значения для начала и конца диапазона.", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void buttonInformation_RA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск первый выполнил студент группы ИИПБ-24-2 Зайнетдинов Руслан Александрович");
        }

    }
}