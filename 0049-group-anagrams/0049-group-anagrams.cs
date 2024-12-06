public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            // sort str in alphabetical order
            var sortedStr = string.Concat(str.OrderBy(c => c));
            if (!groups.ContainsKey(sortedStr))
            {
                groups[sortedStr] = new List<string>();
            }

            groups[sortedStr].Add(str);
        }

        return groups.Values.ToList();
    }
}