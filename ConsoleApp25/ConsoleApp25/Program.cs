using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            //فرق بین کلاس های استاتیک و غیر استاتیک
        
            //Math1 a = new Math1(); ===> اینجا به علت استاتیک بودن کلاس نمیتوانیم از آن یک شئ بسازیم.
            Math2 b = new Math2(); // در این کلاس اما به دلیل استاتیک نبودن آن، ساختن یک شئ شدنی است.

         
            //فرق بین متد های استاتیک و غیر استاتیک
            Math1.GetPow(4);
            //Math2.GetPow(4); این متد در این کلاس به دلیل استاتیک نبودن کار نمیکند.

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
