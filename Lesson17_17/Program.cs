using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета");
            int numberInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string name = Console.ReadLine();

            Bank_account<int> Bank_account1 = new Bank_account<int>(numberInt, balance, name);
            Console.WriteLine(Bank_account1.GetInfo());

            Console.WriteLine("Введите строковый номер счета");
            string numberString = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();

            Bank_account<string> Bank_account2 = new Bank_account<string>(numberString, balance, name);
            Console.WriteLine(Bank_account2.GetInfo());
            Console.ReadKey();
        }
    }
}
