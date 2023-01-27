package com.softuni;

import java.util.*;


public class Exercise {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayDeque<Integer> stack = new ArrayDeque<>();
        int[] input = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int numToPush = input[0];
        int numToPop = input[1];
        int numToCheck = input[2];
        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        for (int i = 0; i < numToPush; i++) {
            stack.push(numbers[i]);
        }
        for (int i = 0; i < numToPop; i++) {
            stack.pop();
        }
        boolean foundNum = false;
        for (int num : stack) {
            if (num == numToCheck) {
                System.out.println("true");
                foundNum = true;
                break;
            }
        }
        if (foundNum == false) {
            if (stack.isEmpty() == false) {
                Arrays.sort(stack.toArray());
                System.out.println(stack.getFirst());
            } else {
                System.out.println("0");
            }
        }
    }
}
