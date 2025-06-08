using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryChainOfResponsibility
{
    public class LevelTwoSupport : SupportHandler
    {
        public override bool HandleRequest()
        {
            Console.WriteLine("Підтримка рівня 2:");
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1 - Проблема з технікою");
            Console.WriteLine("2 - Інше");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Вас переключено на підтримку рівня 2.");
                Console.WriteLine("Розглядаємо проблему з технікою...");
                return true;
            }
            else if (choice == "2")
            {
                if (NextHandler != null)
                    return NextHandler.HandleRequest();
                else
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
