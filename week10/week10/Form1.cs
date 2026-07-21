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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\super\\OneDrive\\바탕 화면\\폴더정리\\1. Project\\3학년\\03. C#\\grade_3_project\\week10\\img\\라이프위버.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\super\\OneDrive\\바탕 화면\\폴더정리\\1. Project\\3학년\\03. C#\\grade_3_project\\week10\\img\\모이라.jpg");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            /// 도구 상자 오류로 인해 비활성화 되어 실습하지 못했습니다.
            // openFileDialog1.showdialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

        }
    }
}
