package com.softuni;

import java.util.*;


public class Exercise {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayDeque<Integer> stack = new ArrayDeque<>();
        int lines = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < lines; i++) {
            int[] input = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
            int command = input[0];
            int number = 0;
            if (input.length >= 2) {
                number = input[1];
            }
            switch (command) {
                case 1: {
                    stack.push(number);
                    break;
                }
                case 2: {
                    stack.pop();
                    break;
                }
                case 3: {
                    int biggestNum = 0;
                    for(int num : stack){
                        if(num >= biggestNum) biggestNum=num;
                    }
                    System.out.println(biggestNum);
                    break;
                }
            }
        }
    }
}
