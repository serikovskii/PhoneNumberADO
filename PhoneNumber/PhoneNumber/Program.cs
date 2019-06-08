using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберете город:\n" +
                        "0 - Астана, 1 - Тараз, 2 - Павлодар " +
                        "3 - Кызыорда, 4 - Шымкент ");
            int choice;
            choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введете номер:");
            string number = Console.ReadLine();
            using (var context = new PhoneAppContext())
            {
                var numbers = new Number()
                {
                    City = context.Cities.ToArray()[choice],
                    CityId = context.Cities.ToArray()[choice].Id,
                    PhoneNumber = number
                };
                context.Numbers.Add(numbers);
                context.SaveChanges();
            }

            Console.WriteLine("номер добавлен");
        }
    }
}
