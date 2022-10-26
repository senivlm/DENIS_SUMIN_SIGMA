using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_1
{
    internal static class Check
    {
        public static void StartMessage()
        {
            Console.WriteLine("Вiтаємо вас в магазинi SIGMA SHOP!\n" +
                              "Зараз вам буде запропоновано ввести iнформацiю про вашу покупку в яку входить:\n" +
                              "1 - Кiлькiсть товарiв якi ви будете купувати\n" +
                              "2 - Iнформацiя про товари(назва,вага,цiна,кiлькiсть в штуках товару який ви купили)\n" +
                              "Будь ласка,вводьте iнформацiю дуже уважно!\n" +
                              "Приємного користування!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WorkProcess(Buy buy)
        {
            buy.AddProducts();
            buy.AddNumberProducts();
            buy.PurchaseAmount();
        }

        public static void ShowBuyInfo(Buy buy)
        {
            Console.WriteLine(buy);
        }

        public static void ShowProductInfo(Buy buy)
        {
            for (int i = 0; i < buy.Products.Length; i++)
            {
                Console.WriteLine(buy.Products[i]);
            }
        }       
    }   
}
