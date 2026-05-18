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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("셀럽");
            TreeNode park = new TreeNode("박효신");
            TreeNode AKMU = new TreeNode("이찬혁");

            TreeNode singer = new TreeNode("가수");
            singer.Nodes.Add(park);
            singer.Nodes.Add(AKMU);
            TreeNode acter = new TreeNode("배우");


            root.Nodes.Add(singer);
            root.Nodes.Add(acter);

            /// 중간에 파일이 깨져서 디자이너 창이 안나와서 실습하지 못했습니다.
            // treeView2.Nodes.Add(root);
        }

    }
}
