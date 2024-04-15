namespace Constructors
{
    internal class Employee
    {
        int Id;
        string? Name;
        double Salary;
        public Employee(int Id, string? Name, double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public double Tax()
        {
            double tax = 0;
            if (Salary > 40000)
            {
                tax = Salary * 5 / 100;
            }
            else if (Salary > 100000)
            {
                tax = Salary * 15 / 100;
            }
            return tax;
        }
        public string GetDetails()
        {
            return $"\nId     : {Id}\nName   : {Name}\nSalary : {Salary}\n";
        }
    }
    internal class EmployeeDetails
    {
        public static void Main()
        {
            Console.Write("Enter Id of the Employee : ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name of the Employee : ");
            string? Name = Console.ReadLine();
            Console.Write("Enter Salary of the Employee : ");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Employee Obj = new Employee(Id, Name, Salary);
            double Tax = Obj.Tax();
            string DetailsOfEmployee = Obj.GetDetails();
            Console.WriteLine("\nEmployee Details : " + DetailsOfEmployee + "Tax    : " + Tax);

            Console.ReadKey();
        }
    }
}
