using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIFRUL_LUI_CEZAR
{
    internal class Program
    {

            static string Cezar(string text, int cheie)
            {
                char[] rezultat = text.ToCharArray();

                for (int i = 0; i < rezultat.Length; i++)
                {
                    if (rezultat[i] >= 'a' && rezultat[i] <= 'z')
                    {
                        rezultat[i] = (char)((rezultat[i] - 'a' + cheie + 26) % 26 + 'a');
                    }
                    else if (rezultat[i] >= 'A' && rezultat[i] <= 'Z')
                    {
                        rezultat[i] = (char)((rezultat[i] - 'A' + cheie + 26) % 26 + 'A');
                    }
                }

                return new string(rezultat);
            }

            static void Criptanaliza(string text)
            {
                Console.WriteLine("\nCriptanaliza:");
                for (int k = 1; k <= 25; k++)
                {
                    Console.WriteLine($"Cheia {k}: {Cezar(text, -k)}");
                }
            }

            static void Main()
            {
                Console.Write("Introdu textul: ");
                string text = Console.ReadLine();

                Console.WriteLine("\nCriptare (+3): " + Cezar(text, 3));
                Console.WriteLine("Decriptare (-3): " + Cezar(text, -3));

                Criptanaliza(text);
            }
        }
    }