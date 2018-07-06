package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println(sumFirstAndLastDigit(864321));
    }

    public static int sumFirstAndLastDigit (int number){
        int lastDigit = number % 10;
        int firstDigit = 0;
        while (number > 0){
            firstDigit = number;
            number /= 10;
        }
        int sum = firstDigit + lastDigit;
        if (sum >= 0) {
            return sum;
        } else {
            return -1;
        }

    }
}
