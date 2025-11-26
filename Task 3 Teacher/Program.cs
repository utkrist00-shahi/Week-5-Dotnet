namespace Task_3_Teacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NepaliTeacher nepaliTeacher = new NepaliTeacher();
            nepaliTeacher.Name = "Harka Sampang";
            Console.WriteLine($"Nepali Teacher Name: {nepaliTeacher.Name}");
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();
            Console.WriteLine();

            EnglishTeacher englishTeacher = new EnglishTeacher();
            englishTeacher.Name = "Balen Shah";
            Console.WriteLine($"English Teacher Name: {englishTeacher.Name}");
            englishTeacher.Teaching();
            englishTeacher.SalaryInfo();
        }
    }
}
