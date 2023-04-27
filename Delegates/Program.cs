using System;
using System.Threading.Channels;

namespace Delegates
{
    internal class Program
    {
        //delegate void MyDelegate(Person p);
        
        static void Main(string[] args)
        {
           // MyDelegate myDelegate = delegate (Person person) { };

            List<Person> people = new List<Person>();

            Person person = new Person() { Name = "Yasin", SurName = "Hesenli", Age = 20 };
            Person person1 = new Person() { Name = "Hesen", SurName = "Hesenov", Age = 31 };

            people.Add(person);
            people.Add(person1);

            
           
            people.FindAll(people => people.Name == "Yasin").ForEach(people => Console.WriteLine(people));

            people.FindAll(person => person.SurName.EndsWith("ov") || person.SurName.EndsWith("ova")).ForEach(people => Console.WriteLine(people));

            people.FindAll(person => person.Age == 20).ForEach(people => Console.WriteLine(people));
        }

    }

    }
