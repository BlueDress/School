import java.util.Scanner;

public class URLParser {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String input = sc.nextLine();

        String protocol = "";
        String server = "";
        String resource = "";

        int indexForProtocol = input.indexOf("://");

        if (indexForProtocol > 0) {
            protocol = input.substring(0, indexForProtocol);
            input = input.substring(indexForProtocol + 3);
        }

        int indexForRecourse = input.indexOf("/");

        if (indexForRecourse > 0) {
            server = input.substring(0, indexForRecourse);
            resource = input.substring(indexForRecourse + 1);
        } else {
            server = input;
        }

        System.out.printf("[protocol] = \"%s\"", protocol);
        System.out.println();
        System.out.printf("[server] = \"%s\"", server);
        System.out.println();
        System.out.printf("[resource] = \"%s\"", resource);
        System.out.println();
    }
}
