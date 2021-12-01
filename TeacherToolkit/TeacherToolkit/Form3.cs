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

namespace TeacherToolkit
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox1.Text = listBox1.Items[studentNum].ToString();

                listBox1.Items.RemoveAt(studentNum);

            }
            else
            {
                MessageBox.Show("Please add some students to continue!!!");
            }
            if (listBox1.Items.Count < 3)
            {
                listBox1.BackColor = Color.OrangeRed;
                MessageBox.Show("Your list is getting Low, Think about adding new names...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (textBox2.Text == "")
           {
                MessageBox.Show("Please Enter a name to the textbox to continue...!");
           }
            listBox1.Items.Add(textBox2.Text);
            textBox2.Clear();
            if (listBox1.Items.Count > 4)
            {
                listBox1.BackColor = Color.White;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);

                    }
                }
            }
            if (listBox1.Items.Count > 4)
            {
                listBox1.BackColor = Color.White;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
