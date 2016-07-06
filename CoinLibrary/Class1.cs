using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinLibrary
{
    public class CoinClass
    {
        public static int amount_q;
        public static int remainder_q;

        public static int amount_d;
        public static int remainder_d;

        public static int amount_n;
        public static int remainder_n;

        public static int amount_p;
        public static int remainder_p;
        /*
        public int prompt()
        {
            Console.WriteLine("What is the amount of change you wish to receive from 1 to 99 cents");
            string amount = Console.ReadLine();
            return Convert.ToInt32(amount);
        }
         * */

        public int remainder_quarters(int change)
        {
            amount_q = change/25;
            remainder_q = change%25;

            return remainder_q;
        }

        public int remainder_dimes(int change)
        {
            amount_d = change/10;
            remainder_d = change%10;

            return remainder_d;
        }

        public int remainder_nickels(int change)
        {
            amount_n = change/5;
            remainder_n = change%5;

            return remainder_n;
        }

        public int remainder_pennies(int change)
        {
            amount_p = change/1;
            amount_p = change/1;

            return remainder_p;
        }

        public List<int> print_change()
        {

            //Console.WriteLine("Quarters: "+amount_q+"\n"+"Dimes: "+amount_d+"\n"+"Nickles: "+amount_n+"\n"+"Pennies: "+amount_p);

            var return_list = new List<Int32>();
            return_list.Add(amount_q);
            return_list.Add(amount_d);
            return_list.Add(amount_n);
            return_list.Add(amount_p);

            return return_list;
        }
    }
}
