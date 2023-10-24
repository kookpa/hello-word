using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_word_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = textBox2.Text;
            int total = int.Parse(numero1) + int.Parse(numero2);

            label2.Text = total.ToString();
        }

        private void lbresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
