public class Solution {
    public bool CanJump(int[] nums) {
        //podejscie zachłanne 
        int goalPos=nums.Length-1;

        for(int i =nums.Length -1;i>=0;i--)
        {
            if(nums[i]+i>=goalPos)
            {
                goalPos=i;
            }
        }
         if(goalPos==0)
         {
            return true;
         } 
         else return false;
    }
}