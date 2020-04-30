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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели имя, поробуйте ещё раз");
            }
            else
            {
                Form_game f = new Form_game();
                this.Hide();
                f.ShowDialog();
                this.Close();    
            }
        }
    }
}
