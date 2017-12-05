import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int equalStreak = 0;
        int longestStreak = 0;
        int longestNumber = 0;
        for (int i = 0; i < numbers.length-1 ; i++) {
            if (numbers[i] == numbers[i+1]){
                equalStreak++;
                if (longestStreak < equalStreak){
                    longestStreak = equalStreak;
                    longestNumber = numbers[i];
                }
            }
            else {
                equalStreak = 0;
            }
        }
        for (int i = 0; i <= longestStreak ; i++) {
            System.out.print(longestNumber+" ");
        }
    }
}
