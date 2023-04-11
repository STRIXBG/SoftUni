import java.util.*;

public class Main {
    static HashMap<String, String> phoneBook = new HashMap<>();

    private static void showPhoneAndName(String name) {
        if(phoneBook.containsKey(name)) {
            String phoneNum = phoneBook.get(name);
            System.out.printf("%s -> %s\n", name, phoneNum);
        } else {
            System.out.printf("Contact %s does not exist.\n", name);
        }
    }

    private static void addPhone(String name, String phoneNum) {
        phoneBook.put(name, phoneNum);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        while(!Objects.equals(input, "search")) {
            String[] line = input.split("-");
            String name = line[0];
            String phoneNum = line[1];
            addPhone(name, phoneNum);
            input = scanner.nextLine();
        }

        input = scanner.nextLine();
        while(!Objects.equals(input, "stop")) {
            String name = input;
            showPhoneAndName(name);
            input = scanner.nextLine();
        }
    }
}
