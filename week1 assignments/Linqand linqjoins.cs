using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
   
        public class student
        {
            public int studentID { get; set; }
            public string name { get; set; }
            public int age{ get; set; }
            public int BatchID{ get; set; }
        }
    public class emp
    {
        public int empID { get; set; }
        public string name { get; set; }
       
    }
    class program
    {

    
        static void Main(string[] args)
        {
            IList<student> studentlist = new List<student>()
            {

            new student() { studentID = 1, name = "soumya", age = 20, BatchID = 101 },
            new student() { studentID = 2, name = "swa", age = 21, BatchID = 102 },
            new student() { studentID = 3, name = "praveen", age = 22, BatchID = 103 },
            new student() { studentID = 4, name = "krupa", age = 23, BatchID = 104 },



            };
            IList<emp> emplists = new List<emp>()
            {

            new emp() { empID = 1, name = "soumya" },
            new emp() { empID = 2, name = "swa" }
            


            };
            var name = studentlist.Where(st => st.age > 18).Select(s => s).Where(st => st.BatchID > 101).Select(s => s);
            var name1 = studentlist.Where(st => st.studentID> 1).Select(s => s).Where(st => st.BatchID > 101).Select(s => s);
            foreach(var x in name)
            {
                Console.WriteLine(x);
            }
            foreach(var y in name1)
            {
                Console.WriteLine(y);
            }
            var group = from s in studentlist
                        where s.age > 13 && s.age < 30
                        where s.BatchID > 101
                        group s by s.studentID into sd
                        orderby sd.Key
                        select new { sd.Key, sd };

            foreach(var z in group)
            {
                Console.WriteLine(z);
            }
            var join = from s in studentlist
                       join e in emplists
                       on s.studentID equals e.empID
                       select new
                       {
                           empName = e.name,
                           studentage = s.age,

                       };
            foreach(var a in join)
            {
                Console.WriteLine(a);
            }



            Console.ReadKey();


        }
    }
}
