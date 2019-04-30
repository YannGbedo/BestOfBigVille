using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestOfBigVille.Models;

namespace BestOfBigVille
{
    class Program
    {
        public static List<Ville> MesVilles;
        static void Main(string[] args)
        {
            MesVilles = Json.GetJson();
            Console.ReadKey();
        }
    }
}
