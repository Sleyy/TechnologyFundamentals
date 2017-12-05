import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] arrayOne = scanner.nextLine().split(" ");
        String[] arrayTwo = scanner.nextLine().split(" ");
        boolean isEqual = true;

        for (int i = 0; i < Math.min(arrayOne.length,arrayTwo.length) ; i++) {
            if (!arrayOne[i].equals(arrayTwo[i])){
                isEqual = false;
            }
        }
        if (isEqual){
            if (arrayOne.length <= arrayTwo.length) {
                System.out.println(String.join("",arrayOne));
                System.out.println(String.join("",arrayTwo));
            }
            else if (arrayTwo.length <= arrayOne.length){
                System.out.println(String.join("",arrayTwo));
                System.out.println(String.join("",arrayOne));
            }

        }
        else {
            if (arrayOne[0].charAt(0) <= arrayTwo[0].charAt(0)){
                System.out.println(String.join("",arrayOne));
                System.out.println(String.join("",arrayTwo));
            }
            else {
                System.out.println(String.join("",arrayTwo));
                System.out.println(String.join("",arrayOne));
            }
        }

        






    }
}
