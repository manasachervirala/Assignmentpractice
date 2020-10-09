using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_expresions
{
    //DEfine the delegates with respected methods with the code
   public delegate double AddnumsDelegate(int x,float y,double z);
    public delegate void Addnums2Delegate(int x, float y, double z);//
    public delegate bool CheckDelegate(string str);
    class Program
    {
        //method with returning value
        public static double Addnums(int x, float y, double z)
        {
            return (x + y + z);
        }
        //method with non returning value
        public static void Addnum2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool Check(string name)
        {
            //check the string whose lenght is greater than the four
            if (name.Length>4)
                return true;
            return false;

        }
        //    public static double Add(string name)
        //    {
        //        return "hello" + " " + name + "GOOD Afternoon";
        //    }
        static void Main(string[] args)
        {
            //AddnumsDelegate obj1 = new AddnumsDelegate(Addnums);//new variables to store the values ---return value
            //double result = obj1.Invoke(10, 3.14f, 123.12324);
            //Console.WriteLine(result);
            /*  AddnumsDelegate obj1 = delegate(int x,float y,double z)*///new variables to store the values ---return value
                                                                         //AddnumsDelegate obj1 = (x,y,z) =>  //using the lamda operator
          Func<int,float,double,double> obj1 = (x, y, z) => 
            {
               return(x + y + z);
            };
            
           //double result = obj1.Invoke(10, 3.14f, 123.12324);

            Console.WriteLine(obj1);
            Action<int, float, double> obj2 = (x, y, z) =>
               {
                   Console.WriteLine(x + y + z);
               };
            obj2.Invoke(10, 3.14f, 12345.123434);

            //Addnums2Delegate obj2 = new Addnums2Delegate(Addnum2);//non return type
            //obj2.Invoke(10, 3.14f, 12345.123434);
            Predicate<string> obj3 = (name) =>
             {
                 if (name.Length > 4)
                     return true;
                 return false;

             };

            //CheckDelegate obj3 = new CheckDelegate(Check);//New Variable to store the value --return value
            //bool check = obj3.Invoke("MANASA");
            //Console.WriteLine(check);
            //Console.ReadLine();




            // GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            //GreetingsDelegate obj = delegate (string name)//initializing delegate using anonoyous 
            //{
            //    return "hello  " + "  " + name +" "   +     "  GOOD Afternoon";
            //};
            //GreetingsDelegate obj = name=> // lamda operator 
            //{
            //    return "hello" + " " + name + "GOOD Afternoon";
            //};
            //string str = obj.Invoke("Manasa");
            //Console.WriteLine(str);
            //Console.ReadLine();
            //
        }
}

}