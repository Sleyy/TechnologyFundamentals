import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

            String email = scanner.nextLine();
            String text = scanner.nextLine();

            int atIndex = email.indexOf("@");
            String user = email.substring(0,atIndex);
            String domain = email.substring(atIndex,email.length());

        for (int i = 0; i <= user.length()-1 ; i++) {
            user = user.replace(user.charAt(i),'*');
        }
       String newEmail = user+domain;
        text = text.replaceAll(email,newEmail);
        System.out.println(text);


    }
}
