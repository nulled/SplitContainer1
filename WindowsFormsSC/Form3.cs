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

namespace WindowsFormsSC
{
    public partial class Form3 : Form
    {
        bool firstTime;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            firstTime = true;
            monthCalendar1.SelectionStart = new DateTime(2019, 04, 20);
            monthCalendar1.SelectionEnd = new DateTime(2019, 04, 27);
            domainUpDown1.Items.Add("Item1");
            domainUpDown1.Items.Add("Item2");
            domainUpDown1.Items.Add("Item3");
            domainUpDown1.SelectedIndex = 0;
            imageList1.ImageSize = new Size(100, 100);
            String[] paths = { };
            paths = Directory.GetFiles(@".", "*.jpg");
            try
            {
                foreach (string path in paths)
                {
                    imageList1.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            listView1.LargeImageList = imageList1;
            listView1.Items.Add("Image 1", 0);
            listView1.Items.Add("Image 2", 1);
            listView1.Items.Add("Image 3", 2);
            listView1.Items.Add("Image 4", 3);
            listView1.Items.Add("Image 5", 4);
            listView1.Items.Add("Image 6", 5);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = colorDialog1.Color;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);

            if (firstTime)
                richTextBox1.SelectedText = textBox1.Text;
            else
                richTextBox1.SelectedText = Environment.NewLine + textBox1.Text;

            firstTime = false;

            listBox1.Items.Add(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();

        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }
    }
}
