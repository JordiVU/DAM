package com.dam;
import java.util.Arrays;
import java.util.Scanner;
import com.dam.Clases.VideoGame;
import com.dam.Clases.Company;

public class VideoGameList {
    public static void main(String[] args) {
        VideoGame[] juegos = new VideoGame[5];
        Company[] companys = new Company[3];
        companys[0] = new Company("Activision", 1982);
        companys[1] = new Company("Nintendo", 1920);
        companys[2] = new Company("EA", 2000);

        for(int i = 0; i < juegos.length; i++) {
            juegos[i] = new VideoGame();
            juegos[i].RellenarJuegos(companys);
        }

        MasCaro(juegos);
        MasBarato(juegos);
    }

    //Comparamos para buscar el juego mas caro.
    static void MasCaro(VideoGame[] juegos)
    {
        //Damos a entender que el primer juego es el mas caro y lo guardamos.
        float mayor = juegos[0].getPrecio();
        VideoGame escogido = new VideoGame(juegos[0].getTitulo(),
                juegos[0].getGenero(), juegos[0].getPrecio(), juegos[0].getCompanya());

        //Hacemos un bucle comparando los juegos del array con el mas caro.
        for(int i = 1; i < juegos.length; i++)
        {
            //Si hay un juego mas caro lo sustituimos.
            if(juegos[i].getPrecio() > mayor)
            {
                mayor = juegos[i].getPrecio();
                escogido = new VideoGame(juegos[i].getTitulo(),
                        juegos[i].getGenero(), juegos[i].getPrecio(), juegos[0].getCompanya());
            }
        }

        System.out.println("El juego " + escogido.getTitulo() + " es el mas caro: "
                + escogido.getPrecio() );
    }

    // Comparamos para buscar el juego mas barato.
    static void MasBarato(VideoGame[] juegos)
    {
        //Damos a entender que el primer juego es el mas barato y lo guardamos.
        float menor = juegos[0].getPrecio();
        VideoGame escogido = new VideoGame(juegos[0].getTitulo(),
                juegos[0].getGenero(), juegos[0].getPrecio(), juegos[0].getCompanya());

        //Hacemos un bucle comparando los juegos del array con el mas barato.
        for(int i = 1; i < juegos.length; i++)
        {
            //Si hay un juego mas barato lo sustituimos.
            if(juegos[i].getPrecio() < menor)
            {
                menor = juegos[i].getPrecio();
                escogido = new VideoGame(juegos[i].getTitulo(),
                        juegos[i].getGenero(), juegos[i].getPrecio(), juegos[0].getCompanya());
            }
        }

        System.out.println("El juego " + escogido.getTitulo() + " es el mas barato: "
                + escogido.getPrecio() );
    }
}
