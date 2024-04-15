namespace Constructors
{
    internal class Person
    {
        string Name;
        int Age;
        string Address;

        public Person(string Name, int Age, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nName    : {Name}\nAge     : {Age}\nAddress : {Address}\n");
        }

        public static void Main()
        {
            Console.Write("Enter Person Name : ");
            string? Name = Console.ReadLine();
            Console.Write("Enter age of Person : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Address of Person : ");
            string? Address = Console.ReadLine();

            Person p = new Person(Name, Age, Address);

            p.DisplayInfo();
            Console.ReadLine();
        }

    }
}
