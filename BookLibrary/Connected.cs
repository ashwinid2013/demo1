using MySqlConnector;
using System.Text.Json.Serialization.Metadata;
namespace Employee
{
    public class DbConnect
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
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp.Add(new Emp(
                        Convert.ToInt32(reader["EMPNO"]),
                        reader["ENAME"].ToString(),
                        reader["JOB"].ToString(),
                        reader["SAL"]==DBNull.Value?0:Convert.ToDecimal(reader["SAL"]),                      
                         Convert.ToInt32(reader["DEPTNO"].ToString())));
                }
                conn.Close();
               
            }
            return emp;
        }

        public int updateSalary(int eno)
        {
            List<Emp> emp = new List<Emp>();
            using (var conn = new MySqlConnection(constr))
            {
                int rowsAffected;
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update emp set sal=5000 where empno=@eno ";
                cmd.Parameters.AddWithValue("@eno", eno);
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }
            
        }


        public int DeleteEmp(int eno)
        {
            List<Emp> emp = new List<Emp>();
            using (var conn = new MySqlConnection(constr))
            {
                int rowsAffected;
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "delete from emp where empno=@eno ";
                cmd.Parameters.AddWithValue("@eno", eno);
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected;

            }

        }


        public int InsertEmp(Emp em)
        {
           // List<Emp> emp = new List<Emp>();
            int rowsAffected;
            using (var conn = new MySqlConnection(constr))
            { 
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into emp(EMPNO,ENAME,JOB,SAL,DEPTNO) values(@eno,@name,@job,@sal,@dept)";
                cmd.Parameters.AddWithValue("@eno", em.EMPNO);
                cmd.Parameters.AddWithValue("@name",em.ENAME);
                cmd.Parameters.AddWithValue("@job", em.JOB);
                cmd.Parameters.AddWithValue("@sal", em.SAL);
                cmd.Parameters.AddWithValue("@dept",em.DEPTNO);

                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                

            }
            return rowsAffected;

        }



    }
}
