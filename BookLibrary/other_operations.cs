using MySqlConnector;
namespace Employee
{
    public class DbConnect123
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
                        reader["SAL"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["SAL"]),
                        reader["DEPTNO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DEPTNO"])));
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
            int rowsAffected;
            using (var conn = new MySqlConnection(constr))
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into emp(EMPNO,ENAME,JOB,SAL,DEPTNO) values(@eno,@name,@job,@sal,@dept)";
                cmd.Parameters.AddWithValue("@eno", em.EMPNO);
                cmd.Parameters.AddWithValue("@name", em.ENAME);
                cmd.Parameters.AddWithValue("@job", em.JOB);
                cmd.Parameters.AddWithValue("@sal", em.SAL);
                cmd.Parameters.AddWithValue("@dept", em.DEPTNO);

                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();


            }
            return rowsAffected;

        }



        public Emp GetEmp(int empno)
        {
            Emp e = null;

            //List<Emp> list = new List<Emp>();
            using (MySqlConnection conConn = new MySqlConnection(constr))
            {
                try
                {

                    conConn.Open();
                    string Query = "Select * from emp where empno= @empno";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    cmd.Parameters.AddWithValue("@empno", empno);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        e = new Emp(
                            Convert.ToInt32(reader["EMPNO"]),
                            Convert.ToString(reader["ENAME"]),
                            Convert.ToString(reader["JOB"]),
                            reader["SAL"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["SAL"]),
                            reader["DEPTNO"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DEPTNO"]));

                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
            return e;
            /*DbConnect123 d1 = new DbConnect123();
           Emp e = d1.GetEmp(6667);
           Console.WriteLine("---------Emp Display---------");
           Console.WriteLine(e);*/


        }


        public int UpdateEmp(Emp e)
        {
            int res = 0;
            //string con = "Server=localhost;Database=sqldb;uid=root;pwd=root";
            using (MySqlConnection conConn = new MySqlConnection(constr))
            {
                try
                {
                    conConn.Open();
                    string Query = "Update  emp  set ename = @name," +
                        "sal= @sal," +
                        "job= @job,deptno=@deptno where EMPNO=@eno";
                    MySqlCommand cmd = new MySqlCommand(Query, conConn);
                    cmd.Parameters.AddWithValue("@eno", e.EMPNO);
                    cmd.Parameters.AddWithValue("@name", e.ENAME);
                    cmd.Parameters.AddWithValue("@sal", e.SAL);
                    cmd.Parameters.AddWithValue("@job", e.JOB);
                    cmd.Parameters.AddWithValue("@deptno", e.DEPTNO);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
            return res;


        }



    }
}

