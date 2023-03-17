using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study2
{
    public partial class MainRfm : Form
    {
        public MainRfm()
        {
            InitializeComponent();
        }

        private void MainRfm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("종료하시겠습니까?", "종료 확인",

                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)

            {

                e.Cancel = true;

            }
        }

        private void 고객관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMgrFrm obj = new UserMgrFrm();
            obj.MdiParent = this;//부모창 내부에 설치하기
            obj.Show();//창띄우기
        }

        private void 상품관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 상품코드관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 상품입고관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
