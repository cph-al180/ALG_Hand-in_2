using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublingTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Starting..");
            SortService sortService = new SortService();
            SortRunner sortRunner = new SortRunner(sortService);

            sortRunner.RunInsertionSort(10000, 100);
            sortRunner.RunInsertionSort(20000, 100);
            sortRunner.RunInsertionSort(40000, 100);
            sortRunner.RunInsertionSort(80000, 100);
            sortRunner.RunInsertionSort(160000, 100);

            sortRunner.RunSelectionSort(10000, 100);
            sortRunner.RunSelectionSort(20000, 100);
            sortRunner.RunSelectionSort(40000, 100);
            sortRunner.RunSelectionSort(80000, 100);
            sortRunner.RunSelectionSort(160000, 100);

            sortRunner.RunMergeSort(10000, 100);
            sortRunner.RunMergeSort(20000, 100);
            sortRunner.RunMergeSort(40000, 100);
            sortRunner.RunMergeSort(80000, 100);
            sortRunner.RunMergeSort(160000, 100);

        }
    }
}

