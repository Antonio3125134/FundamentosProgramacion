/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa2;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class Programa2 { //PASO 1

    public static void main(String[] args) { //PASO 1
        Scanner sc=new Scanner(System.in); //PASO 1
        int a, b, suma; //PASO 2-Declarar variables
        System.out.println("Escribe un número A: "); //PASO 3
        a = sc.nextInt(); //PASO 4-Asignar Valor
        System.out.println("Escribe un número B: "); //PASO 3
        b = sc.nextInt(); //PASO 4-Asignar Valor
        suma=a+b;
        System.out.println("Resultado: "+suma);
    }
}
