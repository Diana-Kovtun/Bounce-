using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bounce
{
    public partial class Form_rating : Form
    {
        public Form_rating()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            string name1, result1,name2,result2,name3,result3,name4,result4,name5,result5;
            using (StreamReader sw = new StreamReader("123.txt"))
            {
                name1 = sw.ReadLine();
                result1 = sw.ReadLine();
                name2 = sw.ReadLine();
                result2 = sw.ReadLine();
                name3 = sw.ReadLine();
                result3 = sw.ReadLine();
                name4 = sw.ReadLine();
                result4 = sw.ReadLine();
                name5 = sw.ReadLine();
                result5 = sw.ReadLine();
                sw.Close();
                
            }
            label1.Text = name1 + " " + result1;
            label2.Text = name2 + " " + result2;
            label3.Text = name3 + " " + result3;
            label4.Text = name4 + " " + result4;
            label5.Text = name5 + " " + result5;
        }

        private void Form_rating_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 k = new Form1();
            this.Hide();
            k.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
