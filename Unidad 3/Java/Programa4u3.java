package com.mycompany.programa4u3;
import java.util.Scanner;

public class programa4u3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner (System.in);
        double p1,p2,p3,total;
       System.out.print("ingresa el valor de p1:"); 
       p1 = sc.nextDouble();
      System.out.print("ingresa el valor de p2:");
      p2 = sc.nextDouble();
      System.out.print("ingresa el valor de p3:");
      p3 = sc.nextDouble();
      total = p1 + p2 + p3;
      if(total<=1500){
          total = total - (total * 0.30); 
          System.out.println("mostrar el total (30% descuento): " + total); 
      }else if (total<1500 && total>=1000){
          System.out.println("el total (20% descuento): " +total);
      } else if (total<1000 && total>=700){
                  total = total -(total * 0.10); 
                  System.out.println("el total (10% descuento): " +total);
                  
      }else {
          System.out.println("el total (sin descuento): " + total);
                  }
      }
       
       
    }

