using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_3.Models
{
    public class MovieDataBase
    {
        private static List<Add> adds = new List<Add>();

        public static IEnumerable<Add> Adds => adds;

        public static void AddAdd(Add add)
        {
            adds.Add(add);
        }
    }
}
