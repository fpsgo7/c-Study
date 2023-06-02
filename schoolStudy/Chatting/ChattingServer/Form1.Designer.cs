namespace ChattingServer
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
            this.clientLB = new System.Windows.Forms.ListBox();
            this.chatRoomLB = new System.Windows.Forms.ListBox();
            this.eventLB = new System.Windows.Forms.ListBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.eventTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port : ";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(70, 16);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(100, 21);
            this.portTxt.TabIndex = 1;
            // 
            // clientLB
            // 
            this.clientLB.FormattingEnabled = true;
            this.clientLB.ItemHeight = 12;
            this.clientLB.Location = new System.Drawing.Point(12, 68);
            this.clientLB.Name = "clientLB";
            this.clientLB.Size = new System.Drawing.Size(188, 376);
            this.clientLB.TabIndex = 2;
            // 
            // chatRoomLB
            // 
            this.chatRoomLB.FormattingEnabled = true;
            this.chatRoomLB.ItemHeight = 12;
            this.chatRoomLB.Location = new System.Drawing.Point(215, 68);
            this.chatRoomLB.Name = "chatRoomLB";
            this.chatRoomLB.Size = new System.Drawing.Size(174, 376);
            this.chatRoomLB.TabIndex = 3;
            // 
            // eventLB
            // 
            this.eventLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventLB.FormattingEnabled = true;
            this.eventLB.ItemHeight = 12;
            this.eventLB.Location = new System.Drawing.Point(408, 356);
            this.eventLB.Name = "eventLB";
            this.eventLB.Size = new System.Drawing.Size(219, 88);
            this.eventLB.TabIndex = 4;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(189, 16);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "서버 구동";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(296, 16);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "서버 중지";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // eventTxt
            // 
            this.eventTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventTxt.Location = new System.Drawing.Point(408, 68);
            this.eventTxt.Multiline = true;
            this.eventTxt.Name = "eventTxt";
            this.eventTxt.Size = new System.Drawing.Size(218, 282);
            this.eventTxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.eventTxt);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.eventLB);
            this.Controls.Add(this.chatRoomLB);
            this.Controls.Add(this.clientLB);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.ListBox clientLB;
        private System.Windows.Forms.ListBox chatRoomLB;
        private System.Windows.Forms.ListBox eventLB;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox eventTxt;
    }
}

