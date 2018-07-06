package com.company;

public class Main {

    public static void main(String[] args) {
        int number = 4;
        int finishNumber = 20;
        int evenNumbersFound =0;

        while (number <= finishNumber && evenNumbersFound != 5) {
            number++;
            if (!isEvenNumber(number)){
//                continue;
            } else {
                evenNumbersFound++;
                System.out.println("Even number " + number);
            }
        }
        System.out.println("The total of even numbers found between " + number + " and " + finishNumber
                + " is " + evenNumbersFound);
    }

    public static boolean isEvenNumber (int number) {
        if (number % 2 == 0) {
            return true;
        } else {
            return false;
        }
    }
}
