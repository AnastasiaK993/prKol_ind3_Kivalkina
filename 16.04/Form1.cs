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
            textBox1.Text= pochts
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pochta pochta = new Pochta(textBox1.Text, textBox2.Text, textBox3.Text);
            pochts.Add(pochta);
            listBox1.Items.Add(pochta.NameOrganoz);
        }
    }
}
