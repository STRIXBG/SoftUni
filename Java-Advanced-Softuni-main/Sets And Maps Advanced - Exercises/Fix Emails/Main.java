import java.util.*;

public class Main {
    static TreeMap<String, String> emailList = new TreeMap<>();

    private static boolean checkEmail(String email) {
        return !email.toLowerCase().endsWith(".us") && !email.toLowerCase().endsWith(".uk") && !email.toLowerCase().endsWith(".com");
    }

    private static void printEmails() {
        for (Map.Entry<String, String> entry : emailList.entrySet()) {
            if (checkEmail(entry.getKey())) {
                System.out.printf("%s -> %s\n", entry.getValue(), entry.getKey());
            }
        }
    }

    private static void addEmail(String name, String email) {
        emailList.put(name, email);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            String email = scanner.nextLine().trim();
            if (email.equals("stop")) break;
            String name = scanner.nextLine().trim();
            if (name.equals("stop")) break;
            addEmail(name, email);
        }
        printEmails();
    }
}
