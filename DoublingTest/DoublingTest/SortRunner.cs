using System;

namespace DoublingTest
{
    public class SortRunner
    {
        public SortService sortService;
        
        public SortRunner(SortService sorter)
        {
            this.sortService = sorter;
        }

        public void RunInsertionSort(int size, int nTimes)
        {
            long sum = 0;
            double result;

            for (int i = 0; i < nTimes; i++)
            {
                sortService.FillWithRandomIntegers(size);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Console.WriteLine("1");
                sortService.InsertionSort();
                Console.WriteLine("2");
                watch.Stop();
                sum += watch.ElapsedMilliseconds;
            }

            result = sum / nTimes;

            Console.WriteLine("Insertion Sort (" + size + "): " + sum / nTimes + " ms");
        }

        public void RunSelectionSort(int size, int nTimes)
        {
            long sum = 0;
            double result;

            for (int i = 0; i < nTimes; i++)
            {
                sortService.FillWithRandomIntegers(size);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                sortService.SelectionSort();
                watch.Stop();
                sum += watch.ElapsedMilliseconds;
            }

            result = sum / nTimes;

            Console.WriteLine("Selection Sort (" + size + "): " + result + " ms");
        }

        public void RunMergeSort(int size, int nTimes)
        {
            long sum = 0;
            double result;

            for (int i = 0; i < nTimes; i++)
            {
                sortService.FillWithRandomIntegers(size);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                sortService.PerformMergeSort();
                watch.Stop();
                sum += watch.ElapsedMilliseconds; ;
            }

            result = sum / nTimes;

            Console.WriteLine("Merge Sort (" + size + "): " + result + " ms");
        }

    }
}
