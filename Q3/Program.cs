using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadKey(true).Key;
            bool h = true;
            do
            {
                
                string str = Console.ReadLine();

                int b = str.Length;


                while (str.Length > 0)
                {

                    Console.Write(str[0] + "  ");
                    int k = 0;
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[0] == str[j])
                        {
                            k++;
                        }
                    }
                    Console.WriteLine(k);

                    str = str.Replace(str[0].ToString(), string.Empty);

                }
                if (key == ConsoleKey.End)
                    h = false;
                    

            } while (h == true);
         }
            
    }
}
