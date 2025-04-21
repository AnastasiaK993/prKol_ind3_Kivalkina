using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._04
{
    public partial class Form1 : Form
    {
        ArrayList pochts = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int l = listBox1.SelectedIndex;
            string []xz = listBox1.Text.Split(' ');

            textBox1.Text = xz[0];
            textBox2.Text = xz[1];
            textBox3.Text = xz[2];
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Pochta pochta = new Pochta(textBox1.Text, textBox2.Text, textBox3.Text);
                pochts.Add(pochta);
                string str = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                //listBox1.Items.Add(pochta.NameOrganoz);
                listBox1.Items.Add(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = listBox1.SelectedIndex;
           
            string str = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            listBox1.Items.Insert(l, str);listBox1.Items.RemoveAt(l+1);
            
        }
    }
}
