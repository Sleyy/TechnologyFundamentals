import java.util.Scanner;

public class VariableinHexadecimalFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = Integer.parseInt(scanner.nextLine(), 16);
        System.out.println(number);
    }
}
