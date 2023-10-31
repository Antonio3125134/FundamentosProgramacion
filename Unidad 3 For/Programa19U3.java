package com.mycompany.programa19u3;
import java.util.Scanner;

public class Programa19U3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Ingresa la cantidad de números: ");
        int Cn = sc.nextInt();
        int Cc = 0;
        int Cmc = 0;
        int Cmec = 0;

        for (int i = 0; i < Cn; i++) {
            System.out.print("Ingresa el número " + (i + 1) + ": ");
            double N = sc.nextDouble();

            if (N == 0) {
                Cc++;
            } else if (N > 0) {
                Cmc++;
            } else {
                Cmec++;
            }
        }
        System.out.println("Cantidad de números iguales a cero: " + Cc);
        System.out.println("Cantidad de números mayores a cero: " + Cmc);
        System.out.println("Cantidad de números menores a cero: " + Cmec);
    }
}