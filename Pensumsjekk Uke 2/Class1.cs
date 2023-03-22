using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensumsjekk_Uke_2
{
    public class Class1
    {
        private List<Student> students { get; set; }

        public Class1()
        {
            InitializeStudents();
            StartMenu();
        }

        public void StartMenu()
        {
            Console.Clear();
            AllAvailableCourses();
            Console.WriteLine("Skriv inn et kurs for å se hvem som deltar.");
            var requestedCourse = Console.ReadLine();
            ChosenCourse(requestedCourse);
        }

        public void ChosenCourse(string requestedCourse)
        {
            switch (requestedCourse)
            {
                case "Excel":
                    ShowCourse(requestedCourse);
                    Console.ReadLine();
                    break;
                case "Brannsikkerhet":
                    ShowCourse(requestedCourse);
                    Console.ReadLine();
                    break;
                case "Maskinfører":
                    ShowCourse(requestedCourse);
                    Console.ReadLine();
                    break;
                case "Fallsikring":
                    ShowCourse(requestedCourse);
                    Console.ReadLine();
                    break;
                case "Førstehjelp":
                    ShowCourse(requestedCourse);
                    Console.ReadLine();
                    break;
                case "Stillasbygger":
                    ShowCourse(requestedCourse);
                    Console.ReadLine();
                    break;
                default:
                    StartMenu();
                    break;
            }
        }

        public void ShowCourse(string course)
        {
            Console.Clear();
            Console.WriteLine($"--- Kurs: {course} ---\n");
            foreach (var student in students.Where(x => x.Course == course))
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("\nTrykk ESC for å gå tilbake til start-menyen...");
            var input = Console.ReadKey(true);

            while (input.Key != ConsoleKey.Escape)
            {
                input = Console.ReadKey(true);
            }
            StartMenu();
        }

        public void InitializeStudents()
        {
            students = new List<Student>()
            {
                new Student("Nora", 43, "Excel"),
                new Student("Emma", 22, "Brannsikkerhet"),
                new Student("Emil", 63, "Maskinfører"),
                new Student("William", 29, "Fallsikring"),
                new Student("Filip", 54, "Excel"),
                new Student("Lucas", 31, "Førstehjelp"),
                new Student("Ella", 48, "Førstehjelp"),
                new Student("Jonas", 25, "Stillasbygger"),
                new Student("Sophie", 23, "Brannsikkerhet")
            };
        }

        public void AllAvailableCourses()
        {
            Console.WriteLine("--- Kurs ---\n");

            Console.WriteLine("Excel");
            Console.WriteLine("Brannsikkerhet");
            Console.WriteLine("Maskinfører");
            Console.WriteLine("Fallsikring");
            Console.WriteLine("Førstehjelp");
            Console.WriteLine("Stillasbygger\n");
        }
    }
}
