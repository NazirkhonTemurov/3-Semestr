using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void katet_a_Click(object sender, EventArgs e)
        {

        }

        private void a_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                string a_katet = a.Text;
                string b_katet = b.Text;
                string h_thickness = h.Text;
                string m_weight = m.Text;

                double a_1 = Convert.ToInt32(a_katet);
                double b_1 = Convert.ToInt32(b_katet);
                double h_1 = Convert.ToInt32(h_thickness);
                double m_1 = Convert.ToInt32(m_weight);


                double result = 2 * m_1 / (a_1 * b_1 * h_1);
                Answer_1.Text = result.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Можно ввести только числа!");
            }

        }

        private void Answer_1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void m_TextChanged(object sender, EventArgs e)
        {

        }

        private void Answer_1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
