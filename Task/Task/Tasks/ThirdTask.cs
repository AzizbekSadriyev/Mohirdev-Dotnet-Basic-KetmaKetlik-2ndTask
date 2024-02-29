// Paritet tekshiruvi

/*
Foydalanuvchi kiritgan raqamning juft yoki toq ekanligini aniqlaydigan va shunga mos ravishda xabarni chiqaradigan dastur tuzing.
Input = 3;
Output = “Toq”
*/

using System.Transactions;

namespace Task
{
    public class ThirdTask
    {
        public static void Task()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = (number%2) switch
            {
                1 => $"{number} is odd number.",
                0 => $"{number} is even number.",
                _ => "Number is negative"
            };

            Console.WriteLine(result);
        }
    }
}
