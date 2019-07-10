using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2000, 3, 10);
            Person human = new Person(date, "00000000000");
            human.Name = Console.ReadLine();
            human.LastName = Console.ReadLine();
            human.Patronymic = Console.ReadLine();
            Console.WriteLine(human.Fullname());
            Console.WriteLine(human.GetAges());
            Console.ReadKey();

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public readonly DateTime Date_of_birth;
        public readonly string ID;
        public Person(DateTime date, string id)
        {
            Date_of_birth = date;
            ID = id;
            Name = LastName = Patronymic = "Unknown";


        }
        public string Fullname()
        {
            return ($"name:{Name}, lastname:{LastName}, patronymic:{Patronymic}");
        }
        public string Shortname()
        {
            return ($" lastname:{LastName}.{Name[0]}.{Patronymic[0]}");
        }
        public int GetAges()
        {
            return (DateTime.Today.Year - Date_of_birth.Year);
        }

    }
}