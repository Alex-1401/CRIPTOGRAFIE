using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIFRUL__N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu textul: ");
            string text = Console.ReadLine();

            Console.Write("Introdu valoarea n (cheia): ");
            int n = int.Parse(Console.ReadLine());

            string criptat = ProceseazaCezar(text, n);
            Console.WriteLine($"\nCriptare (+{n}): {criptat}");

            string decriptat = ProceseazaCezar(criptat, -n);
            Console.WriteLine($"Decriptare (-{n}): {decriptat}");

            Console.WriteLine("\n--- CRIPTANALIZA (Toate variantele posibile) ---");
            Criptanaliza(criptat);

            Console.ReadKey();
        }

        static string ProceseazaCezar(string input, int n)
        {
            char[] caractere = input.ToCharArray();

            for (int i = 0; i < caractere.Length; i++)
            {
                char c = caractere[i];

                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';

                    int nouaPozitie = (c - offset + n) % 26;
                    if (nouaPozitie < 0) nouaPozitie += 26;

                    caractere[i] = (char)(nouaPozitie + offset);
                }
            }

            return new string(caractere);
        }

        static void Criptanaliza(string textCriptat)
        {
            for (int cheie = 0; cheie < 26; cheie++)
            {
                string incercare = ProceseazaCezar(textCriptat, -cheie);
                Console.WriteLine($"Cheia {cheie}: {incercare}");
            }
        }
    }
    }
