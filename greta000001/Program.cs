using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          Console.WriteLine(toto().ToString());

            Console.WriteLine(toto2(10,5).ToString());
            Console.WriteLine(toto2(54,89).ToString());
            Console.WriteLine(toto2(58485,645).ToString());
            Console.WriteLine(toto2(554,555).ToString());

            Console.WriteLine(toto3(1, 1).ToString());


            /// <summary>
            /// 
            /// </summary>
            /// <param name="param1"></param>
            /// <param name="param2"></param>
            /// <returns></returns>
            int toto()
            {
                int resultat = 0;
                int x = 3;
                int y = 4;
                resultat = x + y;
                return resultat;

            }
            int toto2(int param1,int param2)
            {
                int resultat = 0;

                resultat = param1 + param2;
                return resultat;

            }
            int toto3(int param1, int param2)
            {
                return param1 + param2;

            }
        }
        

    }
}