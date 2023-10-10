/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa02;
import java.util.Scanner;


public class Programa02 
{

    public static void main(String[] args) {
	    
	    Scanner f = new Scanner(System.in);
		float x, y, a;
		
		System.out.println("Ingresa el numero 'y': ");
		y = f.nextFloat();
		System.out.println("Ingresa el numero 'a': ");
		a = f.nextFloat();
		x = y + a + 3;
		System.out.println("La suma de los numeros es: "+x);
	}
}
