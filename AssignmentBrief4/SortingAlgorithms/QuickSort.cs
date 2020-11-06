using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBrief4.SortingAlgorithms
{
    public class QuickSort
    {
        public static void SortTShirts(List<TShirt> tShirts) 
        {
            QuickSortAlternative(tShirts, 0, tShirts.Count - 1);
            
        }
        public static List<TShirt> SortTShirtsDesc(List<TShirt> tShirts)
        {
            QuickSortAlternative(tShirts, 0, tShirts.Count - 1);
            tShirts.Reverse();
            return tShirts;
        }
        private static void Quicksort(List<TShirt> tShirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = tShirts[(left + right) / 2].Size;

            while (i <= j)
            {
                while (tShirts[i].Size < pivot)
                    i++;
                while (tShirts[j].Size > pivot)
                    j--;

                if (i <= j)
                {
                    //Swap
                    var temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                Quicksort(tShirts, left, j);
            if (i < right)
                Quicksort(tShirts, i, right);
        }
        
        private static void QuickSortAlternative(List<TShirt> tShirts, int left, int right) 
        {
            if (left > right)
                return;
            var pivot = (int)tShirts[(left + right) / 2].Size;
            int index = Partition(tShirts, left, right, pivot);
            Quicksort(tShirts, left, index - 1);
            Quicksort(tShirts, index, right);
        }
       
        private static int Partition(List<TShirt> tShirts, int left, int right, int pivot) 
        {
            while (left >= right) 
            {
                while ((int)tShirts[right].Size > pivot) 
                {
                    right--;
                }
                if (left <= right) 
                {
                    var temp = tShirts[left];
                    tShirts[left] = tShirts[right];
                    tShirts[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }

        



    }
}
