using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            //получаем значение текстового поля + отрезаем пробелы по краям:
            string userName = tbName.Text.Trim();
            if (userName.Length < 3) //если длина имени пользователя слишком коротная, ошибка!
            {
                MessageBox.Show("Введите имя пользователя!");
            }
            else 
            {
                MessageBox.Show("Привет " + userName);
            }        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
