namespace NorbitTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш вес в килограммах:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах:");
            double height = Convert.ToDouble(Console.ReadLine());

            Person p = new Person(weight, height);

            BMIstat stat = new BMIstat(p);

            stat.PrintStatistic();

        }
    }
}
