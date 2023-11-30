using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_nr_3_tydzień_nr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku Prostkąta");
            double lenght;
            bool option = double.TryParse(Console.ReadLine(), out lenght);
            Console.WriteLine("Podaj szerokość boku Prostokąta");
            double widht;
            bool option2 = double.TryParse(Console.ReadLine(), out widht);
            double diagonal = Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(widht, 2));
            Console.WriteLine($"Długość przekątnej wynosi: {diagonal}");
        }
    }
}