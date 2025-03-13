package com.dam;

import java.util.Scanner;

public class VideoGame {
    String titulo;
    String genero;
    float precio;

    public VideoGame() {
    }

    public VideoGame(String titulo, String genero, float precio) {
        this.titulo = titulo;
        this.genero = genero;
        this.precio = precio;
    }

    // Funcion para que el usuario rellene el array de VideoGame
    public void RellenarJuegos()
    {
        Scanner sc = new Scanner(System.in);
        String titulo = null, genero = null;
        float precio = 0;
        boolean correcto = false;

        do {
            try {
                System.out.println("Nombre:");
                titulo = sc.nextLine();

                System.out.println("Genero:");
                genero = sc.nextLine();

                System.out.println("Precio:");
                precio = sc.nextFloat();
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
