import java.util.LinkedHashMap;
import java.util.Scanner;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");
        LinkedHashMap<String, String> phonebook = new LinkedHashMap<>();
        while (!input[0].equals("END")) {
            String name = input[1];
            if (input.length > 2) {
                String phoneNumber = input[2];
                if (!phonebook.containsKey(name)) {
                    phonebook.put(name, phoneNumber);
                } else {
                    phonebook.put(name, phoneNumber);
                }

            } else {
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

