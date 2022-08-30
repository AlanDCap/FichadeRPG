using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceProbality
{
    public class Dado
    {
        public List<int> D6 (int n = 1)
        {
            Random r = new Random();
            int result;
            List<int> total = new List<int>();

            for (int i = 0; i < n; i++)
            {
                result = r.Next(1, 12);
                total.Add(result);
            }
            return total;
        }

    }
}
