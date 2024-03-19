namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student students1 = new Student("Memmedeli", "Memmedov",20, 90);
            Student students2 = new Student("Akif", "Niyazov", 21, 87);
            Student student3 = new Student("Murad", "Tagiyev", 19, 75);

            students1.ShowInfo();
            Console.WriteLine("------------------------------------");
            students2.ShowInfo();
            Console.WriteLine("------------------------------------");
            student3.ShowInfo();
          


        }
    }
}
