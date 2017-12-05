import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numOne = scanner.nextInt();
        int numTwo = scanner.nextInt();
        int numThree = scanner.nextInt();

        if (numOne+numTwo == numThree){
            System.out.println(Math.min(numOne,numTwo)+ " + " + Math.max(numOne,numTwo) +  " = " + numThree);
        }
        else if (numOne+numThree == numTwo){
            System.out.println(Math.min(numOne,numThree)+ " + " + Math.max(numOne,numThree) +  " = " + numTwo);
        }
        else if (numThree+numTwo == numOne){
            System.out.println(Math.min(numThree,numTwo)+ " + " + Math.max(numThree,numTwo) +  " = " + numOne);
        }
        else{
            System.out.println("No");
        }

    }
}
