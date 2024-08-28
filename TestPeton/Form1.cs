using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestPeton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckTypeComboBox.SelectedIndex = 0;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text))
                MessageBox.Show("Введите текст!", "Проверка");
            else
                switch (CheckTypeComboBox.SelectedItem)
                {
                    case "Номер телефона":
                        if (Regex.IsMatch(TextBox.Text, "[0-9]{9}") && TextBox.Text.Length == 11)
                            MessageBox.Show("Всё ок", "Проверка");
                        else
                            MessageBox.Show("Введите коректный номер!", "Проверка");
                        break;
                    case "Почтовый адрес":
                        if (Regex.IsMatch(TextBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            MessageBox.Show("Всё ок", "Проверка");
                        else
                            MessageBox.Show("Это не почтовый адрес!", "Проверка");
                        break;
                    default:
                        MessageBox.Show("Всё ок", "Проверка");
                        break;
                }
        }
    }
}
