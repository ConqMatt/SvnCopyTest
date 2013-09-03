using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SvnToGitCopyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = 0;
            int.TryParse(textBox1.Text, out val1);
            int val2 = 0;
            int.TryParse(textBox2.Text, out val2);

            result.Text = (val1 + val2).ToString();
        }
    }
}
