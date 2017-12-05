import java.util.Scanner;

public class VowelorDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        if (input.equals("a") || input.equals("e") || input.equals("o") || input.equals("u") || input.equals("i") ){
            System.out.println("vowel");
        }
        else if (Character.isDigit(input.charAt(0))){
            System.out.println("digit");
        }
        else {
            System.out.println("other");
        }
    }
}
