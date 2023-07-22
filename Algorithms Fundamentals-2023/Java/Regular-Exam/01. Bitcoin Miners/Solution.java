public class Solution {
    // x <= n
    // max_transactions > available_transactions
    int solve(int n, int x) {
        if (x == 0 || n == x) {
            return 1;
        }
        if (x > n) {
            return 0;
        }
        return solve(n - 1, x - 1) + solve(n - 1, x);
    }
}
