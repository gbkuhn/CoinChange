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

            Class1 change_prompt = new Class1();
            change = change_prompt.prompt();

            change_prompt.amount_quarters(change);
        }
    }
}
