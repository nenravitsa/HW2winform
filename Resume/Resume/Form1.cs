using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = "Записаны следующие данные:" + Environment.NewLine + "Имя: " + textBox1.Text + Environment.NewLine + "Фамилия: " + textBox2.Text + Environment.NewLine + "Возраст: " + textBox3.Text + Environment.NewLine + "Город: " +  textBox4.Text + Environment.NewLine + "Профессия: " + textBox5.Text + Environment.NewLine + "Цвет: " + textBox6.Text;
        }


    }
}
