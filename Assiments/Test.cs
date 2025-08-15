using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNF3_S1_DAY1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Account f = new Account("ahmed", "23532535", Convert.ToDateTime("12/3/2025"));
            Account k = new Account("ahmo", "23532535", Convert.ToDateTime("12/3/2025"));

            Account l = new Account("ahmed", "23532535", Convert.ToDateTime("12/3/2025"));

            f.Display();
            k.Display(); l.Display();

            BankSystem bb = new BankSystem();
            bb.insert(f);
            bb.insert(k);
            bb.insert(l);
            bb.Deposite(1112, 400);
            bb.DispalyAllAccount();

            bb.Withdraw(1112, 200);
            Console.WriteLine(bb.Searchid(1112));
            bb.Remove(1111);
            bb.DispalyAllAccount();

            bb.Transfer(1112, 1113, 200);
            bb.DispalyAllAccount();

            bb.DispalyAllRecords();

        }

    }
}
