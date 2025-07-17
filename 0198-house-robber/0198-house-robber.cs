public class Solution {
    public int Rob(int[] nums) {

        int [] temp = new int[nums.Length];

        if(nums.Length<2)
        {
            return nums[0];
        }

        temp[0]=nums[0];
        temp[1]=Math.Max(nums[0],nums[1]);

        for(int i=2; i<nums.Length;i++)
        {
            temp[i]=Math.Max(temp[i-2]+nums[i],temp[i-1]);
        }

        return temp[nums.Length-1];

    }
}