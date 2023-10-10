/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa05;
import java.util.Scanner;

public class Programa05
{
	public static void main(String[] args) {
		Scanner M = new Scanner(System.in);
		double f;
		
		System.out.println("Ingresa los metros a convertir: ");
		double m = M.nextDouble();
		f = m * 3.281;
		System.out.println(m+"m son iguales a: "+f+" ft");
	}
}
