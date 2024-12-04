public class Solution {
    public string AddBinary(string a, string b) {
        var carry = 0;
        var stringbuilder = new StringBuilder();
        for(int i = a.Length -1 , j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
        {
            var x = i >= 0 ? a[i] - '0' : 0;
            var y = j >= 0 ? b[j] - '0' : 0;

            var sum = x + y + carry;
            if(sum > 1)
            {
                stringbuilder.Insert(0, sum % 2);
                carry = 1;
            }
            else
            {
                stringbuilder.Insert(0, sum);
                carry = 0;
            }
        }
        if(carry == 1)
            stringbuilder.Insert(0, '1');
        return stringbuilder.ToString();
    }
}