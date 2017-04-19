using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chislo1
{
    public partial class Form2 : Form
    {
        int i = 25;
        int zadumano;
        int nomer_popitki;
        int b;
       
        
        public Form2(  int ch) 
        {
            InitializeComponent();
            label2.Text = "Попыток:0";
            button1.Visible = false;
            Random n = new Random();
            zadumano = n.Next(ch);
            timer1.Start();
          
            
           b = ch;
           
           
        }
        
  
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = "У вас осталось " + Convert.ToString(i) + " сек";
            if (i == 0)
            {
                timer1.Enabled = false;
                textBox1.Enabled = false;
                
                label4.Text = "Увы, время истекло...";
                button1.Visible = true;
            }
            i--;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (label1.Text != "")
            {
                i = Convert.ToInt32(label1.Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
           
            
               
               
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                try
                {

                    if (Convert.ToInt16(textBox1.Text) == zadumano)
                    {
                        textBox1.Enabled = false;
                        button1.Visible = true;

                        label1.Enabled = false;

                        timer1.Stop();
                        label3.Text = "Вы угадали! Задумывалось число " + Convert.ToString(zadumano);
                    };
                    if (Convert.ToInt16(textBox1.Text) > zadumano) label3.Text = "Задуманное число меньше";
                    if (Convert.ToInt16(textBox1.Text) < zadumano) label3.Text = "Задуманное число больше";
                }
                catch { label3.Text = "Некорректные входные данные!"; }
                nomer_popitki++;
               label2.Text = "Попыток:" + Convert.ToString(nomer_popitki);
                textBox1.Text = "";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            textBox1.Enabled = true;
            label1.Enabled = true;
            label3.Text = ("");
            label4.Text = ("");
            nomer_popitki = 0;
            label2.Text = "Попыток:" + Convert.ToString(nomer_popitki);
            Random n = new Random();
           zadumano = n.Next(b);
           i = 25;
           label1.Text = "У вас осталось " + Convert.ToString(i) + " сек";

               timer1.Start();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
          
        }
    }
}
