
import java.util.Scanner;
import java.util.ArrayList;
import java.util.Collections;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        ArrayList<Integer> pares = new ArrayList<>();
        ArrayList<Integer> impares = new ArrayList<>();

        int numbers = scanner.nextInt();

        for (int i = 0; i < numbers; i++)
        {
            int number = scanner.nextInt();

            distributeNumbers(number, pares, impares);
        }

        Collections.sort(pares);
        Collections.sort(impares, Collections.reverseOrder());

        printArrays(pares);
        printArrays(impares);

        scanner.close();
    }

    public static void distributeNumbers(int number, ArrayList<Integer> pares, ArrayList<Integer> impares) {
        if (number % 2 == 0)
        {
            pares.add(number);
            return;
        }

        impares.add(number);
    }

    public static void printArrays(ArrayList<Integer> array){
        for (int i = 0; i < array.size(); i++)
        {
            System.out.println(array.get(i));
        }
    }
}
