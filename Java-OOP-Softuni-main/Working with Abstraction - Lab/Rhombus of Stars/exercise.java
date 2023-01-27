package com.softuni;

import java.util.Scanner;

class Rhombus {
    public void printRow(int n) {
        int actualN = n-1;
        int starsToPrint = 1;
        StringBuilder row = new StringBuilder();
        for(int i=0; i<actualN; i++){ // Up
            row.setLength(0);
            //Spaces - open
            int spacesCount = (n-i)-1;
            for(int j=0; j<spacesCount; j++) row.append(' ');
            //Spaces - close
            for (int j = 0; j < starsToPrint; j++) row.append('*').append(' ');
            System.out.println(row);
            starsToPrint+=1;
        }
        row.setLength(0);
        for (int i = 0; i < n; i++) row.append('*').append(' '); // Middle
        System.out.println(row);
        row.setLength(0);
        for(int i=0; i<actualN; i++){ // Down
            row.setLength(0);
            //Spaces - open
            int spacesCount = i+1;
            for(int j=0; j<spacesCount; j++) row.append(' ');
            //Spaces - close
            for (int j = 0; j < starsToPrint-1; j++) row.append('*').append(' ');
            System.out.println(row);
            starsToPrint-=1;
        }
    }
}

public class Exercise {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();
        Rhombus myRhombus = new Rhombus();
        myRhombus.printRow(number);
    }
}
