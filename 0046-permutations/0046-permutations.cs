public class Solution {
    public List<IList<int>> output;
 

    public IList<IList<int>> Permute(int[] nums) {
        output = new List<IList<int>>();

        Permutations(nums.ToList(), new List<int>());
        return output;
       
    }

    public void Permutations(List<int> nums, List<int> currentPermutation)
    {

        if (nums.Count==1)
        {
            currentPermutation.Add(nums[0]);
            output.Add(currentPermutation);
            return;
        }
        for(int i =0;i<nums.Count;i++)
        {
            List<int> copyPermutation = new List<int>(currentPermutation);
            List<int> copyNums = new List<int> (nums);

            copyPermutation.Add(nums[i]);
            copyNums.RemoveAt(i);

            Permutations(copyNums, copyPermutation);
        }
    }

}