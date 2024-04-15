namespace OopsProject
{
    internal class CopyConstructor
    {
        int Id;
        string? Name, Job;
        double Salary;
        bool Status;

        public CopyConstructor(int id, string? name, string? job, double salary, bool status)
        {
            Id = id;
            Name = name;
            Job = job;
            Salary = salary;
            Status = status;
        }

        public CopyConstructor(CopyConstructor Details)
        {
            Id = Details.Id;
            Name = Details.Name;
            Job = Details.Job;
            Salary = Details.Salary;
            Status = Details.Status;
        }

        public void Update(double Amount)
        {
            Salary += Amount; 
        }

        public override string ToString()
        {
            return $"Id     : {Id}\nName   : {Name}\nJob    : {Job}\nSalary : {Salary}\nStatus : {Status}\n";
        }

        public static void Main()
        {
            CopyConstructor C1 = new CopyConstructor(101, "Adhi Murthy", "Software Developer", 32000, true);
            CopyConstructor C2 = new CopyConstructor(C1);

            Console.WriteLine(C1);
            Console.WriteLine(C2);

            C2.Salary = 5000;
            C2.Status = false;

            C1.Update(10000);
            C2.Update(36000);

            Console.WriteLine(C1);
            Console.WriteLine(C2);

            Console.ReadKey();
        }
    }
}
