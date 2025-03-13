package com.dam.Clases;

import java.util.Scanner;
import com.dam.Clases.Company;

public class VideoGame {
    String titulo;
    String genero;
    float precio;
    Company companya;

    public VideoGame() {
    }

    public VideoGame(String titulo, String genero, float precio, Company companya) {
        this.titulo = titulo;
        this.genero = genero;
        this.precio = precio;
        this.companya = companya;
    }

    // Funcion para que el usuario rellene el array de VideoGame
    public void RellenarJuegos(Company[] companys)
    {
        Scanner sc = new Scanner(System.in);
        String titulo = null, genero = null;
        int elegido = 0;
        float precio = 0;
        boolean correcto = false;

        do {
            try {
                System.out.print("Nombre:");
                titulo = sc.nextLine();

                System.out.print("Genero:");
                genero = sc.nextLine();

                System.out.print("Precio:");
                precio = sc.nextFloat();

                System.out.println("Elige compañia con su numero:");
                for(int i = 0; i < companys.length; i++)
                {
                    System.out.println(i + 1 + ". " + companys[i]);
                }
                elegido = sc.nextInt();

            } catch (NumberFormatException num) {
                System.out.println("ERROR: Formato de precio incorrecto");
                correcto = true;
            } catch (Exception e) {
                System.out.println("ERROR TERROR.");
                correcto = true;
            }
        }
        while (correcto);

        //Añadir la informacion que rellena el usuario al array de VideoGame
        this.setTitulo(titulo);
        this.setGenero(genero);
        this.setPrecio(precio);
        this.setCompanya(companys[elegido - 1]);
    }

    public String getTitulo() {
        return titulo;
    }

    public String getGenero() {
        return genero;
    }

    public float getPrecio() {
        return precio;
    }

    public Company getCompanya() {
        return companya;
    }

    public void setCompanya(Company companya) {
        this.companya = companya;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public void setPrecio(float precio) {
        this.precio = precio;
    }

    @Override
    public String toString() {
        return "VideoGame{" +
                "titulo='" + titulo + '\'' +
                ", genero='" + genero + '\'' +
                ", precio=" + precio +
                '}';
    }
}
