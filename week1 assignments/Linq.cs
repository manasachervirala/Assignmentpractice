using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class student
    {
        public int id;
        public string name;
        public int age;
        public int std;
    }
    class program
    {


        static void Main(string[] args)
        {
            List<student> mylist = new List<student>()
            {
                new student(){id=1,name="man",age=12,std=2},
                new student(){id=2,name="mana",age=19,std=9},
                new student(){id=3,name="manasa",age=17,std=8},
            };
            var names = mylist.Where(s => s.id > 2).Select(s => s).Where(st => st.age > 19).Select(st => st.name);
            foreach(var item in names)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
    }
    
}
