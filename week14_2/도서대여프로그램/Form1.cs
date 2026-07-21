using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도서대여프로그램
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /// id : admin && pw : 1234 이면 로그인 가능
            /// 그렇지 않으면 아이디 및 비번 확인
            if(txtID.Text == "admin" && txtPW.Text == "1234")
            {
                txtID.Clear();
                txtPW.Clear();
                    
                Form2 form2 = new Form2(this, txtID);
                form2.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("로그인 실패, 아이디 및 비밀번호 확인");
                txtID.Text = "";
                txtPW.Clear();
                txtID.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//Form1이 시작폼이므로 Form1을 Close하면 프로그램 종료
            //Application.Exit();
        }
    }
}
