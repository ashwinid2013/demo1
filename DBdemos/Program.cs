using Employee;

namespace DBdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DbConnect db = new DbConnect();
            List<Emp> e = db.GetEmployees();
            Console.WriteLine("---------Emp Display---------");
            foreach (Emp emp in e)
            {
                Console.WriteLine(emp);
            }

            *//*Console.WriteLine("-----------Salary Update-------");
            int res = db.updateSalary(7788);
            if (res > 0)
                Console.WriteLine("Record Updated Successfully");

            Console.WriteLine("-----------Employee Delete-------");
            int res1 = db.DeleteEmp(7902);
            if (res > 0)
                Console.WriteLine("Record deleted Successfully");*//*

            Console.WriteLine("-----------Employee Insertion-------");
            int res3 = db.InsertEmp(new Emp(3244, "Manish", "Manager", 4000.0m, 40));
            if (res3 > 0)
                Console.WriteLine("Record inserted Successfully");
*/

            /*Disconnected dt = new Disconnected();
            List<Emp> e = dt.GetEmployees();
            Console.WriteLine("No of Employee : " + e.Count());
            foreach (Emp emp in e)
            {
                Console.WriteLine(emp);
            }*/

            /* DbConnect123 d1= new DbConnect123();
             Emp e = d1.GetEmp(6667);
             Console.WriteLine("---------Emp Display---------");
             Console.WriteLine(e);*/



        }
    }
}
