package com.mycompany.programa16u3;
import java.util.Scanner;


public class Programa16U3 {

    public static void main(String[] args) {
         Scanner sc = new Scanner(System.in);
        int c=1,horas,pago,sueldo;
          while (c<=20){
           
        System.out.println("captura las horas trabajadas");
        horas=sc.nextInt();
         System.out.println("captura del pago x hora:");
        pago=sc.nextInt();
         sueldo=horas*pago;
         System.out.println("Tu sueldo es: "+ sueldo);
        c++;
    }
}
}
