using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using ClientChat.Properties;
using System.Windows;

namespace ClientChat
{
    public partial class Form1 : Form
    {
        static private Socket Client;
        private IPAddress ip = null;
        private int port = 0;
        private Thread th;

        public Form1()
        {
            InitializeComponent();

            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            button1.Enabled = false;
            
            try
            {
                var sr = new StreamReader(@"Client_info/data_info.txt");
                string buffer = sr.ReadToEnd();
                sr.Close();
                string[] connect_info = buffer.Split(':');
                ip = IPAddress.Parse(connect_info[0]);
                port = int.Parse(connect_info[1]);


                label4.ForeColor = Color.Green;
                label4.Text = " Настройки: \n IP сервера: " + connect_info[0] + "\n Порт сервера: " + connect_info[1];
            }
            catch (Exception ex)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Настройки не найдены!";
                Form2 form = new Form2();
                form.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            SendMessage("\n" + textBox1.Text + ":" + richTextBox2.Text + ";;;5");
            richTextBox2.Clear();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
        void SendMessage(string message)
        {
            if (message != "" && message != "")
            {
                byte[] buffer = new byte[1024];
                buffer = Encoding.UTF8.GetBytes(message);
                Client.Send(buffer);
            }
        }
        void RecvMessage()
        {
            byte[] buffer = new byte[1024];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = 0;

            }
            for (; ; )
            {
                try
                {
                    Client.Receive(buffer);
                    string message = Encoding.UTF8.GetString(buffer);
                    int count = message.IndexOf(";;;5");
                    if (count == -1)
                    {
                        continue;
                    }
                    string Clear_Message = "";
                    for (int i = 0; i < count; i++)
                    {
                        Clear_Message += message[i];
                    }
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = 0;

                    }
                    this.Invoke((MethodInvoker)delegate()
                    {
                        richTextBox1.AppendText(Clear_Message);
                    });
                }
                catch (Exception ex) { }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
                richTextBox2.Enabled = true;
                richTextBox1.Enabled = true;
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    if (ip != null)
                    {
                        Client.Connect(ip, port);
                        th = new Thread(delegate() { RecvMessage(); });
                        th.Start();
                        this.Focus();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения");
                }
            }
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created the program Sirius\nSoftware version 1.0");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (th != null) th.Abort();
            if (Client != null)
            {
                Client.Close();
            }
            Application.Exit();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {

    if (e.KeyCode == Keys.Enter)
    {
        e.SuppressKeyPress = true;
        SendMessage("\n" + textBox1.Text + ":" + richTextBox2.Text + ";;;5");
        richTextBox2.Clear();
    }

        }

        private void настройкиЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
        private void фонToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                     BackColor= Properties.Settings.Default.BackColor = dlg.Color;

                    Properties.Settings.Default.Save();

                }
            }
        }

        private void фонЧатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var lg = new ColorDialog())
            {
                if (lg.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.BackColor = Properties.Settings.Default.Color = lg.Color;

                    Properties.Settings.Default.Save();

                }
            }
        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var Color = new ColorDialog())
            {
                if (Color.ShowDialog() == DialogResult.OK)
                {
                   richTextBox1.ForeColor = Properties.Settings.Default.ColorText = Color.Color;

                    Properties.Settings.Default.Save();
                }
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
