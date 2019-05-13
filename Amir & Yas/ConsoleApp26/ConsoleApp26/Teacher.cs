using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Teacher
    {
        public string TeacherName;

        public static int TeacherCount = 0;   // ===>
        // این متغییر را از نوع استاتیک تعریف کردیم چراکه "تعداد" معلم ها یا دانش آموزان
        // درواقع ربطی به یک معلم یا دانش آموز بخصوص ندارد و اتفاقا مربوط به "کل کلاس" است
    }
}
