using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study2
{
    class DBHelper
    {
        //싱글톤
        // static 정적변수로 만든다. 어디든 접근가능
        static DBHelper instance = null;
        public static DBHelper getInstance()
        {
            if (instance == null)//중복 생성 방지
                instance = new DBHelper();//객체 생성 
            return instance;
        }
        public DBHelper()// 생성자
        {
            openConnection();// DB 연동 함수 실행
        }
        //DB 연동
        SqlConnection sqlConnection = null;
        private void openConnection()
        {
            try
            {
                sqlConnection = new SqlConnection();
                string db = "test";          //Database
                string dbIp = "127.0.0.1";         //Ip
                string dbPort = "1433";            //Port
                string dbID = "test";              //ID
                string dbPW = "1234";            // DB 접속 정보
                string constring = "server=" + dbIp + "," + dbPort + ";database=" + db + ";uid=" + dbID + ";pwd=" + dbPW;
                // 접속정보를 적용
                sqlConnection.ConnectionString = constring;
                // DB연결
                sqlConnection.Open();
                MessageBox.Show("연결 성공");
            }
            catch(Exception e)
            {
                MessageBox.Show("연결 실패: "+e.Message);
            }
           
        }
        //insert / update / delete 구문 실행을 위한 excuteNonQuery 함수 만들기
        public int ExecuteNonQuery(string sql)
        {
            int result = -1;
            SqlCommand sqlCommand = null;// sql커멘드를 별도로 만든다.
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = sql;
                result = sqlCommand.ExecuteNonQuery();//해당 sql Commend를 실행한다.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sqlCommand.Dispose();
            return result;
        }
        //select 구문 실행을 위한 executeReader 함수 만들기
        public ArrayList executeReader(string sql)
        {
            ArrayList list = new ArrayList();
            SqlCommand sqlCommand = null;
            SqlDataReader rd = null;// 데이타 리더로 결과를 받는다.
            try
            {
                sqlCommand = new SqlCommand(sql);// sql 문을 매계변수로 보내준다.
                sqlCommand.Connection = sqlConnection;
                rd = sqlCommand.ExecuteReader();// 쿼리 실행 결과물을 전체 담는다.
                int count = rd.FieldCount;
               
                while (rd.Read())
                {
                    string[] values = new string[count];// 배열길이는 count 얻어온 rd필드의 count로한다.
                    for (int i = 0; i < count; i++)
                    {
                        values[i] = "" + rd[i];// 배열에 값을 채운후
                    }
                    list.Add(values);// 리스트에 배열을 채운다.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                rd.Close();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }
        public void closeConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {

            }
        }
    }
}
