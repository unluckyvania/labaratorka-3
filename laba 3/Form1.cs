using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x, y, result;

            // Преобразуем текст из textBoxX в число
            bool okX = double.TryParse(textBoxX.Text, out x);
            if (!okX)
            {
                MessageBox.Show("Неверный формат числа: " + textBoxX.Text);
                return;
            }

            // Преобразуем текст из textBoxY в число
            bool okY = double.TryParse(textBoxY.Text, out y);
            if (!okY)
            {
                MessageBox.Show("Неверный формат числа: " + textBoxY.Text);
                return;
            }

            // Формула варианта 27: (10 * x + 23 * y) / 2
            result = (10 * x + 23 * y) / 2;

            // Выводим результат
            labelResult.Text = result.ToString();
        }
    }
}
