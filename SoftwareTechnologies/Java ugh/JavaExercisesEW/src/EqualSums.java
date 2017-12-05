import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        boolean numberFound = false;
        for (int i = 0; i <numbers.length ; i++) {
            int currentNumber = numbers[i];
            int leftSum = 0;
            int rightSum = 0;
            if (i == 0){
                leftSum = 0;
            }
            else {
                for (int j = 0; j < i; j++) {
                    leftSum+=numbers[j];
                }
            }
            if (i==numbers.length-1){
                rightSum = 0;
            }
            else {
                for (int j = i+1; j < numbers.length ; j++) {
                    rightSum+=numbers[j];
                }
            }
            if (leftSum == rightSum){
                System.out.println(i);
                numberFound = true;
                break;
            }
        }
        if (!numberFound){
            System.out.println("no");
        }
    }
}
