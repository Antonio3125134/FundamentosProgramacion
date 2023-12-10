package com.mycompany.programa2U5;
import java.util.Scanner;

public class Programa2U5 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int opcion;

        System.out.println("Elige el tipo de conversion a realizar: ");
        System.out.println("1. Temperatura °C a °F");
        System.out.println("2. Temperatura °F a °K");
        System.out.println("3. Medida pulgadas a metros");
        System.out.println("4. Tiempo horas a segundos");

        opcion = scanner.nextInt();

        switch (opcion) {
            case 1:
                double c;
                System.out.print("Escribe los °C a convertir: ");
                c = scanner.nextDouble();
                System.out.println("Tu resultado es: " + temperaturaCF(c));
                break;
            case 2:
                System.out.println("Tu resultado es: " + temperaturaFK());
                break;
            case 3:
                medida();
                break;
            case 4:
                System.out.println(tiempo());
                break;
            default:
                System.out.println("La opción es incorrecta");
                break;
        }
    }

    public static double temperaturaCF(double c) {
        return (c * 1.8) + 32;
    }

    public static double temperaturaFK() {
        double F, resultado;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Escribe la temperatura °F a convertir: ");
        F = scanner.nextDouble();
        resultado = (F - 32) * (5.0 / 9.0) + 273.15;
        return resultado;
    }

    public static void medida() {
        double p, resultado;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Escribe la medida en pulgadas: ");
        p = scanner.nextDouble();
        resultado = p / 39.37;
        System.out.println("Tu resultado es: " + resultado);
    }

    public static double tiempo() {
        double h;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Escribe las horas a convertir: ");
        h = scanner.nextDouble();
        return h * 3600;
    }
}