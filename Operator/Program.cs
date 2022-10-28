using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Atama ve İşlemler
            int x = 3;
            int y = 2;

            y = 2 + 2;
            y += 2; // İşlemli atama denir.
            y /= 2;

        //Mantıksal Öperatörler
            //||, &&,!

            bool isSucces = true;
            bool isComploted = false;


            if(isSucces && isComploted)
            {
                Console.WriteLine("Doğru");
            }

            if(isSucces || isComploted)
            {
                Console.WriteLine("Doğru");
            }


            //  İlişkisel Öperatörler
            // <, >, ==,<=,>=,!=


            //Aritmetik
            // +, -, *, /, %, ++, --

            int x1 = 4;
            int x2 = 2;

            int result = x1 - x2;

            result = x1 * x2;
            result = x1++;

            //Mod alma

            int result2 = 10 % 3;
            Console.WriteLine(result2);


        }

    }

}
