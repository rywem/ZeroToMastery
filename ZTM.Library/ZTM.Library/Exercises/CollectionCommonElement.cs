using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTM.Library.Exercises
{
    //Do 2 collections contain a common element
    public class CollectionCommonElement
    {
        public bool DoCollectionsContainCommon(List<string> col1, List<string> col2)
        {
            Dictionary<string, bool> map = col1.ToDictionary(x => x, x => true);

            foreach (string item in col2)
            {
                var value = false;
                if(map.TryGetValue(item, out value))
                {
                    return true;
                }
            }
            return false;
        }

        public bool BruteForce(List<string> col1, List<string> col2)
        {
            for(int i = 0; i < col1.Count; i++)
            {
                for (int j = 0; j < col2.Count; j++)
                {
                    if (col1[i] == col2[j])
                        return true;
                }
            }

            return false;
        }
    }
}
