namespace ChattingClient
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.chatRoomLB = new System.Windows.Forms.ListBox();
            this.eventLB = new System.Windows.Forms.ListBox();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.eventTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AliasTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port :";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(89, 48);
            this.portTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(114, 25);
            this.portTxt.TabIndex = 1;
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(89, 14);
            this.ipTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(114, 25);
            this.ipTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP :";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(241, 14);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(86, 60);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "서버 연결";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(357, 14);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(86, 60);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "서버 닫기";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // chatRoomLB
            // 
            this.chatRoomLB.FormattingEnabled = true;
            this.chatRoomLB.ItemHeight = 15;
            this.chatRoomLB.Location = new System.Drawing.Point(22, 160);
            this.chatRoomLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chatRoomLB.Name = "chatRoomLB";
            this.chatRoomLB.Size = new System.Drawing.Size(205, 394);
            this.chatRoomLB.TabIndex = 6;
            // 
            // eventLB
            // 
            this.eventLB.FormattingEnabled = true;
            this.eventLB.ItemHeight = 15;
            this.eventLB.Location = new System.Drawing.Point(241, 430);
            this.eventLB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventLB.Name = "eventLB";
            this.eventLB.Size = new System.Drawing.Size(205, 124);
            this.eventLB.TabIndex = 7;
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(22, 569);
            this.messageTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(347, 25);
            this.messageTxt.TabIndex = 8;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(376, 568);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(71, 29);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "말하기";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // eventTxt
            // 
            this.eventTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTxt.Location = new System.Drawing.Point(241, 100);
            this.eventTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventTxt.Multiline = true;
            this.eventTxt.Name = "eventTxt";
            this.eventTxt.Size = new System.Drawing.Size(205, 322);
            this.eventTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "닉네임 :";
            // 
            // AliasTxt
            // 
            this.AliasTxt.Location = new System.Drawing.Point(89, 81);
            this.AliasTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AliasTxt.Name = "AliasTxt";
            this.AliasTxt.Size = new System.Drawing.Size(114, 25);
            this.AliasTxt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 609);
            this.Controls.Add(this.eventTxt);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.eventLB);
            this.Controls.Add(this.chatRoomLB);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.ipTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AliasTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListBox chatRoomLB;
        private System.Windows.Forms.ListBox eventLB;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox eventTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AliasTxt;
    }
}

