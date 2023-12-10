package com.mycompany.programa5u5;
import java.util.Scanner;

public class Programa5U5 {

    public static void main(String[] args) {
  
 Scanner sc = new Scanner(System.in);
        System.out.print("Ingrese una frase para contar las palabras: ");
        String frase = sc.nextLine();

        int cantidadPalabras = contarPalabras(frase);
        System.out.println("Número de palabras: " + cantidadPalabras);
    }

    static int contarPalabras(String cadena) {
        if (cadena == null || cadena.isEmpty()) {
            return 0;
        }

        String[] palabras = cadena.split("\\s+");
        return palabras.length;
    }
}