package com.mycompany.programa25u3;
import java.util.Scanner;

public class Programa25U3 {

    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int n1,n2, R, opcion;

        do{
            System.out.println("Escriba el primer numero: ");
        n1=sc.nextInt();
        System.out.println("Escriba el segundo numero: ");
        n2=sc.nextInt();
        System.out.println("Seleccione una opcion:");
        System.out.println("(1) Suma");
        System.out.println("(2) Resta");
        System.out.println("(3) Multiplicacion");
        System.out.println("(4) Division");
        System.out.println("(5) Salir");
        opcion=sc.nextInt();
              
        switch(opcion){
            case 1:
                R=n1+n2;
                System.out.println("El resultado de la suma es: "+R);
                break;
            case 2:
                R=n1-n2;
                System.out.println("El resultado de la resta es: "+R);
                break;
                case 3:
                R=n1*n2;
                System.out.println("El resultado de la multiplicacion es: "+R);
                break;
            case 4:
                R=n1/n2;
                System.out.println("El resultado de la division es: "+R);
                break;
                case 5:
                    System.out.println("Hasta pronto!");
                System.exit(-1);
                System.out.println("Hasta pronto");
            default:
                System.out.println("No existe esa opcion.");
       
        }
        }while(opcion!=5);
               
    }
}
