public class Solution {
    public int ClimbStairs(int n) {
       if (n <= 0) {
            return 0; // Jeśli n jest mniejsze lub równe 0, zwróć 0
        }
        if (n == 1) {
            return 1; // Tylko jeden sposób na wspięcie się na 1 schodek
        }
        if (n == 2) {
            return 2; // Dwa sposoby na wspięcie się na 2 schodki
        }

        int[] db = new int[n + 1];
        db[1] = 1;
        db[2] = 2;

        for (int i = 3; i <= n; i++) {
            db[i] = db[i - 1] + db[i - 2];
        }
        return db[n];
    }
}