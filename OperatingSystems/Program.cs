using System;

namespace OperatingSystems
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var input = string.Empty;
            while (input?.ToUpper() != "Q")
            {
                Console.WriteLine("Insert the Client no.!"); 
                input = Console.ReadLine();
                int.TryParse(input, out var clientNumber);
                Console.WriteLine("Insert the Operating system name!");
                input = Console.ReadLine();

                if (clientNumber == 2)
                    Console.WriteLine(Client2.GetResult(input));
                else if (Client != null) Console.WriteLine(Client.GetResult(input));

                Console.WriteLine("To stop press q/Q.");
                input = Console.ReadLine(); 
            }
           

            Console.ReadKey();
        }

        #region private members

        private static readonly Client Client = Client.GetInstance;
        private static readonly Client2 Client2 = new(); 

        #endregion
    }
}
