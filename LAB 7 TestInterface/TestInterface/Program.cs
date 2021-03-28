using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    class Program
    {
        static void Main(string[] args)
        {
          
               
                {
                    Account a1 = new Savings("Adnun", "56567", 600000);
                    Account a2 = new Current("Shurjo", "17761", 1230000);
                    Account a3 = new Overdraft("Nasif", "23876", 5500, 5120);

                    a1.ShowInfo();
                    a1.deposit(2000);
                    a3.widhdraw(21000);


                }
            
        }

    }
}

