public class Solution {
    public bool IsHappy(int n) {

        if(n==1)
        {
            return true;
        }

        HashSet<int> history = new HashSet<int>();
        int sum =0;
        string nString = n.ToString();

        while(nString.Length!=0)
        {
            foreach(char c in nString)
            {
                sum+= (int)Math.Pow(Convert.ToInt32(c.ToString()),2);
            }
            if(sum==1)
            {
                return true;
            }

            if(!history.Add(sum))
            {
                return false;
            }
            nString=sum.ToString();
            sum=0;
        }
        return false;
        
    }
}