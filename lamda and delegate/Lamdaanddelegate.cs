using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentonallDelegates
{
    public delegate int Add1Delegate1(int a, int b);
    public delegate bool Add2Delegate2(int a);
    public delegate void Add3Delegate3(string name);
    public delegate void Add4Delegate4(int a);
    public delegate bool Add5Delegate5(string name);
    public delegate bool Add6Delegate6(string name);

    class Program
    {
        //public static int concat (int num1 ,int num2)
        //{
        //return num1 + num2;
        //  }
        //public static bool Ieven(int a)
        //{
        // if(a% 2==0)
        //{
        //return true;
        //}
        //else
        //   return false;
        //}
        //public static void message(string name)
        //{
        //Console.WriteLine(name);
        //}
        //public static void square(int a)
        //{
        //  Console.WriteLine(a* a);
        //}
        //public static bool IsEmpty(string str)
        //{
        //   if(str.Lenght ==0)
        //{
        //   return true;
        //}
        // else
        //{
        // return false;
        //}
        //}



        static void Main(string[] args)
        {

            //****** delegate******//
            //initializing the delegates
            //ADD1Delegate1 obj1 =new Add1Delegate1(concat);
            //Console.WriteLine(obj1(10,20));

            //AddDelegate2 obj2 = new Add2Delegate2(Iseven);
            //Console.WriteLine(obj2(2));

            //Add3Delegate3 obj3 = new Add3Delegate3(mesaage);
            //obj3("manasa");

            //Add4Delegate4 obj4= new Add4Delegate4(square);
            //obj4(3);

            //Add5Delegate5 obj5 = new AddDelegate5(Issupper);
            //Console.WriteLine(onj5("manasa");
            //Add6Delegate6 obj6 = new Add6Delegate6(IsEmpty);
            //Console.WriteLine(onj6("usha"));

            //***************Anonymous***************///////
            //Add1Delegate1 obj1 = delegate (int num1, int num2)
            //{
            //    return num1 + num2;
            //};
            //Add2Delegate2 obj2 = delegate (int a)
            // {
            //     if (a % 2 == 0)
            //     {
            //         return true;
            //     }
            //     else
            //         return false;
            // };
            //Add3Delegate3 obj3 = delegate (string name)
            // {
            //     Console.WriteLine(name);
            // };
            //Add4Delegate4 obj4 = delegate (int a)
            //{
            //    Console.WriteLine(a * a);
            //};
            //Add5Delegate5 obj5 = delegate (string str)
            //{
            //    return str.Equals(str.ToUpper());
            //};
            //Add6Delegate6 obj6 = delegate (string str)
            //{
            //    if (str.Length == 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //};

            //int val = obj1.Invoke(20, 20);
            //Console.WriteLine(val);
            //bool val1 = obj2.Invoke(10);
            //Console.WriteLine(val1);
            //obj3.Invoke("manasa");
            //obj4.Invoke(3);
            //Console.WriteLine(obj5("manasa"));
            //Console.WriteLine(obj6("manasa"));

            /////***********Lamda Expression********/////////
            //Add1Delegate1 obj1 = (num1, num2) =>
            // {
            //     return num1 + num2;
            // };
            //Add2Delegate2 obj2 = a=>
            //{
            //    if (a % 2 == 0)
            //    {
            //        return true;
            //    }
            //    else
            //        return false;
            //};
            //Add3Delegate3 obj3 = ( name)=>
            //{
            //    Console.WriteLine(name);
            //};
            //Add4Delegate4 obj4 =  a=>
            //{
            //    Console.WriteLine(a * a);
            //};
            //Add5Delegate5 obj5 =  str=>
            //{
            //    return str.Equals(str.ToUpper());
            //};
            //Add6Delegate6 obj6 = delegate (string str)
            //{
            //    if (str.Length == 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //};
            //int val = obj1.Invoke(20, 20);
            //Console.WriteLine(val);
            //bool val1 = obj2.Invoke(10);
            //Console.WriteLine(val1);
            //obj3.Invoke("manasa");
            //obj4.Invoke(3);
            //Console.WriteLine(obj5("manasa"));
            //Console.WriteLine(obj6("manasa"));
            //******Func,Action,Delegate**********//////
            //Func delegate
            Func<int, int, int> obj1 = (num1, num2) =>
               {
                   return num1 + num2;

               };
            Func<int, bool> obj2 = a =>
              {
                  if (a % 2 == 0)
                  {
                      return true;
                  }
                  else
                      return false;
              };
            Action<string> obj3 = (name) =>
             {
                 Console.WriteLine(name);
             };
            Action<int> obj4 = a =>
            {
                Console.WriteLine(a * a);
            };

            //predicate
            Predicate<string> obj5 = str =>
            {
                return str.Equals(str.ToUpper());
            };
            Predicate<string> obj6 = delegate (string str)
             {
                 if (str.Length == 0)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }

             };
            int val = obj1.Invoke(20, 20);
            Console.WriteLine(val);
            bool val1 = obj2.Invoke(10);
            Console.WriteLine(val1);
            obj3.Invoke("manasa");
            obj4.Invoke(3);
            Console.WriteLine(obj5("manasa"));
            Console.WriteLine(obj6("manasa"));
            Console.ReadKey();


        }
    }
}
