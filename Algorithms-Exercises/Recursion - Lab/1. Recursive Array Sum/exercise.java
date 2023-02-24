import java.util.Arrays;
import java.util.Scanner;

public class Main {
    static int[] input;
    public static int sum(int n, int sum){
        if(n == -1) return sum;
        sum += input[n];
        return sum(n-1, sum);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        input = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int len = input.length-1;
        int result = sum(len, 0);
        System.out.println(result);
    }
}
