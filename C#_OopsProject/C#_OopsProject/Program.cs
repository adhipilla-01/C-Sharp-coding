namespace OopsProject
{
    internal class Program
    {
        int? Id;
        string? Name;
        string? Job;
        string? Contact;
        string? Course;
        double? Fee;

        public Program(int? id, string? name, string? job, string? contact, string? course, double? fee)
        {
            Id = id;
            Name = name;
            Job = job;
            Contact = contact;
            Course = course;
            Fee = fee;
        }

        public override string ToString()
        {
            return $"Id      : {Id}\nName    : {Name}\nJob     : {Job}\nContact : {Contact}\nContact : {Course}\nFee     : {Fee}\n";
        }

        static void Main(string[] args)
        {
            Program Obj = new Program(101, "Pilla AdhiMurthy", "Software Developer", "7702271510", "C#.Net", 25000.00);

            Console.WriteLine(Obj);

            Console.ReadLine();
        }
    }
}
