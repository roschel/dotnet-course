using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void DeleteById(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>(); 
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i+1);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindById(long id)
        {
            return new Person { Id = IncrementAndGet(), FirstName = "João", LastName = "Roschel", Gender = "Male", Address = "Rua xxx" };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person { Id = IncrementAndGet(), FirstName = "João" + i, LastName = "Roschel", Gender = "Male", Address = "Rua xxx" }; 
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
