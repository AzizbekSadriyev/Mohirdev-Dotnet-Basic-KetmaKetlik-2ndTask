namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Task list:");
            Console.WriteLine("1. Calculator.");
            Console.WriteLine("2. Calculation of the sum of natural numbers up to N.");
            Console.WriteLine("3. Parity check.");
            Console.Write("To select one of the tasks, enter its number:");
            short taskNumber = Convert.ToInt16(Console.ReadLine());
            switch (taskNumber)
            {
                case 1:
                    FirstTask.Task();
                    break;
                case 2:
                    SecondTask.Task();
                    break;
                case 3:
                    ThirdTask.Task();
                    break;
                default:
                    Console.WriteLine("Task Not Found!");
                    break;
            }
        }
    }
}