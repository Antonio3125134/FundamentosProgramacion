package com.mycompany.programa9u5;
import java.util.Scanner;

public class Programa9U5 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.print("Ingrese el sueldo diario del trabajador: $");
        double sueldoDiario = sc.nextDouble();

        System.out.print("Ingrese el tiempo laborado (en días): ");
        int tiempoLaborado = sc.nextInt();

        double finiquito = calcularFiniquito(sueldoDiario, tiempoLaborado);

        System.out.println("Finiquito del trabajador: $" + finiquito);
    }

    static double calcularFiniquito(double sueldoDiario, int tiempoLaborado) {
        return sueldoDiario * tiempoLaborado;
    }
}