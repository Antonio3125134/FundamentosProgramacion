/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa01;
import java.util.Scanner;

public class Programa01 
{
public static void main(String[] args) {
	    
	    Scanner Cf = new Scanner(System.in);
		float S = 0, P;
		int i = 1;
		
		while (i <= 6){
		    System.out.println("Ingresa la calificación "+i+" : ");
		    float C = Cf.nextFloat();
		    S = S + C;
		    i++;
		}
		P = S / 6;
		System.out.println("El promedio del alumno es: "+P);
	}
}
