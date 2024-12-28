using Tyuiu.ZainetdinovRA.Sprint6.Task0.V5.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        private DataService ds;
        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxXValue_RA.Text.Trim(), out int x))
            {

                double result = ds.Calculate(x);
                textBoxResult_RA.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное значение x (целое число).", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by Ruslan Zainetdinov");
            this.Close();
        }

        private void btnInfo_RA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск нулевой выполнил студент группы ИИПБ-24-2 Зайнетдинов Руслан Александрович");
        }
    }
}
