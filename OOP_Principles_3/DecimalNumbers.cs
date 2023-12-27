using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_3
{
    internal struct DecimalNumbers
    {
        public int num { get; set; }
        public string binary { get; set; }
        public string octal { get; set; }
        public string hexa { get; set; }
        
        public static void BinarySystem(int num, string binary)
        {
            while(num!=0) 
            { 
                if (num%2==0)
                {
                    num /= 2;
                    binary += "0";
                }
                else
                {
                    num /= 2;
                    binary += "1";
                }
            
            }
            Console.WriteLine($"Number in binary system is {new string(binary.Reverse().ToArray())}");
        }
        public static void OctalSystem(int num, string octal)
        {
            while (num != 0)
            {
                octal += num % 8;
                num /= 8;

            }
            Console.WriteLine($"Number in octal system is {new string(octal.Reverse().ToArray())}");

        }
        public static void HexadecimalSystem(int num, string hexa)
        {
                hexa = Convert.ToString(num,16);
            Console.WriteLine($"Number in hexadecimal system is {hexa}");
        }
    }
}
