package com.softuni;

import java.util.*;


public class Exercise {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayDeque<String> urlStack = new ArrayDeque<>();
        String command = scanner.nextLine();
        while(!Objects.equals(command, "Home")){
            if(Objects.equals(command, "back")){
                if(urlStack.size() > 1){
                    System.out.println( urlStack.getLast() ); //urlStack Element
                    urlStack.pop();
                }
                else {
                    System.out.println("no previous URLs");
                }
            }
            else{
                String url = command;
                urlStack.push(url);
                System.out.println(url);
            }
            command = scanner.nextLine();
        }
    }
}
