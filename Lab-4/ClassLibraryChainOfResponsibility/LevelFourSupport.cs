using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChainOfResponsibility
{
    public class LevelFourSupport : SupportHandler
    {
        public override bool HandleRequest()
        {
            Console.WriteLine("Підтримка рівня 4:");
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1 - Проблема з адміністрацією");
            Console.WriteLine("2 - Інше");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Вас переключено на підтримку рівня 4.");
                Console.WriteLine("Розглядаємо проблему з адміністрацією...");
                return true;
            }
            else if (choice == "2")
            {
                Console.WriteLine("Немає відповідного рівня підтримки для вашого запиту.");
                return false;
            }
            else
            {
                Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                return false;
            }
        }
    }
}
