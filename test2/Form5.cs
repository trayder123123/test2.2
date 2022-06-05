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
    public partial class Form5 : Form
    {
        public Form5()
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

                Read.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");


            }
            
        }
        
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                File.WriteAllText("programtest.txt", textBox1.Text);

          
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            start();
        }
    }
}
