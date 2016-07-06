using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinLibrary;


namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;

            CoinClass change_obj = new CoinClass();
           // change = change_obj.prompt();

            change_obj.remainder_pennies(
                change_obj.remainder_nickels(change_obj.remainder_dimes(change_obj.remainder_quarters(99))));

            change_obj.print_change();
            
            Console.ReadLine();
        }
    }
}
