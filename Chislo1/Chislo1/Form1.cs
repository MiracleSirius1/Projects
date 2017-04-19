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
    
    public partial class Form1 : Form
    {
        public static int  ch;
        
        public Form1()
        {

            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

            Form1 f3 = new Form1();
            ch = 10;
            Form2 form1 = new Form2(ch);
            form1.Show();
            f3.Visible = false;
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 f3 = new Form1();
            ch = 50;
            Form2 form1 = new Form2(ch);
            form1.Show();
            f3.Visible = false;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
            ch = 100;
            Form2 form1 = new Form2(ch);
            form1.Show();
            f3.Visible = false;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
   
            Form1 f3 = new Form1();
            ch = 500;
            Form2 form1 = new Form2 (ch);
            form1.Show();
            f3.Visible = false;
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            Form1 f3 = new Form1();
            ch = 1000;
            Form2 form1 = new Form2(ch);
            form1.Show();
            f3.Visible = false;
            this.Hide();
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("                                                 Игра: <<Угадай число>>\nТы выбираешь уровень сложности, а я загадываю число.\nЧисло может быть от 0 до 1000,в зависимости от выбранного тобой уровня.\nУ тебя есть 25 секунд для того, чтобы угадать число.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created the program Sirius");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
    }
}
