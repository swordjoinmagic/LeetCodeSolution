using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaryAlgorithm.Sort
{
    class BubbleSort {

        /// <summary>
        /// 冒泡排序，每次都将最大/小的那个数交换到最后位置
        /// </summary>
        /// <param name="array">待排序数组</param>
        public void Bubble(int[] array) {

            /*
             * 这里i的意思是第几趟排序,每一趟都会将最大/最小的那个数放到最后
             * 而冒泡排序,数组中有几个元素,就需要有几趟排序才能完成.
             * 同时,j是用来实际交换的,每次j都向j+1的元素询问,查看自己是否可以与他交换
             * 应当注意的是,i是表示目前已经将几个最大/最小的数交换到最后了,所以
             * j应当小于length - i,因为后面没有必要询问交不交换了,他们已经摆好了
             */
            bool isSwap = false;        // 表示这一轮中是否出现交换
            for (int i = 1; i < array.Length; i++) {
                for (int j = 0; j < array.Length - i; j++) {
                    if (array[j] > array[j+1]) {

                        // 交换
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        isSwap = true;
                    }
                }

                // 如果这一轮中没有出现交换,说明已经排序完成
                if (!isSwap) {
                    break;
                }
            }
        }

        public static void Main(string[] args) {
            int[] array = { 32,26,87,72,26,17 };
            new BubbleSort().Bubble(array);
            foreach (int i in array) {
                Console.Write(i+"  ");
            }
        }
    }
}
