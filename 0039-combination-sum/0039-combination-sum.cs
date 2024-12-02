public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        CombinationSumHelper(candidates, 0, target, new List<int>(), result);
        return result;
    }

    public void CombinationSumHelper(int[] candidates, int index, int target, List<int> elements, IList<IList<int>> result) {

        if (target == 0 || index == candidates.Length ) {
            if (target == 0) {
                result.Add(new List<int>(elements));
            }
            return;
        }
        if (candidates[index] <= target) {
            elements.Add(candidates[index]);
            CombinationSumHelper(candidates, index, target-candidates[index], elements, result);
            int size = elements.Count;
            elements.RemoveAt(size-1);
        }
        CombinationSumHelper(candidates, index+1, target, elements, result);
    }
}