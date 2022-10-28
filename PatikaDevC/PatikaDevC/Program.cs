
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDevC
{
    public class Program

    {
        static void Main(string[] args)
        {
            byte _byte = 5;     // 1byte  0-255 

            
            sbyte _sbyte = 2;   // 1 byte  -128 / +127
            
            short _short = 3;   //2 byte  -32.00 / +32.000          
            
            ushort _ushort = 5; //2byte  0 /  65000  

            
            Int16 i16_ = 2; // 2byte 
            
            int _int = 4; //4byte

            Int32 _int32 = 2; // 4 byte 

            
            
            Int64 _int64 = 3;  //8byte 

            long _long = 3;  // 8byte 
            ulong _ulong = 5; // 8 byte 

            float _float = 4; // 4byte 

            double _double = 5; // 8byte 
            decimal _decimal = 5; //16byte 

            char _char ='a'; // Tek karakter tutmak için kullanırız.

            string _string = "Abdullah"; //Sınırsız karakter tutabilir.

            bool _bool = true; //TRUE FALSE 

           DateTime _datetime = DateTime.Now; // bügünün tarihini verir.
            Console.WriteLine(_datetime);

            object _object = 'x';

            string _str = string.Empty;
            string _str2 = null;


            int x= 10;
            string y= "10";

            Console.WriteLine(x.ToString() + y);
            Console.WriteLine(x + Convert.ToInt32(y));

            int x22 = x + int.Parse(y);
            Console.WriteLine( x22);


            string _datetime2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(_datetime2);

            string _hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(_hour);






        }
    }
}

