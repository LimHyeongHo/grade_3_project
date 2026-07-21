using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 도서대여프로그램
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 loginForm;//Form1 객체 저장
        TextBox id;//Form1에 있는 txtID 객체 저장
        public Form2(Form1 form1, TextBox txtID)
        {
            InitializeComponent();
            loginForm = form1;
            id = txtID;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Form2를 Close하기 전에 현재 리스트뷰 내용 파일에 저장
            StreamWriter sw = new StreamWriter("book.txt");
            foreach(ListViewItem item in lvBook.Items)
            {
                sw.WriteLine(item.SubItems[0].Text + "," +
                    item.SubItems[1].Text + "," +
                    item.SubItems[2].Text + "," +
                    item.SubItems[3].Text + "," +
                    item.SubItems[4].Text + ",");
            }
            sw.Close();
            //리스트뷰에 목록이 여러개 이므로 반복해서 파일에 WriteLine함
            

            this.Close();
            loginForm.Show();
            id.Focus();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //파일이 있으면 파일 열기 진행
            if(File.Exists("book.txt"))
            {
                lvBook.Items.Clear();
                StreamReader sr = new StreamReader("book.txt");
                string line;
                string[] data;
                while((line = sr.ReadLine()) != null)
                {
                    data = line.Split(',');
                    ListViewItem item = new ListViewItem(data[0]);
                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);
                    item.SubItems.Add(data[3]);
                    item.SubItems.Add(data[4]);

                    lvBook.Items.Add(item);
                }
                sr.Close();
                lastNum = int.Parse(lvBook.Items[lvBook.Items.Count - 1].Text);
            }
            //리스트뷰의 목록 클릭어
            //파일내용 메모리에 저장
            //여러개이므로 반복문
            //저장할때 ,로 저장한 정보를 분리해서 문자열배열에 저장
            //리스트뷰 목록 객체를 만든다
            //하위목록 구성
            //하위목록 구성
            //하위목록 구성
            //하위목록 구성
            //리스트뷰에 추가
            
            //리스트뷰의 마지막목록의 번호를 전역변수에 저장
            
        }

        int lastNum;//리스트뷰의 마지막 목록의 번호를 정장
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "")
            {
                MessageBox.Show("도서명을 입력하세요.");
                return;
            }

            int no = 0;
            //목록이 비어있으면 첫번째 목록에 번호를 1번으로 함
            //그렇지 않으면 마지막 목록의 번호에 1을 더해서 변경한다.
            if (lvBook.Items.Count == 0)
            {
                no = 1;
            }
            else
            {
                no = lastNum + 1;
            }
            //리스트뷰의 목록을 추가하기 위해 객체 생성
            ListViewItem item = new ListViewItem(no.ToString());
            item.SubItems.Add(txtBookName.Text);    //하위목록 구성
            item.SubItems.Add(txtWriter.Text);      //하위목록 구성
            item.SubItems.Add(txtCompany.Text);     //하위목록 구성
            item.SubItems.Add("대여가능");          //하위목록 구성

            //리스트뷰 목록에 출력
            lvBook.Items.Add(item);
            //마지막 번호를 갱신
             lastNum = no;
            txtBookName.Clear();
            txtWriter.Clear();  
            txtCompany.Clear();
            txtBookName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvBook.SelectedItems.Count == 0)
            {
                MessageBox.Show("도서를 선택하세요.");
                return;
            }

            //선택한 목록을 삭제
            lvBook.Items.Remove(lvBook.SelectedItems[0]);
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            if (lvBook.SelectedItems.Count == 0)
            {
                MessageBox.Show("도서를 선택하세요.");
                return;
            }
            ;//선택한 목록의 상태를 대여중으로 변경
            lvBook.SelectedItems[0].SubItems[4].Text = "대여중...";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lvBook.SelectedItems.Count == 0)
            {
                MessageBox.Show("도서를 선택하세요.");
                return;
            }
            //반납하면 다시 대여할 수 있도록 대여가능으로 변경
            lvBook.SelectedItems[0].SubItems[4].Text = "대여가능";
        }
    }
}
