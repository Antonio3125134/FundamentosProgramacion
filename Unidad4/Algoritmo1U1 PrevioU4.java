package com.mycompany.previou4;

public class PrevioU4 {

    public static void main(String[] args) {
        int[] calificaciones = { 100, 95, 32, 100, 67, 29 };
        int suma = 0;
        int promedio;

        for (int i = 0; i < calificaciones.length; i++) {
            suma = suma + calificaciones[i];
            System.out.println("Calif " + i + " es: " + calificaciones[i]);
        }

        promedio = suma / calificaciones.length;
        System.out.println("El promedio es: " + promedio);
    }
}
