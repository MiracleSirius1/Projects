using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiTimer.Properties;

namespace MultiTimer
{
    public partial class Form1 : Form
    {
        private DateTime t1,t3,t5,t7,t9,t11;
        private DateTime t2,t4,t6,t8,t10,t12;
       string text1,text2,text3,text4,text5,text6;
        public Form1()
        {
            //1 таймер
            InitializeComponent();
            numericUpDown1.Maximum = 59;
            numericUpDown2.Minimum = 0;

            numericUpDown1.TabStop = false;

            numericUpDown2.Maximum = 59;
            numericUpDown2.Minimum = 0;
            numericUpDown2.TabStop = false;
            //2 таймер
            numericUpDown4.Maximum = 59;
            numericUpDown4.Minimum = 0;

            numericUpDown4.TabStop = false;

            numericUpDown3.Maximum = 59;
            numericUpDown3.Minimum = 0;
            numericUpDown3.TabStop = false;
            //3 Taimer
            numericUpDown5.Maximum = 59;
            numericUpDown5.Minimum = 0;
            numericUpDown5.TabStop = false;

            numericUpDown6.Maximum = 59;
            numericUpDown6.Minimum = 0;
            numericUpDown6.TabStop = false;

            //4 Taimer
            numericUpDown7.Maximum = 59;
            numericUpDown7.Minimum = 0;
            numericUpDown7.TabStop = false;

            numericUpDown8.Maximum = 59;
            numericUpDown8.Minimum = 0;
            numericUpDown8.TabStop = false;

            //5 Taimer
            numericUpDown9.Maximum = 59;
            numericUpDown9.Minimum = 0;
            numericUpDown9.TabStop = false;

            numericUpDown10.Maximum = 59;
            numericUpDown10.Minimum = 0;
            numericUpDown10.TabStop = false;

            //6 Taimer
            numericUpDown11.Maximum = 59;
            numericUpDown11.Minimum = 0;
            numericUpDown11.TabStop = false;

            numericUpDown12.Maximum = 59;
            numericUpDown12.Minimum = 0;
            numericUpDown12.TabStop = false;

           

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
            {
                t1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                t2 = t1.AddMinutes((double)numericUpDown1.Value);
                t2 = t2.AddSeconds((double)numericUpDown2.Value);

                groupBox1.Enabled = false;
                
                button1.Text = "Стоп";

                if (t2.Minute < 9)
                    label1.Text = "0" + t2.Minute.ToString() + ":";
                else
                    label1.Text = t2.Minute.ToString() + ":";
                if (t2.Second < 9)
                    label1.Text += "0" + t2.Second.ToString();
                else
                    label1.Text += t2.Second.ToString();
                timer2.Interval = 1000;
                timer2.Enabled = true;
                groupBox1.Visible = true;
            }
            else
            {
                timer2.Enabled = false;
                button1.Text = "Пуск";
                groupBox1.Enabled = true;
                numericUpDown1.Value = t2.Minute;
                numericUpDown2.Value = t2.Second;


            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            
                t2 = t2.AddSeconds(-1);

                if (t2.Minute < 9)
                    label1.Text = "0" + t2.Minute.ToString() + ":";
                else
                    label1.Text = t2.Minute.ToString() + ":";
                if (t2.Second < 9)
                    label1.Text += "0" + t2.Second.ToString();
                else
                    label1.Text += t2.Second.ToString();
                if (Equals(t1, t2))
                {
                    timer2.Enabled = false;


                    var sound = new SoundPlayer(MultiTimer.Properties.Resources._123);
                    sound.Play();
                    TopMost = true;
                    MessageBox.Show("Таймер " + (text1) + " истёк!", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    TopMost = false;
                    sound.Stop();
                    button1.Text = "Пуск";
                    groupBox1.Enabled = true;
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;

                }

            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if ((numericUpDown1.Value == 0) &&
                (numericUpDown2.Value == 0))

                button1.Enabled = false;
            else
                button1.Enabled = true;


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text1 =(textBox1.Text);
        }

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                t3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                t4 = t3.AddMinutes((double)numericUpDown4.Value);
                t4 = t4.AddSeconds((double)numericUpDown3.Value);

                groupBox4.Enabled = false;

                button2.Text = "Стоп";

                if (t4.Minute < 9)
                    label6.Text = "0" + t4.Minute.ToString() + ":";
                else
                    label6.Text = t4.Minute.ToString() + ":";
                if (t2.Second < 9)
                    label6.Text += "0" + t4.Second.ToString();
                else
                    label6.Text += t4.Second.ToString();
                timer1.Interval = 1000;
                timer1.Enabled = true;
                groupBox4.Visible = true;
            }
            else
            {
                timer1.Enabled = false;
                button2.Text = "Пуск";
                groupBox4.Enabled = true;
                numericUpDown4.Value = t4.Minute;
                numericUpDown3.Value = t4.Second;


            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t4 = t4.AddSeconds(-1);

            if (t4.Minute < 9)
                label6.Text = "0" + t4.Minute.ToString() + ":";
            else
                label6.Text = t4.Minute.ToString() + ":";
            if (t4.Second < 9)
                label6.Text += "0" + t4.Second.ToString();
            else
                label6.Text += t4.Second.ToString();
            if (Equals(t3, t4))
            {
               timer1.Enabled = false;


               var sound = new SoundPlayer(MultiTimer.Properties.Resources._123);
               sound.Play();
                TopMost = true;
                MessageBox.Show("Таймер " + (text2) + " истёк!", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TopMost = false;
                sound.Stop();
                button2.Text = "Пуск";
                groupBox3.Enabled = true;
                numericUpDown4.Value = 0;
                numericUpDown3.Value = 0;

            }


           
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //нумерик
            if ((numericUpDown4.Value == 0) &&
                            (numericUpDown3.Value == 0))

                button2.Enabled = false;
            else
                button2.Enabled = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            text2 = (textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!timer3.Enabled)
            {
                t5 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                t6 = t5.AddMinutes((double)numericUpDown5.Value);
                t6 = t6.AddSeconds((double)numericUpDown6.Value);

                groupBox6.Enabled = false;

                button3.Text = "Стоп";

                if (t6.Minute < 9)
                    label9.Text = "0" + t6.Minute.ToString() + ":";
                else
                    label9.Text = t6.Minute.ToString() + ":";
                if (t6.Second < 9)
                    label9.Text += "0" + t6.Second.ToString();
                else
                    label9.Text += t6.Second.ToString();
                timer3.Interval = 1000;
                timer3.Enabled = true;
                groupBox6.Visible = true;
            }
            else
            {
                timer3.Enabled = false;
                button3.Text = "Пуск";
                groupBox6.Enabled = true;
                numericUpDown5.Value = t6.Minute;
                numericUpDown6.Value = t6.Second;


            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            t6 = t6.AddSeconds(-1);

            if (t6.Minute < 9)
                label9.Text = "0" + t6.Minute.ToString() + ":";
            else
                label9.Text = t6.Minute.ToString() + ":";
            if (t6.Second < 9)
                label9.Text += "0" + t6.Second.ToString();
            else
                label9.Text += t6.Second.ToString();
            if (Equals(t5, t6))
            {
                timer3.Enabled = false;


                var sound = new SoundPlayer(MultiTimer.Properties.Resources._123);
                sound.Play();
                TopMost = true;
                MessageBox.Show("Таймер " + (text3) + " истёк!", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TopMost = false;
                sound.Stop();
                button1.Text = "Пуск";
                groupBox5.Enabled = true;
                numericUpDown5.Value = 0;
                numericUpDown6.Value = 0;

            }

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown5.Value == 0) &&
                (numericUpDown6.Value == 0))

                button3.Enabled = false;
            else
                button3.Enabled = true;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            text3 = (textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!timer4.Enabled)
            {
                t7 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                t8 = t7.AddMinutes((double)numericUpDown7.Value);
                t8 = t8.AddSeconds((double)numericUpDown8.Value);

                groupBox8.Enabled = false;

                button4.Text = "Стоп";

                if (t8.Minute < 9)
                    label12.Text = "0" + t8.Minute.ToString() + ":";
                else
                    label12.Text = t8.Minute.ToString() + ":";
                if (t8.Second < 9)
                    label12.Text += "0" + t8.Second.ToString();
                else
                    label12.Text += t8.Second.ToString();
                timer4.Interval = 1000;
                timer4.Enabled = true;
                groupBox8.Visible = true;
            }
            else
            {
                timer4.Enabled = false;
                button4.Text = "Пуск";
                groupBox8.Enabled = true;
                numericUpDown7.Value = t8.Minute;
                numericUpDown8.Value = t8.Second;


            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            t8 = t8.AddSeconds(-1);

            if (t8.Minute < 9)
                label12.Text = "0" + t8.Minute.ToString() + ":";
            else
                label12.Text = t8.Minute.ToString() + ":";
            if (t8.Second < 9)
                label12.Text += "0" + t8.Second.ToString();
            else
                label12.Text += t8.Second.ToString();
            if (Equals(t7, t8))
            {
                timer4.Enabled = false;


                var sound = new SoundPlayer(MultiTimer.Properties.Resources._123);
                sound.Play();
                TopMost = true;
                MessageBox.Show("Таймер " + (text4) + " истёк!", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TopMost = false;
                sound.Stop();
                button4.Text = "Пуск";
                groupBox7.Enabled = true;
                numericUpDown7.Value = 0;
                numericUpDown8.Value = 0;

            }

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown7.Value == 0) &&
                (numericUpDown8.Value == 0))

                button4.Enabled = false;
            else
                button4.Enabled = true;

        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            text4 = (textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!timer5.Enabled)
            {
                t9 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                t10 = t9.AddMinutes((double)numericUpDown9.Value);
                t10 = t10.AddSeconds((double)numericUpDown10.Value);

                groupBox10.Enabled = false;

                button5.Text = "Стоп";

                if (t10.Minute < 9)
                    label15.Text = "0" + t10.Minute.ToString() + ":";
                else
                    label15.Text = t10.Minute.ToString() + ":";
                if (t10.Second < 9)
                    label15.Text += "0" + t10.Second.ToString();
                else
                    label15.Text += t10.Second.ToString();
                timer5.Interval = 1000;
                timer5.Enabled = true;
                groupBox10.Visible = true;
            }
            else
            {
                timer5.Enabled = false;
                button5.Text = "Пуск";
                groupBox10.Enabled = true;
                numericUpDown9.Value = t10.Minute;
                numericUpDown10.Value = t10.Second;


            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            t10 = t10.AddSeconds(-1);

            if (t10.Minute < 9)
                label15.Text = "0" + t10.Minute.ToString() + ":";
            else
                label15.Text = t10.Minute.ToString() + ":";
            if (t10.Second < 9)
                label15.Text += "0" + t10.Second.ToString();
            else
                label15.Text += t10.Second.ToString();
            if (Equals(t9, t10))
            {
                timer5.Enabled = false;


                var sound = new SoundPlayer(MultiTimer.Properties.Resources._123);
                sound.Play();
                TopMost = true;
                MessageBox.Show("Таймер " + (text5) + " истёк!", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TopMost = false;
                sound.Stop();
                button5.Text = "Пуск";
                groupBox10.Enabled = true;
                numericUpDown9.Value = 0;
                numericUpDown10.Value = 0;

            }

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown9.Value == 0) &&
                (numericUpDown10.Value == 0))

                button5.Enabled = false;
            else
                button5.Enabled = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            text5 = (textBox5.Text);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!timer6.Enabled)
            {
                t11 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                t12 = t11.AddMinutes((double)numericUpDown11.Value);
                t12 = t12.AddSeconds((double)numericUpDown12.Value);

                groupBox12.Enabled = false;

                button6.Text = "Стоп";

                if (t12.Minute < 9)
                    label18.Text = "0" + t12.Minute.ToString() + ":";
                else
                    label18.Text = t12.Minute.ToString() + ":";
                if (t12.Second < 9)
                    label18.Text += "0" + t12.Second.ToString();
                else
                    label18.Text += t12.Second.ToString();
                timer6.Interval = 1000;
                timer6.Enabled = true;
                groupBox12.Visible = true;
            }
            else
            {
                timer6.Enabled = false;
                button6.Text = "Пуск";
                groupBox12.Enabled = true;
                numericUpDown11.Value = t12.Minute;
                numericUpDown12.Value = t12.Second;


            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            t12 = t12.AddSeconds(-1);

            if (t12.Minute < 9)
                label18.Text = "0" + t12.Minute.ToString() + ":";
            else
                label18.Text = t12.Minute.ToString() + ":";
            if (t12.Second < 9)
                label18.Text += "0" + t12.Second.ToString();
            else
                label18.Text += t12.Second.ToString();
            if (Equals(t11, t12))
            {
                timer6.Enabled = false;


                var sound = new SoundPlayer(MultiTimer.Properties.Resources._123);
                sound.Play();
                TopMost = true;
                MessageBox.Show("Таймер " + (text6) + " истёк!", "Таймер", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TopMost = false;
                sound.Stop();
                button6.Text = "Пуск";
                groupBox12.Enabled = true;
                numericUpDown11.Value = 0;
                numericUpDown12.Value = 0;

            }

        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDown11.Value == 0) &&
                (numericUpDown12.Value == 0))

                button6.Enabled = false;
            else
                button6.Enabled = true;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            text6 = (textBox6.Text);
        }
    }
}