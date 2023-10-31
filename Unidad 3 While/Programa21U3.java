package com.mycompany.programa21u3;

import java.util.Scanner;

public class Programa21U3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Ingrese la cantidad de numeros naturales: ");
        int cn = sc.nextInt();

        int i = 1;
        while (i <= cn) {
            System.out.print("Ingrese el numero " + i + ": ");
            int numero = sc.nextInt();

            if (numero > 0) {
                int cubo = numero * numero * numero;
                System.out.println("El cubo de " + numero + " es: " + cubo);
                i++;
            } else {
                System.out.println("Ingrese un numero natural positivo.");
            }
        }
    }
}
