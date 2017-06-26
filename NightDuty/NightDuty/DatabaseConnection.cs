using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NightDuty
{
    public class DatabaseConnection : DutyForm
    {
        public void BindData(int y)
        {
            try
            {
                string _connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Neeraj\Projects\NightDuty\NightDuty\NightDuty\bin\Debug\MyDatabase\NightDuty.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection cn = new SqlConnection(_connectionstring);
                cn.Open();
                string _sql = "SELECT * FROM [Data] WHERE PfNo =" + y + "";
                SqlCommand _command = new SqlCommand(_sql, cn);
                SqlDataAdapter _adapter = new SqlDataAdapter(_command);
                DataTable _table = new DataTable();
                _adapter.Fill(_table);

                //GridView1.DataSource = _table;
                // GridView1.DataBind();
            }
            catch
            {
                throw;
            }
        }
    }
}