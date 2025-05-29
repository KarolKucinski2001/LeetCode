public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums.Length <= 2) return result;

        Array.Sort(nums);

        int start = 0;
        while (start < nums.Length - 2) {
            int target = -nums[start];
            int left = start + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[left] + nums[right];
                if (sum < target) {
                    left++;
                } else if (sum > target) {
                    right--;
                } else {
                    result.Add(new List<int> { nums[start], nums[left], nums[right] });

                    // Unikamy duplikatów
                    int leftVal = nums[left];
                    int rightVal = nums[right];
                    while (left < right && nums[left] == leftVal) left++;
                    while (left < right && nums[right] == rightVal) right--;
                }
            }

            // Przesuwamy start na inną wartość, aby uniknąć duplikatów
            int currentStartNumber = nums[start];
            while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                start++;
        }

        return result;
    }
}
