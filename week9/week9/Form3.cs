using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = "장준환 교수님\n황규대 교수님";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label1.Text = "김원일 교수님\n장윤경 교수님";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("딸기");
            listBox1.Items.Add("바나나");
            listBox1.Items.Add("사과");
            listBox1.Items.Add("수박");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}
