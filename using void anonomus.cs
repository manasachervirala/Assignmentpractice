using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voiddelegate
{
    public delegate void AddSumDelegate(int a, int b);
    public delegate void MulDelegate(int a);
    class Program
    {
        static int num = 10;
        public static void AddSum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a)
        {
            num *= a;
            Console.WriteLine("given method is: {0}",num );
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            AddSumDelegate obj = new AddSumDelegate(AddSum);
            obj.Invoke(100, 50);
            MulDelegate obj1 = new MulDelegate(Mul);
            obj1.Invoke( 50);
            Console.ReadLine();
        }
        
    }
}
