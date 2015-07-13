using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.People
{
    class People
    {
        public void MakePerson(int age)
        {
            Person person = new Person();
            person.age = age;
            if (age % 2 == 0)
            {
                person.name = "Батката";
                person.gender = Gender.Male;
            }
            else
            {
                person.name = "Мацето";
                person.gender = Gender.Female;
            }

            return person;
        }

        static void Main(string[] args)
        {
        }
    }
}
