using Struct;

internal class Program
{
    private static void Main(string[] args)
    {
        Student stu1 = new Student();
        stu1.Id = 1234;
        stu1.Name = "Ferdi";
        stu1.SurName = "Bayram";
        stu1.Gender = true;

        Console.WriteLine($"No: {stu1.Id} " +
            $"{stu1.Name}-{stu1.SurName}-{(stu1.Gender ? "Erkek" : "Kadın")}");
        Console.WriteLine("********************************");
        Student stu2 = new Student(678, "Ayşe", "Ayık", false);
        Console.WriteLine($"No: {stu2.Id} " +
            $"{stu2.Name}-{stu2.SurName}-{(stu2.Gender ? "Erkek" : "Kadın")}");
    }
}