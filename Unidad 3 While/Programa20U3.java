package com.mycompany.programa20u3;

public class Programa20U3 {
    public static void main(String[] args) {
        int Diasaño = 365;
        double AhorroD = 3.0;
        double AhorroT = 0.0;
        int dia = 1;

        while (dia <= Diasaño) {
            AhorroT += AhorroD;
            System.out.println("Ahorro el día " + dia + ": $" + AhorroD);
            AhorroD *= 3;
            dia++;
        }

        System.out.println("Ahorro total en un año: $" + AhorroT);
    }
}
