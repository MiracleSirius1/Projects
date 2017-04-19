using Death_Note.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Death_Note
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
            colorDialog1.FullOpen = true;
            fontDialog1.ShowColor = true;
           
     

            textBox1.Text = Settings.Default["TextBox"].ToString();

           // var Reader = new System.IO.StringReader(Death_Note.Properties.Resources.FileName1);
           // textBox1.Text = Reader.ReadToEnd();
            
           //Reader.Close();
          
        }
 


        private void readTextFromFile(string filename)
        {

           
            
        } 

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        using (var dlg = new ColorDialog()) {
            if (dlg.ShowDialog() == DialogResult.OK) {
                this.BackColor = Properties.Settings.Default.FormBackColor = dlg.Color;
               
                Properties.Settings.Default.Save();
            }
        }
    }
        

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            using (var Font = new FontDialog())
            {
                if (Font.ShowDialog() == DialogResult.OK)
                {
                    this.Font = Properties.Settings.Default.TextFont = Font.Font;

                    Properties.Settings.Default.Save();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings.Default["TextBox"] = textBox1.Text;
            Settings.Default.Save();
            //var Writer = new System.IO.StreamWriter("FileName1.txt");

            //Writer.Write(textBox1.Text);

            //Writer.Close();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void colorTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
      
            using (var Color = new ColorDialog())
            {
                if (Color.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = Properties.Settings.Default.ColorText = Color.Color;

                    Properties.Settings.Default.Save();
                }
            }

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    
        
    }
}
