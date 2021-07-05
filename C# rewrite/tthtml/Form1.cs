using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tthtml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            var r2 = richTextBox1.Text.Replace("\n", "<br>\n");
            if (checkBox1.Checked == true) {
                result = "<!DOCTYPE html>\n<html>\n<head>\n<title>" + textBox1.Text + "</title>\n</head>\n<body>\n" + r2 + "\n</body>\n</html>";
            } else {
                result = "<html>\n<head>\n<title>" + textBox1.Text + "</title>\n</head>\n<body>\n" + r2 + "\n</body>\n</html>";
            }
            richTextBox2.Text = result;
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<b>twój tekst</b>";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<i>twój tekst</i>";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new tthtml.AboutBox1().Show();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (saveFileDialog1)
                {
                    SaveFile(saveFileDialog1);
                }
                
            }
        }
        private void SaveFile(SaveFileDialog sfd)
        {
            string result;
            var r2 = richTextBox1.Text.Replace("\n", "<br>\n");
            if (checkBox1.Checked == true)
            {
                result = "<!DOCTYPE html>\n<html>\n<head>\n<title>" + textBox1.Text + "</title>\n</head>\n<body>\n" + r2 + "\n</body>\n</html>";
            }
            else
            {
                result = "<html>\n<head>\n<title>" + textBox1.Text + "</title>\n</head>\n<body>\n" + r2 + "\n</body>\n</html>";
            }
            richTextBox2.Text = result;
            string path = sfd.FileName;
            File.WriteAllText(path, richTextBox2.Text);
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    var fileContent = reader.ReadToEnd();
                    var r2 = fileContent.Replace("<br>\n", "\n");
                    richTextBox1.Text = r2;
                }
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            checkBox1.Checked = true;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
