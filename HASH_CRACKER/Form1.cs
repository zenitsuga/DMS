using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HASH_CRACKER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Error: Please provide the data to process.", "No Data to process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Error: Please choose only one process.", "Unable to process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox3.Text = CRASHASHER.Keys.Encrypt(textBox1.Text, "");
            }
            else
            {
                textBox3.Text = CRASHASHER.Keys.Decrypt(textBox2.Text, "");
            }
        }
    }
}
