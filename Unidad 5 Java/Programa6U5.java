package com.mycompany.programa6u5;
import java.util.Scanner;

public class Programa6U5 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Ingrese la longitud de la secuencia Fibonacci: ");
        int longitud = sc.nextInt();

        System.out.println("Secuencia Fibonacci:");
        for (int i = 0; i < longitud; i++) {
            System.out.print(fibonacci(i) + " ");
        }
    }

    static int fibonacci(int n) {
        if (n <= 1) {
            return n;
        } else {
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
        

