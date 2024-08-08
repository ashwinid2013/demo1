using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Employee
{
    public class Disconnected
    {
        string constr = "Server=localhost;Database=sqldb;uid=root;pwd=root";
        public List<Emp> GetEmployees()
        {
            List<Emp> emp = new List<Emp>();
           
            using (var conn = new MySqlConnection(constr))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from emp";
                MySqlDataAdapter da=new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                //conn.Close();
                foreach (DataRow dr in dataTable.Rows)
                {
                    emp.Add(new Emp(
                       Convert.ToInt32(dr["EMPNO"]),
                       dr["ENAME"].ToString(),
                       dr["JOB"].ToString(),
                       dr["SAL"] == DBNull.Value ? 0 : Convert.ToDecimal(dr["SAL"]),
                        Convert.ToInt32(dr["DEPTNO"].ToString())));
                }

                conn.Close();
            }
            return emp;
        }

    }
}
