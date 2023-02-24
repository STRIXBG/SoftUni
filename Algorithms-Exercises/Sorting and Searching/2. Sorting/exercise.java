import java.util.Arrays;
import java.util.Scanner;

public class Main {

    static int findIdx(int[] array, int n){
        int idx = -1;
        int low = 0, high = array.length;
        while(low < high){
            int mid = (low+high)/2;
            if(n == array[mid]){
                return mid;
            }
            else if(n > array[mid]){
                low = mid + 1;
            }
            else if(n < array[mid]){
                high = mid - 1;
            }
        }
        return idx;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] input = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int n = scanner.nextInt();
        int idx = findIdx(input, n);
        System.out.println(idx);
    }
}
