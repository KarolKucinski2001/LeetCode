public class Solution {
    public IList<int> GetRow(int rowIndex) {
         
        List<int> row = new List<int>{1};

        for(int i =1; i<=rowIndex;i++)
        {
            for(int j= row.Count-1;j>=1;j--)
            {
                row[j]=row[j]+row[j-1];
            }
            row.Add(1);

        }
        return row;
     
    }
}