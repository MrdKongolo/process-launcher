using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processus
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p;
            Console.WriteLine("Entrez le nom de votre programme à lancer :");
            try
            {
                string prog = Console.ReadLine();
                p= Process.Start(string.Format($"{prog}"));
                Console.WriteLine("Appuyez sur une touche pour mettre fin à ce processus.");
                Console.ReadKey();
                p.Kill();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            Console.ReadKey();
        }
    }
}
