using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstEx
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.nameTb.Text+"저 불렀나요?","예");
            this.nameTb.Text = "반갑습니다.";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            OptionFrm optionFrm = new OptionFrm();// 객체 생성
            //optionFrm.MdiParent = this;
            //optionFrm.Show();
            optionFrm.ShowDialog();// show 하고는 다르게 해당 창이 뜨면 다른 화면 검색이 안된다.
            // ShowDialog 로 띄었을경우 위의 창이 닫힌뒤에 실행된다.
            //단 show 일경우 창이 뜨면서 바루 밑의 메시지박스가 실행된다.
            MessageBox.Show(optionFrm.result);
        }

        private void LoginFrm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("반갑습니다.");
        }

        private void LoginFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("종료하시겠습니까?", "종료 확인",

               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)

            {

                e.Cancel = true;

            }
        }
    }
}
