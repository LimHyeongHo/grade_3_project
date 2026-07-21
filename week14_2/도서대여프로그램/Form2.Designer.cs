namespace 도서대여프로그램
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lvBook = new System.Windows.Forms.ListView();
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWriter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "도서명 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "저자 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "출판사 : ";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(177, 17);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(1066, 61);
            this.txtBookName.TabIndex = 3;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(177, 75);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(1066, 61);
            this.txtWriter.TabIndex = 4;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(177, 133);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(1066, 61);
            this.txtCompany.TabIndex = 5;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(223, 196);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(139, 48);
            this.btnRegistration.TabIndex = 6;
            this.btnRegistration.Text = "등록";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 48);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(557, 196);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(139, 48);
            this.btnLend.TabIndex = 8;
            this.btnLend.Text = "대여";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(724, 196);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(139, 48);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lvBook
            // 
            this.lvBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNum,
            this.chBookName,
            this.chWriter,
            this.chPublisher,
            this.chState});
            this.lvBook.HideSelection = false;
            this.lvBook.Location = new System.Drawing.Point(21, 269);
            this.lvBook.Name = "lvBook";
            this.lvBook.Size = new System.Drawing.Size(1250, 195);
            this.lvBook.TabIndex = 10;
            this.lvBook.UseCompatibleStateImageBehavior = false;
            this.lvBook.View = System.Windows.Forms.View.Details;
            // 
            // chNum
            // 
            this.chNum.Text = "번호";
            this.chNum.Width = 120;
            // 
            // chBookName
            // 
            this.chBookName.Text = "도서명";
            this.chBookName.Width = 600;
            // 
            // chWriter
            // 
            this.chWriter.Text = "저자";
            this.chWriter.Width = 120;
            // 
            // chPublisher
            // 
            this.chPublisher.Text = "출판사";
            this.chPublisher.Width = 250;
            // 
            // chState
            // 
            this.chState.Text = "상태";
            this.chState.Width = 150;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(891, 196);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(139, 48);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "로그아웃";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 480);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lvBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form2";
            this.Text = "도서관리화면";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListView lvBook;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chBookName;
        private System.Windows.Forms.ColumnHeader chWriter;
        private System.Windows.Forms.ColumnHeader chPublisher;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.Button btnLogOut;
    }
}