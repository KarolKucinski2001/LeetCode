public class Solution {
    public int Rob(int[] nums) {
       int [] temp1 = new int[nums.Count()-1];
       int [] temp2 = new int[nums.Count()-1];


       if(nums.Count()<2)
       {
        return nums[0];
       }

        //bez ostatniego elementu
       for(int i =0;i<nums.Count()-1;i++)
       {
        temp1[i]=nums[i];
       }
       //bez pierwszego elementu
       for(int i =1;i<nums.Count();i++)
       {
        temp2[i-1]=nums[i];
       }

       int result =Math.Max(CalculateMaxloot(temp1),CalculateMaxloot(temp2));

       return result;

        
    }

    public int CalculateMaxloot(int [] nums)
    {
         int [] temp = new int [nums.Count()];
        if(nums.Count()<2)
        {
            return nums[0];
        }
        temp[0]=nums[0];
        temp[1]=Math.Max(nums[1], nums[0]);

        for(int i =2;i<nums.Count();i++)
        {
            temp[i]=Math.Max(temp[i-2]+nums[i], temp[i-1]);
        }
        return temp[nums.Count()-1];
    }
}