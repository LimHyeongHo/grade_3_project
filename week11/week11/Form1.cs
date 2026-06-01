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

namespace week11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string currentFilePath = ""; /// 현재 파일 경로를 저장하는 전역 변수
        bool isModified = false; /// txtMeon.Text의 변경사항이 있으면 true, 없으면 false
        
        private void UpdateTile()
        {
            bool chk = string.IsNullOrEmpty(currentFilePath);
            if (chk == true)
            {
                this.Text = "제목 없음 - 메모장";
            }
            else
            {
                this.Text = currentFilePath;
            }
        }

        private bool SaveAsFile()
        {
            saveFileDialog1.Title = "텍스트 문서 다른 이름으로 저장...";
            saveFileDialog1.Filter = "텍스트 문서|*.txt|모든파일|*.*";
            saveFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                // 파일저장
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(txtMemo.Text);
                sw.Close();

                currentFilePath = saveFileDialog1.FileName;
                isModified = false;
                UpdateTile();
                return true;
            }
            return false;
        }
        private bool CheckSaveBeforeContinue()
        {
            if (!isModified) return true;
            DialogResult result = MessageBox.Show("내용이 수정됨. 저장?", "저장확인", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) return SaveAsFile();
            else if (result == DialogResult.No) return false;

            return true;
        }
        private void mnuNew_Click(object sender, EventArgs e)
        {
            // 수정사항이 있는 지확인
            if (!CheckSaveBeforeContinue()) return;

            // 새 파일 인터페이스 만들기
            txtMemo.Clear();
            currentFilePath = "";
            isModified = false;
            UpdateTile();
         }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if(!CheckSaveBeforeContinue()) return;

            openFileDialog1.Title = "텍스트 문서 열기...";
            openFileDialog1.Filter = "텍스트 문서|*.txt|모든파일|*.*";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                txtMemo.Text = sr.ReadToEnd();
                sr.Close();

                currentFilePath = openFileDialog1.FileName;
                isModified = false;
                UpdateTile();
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (!CheckSaveBeforeContinue()) return;
            Form1_FormClosing(sender, e);
            Application.Exit();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
        private void Form1_FormClosing(object sender, EventArgs e)
        {
            MessageBox.Show("저는 떠날거고요 이제는 파일 살릴 생각하지 마세요");
        }


        private void mnuCut_Click(object sender, EventArgs e)
        {
            txtMemo.Cut();
        }
        private void mnuCopy_Click(object sender, EventArgs e)
        {
            txtMemo.Copy();

        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtMemo.Paste();

        }

    }
}
