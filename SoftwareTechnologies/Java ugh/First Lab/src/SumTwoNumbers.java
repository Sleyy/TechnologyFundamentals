import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        float firstNum = Float.parseFloat(scanner.nextLine());
        float secondNum = Float.parseFloat(scanner.nextLine());

        float sum = firstNum + secondNum;
        System.out.println(sum);
    }
}
