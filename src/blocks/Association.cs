namespace src
{
    public static class Association
    {
        public static void Run()
        {
            HomeAddress address = new HomeAddress("123 Main St", "Akron", "OH", "12345");
            Student student = new Student("John Doe", address, "S112233");

            Console.WriteLine($"{student.Name} lives at {student.Address.Street}, {student.Address.City}.");
        }

        public abstract class Person
        {
            public string Name { get; set; }
            public HomeAddress Address { get; set; }

            public Person(string name, HomeAddress address)
            {
                this.Name = name;
                this.Address = address;
            }
        }

        public class HomeAddress
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public HomeAddress(string street, string city, string state, string zipCode)
            {
                this.Street = street;
                this.City = city;
                this.State = state;
                this.ZipCode = zipCode;
            }
        }

        public class Student : Person
        {
            public string StudentID { get; set; }
            
            public Student(string name, HomeAddress address, string studentID)
                : base(name, address)
            {
                StudentID = studentID;
            }
        }
    }
}