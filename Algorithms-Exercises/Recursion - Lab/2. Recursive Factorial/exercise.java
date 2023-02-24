import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static int factorial(int n, int f){
        if(n <= 0) return f;
        f *= n;
        return factorial(n-1, f);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        System.out.println(factorial(n, 1));
    }
}
