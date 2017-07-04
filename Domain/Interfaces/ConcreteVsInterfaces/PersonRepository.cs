using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Interfaces.ConcreteVsInterfaces
{
    public class PersonRepository
    {
        public List<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person() {FirstName = "john", LastName = "smith"},
                new Person() {FirstName = "john", LastName = "smith"},
                new Person() {FirstName = "john", LastName = "smith"},
                new Person() {FirstName = "john", LastName = "smith"},
                new Person() {FirstName = "john", LastName = "smith"},
                new Person() {FirstName = "john", LastName = "smith"}
            };
            return people;
        }

        public Person GetPerson(string lastName)
        {
            return GetPeople().Where(x => x.LastName == lastName).FirstOrDefault();
        }
    }

    public class Operations
    {
        private readonly PersonRepository _repo = new PersonRepository();

        public void ConcreteLogging()
        {
            // If the collection type changes in the future this can break our code. Example of why programming to a concrete class is bad.
            List<Person> people = _repo.GetPeople();

            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }

        public void AbstractLogging()
        {
            // Down the road if the collection changes this code will not have to be modified. Protection from change. If the underlying implementation changes, our code doesnt care!
            // To strongly type:
         // IEnumerable<Person>
            IEnumerable people = _repo.GetPeople();
            
            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}
