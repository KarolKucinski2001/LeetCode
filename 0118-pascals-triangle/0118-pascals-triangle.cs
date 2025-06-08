public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> pascalList = new List<IList<int>>();

        pascalList.Add(new List<int>{1});

        if(numRows==1)
        {
            return pascalList;
        }
        pascalList.Add(new List<int>{1,1});

        if(numRows==2)
        {
            return pascalList;
        }
        for(int i =2;i<numRows;i++)
        {
            var prev = pascalList.Last();
            var newList = new List<int>();
            
            newList.Add(1);

            //calculation based on previous list
            var nums = calculateNumbers(prev);
            newList.AddRange(nums);
            newList.Add(1);
            pascalList.Add(newList);

        }
        return pascalList;
    }

    IList<int> calculateNumbers(IList<int> list)
    {
        var returnList = new List<int>();
        for(int firstIndex=0, secondIndex=1;
        secondIndex<list.Count();
        secondIndex++,firstIndex++)
        {
            returnList.Add(list[firstIndex]+ list[secondIndex]);
        }
        return returnList;
    }
}