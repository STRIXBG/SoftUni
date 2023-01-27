package com.softuni;

import java.util.*;


public class Exercise {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        boolean correct = true;
        ArrayDeque<Character> stack = new ArrayDeque<>();
        String line = scanner.nextLine();
        for (int i = 0; i < line.length(); i++) {
            //Add
            char el = line.charAt(i);
            if(el == '(') {
                stack.push(el); //stack.add(el)
            }
            else if(el == '['){
                stack.push(el);
            }
            else if(el == '{'){
                stack.push(el);
            }
            //Pop
            else if(el == ')') {
                char brack = stack.pop();
                if(brack != '('){
                    correct = false;
                }
            }
            else if(el == ']') {
                char brack = stack.pop();
                if(brack != '['){
                    correct = false;
                }
            }
            else if(el == '}') {
                char brack = stack.pop();
                if(brack != '{'){
                    correct = false;
                }
            }
        }
        if(correct){
            System.out.println("YES");
            //System.out.println(stack);
        }
        else{
            System.out.println("NO");
            //System.out.println(stack);
        }
    }
}
