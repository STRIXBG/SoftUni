import java.util.*;

public class Main {
    static Stack<String> carNumbers = new Stack<>();

    private static void parkCar(String number) {
        carNumbers.add(number);
    }

    private static void removeCar(String number) {
        if (carNumbers.size() != 0) {
            carNumbers.remove(number);
        }
    }

    private static void printAllCarNumbers() {
        if (carNumbers.size() == 0) {
            System.out.println("Parking Lot is Empty");
        } else {
            for (String number :
                    carNumbers) {
                System.out.println(number);
            }
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        while (!line.equals("END")) {
            String[] splitLine = line.split(",");
            String command = splitLine[0];
            String carNumber = splitLine[1];
            if (Objects.equals(command, "IN")) parkCar(carNumber);
            else if (Objects.equals(command, "OUT")) removeCar(carNumber);
            line = scanner.nextLine();
        }
        printAllCarNumbers();
    }
}
