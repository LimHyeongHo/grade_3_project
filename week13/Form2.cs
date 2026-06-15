using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //상태표시줄에 날짜 및 시간 표시
            tsslDateTime.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            /// txtCarNum.Text = "";
            txtCarNum.Clear();
            txtCarNum.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // 차량번호 입력 확인
            if(txtCarNum.Text == "")
            {
                MessageBox.Show("차량 번호를 입력하지 않았습니다.");
                txtCarNum.Focus();
                return;
            }
            // 오늘 날짜 파일명 생성 (예: 20260603.txt)
            string fileName = DateTime.Now.ToString("yyyyMMdd") +".txt";

            // 저장할 내용 : 12가3456,2026-06-04 09:30:00
            string data = txtCarNum.Text + "," + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 파일에 추가 저장File.AppendAllText() 사용
            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine(data);
            sw.Close();

            MessageBox.Show("차량번호 : " + txtCarNum.Text + " 입차 완료");

            txtCarNum.Clear();
            txtCarNum.Focus();
        }
    }
}
