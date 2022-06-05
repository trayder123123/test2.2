using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;

namespace test2
{
    public partial class Form2 : Form
    {
        string ant;
        public Form2()
        {
            InitializeComponent();
        }
        System.IO.StreamReader Read;
        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\programtest.txt", Encoding);
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");


            }
            путь();
        }
        void путь()
        {
            
            ant = File.ReadAllText("programtest.txt");
            Read.Close();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==ant)
            {

                Form4 f = new Form4();
                f.Show();
                Close();
            }
            else
            {
                label1.Text = "ТЫ ТОЧНО ЗНАЕШЬ ПАРОЛЬ";


            }
            start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ant)
            {
                Form5 f = new Form5();
                f.Show();
                Close();
            }
            else
            {

                label1.Text = "Ведите старый пароль";


            }
        }
    }
}





