using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace week9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void chkRemen_CheckedChanged(object sender, EventArgs e)
        {
            string menu = "";
            if(chkRemen.Checked) menu = chkRemen.Text;
            if(chkGalbi.Checked) menu = menu +chkGalbi.Text;
            if(chkMara.Checked) menu = menu + chkMara.Text;
            
            label1.Text = menu;
        }

        private void chkGalbi_CheckedChanged(object sender, EventArgs e)
        {
            string menu = "";
            if (chkRemen.Checked) menu = chkRemen.Text;
            if (chkGalbi.Checked) menu = menu + chkGalbi.Text;
            if (chkMara.Checked) menu = menu + chkMara.Text;

            label1.Text = menu;
        }

        private void chkMara_CheckedChanged(object sender, EventArgs e)
        {
            string menu = "";
            if (chkRemen.Checked) menu = chkRemen.Text;
            if (chkGalbi.Checked) menu = menu + chkGalbi.Text;
            if (chkMara.Checked) menu = menu + chkMara.Text;

            label1.Text = menu;
        }
        private void chkMen_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "성별 : " + chkMen.Text;
        }
        private void chkWomen_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "성별 : " + chkWomen.Text;
        }
        //private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton3.Checked)
        //    {
        //        label3.Text = "학년은 " + radioButton3.Text;
        //    }
        //}

        //private void radioButton4_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton4.Checked)
        //    {
        //        label3.Text = "학년은 " + radioButton3.Text;
        //    }
        //}

        //private void radioButton5_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton5.Checked)
        //    {
        //        label3.Text = "학년은 " + radioButton3.Text;
        //    }
        //}
    }
}
