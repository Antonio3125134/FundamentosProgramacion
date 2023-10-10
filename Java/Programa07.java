
package com.mycompany.programa07;
import java.util.Scanner;
/**
 *
 * @author carlo
 */
public class Programa07
{
	public static void main(String[] args) {
		float S, R, M, D;
		Scanner Op = new Scanner(System.in);
		
		System.out.println("Ingresa el primer numero: ");
		float N1 = Op.nextFloat();
		System.out.println("Ingresa el segundo numero: ");
		float N2 = Op.nextFloat();
		S = N1 + N2;
		R = N1 - N2;
		M = N1 * N2;
		D = N1 / N2;
		System.out.println("La suma de los numeros es: "+S);
		System.out.println("La resta de los numeros es: "+R);
		System.out.println("La multiplicación de los numeros es: "+M);
		System.out.println("La división de los numeros es: "+D);
		
	}
}
