public class Solution {
    public int MaxRepeating(string sequence, string word) {
        
        string s = word;
        int counter= 0;

        while(sequence.Contains(s))
        {
            counter++;
            s+=word;
        }

        return counter;
        
    
    }
}