import java.util.*;

public class SumsbyTown {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int num = Integer.parseInt(scanner.nextLine());
        TreeMap<String,Double> towns = new TreeMap<>();
        for (int i = 0; i < num; i++) {
            String[] input = scanner.nextLine().split("\\s+\\|\\s+");
            String town = input[0];
            double income = Double.parseDouble(input[1]);

            if (!towns.containsKey(town)){
                towns.put(town,income);
            }
            else  {
                towns.put(town , towns.get(town) + income);
            }

        }
        for (String town : towns.keySet()) {
            System.out.println(town + " -> " + towns.get(town));
        }
    }
}
