public class Solution {
    public int IncremovableSubarrayCount(int[] nums) {
    int l = 0, lenn = 1,count=0;
    while (l<nums.Length)
    {
        if (IsIncreasing(RemoveSubArray(nums, l, lenn)))
        {
            count++;
        }
        lenn++;
        if(lenn>nums.Length-l) {
            l++;
            lenn = 1;
        }
    }
    return count;
}
public static int[] RemoveSubArray(int[] array, int startIndex, int length)
{
    int[] newArray = new int[array.Length - length];
    Array.Copy(array, 0, newArray, 0, startIndex);
    Array.Copy(array, startIndex + length, newArray, startIndex, array.Length - startIndex - length);
    return newArray;
}
public static bool IsIncreasing(int[] array)
{
    if (array.Length <= 1)
    {
        return true;
    }
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] <= array[i - 1])
        {
            return false;
        }
    }
    return true;
}
}