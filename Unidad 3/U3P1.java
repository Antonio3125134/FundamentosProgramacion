package com.mycompany.u3p1;
import java.util.Scanner;
public class U3P1 {

    public static void main(String[] args) { //1
        Scanner sc = new Scanner(System.in);//1
        int edad; //2
        System.out.println("Escribe tu edad: "); //3
        edad=sc.nextInt(); //4
        if (edad>=18) //5
            System.out.println("Eres mayor de edad!!"); //5a
        else
            System.out.println("Eres menor de edad");
    } //6
} //6
