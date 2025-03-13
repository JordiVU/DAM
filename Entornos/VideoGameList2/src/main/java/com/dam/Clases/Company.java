package com.dam.Clases;

public class Company {
    String name;
    int anyo;

    public Company() {
    }

    public Company(String name, int anyo) {
        this.name = name;
        this.anyo = anyo;
    }

    public String getName() {
        return name;
    }

    public int getAnyo() {
        return anyo;
    }

    public void setAnyo(int anyo) {
        this.anyo = anyo;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String toString() {
        return "Compañia: " + name + '\'' +
                anyo;
    }
}
