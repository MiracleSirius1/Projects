using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Taimer1
{
    public partial class Form1 : Form
    {
        private DateTime t1;
        private DateTime t2;
       
        

        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Maximum = 159;
            numericUpDown2.Minimum = 0;

            numericUpDown1.TabStop = false;

            numericUpDown2.Maximum = 159;
            numericUpDown2.Minimum = 0;
            numericUpDown2.TabStop = false;


        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Interval = 100;
            timer1.Start();
        }
        public void timer1_tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("hh:mm:ss");
           
        } 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sdsdToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                               Описание программы Helper\n   Эта программа предназначена для удобства,в неё входят такие функции как:\n 1) Таймер выключения компьютера\n 2) Перезагрузка компьютера\n 3) Секундомер\n 4) Проверка пакетов\n 5) Проверка Пинга\n 6) Календарь\n 7) Показывает текущее время\n 8)Конверт\n 9)Вк\n 10)Ютуб\n 11)Твич\n 12)Дотабаф\n 13)Переводчик\n 14)Киного\n 15)Майлру\n\n\n Created the program Sirius");
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void оToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate("https://m.vk.com/feed");
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/playlist?list=PLK4VJAcToLpSwPmKUkCeEG48kybRHjNny");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string command = "ping google.com -t";
            System.Diagnostics.Process.Start("cmd.exe", "/C " + command);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.speedtest.net/ru");
        }

        private void label1_Click(object sender, EventArgs e)
        {
         

        }
        int i;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (timer3.Enabled)
            {
                timer3.Stop();
            }
            else
            {
                timer3.Start();
            }



           
        }
        DialogResult dialog;
        
        public void button6_Click(object sender, EventArgs e)
        {
           
             if (!timer2.Enabled)
            {
                t1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                t2 = t1.AddMinutes((double)numericUpDown1.Value);
                t2 = t2.AddSeconds((double)numericUpDown2.Value);
               
                groupBox1.Enabled = false;
                dialog = MessageBox.Show("Выключить компьютер при окончании таймера?", "Выключение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                button6.Text = "Стоп";
                
                if (t2.Minute < 9)
                    label2.Text = "0" + t2.Minute.ToString() + ":";
                else
                    label2.Text = t2.Minute.ToString() + ":";
                if (t2.Second < 9)
                    label2.Text += "0" + t2.Second.ToString();
                else
                    label2.Text += t2.Second.ToString();
                timer2.Interval = 1000;
                timer2.Enabled = true;
                groupBox1.Visible = true;
            }
            else
            {
                timer2.Enabled = false;
                button6.Text = "Пуск";
                groupBox1.Enabled = true;
                numericUpDown1.Value = t2.Minute;
                numericUpDown2.Value = t2.Second;
              

            }
            

           

        }
       
        public void timer2_Tick(object sender, EventArgs e)
        {
            
            if(dialog==DialogResult.Yes)
            {
                
                t2 = t2.AddSeconds(-1);

                if (t2.Minute < 9)
                    label2.Text = "0" + t2.Minute.ToString() + ":";
                else
                    label2.Text = t2.Minute.ToString() + ":";
                if (t2.Second < 9)
                    label2.Text += "0" + t2.Second.ToString();
                else
                    label2.Text += t2.Second.ToString();
                if (Equals(t1, t2))
                {
                    timer2.Enabled = false;




                    string command = "shutdown /s /t 00 /f";
                    System.Diagnostics.Process.Start("cmd.exe", "/C " + command);
                    button6.Text = "Пуск";
                    groupBox1.Enabled = true;
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                }
            }
                else if (dialog==DialogResult.No)
                {
                     t2 = t2.AddSeconds(-1);

                if (t2.Minute < 9)
                    label2.Text = "0" + t2.Minute.ToString() + ":";
                else
                    label2.Text = t2.Minute.ToString() + ":";
                if (t2.Second < 9)
                    label2.Text += "0" + t2.Second.ToString();
                else
                    label2.Text += t2.Second.ToString();
                if (Equals(t1, t2))
                {
                    timer2.Enabled = false;


                    var sound = new SoundPlayer(Helper.Properties.Resources._123);
                    sound.Play();
            MessageBox.Show("Таймер истёк!","Таймер",MessageBoxButtons.OK, MessageBoxIcon.Question);
            sound.Stop();
                    button6.Text = "Пуск";
                    groupBox1.Enabled = true;
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                    
                }
            }
        }
        
        
           
                
            
        

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.ru/");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/directory/following");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://kinogo.club/");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value == 0) &&
                (numericUpDown2.Value == 0))
                
                button6.Enabled = false;
            else
                button6.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://finance.liga.net/rates/converter/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://translate.google.com/?hl=ru");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dotabuff.com/");
        }
        DateTime date;

        private void button13_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            Timer timer = new Timer();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer1_Tick_1);
            timer1.Start();
            if (button13.Text == "Stop")
            {
                button13.Text = ("Stopwatch");
                timer1.Stop();
            }
            else
            {
                button13.Text = "Stop";
                timer1.Start();
            }

            
        }
        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();

            stopWatch = stopWatch.AddTicks(tick);
            label5.Text = String.Format("{0:HH:mm:ss:ff}",stopWatch);
           

           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                i = Convert.ToInt32(textBox1.Text);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(i);
            if(i==0)
            {
                timer3.Stop();
                string command = "shutdown /r /t 00 /f";
                System.Diagnostics.Process.Start("cmd.exe", "/C " + command);
            }
            i--;
        }

        
       
    }
}

