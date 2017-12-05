import java.util.Arrays;
        import java.util.Scanner;

public class LargestThreeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        Arrays.sort(nums);
        int count = Math.min(nums.length,3);
        for (int i =nums.length-1 ; i >= nums.length-count; i--) {
            System.out.println(nums[i]);
        }
    }
}
