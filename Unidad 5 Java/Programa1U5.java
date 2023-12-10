package com.mycompany.programa1U5;

public class Programa1U5 {

    public static void main(String[] args) {
        System.out.println("Suma ="+suma(7,8));
        System.out.println("Resta ="+resta(7,8));
        System.out.println("Multiplicacion ="+multiplicacion(7,8));
        System.out.println("Divicion ="+divicion(7,8));
    }
    public static int suma(int a, int b){
        int r=a+b;
        return r;
    }
    public static int resta(int a, int b){
        int r=a-b;
        return r;
}
    public static int multiplicacion(int a, int b){
        int r=a*b;
        return r;
}
    public static int division(int a, int b){
        int r=a/b;
        return r;
}
}
