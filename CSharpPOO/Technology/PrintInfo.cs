using Technology.Interfaces;

namespace Technology
{
    internal class PrintInfo
    {
        public void Print(ITechnology technology)
        {
            Console.WriteLine($"ID: {technology.Id}");
            Console.WriteLine($"Size: {technology.Size}");
            Console.WriteLine($"Brand: {technology.Brand}");
            Console.WriteLine($"Model: {technology.Model}");
        }
    }
}