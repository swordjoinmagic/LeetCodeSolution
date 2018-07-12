using System;

/// <summary>
/// 
/// 初级算法入门之数组：
/// <para>=================================</para>
/// ●从排序数组中删除重复项
/// 说明：
/// 给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
/// 不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。
/// <para>=================================</para>
/// </summary>
class Array1 {

    public static void Main(string[] args) {
        int[] nums = { 1,2 };
        int result = new Array1().SloveWithContinuousDeletion(nums);
        Console.WriteLine(result);
    }

    /// <summary>
    /// 方法三:
    ///     利用被删除数组已排序的特性,
    ///     每次都能找到一串相同的数字,
    ///     使用连续删除的方法删除这些数字
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SloveWithContinuousDeletion(int[] nums) {

        int length = nums.Length;
        int i = 0;

        while (i<length) {

            int temp = nums[i];

            // 向后面寻找跟temp相同的有几个
            int sameNumber = 0;     // 相同数量
            for (int j=i+1;j<length && nums[j]==temp;j++) {
                sameNumber++;
            }

            // 删除掉这些相同的
            DeleteNumElement(nums,i+1,length,sameNumber);

            length -= sameNumber;

            i++;
        }

        return length;
    }

    /// <summary>
    /// 方法二:
    ///     利用被删除的数组已排序的特性,
    ///     每次都询问旁边的元素是否跟自己相同,
    ///     相同的话,删除掉旁边的元素,
    ///     将一开始穷举的O(n2)时间复杂度降为O(N)
    /// </summary>
    /// <returns></returns>
    public int SloveWithBySortFeature(int[] nums) {

        int lenght = nums.Length;

        for (int i=0;i<lenght-1;i++) {
            if (nums[i]==nums[i+1]) {
                DeleteNumElement(nums,i+1,lenght);

                // 数组长度减少
                lenght--;

                // 重新检查下标为i的元素跟i+1是否相同
                i--;
            }
        }

        return lenght;
    }

    /// <summary>
    /// 方法一:
    ///     暴力穷举该数组,每次都往后面删掉跟自己相同的元素.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SloveWithExhaustion(int[] nums) {

        int length = nums.Length;

        for (int i=0;i<length;i++) {

            // 保存当前数
            int temp = nums[i];

            for (int j=i+1;j<length;j++) {
                // 如果后面有数跟temp相同,删除该数
                if (nums[j]==temp) {
                    DeleteNumElement(nums,j,length);

                    // 数组长度-1
                    length--;

                    // 重新检查这个在新位置的数是不是跟temp相同
                    j--;
                }
            }
        }
        return length;
    }
    /// <summary>
    /// 删除数组元素的方法,删掉下标为index的元素,length:为当前数组长度
    /// </summary>
    public void DeleteNumElement(int[] nums,int index,int length) {
        for (int i=index;i<length-1;i++) {
            // 下标为index的元素被删除,每一个元素前移一位
            nums[i] = nums[i + 1];
        }
    }

    /// <summary>
    /// 删除掉数组中从下标index开始,知道index+l-1位置的元素,也就是,如果
    /// l=1,那么就是删除掉下标为index的元素,如果l=2,那么就是删除掉下标为index,index+1的元素
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="index"></param>
    /// <param name="conlen"></param>
    public void DeleteNumElement(int[] nums,int index,int length,int conlen) {
        if (conlen == 0) return;
        for (int i=index;i<length-conlen;i+=conlen) {
            for (int j = 0; j < conlen && i + conlen + j<length; j++) {
                nums[i + j] = nums[i + conlen + j];
            }
        }
    }

    public int RemoveDuplicates(int[] nums) {
        return SloveWithContinuousDeletion(nums);
    }
}