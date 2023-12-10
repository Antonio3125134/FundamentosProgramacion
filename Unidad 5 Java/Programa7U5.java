package com.mycompany.programa7u5;
import java.util.Scanner;

public class Programa7U5 {

    public static void main(String[] args) {
         Scanner sc = new Scanner(System.in);

        System.out.print("Ingrese el subtotal: ");
        double subtotal = sc.nextDouble();

        System.out.print("Ingrese el IVA : ");
        double tasaIVA = sc.nextDouble();

        double iva = calcularIVA(subtotal, tasaIVA);
        double total = calcularTotal(subtotal, iva);

        System.out.println("Subtotal: " + subtotal);
        System.out.println("IVA: " + iva);
        System.out.println("Total: " + total);
    }

    static double calcularIVA(double subtotal, double tasaIVA) {
        return subtotal * (tasaIVA / 100);
    }

    static double calcularTotal(double subtotal, double iva) {
        return subtotal + iva;
    }
}
