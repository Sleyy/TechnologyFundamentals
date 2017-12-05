import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        ArrayList<String> numbers = new ArrayList<>(Arrays.asList(scanner.nextLine().split(" ")));
        int[] actions = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        String specialNum = Integer.toString(actions[0]);
        int power = actions[1];

        for (int i = 0; i < numbers.size(); i++) {
            if (numbers.get(i).equals(specialNum)){
                int left = Math.min(power , i);
                int right = Math.min(power ,numbers.size()-1-i);
                int detonate = left+1+right;
                int epicenter = numbers.indexOf(specialNum)-left;
                for (int j = 0; j < detonate ; j++) {
                    numbers.remove(epicenter);
                }
                i--;
            }
        }
        int sum = 0;
        for (int i = 0; i < numbers.size() ; i++) {
            sum += Integer.parseInt(numbers.get(i));
            }
        System.out.println(sum);


    }
}
