package programa66;
import java.util.Scanner;

public class Programa66 {
    
    public static void main(String[] args) {
        menu();
	    double opc = leer();
	    if (opc == 1 )
	    {
	        double a,b,c;
                System.out.println("La formula es: Lado x Lado");
	        System.out.println("Ingresa el primer Lado: ");
	        a=leer();
	        System.out.println("Ingresa el segundo Lado: ");
	        b=leer();
	        c=Acuadrado(a,b);
	        resultado(a,b,c,"x");
	       
	    }
	    
	    if (opc == 2 )
	    {
	        double a,b,c;
                System.out.println("La formula es: Base x Altura");
	        System.out.println("Ingresa la Base: ");
	        a=leer();
	        System.out.println("Ingresa la Altura: ");
	        b=leer();
	        c=Arectangulo(a,b);
	        resultado(a,b,c,"x");
	       
	    }
	    
	    if (opc == 3)
	    {
	        double a,b,c;
                System.out.println("La formula es: Base x Altura / 2");
	        System.out.println("Ingresa la Base: ");
	        a=leer();
	        System.out.println("Ingresa la Altura: ");
	        b=leer();
                
	        c=Atriangulo(a,b);
	        resultado2(a,b,c,"X");
	    }
	    
	    if (opc == 4)
	    {
	        double a,b,c;
	        System.out.println("Ingresa el valor de pi: ");
	        a=leer();
	        System.out.println("Ingresa el radio: ");
	        b=leer();
	        c=Acirculo(a,b);
	        resultado3(a,b,c,"X");
	    }
	    
	    if (opc == 5)
	    {
	        
	        mensajesalir();
	        
	    }
	}
	
	public static void menu()
	{
	    System.out.println("1.Area de un cuadrado ");
	    System.out.println("2.Area de un rectangulo");
	    System.out.println("3.Area de un triangulo");
	    System.out.println("4.Area de un circulo");
	    System.out.println("5.-Salir");
	    System.out.println("Selecciona una opcion:");
	    
	}
	
	public static double leer ()
	{
	   Scanner sc = new Scanner(System.in);
	   double valor;
	   valor = sc.nextDouble();
	   return (valor);
	}
	
	public static void mensaje(String cadena)
	{
	    System.out.println("Introduce el "+cadena+" valor");
	}
	
	public static double Acuadrado(double x, double y)
	{
	        double r;
	        r=x*y;
	        return (r);
	}
	
	public static double Arectangulo(double x, double y)
	{
	        double r;
	        r=x*y;
	        return (r);
	}
	
	public static double Atriangulo (double x, double y)
	{
	        double r;
	        r=x*y/2;
                
	        return (r);
	}
	
	public static double Acirculo (double x, double y)
	{
	        double r;
	        r=x*y*y;
	        return (r);
	}
	
	public static void resultado (double x, double y, double res,String cad)
	{
	    System.out.println(x+cad+y+"="+res);
	}
        
        public static void resultado2 (double x, double y, double res,String cad)
	{
	    System.out.println(x+cad+y+"/2 ="+res);
	}
        
        public static void resultado3 (double x, double y, double res,String cad)
	{
	    System.out.println(x+cad+y+"^2 ="+res);
	}
	
	public static void mensajesalir()
	{
	    System.out.println("Hasta Luego");
	}
	
	
	
	
	
}
