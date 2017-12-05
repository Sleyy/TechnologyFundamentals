import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        if (input.length()< 20) {
            int numberOfSymbols = 20 - input.length();
            for (int i = 1; i <= numberOfSymbols ; i++) {
                input = input.concat("*");
            }
        }
        else {
            input = input.substring(0,20);
        }
        System.out.println(input);
    }
}
