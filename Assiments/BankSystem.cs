using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNF3_S1_DAY1
{
    internal class BankSystem
    {
        
        private static List<Account> Accounts = new List<Account>();
        private static List<History> Records = new List<History>();



        public void insert(Account account)
        {
            Accounts.Add(account);
        }

        public void Deposite( int id , int value)
        {
            int result = find(id);
            if (value > 0)
            {
                if (result != -1)
                {
                    Accounts[result].balance += value;
                    Console.WriteLine($"Deposited {value}");
                    History h = new History("Deposite", value, 0, 0 );
                    Records.Add(h);
                }
                else
                {
                    Console.WriteLine("this account not Exict");
                }
            }
            else {
                Console.WriteLine("invalid vlaue");
            }
           
            
        }

        public void Withdraw(int id , int value)
        {
            int result = find(id);
            if (value > 0)
            {
                if (result != -1)
                {
                    if (Accounts[result].balance >= value)
                    {
                        Accounts[result].balance -= value;
                        Console.WriteLine($"Withdraw {value} ");
                        History h = new History("Withdraw", value, 0, 0);
                        Records.Add(h);

                    }
                    else
                    {
                        Console.WriteLine($"Your Balance is = {Accounts[result].balance}");

                    }
                }
                else
                {
                    Console.WriteLine("this account not Exict");
                }
            }
            else
            {
                Console.WriteLine("invalid vlaue");
            }



        }

        public void Remove(int id) {
        int result = find(id);
            if(result != -1)
            {
                if (Accounts[result].balance == 0)
                {
                    Accounts.RemoveAt(result);
                    Console.WriteLine("this account is deleted");
                }else
                {
                    Console.WriteLine("this account have money");
                }

            }
            else
            {
                Console.WriteLine("this account not Exict");
            }

        }

        public void Transfer(int seid , int reid ,int value)
        {
            int se = find(seid);
            int re = find(reid);
            if(value > 0)
            {
                if (se != -1 && re != -1)
                {
                    Withdraw(seid, value);
                    Deposite(reid, value);
                    Console.WriteLine($"Transfer {value}susses from {seid} to {reid}");
                    History h = new History("Transfer", value, seid, reid);
                    Records.Add(h);
                }
            }
            
        }

        public  bool Searchid(int id)
        {
            foreach (Account account in Accounts)
            {
                if (id == account.id)
                {
                    return true;
                }
               
            }
            return false;
        }

        public bool SearchName(String name)
        {
            foreach (Account account in Accounts)
            {
                if (name == account.full_name)
                {
                    return true;
                }

            }
            return false;
        }

        public int find(int id)
        {
            foreach (Account account in Accounts)
            {
                if (id == account.id)
                {
                    return Accounts.IndexOf(account);
                }

            }
            return -1;
        }

        public void DispalyAllAccount()
        {
            foreach (Account account in Accounts)
            {
                account.Display();
            }

        }

        public void DispalyAllRecords()
        {
            foreach (History re in Records)
            {
                re.Display();
            }

        }
        class Program
        {
           

        }
    }

}
