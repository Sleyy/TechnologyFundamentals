import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        StringBuilder input = new StringBuilder(scanner.nextLine());

        int indexOfUpcaseStart = input.indexOf("<upcase>");
        int indexOfUpcaseEnd = input.indexOf("</upcase>");

        while(indexOfUpcaseStart != -1 && indexOfUpcaseEnd != -1){
            String toUpper = input.substring(indexOfUpcaseStart+8,indexOfUpcaseEnd).toUpperCase();
            input.replace(indexOfUpcaseStart,indexOfUpcaseEnd+9, toUpper);

            indexOfUpcaseStart = input.indexOf("<upcase>");
            indexOfUpcaseEnd = input.indexOf("</upcase>");
        }
        System.out.println(input);
    }
}
