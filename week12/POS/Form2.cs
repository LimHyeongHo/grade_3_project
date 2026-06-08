using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace POS
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 orderForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            orderForm = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblDisplay.Text = "결제하실 금액은 " + Form1.totalPrice.ToString("N0") + "원입니다.\n결제하시겠습니까?";
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            //파일저장(20260608.txt)
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            StreamWriter sw = new StreamWriter(fileName,true);
            sw.WriteLine(Form1.totalPrice);
            sw.Close();

            orderForm.ClearList();
            MessageBox.Show("결제가 완료되었음.\n어서 가시길 바람.", "결제완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }
    }
}
