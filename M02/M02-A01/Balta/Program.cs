using System;
using Balta.ContentContext;
using Balta;

namespace Balta{

    class Program{

        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Advanced;
            foreach(var item in course.Modules){

            }

            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);
            System.Console.WriteLine("====> Final do Programa <====");
        }
    }
}
