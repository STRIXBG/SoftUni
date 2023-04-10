import java.util.*;

public class Main {

    static Set<String> table = new TreeSet<>();

    private static void printTable() {
        for (String element : table) {
            System.out.print(element + " ");
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int lines = scanner.nextInt();
        scanner.nextLine();
        for (int i = 0; i < lines; i++) {
            String input = scanner.nextLine();
            String[] words = input.split(" ");
            Collections.addAll(table, words);
        }
        printTable();
    }
}
