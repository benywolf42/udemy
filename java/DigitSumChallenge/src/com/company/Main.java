package com.company;

        public class Main {

            public static void main(String[] args) {
                System.out.println(sumDigits2(14321));
                System.out.println(sumDigits2(-14321));
                System.out.println(sumDigits2(3414321));

            }


    public static int sumDigits2 (int number) {
        if (number < 10){
            return -1;
        }

        int sum = 0;

        while (number > 0){
            int digit = number % 10;
            sum += digit;

            number /= 10;
        }

        return sum;
    }
}
