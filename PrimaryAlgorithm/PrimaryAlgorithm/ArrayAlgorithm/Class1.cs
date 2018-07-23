using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaryAlgorithm.ArrayAlgorithm
{
    class Class1
    {

        public static void Main(string[] args) {
            int[] array = { 1,2,3,4,5,6 };
            new Class1().AnotherRotate(array, 2);
            foreach (int i in array) {
                Console.Write(i + "  ");
            }
        }

        public void Rotate(int[] nums, int k) {
            for (int i=0;i<k;i++) {
                for (int j=0;j<nums.Length-1;j++) {
                    Swap(ref nums[j],ref nums[nums.Length-1]);
                }
            }
        }

        public void AnotherRotate(int[] nums, int k) {

            // 要进行交换的元素的下标
            int swapIndex = nums.Length-1;

            for (int i=0;i<nums.Length;i++) {
                Swap(ref nums[nums.Length - 1],ref nums[(swapIndex+k)%nums.Length]);

                swapIndex = (swapIndex + k) % nums.Length;
            }
        }

        public void Swap(ref int a,ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
