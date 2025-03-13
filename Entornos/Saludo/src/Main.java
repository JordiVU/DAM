//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        System.out.println("Hola");
        Scanner sc = new Scanner(System.in);
        int perros, gatos, pajaros, total, porcentajePerros, porcentajeGatos,
                porcentajePajaros;

        System.out.println("Indica el número de perros:");
        perros = sc.nextInt();
        System.out.println("Indica el número de gatos:");
        gatos = sc.nextInt();
        System.out.println("Indica el número de pajaros:");
        pajaros = sc.nextInt();

        total = perros + gatos + pajaros;
        porcentajePerros = perros * 100 / total;
        porcentajeGatos = gatos * 100 / total;
        porcentajePajaros = pajaros * 100 / total;

        System.out.println("Hay un " + porcentajePerros + "% de perros");
        System.out.println("Hay un " + porcentajeGatos + "% de gatos");
        System.out.println("Hay un " + porcentajePajaros + "% de pagaros");
    }
}