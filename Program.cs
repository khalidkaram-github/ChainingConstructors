namespace ChainingConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine($"Name={user.Name} , age ={user.Age}");
        }
    }
    class User
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public User() : this(10)
        {

        }
        public User(int age) : this(age, "ahmed")
        {

        }
        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }

}
