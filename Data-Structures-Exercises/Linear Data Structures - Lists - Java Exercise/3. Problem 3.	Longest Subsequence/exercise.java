import java.util.*;

public class Main {

    public static void longestSub(List<Integer> seq) {
        int[] dp = new int[256];
        int max = 0;
        for (int i = 0; i < seq.size(); i++) {
            int n = seq.get(i);
            if (i == 0) max = n;
            dp[n] += 1;

            //Define Maximum:
            if (dp[max] < dp[n]) max = n;
        }
        for (int i = 0; i < dp[max]; i++) {
            System.out.printf("%d ", max);
        }
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Integer> sequence = new ArrayList<>();
        while (sc.hasNextInt()) {
            sequence.add(sc.nextInt());
        }
        longestSub(sequence);
    }
}
