import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        StringBuilder input = new StringBuilder(scanner.nextLine());
        String server = "";
        String protocol = "";
        String resource = "";
        int indexAfterProtocol = input.indexOf("://");
        if (indexAfterProtocol != -1) {
            protocol = input.substring(0, indexAfterProtocol);
            input.delete(0, indexAfterProtocol + 3);
            int leftMostSlash = input.indexOf("/");
            if (leftMostSlash != -1) {
                server = input.substring(0, leftMostSlash);
                resource = input.substring(leftMostSlash + 1, input.length());
            } else {
                server = input.toString();
            }


        } else {
            int leftMostSlash = input.indexOf("/");
            if (leftMostSlash != -1) {
                server = input.substring(0, leftMostSlash);
                resource = input.substring(leftMostSlash + 1, input.length());
            } else {
                server = input.toString();
            }
        }
        System.out.println("[protocol] = \"" + protocol + "\"");
        System.out.println("[server] = \"" + server + "\"");
        System.out.println("[resource] = \"" + resource + "\"");
    }
}
