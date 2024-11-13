public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> symbolValues = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int result = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int currentValue = symbolValues[s[i]];

            // If the current value is less than the previous value, we subtract it (e.g., IV = 5 - 1 = 4)
            if (currentValue < prevValue)
                result -= currentValue;
            else //otherwise we add it
                result += currentValue;

            //update previuous value for further iteration
            prevValue = currentValue;
        }
        return result;
    }
}