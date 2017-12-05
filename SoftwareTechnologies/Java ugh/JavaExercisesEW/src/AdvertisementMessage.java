import java.util.Random;
import java.util.Scanner;

public class AdvertisementMessage {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        String[] phrases = new String[]{"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product."};
        String[] events = new String[] {"Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
        String[] author = new String[]{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        String[] cities = new String[]{"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

        int numberOfMessages = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i <numberOfMessages ; i++) {
            Random random = new Random();
            int randomPhrase = random.nextInt(phrases.length-1);
            int randomEvent =  random.nextInt(events.length-1);
            int randomAuthor =  random.nextInt(author.length-1);
            int randomCity =  random.nextInt(cities.length-1);
            System.out.println(phrases[randomPhrase]+events[randomEvent]+author[randomAuthor]+cities[randomCity]);
        }

    }
}
