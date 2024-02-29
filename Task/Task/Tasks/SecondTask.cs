// Raqamlar qatorining yig‘indisini hisoblash

/*
Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab, natijani ekranga chiqaradigan dastur tuzing.
Input = 10;
Output = 55;
*/

namespace Task
{
    public class SecondTask
    {
        public static void Task()
        {
            Console.Write("Enter the number N: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int iterator = 1; iterator <= number; iterator++)
            {
                sum += iterator;
            }

            Console.WriteLine($"The sum of natural numbers from 1 to {number}: {sum}");
        }
    }
}
