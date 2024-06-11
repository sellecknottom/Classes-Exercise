namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() {Make = "Buick", Model = "Enclave", Year = "2024"};
            Console.WriteLine($"{car1.Make} {car1.Model} {car1.Year}");
        }
    }
}
