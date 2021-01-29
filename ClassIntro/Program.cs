using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.educator = "Engin Demirog";
            course1.izlenmeRakamlari = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.educator = "Kenan Demir";
            course2.izlenmeRakamlari = 62;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.educator = "Emre Deniz";
            course3.izlenmeRakamlari = 12;

            Course course4 = new Course();
            course4.CourseName = "C++";
            course4.educator = "Emrah Denek";
            course4.izlenmeRakamlari = 100;

            //Console.WriteLine(course1.CourseName + " " + course1.educator);

            Course[] courses = new Course[] {course1,course2,course3,course4};

            foreach (var i in courses)
            {
                Console.WriteLine(i.CourseName+": "+i.educator);
            }


        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string educator { get; set; }
        public int izlenmeRakamlari { get; set; }


    }
}
