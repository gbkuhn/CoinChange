using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinLibrary
{
    public class Class1
    {
        public int amount_q;
        public int amount_d;
        public int amount_n;
        public int amount_p;

        public int prompt()
        {
            Console.WriteLine("What is the amount of change you wish to receive from 1 to 99 cents");
            string amount = Console.ReadLine();
            return Convert.ToInt32(amount);
        }

        public int amount_quarters(int change)
        {

            return amount_q;
        }

        public int amount_dimes(int change)
        {

            return amount_d;
        }

        public int amount_nickels(int change)
        {

            return amount_n;
        }

        public int amount_pennies(int change)
        {

            return amount_p;
        }
    }
}
