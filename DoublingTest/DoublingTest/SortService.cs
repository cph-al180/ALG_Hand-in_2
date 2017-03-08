using System;

namespace DoublingTest
{
    public class SortService
    {
        private int size;
        private int maxSize = 1000;
        private int[] list;
        private int[] helpList;

        public void FillWithRandomIntegers(int size)
        {
            this.size = size;
            this.list = new int[size];
            Random random = new Random();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = random.Next(maxSize);
            }
        }

        public void InsertionSort()
        {
            for (int i = 0; i < size - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < size; j++)
                    if (list[j] < list[index])
                        index = j;

                int smallerNumber = list[index];
                list[index] = list[i];
                list[i] = smallerNumber;
            }
        }

        public void SelectionSort()
        {
            for (int i = 0; i < size - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < size; j++)
                    if (list[j] < list[index])
                        index = j;

                int smallerNumber = list[index];
                list[index] = list[i];
                list[i] = smallerNumber;
            }
        }

        public void PerformMergeSort()
        {
            this.helpList = new int[size];
            MergeSort(0, size - 1);
        }

        private void MergeSort(int low, int high)
        {
            if (low < high)
            {
                int middle = low + (high - low) / 2;
                MergeSort(low, middle);
                MergeSort(middle + 1, high);
                Merge(low, middle, high);
            }
        }

        private void Merge(int low, int mid, int high)
        {
            for (int i = low; i <= high; i++)
            {
                helpList[i] = list[i];
            }

            int j = low;
            int k = mid + 1;
            int l = low;

            while (j <= mid && k <= high)
            {
                if (helpList[j] <= helpList[k])
                {
                    list[l] = helpList[j];
                    j++;
                }
                else
                {
                    list[l] = helpList[k];
                    k++;
                }
                l++;
            }
            while (j <= mid)
            {
                list[l] = helpList[j];
                l++;
                j++;
            }
        }

    }
}
