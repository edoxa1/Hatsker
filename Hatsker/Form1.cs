using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hatsker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void ChangeForm(string col, string title, string width,string height)
        {
            this.BackColor = Color.FromName(col);
            this.Text = title;

            this.Width = Convert.ToInt32(width);
            this.Height = Convert.ToInt32(height);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter something in Text Boxes");
            }
            else
            {
                string BackgroundColor = textBox1.Text;
                string FormTitle = textBox2.Text;
                string wdth = textBox3.Text;
                string hght = textBox4.Text;
                ChangeForm(BackgroundColor, FormTitle, wdth, hght);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
