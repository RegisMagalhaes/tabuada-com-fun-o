using System;

namespace Auladia20
{
    class Program
    {
        static void Main(string[] args)
        {
            static void tabuada(int numero) {
               for (int i=1;i<=10;i++){
                   Console.WriteLine(numero+ "x" +i+ "=" +(numero*i));
               }

            }

            tabuada(4);
        }

    }
}
