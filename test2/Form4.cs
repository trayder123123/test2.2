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
using System.Diagnostics;
using System.Runtime.Remoting.Channels;
using System.Text.RegularExpressions;

namespace test2
{
    public partial class Form4 : Form
    {

        System.IO.StreamReader Read;
        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\t.txt", Encoding);
               
                
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");


            }
            загрузка();
        }
        void загрузка()
        {
            textBox1.Text = Read.ReadToEnd();



            остановка();
        }
        void остановка()
        {

            Read.Close();

        }
        void start2()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\tt.txt", Encoding);


            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");


            }
            загрузка2();
        }
        void загрузка2()
        {
            label1.Text = Read.ReadToEnd();



            
        }
        
        public Form4()
        {
            InitializeComponent();
            
        }

        


        private void Form4_Load(object sender, EventArgs e)
        {
            start();
            start2();

        }
        private void button1_Click(object sender, EventArgs e)
        {
             File.WriteAllText("t.txt",textBox1.Text);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
    
}
