import java.util.Scanner;

public class ReverseCharacters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String result = "";
        String finalResult = "";
        for (int i = 0; i < 3 ; i++) {
            result+=scanner.nextLine();
        }
        for (int i = 2; i >= 0 ; i--) {
            finalResult += result.charAt(i);
        }

        System.out.println(finalResult);
    }
}
