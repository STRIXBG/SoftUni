import java.util.*;

public class Main {
    static HashMap<String, Long> phoneBook = new HashMap<>();

    private static void showPhoneAndName(String name) {
        if(phoneBook.containsKey(name)) {
            long phoneNum = phoneBook.get(name);
            System.out.printf("%s -> %d\n", name, phoneNum);
        } else {
            System.out.printf("Contact %s does not exist.\n", name);
        }
    }

    private static void addPhone(String name, long phoneNum) {
        phoneBook.put(name, phoneNum);
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        while(!Objects.equals(input, "search")) {
            String[] line = input.split("-");
            String name = line[0];
            long phoneNum = Long.parseLong(line[1]);
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
