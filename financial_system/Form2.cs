using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;


namespace financial_system
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) { }

        private void SumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;

            if (!Char.IsDigit(num) && num != 8 && num != 127)
            {
                e.Handled = true;
            }
        }
        private void SumBox_Click(object sender, EventArgs e)
        {
            SumBox.Text = SumBox.Text = "";
        }

        private void CategoryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileData = "..\\..\\file.txt";

            if (CategoryBox.Text != "" && CategoryBox.Text != "Выберете категорию"
                && SumBox.Text != "" && SumBox.Text != "Введите сумму")
            {
                File.AppendAllText(fileData, CategoryBox.Text + " - " + SumBox.Text + " руб\n");
                CategoryBox.Text = "Выберете категорию";
                SumBox.Text = "Введите сумму";
            }
            else
            {
                MessageBox.Show("Check code");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileData = "..\\..\\file.txt";

            string[] data = File.ReadAllLines(fileData);
            this.listBox1.DataSource = data;
        }
    }
}
