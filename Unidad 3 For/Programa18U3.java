package com.mycompany.programa18u3;
public class Programa18U3 {
    
    public static void main(String[] args) {
        
        double Si = 1500;
        double Ia = 0.10;
        double Sa = Si;

        System.out.println("Salario inicial: $" + Si);

        for (int i = 1; i <= 6; i++) {
            double incremento = Sa * Ia;
            Sa += incremento;

            System.out.println("Salario en el año " + i + ": $" + Sa);
        }

        System.out.println("Salario al cabo de 6 años: $" + Sa);
    }
}
