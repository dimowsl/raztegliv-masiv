using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raztegliv_masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko chisla shte vuvejdash za purviq masiv: ");
            int n1 = int.Parse(Console.ReadLine());

            int[] masiv1 = new int[n1];
            Console.WriteLine("Vuvedi chislata za purviq masiv:");

            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Chislo {i + 1}: ");
                masiv1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Kolko chisla shte vuvejdash za vtoriq masiv: ");
            int n2 = int.Parse(Console.ReadLine());

            int[] masiv2 = new int[n2];
            Console.WriteLine("Napishi chislata za vtoriq masiv:");

            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Chislo {i + 1}: ");
                masiv2[i] = int.Parse(Console.ReadLine());
            }

            bool neshtosi = true;

            if (n1 == n2)
            {
                for (int i = 0; i < n1; i++)
                {
                    if (masiv1[i] != masiv2[i])
                    {
                        neshtosi = false;
                        break;
                    }
                }
            }
            else
            {
                neshtosi = false;
            }

            if (neshtosi)
            {
                Console.WriteLine("Ednakvi sa");
            }
            else
            {
                Array.Sort(masiv1);
                Array.Sort(masiv2);
                bool sortirani = true;
                for (int i = 0; i < n1; i++)
                {
                    sortiran
                }
                Console.WriteLine("Razlichni sa");
            }

            
        }
    } 
    }

