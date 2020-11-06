using AssignmentBrief4.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBrief4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            MyDatabase db = new MyDatabase();

            var myList = new List<TShirt>(db.TShirts);

            Console.WriteLine("Unsorted list: \n");

            foreach (var item in myList) 
            {
                item.Output();
            }


            #region QUICK SORT
            //Ascending Size
            watch.Restart();
            QuickSort.SortTShirts(myList);
            Console.WriteLine("\nSorted List with Quick Sort Size Ascending: \n");
            foreach (var item in myList)
            {
                item.Output();
            }

            watch.Stop();
            Console.WriteLine("Time: {0:F3}", watch.ElapsedMilliseconds);

            //Descending Size
            watch.Restart();
            QuickSort.SortTShirtsDesc(myList);
            Console.WriteLine("\nSorted List with Quick Sort Size Descending \n");
            foreach (var item in myList)
            {
                item.Output();
            }

            watch.Stop();
            Console.WriteLine("Time: {0:F3}", watch.ElapsedMilliseconds);
            #endregion

            #region BUBBLE SORT
            //Ascending Color 
            watch.Restart();
            BubbleSort.SortTShirtsColor(myList);
            Console.WriteLine("\nSorted List with Bubble Sort Color Asc: \n");
            foreach (var item in myList)
            {
                item.Output();
            }
            
            watch.Stop();
            Console.WriteLine("Time: {0:F3}", watch.ElapsedMilliseconds);

            //Descending Color
            watch.Restart();
            BubbleSort.SortTShirtsColorDesc(myList);
            Console.WriteLine("\nSorted List with Bubble Sort Color Desc: \n");
            foreach (var item in myList)
            {
                item.Output();
            }

            watch.Stop();
            Console.WriteLine("Time: {0:F3}", watch.ElapsedMilliseconds);
            #endregion

            #region BUCKET SORT
            //Ascending Fabric
            watch.Restart();
            var sortedListBucket = BucketSort.SortTShirtsFabric(myList);
            Console.WriteLine("\nSorted List with Bucket Sort Fabric Asc: \n");
            foreach (var item in sortedListBucket)
            {
                item.Output();
            }

            watch.Stop();
            Console.WriteLine("Time: {0:F3}", watch.ElapsedMilliseconds);

            //Descending Fabric
            watch.Restart();
            var sortedListBucketDesc = BucketSort.SortTShirtsFabricDesc(myList);
            sortedListBucket.Reverse();
            Console.WriteLine("\nSorted List with Bucket Sort Fabric Desc: \n");
            foreach (var item in sortedListBucket)
            {
                item.Output();
            }

            watch.Stop();
            Console.WriteLine("Time: {0:F3}", watch.ElapsedMilliseconds);
            #endregion

            #region SORT BY MULTIPLE CRITERIA
            //Ascending
            IEnumerable<TShirt> tShirts = db.TShirts
                .OrderBy(t => t.Size)
                .ThenBy(t => t.Color)
                .ThenBy(t => t.Fabric);
              
            Console.WriteLine("\nSorted List by Size and Color and Fabric Asc: \n");
            foreach (var item in tShirts)
            {
                item.Output();
            }

            //Descending
            IEnumerable<TShirt> tShirts2 = db.TShirts
              .OrderByDescending(t => t.Size)
              .ThenByDescending(t => t.Color)
              .ThenByDescending(t => t.Fabric);
              
            Console.WriteLine("\nSorted List by Size and Color and Fabric Desc: \n");
            foreach (var item in tShirts2)
            {
                item.Output();
            }
            #endregion
        }
    }
}
