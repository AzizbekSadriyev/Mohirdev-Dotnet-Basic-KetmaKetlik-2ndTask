// Kalkulyator

/*
Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.
Input = 5;
Input = +;
Input = 5;
Output = 10;
*/

namespace Task
{
    public class FirstTask
    {
        public static void Task()
        {
            Console.Write("Enter the first number: ");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the operation: ");
            string? operation = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the second number: ");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            string result = operation switch
            {
                "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
                "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
                "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
                "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
                _ => "Operation Not Found"
            };

            Console.WriteLine(result);
        }
    }
}
