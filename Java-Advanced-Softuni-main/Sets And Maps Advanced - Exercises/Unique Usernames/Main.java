import java.util.*;

public class Main {
    static Set<String> usernames = new LinkedHashSet<>();

    private static void printUsernames() {
        for (String user : usernames) {
            System.out.println(user);
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int lines = scanner.nextInt();
        scanner.nextLine(); //clears buffer
        for (int i = 0; i < lines; i++) {
            String username = scanner.nextLine();
            usernames.add(username);
        }
        printUsernames();
    }
}
