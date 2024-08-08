using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Emp
    {
        public int? EMPNO {  get; set; }
        public string? ENAME{ get; set; }
        public string? JOB{ get; set; }
        public decimal? SAL{ get; set; }
        public int? DEPTNO {  get; set; }
        public Emp(int? EMPNO,String? ENAME,String? JOB,decimal? SAL,int? DEPTNO)
        {
            this.EMPNO = EMPNO;
            this.JOB = JOB;
            this.ENAME = ENAME;
            this.SAL = SAL;
            this.DEPTNO = DEPTNO;
        }
        public override string ToString()
        {
            return $"{EMPNO}-{ENAME}-{JOB}-{SAL}-{DEPTNO}";
        }
    }
}
