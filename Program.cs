namespace StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxIndent = 3;
            string[] myCars = new string[maxIndent];
            
            Console.WriteLine();
            Console.WriteLine("Add a car brand and close with 'exit'");
            Console.WriteLine();

            int i = 0;
            
            while (true)
            {
                Console.Write("Add a car brand: ");
                string data = Console.ReadLine();

                if (data.ToLower().Trim() == "exit")
                {
                    break;
                }

                if (i == maxIndent - 1) 
                {
                    maxIndent = maxIndent + 3;
                    Array.Resize(ref myCars, maxIndent);
                }

                myCars[i] = data;
                i++;
            }

            Array.Resize(ref myCars, i);

            string[] myCarsOrdered = new string[myCars.Length];
            myCars.CopyTo(myCarsOrdered, 0);
     
            Array.Sort(myCarsOrdered);


            Console.WriteLine();
            Console.WriteLine("My Cars unordered");

            foreach (string car in myCars)
            {
                Console.Write(car + " ");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("My Cars ordered");

            foreach (string car in myCarsOrdered)
            {
                Console.Write(car + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Finished");

        }
    }
}
