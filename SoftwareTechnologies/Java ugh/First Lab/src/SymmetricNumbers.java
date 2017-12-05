import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i <= n; i++) {
            String currentNum = Integer.toString(i);
            boolean isSymetric = true;
            for (int j = 0; j < currentNum.length()/2 ; j++) {
                if (currentNum.charAt(j) != currentNum.charAt(currentNum.length()-1-j)) {
                    isSymetric = false;
                }
            }
            if (isSymetric){
                System.out.println(i);
            }
        }
    }
}
