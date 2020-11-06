using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBrief4.SortingAlgorithms
{
    public class BucketSort
    {
        public static List<TShirt> SortTShirtsFabric(List<TShirt> tShirts)
        {
            List<TShirt> sortedList = new List<TShirt>();

            int numOfBuckets = 4;
            // Create buckets
            List<TShirt>[] buckets = new List<TShirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<TShirt>();
            }

            // Iterate and add each element to the appropriate bucket
            for (int i = 0; i < tShirts.Count; i++)
            {
                int bucket = (int)tShirts[i].Fabric;
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(tShirts[i]);
            }

            // Sort each bucket 
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<TShirt> temp = InsertionSortBucket(buckets[i]);
                sortedList.AddRange(temp);
            }

            return sortedList;
        }

        public static List<TShirt> SortTShirtsFabricDesc(List<TShirt> tShirts) 
        {
            List<TShirt> sortedList = new List<TShirt>();

            int numOfBuckets = 4;
            // Create buckets
            List<TShirt>[] buckets = new List<TShirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<TShirt>();
            }

            // Iterate and add each element to the appropriate bucket
            for (int i = 0; i < tShirts.Count; i++)
            {
                int bucket = (int)tShirts[i].Fabric;
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(tShirts[i]);
            }

            // Sort each bucket 
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<TShirt> temp = InsertionSortBucket(buckets[i]);
                sortedList.AddRange(temp);
                
            }
            return sortedList;
        }

        public static List<TShirt> InsertionSortBucket(List<TShirt> tShirts)
        {
            TShirt temp;

            for (int i = 1; i < tShirts.Count; i++)
            {
                // Store current value in a variable
                int currentValue = (int)tShirts[i].Fabric;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < (int)tShirts[pointer].Fabric)
                    {
                        //Swap
                        temp = tShirts[pointer + 1];
                        tShirts[pointer + 1] = tShirts[pointer];
                        tShirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }
            return tShirts;
        }
    }
}
