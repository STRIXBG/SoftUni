import java.util.*;

public class Main {

    static Map<Character, Integer> charCount = new TreeMap<>();

    private static void printChars() {
        for (Map.Entry<Character, Integer> entry : charCount.entrySet()) {
            System.out.println(entry.getKey() + ": " + entry.getValue() + " time/s");
        }
    }

    private static void addChar(char ch) {
        if (charCount.containsKey(ch)) {
            int currentValue = charCount.get(ch);
            int newValue = currentValue + 1;
            charCount.put(ch, newValue);
        } else {
            charCount.put(ch, 1);
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        for (int i = 0; i < input.length(); i++) {
            addChar(input.charAt(i));
        }
        printChars();
    }
}
