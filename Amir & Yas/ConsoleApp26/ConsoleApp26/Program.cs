using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Teacher T = new Teacher();
                T.TeacherName = "Amir"; // the gaav :)
                Teacher.TeacherCount++;

                Student S1 = new Student();
                S1.StudentName = "Yasamin"; // :)
                S1.Grade = "A";
                Student.StudentCount++;

                Student S2 = new Student();
                S2.StudentName = "Somayyeh";
                S2.Grade = "C";
                Student.StudentCount++;

                Console.WriteLine("Teachers: " + Teacher.TeacherCount);
                Console.WriteLine("Students: " + Student.StudentCount);

                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
    }
}
