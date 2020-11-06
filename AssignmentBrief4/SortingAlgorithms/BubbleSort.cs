using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBrief4.SortingAlgorithms
{
    public class BubbleSort
    {
        private static bool less(int value1, int value2)
        {
            return value1 < value2;
        }
        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }
       
        public static void SortTShirtsColor(List<TShirt> tShirts)
        {
            int size = tShirts.Count;
            bool isSorted = false;
            int lastUnsorted = size - 1;
            TShirt temp;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (more((int)tShirts[i].Color, (int)tShirts[i + 1].Color))
                    {
                        temp = tShirts[i];
                        tShirts[i] = tShirts[i + 1];
                        tShirts[i + 1] = temp;
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }

        }
        public static void SortTShirtsColorDesc(List<TShirt> tShirts)
        {
            int size = tShirts.Count;
            bool isSorted = false;
            int lastUnsorted = size - 1;
            TShirt temp;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (less((int)tShirts[i].Color, (int)tShirts[i + 1].Color))
                    {
                        temp = tShirts[i];
                        tShirts[i] = tShirts[i + 1];
                        tShirts[i + 1] = temp;
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }
        }





    }
}
