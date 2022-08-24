using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
     class Student
    {
        public string name { get; set; }
        public int age { get; set; }

        public int id { get; set; }
        
         

        public void Text()
        {
            Console.WriteLine("");
            Console.WriteLine("Name of the student: ");
            name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Age of the student: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("ID of the student: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("");





        }

    }

    
}
