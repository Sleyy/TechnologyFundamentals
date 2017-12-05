import java.util.Arrays;
import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int frequentStreak = 0;
        int longestStreak = 0;
        int frequentNumber = 0;
        for (int i = 0; i < numbers.length ; i++) {
            int currentNumber = numbers[i];
            for (int j = 0; j < numbers.length ; j++) {
                if (currentNumber==numbers[j]){
                    frequentStreak ++;
                    if (longestStreak < frequentStreak){
                        longestStreak = frequentStreak;
                        frequentNumber = currentNumber;
                    }
                }
            }
            frequentStreak = 0;
        }
        System.out.print(frequentNumber);



    }
}
