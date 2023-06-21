using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTM.Library.Google
{
    public class CollectionSum
    {
        public bool HasPairWithSum(List<int> collection, int sum)
        {
            List<int> compliments = new List<int>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (compliments.Contains(sum - collection[i]))
                    return true;

                compliments.Add(sum - collection[i]);
            }

            return false;


        }
    }
}
