using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Il_tuo_nome_Star_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "", cognome = "", madre_nubile = "", città_nascita = "", Temp_nome, Temp_cognome, lingua;
            Console.Write("Do you want the languege to be [it]alian or [en]glish");
            lingua = Console.ReadLine().ToLower();
            if (lingua == "en" || lingua == "it")
            {
                do
                {
                    Console.Write("Insert youre name: ");
                    nome = Console.ReadLine();
                } while (nome.Length < 2);
                do
                {
                    Console.Write("Insert youre surname: ");
                    cognome = Console.ReadLine();
                } while (cognome.Length < 3);
                do
                {
                    Console.Write("Insert youre maiden mother name: ");
                    madre_nubile = Console.ReadLine();
                } while (madre_nubile.Length < 2);
                do
                {
                    Console.Write("Insert you're birth city: ");
                    città_nascita = Console.ReadLine();
                } while (città_nascita.Length < 3);

                Console.Clear();

                Temp_nome = cognome.Substring(0, 3);
                Temp_nome += nome.Substring(0, 2).ToLower();
                Temp_cognome = madre_nubile.Substring(0, 2);
                Temp_cognome += città_nascita.Substring(0, 3).ToLower();
                Console.WriteLine($"Youre name is '{Temp_nome}', youre surname is {Temp_cognome}");
            } else if (lingua == "it" || lingua == "italian")
            {
                do
                {
                    Console.Write("Inserire il nome: ");
                    nome = Console.ReadLine();
                } while (nome.Length < 2);
                do
                {
                    Console.Write("Inserire il cognome: ");
                    cognome = Console.ReadLine();
                } while (cognome.Length < 3);
                do
                {
                    Console.Write("Inserire il cognome di tua madre da nubile: ");
                    madre_nubile = Console.ReadLine();
                } while (madre_nubile.Length < 2);
                do
                {
                    Console.Write("Inserire la tua città di nascita: ");
                    città_nascita = Console.ReadLine();
                } while (città_nascita.Length < 3);

                Console.Clear();

                Temp_nome = cognome.Substring(0, 3);
                Temp_nome += nome.Substring(0, 2).ToLower();
                Temp_cognome = madre_nubile.Substring(0, 2);
                Temp_cognome += città_nascita.Substring(0, 3).ToLower();
                Console.WriteLine($"Il tuo nome è '{Temp_nome}', il tuo cognome è {Temp_cognome}");
            } else
            {
                Console.WriteLine("You didn't insert a valid languege");
            }
            
            Console.ReadKey();
        }
    }
}
