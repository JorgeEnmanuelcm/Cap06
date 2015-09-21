using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCap06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

private void textBox2_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[][] valores = new int[3][];
            
            valores[0] = new int[] { 7, 6, 1 };
            valores[1] = new int[] { 2, 9 };
            valores[2] = new int[] { 3, 5, 8 };

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            int Resultado=int.Parse(textBoxLados.Text)
            textBoxRes.Text = Resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

