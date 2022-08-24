using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();


            bool loop = true;
            

            while (loop)
            {
                
                CurrentList(students); //shows current student list
                Console.WriteLine("");

                Console.WriteLine("1 - Add students");
                Console.WriteLine("2 - Information about students");
                int SwitchCase = int.Parse(Console.ReadLine());

                if (SwitchCase == 1 || SwitchCase == 2) {

                    if (SwitchCase == 1)
                    {
                                AddStudent(students); // Asks about student informations and adds them to the list
                   
                    }
                    if (SwitchCase == 2)
                    {
                                SpecificStudentInfo(students);                    
                    }

                    
             
                } 
            }



            static void AddStudent(List<Student> list)
            {
                Student student = new Student();
                student.Text();
                list.Add(student);

            }

            static bool AskAddStudent()
            {

                Console.WriteLine("Hey ! Do you want to add students ?");


                if (Console.ReadLine() == "yes")
                {

                    return true;
                } else
                {

                    return false;
                }


            }

            static void CurrentList(List<Student> list)

            {

                Console.WriteLine("");
                Console.WriteLine("this is the current student list:");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i].name);
                }
                Console.WriteLine("");

            }

            static void SpecificStudentInfo(List<Student> list)
            {

                        int number = StudentGetter(list);
                        Console.WriteLine("Age: " + list[number].age);
                        Console.WriteLine("id: " + list[number].id);

            }

            static int StudentGetter(List<Student> list)
            {
                int number = 0;
                CurrentList(list);
                Console.WriteLine("");
                Console.WriteLine("Enter the name of the student: ");
                Console.WriteLine("");
                string name = Console.ReadLine();

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].name.Equals(name))
                    {
                        number = i;
                    }
                }
                return number;
            }




        }




    }

}
