public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var returnList = new List<IList<int>>();
        Array.Sort(nums);
        Backtrack(nums, new List<int>(nums.Length), returnList, new HashSet<int>(nums.Length));
        return returnList;
    }

    private static void Backtrack(int[] nums, IList<int> permutation, IList<IList<int>> returnList, HashSet<int> usedIndices)
    {
        if (permutation.Count == nums.Length)
        {
            returnList.Add(new List<int>(permutation));
            return;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (!usedIndices.Add(i))
            {
                continue;
            }

            permutation.Add(nums[i]);
            Backtrack(nums, permutation, returnList, usedIndices);
            permutation.RemoveAt(permutation.Count-1);
            usedIndices.Remove(i);

            while (i < nums.Length-1 && nums[i] == nums[i+1])
            {
                i++;
            }
        }
    }
}