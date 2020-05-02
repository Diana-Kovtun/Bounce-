using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce
{
    public partial class Form_results : Form
    {
        public Form_results(string name, string result)
        {
            InitializeComponent();
            label1.BackColor=Color.FromArgb(0, 0, 0, 0);
            label1.Text = name + ", ваше время:" + result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_rating g = new Form_rating();
            this.Hide();
            g.ShowDialog();
            this.Close();
        }

        private void Form_results_Load(object sender, EventArgs e)
        {

        }
    }
}
