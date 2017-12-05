import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUpgrade {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");
        TreeMap<String, String> phonebook = new TreeMap<>();
        while (!input[0].equals("END")) {

            if (input[0].equals("ListAll")){
                for (String entry:phonebook.keySet()){
                    System.out.println(entry + " -> " + phonebook.get(entry));
                }
            }
            else if (input.length > 2) {
                String name = input[1];
                String phoneNumber = input[2];
                if (!phonebook.containsKey(name)) {
                    phonebook.put(name, phoneNumber);
                } else {
                    phonebook.put(name, phoneNumber);
                }

            } else {
                String name = input[1];
                if (phonebook.containsKey(name)) {
                    for (String entry : phonebook.keySet()) {
                        if (entry.equals(name)) {
                            System.out.println(entry + " -> " + phonebook.get(name));
                        }
                    }
                } else {
                    System.out.println("Contact " + name + " does not exist.");
                }
            }
            input = scanner.nextLine().split(" ");
        }


    }
}

