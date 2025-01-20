namespace src
{
    public static class Classes
    {
        public static void Run()
        {
            Dog fido = new Dog("Fido","Boxer",4);

            fido.Bark();
            fido.DisplayInfo();
        }

        public class Dog 
        {
            private string name;
            private string breed;
            private int age;
            public Dog (string name, string breed, int age)
            {
                this.name = name;
                this.breed = breed;
                this.age = age;
            }
            public void Bark()
            {
                Console.WriteLine($"{name} is barking!  Woof woof!");
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}, Breed: {breed}, Age: {age}");
            }
        }
    }
}