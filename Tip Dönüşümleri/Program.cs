using System;
using System.Runtime.Intrinsics.Arm;

namespace operatorler
{
    class Program
    {


        //Tip Dönüşümleri 

        //Implicit Conversion(Bilinçsiz ya da kapalı dönüşüm)
       // Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanmasıdır.
        byte _a = 5;
        sbyte _b = 30;

        short _c = 23;
        int _d = _a +_b+_c;


        // Explicit Conversion(Bilinçli ya da açık dönüşüm)


        int x = 4;
        byte y = (byte)2; //2'yi byte veri tipine dönüştürmeye çalışır. 

        //ToString()

        int xy22 = 1;
        string yy= xy22.ToString();

        //SystemConvert

        string s1 = "10", s2 = "12";
        int sayi1, sayi2;

        sayi1 = Convert.ToInt32(s1);
        sayi2=Convert.ToInt32(s2);



    }

}
