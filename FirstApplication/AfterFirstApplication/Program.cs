using System;

namespace AfterFirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("{0}, сколько вам лет?", name);
            string age = Console.ReadLine();
            Console.WriteLine("{0}, как называется ваша профессия?", name);
            string job_title = Console.ReadLine();
            Console.WriteLine("{0}, сколько вы работаете в профессии {1}?",
                name, job_title);
            string job_term = Console.ReadLine();
            Console.WriteLine("Вас зовут {0}, вам {1} лет, вы {2} лет работаете {3}ом.",
                name, age, job_term, job_title);
        }
    }
}
