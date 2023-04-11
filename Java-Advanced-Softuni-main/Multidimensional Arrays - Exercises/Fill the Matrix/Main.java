import java.util.*;

public class Main {

    static int[][] matrix = new int[32][32];

    private static void printMatrix(int matrixSize) {
        for (int i = 0; i < matrixSize; i++) {
            for (int j = 0; j < matrixSize; j++) {
                System.out.print(matrix[j][i] + " ");
            }
            System.out.println();
        }
    }

    private static void fillMatrix(int matrixSize, char pattern) {
        int num = 1;
        if (pattern == 'A') {
            for (int i = 0; i < matrixSize; i++) {
                for (int j = 0; j < matrixSize; j++) {
                    matrix[i][j] = num;
                    num++;
                }
            }
        } else if (pattern == 'B') {
            int current = 1;
            for (int i = 0; i < matrixSize; i++) {
                if (i % 2 == 0) {
                    for (int j = 0; j < matrixSize; j++) {
                        matrix[i][j] = current;
                        current++;
                    }
                } else {
                    for (int j = matrixSize - 1; j >= 0; j--) {
                        matrix[i][j] = current;
                        current++;
                    }
                }
            }
        }
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] line = scanner.nextLine().split(", ");
        int size = Integer.parseInt(line[0]);
        char pattern = line[1].charAt(0);
        fillMatrix(size, pattern);
        printMatrix(size);
    }
}
