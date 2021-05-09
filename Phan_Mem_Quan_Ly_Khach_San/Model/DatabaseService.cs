using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
    public class DatabaseService
    {
        //Ket noi voi SQL.
        public const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        public SqlConnection connection;
        public SqlCommand command;
        public DatabaseService()
        {
            connection = new SqlConnection(connectionString);
        }

        //Mo ket noi khi ket noi co va trang thai dang dong.
        public void OpenConnection()
        {
            //State cũng là một kiểu dữ liệu và trong phép so sánh thì vế trái và vế phải đều cùng một loại dữ liệu
            if(connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //Dong ket noi khi ket noi co va trang thai dang mo.
        public void CloseConnection()
        {
            if(connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //Phuong thuc ReadData dung de noi chuyen voi ben ngoai.
        public SqlDataReader ReadData(string sql)
        {
            command = new SqlCommand(); //do la bien toan cuc nen phai reset.
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //Doc du lieu voi co doi so <<pars>>.
        public SqlDataReader ReadDataPars (string sql,SqlParameter[] pars)
        {
            command = new SqlCommand(); //do la bien toan cuc nen phai reset.
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(pars);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //ExcuteNonQuery tra ve mot con so.
        //kieu du lieu tra ve la bool vi bool co 0: false, 1:true (chi co hai gia tri <<0,1>>).
        public bool WriteData(string sql, SqlParameter[] pars)
        {
            try
            {

                command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;
                command.Connection = connection;
                OpenConnection();
                command.Parameters.AddRange(pars);
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
