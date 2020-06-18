using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDoiBong_DoAn    
{
    public class Database
    {
        private string connectionString = "Data Source=NAMLE2326;Initial Catalog=QLDoiBong;Integrated Security=True";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        //Create Connection
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed" + ex.Message);
            }
        }
        //Get data
        //Kiểu dữ liệu trả về là 1 datatable
        public DataTable SelectData(string sql,List<CustomParameter>lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;//Gán Procedure
                foreach(var p in lstPara)//Truyền tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());//Trả về 1 biểu hiện của SqlDataReader là trả về 1 IDataReader
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int Execute(string sql,List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;//Gọi Procedure
                foreach(var p in lstPara)//Gán tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);//Sql chuyển đổi chuỗi thành XML
                }
                var rs = cmd.ExecuteNonQuery();//Lấy kết quả thực thi truy vấn
                return (int)rs;//Trả về kq
            }
            catch (Exception ex )
            {
                MessageBox.Show("Lỗi thực thi câu lệnh " + ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
