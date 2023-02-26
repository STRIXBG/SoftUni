import java.util.*;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Stack<Integer> numbers = new Stack<>();
        while(sc.hasNextInt()){
            numbers.push(sc.nextInt());
        }
        printReversed(numbers);
    }

    public static void printReversed(Stack<Integer> st) {
        while(!st.empty()){
            System.out.printf("%d ", st.pop());
        }
    }
}
