using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_17
{
    class Bank_account<T>
    {
        public T Number { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public Bank_account (T number, int balance, string name)
        {
            Number = number;
            Balance=balance;
            Name = name;

        }
        public string GetInfo()
        {
            return $"{Number} {Balance} {Name}";
            
            
        }
    }
}
