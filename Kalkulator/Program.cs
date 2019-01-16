using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            String FirstNumber = "", SecondNumber = "";
            

            int FirstNum = 0;
            int SecondNum = 0;
            try
            {
                Console.WriteLine("Podaj Pierwsza Liczbe 0-10: ");
                FirstNumber = Console.ReadLine();
                FirstNum = Convert.ToInt32(FirstNumber);
                
                    }
            catch(SystemException)
            {

               
                Console.WriteLine("nie wprowadziles poprawnie pierwszej liczby");
                Console.WriteLine("twoja liczba zostanie pominieta");
                Console.WriteLine("nacisnij przycisk");
                Console.ReadKey();
            }
            try
            {
                Console.WriteLine("Podaj druga liczbe 0-10: ");
                SecondNumber = Console.ReadLine();
                SecondNum = Convert.ToInt32(SecondNumber);
            }
            catch (SystemException)
            {
                Console.WriteLine("nie wprowadziles poprawnie drugiej liczby");
                Console.WriteLine("twoja liczba zostanie pominieta");
                Console.WriteLine("nacisnij przycisk");
                Console.ReadKey();
            }

            if (FirstNum > 10 || FirstNum < 0)
            {
                Console.WriteLine("wprowadziles pierwsza liczbe mniejsza od 0 lub wieksza niz 10 ");
                Console.WriteLine("twoja liczba zostanie pominieta");
                Console.ReadKey();

            }
            else if (SecondNum > 10 || SecondNum < 0)
            {
                Console.WriteLine("wprowadziles pierwsza liczbe mniejsza od 0 lub wieksza niz 10 ");
                Console.WriteLine("twoja liczba zostanie pominieta");
                Console.ReadKey();
            }

            int Sum = FirstNum + SecondNum;
            Console.WriteLine("Wynik dodawania to :" + Sum + "");
            Console.ReadKey();

        }

            

        }
    }

    

