using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhan
{
    class Program
    {
        public static int BinarySearch(int[] arr, int target) // arr=8; target=9
        {
            int left = 0; //left =4 
            int right = arr.Length - 1;//right = 8-1=7

            while (left <= right)//left=4 <= right =4 true
            {
                int mid = left + (right - left) / 2; //mid = left(4) +(right(4)- 4)/2 =4 

                if (arr[mid] == target)//mid =4 target=9 =>true arr[mid(4)]=9  
                {
                    return mid;//mid =4 => dung vong lap
                }
                else if (arr[mid] < target) //true
                {
                    left = mid + 1; //left(4) = mid(5)+ 1=6=>left=6
                }
                else
                {
                    right = mid - 1;//right = mid(5)-1 =4
                }
            }

            return -1; // Không tìm thấy target
        }
        static void Main(string[] args)
        {
            Console.WriteLine("So Phan Tu trong mang: 1, 3, 5, 7, 9, 11, 13, 15");
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
            Console.Write("Nhap Phan tu can tim : ");
            string input = Console.ReadLine();
            int target =Convert.ToInt32(input);

            int index = BinarySearch(numbers, target);

            if (index == -1)//ket thuc vong lap neu bang -1 thi suy ra ket luan 
            {
                 Console.WriteLine("Khong tim thay {0} trong mang.",target);
            }
            else
            {
                 Console.WriteLine("{0} đuoc tim thay tai Vi tri {1}.",target,index); // in ra ket qua arr[mid] vs mid 
            }
            Console.ReadKey();
        }
    }
}
