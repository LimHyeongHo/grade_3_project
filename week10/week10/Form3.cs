using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week10
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView2.View = View.Details;
            listView2.Columns.Add("번호");
            listView2.Columns.Add("이름");
            listView2.Columns.Add("주소");

            ListViewItem item1 = new ListViewItem("4");
            item1.SubItems.Add("임태균");
            item1.SubItems.Add("논산군 훈련소");

            ListViewItem item2 = new ListViewItem("5");
            item2.SubItems.Add("손재호");
            item2.SubItems.Add("서울시 예비군");

            ListViewItem item3 = new ListViewItem("6");
            item3.SubItems.Add("김태중");
            item3.SubItems.Add("인천시 어디군");

            listView2.Items.Add(item1);
            listView2.Items.Add(item2);
            listView2.Items.Add(item3);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
