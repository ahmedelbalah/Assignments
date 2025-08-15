using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNF3_S1_DAY1
{
    internal class Account
    {


        private static int Gen_id = 1111;
        private int Id;
        private String Full_Name;
        protected String National_Id;
        private DateTime Birth;
        private int Balance;
        private DateTime dateOpen = DateTime.Now;
        


        public Account(Account vlaue) {
            Id = Gen_id;
            Gen_id++;
        this.Full_Name = vlaue.Full_Name;
        this.Birth = vlaue.Birth;
        this.Balance = vlaue.Balance;
        this.National_Id = vlaue.National_Id;
        
        }
        public Account(String f, String N, DateTime d)
        {
            Id = Gen_id;
            Gen_id++;
            this.Full_Name = f;
            this.National_Id = N;
            this.Birth = d;
            Balance = 0;
            
        }
        public int id {  get { return this.Id; } }
        public String full_name { get { return this.Full_Name; } set { this.Full_Name = value; } }

        public String national_id { get { return this.National_Id; } set { this.National_Id = value; } }

        public int balance { get { return this.Balance; } set { this.Balance = value; } }

        public DateTime birth { get { return this.Birth; } set { this.Birth = value; } }

        public DateTime dateopen { get { return dateOpen; } }

        public void Display ()
        {
            Console.WriteLine($"Id = {Id} , Full_Name = {Full_Name} , Balance = {Balance}");
        }






        
    }
    }


