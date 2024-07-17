using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        public static void MergeSort(int[] arr)
        {
            if (arr.Length > 1)
            {
                int mid = arr.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[arr.Length - mid];

                // Chia mảng ra thành 2 nửa
                for (int i = 0; i < mid; i++)
                    left[i] = arr[i];
                for (int i = mid; i < arr.Length; i++)
                    right[i - mid] = arr[i];

                // Đệ quy sắp xếp 2 nửa
                MergeSort(left);
                MergeSort(right);

                // Trộn 2 nửa đã sắp xếp
                Merge(arr, left, right);
            }
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            // Trộn 2 mảng con cho đến khi hoàn thành
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            // Thêm phần tử còn lại (nếu có) của mảng con
            while (i < left.Length)
                arr[k++] = left[i++];
            while (j < right.Length)
                arr[k++] = right[j++];
        }
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 7, 3, 8, 4 };
            Console.WriteLine("Cac phan tu trong mang la : 5, 2, 9, 1, 7, 3, 8, 4 ");
            MergeSort(numbers);
            Console.Write("Cac phan tu trong mang sau khi sap xep : ");
            Console.WriteLine(string.Join(", ", numbers)); // Kết quả: 1, 2, 3, 4, 5, 7, 8, 9
            Console.ReadKey();
        }
    }
}
