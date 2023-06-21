using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTM.Library.Arrays
{
    public class MergeSorted
    {
        public int[] MergeSortedArrays(int[] first, int[] second)
        {
            var total = first.Length + second.Length;
            int[] result = new int[total];

            int firstTracker = 0;
            int secondTracker = 0;
            int index = 0;
            while (firstTracker < first.Length && secondTracker < second.Length)
            {
                if (first[firstTracker] < second[secondTracker])
                {
                    result[index] = first[firstTracker];
                    firstTracker++;
                }
                else
                {
                    result[index] = second[secondTracker];
                    secondTracker++;
                }
                index++;
            }

            if(firstTracker < first.Length)
            {
                for (int i = firstTracker; i < first.Length; i++)
                {
                    result[index] = first[i];
                    index++;
                }
            }
            else if(secondTracker < second.Length)
            {
                for (int i = secondTracker; i < second.Length; i++)
                {
                    result[index] = second[i];
                    index++;
                }
            }

            return result;
        }

        public int[] MergeSortedInstructorSolution(int[] array1, int[] array2)
        {
            if(array1.Length == 0)
                return array2;
            if(array2.Length == 0)
                return array1;

            int[] mergedArray = new int[array1.Length + array2.Length];

            int array1Item = array1[0];
            int array2Item = array2[0];
            int index = 0;
            //check input
            int array1Index = 1;
            int array2Index = 1;
            while (index < mergedArray.Length)
            {
                if(array1Item < array2Item)
                {
                    mergedArray[index] = array1Item;                    
                    array1Item = array1[array1Index];
                    array1Index++;
                }
                else
                {
                    mergedArray[index] = array2Item;
                    array2Item = array2[array2Index];                    
                    array2Index++;
                }
                index++;

            }
            
            return mergedArray;
        }
    }
}
