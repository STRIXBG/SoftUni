package com.softuni;

import java.util.*;


public class Exercise {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayDeque<Integer> reversedNums = new ArrayDeque<>();
        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        for(int num : numbers){
            reversedNums.push(num);
        }
        while(reversedNums.size() > 0) {
            int num = reversedNums.pop();
            System.out.print(num + " ");
        }
    }
}
