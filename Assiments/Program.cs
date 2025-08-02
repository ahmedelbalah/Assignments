namespace MNF3_S1_DAY1
{
    internal class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Hello!");

            Console.WriteLine("Input the first number:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second number:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to do with those numbers? \n[A]dd \n[S]ubtract \n[M]ultiply");
            String z = Console.ReadLine();
            Char zz = z.ToUpper()[0];
            switch (zz)
            {
                case 'A':
                    Console.WriteLine("[A]dd = " + (x + y));
                    break;

                case 'S':
                    Console.WriteLine("[S]ubtract = " + (x - y));
                    break;

                case 'M':
                    Console.WriteLine("[M]ultiply = " + (x * y));
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }



            }
       
        
    }
}
