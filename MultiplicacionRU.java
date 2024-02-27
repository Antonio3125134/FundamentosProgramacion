package com.mycompany.multiplicacionru;
import java.util.Scanner;

public class MultiplicacionRU {

    public static void main(String[] args) {
                System.out.println("Ingrese el multiplicador");
                a =leer();
	        System.out.println("Ingrese el multiplicando");
	        b =leer();
                System.out.println("El resultado es: ");
                
	        
	        
    }
    public static int leer ()
	{
	   Scanner sc = new Scanner(System.in);
	   int valor;
	   valor = sc.nextInt();
	   return (valor);
	}
    
    
    public static int multiplicador(int a, int b, int r, int rm)
	{
                while (r <=0){
	        r=b/2;
                rm=a*2;
                r++;
                }
	        return (r);
                
	}
    
    public static void resultado()
	{
	    System.out.println("el resultado es: ");
	    
	    
	}
}
