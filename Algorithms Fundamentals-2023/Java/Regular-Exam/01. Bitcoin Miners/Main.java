import java.util.Scanner;

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

public class Main {
    public static void main(String[] args) {
        Solution solution = new Solution();
        Scanner sc = new Scanner(System.in);
        int n_transactions = Integer.parseInt(sc.nextLine());
        int x_transactions = Integer.parseInt(sc.nextLine());
        int result = solution.solve(n_transactions, x_transactions);
        System.out.println(result);
    }
}
