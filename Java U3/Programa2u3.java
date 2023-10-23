
package com.mycompany.programa2u3;
import java.util.Scanner;

public class programa2u3 {

    public static void main(String[] args) {
         Scanner it = new Scanner (System.in);
        double ca1,cal2,cal3,ca4,cal5,cal6,suma,promedio; 
        System.out.println("ingrese la primera calificacion: ");
        ca1 = it.nextDouble();
        System.out.println("ingrese la segunda calificacion:");
        cal2 = it.nextDouble();
        System.out.println("ingrese la tercera calificacion:");
        cal3 = it.nextDouble();
        System.out.println("ingrese la cuarta calificacion: ");
        ca4 = it.nextDouble();
        System.out.println("ingrese la quinta calificacion:");
        cal5 = it.nextDouble();
        System.out.println("ingrese la sexta calificacion:");
        cal6 = it.nextDouble();
        suma = ca1+cal2+cal3+ca4+cal5+cal6;
        promedio = suma / 6; 
        if (promedio<=70){
        System.out.println("el alumno esta aprobado");
        }else{
        System.out.println("el alumno esta reprobado"); 
                }
    }
}
