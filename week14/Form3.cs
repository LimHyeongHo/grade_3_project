using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;

namespace Parking
{
    public partial class Form3 : Form
    {
        DateTime inTime;//입차시간
        int fee = 0;//주차금액q
        List<string> list = new List<string>();
        //출차이후에 남은 차량정보를 파일에 저장
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //상태표시줄에 현재 날짜 및 시간 출력
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCarNum.Text == "")
            {
                MessageBox.Show("차량번호를 입력하세요.");
                txtCarNum.Focus();
                return;
            }
            ////열기파일명을 문자열 변수에 저장
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";

            ////해당 파일이 없으면 입차기록이 없다고 알려주고 끝냄
            if (!File.Exists(fileName))
            {
                MessageBox.Show("입차기록이 없습니다.");
                return;
            }

            //파일에서 모든 내용을 읽어 와서 검색하려고 하는 자동차 번호인지 확인하고
            //요금을 계산하는 일을 한다.            
            TimeSpan parkingTime;//시간 간격을 관리하는 구조체
            string line;
            string[] data;
            StreamReader sr = new StreamReader(fileName);
            while ((line = sr.ReadLine()) != null)
            {
                string[] info = line.Split(',');
                if (info[0].Contains(txtCarNum.Text))
                {
                    //출차시간에서 입차시간을 빼서 주차시간알아내기
                    inTime = DateTime.Parse(info[1]);
                    parkingTime = DateTime.Now - inTime;//출차-입차
                    //주차시간에 해당하는 결제금액을 계산하기
                    fee = CalculateFee(parkingTime);
                    //레이블3,5,9에 차량번호, 결제금액, 주차시간 출력
                    label3.Text = info[0];
                    label5.Text = fee.ToString("N0") + "원";
                    label9.Text = parkingTime.Hours.ToString() + "시간 "
                        + parkingTime.Minutes.ToString() + "분 "
                        + parkingTime.Seconds.ToString() + "초";

                    sr.Close();
                    return;
                }
            }
            MessageBox.Show("해당하는 차량이 없습니다.");
        }
        private int CalculateFee(TimeSpan parkingTime)//요금 계산하기
        {
            double totalMinutes = parkingTime.TotalMinutes;//29분->29.47812857
            if (totalMinutes <= 30)
                return 1000;

            double extraMinutes = totalMinutes - 30;//74.384873 - 30
            int extraMoney = (int)(Math.Ceiling(extraMinutes / 10)) * 500;
            int money = 1000 + extraMoney;
            return money;//요금계산하고 리턴
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string carNo = label3.Text;
            if (carNo == "")
            {
                MessageBox.Show("차량을 검색해 주세요.");
                txtCarNum.Focus();
                return;
            }

            //요금 계산하고 계산된 차량은 파일에서 삭제
            DialogResult result = MessageBox.Show("주차요금 : " + fee.ToString("N0") + "원 결제하시겠습니까?", "결제확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
                StreamReader sr = new StreamReader(fileName);
                string line;
                string[] data;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] carInfo = line.Split(',');
                    if (carInfo[0].Contains(carNo) == false)
                    {
                        /// 출차 하지 않는 차들의 정보를 저장함
                        list.Add(line);
                    }

                }
                sr.Close();
                //StreamWriter sw = new StreamWriter(fileName);
                //sw.WriteLine(fileName, list);
                // sw.Close();
                File.WriteAllLines(fileName, list);

                   
                this.Close();
                MessageBox.Show(fee.ToString("N0") + "원 접수완료\n안녕히 가시라요.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslDateTime.Text =
            DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }
    }
}
