
namespace study2
{
    partial class UserMgrFrm
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
            this.numTxt = new System.Windows.Forms.TextBox();
            this.telNumberTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insertBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ecelWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numTxt
            // 
            this.numTxt.Location = new System.Drawing.Point(146, 49);
            this.numTxt.Name = "numTxt";
            this.numTxt.Size = new System.Drawing.Size(100, 25);
            this.numTxt.TabIndex = 1;
            this.numTxt.TextChanged += new System.EventHandler(this.numTxt_TextChanged);
            // 
            // telNumberTxt
            // 
            this.telNumberTxt.Location = new System.Drawing.Point(146, 107);
            this.telNumberTxt.Name = "telNumberTxt";
            this.telNumberTxt.Size = new System.Drawing.Size(100, 25);
            this.telNumberTxt.TabIndex = 3;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(412, 49);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 25);
            this.nameTxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "순번";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "이름";
            // 
            // totalLv
            // 
            this.totalLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.totalLv.FullRowSelect = true;
            this.totalLv.HideSelection = false;
            this.totalLv.Location = new System.Drawing.Point(-1, 220);
            this.totalLv.MultiSelect = false;
            this.totalLv.Name = "totalLv";
            this.totalLv.Size = new System.Drawing.Size(857, 283);
            this.totalLv.TabIndex = 15;
            this.totalLv.UseCompatibleStateImageBehavior = false;
            this.totalLv.View = System.Windows.Forms.View.Details;
            this.totalLv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.totalLv_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "순번";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "연락처";
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(187, 165);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(118, 40);
            this.insertBtn.TabIndex = 16;
            this.insertBtn.Text = "추가하기";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "연락처\r\n";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(335, 165);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(120, 40);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.Text = "수정하기";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(470, 165);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 40);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "삭제하기";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ecelWrite
            // 
            this.ecelWrite.Location = new System.Drawing.Point(629, 165);
            this.ecelWrite.Name = "ecelWrite";
            this.ecelWrite.Size = new System.Drawing.Size(117, 40);
            this.ecelWrite.TabIndex = 20;
            this.ecelWrite.Text = "엑셀 쓰기\r\n";
            this.ecelWrite.UseVisualStyleBackColor = true;
            this.ecelWrite.Click += new System.EventHandler(this.excelWrite_Click);
            // 
            // UserMgrFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 506);
            this.Controls.Add(this.ecelWrite);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.totalLv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.telNumberTxt);
            this.Controls.Add(this.numTxt);
            this.Name = "UserMgrFrm";
            this.Text = "UserMgrFrm";
            this.Shown += new System.EventHandler(this.UserMgrFrm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox numTxt;
        private System.Windows.Forms.TextBox telNumberTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView totalLv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button ecelWrite;
    }
}