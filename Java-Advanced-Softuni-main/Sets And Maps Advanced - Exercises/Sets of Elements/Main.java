import java.util.*;

public class Main {
    static Set<Integer> table1 = new LinkedHashSet<>();
    static Set<Integer> table2 = new LinkedHashSet<>();

    private static void printTable() {
        for (int el_table1 : table1) {
            if (table2.contains(el_table1)) {
                System.out.print(el_table1 + " ");
            }
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int N = scanner.nextInt();
        int M = scanner.nextInt();
        for (int i = 0; i < N; i++) {
            int num = scanner.nextInt();
            table1.add(num);
        }
        for (int j = 0; j < M; j++) {
            int num = scanner.nextInt();
            table2.add(num);
        }
        printTable();
    }
}
