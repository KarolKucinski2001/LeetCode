using System;

public class Solution {
    public double MyPow(double x, int n) {
        
        // handle special case when n is equal to Int32.MinValue
        if (n == Int32.MinValue) {
            n = -(n + 1);
            x = 1.0 / x;
            return x * x * MyPow(x * x, n / 2);
        }
        
        // base case: if n is 0, return 1
        if (n == 0) {
            return 1.0;
        }
        
        // recursive case: if n is negative, invert x and make n positive
        if (n < 0) {
            x = 1.0 / x;
            n = -n;
        }
        
        // recursive case: if n is even, divide n by 2 and square x
        if (n % 2 == 0) {
            double y = MyPow(x, n / 2);
            return y * y;
        }
        
        // recursive case: if n is odd, subtract 1 from n and recurse
        // using x^2 as base, then multiply by x
        else {
            double y = MyPow(x, (n - 1) / 2);
            return y * y * x;
        }
    }
}