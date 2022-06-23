using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> people = new List<Person>();

        public void AddMember(Person person)
        {
            people.Add(person);
        }
        public Person GetOldestMember()
        {
            var maxAge = int.MinValue;
            var oldestMember = new Person();
            foreach (var person in people)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    oldestMember = person;
                }
            }
            return oldestMember;

        }
    }
}
