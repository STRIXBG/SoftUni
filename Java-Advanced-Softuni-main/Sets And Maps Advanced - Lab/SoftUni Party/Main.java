import java.util.*;

public class Main {
    static Stack<String> regularGuests = new Stack<>();
    static Stack<String> vipGuests = new Stack<>();

    private static void printAllGuestsCount() {
        System.out.println(regularGuests.size() + vipGuests.size());
    }

    private static void guestAdd(String code) {
        if (Character.isDigit(code.charAt(0))) {
            vipGuests.add(code);
        } else {
            regularGuests.add(code);
        }
    }

    private static void vipGuestRemove(String code) {
        if (vipGuests.size() != 0) {
            vipGuests.remove(code);
        }
    }

    private static void regularGuestRemove(String code) {
        if (regularGuests.size() != 0) {
            regularGuests.remove(code);
        }
    }

    private static void guestRemove(String code) {
        if (Character.isDigit(code.charAt(0))) {
            vipGuestRemove(code);
        } else {
            regularGuestRemove(code);
        }
    }

    private static void printAllVipGuests() {

        for (String code :
                vipGuests) {
            System.out.println(code);
        }
    }

    private static void printAllRegularGuests() {

        for (String code :
                regularGuests) {
            System.out.println(code);
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        while(!Objects.equals(line, "PARTY")) {
            guestAdd(line);
            line = scanner.nextLine();
        }

        while(!line.equals("END")) {
            guestRemove(line);
            line = scanner.nextLine();
        }

        printAllGuestsCount();
        printAllVipGuests();
        printAllRegularGuests();
    }
}
