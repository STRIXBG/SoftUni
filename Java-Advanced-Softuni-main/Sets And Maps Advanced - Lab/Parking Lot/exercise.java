package com.softuni;

import java.util.*;


public class Exercise {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Set<String> parkedCars = new HashSet<>();
        String input = scanner.nextLine();
        while(!Objects.equals(input, "END")){
            String[] inputInfo = input.split(", ");
            String command = inputInfo[0];
            String carNum = inputInfo[1];
            if(Objects.equals(command, "IN")){
                parkedCars.add(carNum);
            }
            else if(Objects.equals(command, "OUT")){
                parkedCars.remove(carNum);
            }
            input = scanner.nextLine();
        }
        if(!parkedCars.isEmpty()) {
            for (String value : parkedCars) {
                System.out.println(value);
            }
        }
        else{
            System.out.println("Parking Lot is Empty");
        }
    }
}
