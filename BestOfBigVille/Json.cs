using BestOfBigVille.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfBigVille
{
    class Json
    {
        public const string JsonUri = "./cities.json";
        public static List<Ville> GetJson()
        {

            string Contenue = File.ReadAllText(JsonUri).Replace('\'', ' ');
            return JsonConvert.DeserializeObject<List<Ville>>(Contenue);
        }
    }
}
