using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 액셀 사용하기
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;

namespace study2
{
    public partial class UserMgrFrm : Form
    {
        DBHelper dbHelper = DBHelper.getInstance();
        private static readonly Color SELECTED_COLOR = Color.FromArgb(0, 120, 215);

        public UserMgrFrm()
        {
            InitializeComponent();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from testTable where name like '%" + nameTxt.Text + "%'";
            MessageBox.Show(sql);
            ArrayList list = dbHelper.executeReader(sql);
            totalLv.Items.Clear();
            foreach (string[] values in list)
            {
                ListViewItem item = new ListViewItem(values);
                UserVO userVO = new UserVO(values);
                item.Tag = userVO;
                totalLv.Items.Add(item);
            }
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {
            //기본 추가기능
            //string[] values = new string[3];
            //values[0] = this.numTxt.Text;
            //values[1] = this.nameTxt.Text;
            //values[2] = this.contactTxt.Text;
            //ListViewItem item = new ListViewItem(values);
            //this.Tag = new UserVO(values);
            //this.totalLv.Items.Add(item);
            //item.Tag = new UserVO(values);

            // 데이터베이스 일겨우
            string sql = "INSERT INTO testTable ( name, contact) " +
                $"values('{this.nameTxt.Text.ToString()}','{this.contactTxt.Text.ToString()}')";
            MessageBox.Show(sql);
            dbHelper.ExecuteNonQuery(sql);
            // 추가된 걸 확인하기 
            this.nameTxt.Text = string.Empty;
            this.contactTxt.Text = string.Empty;
            this.searchBtn.PerformClick();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (this.totalLv.SelectedIndices == null ||
                this.totalLv.SelectedIndices.Count < 1)
                return;
            //string[] values = new string[3];
            //values[0] = this.numTxt.Text;
            //values[1] = this.nameTxt.Text;
            //values[2] = this.contactTxt.Text;

            //int selectedIndex = this.totalLv.SelectedIndices[0];
            //UserVO userVO = (UserVO)this.totalLv.Items[selectedIndex].Tag;
            //this.totalLv.Items[selectedIndex] = new ListViewItem(values);
            //userVO.Order = values[0];
            //userVO.Name = values[1];
            //userVO.Contact = values[2];
            //this.totalLv.Items[selectedIndex].Tag = userVO;
            string sql = "UPDATE testTable " +
                $"SET name = '{this.nameTxt.Text.ToString()}' , contact = '{this.contactTxt.Text.ToString()}'  " +
                $"WHERE id = {this.numTxt.Text.ToString()}";
            MessageBox.Show(sql);
            dbHelper.ExecuteNonQuery(sql);
            // 추가된 걸 확인하기 
            this.nameTxt.Text = string.Empty;
            this.contactTxt.Text = string.Empty;
            this.searchBtn.PerformClick();
            //SetListViewSelectColor();
        }
        //리스트의  FullRowSelect 설정을 true 해야한다.
        //
        private void totalLv_MouseClick(object sender, MouseEventArgs e)
        {
            //FocusedItem은 내가 선택한 대상의 정보를 리스트에서 가져와준다.
            if (totalLv.FocusedItem == null)
                return;
            ListViewItem selectedItem = totalLv.FocusedItem;
            UserVO userVO = (UserVO)selectedItem.Tag;

            this.numTxt.Text = userVO.order;
            //this.numTxt.Text = selectedItem.SubItems[0].Text;
            this.nameTxt.Text = userVO.Name;
            //this.nameTxt.Text = selectedItem.SubItems[1].Text;
            this.contactTxt.Text = userVO.Contact;
            //this.telNumberTxt.Text = selectedItem.SubItems[2].Text;

            SetListViewSelectColor();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // 선택된 줄확인
            if (this.totalLv.SelectedIndices == null ||
              this.totalLv.SelectedIndices.Count < 1)
                return;
            //this.totalLv.Items.RemoveAt(this.totalLv.SelectedIndices[0]);
            // 데이터 베이스 용
            string sql = $"DELETE FROM testTable " +
                $"WHERE id={this.numTxt.Text.ToString()}";
            MessageBox.Show(sql);
            dbHelper.ExecuteNonQuery(sql);
            // 추가된 걸 확인하기 
            this.nameTxt.Text = string.Empty;
            this.contactTxt.Text = string.Empty;
            this.searchBtn.PerformClick();
        }

        private void SetListViewSelectColor()
        {
            //totalLv 의 속성에서 hideselect true로 한다음 사용할 것!
            totalLv.BeginUpdate();
            foreach (ListViewItem item in totalLv.Items)
            {
                item.BackColor = item.Selected ? SELECTED_COLOR : Color.Transparent;
                item.ForeColor = item.Selected ? Color.White : Color.Black;
            }

            totalLv.EndUpdate();
        }

        private void numTxt_TextChanged(object sender, EventArgs e)
        {


        }
        //액셀 관련
        private void UserMgrFrm_Shown(object sender, EventArgs e)
        {
            this.searchBtn.PerformClick();
            //MessageBox.Show(System.Environment.CurrentDirectory);
            // D:\Projects\MyShop\bin\Debug
            //Excel.Application excelApp = null;
            //Excel.Workbook workBook = null;
            //Excel.Worksheet workSheet = null;
            //try
            //{
            //    string currentPath = @"C:\대학교 4학년 1학기\c-Study\schoolStudy\study2";// 파일경로 저장한 곳에 둘것
            //    // Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // 바탕화면 경로
            //    string path = Path.Combine(currentPath, "myshop.xlsx");
            //    excelApp = new Excel.Application();
            //    workBook = excelApp.Workbooks.Open(path);
            //    workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;
            //    Excel.Range range = workSheet.UsedRange;
            //    //MessageBox.Show(range.Rows.Count + ","+ range.Columns.Count);
            //    for (int row = 2; row <= range.Rows.Count; row++)
            //    {
            //        string[] cellValues = new string[range.Columns.Count];
            //        for (int column = 1; column <= range.Columns.Count; column++)
            //        {
            //            string str = "" + (range.Cells[row, column] as Excel.Range).Value2;
            //            cellValues[column - 1] = str;
            //        }
            //        UserVO userVO = new UserVO(cellValues);
            //        ListViewItem item = new ListViewItem(cellValues);
            //        item.Tag = userVO;
            //        this.totalLv.Items.Add(item); ;
            //    }
            //    workBook.Close(true);
            //    excelApp.Quit();
            //}
            //finally
            //{
            //    ReleaseObject(workSheet);
            //    ReleaseObject(workBook);
            //    ReleaseObject(excelApp);
            //}
        }
        //액셀 파일을 사용한후 마무리용 함수
        static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void excelWrite_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = null;// 액셀 엡
            Excel.Workbook workBook = null;// 액셀 워크 북
            Excel.Worksheet workSheet = null;// 액셀 시트
            try
            {
                excelApp = new Excel.Application();
                workBook = excelApp.Workbooks.Add();
                workSheet = workBook.Worksheets.Add(Type.Missing,workBook.Worksheets[1]);
                workSheet.Name = "고객목록";
                for(int row = 0; row<=totalLv.Items.Count; row++)
                {
                    for(int col = 0; col< 3; col++)
                    {
                        

                        if (row == 0)
                        {
                            workSheet.Cells[1, col + 1] = this.totalLv.Columns[col].Text;
                        }
                        else
                        {
                            workSheet.Cells[row + 1, col + 1] = this.totalLv.Items[row - 1].SubItems[col].Text;
                        }
                    }
                }
                
                workBook.SaveAs("C:\\대학교 4학년 1학기\\c-Study\\schoolStudy\\study2\\myshop02.xlsx");
                excelApp.Quit();
            }
            finally
            {
                ReleaseObject(workSheet);
                ReleaseObject(workBook);
                ReleaseObject(excelApp);
            }

        }

        private void UserMgrFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbHelper.closeConnection();
        }

       
    }
}
