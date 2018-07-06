package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println(isPalindrome(-8888));
        System.out.println(isPalindrome(-8787));
    }

    public static boolean isPalindrome (int number) {
        int num = number;
        int reverse = 0;
        int lastDigit;

        while (number != 0) {
            lastDigit = number % 10;
            reverse *= 10;
            reverse += lastDigit;
            number /= 10;
        }
        if (reverse == num){
            return true;
        }
        else {
            return false;
        }
    }
}
