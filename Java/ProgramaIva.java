

package com.mycompany.programaiva;
import java.util.Scanner;
/**
 *
 * @author LaboratorioLTI2
 */
public class ProgramaIva {

    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        double p1, p2, p3, subtotal, total, ivaT;
        final double iva=0.16;
        System.out.println("Ingrese el precio del primer producto: "); //3
        p1 = sc.nextDouble(); //4
        System.out.println("Ingrese el precio del segundo producto: "); //3
        p2 = sc.nextDouble(); //4
        System.out.println("Ingrese el precio del tercer producto: "); //3
        p3 = sc.nextDouble();//4
        total = p1+p2+p3; //5a
        ivaT = total*iva; //5b
        subtotal = total-ivaT; //5c
        System.out.println("El total es: "+total); //6
        System.out.println("El Iva total es: "+ivaT); //6
        System.out.println("El subtotal es: "+subtotal); //6
        
    }
}
