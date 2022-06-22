using System;

namespace MethodOverloading
{
    internal class Program
    {
        static int Add(int x, int y) {return x + y;}
        
        static decimal Add(decimal x, decimal y) {return x + y;}
        
        static string Add(int x, int y, bool dollars)
        {
            int num = x + y;
            string result;
            string money;

            switch (num) {
                case 1:
                    money = " dollar";
                    break;
                default:
                    money = " dollars";
                    break;
            }
            result = (dollars) ? num.ToString() + money : num.ToString();
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.5m, 1.7m));
            Console.WriteLine(Add(5,10,true));
            Console.WriteLine(Add(5,10,false));
            Console.WriteLine(Add(0,1,true));
        }
    }
}
