import java.util.*;

public class Main {

    public static void printResult(List<Integer> seq){
        double sum = sum(seq);
        double average = sum/seq.size();
        System.out.printf("Sum=%.0f; ", sum);
        String strAverage = String.format(Locale.US, "%.2f", average);
        System.out.printf("Average=%s", strAverage);
    }

    public static double sum(List<Integer> seq){
        double sum = 0;
        for (Integer integer : seq) {
            sum += integer;
        }
        return sum;
    }

    public static void main(String[] args) {
        List<Integer> sequence = new ArrayList<>();
        Scanner sc = new Scanner(System.in);
        while(sc.hasNextInt()){
            sequence.add(sc.nextInt());
        }
        printResult(sequence);
    }
}
