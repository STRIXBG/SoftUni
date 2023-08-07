import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String line = sc.nextLine();
        String[] elements = line.split(" ");

        int[] array = new int[elements.length];
        for (int i = 0; i < elements.length; i++) {
            array[i] = Integer.parseInt(elements[i]);
        }

        System.out.println(sum(array, 0));
    }

    public static int sum(int[] array, int index) {
        if (index >= array.length) {
            return 0;
        }

        int currentNumber = array[index];
        int sumOfRest = sum(array, index + 1);

        return currentNumber + sumOfRest;
    }
}
