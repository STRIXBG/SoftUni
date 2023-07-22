import java.util.Scanner;

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
