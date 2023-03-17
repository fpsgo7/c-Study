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
    public partial class UserMgrFrm : Form
    {
        private static readonly Color SELECTED_COLOR = Color.FromArgb(0, 120, 215);

        public UserMgrFrm()
        {
            InitializeComponent();
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }


        private void insertBtn_Click(object sender, EventArgs e)
        {
            string[] values = new string[3];
            values[0] = this.numTxt.Text;
            values[1] = this.nameTxt.Text;
            values[2] = this.telNumberTxt.Text;
            this.totalLv.Items.Add(new ListViewItem(values));

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (this.totalLv.SelectedIndices == null ||
                this.totalLv.SelectedIndices.Count < 1)
                return;
            string[] values = new string[3];
            values[0] = this.numTxt.Text;
            values[1] = this.nameTxt.Text;
            values[2] = this.telNumberTxt.Text;
            int selectedIndex = this.totalLv.SelectedIndices[0];

            ListViewItem item = new ListViewItem(values);// 힙해할당되기에 여기서 캐싱해도 문제는 없다.
            this.totalLv.Items[selectedIndex] = item;
            item.Selected = true;
            SetListViewSelectColor();
        }
        //리스트의  FullRowSelect 설정을 true 해야한다.
        //
        private void totalLv_MouseClick(object sender, MouseEventArgs e)
        {
            //FocusedItem은 내가 선택한 대상의 정보를 리스트에서 가져와준다.
            if (totalLv.FocusedItem == null)
                return;
            ListViewItem selectedItem = totalLv.FocusedItem;

            this.numTxt.Text = selectedItem.SubItems[0].Text;

            this.nameTxt.Text = selectedItem.SubItems[1].Text;

            this.telNumberTxt.Text = selectedItem.SubItems[2].Text;
            SetListViewSelectColor();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // 선택된 줄확인
            if (this.totalLv.SelectedIndices == null ||
              this.totalLv.SelectedIndices.Count < 1)
                return;
            this.totalLv.Items.RemoveAt(this.totalLv.SelectedIndices[0]);
        }

        private void SetListViewSelectColor()
        {
            //totalLv 의 속성에서 hideselect true로 한다음 사용할 것!
            totalLv.BeginUpdate();
            foreach(ListViewItem item in totalLv.Items)
            {
                item.BackColor = item.Selected ? SELECTED_COLOR : Color.Transparent;
                item.ForeColor = item.Selected ? Color.White : Color.Black;
            }

            totalLv.EndUpdate();
        }
    }
}
