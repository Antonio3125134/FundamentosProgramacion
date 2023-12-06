package com.mycompany.programa10u5;
import java.util.Random;

public class Programa10U5 {

    public static void main(String[] args) {
        int longitud=8;
        String contrasena = aleatorio(longitud);
        System.out.println("Password: "+contrasena);
        
    }
    public static String aleatorio(int longitud){
        //declarar los caracteres permitidos
        String caracteres = "ABCDEFghijkl0123456789*-_.";
        Random random = new Random();//Sirve para generar numero
        //Costruir caracteres
        StringBuilder cadena = new StringBuilder(longitud);
        for(int i=0; i < longitud; i++){
            int indiceCaracter = random.nextInt(caracteres.length());
            cadena.append(caracteres.charAt(indiceCaracter));
        }
        return cadena.toString();
    }
}
