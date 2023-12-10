package com.mycompany.programa8u5;
import java.util.Random;
import java.util.Scanner;

public class Programa8U5 {

    public static void main(String[] args) {
          Scanner sc = new Scanner(System.in);

        System.out.print("Ingrese la cantidad de veces que desea lanzar el dado: ");
        int vecesLanzamiento = sc.nextInt();

        System.out.println("Resultados de los lanzamientos:");

        for (int i = 0; i < vecesLanzamiento; i++) {
            int resultado = lanzarDado();
            System.out.println("Lanzamiento " + (i + 1) + ": " + resultado);
        }
    }

    static int lanzarDado() {
        Random random = new Random();
        return random.nextInt(6) + 1;
    }
}
