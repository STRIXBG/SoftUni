import java.util.*;

public class Main {
    static Map<Double, Integer> numbersMap = new HashMap<>();

    private static void printMap() {
        for (Map.Entry<Double, Integer> entry : numbersMap.entrySet()) {
            System.out.println(entry.getKey() + " -> " + entry.getValue());
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        String[] numbers = input.split(" ");
        for (String number : numbers) {
            double key = Double.parseDouble(number);
            if (!numbersMap.containsKey(key)) {
                numbersMap.put(key, 1);
            } else {
                int newValue = numbersMap.get(key);
                newValue += 1;
                numbersMap.put(key, newValue);
            }
        }

        printMap();
    }
}
